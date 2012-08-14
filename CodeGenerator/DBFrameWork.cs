using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;

namespace MyFrameWork
{
	public class Customer
	{
		public static string TableName = "Customer";
		public string LastWhere { protected get; set; }
		#region Where
		private CustomerWhereObject _whereObject = null;
		public CustomerWhereObject Where
		{
			get
			{
				if (_whereObject == null)
				{
					_whereObject = new CustomerWhereObject(this);
				}
				return _whereObject;
			}
		}
		#endregion

		#region Properties
		public object CustomerId { get; set; }
		public object Name { get; set; }
		public object Addres { get; set; }
		public object Int { get; set; }
		public object BigInt { get; set; }
		#endregion

		public static class Fields
		{
			public const string CustomerId = "CustomerId";
			public const string Name = "Name";
			public const string Addres = "Addres";
			public const string Int = "Int";
			public const string BigInt = "BigInt";
		}
		public static string[] FieldList = {Fields.CustomerId, Fields.Name, Fields.Addres, Fields.Int, Fields.BigInt};

		#region Methods
		public void Insert() { DBAdapter.Insert(this); }
		public void Update() { DBAdapter.Update(this); }
		public void Delete() { DBAdapter.Delete(this); }
		public DataSet Select() { return DBAdapter.Select(this); }
		#endregion

		#region Where Object
		public class CustomerWhereObject
		{
			public readonly Customer Parent = null;
			protected CustomerWhereObject(){ }
			public CustomerWhereObject(Customer parent){ this.Parent = parent; }

			private CustomerIdObject _CustomerId = null;
			public CustomerIdObject CustomerId
			{
				get
				{
					if (_CustomerId == null)
					{
						_CustomerId = new CustomerIdObject(this);
					}
					return _CustomerId;
				}
			}

			private NameObject _Name = null;
			public NameObject Name
			{
				get
				{
					if (_Name == null)
					{
						_Name = new NameObject(this);
					}
					return _Name;
				}
			}

			private AddresObject _Addres = null;
			public AddresObject Addres
			{
				get
				{
					if (_Addres == null)
					{
						_Addres = new AddresObject(this);
					}
					return _Addres;
				}
			}

			private IntObject _Int = null;
			public IntObject Int
			{
				get
				{
					if (_Int == null)
					{
						_Int = new IntObject(this);
					}
					return _Int;
				}
			}

			private BigIntObject _BigInt = null;
			public BigIntObject BigInt
			{
				get
				{
					if (_BigInt == null)
					{
						_BigInt = new BigIntObject(this);
					}
					return _BigInt;
				}
			}

			#region Each field object
			public class CustomerIdObject
			{
				public readonly CustomerWhereObject Parent = null;
				protected CustomerIdObject() { }
				public CustomerIdObject(CustomerWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CustomerId = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CustomerId = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CustomerId < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CustomerId < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CustomerId <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CustomerId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CustomerId > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CustomerId > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CustomerId >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CustomerId >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CustomerId like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where CustomerId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class NameObject
			{
				public readonly CustomerWhereObject Parent = null;
				protected NameObject() { }
				public NameObject(CustomerWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Name = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Name = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Name < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Name < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Name <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Name <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Name > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Name > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Name >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Name >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Name like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where Name <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class AddresObject
			{
				public readonly CustomerWhereObject Parent = null;
				protected AddresObject() { }
				public AddresObject(CustomerWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Addres = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Addres = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Addres < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Addres < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Addres <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Addres <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Addres > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Addres > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Addres >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Addres >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Addres like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where Addres <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class IntObject
			{
				public readonly CustomerWhereObject Parent = null;
				protected IntObject() { }
				public IntObject(CustomerWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Int = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Int = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Int < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Int < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Int <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Int <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Int > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Int > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Int >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Int >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Int like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where Int <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class BigIntObject
			{
				public readonly CustomerWhereObject Parent = null;
				protected BigIntObject() { }
				public BigIntObject(CustomerWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where BigInt = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where BigInt = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where BigInt < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where BigInt < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where BigInt <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where BigInt <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where BigInt > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where BigInt > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where BigInt >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where BigInt >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where BigInt like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where BigInt <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			#endregion
		}
		#endregion

	}

    #region DBAdapter
    public class DBAdapter
    {
        public static string mConStr = "Data Source=CBVN-PC037;Initial Catalog=MyFrameWork;Persist Security Info=True;Integrated Security=True";

        public static void Insert(Object obj)
        {
            Type t = obj.GetType();
            string strTableName = t.Name;
            PropertyInfo[] propertyInfos = t.GetProperties();
            string[] fields = (string[])t.GetField("FieldList").GetValue(obj);
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
            string strField = String.Join(", ", field2Insert.ToArray());
            string strValue = String.Join(", ", fieldsVal2Insert.ToArray());

            string strInsertFormat = "Insert Into {0} ({1}) Values ({2})";
            string sql = string.Format(strInsertFormat, strTableName, strField, strValue);
            DBAdapter.ExecQuery(sql);
        }

        public static void Update(Object obj)
        {
            Type t = obj.GetType();
            string strTableName = t.Name;
            PropertyInfo[] propertyInfos = t.GetProperties();
            string strWhere = t.GetProperty("LastWhere").GetValue(obj, null) + string.Empty;
            if (strWhere.Length == 0)
            {
                throw new ArgumentNullException("ArgumentNullException: Where");
            }
            string[] fields = (string[])t.GetField("FieldList").GetValue(obj);
            List<string> updateSets = new List<string>(fields.Length);
            foreach (PropertyInfo pi in propertyInfos)
            {
                if (fields.Contains(pi.Name))
                {
                    string value = DBAdapter.GetValue(pi.GetValue(obj, null));
                    if (value.Length == 0) { value = "''"; }
                    updateSets.Add(string.Format("{0} = {1}", pi.Name, value));
                }
            }

            string strSqlFormat = "Update {0} Set {1} {2}";
            string sql = string.Format(strSqlFormat, strTableName, String.Join(", ", updateSets.ToArray()), strWhere);
            DBAdapter.ExecQuery(sql);
        }

        public static void Delete(Object obj)
        {
            Type t = obj.GetType();
            string strTableName = (string)t.GetField("TableName").GetValue(obj);
            string strWhere = t.GetProperty("LastWhere").GetValue(obj, null) + string.Empty;
            if (strWhere.Length == 0)
            {
                throw new ArgumentNullException("ArgumentNullException: Where");
            }
            string sql = string.Format("Delete From {0} {1}", strTableName, strWhere);
            DBAdapter.ExecQuery(sql);
        }

        public static DataSet Select(Object obj)
        {
            Type t = obj.GetType();
            string[] fields = (string[])t.GetField("FieldList").GetValue(obj);
            string strTableName = (string)t.GetField("TableName").GetValue(obj);
            string strWhere = t.GetProperty("LastWhere").GetValue(obj, null) + string.Empty;
            string sql = string.Format("Select {0} From {1} {2}", String.Join(", ", fields), strTableName, strWhere);
            return DBAdapter.GetDataSet(sql);
        }

        private static String GetValue(Object value)
        {
            String ret = "";
            if (value == null) { return ret; }
            if (value.GetType() == typeof(string))
            {
                ret = "'" + value.ToString().Replace("'", "''") + "'";
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

}
