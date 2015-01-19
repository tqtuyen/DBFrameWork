using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;

namespace Personal
{
	public class Address
	{
		public static string TableName = "Address";
		public string LastWhere { protected get; set; }
		#region Where
		private AddressWhereObject _whereObject = null;
		public AddressWhereObject Where
		{
			get
			{
				if (_whereObject == null)
				{
					_whereObject = new AddressWhereObject(this);
				}
				return _whereObject;
			}
		}
		#endregion

		#region Properties
		public object AddrID { get; set; }
		public object PersonID { get; set; }
		public object Address1 { get; set; }
		public object Address2 { get; set; }
		public object City { get; set; }
		public object District { get; set; }
		public object Area { get; set; }
		public object Zip { get; set; }
		public object Country { get; set; }
		public object CreatedDate { get; set; }
		#endregion

		public static class Fields
		{
			public const string AddrID = "AddrID";
			public const string PersonID = "PersonID";
			public const string Address1 = "Address1";
			public const string Address2 = "Address2";
			public const string City = "City";
			public const string District = "District";
			public const string Area = "Area";
			public const string Zip = "Zip";
			public const string Country = "Country";
			public const string CreatedDate = "CreatedDate";
		}
		public static string[] FieldList = {Fields.AddrID, Fields.PersonID, Fields.Address1, Fields.Address2, Fields.City, Fields.District, Fields.Area, Fields.Zip, Fields.Country, Fields.CreatedDate};

		#region Methods
		public void Insert() { DBAdapter.Insert(this); }
		public void Update() { DBAdapter.Update(this); }
		public void Delete() { DBAdapter.Delete(this); }
		public DataSet Select() { return DBAdapter.Select(this); }
		#endregion

		#region Where Object
		public class AddressWhereObject
		{
			public readonly Address Parent = null;
			protected AddressWhereObject(){ }
			public AddressWhereObject(Address parent){ this.Parent = parent; }

			private AddrIDObject _AddrID = null;
			public AddrIDObject AddrID
			{
				get
				{
					if (_AddrID == null)
					{
						_AddrID = new AddrIDObject(this);
					}
					return _AddrID;
				}
			}

			private PersonIDObject _PersonID = null;
			public PersonIDObject PersonID
			{
				get
				{
					if (_PersonID == null)
					{
						_PersonID = new PersonIDObject(this);
					}
					return _PersonID;
				}
			}

			private Address1Object _Address1 = null;
			public Address1Object Address1
			{
				get
				{
					if (_Address1 == null)
					{
						_Address1 = new Address1Object(this);
					}
					return _Address1;
				}
			}

			private Address2Object _Address2 = null;
			public Address2Object Address2
			{
				get
				{
					if (_Address2 == null)
					{
						_Address2 = new Address2Object(this);
					}
					return _Address2;
				}
			}

			private CityObject _City = null;
			public CityObject City
			{
				get
				{
					if (_City == null)
					{
						_City = new CityObject(this);
					}
					return _City;
				}
			}

			private DistrictObject _District = null;
			public DistrictObject District
			{
				get
				{
					if (_District == null)
					{
						_District = new DistrictObject(this);
					}
					return _District;
				}
			}

			private AreaObject _Area = null;
			public AreaObject Area
			{
				get
				{
					if (_Area == null)
					{
						_Area = new AreaObject(this);
					}
					return _Area;
				}
			}

			private ZipObject _Zip = null;
			public ZipObject Zip
			{
				get
				{
					if (_Zip == null)
					{
						_Zip = new ZipObject(this);
					}
					return _Zip;
				}
			}

			private CountryObject _Country = null;
			public CountryObject Country
			{
				get
				{
					if (_Country == null)
					{
						_Country = new CountryObject(this);
					}
					return _Country;
				}
			}

			private CreatedDateObject _CreatedDate = null;
			public CreatedDateObject CreatedDate
			{
				get
				{
					if (_CreatedDate == null)
					{
						_CreatedDate = new CreatedDateObject(this);
					}
					return _CreatedDate;
				}
			}

