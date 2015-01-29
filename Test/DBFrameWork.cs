using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;

namespace DBGenerator
{

#region Share Object

	public enum DatabaseAction
	{
		Insert = 0,
		Update = 1,
		Delete = 2
	}
			#endregion

	#region Base Object
	public class FieldObjectBase
	{
		protected string FieldName = string.Empty;
		protected Object FieldValue = null;
		protected string CurrentOperator = string.Empty;
		protected FieldObjectBase() { }
		public FieldObjectBase(string fldName)
		{
			this.FieldName = fldName;
		}

		protected string ToQueryString()
		{
			string queryString = string.Empty;
			if (FieldValue.GetType() == typeof(string))
			{
				string _fieldValue = FieldValue.ToString().Replace("'", "''");
				string queryStringFormat = "({0} {1} '{2}')";
				if (CurrentOperator.ToUpper() == "LIKE")
				{
					queryStringFormat = "({0} {1} '%{2}%')";
				}
				queryString = string.Format(queryStringFormat, FieldName, CurrentOperator, _fieldValue);
			}
			else
			{
				if (CurrentOperator.ToUpper() == "LIKE")
				{
					CurrentOperator = "<=";
				}
				queryString = string.Format("({0} {1} {2})", FieldName, CurrentOperator, FieldValue);
			}
			return queryString;
		}

	}

	public class TableClassBase
	{
		protected bool IsUpdate = false;
		protected DatabaseAction DbAction = DatabaseAction.Insert;
		protected string _lastWhere = string.Empty;
		public string LastWhere
		{
			protected get { return _lastWhere; }
			set
			{
				if (String.IsNullOrEmpty(_lastWhere))
				{
					_lastWhere = " WHERE ";
				}
				_lastWhere += value;
			}
		}
	}

	public class WhereObjectBase
	{
		public TableClassBase Parent;

		public WhereObjectBase(TableClassBase tblClassBase)
		{
			this.Parent = tblClassBase;
		}
	}
	#endregion

	public class Customer : TableClassBase
	{
		public static string TableName = "Customer";
		#region Where
		private CustomerWhereObject _whereObject = null;
		protected CustomerWhereObject Where
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

		#region Update
		private CustomerUpdateObject _updateObject = null;
		public CustomerUpdateObject Update
		{
			get
			{
				if (_updateObject == null)
				{
					_updateObject = new CustomerUpdateObject(Where);
				}
				IsUpdate = true;
				return _updateObject;
			}
		}
		#endregion

		#region Update
		private CustomerDeleteObject _deleteObject = null;
		public CustomerDeleteObject Delete
		{
			get
			{
				if (_deleteObject == null)
				{
					_deleteObject = new CustomerDeleteObject(Where);
				}
				return _deleteObject;
			}
		}
		#endregion

		#region Properties
		public object ID { get; set; }
		public object Name { get; set; }
		#endregion

		public static class Fields
		{
			public const string ID = "ID";
			public const string Name = "Name";
		}
		public static string[] FieldList = {Fields.ID, Fields.Name};

		#region Methods
		public Int32 Save()
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

		public void DeleteEx()
		{
			DBAdapter.Delete(this);
		}


		public DataSet Select()
		{
			return DBAdapter.Select(this);
		}

		#endregion

		#region Where Object
		public class CustomerWhereObject : WhereObjectBase
		{
			public CustomerWhereObject(Customer parent) : base(parent) { }

