using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CodeGenerator
{
    class CodeGenerator
    {
        string filePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
        List<string> fields = new List<string>();
        
        // constructor
        public CodeGenerator() { }
        public CodeGenerator(string strPath)
        {
            this.filePath = strPath;
        }

        public void Execute()
        {
			string strSolutionName = "DBFrameWork";
			string path = this.filePath.Replace("file:\\", "");
			path = path.Substring(0, path.IndexOf(strSolutionName) + strSolutionName.Length);
			path += "\\Test\\DBFrameWork.cs";
			FileStream fs = File.Create(path);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            this.AddUsing(sw);

            DataTable tables = this.GetTables();
            if (tables.Rows.Count == 0) { return; }
            string tableQualifier = tables.Rows[0]["TABLE_QUALIFIER"].ToString();
            
			this.AddNamespace(sw, tableQualifier);

			this.AddSharedObject(sw);

			this.AddBaseObject(sw);

            foreach (DataRow oRow in tables.Rows)
            {
                string tableName = oRow["TABLE_NAME"].ToString();
                
				this.AddClass(sw, tableName, 1);

                this.AddWhereObject(sw, tableName, 2);

				this.AddCommandObject(sw, tableName, 2);

				this.AddOperatorObject(sw, tableName, 2);

                this.EndClassOrNamespace(sw, 1);
            }
            // DBAdapter
            AddDBAdapter(sw);
            // End
            this.EndClassOrNamespace(sw, 0);

            sw.Flush();
            fs.Close();
        }

        private void AddUsing(StreamWriter sw)
        {
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Data;");
            sw.WriteLine("using System.Linq;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.Data.SqlClient;");
            sw.WriteLine("using System.Reflection;");
            sw.WriteLine();
        }

        private void AddNamespace(StreamWriter sw, string ns)
        {
            sw.WriteLine("namespace " + ns);
            sw.WriteLine("{");
        }

		private void AddSharedObject(StreamWriter sw)
		{
			sw.WriteLine();
			sw.WriteLine("#region Share Object");
			sw.Write(@"
	public enum DatabaseAction
	{
		Insert = 0,
		Update = 1,
		Delete = 2
	}
			");
			sw.WriteLine("#endregion");
			sw.WriteLine();
		}
		private void AddBaseObject(StreamWriter sw)
		{
			sw.Write(Tab(1) + "#region Base Object");
			AddFieldBaseObject(sw);
			AddTableClassBase(sw);
			AddWhereObjectBase(sw);
			sw.WriteLine(Tab(1) + "#endregion");
			sw.WriteLine();
		}

		private void AddFieldBaseObject(StreamWriter sw)
		{
			sw.WriteLine();
			sw.Write( Tab(1) );
			sw.WriteLine("public class FieldObjectBase");
			sw.Write( Tab(1) );
			sw.WriteLine("{");
			sw.Write( Tab(2) );
			sw.WriteLine( "protected string FieldName = string.Empty;" );
			sw.Write(Tab(2));
			sw.WriteLine("protected Object FieldValue = null;");
			sw.Write(Tab(2));
			sw.WriteLine("protected string CurrentOperator = string.Empty;");
			sw.Write(Tab(2));
			sw.WriteLine("protected FieldObjectBase() { }");
			sw.Write(Tab(2));
			sw.WriteLine("public FieldObjectBase(string fldName)");
			sw.Write(Tab(2));
			sw.WriteLine("{");
			sw.Write(Tab(3));
			sw.WriteLine("this.FieldName = fldName;");
			sw.Write(Tab(2));
			sw.WriteLine("}");

			string t2 = Tab(1);

			sw.WriteLine();
			sw.WriteLine(t2 + "\tprotected string ToQueryString()");
			sw.WriteLine(t2 + "\t{");
			sw.WriteLine(t2 + "\t\tstring queryString = string.Empty;");
			sw.WriteLine(t2 + "\t\tif (FieldValue.GetType() == typeof(string))");
			sw.WriteLine(t2 + "\t\t{");
			sw.WriteLine(t2 + "\t\t\tstring _fieldValue = FieldValue.ToString().Replace(\"'\", \"''\");");
			sw.WriteLine(t2 + "\t\t\tstring queryStringFormat = \"({0} {1} '{2}')\";");
			sw.WriteLine(t2 + "\t\t\tif (CurrentOperator.ToUpper() == \"LIKE\")");
			sw.WriteLine(t2 + "\t\t\t{");
			sw.WriteLine(t2 + "\t\t\t\tqueryStringFormat = \"({0} {1} '%{2}%')\";");
			sw.WriteLine(t2 + "\t\t\t}");
			sw.WriteLine(t2 + "\t\t\tqueryString = string.Format(queryStringFormat, FieldName, CurrentOperator, _fieldValue);");
			sw.WriteLine(t2 + "\t\t}");
			sw.WriteLine(t2 + "\t\telse");
			sw.WriteLine(t2 + "\t\t{");
			sw.WriteLine(t2 + "\t\t\tif (CurrentOperator.ToUpper() == \"LIKE\")");
			sw.WriteLine(t2 + "\t\t\t{");
			sw.WriteLine(t2 + "\t\t\t\tCurrentOperator = \"<=\";");
			sw.WriteLine(t2 + "\t\t\t}");
			sw.WriteLine(t2 + "\t\t\tqueryString = string.Format(\"({0} {1} {2})\", FieldName, CurrentOperator, FieldValue);");
			sw.WriteLine(t2 + "\t\t}");
			sw.WriteLine(t2 + "\t\treturn queryString;");
			sw.WriteLine(t2 + "\t}");
			sw.WriteLine();


			// And Class
			sw.Write(Tab(1));
			sw.WriteLine("}");
		}

		private void AddTableClassBase(StreamWriter sw)
		{
			sw.WriteLine();
			sw.Write(Tab(1));
			sw.WriteLine("public class TableClassBase");
			sw.Write(Tab(1));
			sw.WriteLine("{");
			sw.Write(Tab(2));
			sw.WriteLine("protected bool IsUpdate = false;");
			sw.Write(Tab(2));
			sw.WriteLine("protected DatabaseAction DbAction = DatabaseAction.Insert;");
			sw.Write(Tab(2));
			sw.WriteLine("protected string _lastWhere = string.Empty;");
			sw.Write(Tab(2));
			sw.WriteLine("public string LastWhere");
			sw.Write(Tab(2));
			sw.WriteLine("{");
			sw.Write(Tab(3));
			sw.WriteLine("protected get { return _lastWhere; }");
			sw.Write(Tab(3));
			sw.WriteLine("set");
			sw.Write(Tab(3));
			sw.WriteLine("{");
			sw.Write(Tab(4));
			sw.WriteLine("if (String.IsNullOrEmpty(_lastWhere))");
			sw.Write(Tab(4));
			sw.WriteLine("{");
			sw.Write(Tab(5));
			sw.WriteLine("_lastWhere = \" WHERE \";");	
			sw.Write(Tab(4));
			sw.WriteLine("}");
			sw.Write(Tab(4));
			sw.WriteLine("_lastWhere += value;");
			sw.Write(Tab(3));
			sw.WriteLine("}");
			sw.Write(Tab(2));
			sw.WriteLine("}");
			// And Class
			sw.Write(Tab(1));
			sw.WriteLine("}");
		}

		private void AddWhereObjectBase(StreamWriter sw)
		{
			sw.WriteLine();
			sw.Write(Tab(1));
			sw.WriteLine("public class WhereObjectBase");
			sw.Write(Tab(1));
			sw.WriteLine("{");
			sw.Write(Tab(2));
			sw.WriteLine("public TableClassBase Parent;");
			sw.WriteLine();
			sw.Write(Tab(2));
			sw.WriteLine("public WhereObjectBase(TableClassBase tblClassBase)");
			sw.Write(Tab(2));
			sw.WriteLine("{");
			sw.Write(Tab(3));
			sw.WriteLine("this.Parent = tblClassBase;");
			sw.Write(Tab(2));
			sw.WriteLine("}");
			// And Class
			sw.Write(Tab(1));
			sw.WriteLine("}");
		}

        private void AddClass(StreamWriter sw, string className, int tabCount)
        {
			string tab = Tab(tabCount)
				, tab1 = Tab(tabCount + 1)
				, tab2 = Tab(tabCount + 2)
				, tab3 = Tab(tabCount + 3)
				, tab4 = Tab(tabCount + 4);
			
			sw.Write(this.Tab(tabCount));
            sw.WriteLine(String.Format("public class {0} : TableClassBase", className));
            sw.Write(this.Tab(tabCount));
			sw.WriteLine("{");
			sw.Write(tab1);
			sw.WriteLine(string.Format("public static string TableName = \"{0}\";", className));

            // where
            this.AddWhere(sw, className, tabCount + 1);

			// update
			this.AddUpdate(sw, className, tabCount + 1);
			// Delete
			this.AddDelete(sw, className, tabCount + 1);

            // properties
            this.AddProperties(sw, className, tabCount + 1);

            // Fields
            this.AddFields(sw, tabCount + 1);

            // method
            this.AddMethods(sw, tabCount + 1);
        }

        private void AddProperties(StreamWriter sw, string tableName, int tab)
        {
            this.fields.Clear();

            sw.WriteLine(this.Tab(tab) + "#region Properties");
            DataTable oTable = DB.GetColumns(tableName);
            foreach (DataRow oRow in oTable.Rows)
            {
                sw.Write(this.Tab(tab));
                sw.WriteLine("public object " + oRow["COLUMN_NAME"] + " { get; set; }");
                // cache a field for later use
                this.fields.Add(oRow["COLUMN_NAME"].ToString());
            }
            sw.WriteLine(this.Tab(tab) + "#endregion");
            sw.WriteLine("");
        }

        private void AddWhere(StreamWriter sw, string tableName, int tab)
        {
            string t = this.Tab(tab);
            string t1 = this.Tab(tab + 1);
            string t2 = this.Tab(tab + 2);
            string whereObject = string.Format("{0}WhereObject", tableName);

            sw.WriteLine(t + "#region Where");
            sw.WriteLine(t + string.Format("private {0} _whereObject = null;", whereObject));
            sw.WriteLine(t + string.Format("protected {0} Where", whereObject));
            sw.WriteLine(t + "{");
            sw.WriteLine(t1 + "get");
            sw.WriteLine(t1 + "{");
            sw.WriteLine(t2 + "if (_whereObject == null)");
            sw.WriteLine(t2 + "{");
            sw.WriteLine(t2 + string.Format("\t_whereObject = new {0}(this);", whereObject));
            sw.WriteLine(t2 + "}");
            sw.WriteLine(t2 + "return _whereObject;");
            sw.WriteLine(t1 + "}");
            sw.WriteLine(t + "}");
            sw.WriteLine(t + "#endregion");
            sw.WriteLine();
        }

		private void AddUpdate(StreamWriter sw, string tableName, int tab)
		{
			string t = this.Tab(tab);
			string t1 = this.Tab(tab + 1);
			string t2 = this.Tab(tab + 2);
			string updateObject = string.Format("{0}UpdateObject", tableName);

			sw.WriteLine(t + "#region Update");
			sw.WriteLine(t + string.Format("private {0} _updateObject = null;", updateObject));
			sw.WriteLine(t + string.Format("public {0} Update", updateObject));
			sw.WriteLine(t + "{");
			sw.WriteLine(t1 + "get");
			sw.WriteLine(t1 + "{");
			sw.WriteLine(t2 + "if (_updateObject == null)");
			sw.WriteLine(t2 + "{");
			sw.WriteLine(t2 + string.Format("\t_updateObject = new {0}(Where);", updateObject));
			sw.WriteLine(t2 + "}");
			sw.WriteLine(t2 + "IsUpdate = true;");
			sw.WriteLine(t2 + "return _updateObject;");
			sw.WriteLine(t1 + "}");
			sw.WriteLine(t + "}");
			sw.WriteLine(t + "#endregion");
			sw.WriteLine();
		}

		private void AddDelete(StreamWriter sw, string tableName, int tab)
		{
			string t = this.Tab(tab);
			string t1 = this.Tab(tab + 1);
			string t2 = this.Tab(tab + 2);
			string deleteObject = string.Format("{0}DeleteObject", tableName);

			sw.WriteLine(t + "#region Update");
			sw.WriteLine(t + string.Format("private {0} _deleteObject = null;", deleteObject));
			sw.WriteLine(t + string.Format("public {0} Delete", deleteObject));
			sw.WriteLine(t + "{");
			sw.WriteLine(t1 + "get");
			sw.WriteLine(t1 + "{");
			sw.WriteLine(t2 + "if (_deleteObject == null)");
			sw.WriteLine(t2 + "{");
			sw.WriteLine(t2 + string.Format("\t_deleteObject = new {0}(Where);", deleteObject));
			sw.WriteLine(t2 + "}");
			sw.WriteLine(t2 + "return _deleteObject;");
			sw.WriteLine(t1 + "}");
			sw.WriteLine(t + "}");
			sw.WriteLine(t + "#endregion");
			sw.WriteLine();
		}

		private void AddCommandObject(StreamWriter sw, string prefix, int tab)
		{
			AddCommandObjectInner(sw, prefix, tab, "Update");
			AddCommandObjectInner(sw, prefix, tab, "Insert");
			AddCommandObjectInner(sw, prefix, tab, "Delete");
			AddCommandObjectInner(sw, prefix, tab, "Select");
		}

		private void AddCommandObjectInner(StreamWriter sw, string tableName, int tab, string cmdName)
		{
			string t = this.Tab(tab);
			string t2 = this.Tab(tab + 1);
			string t3 = this.Tab(tab + 2);

			cmdName = cmdName.First().ToString().ToUpper() + cmdName.Substring(1).ToLower();
			sw.WriteLine(t + string.Format("#region {0} Command Object", cmdName));
			sw.WriteLine(t + string.Format("public class {0}{1}Object", tableName, cmdName));
			sw.WriteLine(t + "{");
			sw.WriteLine(t2 + string.Format("public readonly {0}WhereObject _whereObject = null;", tableName));
			sw.WriteLine(t + string.Format("\tprotected {0}{1}Object() ", tableName, cmdName) + "{}");
			sw.WriteLine(t + string.Format("\tpublic {0}{1}Object({0}WhereObject whereObj) ", tableName, cmdName) + "{ this._whereObject = whereObj; }");
			sw.WriteLine();
			sw.WriteLine(t2 + string.Format("public {0}WhereObject Where", tableName));
			sw.WriteLine(t2 + "{");
			sw.WriteLine(t3 + "get { return this._whereObject; }");
			sw.WriteLine(t2 + "}");
			sw.WriteLine(t + "}");
			sw.WriteLine(t + "#endregion");
			sw.WriteLine();
		}

		private void AddOperatorObject(StreamWriter sw, string prefix, int tab)
		{
			string t = this.Tab(tab);
			string t2 = this.Tab(tab + 1);
			string t3 = this.Tab(tab + 2);
			string t4 = this.Tab(tab + 3);

			sw.WriteLine(t + "#region Operator Object");
			sw.WriteLine(t + string.Format("public class {0}OperatorObject", prefix));
			sw.WriteLine(t + "{");
			sw.WriteLine(t2 + string.Format("private {0}WhereObject _whereObject = null;", prefix));
			sw.WriteLine(t2 + string.Format("protected {0}OperatorObject() ", prefix) + "{}");
			sw.WriteLine(t2 + string.Format("public {0}OperatorObject({0}WhereObject whereObj) ", prefix) + "{ this._whereObject = whereObj; }");
			sw.WriteLine();
			sw.WriteLine(t2 + string.Format("public {0}WhereObject Where", prefix));
			sw.WriteLine(t2 + "{");
			sw.WriteLine(t3 + "get { return this._whereObject; }");
			sw.WriteLine(t2 + "}");
			// OR
			AddOperatorObjectInner(sw, prefix, tab + 1, "OR");
			// AND
			AddOperatorObjectInner(sw, prefix, tab + 1, "AND");

			sw.WriteLine(t + "}");
			sw.WriteLine(t + "#endregion");
			sw.WriteLine();
		}

		private void AddOperatorObjectInner(StreamWriter sw, string tableName, int tab, String andOr)
		{
			if (String.IsNullOrEmpty(andOr.Trim()))
			{
				return;
			}
			string t2 = Tab(tab)
				, t3 = Tab(tab + 1)
				, t4 = Tab(tab + 2);
			string andOrFunc = andOr.Trim().ToLower();
			andOrFunc = andOrFunc.First().ToString().ToUpper() + andOrFunc.Substring(1);
			sw.WriteLine("");
			sw.WriteLine(string.Format("{0}public {1}WhereObject {2}", t2, tableName, andOrFunc));
			sw.Write(t2);
			sw.WriteLine("{");
			sw.Write(t3);
			sw.WriteLine("get");
			sw.Write(t3);
			sw.WriteLine("{");
			sw.Write(t4);
			sw.WriteLine("this._whereObject.Parent.LastWhere = \" " + andOr.Trim() + " \";");
			sw.Write(t4);
			sw.WriteLine("return this._whereObject;");
			sw.Write(t3);
			sw.WriteLine("}");
			sw.Write(t2);
			sw.WriteLine("}");
		}

        private void AddMethods(StreamWriter sw, int tabCount)
        {
            sw.Write(this.Tab(tabCount));
            sw.WriteLine("#region Methods");
			sw.Write(this.Tab(tabCount));
			sw.Write("public Int32 Save()");
			sw.Write(@"
	{
		if (DbAction == DatabaseAction.Insert)
		{
			return DBAdapter.Insert(this);
		}
		else if (DbAction == DatabaseAction.Update)
		{
			DBAdapter.Update(this);
		}
		else
		{
			DBAdapter.Delete(this);
		}
		return 0;
	}
");

            /*
			sw.Write(this.Tab(tabCount));
			sw.WriteLine("public Int32 Save()");
			sw.Write(this.Tab(tabCount));
			sw.WriteLine("{");
			sw.Write(this.Tab(tabCount + 1));
			sw.WriteLine("if(!IsUpdate)");
			sw.Write(this.Tab(tabCount + 1));
			sw.WriteLine("{");
			sw.Write(this.Tab(tabCount + 2));
			sw.WriteLine("return DBAdapter.Insert(this);");
			sw.Write(this.Tab(tabCount + 1));
			sw.WriteLine("}");
			sw.Write(this.Tab(tabCount + 1));
			sw.WriteLine("else");
			sw.Write(this.Tab(tabCount + 1));
			sw.WriteLine("{");
			sw.Write(this.Tab(tabCount + 2));
			sw.WriteLine("DBAdapter.Update(this);");
			sw.Write(this.Tab(tabCount + 1));
			sw.WriteLine("}");
			sw.Write(this.Tab(tabCount + 1));
			sw.WriteLine("return 0;");
			sw.Write(this.Tab(tabCount));
			sw.WriteLine("}");
			*/

            //sw.Write(this.Tab(tabCount));
            //sw.WriteLine("public void UpdateEx() { DBAdapter.Update(this); }");

			sw.WriteLine();
			sw.Write(this.Tab(tabCount));
            sw.WriteLine(@"public void DeleteEx()
		{
			DBAdapter.Delete(this);
		}");
			sw.WriteLine();

			sw.WriteLine();
			sw.Write(this.Tab(tabCount));
            sw.WriteLine(@"public DataSet Select()
		{
			return DBAdapter.Select(this);
		}");
			sw.WriteLine();

            sw.Write(this.Tab(tabCount));
            sw.WriteLine("#endregion");
            sw.WriteLine();
        }

        private void AddFields(StreamWriter sw, int tabCount)
        {
            List<string> _fieldList = new List<string>();
            sw.Write(this.Tab(tabCount));
            sw.WriteLine("public static class Fields");
            sw.WriteLine(this.Tab(tabCount) + "{");
            foreach (string field in this.fields)
            {
                sw.WriteLine(this.Tab(tabCount + 1) + string.Format("public const string {0} = \"{0}\";", field));
                _fieldList.Add(string.Format("Fields.{0}", field));
            }
            sw.WriteLine(this.Tab(tabCount) + "}");
            sw.WriteLine(this.Tab(tabCount) + "public static string[] FieldList = {" + String.Join(", ",_fieldList.ToArray()) + "};");
            sw.WriteLine();
        }

        private void EndClassOrNamespace(StreamWriter sw, int tabCount)
        {
            sw.Write(this.Tab(tabCount));
            sw.WriteLine("}");
        }

        /// <summary>
        /// Where Object
        /// </summary>
        /// <param name="sw">StreamWriter</param>
        /// <param name="prefix">It should be a table name</param>
        /// <param name="tab">How many tab before each line of code</param>
        private void AddWhereObject(StreamWriter sw, string prefix, int tab)
        {
            string t = this.Tab(tab);
            string t2 = this.Tab(tab + 1);

            sw.WriteLine(t + "#region Where Object");
			sw.WriteLine(t + string.Format("public class {0}WhereObject : WhereObjectBase", prefix));
            sw.WriteLine(t + "{");
            //sw.WriteLine(t + string.Format("\tpublic readonly {0} Parent = null;", prefix));
            //sw.WriteLine(t + string.Format("\tprotected {0}WhereObject()", prefix) + "{ }");
            sw.WriteLine(t + string.Format("\tpublic {0}WhereObject({0} parent) : base(parent)", prefix) + " { }");
            sw.WriteLine();
            
            foreach (string field in fields)
            {
                sw.WriteLine(t2 + string.Format("private {0}Object _{0} = null;", field));
                sw.WriteLine(t2 + "public {0}Object {0}", field);
                sw.WriteLine(t2 + "{");
                sw.WriteLine(t2 + "\tget");
                sw.WriteLine(t2 + "\t{");
                sw.WriteLine(t2 + string.Format("\t\tif (_{0} == null)", field));
                sw.WriteLine(t2 + "\t\t{");
                sw.WriteLine(t2 + string.Format("\t\t\t_{0} = new {0}Object(this);", field));
                sw.WriteLine(t2 + "\t\t}");
                sw.WriteLine(t2 + string.Format("\t\treturn _{0};", field));
                sw.WriteLine(t2 + "\t}");
                sw.WriteLine(t2 + "}");
                sw.WriteLine();
            }
            sw.WriteLine(t2 + "#region Each field object");
            foreach (string field in fields)
            {
                this.AddFieldObject(sw, field, prefix, tab + 1);
                sw.WriteLine();
            }
            sw.WriteLine(t2 + "#endregion");
            sw.WriteLine(t + "}");
            sw.WriteLine(t + "#endregion");
            sw.WriteLine();
        }

        private void AddFieldObject(StreamWriter sw, string fieldName, string parent, int tab)
        {
            string t2 = this.Tab(tab);
            sw.WriteLine(t2 + string.Format("public class {0}Object : FieldObjectBase", fieldName));
            sw.WriteLine(t2 + "{");
			sw.WriteLine(t2 + string.Format("\t{0}OperatorObject _operator = null;", parent));
			sw.WriteLine();

            sw.WriteLine(t2 + string.Format("\tpublic readonly {0}WhereObject Parent = null;", parent));
            sw.WriteLine(t2 + string.Format("\tprotected {0}Object() ", fieldName) + "{ }");
			sw.WriteLine(t2 + string.Format("\tpublic {0}Object({1}WhereObject parent): base(\"{0}\") ", fieldName, parent));
			sw.WriteLine(t2 + "\t{");
			sw.WriteLine(t2 + "\t\tthis.Parent = parent;");
			sw.WriteLine(t2 + string.Format("\t\tthis._operator = new {0}OperatorObject(this.Parent);", parent));
			sw.WriteLine(t2 + "\t}");

			AddFieldObjectInner(sw, tab, parent, "Equal", "=");
			AddFieldObjectInner(sw, tab, parent, "LessThan", "<");
			AddFieldObjectInner(sw, tab, parent, "LessThanEqual", "<=");
			AddFieldObjectInner(sw, tab, parent, "GreaterThan", ">");
			AddFieldObjectInner(sw, tab, parent, "GreaterThanEqual", ">=");
			AddFieldObjectInner(sw, tab, parent, "Like", "LIKE");
            // End Class
            sw.WriteLine(t2 + "}");
        }

		private void AddFieldObjectInner(StreamWriter sw, int tab, string tblName, string strFunc, string strOperator)
		{
			string t2 = this.Tab(tab);

			sw.WriteLine();
			sw.WriteLine(t2 + string.Format("\tpublic {0}OperatorObject {1}(Object value)", tblName, strFunc));
			sw.WriteLine(t2 + "\t{");
			sw.WriteLine(t2 + "\t\tFieldValue = value;");
			sw.WriteLine(t2 + string.Format("\t\tCurrentOperator = \"{0}\";", strOperator.ToUpper()));
			sw.WriteLine(t2 + "\t\tthis.Parent.Parent.LastWhere = ToQueryString();");
			sw.WriteLine(t2 + "\t\treturn _operator;");
			sw.WriteLine(t2 + "\t}");
		}

        private void AddDBAdapter(StreamWriter sw)
        {
            string strDBAdapter = @"
    #region DBAdapter
    public class DBAdapter
    {
        public static string mConStr = ""Data Source=CBVN-PC046\\SQLEXPRESS;Initial Catalog=DBGenerator;Persist Security Info=True;Integrated Security=True"";

        public static Int32 Insert(Object obj)
        {
            Type t = obj.GetType();
            string strTableName = t.Name;
            PropertyInfo[] propertyInfos = t.GetProperties();
            string[] fields = (string[])t.GetField(""FieldList"").GetValue(obj);
            List<string> fieldsVal2Insert = new List<string>(fields.Length);
            List<string> field2Insert = new List<string>(fields.Length);
            foreach (PropertyInfo pi in propertyInfos)
            {
                if (fields.Contains(pi.Name))
                {
                    string value = DBAdapter.GetValue(pi.GetValue(obj, null));
                    if (value.Length == 0) { continue; }
                    field2Insert.Add(pi.Name);
                    fieldsVal2Insert.Add(value);
                }
            }
            string strField = String.Join("", "", field2Insert.ToArray());
            string strValue = String.Join("", "", fieldsVal2Insert.ToArray());

            string strInsertFormat = ""INSERT INTO {0} ({1}) VALUES ({2}); SELECT SCOPE_IDENTITY() AS LastID;"";
            string sql = string.Format(strInsertFormat, strTableName, strField, strValue);
            return DBAdapter.ExecQuery(sql);
        }

        public static void Update(Object obj)
        {
            Type t = obj.GetType();
            string strTableName = t.Name;
            PropertyInfo[] propertyInfos = t.GetProperties();
            string strWhere = t.GetProperty(""LastWhere"").GetValue(obj, null) + string.Empty;
            if (strWhere.Length == 0)
            {
                throw new ArgumentNullException(""ArgumentNullException: Where"");
            }
            string[] fields = (string[])t.GetField(""FieldList"").GetValue(obj);
            List<string> updateSets = new List<string>(fields.Length);
            foreach (PropertyInfo pi in propertyInfos)
            {
                if (fields.Contains(pi.Name))
                {
                    string value = DBAdapter.GetValue(pi.GetValue(obj, null), null);
                    if (value == null) { continue; }
                    if (value.Length == 0) { value = ""''""; }
                    updateSets.Add(string.Format(""{0} = {1}"", pi.Name, value));
                }
            }

            string strSqlFormat = ""UPDATE {0} SET {1} {2}"";
            string sql = string.Format(strSqlFormat, strTableName, String.Join("", "", updateSets.ToArray()), strWhere);
            DBAdapter.ExecQuery(sql);
        }

        public static void Delete(Object obj)
        {
            Type t = obj.GetType();
            string strTableName = (string)t.GetField(""TableName"").GetValue(obj);
            string strWhere = t.GetProperty(""LastWhere"").GetValue(obj, null) + string.Empty;
            if (strWhere.Length == 0)
            {
                throw new ArgumentNullException(""ArgumentNullException: Where"");
            }
            string sql = string.Format(""DELETE FROM {0} {1}"", strTableName, strWhere);
            DBAdapter.ExecQuery(sql);
        }

        public static DataSet Select(Object obj)
        {
            Type t = obj.GetType();
            string[] fields = (string[])t.GetField(""FieldList"").GetValue(obj);
            string strTableName = (string)t.GetField(""TableName"").GetValue(obj);
            string strWhere = t.GetProperty(""LastWhere"").GetValue(obj, null) + string.Empty;
            string sql = string.Format(""Select {0} From {1} {2}"", String.Join("", "", fields), strTableName, strWhere);
            return DBAdapter.GetDataSet(sql);
        }

        // return empty if @param value is null
        private static String GetValue(Object value)
        {
            String ret = """";
            if (value == null) { return ret; }
            if (value.GetType() == typeof(string))
            {
                ret = ""'"" + value.ToString().Replace(""'"", ""''"") + ""'"";
            }
            else
            {
                ret = value.ToString();
            }
            return ret;
        }

        // return a defaultValue if @param value is null
        private static String GetValue(Object value, String defaultValue)
        {
            if (value == null) { return defaultValue; }
            return GetValue(value);
        }

        private static SqlConnection getCon()
        {
            SqlConnection con = new SqlConnection(mConStr);
            con.Open();
            return con;
        }
        private static Int32 ExecQuery(String sql)
        {

            SqlConnection con = getCon();
            SqlCommand cmd = new SqlCommand(sql, con);
           //cmd.ExecuteNonQuery();
			object returnResult = cmd.ExecuteScalar();
            con.Close();
			if (returnResult == null || returnResult is DBNull)
			{
				return 0;
			}
			return Convert.ToInt32(returnResult);

        }
        private static DataSet GetDataSet(String sql)
        {

            SqlConnection con = getCon();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();

            da.SelectCommand = cmd;
            da.Fill(ds);
            con.Close();

            return ds;
        }
    }
    #endregion
";
            sw.WriteLine(strDBAdapter);
        }

        #region Get Tables
        private DataTable GetTables()
        {
            return DB.GetTables();
        }
        #endregion

        #region Tabs
        private string Tab(int howMany)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < howMany; i++)
            {
                sb.Append("\t");
            }
            return sb.ToString();
        }
        #endregion
    }
}