			#region Each field object
			public class AddrIDObject
			{
				public readonly AddressWhereObject Parent = null;
				protected AddrIDObject() { }
				public AddrIDObject(AddressWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AddrID = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where AddrID = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AddrID < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where AddrID < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AddrID <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where AddrID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AddrID > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where AddrID > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AddrID >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where AddrID >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AddrID like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where AddrID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class PersonIDObject
			{
				public readonly AddressWhereObject Parent = null;
				protected PersonIDObject() { }
				public PersonIDObject(AddressWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where PersonID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class Address1Object
			{
				public readonly AddressWhereObject Parent = null;
				protected Address1Object() { }
				public Address1Object(AddressWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Address1 = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Address1 = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Address1 < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Address1 < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Address1 <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Address1 <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Address1 > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Address1 > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Address1 >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Address1 >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Address1 like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where Address1 <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class Address2Object
			{
				public readonly AddressWhereObject Parent = null;
				protected Address2Object() { }
				public Address2Object(AddressWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Address2 = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Address2 = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Address2 < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Address2 < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Address2 <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Address2 <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Address2 > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Address2 > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Address2 >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Address2 >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Address2 like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where Address2 <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class CityObject
			{
				public readonly AddressWhereObject Parent = null;
				protected CityObject() { }
				public CityObject(AddressWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where City = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where City = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where City < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where City < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where City <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where City <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where City > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where City > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where City >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where City >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where City like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where City <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class DistrictObject
			{
				public readonly AddressWhereObject Parent = null;
				protected DistrictObject() { }
				public DistrictObject(AddressWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where District = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where District = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where District < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where District < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where District <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where District <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where District > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where District > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where District >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where District >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where District like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where District <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class AreaObject
			{
				public readonly AddressWhereObject Parent = null;
				protected AreaObject() { }
				public AreaObject(AddressWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Area = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Area = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Area < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Area < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Area <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Area <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Area > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Area > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Area >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Area >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Area like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where Area <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class ZipObject
			{
				public readonly AddressWhereObject Parent = null;
				protected ZipObject() { }
				public ZipObject(AddressWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Zip = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Zip = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Zip < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Zip < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Zip <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Zip <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Zip > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Zip > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Zip >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Zip >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Zip like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where Zip <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class CountryObject
			{
				public readonly AddressWhereObject Parent = null;
				protected CountryObject() { }
				public CountryObject(AddressWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Country = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Country = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Country < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Country < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Country <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Country <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Country > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Country > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Country >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Country >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Country like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where Country <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class CreatedDateObject
			{
				public readonly AddressWhereObject Parent = null;
				protected CreatedDateObject() { }
				public CreatedDateObject(AddressWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where CreatedDate <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			#endregion
		}
		#endregion

	}
	public class aspnet_Applications
	{
		public static string TableName = "aspnet_Applications";
		public string LastWhere { protected get; set; }
		#region Where
		private aspnet_ApplicationsWhereObject _whereObject = null;
		public aspnet_ApplicationsWhereObject Where
		{
			get
			{
				if (_whereObject == null)
				{
					_whereObject = new aspnet_ApplicationsWhereObject(this);
				}
				return _whereObject;
			}
		}
		#endregion

		#region Properties
		public object ApplicationName { get; set; }
		public object LoweredApplicationName { get; set; }
		public object ApplicationId { get; set; }
		public object Description { get; set; }
		#endregion

		public static class Fields
		{
			public const string ApplicationName = "ApplicationName";
			public const string LoweredApplicationName = "LoweredApplicationName";
			public const string ApplicationId = "ApplicationId";
			public const string Description = "Description";
		}
		public static string[] FieldList = {Fields.ApplicationName, Fields.LoweredApplicationName, Fields.ApplicationId, Fields.Description};

		#region Methods
		public void Insert() { DBAdapter.Insert(this); }
		public void Update() { DBAdapter.Update(this); }
		public void Delete() { DBAdapter.Delete(this); }
		public DataSet Select() { return DBAdapter.Select(this); }
		#endregion

		#region Where Object
		public class aspnet_ApplicationsWhereObject
		{
			public readonly aspnet_Applications Parent = null;
			protected aspnet_ApplicationsWhereObject(){ }
			public aspnet_ApplicationsWhereObject(aspnet_Applications parent){ this.Parent = parent; }

			private ApplicationNameObject _ApplicationName = null;
			public ApplicationNameObject ApplicationName
			{
				get
				{
					if (_ApplicationName == null)
					{
						_ApplicationName = new ApplicationNameObject(this);
					}
					return _ApplicationName;
				}
			}

			private LoweredApplicationNameObject _LoweredApplicationName = null;
			public LoweredApplicationNameObject LoweredApplicationName
			{
				get
				{
					if (_LoweredApplicationName == null)
					{
						_LoweredApplicationName = new LoweredApplicationNameObject(this);
					}
					return _LoweredApplicationName;
				}
			}

			private ApplicationIdObject _ApplicationId = null;
			public ApplicationIdObject ApplicationId
			{
				get
				{
					if (_ApplicationId == null)
					{
						_ApplicationId = new ApplicationIdObject(this);
					}
					return _ApplicationId;
				}
			}

			private DescriptionObject _Description = null;
			public DescriptionObject Description
			{
				get
				{
					if (_Description == null)
					{
						_Description = new DescriptionObject(this);
					}
					return _Description;
				}
			}

			#region Each field object
			public class ApplicationNameObject
			{
				public readonly aspnet_ApplicationsWhereObject Parent = null;
				protected ApplicationNameObject() { }
				public ApplicationNameObject(aspnet_ApplicationsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationName = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationName = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationName < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationName < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationName <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationName <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationName > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationName > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationName >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationName >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationName like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where ApplicationName <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class LoweredApplicationNameObject
			{
				public readonly aspnet_ApplicationsWhereObject Parent = null;
				protected LoweredApplicationNameObject() { }
				public LoweredApplicationNameObject(aspnet_ApplicationsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredApplicationName = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LoweredApplicationName = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredApplicationName < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LoweredApplicationName < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredApplicationName <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LoweredApplicationName <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredApplicationName > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LoweredApplicationName > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredApplicationName >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LoweredApplicationName >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredApplicationName like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where LoweredApplicationName <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class ApplicationIdObject
			{
				public readonly aspnet_ApplicationsWhereObject Parent = null;
				protected ApplicationIdObject() { }
				public ApplicationIdObject(aspnet_ApplicationsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationId = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationId < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationId > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationId >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where ApplicationId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class DescriptionObject
			{
				public readonly aspnet_ApplicationsWhereObject Parent = null;
				protected DescriptionObject() { }
				public DescriptionObject(aspnet_ApplicationsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Description = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Description = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Description < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Description < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Description <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Description <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Description > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Description > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Description >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Description >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Description like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where Description <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			#endregion
		}
		#endregion

	}
	public class aspnet_Membership
	{
		public static string TableName = "aspnet_Membership";
		public string LastWhere { protected get; set; }
		#region Where
		private aspnet_MembershipWhereObject _whereObject = null;
		public aspnet_MembershipWhereObject Where
		{
			get
			{
				if (_whereObject == null)
				{
					_whereObject = new aspnet_MembershipWhereObject(this);
				}
				return _whereObject;
			}
		}
		#endregion

		#region Properties
		public object ApplicationId { get; set; }
		public object UserId { get; set; }
		public object Password { get; set; }
		public object PasswordFormat { get; set; }
		public object PasswordSalt { get; set; }
		public object MobilePIN { get; set; }
		public object Email { get; set; }
		public object LoweredEmail { get; set; }
		public object PasswordQuestion { get; set; }
		public object PasswordAnswer { get; set; }
		public object IsApproved { get; set; }
		public object IsLockedOut { get; set; }
		public object CreateDate { get; set; }
		public object LastLoginDate { get; set; }
		public object LastPasswordChangedDate { get; set; }
		public object LastLockoutDate { get; set; }
		public object FailedPasswordAttemptCount { get; set; }
		public object FailedPasswordAttemptWindowStart { get; set; }
		public object FailedPasswordAnswerAttemptCount { get; set; }
		public object FailedPasswordAnswerAttemptWindowStart { get; set; }
		public object Comment { get; set; }
		#endregion

		public static class Fields
		{
			public const string ApplicationId = "ApplicationId";
			public const string UserId = "UserId";
			public const string Password = "Password";
			public const string PasswordFormat = "PasswordFormat";
			public const string PasswordSalt = "PasswordSalt";
			public const string MobilePIN = "MobilePIN";
			public const string Email = "Email";
			public const string LoweredEmail = "LoweredEmail";
			public const string PasswordQuestion = "PasswordQuestion";
			public const string PasswordAnswer = "PasswordAnswer";
			public const string IsApproved = "IsApproved";
			public const string IsLockedOut = "IsLockedOut";
			public const string CreateDate = "CreateDate";
			public const string LastLoginDate = "LastLoginDate";
			public const string LastPasswordChangedDate = "LastPasswordChangedDate";
			public const string LastLockoutDate = "LastLockoutDate";
			public const string FailedPasswordAttemptCount = "FailedPasswordAttemptCount";
			public const string FailedPasswordAttemptWindowStart = "FailedPasswordAttemptWindowStart";
			public const string FailedPasswordAnswerAttemptCount = "FailedPasswordAnswerAttemptCount";
			public const string FailedPasswordAnswerAttemptWindowStart = "FailedPasswordAnswerAttemptWindowStart";
			public const string Comment = "Comment";
		}
		public static string[] FieldList = {Fields.ApplicationId, Fields.UserId, Fields.Password, Fields.PasswordFormat, Fields.PasswordSalt, Fields.MobilePIN, Fields.Email, Fields.LoweredEmail, Fields.PasswordQuestion, Fields.PasswordAnswer, Fields.IsApproved, Fields.IsLockedOut, Fields.CreateDate, Fields.LastLoginDate, Fields.LastPasswordChangedDate, Fields.LastLockoutDate, Fields.FailedPasswordAttemptCount, Fields.FailedPasswordAttemptWindowStart, Fields.FailedPasswordAnswerAttemptCount, Fields.FailedPasswordAnswerAttemptWindowStart, Fields.Comment};

		#region Methods
		public void Insert() { DBAdapter.Insert(this); }
		public void Update() { DBAdapter.Update(this); }
		public void Delete() { DBAdapter.Delete(this); }
		public DataSet Select() { return DBAdapter.Select(this); }
		#endregion

		#region Where Object
		public class aspnet_MembershipWhereObject
		{
			public readonly aspnet_Membership Parent = null;
			protected aspnet_MembershipWhereObject(){ }
			public aspnet_MembershipWhereObject(aspnet_Membership parent){ this.Parent = parent; }

			private ApplicationIdObject _ApplicationId = null;
			public ApplicationIdObject ApplicationId
			{
				get
				{
					if (_ApplicationId == null)
					{
						_ApplicationId = new ApplicationIdObject(this);
					}
					return _ApplicationId;
				}
			}

			private UserIdObject _UserId = null;
			public UserIdObject UserId
			{
				get
				{
					if (_UserId == null)
					{
						_UserId = new UserIdObject(this);
					}
					return _UserId;
				}
			}

			private PasswordObject _Password = null;
			public PasswordObject Password
			{
				get
				{
					if (_Password == null)
					{
						_Password = new PasswordObject(this);
					}
					return _Password;
				}
			}

			private PasswordFormatObject _PasswordFormat = null;
			public PasswordFormatObject PasswordFormat
			{
				get
				{
					if (_PasswordFormat == null)
					{
						_PasswordFormat = new PasswordFormatObject(this);
					}
					return _PasswordFormat;
				}
			}

			private PasswordSaltObject _PasswordSalt = null;
			public PasswordSaltObject PasswordSalt
			{
				get
				{
					if (_PasswordSalt == null)
					{
						_PasswordSalt = new PasswordSaltObject(this);
					}
					return _PasswordSalt;
				}
			}

			private MobilePINObject _MobilePIN = null;
			public MobilePINObject MobilePIN
			{
				get
				{
					if (_MobilePIN == null)
					{
						_MobilePIN = new MobilePINObject(this);
					}
					return _MobilePIN;
				}
			}

			private EmailObject _Email = null;
			public EmailObject Email
			{
				get
				{
					if (_Email == null)
					{
						_Email = new EmailObject(this);
					}
					return _Email;
				}
			}

			private LoweredEmailObject _LoweredEmail = null;
			public LoweredEmailObject LoweredEmail
			{
				get
				{
					if (_LoweredEmail == null)
					{
						_LoweredEmail = new LoweredEmailObject(this);
					}
					return _LoweredEmail;
				}
			}

			private PasswordQuestionObject _PasswordQuestion = null;
			public PasswordQuestionObject PasswordQuestion
			{
				get
				{
					if (_PasswordQuestion == null)
					{
						_PasswordQuestion = new PasswordQuestionObject(this);
					}
					return _PasswordQuestion;
				}
			}

			private PasswordAnswerObject _PasswordAnswer = null;
			public PasswordAnswerObject PasswordAnswer
			{
				get
				{
					if (_PasswordAnswer == null)
					{
						_PasswordAnswer = new PasswordAnswerObject(this);
					}
					return _PasswordAnswer;
				}
			}

			private IsApprovedObject _IsApproved = null;
			public IsApprovedObject IsApproved
			{
				get
				{
					if (_IsApproved == null)
					{
						_IsApproved = new IsApprovedObject(this);
					}
					return _IsApproved;
				}
			}

			private IsLockedOutObject _IsLockedOut = null;
			public IsLockedOutObject IsLockedOut
			{
				get
				{
					if (_IsLockedOut == null)
					{
						_IsLockedOut = new IsLockedOutObject(this);
					}
					return _IsLockedOut;
				}
			}

			private CreateDateObject _CreateDate = null;
			public CreateDateObject CreateDate
			{
				get
				{
					if (_CreateDate == null)
					{
						_CreateDate = new CreateDateObject(this);
					}
					return _CreateDate;
				}
			}

			private LastLoginDateObject _LastLoginDate = null;
			public LastLoginDateObject LastLoginDate
			{
				get
				{
					if (_LastLoginDate == null)
					{
						_LastLoginDate = new LastLoginDateObject(this);
					}
					return _LastLoginDate;
				}
			}

			private LastPasswordChangedDateObject _LastPasswordChangedDate = null;
			public LastPasswordChangedDateObject LastPasswordChangedDate
			{
				get
				{
					if (_LastPasswordChangedDate == null)
					{
						_LastPasswordChangedDate = new LastPasswordChangedDateObject(this);
					}
					return _LastPasswordChangedDate;
				}
			}

			private LastLockoutDateObject _LastLockoutDate = null;
			public LastLockoutDateObject LastLockoutDate
			{
				get
				{
					if (_LastLockoutDate == null)
					{
						_LastLockoutDate = new LastLockoutDateObject(this);
					}
					return _LastLockoutDate;
				}
			}

			private FailedPasswordAttemptCountObject _FailedPasswordAttemptCount = null;
			public FailedPasswordAttemptCountObject FailedPasswordAttemptCount
			{
				get
				{
					if (_FailedPasswordAttemptCount == null)
					{
						_FailedPasswordAttemptCount = new FailedPasswordAttemptCountObject(this);
					}
					return _FailedPasswordAttemptCount;
				}
			}

			private FailedPasswordAttemptWindowStartObject _FailedPasswordAttemptWindowStart = null;
			public FailedPasswordAttemptWindowStartObject FailedPasswordAttemptWindowStart
			{
				get
				{
					if (_FailedPasswordAttemptWindowStart == null)
					{
						_FailedPasswordAttemptWindowStart = new FailedPasswordAttemptWindowStartObject(this);
					}
					return _FailedPasswordAttemptWindowStart;
				}
			}

			private FailedPasswordAnswerAttemptCountObject _FailedPasswordAnswerAttemptCount = null;
			public FailedPasswordAnswerAttemptCountObject FailedPasswordAnswerAttemptCount
			{
				get
				{
					if (_FailedPasswordAnswerAttemptCount == null)
					{
						_FailedPasswordAnswerAttemptCount = new FailedPasswordAnswerAttemptCountObject(this);
					}
					return _FailedPasswordAnswerAttemptCount;
				}
			}

			private FailedPasswordAnswerAttemptWindowStartObject _FailedPasswordAnswerAttemptWindowStart = null;
			public FailedPasswordAnswerAttemptWindowStartObject FailedPasswordAnswerAttemptWindowStart
			{
				get
				{
					if (_FailedPasswordAnswerAttemptWindowStart == null)
					{
						_FailedPasswordAnswerAttemptWindowStart = new FailedPasswordAnswerAttemptWindowStartObject(this);
					}
					return _FailedPasswordAnswerAttemptWindowStart;
				}
			}

			private CommentObject _Comment = null;
			public CommentObject Comment
			{
				get
				{
					if (_Comment == null)
					{
						_Comment = new CommentObject(this);
					}
					return _Comment;
				}
			}

			#region Each field object
			public class ApplicationIdObject
			{
				public readonly aspnet_MembershipWhereObject Parent = null;
				protected ApplicationIdObject() { }
				public ApplicationIdObject(aspnet_MembershipWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationId = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationId < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationId > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationId >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where ApplicationId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class UserIdObject
			{
				public readonly aspnet_MembershipWhereObject Parent = null;
				protected UserIdObject() { }
				public UserIdObject(aspnet_MembershipWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserId = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserId < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserId > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserId >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where UserId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class PasswordObject
			{
				public readonly aspnet_MembershipWhereObject Parent = null;
				protected PasswordObject() { }
				public PasswordObject(aspnet_MembershipWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Password = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Password = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Password < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Password < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Password <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Password <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Password > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Password > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Password >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Password >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Password like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where Password <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class PasswordFormatObject
			{
				public readonly aspnet_MembershipWhereObject Parent = null;
				protected PasswordFormatObject() { }
				public PasswordFormatObject(aspnet_MembershipWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PasswordFormat = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PasswordFormat = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PasswordFormat < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PasswordFormat < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PasswordFormat <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PasswordFormat <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PasswordFormat > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PasswordFormat > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PasswordFormat >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PasswordFormat >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PasswordFormat like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where PasswordFormat <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class PasswordSaltObject
			{
				public readonly aspnet_MembershipWhereObject Parent = null;
				protected PasswordSaltObject() { }
				public PasswordSaltObject(aspnet_MembershipWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PasswordSalt = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PasswordSalt = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PasswordSalt < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PasswordSalt < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PasswordSalt <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PasswordSalt <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PasswordSalt > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PasswordSalt > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PasswordSalt >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PasswordSalt >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PasswordSalt like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where PasswordSalt <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class MobilePINObject
			{
				public readonly aspnet_MembershipWhereObject Parent = null;
				protected MobilePINObject() { }
				public MobilePINObject(aspnet_MembershipWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MobilePIN = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MobilePIN = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MobilePIN < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MobilePIN < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MobilePIN <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MobilePIN <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MobilePIN > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MobilePIN > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MobilePIN >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MobilePIN >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MobilePIN like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where MobilePIN <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class EmailObject
			{
				public readonly aspnet_MembershipWhereObject Parent = null;
				protected EmailObject() { }
				public EmailObject(aspnet_MembershipWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Email = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Email = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Email < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Email < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Email <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Email <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Email > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Email > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Email >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Email >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Email like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where Email <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class LoweredEmailObject
			{
				public readonly aspnet_MembershipWhereObject Parent = null;
				protected LoweredEmailObject() { }
				public LoweredEmailObject(aspnet_MembershipWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredEmail = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LoweredEmail = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredEmail < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LoweredEmail < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredEmail <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LoweredEmail <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredEmail > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LoweredEmail > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredEmail >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LoweredEmail >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredEmail like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where LoweredEmail <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class PasswordQuestionObject
			{
				public readonly aspnet_MembershipWhereObject Parent = null;
				protected PasswordQuestionObject() { }
				public PasswordQuestionObject(aspnet_MembershipWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PasswordQuestion = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PasswordQuestion = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PasswordQuestion < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PasswordQuestion < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PasswordQuestion <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PasswordQuestion <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PasswordQuestion > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PasswordQuestion > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PasswordQuestion >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PasswordQuestion >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PasswordQuestion like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where PasswordQuestion <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class PasswordAnswerObject
			{
				public readonly aspnet_MembershipWhereObject Parent = null;
				protected PasswordAnswerObject() { }
				public PasswordAnswerObject(aspnet_MembershipWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PasswordAnswer = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PasswordAnswer = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PasswordAnswer < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PasswordAnswer < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PasswordAnswer <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PasswordAnswer <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PasswordAnswer > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PasswordAnswer > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PasswordAnswer >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PasswordAnswer >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PasswordAnswer like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where PasswordAnswer <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class IsApprovedObject
			{
				public readonly aspnet_MembershipWhereObject Parent = null;
				protected IsApprovedObject() { }
				public IsApprovedObject(aspnet_MembershipWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where IsApproved = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where IsApproved = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where IsApproved < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where IsApproved < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where IsApproved <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where IsApproved <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where IsApproved > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where IsApproved > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where IsApproved >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where IsApproved >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where IsApproved like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where IsApproved <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class IsLockedOutObject
			{
				public readonly aspnet_MembershipWhereObject Parent = null;
				protected IsLockedOutObject() { }
				public IsLockedOutObject(aspnet_MembershipWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where IsLockedOut = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where IsLockedOut = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where IsLockedOut < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where IsLockedOut < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where IsLockedOut <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where IsLockedOut <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where IsLockedOut > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where IsLockedOut > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where IsLockedOut >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where IsLockedOut >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where IsLockedOut like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where IsLockedOut <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class CreateDateObject
			{
				public readonly aspnet_MembershipWhereObject Parent = null;
				protected CreateDateObject() { }
				public CreateDateObject(aspnet_MembershipWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreateDate = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreateDate = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreateDate < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreateDate < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreateDate <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreateDate <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreateDate > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreateDate > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreateDate >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreateDate >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreateDate like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where CreateDate <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class LastLoginDateObject
			{
				public readonly aspnet_MembershipWhereObject Parent = null;
				protected LastLoginDateObject() { }
				public LastLoginDateObject(aspnet_MembershipWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastLoginDate = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastLoginDate = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastLoginDate < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastLoginDate < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastLoginDate <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastLoginDate <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastLoginDate > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastLoginDate > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastLoginDate >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastLoginDate >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastLoginDate like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where LastLoginDate <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class LastPasswordChangedDateObject
			{
				public readonly aspnet_MembershipWhereObject Parent = null;
				protected LastPasswordChangedDateObject() { }
				public LastPasswordChangedDateObject(aspnet_MembershipWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastPasswordChangedDate = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastPasswordChangedDate = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastPasswordChangedDate < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastPasswordChangedDate < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastPasswordChangedDate <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastPasswordChangedDate <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastPasswordChangedDate > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastPasswordChangedDate > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastPasswordChangedDate >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastPasswordChangedDate >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastPasswordChangedDate like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where LastPasswordChangedDate <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class LastLockoutDateObject
			{
				public readonly aspnet_MembershipWhereObject Parent = null;
				protected LastLockoutDateObject() { }
				public LastLockoutDateObject(aspnet_MembershipWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastLockoutDate = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastLockoutDate = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastLockoutDate < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastLockoutDate < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastLockoutDate <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastLockoutDate <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastLockoutDate > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastLockoutDate > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastLockoutDate >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastLockoutDate >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastLockoutDate like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where LastLockoutDate <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class FailedPasswordAttemptCountObject
			{
				public readonly aspnet_MembershipWhereObject Parent = null;
				protected FailedPasswordAttemptCountObject() { }
				public FailedPasswordAttemptCountObject(aspnet_MembershipWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FailedPasswordAttemptCount = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FailedPasswordAttemptCount = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FailedPasswordAttemptCount < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FailedPasswordAttemptCount < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FailedPasswordAttemptCount <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FailedPasswordAttemptCount <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FailedPasswordAttemptCount > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FailedPasswordAttemptCount > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FailedPasswordAttemptCount >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FailedPasswordAttemptCount >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FailedPasswordAttemptCount like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where FailedPasswordAttemptCount <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class FailedPasswordAttemptWindowStartObject
			{
				public readonly aspnet_MembershipWhereObject Parent = null;
				protected FailedPasswordAttemptWindowStartObject() { }
				public FailedPasswordAttemptWindowStartObject(aspnet_MembershipWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FailedPasswordAttemptWindowStart = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FailedPasswordAttemptWindowStart = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FailedPasswordAttemptWindowStart < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FailedPasswordAttemptWindowStart < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FailedPasswordAttemptWindowStart <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FailedPasswordAttemptWindowStart <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FailedPasswordAttemptWindowStart > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FailedPasswordAttemptWindowStart > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FailedPasswordAttemptWindowStart >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FailedPasswordAttemptWindowStart >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FailedPasswordAttemptWindowStart like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where FailedPasswordAttemptWindowStart <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class FailedPasswordAnswerAttemptCountObject
			{
				public readonly aspnet_MembershipWhereObject Parent = null;
				protected FailedPasswordAnswerAttemptCountObject() { }
				public FailedPasswordAnswerAttemptCountObject(aspnet_MembershipWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FailedPasswordAnswerAttemptCount = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FailedPasswordAnswerAttemptCount = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FailedPasswordAnswerAttemptCount < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FailedPasswordAnswerAttemptCount < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FailedPasswordAnswerAttemptCount <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FailedPasswordAnswerAttemptCount <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FailedPasswordAnswerAttemptCount > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FailedPasswordAnswerAttemptCount > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FailedPasswordAnswerAttemptCount >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FailedPasswordAnswerAttemptCount >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FailedPasswordAnswerAttemptCount like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where FailedPasswordAnswerAttemptCount <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class FailedPasswordAnswerAttemptWindowStartObject
			{
				public readonly aspnet_MembershipWhereObject Parent = null;
				protected FailedPasswordAnswerAttemptWindowStartObject() { }
				public FailedPasswordAnswerAttemptWindowStartObject(aspnet_MembershipWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FailedPasswordAnswerAttemptWindowStart = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FailedPasswordAnswerAttemptWindowStart = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FailedPasswordAnswerAttemptWindowStart < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FailedPasswordAnswerAttemptWindowStart < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FailedPasswordAnswerAttemptWindowStart <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FailedPasswordAnswerAttemptWindowStart <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FailedPasswordAnswerAttemptWindowStart > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FailedPasswordAnswerAttemptWindowStart > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FailedPasswordAnswerAttemptWindowStart >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FailedPasswordAnswerAttemptWindowStart >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FailedPasswordAnswerAttemptWindowStart like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where FailedPasswordAnswerAttemptWindowStart <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class CommentObject
			{
				public readonly aspnet_MembershipWhereObject Parent = null;
				protected CommentObject() { }
				public CommentObject(aspnet_MembershipWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Comment = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Comment = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Comment < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Comment < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Comment <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Comment <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Comment > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Comment > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Comment >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Comment >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Comment like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where Comment <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			#endregion
		}
		#endregion

	}
	public class aspnet_Paths
	{
		public static string TableName = "aspnet_Paths";
		public string LastWhere { protected get; set; }
		#region Where
		private aspnet_PathsWhereObject _whereObject = null;
		public aspnet_PathsWhereObject Where
		{
			get
			{
				if (_whereObject == null)
				{
					_whereObject = new aspnet_PathsWhereObject(this);
				}
				return _whereObject;
			}
		}
		#endregion

		#region Properties
		public object ApplicationId { get; set; }
		public object PathId { get; set; }
		public object Path { get; set; }
		public object LoweredPath { get; set; }
		#endregion

		public static class Fields
		{
			public const string ApplicationId = "ApplicationId";
			public const string PathId = "PathId";
			public const string Path = "Path";
			public const string LoweredPath = "LoweredPath";
		}
		public static string[] FieldList = {Fields.ApplicationId, Fields.PathId, Fields.Path, Fields.LoweredPath};

		#region Methods
		public void Insert() { DBAdapter.Insert(this); }
		public void Update() { DBAdapter.Update(this); }
		public void Delete() { DBAdapter.Delete(this); }
		public DataSet Select() { return DBAdapter.Select(this); }
		#endregion

		#region Where Object
		public class aspnet_PathsWhereObject
		{
			public readonly aspnet_Paths Parent = null;
			protected aspnet_PathsWhereObject(){ }
			public aspnet_PathsWhereObject(aspnet_Paths parent){ this.Parent = parent; }

			private ApplicationIdObject _ApplicationId = null;
			public ApplicationIdObject ApplicationId
			{
				get
				{
					if (_ApplicationId == null)
					{
						_ApplicationId = new ApplicationIdObject(this);
					}
					return _ApplicationId;
				}
			}

			private PathIdObject _PathId = null;
			public PathIdObject PathId
			{
				get
				{
					if (_PathId == null)
					{
						_PathId = new PathIdObject(this);
					}
					return _PathId;
				}
			}

			private PathObject _Path = null;
			public PathObject Path
			{
				get
				{
					if (_Path == null)
					{
						_Path = new PathObject(this);
					}
					return _Path;
				}
			}

			private LoweredPathObject _LoweredPath = null;
			public LoweredPathObject LoweredPath
			{
				get
				{
					if (_LoweredPath == null)
					{
						_LoweredPath = new LoweredPathObject(this);
					}
					return _LoweredPath;
				}
			}

			#region Each field object
			public class ApplicationIdObject
			{
				public readonly aspnet_PathsWhereObject Parent = null;
				protected ApplicationIdObject() { }
				public ApplicationIdObject(aspnet_PathsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationId = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationId < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationId > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationId >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where ApplicationId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class PathIdObject
			{
				public readonly aspnet_PathsWhereObject Parent = null;
				protected PathIdObject() { }
				public PathIdObject(aspnet_PathsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PathId = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PathId = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PathId < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PathId < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PathId <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PathId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PathId > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PathId > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PathId >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PathId >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PathId like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where PathId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class PathObject
			{
				public readonly aspnet_PathsWhereObject Parent = null;
				protected PathObject() { }
				public PathObject(aspnet_PathsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Path = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Path = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Path < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Path < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Path <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Path <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Path > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Path > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Path >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Path >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Path like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where Path <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class LoweredPathObject
			{
				public readonly aspnet_PathsWhereObject Parent = null;
				protected LoweredPathObject() { }
				public LoweredPathObject(aspnet_PathsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredPath = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LoweredPath = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredPath < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LoweredPath < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredPath <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LoweredPath <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredPath > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LoweredPath > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredPath >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LoweredPath >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredPath like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where LoweredPath <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			#endregion
		}
		#endregion

	}
	public class aspnet_PersonalizationAllUsers
	{
		public static string TableName = "aspnet_PersonalizationAllUsers";
		public string LastWhere { protected get; set; }
		#region Where
		private aspnet_PersonalizationAllUsersWhereObject _whereObject = null;
		public aspnet_PersonalizationAllUsersWhereObject Where
		{
			get
			{
				if (_whereObject == null)
				{
					_whereObject = new aspnet_PersonalizationAllUsersWhereObject(this);
				}
				return _whereObject;
			}
		}
		#endregion

		#region Properties
		public object PathId { get; set; }
		public object PageSettings { get; set; }
		public object LastUpdatedDate { get; set; }
		#endregion

		public static class Fields
		{
			public const string PathId = "PathId";
			public const string PageSettings = "PageSettings";
			public const string LastUpdatedDate = "LastUpdatedDate";
		}
		public static string[] FieldList = {Fields.PathId, Fields.PageSettings, Fields.LastUpdatedDate};

		#region Methods
		public void Insert() { DBAdapter.Insert(this); }
		public void Update() { DBAdapter.Update(this); }
		public void Delete() { DBAdapter.Delete(this); }
		public DataSet Select() { return DBAdapter.Select(this); }
		#endregion

		#region Where Object
		public class aspnet_PersonalizationAllUsersWhereObject
		{
			public readonly aspnet_PersonalizationAllUsers Parent = null;
			protected aspnet_PersonalizationAllUsersWhereObject(){ }
			public aspnet_PersonalizationAllUsersWhereObject(aspnet_PersonalizationAllUsers parent){ this.Parent = parent; }

			private PathIdObject _PathId = null;
			public PathIdObject PathId
			{
				get
				{
					if (_PathId == null)
					{
						_PathId = new PathIdObject(this);
					}
					return _PathId;
				}
			}

			private PageSettingsObject _PageSettings = null;
			public PageSettingsObject PageSettings
			{
				get
				{
					if (_PageSettings == null)
					{
						_PageSettings = new PageSettingsObject(this);
					}
					return _PageSettings;
				}
			}

			private LastUpdatedDateObject _LastUpdatedDate = null;
			public LastUpdatedDateObject LastUpdatedDate
			{
				get
				{
					if (_LastUpdatedDate == null)
					{
						_LastUpdatedDate = new LastUpdatedDateObject(this);
					}
					return _LastUpdatedDate;
				}
			}

			#region Each field object
			public class PathIdObject
			{
				public readonly aspnet_PersonalizationAllUsersWhereObject Parent = null;
				protected PathIdObject() { }
				public PathIdObject(aspnet_PersonalizationAllUsersWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PathId = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PathId = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PathId < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PathId < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PathId <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PathId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PathId > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PathId > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PathId >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PathId >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PathId like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where PathId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class PageSettingsObject
			{
				public readonly aspnet_PersonalizationAllUsersWhereObject Parent = null;
				protected PageSettingsObject() { }
				public PageSettingsObject(aspnet_PersonalizationAllUsersWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PageSettings = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PageSettings = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PageSettings < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PageSettings < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PageSettings <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PageSettings <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PageSettings > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PageSettings > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PageSettings >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PageSettings >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PageSettings like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where PageSettings <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class LastUpdatedDateObject
			{
				public readonly aspnet_PersonalizationAllUsersWhereObject Parent = null;
				protected LastUpdatedDateObject() { }
				public LastUpdatedDateObject(aspnet_PersonalizationAllUsersWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastUpdatedDate = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastUpdatedDate = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastUpdatedDate < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastUpdatedDate < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastUpdatedDate <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastUpdatedDate <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastUpdatedDate > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastUpdatedDate > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastUpdatedDate >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastUpdatedDate >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastUpdatedDate like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where LastUpdatedDate <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			#endregion
		}
		#endregion

	}
	public class aspnet_PersonalizationPerUser
	{
		public static string TableName = "aspnet_PersonalizationPerUser";
		public string LastWhere { protected get; set; }
		#region Where
		private aspnet_PersonalizationPerUserWhereObject _whereObject = null;
		public aspnet_PersonalizationPerUserWhereObject Where
		{
			get
			{
				if (_whereObject == null)
				{
					_whereObject = new aspnet_PersonalizationPerUserWhereObject(this);
				}
				return _whereObject;
			}
		}
		#endregion

		#region Properties
		public object Id { get; set; }
		public object PathId { get; set; }
		public object UserId { get; set; }
		public object PageSettings { get; set; }
		public object LastUpdatedDate { get; set; }
		#endregion

		public static class Fields
		{
			public const string Id = "Id";
			public const string PathId = "PathId";
			public const string UserId = "UserId";
			public const string PageSettings = "PageSettings";
			public const string LastUpdatedDate = "LastUpdatedDate";
		}
		public static string[] FieldList = {Fields.Id, Fields.PathId, Fields.UserId, Fields.PageSettings, Fields.LastUpdatedDate};

		#region Methods
		public void Insert() { DBAdapter.Insert(this); }
		public void Update() { DBAdapter.Update(this); }
		public void Delete() { DBAdapter.Delete(this); }
		public DataSet Select() { return DBAdapter.Select(this); }
		#endregion

		#region Where Object
		public class aspnet_PersonalizationPerUserWhereObject
		{
			public readonly aspnet_PersonalizationPerUser Parent = null;
			protected aspnet_PersonalizationPerUserWhereObject(){ }
			public aspnet_PersonalizationPerUserWhereObject(aspnet_PersonalizationPerUser parent){ this.Parent = parent; }

			private IdObject _Id = null;
			public IdObject Id
			{
				get
				{
					if (_Id == null)
					{
						_Id = new IdObject(this);
					}
					return _Id;
				}
			}

			private PathIdObject _PathId = null;
			public PathIdObject PathId
			{
				get
				{
					if (_PathId == null)
					{
						_PathId = new PathIdObject(this);
					}
					return _PathId;
				}
			}

			private UserIdObject _UserId = null;
			public UserIdObject UserId
			{
				get
				{
					if (_UserId == null)
					{
						_UserId = new UserIdObject(this);
					}
					return _UserId;
				}
			}

			private PageSettingsObject _PageSettings = null;
			public PageSettingsObject PageSettings
			{
				get
				{
					if (_PageSettings == null)
					{
						_PageSettings = new PageSettingsObject(this);
					}
					return _PageSettings;
				}
			}

			private LastUpdatedDateObject _LastUpdatedDate = null;
			public LastUpdatedDateObject LastUpdatedDate
			{
				get
				{
					if (_LastUpdatedDate == null)
					{
						_LastUpdatedDate = new LastUpdatedDateObject(this);
					}
					return _LastUpdatedDate;
				}
			}

			#region Each field object
			public class IdObject
			{
				public readonly aspnet_PersonalizationPerUserWhereObject Parent = null;
				protected IdObject() { }
				public IdObject(aspnet_PersonalizationPerUserWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Id = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Id = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Id < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Id < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Id <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Id <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Id > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Id > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Id >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Id >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Id like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where Id <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class PathIdObject
			{
				public readonly aspnet_PersonalizationPerUserWhereObject Parent = null;
				protected PathIdObject() { }
				public PathIdObject(aspnet_PersonalizationPerUserWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PathId = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PathId = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PathId < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PathId < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PathId <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PathId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PathId > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PathId > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PathId >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PathId >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PathId like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where PathId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class UserIdObject
			{
				public readonly aspnet_PersonalizationPerUserWhereObject Parent = null;
				protected UserIdObject() { }
				public UserIdObject(aspnet_PersonalizationPerUserWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserId = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserId < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserId > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserId >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where UserId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class PageSettingsObject
			{
				public readonly aspnet_PersonalizationPerUserWhereObject Parent = null;
				protected PageSettingsObject() { }
				public PageSettingsObject(aspnet_PersonalizationPerUserWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PageSettings = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PageSettings = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PageSettings < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PageSettings < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PageSettings <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PageSettings <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PageSettings > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PageSettings > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PageSettings >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PageSettings >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PageSettings like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where PageSettings <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class LastUpdatedDateObject
			{
				public readonly aspnet_PersonalizationPerUserWhereObject Parent = null;
				protected LastUpdatedDateObject() { }
				public LastUpdatedDateObject(aspnet_PersonalizationPerUserWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastUpdatedDate = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastUpdatedDate = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastUpdatedDate < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastUpdatedDate < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastUpdatedDate <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastUpdatedDate <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastUpdatedDate > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastUpdatedDate > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastUpdatedDate >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastUpdatedDate >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastUpdatedDate like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where LastUpdatedDate <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			#endregion
		}
		#endregion

	}
	public class aspnet_Profile
	{
		public static string TableName = "aspnet_Profile";
		public string LastWhere { protected get; set; }
		#region Where
		private aspnet_ProfileWhereObject _whereObject = null;
		public aspnet_ProfileWhereObject Where
		{
			get
			{
				if (_whereObject == null)
				{
					_whereObject = new aspnet_ProfileWhereObject(this);
				}
				return _whereObject;
			}
		}
		#endregion

		#region Properties
		public object UserId { get; set; }
		public object PropertyNames { get; set; }
		public object PropertyValuesString { get; set; }
		public object PropertyValuesBinary { get; set; }
		public object LastUpdatedDate { get; set; }
		#endregion

		public static class Fields
		{
			public const string UserId = "UserId";
			public const string PropertyNames = "PropertyNames";
			public const string PropertyValuesString = "PropertyValuesString";
			public const string PropertyValuesBinary = "PropertyValuesBinary";
			public const string LastUpdatedDate = "LastUpdatedDate";
		}
		public static string[] FieldList = {Fields.UserId, Fields.PropertyNames, Fields.PropertyValuesString, Fields.PropertyValuesBinary, Fields.LastUpdatedDate};

		#region Methods
		public void Insert() { DBAdapter.Insert(this); }
		public void Update() { DBAdapter.Update(this); }
		public void Delete() { DBAdapter.Delete(this); }
		public DataSet Select() { return DBAdapter.Select(this); }
		#endregion

		#region Where Object
		public class aspnet_ProfileWhereObject
		{
			public readonly aspnet_Profile Parent = null;
			protected aspnet_ProfileWhereObject(){ }
			public aspnet_ProfileWhereObject(aspnet_Profile parent){ this.Parent = parent; }

			private UserIdObject _UserId = null;
			public UserIdObject UserId
			{
				get
				{
					if (_UserId == null)
					{
						_UserId = new UserIdObject(this);
					}
					return _UserId;
				}
			}

			private PropertyNamesObject _PropertyNames = null;
			public PropertyNamesObject PropertyNames
			{
				get
				{
					if (_PropertyNames == null)
					{
						_PropertyNames = new PropertyNamesObject(this);
					}
					return _PropertyNames;
				}
			}

			private PropertyValuesStringObject _PropertyValuesString = null;
			public PropertyValuesStringObject PropertyValuesString
			{
				get
				{
					if (_PropertyValuesString == null)
					{
						_PropertyValuesString = new PropertyValuesStringObject(this);
					}
					return _PropertyValuesString;
				}
			}

			private PropertyValuesBinaryObject _PropertyValuesBinary = null;
			public PropertyValuesBinaryObject PropertyValuesBinary
			{
				get
				{
					if (_PropertyValuesBinary == null)
					{
						_PropertyValuesBinary = new PropertyValuesBinaryObject(this);
					}
					return _PropertyValuesBinary;
				}
			}

			private LastUpdatedDateObject _LastUpdatedDate = null;
			public LastUpdatedDateObject LastUpdatedDate
			{
				get
				{
					if (_LastUpdatedDate == null)
					{
						_LastUpdatedDate = new LastUpdatedDateObject(this);
					}
					return _LastUpdatedDate;
				}
			}

			#region Each field object
			public class UserIdObject
			{
				public readonly aspnet_ProfileWhereObject Parent = null;
				protected UserIdObject() { }
				public UserIdObject(aspnet_ProfileWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserId = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserId < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserId > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserId >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where UserId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class PropertyNamesObject
			{
				public readonly aspnet_ProfileWhereObject Parent = null;
				protected PropertyNamesObject() { }
				public PropertyNamesObject(aspnet_ProfileWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PropertyNames = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PropertyNames = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PropertyNames < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PropertyNames < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PropertyNames <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PropertyNames <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PropertyNames > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PropertyNames > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PropertyNames >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PropertyNames >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PropertyNames like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where PropertyNames <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class PropertyValuesStringObject
			{
				public readonly aspnet_ProfileWhereObject Parent = null;
				protected PropertyValuesStringObject() { }
				public PropertyValuesStringObject(aspnet_ProfileWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PropertyValuesString = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PropertyValuesString = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PropertyValuesString < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PropertyValuesString < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PropertyValuesString <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PropertyValuesString <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PropertyValuesString > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PropertyValuesString > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PropertyValuesString >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PropertyValuesString >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PropertyValuesString like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where PropertyValuesString <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class PropertyValuesBinaryObject
			{
				public readonly aspnet_ProfileWhereObject Parent = null;
				protected PropertyValuesBinaryObject() { }
				public PropertyValuesBinaryObject(aspnet_ProfileWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PropertyValuesBinary = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PropertyValuesBinary = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PropertyValuesBinary < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PropertyValuesBinary < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PropertyValuesBinary <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PropertyValuesBinary <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PropertyValuesBinary > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PropertyValuesBinary > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PropertyValuesBinary >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PropertyValuesBinary >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PropertyValuesBinary like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where PropertyValuesBinary <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class LastUpdatedDateObject
			{
				public readonly aspnet_ProfileWhereObject Parent = null;
				protected LastUpdatedDateObject() { }
				public LastUpdatedDateObject(aspnet_ProfileWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastUpdatedDate = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastUpdatedDate = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastUpdatedDate < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastUpdatedDate < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastUpdatedDate <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastUpdatedDate <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastUpdatedDate > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastUpdatedDate > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastUpdatedDate >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastUpdatedDate >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastUpdatedDate like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where LastUpdatedDate <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			#endregion
		}
		#endregion

	}
	public class aspnet_Roles
	{
		public static string TableName = "aspnet_Roles";
		public string LastWhere { protected get; set; }
		#region Where
		private aspnet_RolesWhereObject _whereObject = null;
		public aspnet_RolesWhereObject Where
		{
			get
			{
				if (_whereObject == null)
				{
					_whereObject = new aspnet_RolesWhereObject(this);
				}
				return _whereObject;
			}
		}
		#endregion

		#region Properties
		public object ApplicationId { get; set; }
		public object RoleId { get; set; }
		public object RoleName { get; set; }
		public object LoweredRoleName { get; set; }
		public object Description { get; set; }
		#endregion

		public static class Fields
		{
			public const string ApplicationId = "ApplicationId";
			public const string RoleId = "RoleId";
			public const string RoleName = "RoleName";
			public const string LoweredRoleName = "LoweredRoleName";
			public const string Description = "Description";
		}
		public static string[] FieldList = {Fields.ApplicationId, Fields.RoleId, Fields.RoleName, Fields.LoweredRoleName, Fields.Description};

		#region Methods
		public void Insert() { DBAdapter.Insert(this); }
		public void Update() { DBAdapter.Update(this); }
		public void Delete() { DBAdapter.Delete(this); }
		public DataSet Select() { return DBAdapter.Select(this); }
		#endregion

		#region Where Object
		public class aspnet_RolesWhereObject
		{
			public readonly aspnet_Roles Parent = null;
			protected aspnet_RolesWhereObject(){ }
			public aspnet_RolesWhereObject(aspnet_Roles parent){ this.Parent = parent; }

			private ApplicationIdObject _ApplicationId = null;
			public ApplicationIdObject ApplicationId
			{
				get
				{
					if (_ApplicationId == null)
					{
						_ApplicationId = new ApplicationIdObject(this);
					}
					return _ApplicationId;
				}
			}

			private RoleIdObject _RoleId = null;
			public RoleIdObject RoleId
			{
				get
				{
					if (_RoleId == null)
					{
						_RoleId = new RoleIdObject(this);
					}
					return _RoleId;
				}
			}

			private RoleNameObject _RoleName = null;
			public RoleNameObject RoleName
			{
				get
				{
					if (_RoleName == null)
					{
						_RoleName = new RoleNameObject(this);
					}
					return _RoleName;
				}
			}

			private LoweredRoleNameObject _LoweredRoleName = null;
			public LoweredRoleNameObject LoweredRoleName
			{
				get
				{
					if (_LoweredRoleName == null)
					{
						_LoweredRoleName = new LoweredRoleNameObject(this);
					}
					return _LoweredRoleName;
				}
			}

			private DescriptionObject _Description = null;
			public DescriptionObject Description
			{
				get
				{
					if (_Description == null)
					{
						_Description = new DescriptionObject(this);
					}
					return _Description;
				}
			}

			#region Each field object
			public class ApplicationIdObject
			{
				public readonly aspnet_RolesWhereObject Parent = null;
				protected ApplicationIdObject() { }
				public ApplicationIdObject(aspnet_RolesWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationId = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationId < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationId > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationId >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where ApplicationId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class RoleIdObject
			{
				public readonly aspnet_RolesWhereObject Parent = null;
				protected RoleIdObject() { }
				public RoleIdObject(aspnet_RolesWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RoleId = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RoleId = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RoleId < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RoleId < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RoleId <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RoleId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RoleId > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RoleId > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RoleId >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RoleId >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RoleId like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where RoleId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class RoleNameObject
			{
				public readonly aspnet_RolesWhereObject Parent = null;
				protected RoleNameObject() { }
				public RoleNameObject(aspnet_RolesWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RoleName = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RoleName = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RoleName < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RoleName < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RoleName <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RoleName <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RoleName > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RoleName > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RoleName >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RoleName >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RoleName like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where RoleName <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class LoweredRoleNameObject
			{
				public readonly aspnet_RolesWhereObject Parent = null;
				protected LoweredRoleNameObject() { }
				public LoweredRoleNameObject(aspnet_RolesWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredRoleName = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LoweredRoleName = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredRoleName < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LoweredRoleName < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredRoleName <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LoweredRoleName <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredRoleName > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LoweredRoleName > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredRoleName >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LoweredRoleName >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredRoleName like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where LoweredRoleName <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class DescriptionObject
			{
				public readonly aspnet_RolesWhereObject Parent = null;
				protected DescriptionObject() { }
				public DescriptionObject(aspnet_RolesWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Description = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Description = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Description < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Description < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Description <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Description <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Description > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Description > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Description >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Description >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Description like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where Description <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			#endregion
		}
		#endregion

	}
	public class aspnet_SchemaVersions
	{
		public static string TableName = "aspnet_SchemaVersions";
		public string LastWhere { protected get; set; }
		#region Where
		private aspnet_SchemaVersionsWhereObject _whereObject = null;
		public aspnet_SchemaVersionsWhereObject Where
		{
			get
			{
				if (_whereObject == null)
				{
					_whereObject = new aspnet_SchemaVersionsWhereObject(this);
				}
				return _whereObject;
			}
		}
		#endregion

		#region Properties
		public object Feature { get; set; }
		public object CompatibleSchemaVersion { get; set; }
		public object IsCurrentVersion { get; set; }
		#endregion

		public static class Fields
		{
			public const string Feature = "Feature";
			public const string CompatibleSchemaVersion = "CompatibleSchemaVersion";
			public const string IsCurrentVersion = "IsCurrentVersion";
		}
		public static string[] FieldList = {Fields.Feature, Fields.CompatibleSchemaVersion, Fields.IsCurrentVersion};

		#region Methods
		public void Insert() { DBAdapter.Insert(this); }
		public void Update() { DBAdapter.Update(this); }
		public void Delete() { DBAdapter.Delete(this); }
		public DataSet Select() { return DBAdapter.Select(this); }
		#endregion

		#region Where Object
		public class aspnet_SchemaVersionsWhereObject
		{
			public readonly aspnet_SchemaVersions Parent = null;
			protected aspnet_SchemaVersionsWhereObject(){ }
			public aspnet_SchemaVersionsWhereObject(aspnet_SchemaVersions parent){ this.Parent = parent; }

			private FeatureObject _Feature = null;
			public FeatureObject Feature
			{
				get
				{
					if (_Feature == null)
					{
						_Feature = new FeatureObject(this);
					}
					return _Feature;
				}
			}

			private CompatibleSchemaVersionObject _CompatibleSchemaVersion = null;
			public CompatibleSchemaVersionObject CompatibleSchemaVersion
			{
				get
				{
					if (_CompatibleSchemaVersion == null)
					{
						_CompatibleSchemaVersion = new CompatibleSchemaVersionObject(this);
					}
					return _CompatibleSchemaVersion;
				}
			}

			private IsCurrentVersionObject _IsCurrentVersion = null;
			public IsCurrentVersionObject IsCurrentVersion
			{
				get
				{
					if (_IsCurrentVersion == null)
					{
						_IsCurrentVersion = new IsCurrentVersionObject(this);
					}
					return _IsCurrentVersion;
				}
			}

			#region Each field object
			public class FeatureObject
			{
				public readonly aspnet_SchemaVersionsWhereObject Parent = null;
				protected FeatureObject() { }
				public FeatureObject(aspnet_SchemaVersionsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Feature = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Feature = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Feature < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Feature < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Feature <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Feature <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Feature > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Feature > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Feature >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Feature >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Feature like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where Feature <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class CompatibleSchemaVersionObject
			{
				public readonly aspnet_SchemaVersionsWhereObject Parent = null;
				protected CompatibleSchemaVersionObject() { }
				public CompatibleSchemaVersionObject(aspnet_SchemaVersionsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CompatibleSchemaVersion = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CompatibleSchemaVersion = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CompatibleSchemaVersion < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CompatibleSchemaVersion < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CompatibleSchemaVersion <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CompatibleSchemaVersion <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CompatibleSchemaVersion > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CompatibleSchemaVersion > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CompatibleSchemaVersion >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CompatibleSchemaVersion >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CompatibleSchemaVersion like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where CompatibleSchemaVersion <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class IsCurrentVersionObject
			{
				public readonly aspnet_SchemaVersionsWhereObject Parent = null;
				protected IsCurrentVersionObject() { }
				public IsCurrentVersionObject(aspnet_SchemaVersionsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where IsCurrentVersion = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where IsCurrentVersion = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where IsCurrentVersion < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where IsCurrentVersion < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where IsCurrentVersion <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where IsCurrentVersion <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where IsCurrentVersion > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where IsCurrentVersion > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where IsCurrentVersion >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where IsCurrentVersion >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where IsCurrentVersion like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where IsCurrentVersion <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			#endregion
		}
		#endregion

	}
	public class aspnet_Users
	{
		public static string TableName = "aspnet_Users";
		public string LastWhere { protected get; set; }
		#region Where
		private aspnet_UsersWhereObject _whereObject = null;
		public aspnet_UsersWhereObject Where
		{
			get
			{
				if (_whereObject == null)
				{
					_whereObject = new aspnet_UsersWhereObject(this);
				}
				return _whereObject;
			}
		}
		#endregion

		#region Properties
		public object ApplicationId { get; set; }
		public object UserId { get; set; }
		public object UserName { get; set; }
		public object LoweredUserName { get; set; }
		public object MobileAlias { get; set; }
		public object IsAnonymous { get; set; }
		public object LastActivityDate { get; set; }
		#endregion

		public static class Fields
		{
			public const string ApplicationId = "ApplicationId";
			public const string UserId = "UserId";
			public const string UserName = "UserName";
			public const string LoweredUserName = "LoweredUserName";
			public const string MobileAlias = "MobileAlias";
			public const string IsAnonymous = "IsAnonymous";
			public const string LastActivityDate = "LastActivityDate";
		}
		public static string[] FieldList = {Fields.ApplicationId, Fields.UserId, Fields.UserName, Fields.LoweredUserName, Fields.MobileAlias, Fields.IsAnonymous, Fields.LastActivityDate};

		#region Methods
		public void Insert() { DBAdapter.Insert(this); }
		public void Update() { DBAdapter.Update(this); }
		public void Delete() { DBAdapter.Delete(this); }
		public DataSet Select() { return DBAdapter.Select(this); }
		#endregion

		#region Where Object
		public class aspnet_UsersWhereObject
		{
			public readonly aspnet_Users Parent = null;
			protected aspnet_UsersWhereObject(){ }
			public aspnet_UsersWhereObject(aspnet_Users parent){ this.Parent = parent; }

			private ApplicationIdObject _ApplicationId = null;
			public ApplicationIdObject ApplicationId
			{
				get
				{
					if (_ApplicationId == null)
					{
						_ApplicationId = new ApplicationIdObject(this);
					}
					return _ApplicationId;
				}
			}

			private UserIdObject _UserId = null;
			public UserIdObject UserId
			{
				get
				{
					if (_UserId == null)
					{
						_UserId = new UserIdObject(this);
					}
					return _UserId;
				}
			}

			private UserNameObject _UserName = null;
			public UserNameObject UserName
			{
				get
				{
					if (_UserName == null)
					{
						_UserName = new UserNameObject(this);
					}
					return _UserName;
				}
			}

			private LoweredUserNameObject _LoweredUserName = null;
			public LoweredUserNameObject LoweredUserName
			{
				get
				{
					if (_LoweredUserName == null)
					{
						_LoweredUserName = new LoweredUserNameObject(this);
					}
					return _LoweredUserName;
				}
			}

			private MobileAliasObject _MobileAlias = null;
			public MobileAliasObject MobileAlias
			{
				get
				{
					if (_MobileAlias == null)
					{
						_MobileAlias = new MobileAliasObject(this);
					}
					return _MobileAlias;
				}
			}

			private IsAnonymousObject _IsAnonymous = null;
			public IsAnonymousObject IsAnonymous
			{
				get
				{
					if (_IsAnonymous == null)
					{
						_IsAnonymous = new IsAnonymousObject(this);
					}
					return _IsAnonymous;
				}
			}

			private LastActivityDateObject _LastActivityDate = null;
			public LastActivityDateObject LastActivityDate
			{
				get
				{
					if (_LastActivityDate == null)
					{
						_LastActivityDate = new LastActivityDateObject(this);
					}
					return _LastActivityDate;
				}
			}

			#region Each field object
			public class ApplicationIdObject
			{
				public readonly aspnet_UsersWhereObject Parent = null;
				protected ApplicationIdObject() { }
				public ApplicationIdObject(aspnet_UsersWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationId = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationId < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationId > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationId >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationId like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where ApplicationId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class UserIdObject
			{
				public readonly aspnet_UsersWhereObject Parent = null;
				protected UserIdObject() { }
				public UserIdObject(aspnet_UsersWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserId = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserId < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserId > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserId >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where UserId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class UserNameObject
			{
				public readonly aspnet_UsersWhereObject Parent = null;
				protected UserNameObject() { }
				public UserNameObject(aspnet_UsersWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserName = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserName = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserName < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserName < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserName <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserName <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserName > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserName > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserName >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserName >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserName like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where UserName <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class LoweredUserNameObject
			{
				public readonly aspnet_UsersWhereObject Parent = null;
				protected LoweredUserNameObject() { }
				public LoweredUserNameObject(aspnet_UsersWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredUserName = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LoweredUserName = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredUserName < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LoweredUserName < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredUserName <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LoweredUserName <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredUserName > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LoweredUserName > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredUserName >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LoweredUserName >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LoweredUserName like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where LoweredUserName <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class MobileAliasObject
			{
				public readonly aspnet_UsersWhereObject Parent = null;
				protected MobileAliasObject() { }
				public MobileAliasObject(aspnet_UsersWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MobileAlias = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MobileAlias = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MobileAlias < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MobileAlias < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MobileAlias <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MobileAlias <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MobileAlias > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MobileAlias > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MobileAlias >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MobileAlias >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MobileAlias like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where MobileAlias <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class IsAnonymousObject
			{
				public readonly aspnet_UsersWhereObject Parent = null;
				protected IsAnonymousObject() { }
				public IsAnonymousObject(aspnet_UsersWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where IsAnonymous = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where IsAnonymous = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where IsAnonymous < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where IsAnonymous < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where IsAnonymous <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where IsAnonymous <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where IsAnonymous > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where IsAnonymous > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where IsAnonymous >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where IsAnonymous >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where IsAnonymous like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where IsAnonymous <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class LastActivityDateObject
			{
				public readonly aspnet_UsersWhereObject Parent = null;
				protected LastActivityDateObject() { }
				public LastActivityDateObject(aspnet_UsersWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastActivityDate = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastActivityDate = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastActivityDate < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastActivityDate < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastActivityDate <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastActivityDate <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastActivityDate > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastActivityDate > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastActivityDate >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastActivityDate >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastActivityDate like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where LastActivityDate <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			#endregion
		}
		#endregion

	}
	public class aspnet_UsersInRoles
	{
		public static string TableName = "aspnet_UsersInRoles";
		public string LastWhere { protected get; set; }
		#region Where
		private aspnet_UsersInRolesWhereObject _whereObject = null;
		public aspnet_UsersInRolesWhereObject Where
		{
			get
			{
				if (_whereObject == null)
				{
					_whereObject = new aspnet_UsersInRolesWhereObject(this);
				}
				return _whereObject;
			}
		}
		#endregion

		#region Properties
		public object UserId { get; set; }
		public object RoleId { get; set; }
		#endregion

		public static class Fields
		{
			public const string UserId = "UserId";
			public const string RoleId = "RoleId";
		}
		public static string[] FieldList = {Fields.UserId, Fields.RoleId};

		#region Methods
		public void Insert() { DBAdapter.Insert(this); }
		public void Update() { DBAdapter.Update(this); }
		public void Delete() { DBAdapter.Delete(this); }
		public DataSet Select() { return DBAdapter.Select(this); }
		#endregion

		#region Where Object
		public class aspnet_UsersInRolesWhereObject
		{
			public readonly aspnet_UsersInRoles Parent = null;
			protected aspnet_UsersInRolesWhereObject(){ }
			public aspnet_UsersInRolesWhereObject(aspnet_UsersInRoles parent){ this.Parent = parent; }

			private UserIdObject _UserId = null;
			public UserIdObject UserId
			{
				get
				{
					if (_UserId == null)
					{
						_UserId = new UserIdObject(this);
					}
					return _UserId;
				}
			}

			private RoleIdObject _RoleId = null;
			public RoleIdObject RoleId
			{
				get
				{
					if (_RoleId == null)
					{
						_RoleId = new RoleIdObject(this);
					}
					return _RoleId;
				}
			}

			#region Each field object
			public class UserIdObject
			{
				public readonly aspnet_UsersInRolesWhereObject Parent = null;
				protected UserIdObject() { }
				public UserIdObject(aspnet_UsersInRolesWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserId = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserId < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserId > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where UserId >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where UserId like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where UserId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class RoleIdObject
			{
				public readonly aspnet_UsersInRolesWhereObject Parent = null;
				protected RoleIdObject() { }
				public RoleIdObject(aspnet_UsersInRolesWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RoleId = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RoleId = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RoleId < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RoleId < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RoleId <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RoleId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RoleId > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RoleId > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RoleId >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RoleId >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RoleId like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where RoleId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			#endregion
		}
		#endregion

	}
	public class aspnet_WebEvent_Events
	{
		public static string TableName = "aspnet_WebEvent_Events";
		public string LastWhere { protected get; set; }
		#region Where
		private aspnet_WebEvent_EventsWhereObject _whereObject = null;
		public aspnet_WebEvent_EventsWhereObject Where
		{
			get
			{
				if (_whereObject == null)
				{
					_whereObject = new aspnet_WebEvent_EventsWhereObject(this);
				}
				return _whereObject;
			}
		}
		#endregion

		#region Properties
		public object EventId { get; set; }
		public object EventTimeUtc { get; set; }
		public object EventTime { get; set; }
		public object EventType { get; set; }
		public object EventSequence { get; set; }
		public object EventOccurrence { get; set; }
		public object EventCode { get; set; }
		public object EventDetailCode { get; set; }
		public object Message { get; set; }
		public object ApplicationPath { get; set; }
		public object ApplicationVirtualPath { get; set; }
		public object MachineName { get; set; }
		public object RequestUrl { get; set; }
		public object ExceptionType { get; set; }
		public object Details { get; set; }
		#endregion

		public static class Fields
		{
			public const string EventId = "EventId";
			public const string EventTimeUtc = "EventTimeUtc";
			public const string EventTime = "EventTime";
			public const string EventType = "EventType";
			public const string EventSequence = "EventSequence";
			public const string EventOccurrence = "EventOccurrence";
			public const string EventCode = "EventCode";
			public const string EventDetailCode = "EventDetailCode";
			public const string Message = "Message";
			public const string ApplicationPath = "ApplicationPath";
			public const string ApplicationVirtualPath = "ApplicationVirtualPath";
			public const string MachineName = "MachineName";
			public const string RequestUrl = "RequestUrl";
			public const string ExceptionType = "ExceptionType";
			public const string Details = "Details";
		}
		public static string[] FieldList = {Fields.EventId, Fields.EventTimeUtc, Fields.EventTime, Fields.EventType, Fields.EventSequence, Fields.EventOccurrence, Fields.EventCode, Fields.EventDetailCode, Fields.Message, Fields.ApplicationPath, Fields.ApplicationVirtualPath, Fields.MachineName, Fields.RequestUrl, Fields.ExceptionType, Fields.Details};

		#region Methods
		public void Insert() { DBAdapter.Insert(this); }
		public void Update() { DBAdapter.Update(this); }
		public void Delete() { DBAdapter.Delete(this); }
		public DataSet Select() { return DBAdapter.Select(this); }
		#endregion

		#region Where Object
		public class aspnet_WebEvent_EventsWhereObject
		{
			public readonly aspnet_WebEvent_Events Parent = null;
			protected aspnet_WebEvent_EventsWhereObject(){ }
			public aspnet_WebEvent_EventsWhereObject(aspnet_WebEvent_Events parent){ this.Parent = parent; }

			private EventIdObject _EventId = null;
			public EventIdObject EventId
			{
				get
				{
					if (_EventId == null)
					{
						_EventId = new EventIdObject(this);
					}
					return _EventId;
				}
			}

			private EventTimeUtcObject _EventTimeUtc = null;
			public EventTimeUtcObject EventTimeUtc
			{
				get
				{
					if (_EventTimeUtc == null)
					{
						_EventTimeUtc = new EventTimeUtcObject(this);
					}
					return _EventTimeUtc;
				}
			}

			private EventTimeObject _EventTime = null;
			public EventTimeObject EventTime
			{
				get
				{
					if (_EventTime == null)
					{
						_EventTime = new EventTimeObject(this);
					}
					return _EventTime;
				}
			}

			private EventTypeObject _EventType = null;
			public EventTypeObject EventType
			{
				get
				{
					if (_EventType == null)
					{
						_EventType = new EventTypeObject(this);
					}
					return _EventType;
				}
			}

			private EventSequenceObject _EventSequence = null;
			public EventSequenceObject EventSequence
			{
				get
				{
					if (_EventSequence == null)
					{
						_EventSequence = new EventSequenceObject(this);
					}
					return _EventSequence;
				}
			}

			private EventOccurrenceObject _EventOccurrence = null;
			public EventOccurrenceObject EventOccurrence
			{
				get
				{
					if (_EventOccurrence == null)
					{
						_EventOccurrence = new EventOccurrenceObject(this);
					}
					return _EventOccurrence;
				}
			}

			private EventCodeObject _EventCode = null;
			public EventCodeObject EventCode
			{
				get
				{
					if (_EventCode == null)
					{
						_EventCode = new EventCodeObject(this);
					}
					return _EventCode;
				}
			}

			private EventDetailCodeObject _EventDetailCode = null;
			public EventDetailCodeObject EventDetailCode
			{
				get
				{
					if (_EventDetailCode == null)
					{
						_EventDetailCode = new EventDetailCodeObject(this);
					}
					return _EventDetailCode;
				}
			}

			private MessageObject _Message = null;
			public MessageObject Message
			{
				get
				{
					if (_Message == null)
					{
						_Message = new MessageObject(this);
					}
					return _Message;
				}
			}

			private ApplicationPathObject _ApplicationPath = null;
			public ApplicationPathObject ApplicationPath
			{
				get
				{
					if (_ApplicationPath == null)
					{
						_ApplicationPath = new ApplicationPathObject(this);
					}
					return _ApplicationPath;
				}
			}

			private ApplicationVirtualPathObject _ApplicationVirtualPath = null;
			public ApplicationVirtualPathObject ApplicationVirtualPath
			{
				get
				{
					if (_ApplicationVirtualPath == null)
					{
						_ApplicationVirtualPath = new ApplicationVirtualPathObject(this);
					}
					return _ApplicationVirtualPath;
				}
			}

			private MachineNameObject _MachineName = null;
			public MachineNameObject MachineName
			{
				get
				{
					if (_MachineName == null)
					{
						_MachineName = new MachineNameObject(this);
					}
					return _MachineName;
				}
			}

			private RequestUrlObject _RequestUrl = null;
			public RequestUrlObject RequestUrl
			{
				get
				{
					if (_RequestUrl == null)
					{
						_RequestUrl = new RequestUrlObject(this);
					}
					return _RequestUrl;
				}
			}

			private ExceptionTypeObject _ExceptionType = null;
			public ExceptionTypeObject ExceptionType
			{
				get
				{
					if (_ExceptionType == null)
					{
						_ExceptionType = new ExceptionTypeObject(this);
					}
					return _ExceptionType;
				}
			}

			private DetailsObject _Details = null;
			public DetailsObject Details
			{
				get
				{
					if (_Details == null)
					{
						_Details = new DetailsObject(this);
					}
					return _Details;
				}
			}

			#region Each field object
			public class EventIdObject
			{
				public readonly aspnet_WebEvent_EventsWhereObject Parent = null;
				protected EventIdObject() { }
				public EventIdObject(aspnet_WebEvent_EventsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventId = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventId = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventId < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventId < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventId <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventId > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventId > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventId >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventId >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventId like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where EventId <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class EventTimeUtcObject
			{
				public readonly aspnet_WebEvent_EventsWhereObject Parent = null;
				protected EventTimeUtcObject() { }
				public EventTimeUtcObject(aspnet_WebEvent_EventsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventTimeUtc = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventTimeUtc = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventTimeUtc < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventTimeUtc < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventTimeUtc <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventTimeUtc <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventTimeUtc > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventTimeUtc > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventTimeUtc >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventTimeUtc >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventTimeUtc like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where EventTimeUtc <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class EventTimeObject
			{
				public readonly aspnet_WebEvent_EventsWhereObject Parent = null;
				protected EventTimeObject() { }
				public EventTimeObject(aspnet_WebEvent_EventsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventTime = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventTime = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventTime < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventTime < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventTime <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventTime <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventTime > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventTime > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventTime >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventTime >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventTime like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where EventTime <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class EventTypeObject
			{
				public readonly aspnet_WebEvent_EventsWhereObject Parent = null;
				protected EventTypeObject() { }
				public EventTypeObject(aspnet_WebEvent_EventsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventType = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventType = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventType < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventType < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventType <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventType <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventType > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventType > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventType >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventType >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventType like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where EventType <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class EventSequenceObject
			{
				public readonly aspnet_WebEvent_EventsWhereObject Parent = null;
				protected EventSequenceObject() { }
				public EventSequenceObject(aspnet_WebEvent_EventsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventSequence = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventSequence = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventSequence < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventSequence < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventSequence <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventSequence <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventSequence > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventSequence > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventSequence >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventSequence >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventSequence like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where EventSequence <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class EventOccurrenceObject
			{
				public readonly aspnet_WebEvent_EventsWhereObject Parent = null;
				protected EventOccurrenceObject() { }
				public EventOccurrenceObject(aspnet_WebEvent_EventsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventOccurrence = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventOccurrence = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventOccurrence < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventOccurrence < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventOccurrence <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventOccurrence <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventOccurrence > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventOccurrence > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventOccurrence >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventOccurrence >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventOccurrence like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where EventOccurrence <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class EventCodeObject
			{
				public readonly aspnet_WebEvent_EventsWhereObject Parent = null;
				protected EventCodeObject() { }
				public EventCodeObject(aspnet_WebEvent_EventsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventCode = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventCode = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventCode < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventCode < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventCode <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventCode <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventCode > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventCode > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventCode >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventCode >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventCode like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where EventCode <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class EventDetailCodeObject
			{
				public readonly aspnet_WebEvent_EventsWhereObject Parent = null;
				protected EventDetailCodeObject() { }
				public EventDetailCodeObject(aspnet_WebEvent_EventsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventDetailCode = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventDetailCode = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventDetailCode < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventDetailCode < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventDetailCode <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventDetailCode <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventDetailCode > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventDetailCode > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventDetailCode >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventDetailCode >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventDetailCode like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where EventDetailCode <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class MessageObject
			{
				public readonly aspnet_WebEvent_EventsWhereObject Parent = null;
				protected MessageObject() { }
				public MessageObject(aspnet_WebEvent_EventsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Message = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Message = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Message < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Message < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Message <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Message <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Message > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Message > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Message >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Message >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Message like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where Message <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class ApplicationPathObject
			{
				public readonly aspnet_WebEvent_EventsWhereObject Parent = null;
				protected ApplicationPathObject() { }
				public ApplicationPathObject(aspnet_WebEvent_EventsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationPath = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationPath = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationPath < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationPath < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationPath <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationPath <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationPath > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationPath > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationPath >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationPath >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationPath like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where ApplicationPath <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class ApplicationVirtualPathObject
			{
				public readonly aspnet_WebEvent_EventsWhereObject Parent = null;
				protected ApplicationVirtualPathObject() { }
				public ApplicationVirtualPathObject(aspnet_WebEvent_EventsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationVirtualPath = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationVirtualPath = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationVirtualPath < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationVirtualPath < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationVirtualPath <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationVirtualPath <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationVirtualPath > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationVirtualPath > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationVirtualPath >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ApplicationVirtualPath >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ApplicationVirtualPath like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where ApplicationVirtualPath <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class MachineNameObject
			{
				public readonly aspnet_WebEvent_EventsWhereObject Parent = null;
				protected MachineNameObject() { }
				public MachineNameObject(aspnet_WebEvent_EventsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MachineName = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MachineName = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MachineName < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MachineName < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MachineName <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MachineName <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MachineName > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MachineName > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MachineName >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MachineName >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MachineName like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where MachineName <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class RequestUrlObject
			{
				public readonly aspnet_WebEvent_EventsWhereObject Parent = null;
				protected RequestUrlObject() { }
				public RequestUrlObject(aspnet_WebEvent_EventsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RequestUrl = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RequestUrl = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RequestUrl < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RequestUrl < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RequestUrl <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RequestUrl <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RequestUrl > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RequestUrl > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RequestUrl >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RequestUrl >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RequestUrl like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where RequestUrl <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class ExceptionTypeObject
			{
				public readonly aspnet_WebEvent_EventsWhereObject Parent = null;
				protected ExceptionTypeObject() { }
				public ExceptionTypeObject(aspnet_WebEvent_EventsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ExceptionType = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ExceptionType = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ExceptionType < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ExceptionType < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ExceptionType <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ExceptionType <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ExceptionType > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ExceptionType > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ExceptionType >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ExceptionType >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ExceptionType like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where ExceptionType <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class DetailsObject
			{
				public readonly aspnet_WebEvent_EventsWhereObject Parent = null;
				protected DetailsObject() { }
				public DetailsObject(aspnet_WebEvent_EventsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Details = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Details = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Details < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Details < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Details <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Details <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Details > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Details > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Details >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Details >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Details like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where Details <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			#endregion
		}
		#endregion

	}
	public class Connection
	{
		public static string TableName = "Connection";
		public string LastWhere { protected get; set; }
		#region Where
		private ConnectionWhereObject _whereObject = null;
		public ConnectionWhereObject Where
		{
			get
			{
				if (_whereObject == null)
				{
					_whereObject = new ConnectionWhereObject(this);
				}
				return _whereObject;
			}
		}
		#endregion

		#region Properties
		public object ConnectionID { get; set; }
		public object PersonID { get; set; }
		public object RelationShipID { get; set; }
		public object RelTypeID { get; set; }
		public object CreatedDate { get; set; }
		#endregion

		public static class Fields
		{
			public const string ConnectionID = "ConnectionID";
			public const string PersonID = "PersonID";
			public const string RelationShipID = "RelationShipID";
			public const string RelTypeID = "RelTypeID";
			public const string CreatedDate = "CreatedDate";
		}
		public static string[] FieldList = {Fields.ConnectionID, Fields.PersonID, Fields.RelationShipID, Fields.RelTypeID, Fields.CreatedDate};

		#region Methods
		public void Insert() { DBAdapter.Insert(this); }
		public void Update() { DBAdapter.Update(this); }
		public void Delete() { DBAdapter.Delete(this); }
		public DataSet Select() { return DBAdapter.Select(this); }
		#endregion

		#region Where Object
		public class ConnectionWhereObject
		{
			public readonly Connection Parent = null;
			protected ConnectionWhereObject(){ }
			public ConnectionWhereObject(Connection parent){ this.Parent = parent; }

			private ConnectionIDObject _ConnectionID = null;
			public ConnectionIDObject ConnectionID
			{
				get
				{
					if (_ConnectionID == null)
					{
						_ConnectionID = new ConnectionIDObject(this);
					}
					return _ConnectionID;
				}
			}

			private PersonIDObject _PersonID = null;
			public PersonIDObject PersonID
			{
				get
				{
					if (_PersonID == null)
					{
						_PersonID = new PersonIDObject(this);
					}
					return _PersonID;
				}
			}

			private RelationShipIDObject _RelationShipID = null;
			public RelationShipIDObject RelationShipID
			{
				get
				{
					if (_RelationShipID == null)
					{
						_RelationShipID = new RelationShipIDObject(this);
					}
					return _RelationShipID;
				}
			}

			private RelTypeIDObject _RelTypeID = null;
			public RelTypeIDObject RelTypeID
			{
				get
				{
					if (_RelTypeID == null)
					{
						_RelTypeID = new RelTypeIDObject(this);
					}
					return _RelTypeID;
				}
			}

			private CreatedDateObject _CreatedDate = null;
			public CreatedDateObject CreatedDate
			{
				get
				{
					if (_CreatedDate == null)
					{
						_CreatedDate = new CreatedDateObject(this);
					}
					return _CreatedDate;
				}
			}

			#region Each field object
			public class ConnectionIDObject
			{
				public readonly ConnectionWhereObject Parent = null;
				protected ConnectionIDObject() { }
				public ConnectionIDObject(ConnectionWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ConnectionID = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ConnectionID = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ConnectionID < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ConnectionID < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ConnectionID <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ConnectionID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ConnectionID > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ConnectionID > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ConnectionID >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ConnectionID >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ConnectionID like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where ConnectionID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class PersonIDObject
			{
				public readonly ConnectionWhereObject Parent = null;
				protected PersonIDObject() { }
				public PersonIDObject(ConnectionWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where PersonID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class RelationShipIDObject
			{
				public readonly ConnectionWhereObject Parent = null;
				protected RelationShipIDObject() { }
				public RelationShipIDObject(ConnectionWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RelationShipID = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RelationShipID = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RelationShipID < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RelationShipID < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RelationShipID <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RelationShipID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RelationShipID > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RelationShipID > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RelationShipID >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RelationShipID >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RelationShipID like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where RelationShipID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class RelTypeIDObject
			{
				public readonly ConnectionWhereObject Parent = null;
				protected RelTypeIDObject() { }
				public RelTypeIDObject(ConnectionWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RelTypeID = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RelTypeID = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RelTypeID < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RelTypeID < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RelTypeID <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RelTypeID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RelTypeID > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RelTypeID > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RelTypeID >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where RelTypeID >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where RelTypeID like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where RelTypeID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class CreatedDateObject
			{
				public readonly ConnectionWhereObject Parent = null;
				protected CreatedDateObject() { }
				public CreatedDateObject(ConnectionWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where CreatedDate <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			#endregion
		}
		#endregion

	}
	public class Contact
	{
		public static string TableName = "Contact";
		public string LastWhere { protected get; set; }
		#region Where
		private ContactWhereObject _whereObject = null;
		public ContactWhereObject Where
		{
			get
			{
				if (_whereObject == null)
				{
					_whereObject = new ContactWhereObject(this);
				}
				return _whereObject;
			}
		}
		#endregion

		#region Properties
		public object ConID { get; set; }
		public object PersonID { get; set; }
		public object HomePhone { get; set; }
		public object MobilePhone { get; set; }
		public object WorkPhone { get; set; }
		public object Email { get; set; }
		public object CreatedDate { get; set; }
		#endregion

		public static class Fields
		{
			public const string ConID = "ConID";
			public const string PersonID = "PersonID";
			public const string HomePhone = "HomePhone";
			public const string MobilePhone = "MobilePhone";
			public const string WorkPhone = "WorkPhone";
			public const string Email = "Email";
			public const string CreatedDate = "CreatedDate";
		}
		public static string[] FieldList = {Fields.ConID, Fields.PersonID, Fields.HomePhone, Fields.MobilePhone, Fields.WorkPhone, Fields.Email, Fields.CreatedDate};

		#region Methods
		public void Insert() { DBAdapter.Insert(this); }
		public void Update() { DBAdapter.Update(this); }
		public void Delete() { DBAdapter.Delete(this); }
		public DataSet Select() { return DBAdapter.Select(this); }
		#endregion

		#region Where Object
		public class ContactWhereObject
		{
			public readonly Contact Parent = null;
			protected ContactWhereObject(){ }
			public ContactWhereObject(Contact parent){ this.Parent = parent; }

			private ConIDObject _ConID = null;
			public ConIDObject ConID
			{
				get
				{
					if (_ConID == null)
					{
						_ConID = new ConIDObject(this);
					}
					return _ConID;
				}
			}

			private PersonIDObject _PersonID = null;
			public PersonIDObject PersonID
			{
				get
				{
					if (_PersonID == null)
					{
						_PersonID = new PersonIDObject(this);
					}
					return _PersonID;
				}
			}

			private HomePhoneObject _HomePhone = null;
			public HomePhoneObject HomePhone
			{
				get
				{
					if (_HomePhone == null)
					{
						_HomePhone = new HomePhoneObject(this);
					}
					return _HomePhone;
				}
			}

			private MobilePhoneObject _MobilePhone = null;
			public MobilePhoneObject MobilePhone
			{
				get
				{
					if (_MobilePhone == null)
					{
						_MobilePhone = new MobilePhoneObject(this);
					}
					return _MobilePhone;
				}
			}

			private WorkPhoneObject _WorkPhone = null;
			public WorkPhoneObject WorkPhone
			{
				get
				{
					if (_WorkPhone == null)
					{
						_WorkPhone = new WorkPhoneObject(this);
					}
					return _WorkPhone;
				}
			}

			private EmailObject _Email = null;
			public EmailObject Email
			{
				get
				{
					if (_Email == null)
					{
						_Email = new EmailObject(this);
					}
					return _Email;
				}
			}

			private CreatedDateObject _CreatedDate = null;
			public CreatedDateObject CreatedDate
			{
				get
				{
					if (_CreatedDate == null)
					{
						_CreatedDate = new CreatedDateObject(this);
					}
					return _CreatedDate;
				}
			}

			#region Each field object
			public class ConIDObject
			{
				public readonly ContactWhereObject Parent = null;
				protected ConIDObject() { }
				public ConIDObject(ContactWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ConID = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ConID = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ConID < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ConID < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ConID <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ConID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ConID > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ConID > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ConID >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where ConID >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where ConID like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where ConID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class PersonIDObject
			{
				public readonly ContactWhereObject Parent = null;
				protected PersonIDObject() { }
				public PersonIDObject(ContactWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where PersonID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class HomePhoneObject
			{
				public readonly ContactWhereObject Parent = null;
				protected HomePhoneObject() { }
				public HomePhoneObject(ContactWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where HomePhone = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where HomePhone = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where HomePhone < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where HomePhone < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where HomePhone <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where HomePhone <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where HomePhone > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where HomePhone > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where HomePhone >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where HomePhone >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where HomePhone like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where HomePhone <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class MobilePhoneObject
			{
				public readonly ContactWhereObject Parent = null;
				protected MobilePhoneObject() { }
				public MobilePhoneObject(ContactWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MobilePhone = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MobilePhone = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MobilePhone < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MobilePhone < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MobilePhone <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MobilePhone <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MobilePhone > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MobilePhone > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MobilePhone >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MobilePhone >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MobilePhone like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where MobilePhone <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class WorkPhoneObject
			{
				public readonly ContactWhereObject Parent = null;
				protected WorkPhoneObject() { }
				public WorkPhoneObject(ContactWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where WorkPhone = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where WorkPhone = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where WorkPhone < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where WorkPhone < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where WorkPhone <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where WorkPhone <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where WorkPhone > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where WorkPhone > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where WorkPhone >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where WorkPhone >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where WorkPhone like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where WorkPhone <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class EmailObject
			{
				public readonly ContactWhereObject Parent = null;
				protected EmailObject() { }
				public EmailObject(ContactWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Email = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Email = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Email < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Email < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Email <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Email <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Email > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Email > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Email >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Email >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Email like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where Email <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class CreatedDateObject
			{
				public readonly ContactWhereObject Parent = null;
				protected CreatedDateObject() { }
				public CreatedDateObject(ContactWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where CreatedDate <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			#endregion
		}
		#endregion

	}
	public class Event
	{
		public static string TableName = "Event";
		public string LastWhere { protected get; set; }
		#region Where
		private EventWhereObject _whereObject = null;
		public EventWhereObject Where
		{
			get
			{
				if (_whereObject == null)
				{
					_whereObject = new EventWhereObject(this);
				}
				return _whereObject;
			}
		}
		#endregion

		#region Properties
		public object EventID { get; set; }
		public object PersonID { get; set; }
		public object Title { get; set; }
		public object Description { get; set; }
		public object CreatedDate { get; set; }
		#endregion

		public static class Fields
		{
			public const string EventID = "EventID";
			public const string PersonID = "PersonID";
			public const string Title = "Title";
			public const string Description = "Description";
			public const string CreatedDate = "CreatedDate";
		}
		public static string[] FieldList = {Fields.EventID, Fields.PersonID, Fields.Title, Fields.Description, Fields.CreatedDate};

		#region Methods
		public void Insert() { DBAdapter.Insert(this); }
		public void Update() { DBAdapter.Update(this); }
		public void Delete() { DBAdapter.Delete(this); }
		public DataSet Select() { return DBAdapter.Select(this); }
		#endregion

		#region Where Object
		public class EventWhereObject
		{
			public readonly Event Parent = null;
			protected EventWhereObject(){ }
			public EventWhereObject(Event parent){ this.Parent = parent; }

			private EventIDObject _EventID = null;
			public EventIDObject EventID
			{
				get
				{
					if (_EventID == null)
					{
						_EventID = new EventIDObject(this);
					}
					return _EventID;
				}
			}

			private PersonIDObject _PersonID = null;
			public PersonIDObject PersonID
			{
				get
				{
					if (_PersonID == null)
					{
						_PersonID = new PersonIDObject(this);
					}
					return _PersonID;
				}
			}

			private TitleObject _Title = null;
			public TitleObject Title
			{
				get
				{
					if (_Title == null)
					{
						_Title = new TitleObject(this);
					}
					return _Title;
				}
			}

			private DescriptionObject _Description = null;
			public DescriptionObject Description
			{
				get
				{
					if (_Description == null)
					{
						_Description = new DescriptionObject(this);
					}
					return _Description;
				}
			}

			private CreatedDateObject _CreatedDate = null;
			public CreatedDateObject CreatedDate
			{
				get
				{
					if (_CreatedDate == null)
					{
						_CreatedDate = new CreatedDateObject(this);
					}
					return _CreatedDate;
				}
			}

			#region Each field object
			public class EventIDObject
			{
				public readonly EventWhereObject Parent = null;
				protected EventIDObject() { }
				public EventIDObject(EventWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventID = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventID = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventID < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventID < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventID <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventID > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventID > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventID >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where EventID >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where EventID like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where EventID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class PersonIDObject
			{
				public readonly EventWhereObject Parent = null;
				protected PersonIDObject() { }
				public PersonIDObject(EventWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where PersonID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class TitleObject
			{
				public readonly EventWhereObject Parent = null;
				protected TitleObject() { }
				public TitleObject(EventWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Title = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Title = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Title < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Title < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Title <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Title <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Title > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Title > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Title >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Title >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Title like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where Title <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class DescriptionObject
			{
				public readonly EventWhereObject Parent = null;
				protected DescriptionObject() { }
				public DescriptionObject(EventWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Description = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Description = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Description < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Description < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Description <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Description <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Description > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Description > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Description >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Description >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Description like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where Description <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class CreatedDateObject
			{
				public readonly EventWhereObject Parent = null;
				protected CreatedDateObject() { }
				public CreatedDateObject(EventWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where CreatedDate <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			#endregion
		}
		#endregion

	}
	public class Language
	{
		public static string TableName = "Language";
		public string LastWhere { protected get; set; }
		#region Where
		private LanguageWhereObject _whereObject = null;
		public LanguageWhereObject Where
		{
			get
			{
				if (_whereObject == null)
				{
					_whereObject = new LanguageWhereObject(this);
				}
				return _whereObject;
			}
		}
		#endregion

		#region Properties
		public object LangID { get; set; }
		public object LangName { get; set; }
		#endregion

		public static class Fields
		{
			public const string LangID = "LangID";
			public const string LangName = "LangName";
		}
		public static string[] FieldList = {Fields.LangID, Fields.LangName};

		#region Methods
		public void Insert() { DBAdapter.Insert(this); }
		public void Update() { DBAdapter.Update(this); }
		public void Delete() { DBAdapter.Delete(this); }
		public DataSet Select() { return DBAdapter.Select(this); }
		#endregion

		#region Where Object
		public class LanguageWhereObject
		{
			public readonly Language Parent = null;
			protected LanguageWhereObject(){ }
			public LanguageWhereObject(Language parent){ this.Parent = parent; }

			private LangIDObject _LangID = null;
			public LangIDObject LangID
			{
				get
				{
					if (_LangID == null)
					{
						_LangID = new LangIDObject(this);
					}
					return _LangID;
				}
			}

			private LangNameObject _LangName = null;
			public LangNameObject LangName
			{
				get
				{
					if (_LangName == null)
					{
						_LangName = new LangNameObject(this);
					}
					return _LangName;
				}
			}

			#region Each field object
			public class LangIDObject
			{
				public readonly LanguageWhereObject Parent = null;
				protected LangIDObject() { }
				public LangIDObject(LanguageWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LangID = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LangID = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LangID < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LangID < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LangID <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LangID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LangID > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LangID > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LangID >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LangID >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LangID like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where LangID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class LangNameObject
			{
				public readonly LanguageWhereObject Parent = null;
				protected LangNameObject() { }
				public LangNameObject(LanguageWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LangName = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LangName = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LangName < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LangName < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LangName <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LangName <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LangName > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LangName > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LangName >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LangName >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LangName like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where LangName <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			#endregion
		}
		#endregion

	}
	public class LanguageValue
	{
		public static string TableName = "LanguageValue";
		public string LastWhere { protected get; set; }
		#region Where
		private LanguageValueWhereObject _whereObject = null;
		public LanguageValueWhereObject Where
		{
			get
			{
				if (_whereObject == null)
				{
					_whereObject = new LanguageValueWhereObject(this);
				}
				return _whereObject;
			}
		}
		#endregion

		#region Properties
		public object object_id { get; set; }
		public object column_id { get; set; }
		public object language { get; set; }
		public object value { get; set; }
		#endregion

		public static class Fields
		{
			public const string object_id = "object_id";
			public const string column_id = "column_id";
			public const string language = "language";
			public const string value = "value";
		}
		public static string[] FieldList = {Fields.object_id, Fields.column_id, Fields.language, Fields.value};

		#region Methods
		public void Insert() { DBAdapter.Insert(this); }
		public void Update() { DBAdapter.Update(this); }
		public void Delete() { DBAdapter.Delete(this); }
		public DataSet Select() { return DBAdapter.Select(this); }
		#endregion

		#region Where Object
		public class LanguageValueWhereObject
		{
			public readonly LanguageValue Parent = null;
			protected LanguageValueWhereObject(){ }
			public LanguageValueWhereObject(LanguageValue parent){ this.Parent = parent; }

			private object_idObject _object_id = null;
			public object_idObject object_id
			{
				get
				{
					if (_object_id == null)
					{
						_object_id = new object_idObject(this);
					}
					return _object_id;
				}
			}

			private column_idObject _column_id = null;
			public column_idObject column_id
			{
				get
				{
					if (_column_id == null)
					{
						_column_id = new column_idObject(this);
					}
					return _column_id;
				}
			}

			private languageObject _language = null;
			public languageObject language
			{
				get
				{
					if (_language == null)
					{
						_language = new languageObject(this);
					}
					return _language;
				}
			}

			private valueObject _value = null;
			public valueObject value
			{
				get
				{
					if (_value == null)
					{
						_value = new valueObject(this);
					}
					return _value;
				}
			}

			#region Each field object
			public class object_idObject
			{
				public readonly LanguageValueWhereObject Parent = null;
				protected object_idObject() { }
				public object_idObject(LanguageValueWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where object_id = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where object_id = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where object_id < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where object_id < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where object_id <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where object_id <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where object_id > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where object_id > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where object_id >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where object_id >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where object_id like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where object_id <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class column_idObject
			{
				public readonly LanguageValueWhereObject Parent = null;
				protected column_idObject() { }
				public column_idObject(LanguageValueWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where column_id = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where column_id = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where column_id < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where column_id < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where column_id <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where column_id <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where column_id > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where column_id > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where column_id >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where column_id >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where column_id like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where column_id <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class languageObject
			{
				public readonly LanguageValueWhereObject Parent = null;
				protected languageObject() { }
				public languageObject(LanguageValueWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where language = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where language = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where language < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where language < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where language <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where language <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where language > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where language > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where language >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where language >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where language like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where language <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class valueObject
			{
				public readonly LanguageValueWhereObject Parent = null;
				protected valueObject() { }
				public valueObject(LanguageValueWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where value = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where value = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where value < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where value < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where value <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where value <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where value > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where value > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where value >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where value >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where value like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where value <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			#endregion
		}
		#endregion

	}
	public class Media
	{
		public static string TableName = "Media";
		public string LastWhere { protected get; set; }
		#region Where
		private MediaWhereObject _whereObject = null;
		public MediaWhereObject Where
		{
			get
			{
				if (_whereObject == null)
				{
					_whereObject = new MediaWhereObject(this);
				}
				return _whereObject;
			}
		}
		#endregion

		#region Properties
		public object MediaID { get; set; }
		public object PersonID { get; set; }
		public object AlbumID { get; set; }
		public object MediaTypeID { get; set; }
		public object FileName { get; set; }
		public object CreatedDate { get; set; }
		#endregion

		public static class Fields
		{
			public const string MediaID = "MediaID";
			public const string PersonID = "PersonID";
			public const string AlbumID = "AlbumID";
			public const string MediaTypeID = "MediaTypeID";
			public const string FileName = "FileName";
			public const string CreatedDate = "CreatedDate";
		}
		public static string[] FieldList = {Fields.MediaID, Fields.PersonID, Fields.AlbumID, Fields.MediaTypeID, Fields.FileName, Fields.CreatedDate};

		#region Methods
		public void Insert() { DBAdapter.Insert(this); }
		public void Update() { DBAdapter.Update(this); }
		public void Delete() { DBAdapter.Delete(this); }
		public DataSet Select() { return DBAdapter.Select(this); }
		#endregion

		#region Where Object
		public class MediaWhereObject
		{
			public readonly Media Parent = null;
			protected MediaWhereObject(){ }
			public MediaWhereObject(Media parent){ this.Parent = parent; }

			private MediaIDObject _MediaID = null;
			public MediaIDObject MediaID
			{
				get
				{
					if (_MediaID == null)
					{
						_MediaID = new MediaIDObject(this);
					}
					return _MediaID;
				}
			}

			private PersonIDObject _PersonID = null;
			public PersonIDObject PersonID
			{
				get
				{
					if (_PersonID == null)
					{
						_PersonID = new PersonIDObject(this);
					}
					return _PersonID;
				}
			}

			private AlbumIDObject _AlbumID = null;
			public AlbumIDObject AlbumID
			{
				get
				{
					if (_AlbumID == null)
					{
						_AlbumID = new AlbumIDObject(this);
					}
					return _AlbumID;
				}
			}

			private MediaTypeIDObject _MediaTypeID = null;
			public MediaTypeIDObject MediaTypeID
			{
				get
				{
					if (_MediaTypeID == null)
					{
						_MediaTypeID = new MediaTypeIDObject(this);
					}
					return _MediaTypeID;
				}
			}

			private FileNameObject _FileName = null;
			public FileNameObject FileName
			{
				get
				{
					if (_FileName == null)
					{
						_FileName = new FileNameObject(this);
					}
					return _FileName;
				}
			}

			private CreatedDateObject _CreatedDate = null;
			public CreatedDateObject CreatedDate
			{
				get
				{
					if (_CreatedDate == null)
					{
						_CreatedDate = new CreatedDateObject(this);
					}
					return _CreatedDate;
				}
			}

			#region Each field object
			public class MediaIDObject
			{
				public readonly MediaWhereObject Parent = null;
				protected MediaIDObject() { }
				public MediaIDObject(MediaWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MediaID = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MediaID = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MediaID < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MediaID < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MediaID <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MediaID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MediaID > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MediaID > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MediaID >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MediaID >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MediaID like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where MediaID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class PersonIDObject
			{
				public readonly MediaWhereObject Parent = null;
				protected PersonIDObject() { }
				public PersonIDObject(MediaWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where PersonID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class AlbumIDObject
			{
				public readonly MediaWhereObject Parent = null;
				protected AlbumIDObject() { }
				public AlbumIDObject(MediaWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AlbumID = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where AlbumID = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AlbumID < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where AlbumID < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AlbumID <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where AlbumID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AlbumID > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where AlbumID > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AlbumID >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where AlbumID >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AlbumID like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where AlbumID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class MediaTypeIDObject
			{
				public readonly MediaWhereObject Parent = null;
				protected MediaTypeIDObject() { }
				public MediaTypeIDObject(MediaWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MediaTypeID = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MediaTypeID = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MediaTypeID < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MediaTypeID < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MediaTypeID <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MediaTypeID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MediaTypeID > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MediaTypeID > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MediaTypeID >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where MediaTypeID >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where MediaTypeID like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where MediaTypeID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class FileNameObject
			{
				public readonly MediaWhereObject Parent = null;
				protected FileNameObject() { }
				public FileNameObject(MediaWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FileName = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FileName = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FileName < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FileName < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FileName <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FileName <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FileName > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FileName > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FileName >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FileName >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FileName like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where FileName <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class CreatedDateObject
			{
				public readonly MediaWhereObject Parent = null;
				protected CreatedDateObject() { }
				public CreatedDateObject(MediaWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where CreatedDate <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			#endregion
		}
		#endregion

	}
	public class Person
	{
		public static string TableName = "Person";
		public string LastWhere { protected get; set; }
		#region Where
		private PersonWhereObject _whereObject = null;
		public PersonWhereObject Where
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

		#region Properties
		public object PersonID { get; set; }
		public object DefaultImage { get; set; }
		public object FirstName { get; set; }
		public object LastName { get; set; }
		public object Welcome { get; set; }
		public object AboutMe { get; set; }
		public object CreatedDate { get; set; }
		#endregion

		public static class Fields
		{
			public const string PersonID = "PersonID";
			public const string DefaultImage = "DefaultImage";
			public const string FirstName = "FirstName";
			public const string LastName = "LastName";
			public const string Welcome = "Welcome";
			public const string AboutMe = "AboutMe";
			public const string CreatedDate = "CreatedDate";
		}
		public static string[] FieldList = {Fields.PersonID, Fields.DefaultImage, Fields.FirstName, Fields.LastName, Fields.Welcome, Fields.AboutMe, Fields.CreatedDate};

		#region Methods
		public void Insert() { DBAdapter.Insert(this); }
		public void Update() { DBAdapter.Update(this); }
		public void Delete() { DBAdapter.Delete(this); }
		public DataSet Select() { return DBAdapter.Select(this); }
		#endregion

		#region Where Object
		public class PersonWhereObject
		{
			public readonly Person Parent = null;
			protected PersonWhereObject(){ }
			public PersonWhereObject(Person parent){ this.Parent = parent; }

			private PersonIDObject _PersonID = null;
			public PersonIDObject PersonID
			{
				get
				{
					if (_PersonID == null)
					{
						_PersonID = new PersonIDObject(this);
					}
					return _PersonID;
				}
			}

			private DefaultImageObject _DefaultImage = null;
			public DefaultImageObject DefaultImage
			{
				get
				{
					if (_DefaultImage == null)
					{
						_DefaultImage = new DefaultImageObject(this);
					}
					return _DefaultImage;
				}
			}

			private FirstNameObject _FirstName = null;
			public FirstNameObject FirstName
			{
				get
				{
					if (_FirstName == null)
					{
						_FirstName = new FirstNameObject(this);
					}
					return _FirstName;
				}
			}

			private LastNameObject _LastName = null;
			public LastNameObject LastName
			{
				get
				{
					if (_LastName == null)
					{
						_LastName = new LastNameObject(this);
					}
					return _LastName;
				}
			}

			private WelcomeObject _Welcome = null;
			public WelcomeObject Welcome
			{
				get
				{
					if (_Welcome == null)
					{
						_Welcome = new WelcomeObject(this);
					}
					return _Welcome;
				}
			}

			private AboutMeObject _AboutMe = null;
			public AboutMeObject AboutMe
			{
				get
				{
					if (_AboutMe == null)
					{
						_AboutMe = new AboutMeObject(this);
					}
					return _AboutMe;
				}
			}

			private CreatedDateObject _CreatedDate = null;
			public CreatedDateObject CreatedDate
			{
				get
				{
					if (_CreatedDate == null)
					{
						_CreatedDate = new CreatedDateObject(this);
					}
					return _CreatedDate;
				}
			}

			#region Each field object
			public class PersonIDObject
			{
				public readonly PersonWhereObject Parent = null;
				protected PersonIDObject() { }
				public PersonIDObject(PersonWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID = " + value;
					}
                    
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where PersonID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class DefaultImageObject
			{
				public readonly PersonWhereObject Parent = null;
				protected DefaultImageObject() { }
				public DefaultImageObject(PersonWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where DefaultImage = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where DefaultImage = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where DefaultImage < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where DefaultImage < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where DefaultImage <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where DefaultImage <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where DefaultImage > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where DefaultImage > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where DefaultImage >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where DefaultImage >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where DefaultImage like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where DefaultImage <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class FirstNameObject
			{
				public readonly PersonWhereObject Parent = null;
				protected FirstNameObject() { }
				public FirstNameObject(PersonWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FirstName = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FirstName = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FirstName < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FirstName < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FirstName <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FirstName <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FirstName > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FirstName > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FirstName >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where FirstName >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where FirstName like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where FirstName <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class LastNameObject
			{
				public readonly PersonWhereObject Parent = null;
				protected LastNameObject() { }
				public LastNameObject(PersonWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastName = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastName = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastName < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastName < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastName <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastName <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastName > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastName > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastName >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where LastName >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where LastName like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where LastName <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class WelcomeObject
			{
				public readonly PersonWhereObject Parent = null;
				protected WelcomeObject() { }
				public WelcomeObject(PersonWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Welcome = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Welcome = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Welcome < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Welcome < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Welcome <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Welcome <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Welcome > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Welcome > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Welcome >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where Welcome >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where Welcome like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where Welcome <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class AboutMeObject
			{
				public readonly PersonWhereObject Parent = null;
				protected AboutMeObject() { }
				public AboutMeObject(PersonWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AboutMe = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where AboutMe = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AboutMe < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where AboutMe < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AboutMe <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where AboutMe <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AboutMe > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where AboutMe > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AboutMe >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where AboutMe >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AboutMe like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where AboutMe <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class CreatedDateObject
			{
				public readonly PersonWhereObject Parent = null;
				protected CreatedDateObject() { }
				public CreatedDateObject(PersonWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where CreatedDate <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			#endregion
		}
		#endregion

	}
	public class PhodeoAlbum
	{
		public static string TableName = "PhodeoAlbum";
		public string LastWhere { protected get; set; }
		#region Where
		private PhodeoAlbumWhereObject _whereObject = null;
		public PhodeoAlbumWhereObject Where
		{
			get
			{
				if (_whereObject == null)
				{
					_whereObject = new PhodeoAlbumWhereObject(this);
				}
				return _whereObject;
			}
		}
		#endregion

		#region Properties
		public object AlbumID { get; set; }
		public object PersonID { get; set; }
		public object AlbumName { get; set; }
		public object CreatedDate { get; set; }
		#endregion

		public static class Fields
		{
			public const string AlbumID = "AlbumID";
			public const string PersonID = "PersonID";
			public const string AlbumName = "AlbumName";
			public const string CreatedDate = "CreatedDate";
		}
		public static string[] FieldList = {Fields.AlbumID, Fields.PersonID, Fields.AlbumName, Fields.CreatedDate};

		#region Methods
		public void Insert() { DBAdapter.Insert(this); }
		public void Update() { DBAdapter.Update(this); }
		public void Delete() { DBAdapter.Delete(this); }
		public DataSet Select() { return DBAdapter.Select(this); }
		#endregion

		#region Where Object
		public class PhodeoAlbumWhereObject
		{
			public readonly PhodeoAlbum Parent = null;
			protected PhodeoAlbumWhereObject(){ }
			public PhodeoAlbumWhereObject(PhodeoAlbum parent){ this.Parent = parent; }

			private AlbumIDObject _AlbumID = null;
			public AlbumIDObject AlbumID
			{
				get
				{
					if (_AlbumID == null)
					{
						_AlbumID = new AlbumIDObject(this);
					}
					return _AlbumID;
				}
			}

			private PersonIDObject _PersonID = null;
			public PersonIDObject PersonID
			{
				get
				{
					if (_PersonID == null)
					{
						_PersonID = new PersonIDObject(this);
					}
					return _PersonID;
				}
			}

			private AlbumNameObject _AlbumName = null;
			public AlbumNameObject AlbumName
			{
				get
				{
					if (_AlbumName == null)
					{
						_AlbumName = new AlbumNameObject(this);
					}
					return _AlbumName;
				}
			}

			private CreatedDateObject _CreatedDate = null;
			public CreatedDateObject CreatedDate
			{
				get
				{
					if (_CreatedDate == null)
					{
						_CreatedDate = new CreatedDateObject(this);
					}
					return _CreatedDate;
				}
			}

			#region Each field object
			public class AlbumIDObject
			{
				public readonly PhodeoAlbumWhereObject Parent = null;
				protected AlbumIDObject() { }
				public AlbumIDObject(PhodeoAlbumWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AlbumID = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where AlbumID = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AlbumID < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where AlbumID < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AlbumID <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where AlbumID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AlbumID > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where AlbumID > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AlbumID >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where AlbumID >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AlbumID like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where AlbumID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class PersonIDObject
			{
				public readonly PhodeoAlbumWhereObject Parent = null;
				protected PersonIDObject() { }
				public PersonIDObject(PhodeoAlbumWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where PersonID >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where PersonID like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where PersonID <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class AlbumNameObject
			{
				public readonly PhodeoAlbumWhereObject Parent = null;
				protected AlbumNameObject() { }
				public AlbumNameObject(PhodeoAlbumWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AlbumName = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where AlbumName = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AlbumName < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where AlbumName < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AlbumName <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where AlbumName <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AlbumName > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where AlbumName > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AlbumName >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where AlbumName >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where AlbumName like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where AlbumName <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
			}

			public class CreatedDateObject
			{
				public readonly PhodeoAlbumWhereObject Parent = null;
				protected CreatedDateObject() { }
				public CreatedDateObject(PhodeoAlbumWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate < " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate <= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThan(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate > " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string GreaterThanEqual(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where CreatedDate >= " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string Like(Object value)
				{
					string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where CreatedDate like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						lastWhere = " where CreatedDate <= " + value;
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
        public static string mConStr = "Data Source=localhost;Initial Catalog=Personal;Integrated Security=True";

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