			private IDObject _ID = null;
			public IDObject ID
			{
				get
				{
					if (_ID == null)
					{
						_ID = new IDObject(this);
					}
					return _ID;
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

			#region Each field object
			public class IDObject : FieldObjectBase
			{
				CustomerOperatorObject _operator = null;

				public readonly CustomerWhereObject Parent = null;
				protected IDObject() { }
				public IDObject(CustomerWhereObject parent): base("ID") 
				{
					this.Parent = parent;
					this._operator = new CustomerOperatorObject(this.Parent);
				}

				public CustomerOperatorObject Equal(Object value)
				{
					FieldValue = value;
					CurrentOperator = "=";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public CustomerOperatorObject LessThan(Object value)
				{
					FieldValue = value;
					CurrentOperator = "<";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public CustomerOperatorObject LessThanEqual(Object value)
				{
					FieldValue = value;
					CurrentOperator = "<=";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public CustomerOperatorObject GreaterThan(Object value)
				{
					FieldValue = value;
					CurrentOperator = ">";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public CustomerOperatorObject GreaterThanEqual(Object value)
				{
					FieldValue = value;
					CurrentOperator = ">=";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public CustomerOperatorObject Like(Object value)
				{
					FieldValue = value;
					CurrentOperator = "LIKE";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}
			}

			public class NameObject : FieldObjectBase
			{
				CustomerOperatorObject _operator = null;

				public readonly CustomerWhereObject Parent = null;
				protected NameObject() { }
				public NameObject(CustomerWhereObject parent): base("Name") 
				{
					this.Parent = parent;
					this._operator = new CustomerOperatorObject(this.Parent);
				}

				public CustomerOperatorObject Equal(Object value)
				{
					FieldValue = value;
					CurrentOperator = "=";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public CustomerOperatorObject LessThan(Object value)
				{
					FieldValue = value;
					CurrentOperator = "<";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public CustomerOperatorObject LessThanEqual(Object value)
				{
					FieldValue = value;
					CurrentOperator = "<=";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public CustomerOperatorObject GreaterThan(Object value)
				{
					FieldValue = value;
					CurrentOperator = ">";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public CustomerOperatorObject GreaterThanEqual(Object value)
				{
					FieldValue = value;
					CurrentOperator = ">=";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public CustomerOperatorObject Like(Object value)
				{
					FieldValue = value;
					CurrentOperator = "LIKE";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}
			}

			#endregion
		}
		#endregion

		#region Update Command Object
		public class CustomerUpdateObject
		{
			public readonly CustomerWhereObject _whereObject = null;
			protected CustomerUpdateObject() {}
			public CustomerUpdateObject(CustomerWhereObject whereObj) { this._whereObject = whereObj; }

			public CustomerWhereObject Where
			{
				get { return this._whereObject; }
			}
		}
		#endregion

		#region Insert Command Object
		public class CustomerInsertObject
		{
			public readonly CustomerWhereObject _whereObject = null;
			protected CustomerInsertObject() {}
			public CustomerInsertObject(CustomerWhereObject whereObj) { this._whereObject = whereObj; }

			public CustomerWhereObject Where
			{
				get { return this._whereObject; }
			}
		}
		#endregion

		#region Delete Command Object
		public class CustomerDeleteObject
		{
			public readonly CustomerWhereObject _whereObject = null;
			protected CustomerDeleteObject() {}
			public CustomerDeleteObject(CustomerWhereObject whereObj) { this._whereObject = whereObj; }

			public CustomerWhereObject Where
			{
				get { return this._whereObject; }
			}
		}
		#endregion

		#region Select Command Object
		public class CustomerSelectObject
		{
			public readonly CustomerWhereObject _whereObject = null;
			protected CustomerSelectObject() {}
			public CustomerSelectObject(CustomerWhereObject whereObj) { this._whereObject = whereObj; }

			public CustomerWhereObject Where
			{
				get { return this._whereObject; }
			}
		}
		#endregion

		#region Operator Object
		public class CustomerOperatorObject
		{
			private CustomerWhereObject _whereObject = null;
			protected CustomerOperatorObject() {}
			public CustomerOperatorObject(CustomerWhereObject whereObj) { this._whereObject = whereObj; }

			public CustomerWhereObject Where
			{
				get { return this._whereObject; }
			}

			public CustomerWhereObject Or
			{
				get
				{
					this._whereObject.Parent.LastWhere = " OR ";
					return this._whereObject;
				}
			}

			public CustomerWhereObject And
			{
				get
				{
					this._whereObject.Parent.LastWhere = " AND ";
					return this._whereObject;
				}
			}
		}
		#endregion

	}
	public class Events : TableClassBase
	{
		public static string TableName = "Events";
		#region Where
		private EventsWhereObject _whereObject = null;
		protected EventsWhereObject Where
		{
			get
			{
				if (_whereObject == null)
				{
					_whereObject = new EventsWhereObject(this);
				}
				return _whereObject;
			}
		}
		#endregion

		#region Update
		private EventsUpdateObject _updateObject = null;
		public EventsUpdateObject Update
		{
			get
			{
				if (_updateObject == null)
				{
					_updateObject = new EventsUpdateObject(Where);
				}
				IsUpdate = true;
				return _updateObject;
			}
		}
		#endregion

		#region Update
		private EventsDeleteObject _deleteObject = null;
		public EventsDeleteObject Delete
		{
			get
			{
				if (_deleteObject == null)
				{
					_deleteObject = new EventsDeleteObject(Where);
				}
				return _deleteObject;
			}
		}
		#endregion

		#region Properties
		public object ID { get; set; }
		public object EventName { get; set; }
		public object EventLocation { get; set; }
		#endregion

		public static class Fields
		{
			public const string ID = "ID";
			public const string EventName = "EventName";
			public const string EventLocation = "EventLocation";
		}
		public static string[] FieldList = {Fields.ID, Fields.EventName, Fields.EventLocation};

		#region Methods
		public Int32 Save()
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

		public void DeleteEx()
		{
			DBAdapter.Delete(this);
		}


		public DataSet Select()
		{
			return DBAdapter.Select(this);
		}

		#endregion

		#region Where Object
		public class EventsWhereObject : WhereObjectBase
		{
			public EventsWhereObject(Events parent) : base(parent) { }

			private IDObject _ID = null;
			public IDObject ID
			{
				get
				{
					if (_ID == null)
					{
						_ID = new IDObject(this);
					}
					return _ID;
				}
			}

			private EventNameObject _EventName = null;
			public EventNameObject EventName
			{
				get
				{
					if (_EventName == null)
					{
						_EventName = new EventNameObject(this);
					}
					return _EventName;
				}
			}

			private EventLocationObject _EventLocation = null;
			public EventLocationObject EventLocation
			{
				get
				{
					if (_EventLocation == null)
					{
						_EventLocation = new EventLocationObject(this);
					}
					return _EventLocation;
				}
			}

			#region Each field object
			public class IDObject : FieldObjectBase
			{
				EventsOperatorObject _operator = null;

				public readonly EventsWhereObject Parent = null;
				protected IDObject() { }
				public IDObject(EventsWhereObject parent): base("ID") 
				{
					this.Parent = parent;
					this._operator = new EventsOperatorObject(this.Parent);
				}

				public EventsOperatorObject Equal(Object value)
				{
					FieldValue = value;
					CurrentOperator = "=";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public EventsOperatorObject LessThan(Object value)
				{
					FieldValue = value;
					CurrentOperator = "<";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public EventsOperatorObject LessThanEqual(Object value)
				{
					FieldValue = value;
					CurrentOperator = "<=";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public EventsOperatorObject GreaterThan(Object value)
				{
					FieldValue = value;
					CurrentOperator = ">";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public EventsOperatorObject GreaterThanEqual(Object value)
				{
					FieldValue = value;
					CurrentOperator = ">=";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public EventsOperatorObject Like(Object value)
				{
					FieldValue = value;
					CurrentOperator = "LIKE";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}
			}

			public class EventNameObject : FieldObjectBase
			{
				EventsOperatorObject _operator = null;

				public readonly EventsWhereObject Parent = null;
				protected EventNameObject() { }
				public EventNameObject(EventsWhereObject parent): base("EventName") 
				{
					this.Parent = parent;
					this._operator = new EventsOperatorObject(this.Parent);
				}

				public EventsOperatorObject Equal(Object value)
				{
					FieldValue = value;
					CurrentOperator = "=";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public EventsOperatorObject LessThan(Object value)
				{
					FieldValue = value;
					CurrentOperator = "<";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public EventsOperatorObject LessThanEqual(Object value)
				{
					FieldValue = value;
					CurrentOperator = "<=";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public EventsOperatorObject GreaterThan(Object value)
				{
					FieldValue = value;
					CurrentOperator = ">";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public EventsOperatorObject GreaterThanEqual(Object value)
				{
					FieldValue = value;
					CurrentOperator = ">=";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public EventsOperatorObject Like(Object value)
				{
					FieldValue = value;
					CurrentOperator = "LIKE";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}
			}

			public class EventLocationObject : FieldObjectBase
			{
				EventsOperatorObject _operator = null;

				public readonly EventsWhereObject Parent = null;
				protected EventLocationObject() { }
				public EventLocationObject(EventsWhereObject parent): base("EventLocation") 
				{
					this.Parent = parent;
					this._operator = new EventsOperatorObject(this.Parent);
				}

				public EventsOperatorObject Equal(Object value)
				{
					FieldValue = value;
					CurrentOperator = "=";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public EventsOperatorObject LessThan(Object value)
				{
					FieldValue = value;
					CurrentOperator = "<";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public EventsOperatorObject LessThanEqual(Object value)
				{
					FieldValue = value;
					CurrentOperator = "<=";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public EventsOperatorObject GreaterThan(Object value)
				{
					FieldValue = value;
					CurrentOperator = ">";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public EventsOperatorObject GreaterThanEqual(Object value)
				{
					FieldValue = value;
					CurrentOperator = ">=";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public EventsOperatorObject Like(Object value)
				{
					FieldValue = value;
					CurrentOperator = "LIKE";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}
			}

			#endregion
		}
		#endregion

		#region Update Command Object
		public class EventsUpdateObject
		{
			public readonly EventsWhereObject _whereObject = null;
			protected EventsUpdateObject() {}
			public EventsUpdateObject(EventsWhereObject whereObj) { this._whereObject = whereObj; }

			public EventsWhereObject Where
			{
				get { return this._whereObject; }
			}
		}
		#endregion

		#region Insert Command Object
		public class EventsInsertObject
		{
			public readonly EventsWhereObject _whereObject = null;
			protected EventsInsertObject() {}
			public EventsInsertObject(EventsWhereObject whereObj) { this._whereObject = whereObj; }

			public EventsWhereObject Where
			{
				get { return this._whereObject; }
			}
		}
		#endregion

		#region Delete Command Object
		public class EventsDeleteObject
		{
			public readonly EventsWhereObject _whereObject = null;
			protected EventsDeleteObject() {}
			public EventsDeleteObject(EventsWhereObject whereObj) { this._whereObject = whereObj; }

			public EventsWhereObject Where
			{
				get { return this._whereObject; }
			}
		}
		#endregion

		#region Select Command Object
		public class EventsSelectObject
		{
			public readonly EventsWhereObject _whereObject = null;
			protected EventsSelectObject() {}
			public EventsSelectObject(EventsWhereObject whereObj) { this._whereObject = whereObj; }

			public EventsWhereObject Where
			{
				get { return this._whereObject; }
			}
		}
		#endregion

		#region Operator Object
		public class EventsOperatorObject
		{
			private EventsWhereObject _whereObject = null;
			protected EventsOperatorObject() {}
			public EventsOperatorObject(EventsWhereObject whereObj) { this._whereObject = whereObj; }

			public EventsWhereObject Where
			{
				get { return this._whereObject; }
			}

			public EventsWhereObject Or
			{
				get
				{
					this._whereObject.Parent.LastWhere = " OR ";
					return this._whereObject;
				}
			}

			public EventsWhereObject And
			{
				get
				{
					this._whereObject.Parent.LastWhere = " AND ";
					return this._whereObject;
				}
			}
		}
		#endregion

	}
	public class Person : TableClassBase
	{
		public static string TableName = "Person";
		#region Where
		private PersonWhereObject _whereObject = null;
		protected PersonWhereObject Where
		{
			get
			{
				if (_whereObject == null)
				{
					_whereObject = new PersonWhereObject(this);
				}
				return _whereObject;
			}
		}
		#endregion

		#region Update
		private PersonUpdateObject _updateObject = null;
		public PersonUpdateObject Update
		{
			get
			{
				if (_updateObject == null)
				{
					_updateObject = new PersonUpdateObject(Where);
				}
				IsUpdate = true;
				return _updateObject;
			}
		}
		#endregion

		#region Update
		private PersonDeleteObject _deleteObject = null;
		public PersonDeleteObject Delete
		{
			get
			{
				if (_deleteObject == null)
				{
					_deleteObject = new PersonDeleteObject(Where);
				}
				return _deleteObject;
			}
		}
		#endregion

		#region Properties
		public object PersonName { get; set; }
		public object PersonAddress { get; set; }
		#endregion

		public static class Fields
		{
			public const string PersonName = "PersonName";
			public const string PersonAddress = "PersonAddress";
		}
		public static string[] FieldList = {Fields.PersonName, Fields.PersonAddress};

		#region Methods
		public Int32 Save()
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

		public void DeleteEx()
		{
			DBAdapter.Delete(this);
		}


		public DataSet Select()
		{
			return DBAdapter.Select(this);
		}

		#endregion

		#region Where Object
		public class PersonWhereObject : WhereObjectBase
		{
			public PersonWhereObject(Person parent) : base(parent) { }

			private PersonNameObject _PersonName = null;
			public PersonNameObject PersonName
			{
				get
				{
					if (_PersonName == null)
					{
						_PersonName = new PersonNameObject(this);
					}
					return _PersonName;
				}
			}

			private PersonAddressObject _PersonAddress = null;
			public PersonAddressObject PersonAddress
			{
				get
				{
					if (_PersonAddress == null)
					{
						_PersonAddress = new PersonAddressObject(this);
					}
					return _PersonAddress;
				}
			}

			#region Each field object
			public class PersonNameObject : FieldObjectBase
			{
				PersonOperatorObject _operator = null;

				public readonly PersonWhereObject Parent = null;
				protected PersonNameObject() { }
				public PersonNameObject(PersonWhereObject parent): base("PersonName") 
				{
					this.Parent = parent;
					this._operator = new PersonOperatorObject(this.Parent);
				}

				public PersonOperatorObject Equal(Object value)
				{
					FieldValue = value;
					CurrentOperator = "=";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public PersonOperatorObject LessThan(Object value)
				{
					FieldValue = value;
					CurrentOperator = "<";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public PersonOperatorObject LessThanEqual(Object value)
				{
					FieldValue = value;
					CurrentOperator = "<=";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public PersonOperatorObject GreaterThan(Object value)
				{
					FieldValue = value;
					CurrentOperator = ">";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public PersonOperatorObject GreaterThanEqual(Object value)
				{
					FieldValue = value;
					CurrentOperator = ">=";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public PersonOperatorObject Like(Object value)
				{
					FieldValue = value;
					CurrentOperator = "LIKE";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}
			}

			public class PersonAddressObject : FieldObjectBase
			{
				PersonOperatorObject _operator = null;

				public readonly PersonWhereObject Parent = null;
				protected PersonAddressObject() { }
				public PersonAddressObject(PersonWhereObject parent): base("PersonAddress") 
				{
					this.Parent = parent;
					this._operator = new PersonOperatorObject(this.Parent);
				}

				public PersonOperatorObject Equal(Object value)
				{
					FieldValue = value;
					CurrentOperator = "=";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public PersonOperatorObject LessThan(Object value)
				{
					FieldValue = value;
					CurrentOperator = "<";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public PersonOperatorObject LessThanEqual(Object value)
				{
					FieldValue = value;
					CurrentOperator = "<=";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public PersonOperatorObject GreaterThan(Object value)
				{
					FieldValue = value;
					CurrentOperator = ">";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public PersonOperatorObject GreaterThanEqual(Object value)
				{
					FieldValue = value;
					CurrentOperator = ">=";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}

				public PersonOperatorObject Like(Object value)
				{
					FieldValue = value;
					CurrentOperator = "LIKE";
					this.Parent.Parent.LastWhere = ToQueryString();
					return _operator;
				}
			}

			#endregion
		}
		#endregion

		#region Update Command Object
		public class PersonUpdateObject
		{
			public readonly PersonWhereObject _whereObject = null;
			protected PersonUpdateObject() {}
			public PersonUpdateObject(PersonWhereObject whereObj) { this._whereObject = whereObj; }

			public PersonWhereObject Where
			{
				get { return this._whereObject; }
			}
		}
		#endregion

		#region Insert Command Object
		public class PersonInsertObject
		{
			public readonly PersonWhereObject _whereObject = null;
			protected PersonInsertObject() {}
			public PersonInsertObject(PersonWhereObject whereObj) { this._whereObject = whereObj; }

			public PersonWhereObject Where
			{
				get { return this._whereObject; }
			}
		}
		#endregion

		#region Delete Command Object
		public class PersonDeleteObject
		{
			public readonly PersonWhereObject _whereObject = null;
			protected PersonDeleteObject() {}
			public PersonDeleteObject(PersonWhereObject whereObj) { this._whereObject = whereObj; }

			public PersonWhereObject Where
			{
				get { return this._whereObject; }
			}
		}
		#endregion

		#region Select Command Object
		public class PersonSelectObject
		{
			public readonly PersonWhereObject _whereObject = null;
			protected PersonSelectObject() {}
			public PersonSelectObject(PersonWhereObject whereObj) { this._whereObject = whereObj; }

			public PersonWhereObject Where
			{
				get { return this._whereObject; }
			}
		}
		#endregion

		#region Operator Object
		public class PersonOperatorObject
		{
			private PersonWhereObject _whereObject = null;
			protected PersonOperatorObject() {}
			public PersonOperatorObject(PersonWhereObject whereObj) { this._whereObject = whereObj; }

			public PersonWhereObject Where
			{
				get { return this._whereObject; }
			}

			public PersonWhereObject Or
			{
				get
				{
					this._whereObject.Parent.LastWhere = " OR ";
					return this._whereObject;
				}
			}

			public PersonWhereObject And
			{
				get
				{
					this._whereObject.Parent.LastWhere = " AND ";
					return this._whereObject;
				}
			}
		}
		#endregion

	}

    #region DBAdapter
    public class DBAdapter
    {
        public static string mConStr = "Data Source=CBVN-PC046\\SQLEXPRESS;Initial Catalog=DBGenerator;Persist Security Info=True;Integrated Security=True";

        public static Int32 Insert(Object obj)
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

            string strInsertFormat = "INSERT INTO {0} ({1}) VALUES ({2}); SELECT SCOPE_IDENTITY() AS LastID;";
            string sql = string.Format(strInsertFormat, strTableName, strField, strValue);
            return DBAdapter.ExecQuery(sql);
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
                    string value = DBAdapter.GetValue(pi.GetValue(obj, null), null);
                    if (value == null) { continue; }
                    if (value.Length == 0) { value = "''"; }
                    updateSets.Add(string.Format("{0} = {1}", pi.Name, value));
                }
            }

            string strSqlFormat = "UPDATE {0} SET {1} {2}";
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
            string sql = string.Format("DELETE FROM {0} {1}", strTableName, strWhere);
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

        // return empty if @param value is null
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

}
