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
            FileStream fs = File.Create(this.filePath.Replace("file:\\","") + "..\\..\\..\\DBFrameWork.cs");
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            this.AddUsing(sw);

            DataTable tables = this.GetTables();
            if (tables.Rows.Count == 0) { return; }
            string tableQualifier = tables.Rows[0]["TABLE_QUALIFIER"].ToString();
            this.AddNamespace(sw, tableQualifier);
            foreach (DataRow oRow in tables.Rows)
            {
                string tableName = oRow["TABLE_NAME"].ToString();

                this.AddClass(sw, tableName, 1);

                this.AddWhereObject(sw, tableName, 2);

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

        private void AddClass(StreamWriter sw, string className, int tabCount)
        {
            sw.Write(this.Tab(tabCount));
            sw.WriteLine("public class " + className);
            sw.Write(this.Tab(tabCount));
            sw.WriteLine("{");
            sw.WriteLine(this.Tab(tabCount) + string.Format("\tpublic static string TableName = \"{0}\";", className));
            sw.WriteLine(this.Tab(tabCount) + "\tpublic string LastWhere { protected get; set; }");
            // where
            this.AddWhere(sw, className, tabCount + 1);
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
            sw.WriteLine(t + string.Format("public {0} Where", whereObject));
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

        private void AddMethods(StreamWriter sw, int tabCount)
        {
            sw.Write(this.Tab(tabCount));
            sw.WriteLine("#region Methods");
            sw.Write(this.Tab(tabCount));
            sw.WriteLine("public void Insert() { DBAdapter.Insert(this); }");
            sw.Write(this.Tab(tabCount));
            sw.WriteLine("public void Update() { DBAdapter.Update(this); }");
            sw.Write(this.Tab(tabCount));
            sw.WriteLine("public void Delete() { DBAdapter.Delete(this); }");
            sw.Write(this.Tab(tabCount));
            sw.WriteLine("public DataSet Select() { return DBAdapter.Select(this); }");
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
            sw.WriteLine(t + string.Format("public class {0}WhereObject", prefix));
            sw.WriteLine(t + "{");
            sw.WriteLine(t + string.Format("\tpublic readonly {0} Parent = null;", prefix));
            sw.WriteLine(t + string.Format("\tprotected {0}WhereObject()", prefix) + "{ }");
            sw.WriteLine(t + string.Format("\tpublic {0}WhereObject({0} parent)", prefix) + "{ this.Parent = parent; }");
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
            sw.WriteLine(t2 + string.Format("public class {0}Object", fieldName));
            sw.WriteLine(t2 + "{");
            sw.WriteLine(t2 + string.Format("\tpublic readonly {0}WhereObject Parent = null;", parent));
            sw.WriteLine(t2 + string.Format("\tprotected {0}Object() ", fieldName) + "{ }");
            sw.WriteLine(t2 + string.Format("\tpublic {0}Object({1}WhereObject parent) ", fieldName, parent) + "{ this.Parent = parent; }");
            // Equal
            sw.WriteLine(t2 + "\tpublic string Equal(Object value)");
            sw.WriteLine(t2 + "\t{");
            sw.WriteLine(t2 + "\t\tstring lastWhere = \"\";");
            sw.WriteLine(t2 + "\t\tif (value.GetType() == typeof(string))");
            sw.WriteLine(t2 + "\t\t{");
            sw.WriteLine(t2 + string.Format("\t\t\tlastWhere = \" where {0} = '\" + value.ToString().Replace(\"'\", \"''\") + \"'\";", fieldName));
            sw.WriteLine(t2 + "\t\t}");
            sw.WriteLine(t2 + "\t\telse");
            sw.WriteLine(t2 + "\t\t{");
            sw.WriteLine(t2 + string.Format("\t\t\tlastWhere = \" where {0} = \" + value;", fieldName));
            sw.WriteLine(t2 + "\t\t}");
            sw.WriteLine(t2 + "\t\tthis.Parent.Parent.LastWhere = lastWhere;");
            sw.WriteLine(t2 + "\t\treturn lastWhere;");
            sw.WriteLine(t2 + "\t}"); 
            // LessThan
            sw.WriteLine(t2 + "\tpublic string LessThan(Object value)");
            sw.WriteLine(t2 + "\t{");
            sw.WriteLine(t2 + "\t\tstring lastWhere = \"\";");
            sw.WriteLine(t2 + "\t\tif (value.GetType() == typeof(string))");
            sw.WriteLine(t2 + "\t\t{");
            sw.WriteLine(t2 + string.Format("\t\t\tlastWhere = \" where {0} < '\" + value.ToString().Replace(\"'\", \"''\") + \"'\";", fieldName));
            sw.WriteLine(t2 + "\t\t}");
            sw.WriteLine(t2 + "\t\telse");
            sw.WriteLine(t2 + "\t\t{");
            sw.WriteLine(t2 + string.Format("\t\t\tlastWhere = \" where {0} < \" + value;", fieldName));
            sw.WriteLine(t2 + "\t\t}");
            sw.WriteLine(t2 + "\t\tthis.Parent.Parent.LastWhere = lastWhere;");
            sw.WriteLine(t2 + "\t\treturn lastWhere;");
            sw.WriteLine(t2 + "\t}");  
            // LessThanEqual
            sw.WriteLine(t2 + "\tpublic string LessThanEqual(Object value)");
            sw.WriteLine(t2 + "\t{");
            sw.WriteLine(t2 + "\t\tstring lastWhere = \"\";");
            sw.WriteLine(t2 + "\t\tif (value.GetType() == typeof(string))");
            sw.WriteLine(t2 + "\t\t{");
            sw.WriteLine(t2 + string.Format("\t\t\tlastWhere = \" where {0} <= '\" + value.ToString().Replace(\"'\", \"''\") + \"'\";", fieldName));
            sw.WriteLine(t2 + "\t\t}");
            sw.WriteLine(t2 + "\t\telse");
            sw.WriteLine(t2 + "\t\t{");
            sw.WriteLine(t2 + string.Format("\t\t\tlastWhere = \" where {0} <= \" + value;", fieldName));
            sw.WriteLine(t2 + "\t\t}");
            sw.WriteLine(t2 + "\t\tthis.Parent.Parent.LastWhere = lastWhere;");
            sw.WriteLine(t2 + "\t\treturn lastWhere;");
            sw.WriteLine(t2 + "\t}");  
            // GreaterThan
            sw.WriteLine(t2 + "\tpublic string GreaterThan(Object value)");
            sw.WriteLine(t2 + "\t{");
            sw.WriteLine(t2 + "\t\tstring lastWhere = \"\";");
            sw.WriteLine(t2 + "\t\tif (value.GetType() == typeof(string))");
            sw.WriteLine(t2 + "\t\t{");
            sw.WriteLine(t2 + string.Format("\t\t\tlastWhere = \" where {0} > '\" + value.ToString().Replace(\"'\", \"''\") + \"'\";", fieldName));
            sw.WriteLine(t2 + "\t\t}");
            sw.WriteLine(t2 + "\t\telse");
            sw.WriteLine(t2 + "\t\t{");
            sw.WriteLine(t2 + string.Format("\t\t\tlastWhere = \" where {0} > \" + value;", fieldName));
            sw.WriteLine(t2 + "\t\t}");
            sw.WriteLine(t2 + "\t\tthis.Parent.Parent.LastWhere = lastWhere;");
            sw.WriteLine(t2 + "\t\treturn lastWhere;");
            sw.WriteLine(t2 + "\t}");  
            // GreaterThanEqual
            sw.WriteLine(t2 + "\tpublic string GreaterThanEqual(Object value)");
            sw.WriteLine(t2 + "\t{");
            sw.WriteLine(t2 + "\t\tstring lastWhere = \"\";");
            sw.WriteLine(t2 + "\t\tif (value.GetType() == typeof(string))");
            sw.WriteLine(t2 + "\t\t{");
            sw.WriteLine(t2 + string.Format("\t\t\tlastWhere = \" where {0} >= '\" + value.ToString().Replace(\"'\", \"''\") + \"'\";", fieldName));
            sw.WriteLine(t2 + "\t\t}");
            sw.WriteLine(t2 + "\t\telse");
            sw.WriteLine(t2 + "\t\t{");
            sw.WriteLine(t2 + string.Format("\t\t\tlastWhere = \" where {0} >= \" + value;", fieldName));
            sw.WriteLine(t2 + "\t\t}");
            sw.WriteLine(t2 + "\t\tthis.Parent.Parent.LastWhere = lastWhere;");
            sw.WriteLine(t2 + "\t\treturn lastWhere;");
            sw.WriteLine(t2 + "\t}");  
            // Like
            sw.WriteLine(t2 + "\tpublic string Like(Object value)");
            sw.WriteLine(t2 + "\t{");
            sw.WriteLine(t2 + "\t\tstring lastWhere = \"\";");
            sw.WriteLine(t2 + "\t\tif (value.GetType() == typeof(string))");
            sw.WriteLine(t2 + "\t\t{");
            sw.WriteLine(t2 + string.Format("\t\t\tlastWhere = \" where {0} like '%\" + value.ToString().Replace(\"'\", \"''\") + \"%'\";", fieldName));
            sw.WriteLine(t2 + "\t\t}");
            sw.WriteLine(t2 + "\t\telse");
            sw.WriteLine(t2 + "\t\t{");
            sw.WriteLine(t2 + string.Format("\t\t\tlastWhere = \" where {0} <= \" + value;", fieldName));
            sw.WriteLine(t2 + "\t\t}");
            sw.WriteLine(t2 + "\t\tthis.Parent.Parent.LastWhere = lastWhere;");
            sw.WriteLine(t2 + "\t\treturn lastWhere;");
            sw.WriteLine(t2 + "\t}");  
            // End Class
            sw.WriteLine(t2 + "}");
        }

        private void AddDBAdapter(StreamWriter sw)
        {
            string strDBAdapter = @"
    #region DBAdapter
    public class DBAdapter
    {
        public static string mConStr = ""Data Source=CBVN-PC037;Initial Catalog=MyFrameWork;Persist Security Info=True;Integrated Security=True"";

        public static void Insert(Object obj)
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

            string strInsertFormat = ""Insert Into {0} ({1}) Values ({2})"";
            string sql = string.Format(strInsertFormat, strTableName, strField, strValue);
            DBAdapter.ExecQuery(sql);
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
                    string value = DBAdapter.GetValue(pi.GetValue(obj, null));
                    if (value.Length == 0) { value = ""''""; }
                    updateSets.Add(string.Format(""{0} = {1}"", pi.Name, value));
                }
            }

            string strSqlFormat = ""Update {0} Set {1} {2}"";
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
            string sql = string.Format(""Delete From {0} {1}"", strTableName, strWhere);
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

        private static SqlConnection getCon()
        {
            SqlConnection con = new SqlConnection(mConStr);
            con.Open();
            return con;
        }
        private static void ExecQuery(String sql)
        {

            SqlConnection con = getCon();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

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
