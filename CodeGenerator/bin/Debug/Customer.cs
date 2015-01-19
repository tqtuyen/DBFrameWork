using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;

namespace master
{
	class MSreplication_options
	{
		public static string TableName = "MSreplication_options";
		public string LastWhere { protected get; set; }
		#region Where
		private MSreplication_optionsWhereObject _whereObject = null;
		public MSreplication_optionsWhereObject Where
		{
			get
			{
				if (_whereObject == null)
				{
					_whereObject = new MSreplication_optionsWhereObject(this);
				}
				return _whereObject;
			}
		}
		#endregion

		#region Properties
		public object optname { get; set; }
		public object value { get; set; }
		public object major_version { get; set; }
		public object minor_version { get; set; }
		public object revision { get; set; }
		public object install_failures { get; set; }
		#endregion

		public static class Fields
		{
			public const string optname = "optname";
			public const string value = "value";
			public const string major_version = "major_version";
			public const string minor_version = "minor_version";
			public const string revision = "revision";
			public const string install_failures = "install_failures";
		}
		public static string[] FieldList = {Fields.optname, Fields.value, Fields.major_version, Fields.minor_version, Fields.revision, Fields.install_failures};

		#region Methods
		public void Insert() { DBAdapter.Insert(this); }
		public void Update() { DBAdapter.Update(this); }
		public void Delete() { DBAdapter.Delete(this); }
		public DataSet Select() { return DBAdapter.Select(this); }
		#endregion

		#region Where Object
		public class MSreplication_optionsWhereObject
		{
			public readonly MSreplication_options Parent = null;
			protected MSreplication_optionsWhereObject(){ }
			public MSreplication_optionsWhereObject(MSreplication_options parent){ this.Parent = parent; }

			private optnameObject _optname = null;
			public optnameObject optname
			{
				get
				{
					if (_optname == null)
					{
						_optname = new optnameObject(this);
					}
					return _optname;
				}
			}

			#region Each field object
			internal class optnameObject
			{
				public readonly MSreplication_optionsWhereObject Parent = null;
				protected optnameObject() { }
				public optnameObject(MSreplication_optionsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where optname = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where optname = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where optname < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where optname < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where optname <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where optname <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where optname > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where optname > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where optname >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where optname >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where optname like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where optname <= " + value;
					}
				}
			}
			#endregion

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
			internal class valueObject
			{
				public readonly MSreplication_optionsWhereObject Parent = null;
				protected valueObject() { }
				public valueObject(MSreplication_optionsWhereObject parent) { this.Parent = parent; }
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
					if (value.GetType() == typeof(string))
					{
						return " where value < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where value < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where value <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where value <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where value > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where value > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where value >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where value >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where value like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where value <= " + value;
					}
				}
			}
			#endregion

			private major_versionObject _major_version = null;
			public major_versionObject major_version
			{
				get
				{
					if (_major_version == null)
					{
						_major_version = new major_versionObject(this);
					}
					return _major_version;
				}
			}

			#region Each field object
			internal class major_versionObject
			{
				public readonly MSreplication_optionsWhereObject Parent = null;
				protected major_versionObject() { }
				public major_versionObject(MSreplication_optionsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where major_version = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where major_version = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where major_version < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where major_version < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where major_version <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where major_version <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where major_version > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where major_version > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where major_version >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where major_version >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where major_version like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where major_version <= " + value;
					}
				}
			}
			#endregion

			private minor_versionObject _minor_version = null;
			public minor_versionObject minor_version
			{
				get
				{
					if (_minor_version == null)
					{
						_minor_version = new minor_versionObject(this);
					}
					return _minor_version;
				}
			}

			#region Each field object
			internal class minor_versionObject
			{
				public readonly MSreplication_optionsWhereObject Parent = null;
				protected minor_versionObject() { }
				public minor_versionObject(MSreplication_optionsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where minor_version = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where minor_version = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where minor_version < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where minor_version < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where minor_version <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where minor_version <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where minor_version > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where minor_version > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where minor_version >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where minor_version >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where minor_version like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where minor_version <= " + value;
					}
				}
			}
			#endregion

			private revisionObject _revision = null;
			public revisionObject revision
			{
				get
				{
					if (_revision == null)
					{
						_revision = new revisionObject(this);
					}
					return _revision;
				}
			}

			#region Each field object
			internal class revisionObject
			{
				public readonly MSreplication_optionsWhereObject Parent = null;
				protected revisionObject() { }
				public revisionObject(MSreplication_optionsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where revision = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where revision = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where revision < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where revision < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where revision <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where revision <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where revision > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where revision > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where revision >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where revision >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where revision like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where revision <= " + value;
					}
				}
			}
			#endregion

			private install_failuresObject _install_failures = null;
			public install_failuresObject install_failures
			{
				get
				{
					if (_install_failures == null)
					{
						_install_failures = new install_failuresObject(this);
					}
					return _install_failures;
				}
			}

			#region Each field object
			internal class install_failuresObject
			{
				public readonly MSreplication_optionsWhereObject Parent = null;
				protected install_failuresObject() { }
				public install_failuresObject(MSreplication_optionsWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where install_failures = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where install_failures = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where install_failures < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where install_failures < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where install_failures <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where install_failures <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where install_failures > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where install_failures > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where install_failures >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where install_failures >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where install_failures like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where install_failures <= " + value;
					}
				}
			}
			#endregion

		}
		#endregion

	}
	class spt_fallback_db
	{
		public static string TableName = "spt_fallback_db";
		public string LastWhere { protected get; set; }
		#region Where
		private spt_fallback_dbWhereObject _whereObject = null;
		public spt_fallback_dbWhereObject Where
		{
			get
			{
				if (_whereObject == null)
				{
					_whereObject = new spt_fallback_dbWhereObject(this);
				}
				return _whereObject;
			}
		}
		#endregion

		#region Properties
		public object xserver_name { get; set; }
		public object xdttm_ins { get; set; }
		public object xdttm_last_ins_upd { get; set; }
		public object xfallback_dbid { get; set; }
		public object name { get; set; }
		public object dbid { get; set; }
		public object status { get; set; }
		public object version { get; set; }
		#endregion

		public static class Fields
		{
			public const string xserver_name = "xserver_name";
			public const string xdttm_ins = "xdttm_ins";
			public const string xdttm_last_ins_upd = "xdttm_last_ins_upd";
			public const string xfallback_dbid = "xfallback_dbid";
			public const string name = "name";
			public const string dbid = "dbid";
			public const string status = "status";
			public const string version = "version";
		}
		public static string[] FieldList = {Fields.xserver_name, Fields.xdttm_ins, Fields.xdttm_last_ins_upd, Fields.xfallback_dbid, Fields.name, Fields.dbid, Fields.status, Fields.version};

		#region Methods
		public void Insert() { DBAdapter.Insert(this); }
		public void Update() { DBAdapter.Update(this); }
		public void Delete() { DBAdapter.Delete(this); }
		public DataSet Select() { return DBAdapter.Select(this); }
		#endregion

		#region Where Object
		public class spt_fallback_dbWhereObject
		{
			public readonly spt_fallback_db Parent = null;
			protected spt_fallback_dbWhereObject(){ }
			public spt_fallback_dbWhereObject(spt_fallback_db parent){ this.Parent = parent; }

			private xserver_nameObject _xserver_name = null;
			public xserver_nameObject xserver_name
			{
				get
				{
					if (_xserver_name == null)
					{
						_xserver_name = new xserver_nameObject(this);
					}
					return _xserver_name;
				}
			}

			#region Each field object
			internal class xserver_nameObject
			{
				public readonly spt_fallback_dbWhereObject Parent = null;
				protected xserver_nameObject() { }
				public xserver_nameObject(spt_fallback_dbWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where xserver_name = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where xserver_name = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xserver_name < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xserver_name < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xserver_name <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xserver_name <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xserver_name > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xserver_name > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xserver_name >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xserver_name >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xserver_name like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where xserver_name <= " + value;
					}
				}
			}
			#endregion

			private xdttm_insObject _xdttm_ins = null;
			public xdttm_insObject xdttm_ins
			{
				get
				{
					if (_xdttm_ins == null)
					{
						_xdttm_ins = new xdttm_insObject(this);
					}
					return _xdttm_ins;
				}
			}

			#region Each field object
			internal class xdttm_insObject
			{
				public readonly spt_fallback_dbWhereObject Parent = null;
				protected xdttm_insObject() { }
				public xdttm_insObject(spt_fallback_dbWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where xdttm_ins = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where xdttm_ins = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_ins < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xdttm_ins < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_ins <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xdttm_ins <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_ins > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xdttm_ins > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_ins >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xdttm_ins >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_ins like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where xdttm_ins <= " + value;
					}
				}
			}
			#endregion

			private xdttm_last_ins_updObject _xdttm_last_ins_upd = null;
			public xdttm_last_ins_updObject xdttm_last_ins_upd
			{
				get
				{
					if (_xdttm_last_ins_upd == null)
					{
						_xdttm_last_ins_upd = new xdttm_last_ins_updObject(this);
					}
					return _xdttm_last_ins_upd;
				}
			}

			#region Each field object
			internal class xdttm_last_ins_updObject
			{
				public readonly spt_fallback_dbWhereObject Parent = null;
				protected xdttm_last_ins_updObject() { }
				public xdttm_last_ins_updObject(spt_fallback_dbWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where xdttm_last_ins_upd = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where xdttm_last_ins_upd = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_last_ins_upd < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xdttm_last_ins_upd < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_last_ins_upd <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xdttm_last_ins_upd <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_last_ins_upd > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xdttm_last_ins_upd > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_last_ins_upd >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xdttm_last_ins_upd >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_last_ins_upd like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where xdttm_last_ins_upd <= " + value;
					}
				}
			}
			#endregion

			private xfallback_dbidObject _xfallback_dbid = null;
			public xfallback_dbidObject xfallback_dbid
			{
				get
				{
					if (_xfallback_dbid == null)
					{
						_xfallback_dbid = new xfallback_dbidObject(this);
					}
					return _xfallback_dbid;
				}
			}

			#region Each field object
			internal class xfallback_dbidObject
			{
				public readonly spt_fallback_dbWhereObject Parent = null;
				protected xfallback_dbidObject() { }
				public xfallback_dbidObject(spt_fallback_dbWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where xfallback_dbid = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where xfallback_dbid = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xfallback_dbid < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xfallback_dbid < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xfallback_dbid <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xfallback_dbid <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xfallback_dbid > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xfallback_dbid > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xfallback_dbid >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xfallback_dbid >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xfallback_dbid like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where xfallback_dbid <= " + value;
					}
				}
			}
			#endregion

			private nameObject _name = null;
			public nameObject name
			{
				get
				{
					if (_name == null)
					{
						_name = new nameObject(this);
					}
					return _name;
				}
			}

			#region Each field object
			internal class nameObject
			{
				public readonly spt_fallback_dbWhereObject Parent = null;
				protected nameObject() { }
				public nameObject(spt_fallback_dbWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where name = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where name = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where name < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where name < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where name <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where name <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where name > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where name > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where name >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where name >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where name like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where name <= " + value;
					}
				}
			}
			#endregion

			private dbidObject _dbid = null;
			public dbidObject dbid
			{
				get
				{
					if (_dbid == null)
					{
						_dbid = new dbidObject(this);
					}
					return _dbid;
				}
			}

			#region Each field object
			internal class dbidObject
			{
				public readonly spt_fallback_dbWhereObject Parent = null;
				protected dbidObject() { }
				public dbidObject(spt_fallback_dbWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where dbid = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where dbid = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where dbid < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where dbid < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where dbid <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where dbid <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where dbid > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where dbid > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where dbid >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where dbid >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where dbid like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where dbid <= " + value;
					}
				}
			}
			#endregion

			private statusObject _status = null;
			public statusObject status
			{
				get
				{
					if (_status == null)
					{
						_status = new statusObject(this);
					}
					return _status;
				}
			}

			#region Each field object
			internal class statusObject
			{
				public readonly spt_fallback_dbWhereObject Parent = null;
				protected statusObject() { }
				public statusObject(spt_fallback_dbWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where status = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where status = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where status < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where status < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where status <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where status <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where status > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where status > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where status >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where status >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where status like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where status <= " + value;
					}
				}
			}
			#endregion

			private versionObject _version = null;
			public versionObject version
			{
				get
				{
					if (_version == null)
					{
						_version = new versionObject(this);
					}
					return _version;
				}
			}

			#region Each field object
			internal class versionObject
			{
				public readonly spt_fallback_dbWhereObject Parent = null;
				protected versionObject() { }
				public versionObject(spt_fallback_dbWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where version = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where version = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where version < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where version < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where version <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where version <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where version > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where version > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where version >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where version >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where version like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where version <= " + value;
					}
				}
			}
			#endregion

		}
		#endregion

	}
	class spt_fallback_dev
	{
		public static string TableName = "spt_fallback_dev";
		public string LastWhere { protected get; set; }
		#region Where
		private spt_fallback_devWhereObject _whereObject = null;
		public spt_fallback_devWhereObject Where
		{
			get
			{
				if (_whereObject == null)
				{
					_whereObject = new spt_fallback_devWhereObject(this);
				}
				return _whereObject;
			}
		}
		#endregion

		#region Properties
		public object xserver_name { get; set; }
		public object xdttm_ins { get; set; }
		public object xdttm_last_ins_upd { get; set; }
		public object xfallback_low { get; set; }
		public object xfallback_drive { get; set; }
		public object low { get; set; }
		public object high { get; set; }
		public object status { get; set; }
		public object name { get; set; }
		public object phyname { get; set; }
		#endregion

		public static class Fields
		{
			public const string xserver_name = "xserver_name";
			public const string xdttm_ins = "xdttm_ins";
			public const string xdttm_last_ins_upd = "xdttm_last_ins_upd";
			public const string xfallback_low = "xfallback_low";
			public const string xfallback_drive = "xfallback_drive";
			public const string low = "low";
			public const string high = "high";
			public const string status = "status";
			public const string name = "name";
			public const string phyname = "phyname";
		}
		public static string[] FieldList = {Fields.xserver_name, Fields.xdttm_ins, Fields.xdttm_last_ins_upd, Fields.xfallback_low, Fields.xfallback_drive, Fields.low, Fields.high, Fields.status, Fields.name, Fields.phyname};

		#region Methods
		public void Insert() { DBAdapter.Insert(this); }
		public void Update() { DBAdapter.Update(this); }
		public void Delete() { DBAdapter.Delete(this); }
		public DataSet Select() { return DBAdapter.Select(this); }
		#endregion

		#region Where Object
		public class spt_fallback_devWhereObject
		{
			public readonly spt_fallback_dev Parent = null;
			protected spt_fallback_devWhereObject(){ }
			public spt_fallback_devWhereObject(spt_fallback_dev parent){ this.Parent = parent; }

			private xserver_nameObject _xserver_name = null;
			public xserver_nameObject xserver_name
			{
				get
				{
					if (_xserver_name == null)
					{
						_xserver_name = new xserver_nameObject(this);
					}
					return _xserver_name;
				}
			}

			#region Each field object
			internal class xserver_nameObject
			{
				public readonly spt_fallback_devWhereObject Parent = null;
				protected xserver_nameObject() { }
				public xserver_nameObject(spt_fallback_devWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where xserver_name = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where xserver_name = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xserver_name < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xserver_name < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xserver_name <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xserver_name <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xserver_name > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xserver_name > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xserver_name >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xserver_name >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xserver_name like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where xserver_name <= " + value;
					}
				}
			}
			#endregion

			private xdttm_insObject _xdttm_ins = null;
			public xdttm_insObject xdttm_ins
			{
				get
				{
					if (_xdttm_ins == null)
					{
						_xdttm_ins = new xdttm_insObject(this);
					}
					return _xdttm_ins;
				}
			}

			#region Each field object
			internal class xdttm_insObject
			{
				public readonly spt_fallback_devWhereObject Parent = null;
				protected xdttm_insObject() { }
				public xdttm_insObject(spt_fallback_devWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where xdttm_ins = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where xdttm_ins = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_ins < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xdttm_ins < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_ins <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xdttm_ins <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_ins > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xdttm_ins > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_ins >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xdttm_ins >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_ins like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where xdttm_ins <= " + value;
					}
				}
			}
			#endregion

			private xdttm_last_ins_updObject _xdttm_last_ins_upd = null;
			public xdttm_last_ins_updObject xdttm_last_ins_upd
			{
				get
				{
					if (_xdttm_last_ins_upd == null)
					{
						_xdttm_last_ins_upd = new xdttm_last_ins_updObject(this);
					}
					return _xdttm_last_ins_upd;
				}
			}

			#region Each field object
			internal class xdttm_last_ins_updObject
			{
				public readonly spt_fallback_devWhereObject Parent = null;
				protected xdttm_last_ins_updObject() { }
				public xdttm_last_ins_updObject(spt_fallback_devWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where xdttm_last_ins_upd = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where xdttm_last_ins_upd = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_last_ins_upd < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xdttm_last_ins_upd < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_last_ins_upd <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xdttm_last_ins_upd <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_last_ins_upd > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xdttm_last_ins_upd > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_last_ins_upd >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xdttm_last_ins_upd >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_last_ins_upd like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where xdttm_last_ins_upd <= " + value;
					}
				}
			}
			#endregion

			private xfallback_lowObject _xfallback_low = null;
			public xfallback_lowObject xfallback_low
			{
				get
				{
					if (_xfallback_low == null)
					{
						_xfallback_low = new xfallback_lowObject(this);
					}
					return _xfallback_low;
				}
			}

			#region Each field object
			internal class xfallback_lowObject
			{
				public readonly spt_fallback_devWhereObject Parent = null;
				protected xfallback_lowObject() { }
				public xfallback_lowObject(spt_fallback_devWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where xfallback_low = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where xfallback_low = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xfallback_low < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xfallback_low < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xfallback_low <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xfallback_low <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xfallback_low > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xfallback_low > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xfallback_low >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xfallback_low >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xfallback_low like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where xfallback_low <= " + value;
					}
				}
			}
			#endregion

			private xfallback_driveObject _xfallback_drive = null;
			public xfallback_driveObject xfallback_drive
			{
				get
				{
					if (_xfallback_drive == null)
					{
						_xfallback_drive = new xfallback_driveObject(this);
					}
					return _xfallback_drive;
				}
			}

			#region Each field object
			internal class xfallback_driveObject
			{
				public readonly spt_fallback_devWhereObject Parent = null;
				protected xfallback_driveObject() { }
				public xfallback_driveObject(spt_fallback_devWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where xfallback_drive = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where xfallback_drive = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xfallback_drive < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xfallback_drive < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xfallback_drive <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xfallback_drive <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xfallback_drive > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xfallback_drive > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xfallback_drive >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xfallback_drive >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xfallback_drive like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where xfallback_drive <= " + value;
					}
				}
			}
			#endregion

			private lowObject _low = null;
			public lowObject low
			{
				get
				{
					if (_low == null)
					{
						_low = new lowObject(this);
					}
					return _low;
				}
			}

			#region Each field object
			internal class lowObject
			{
				public readonly spt_fallback_devWhereObject Parent = null;
				protected lowObject() { }
				public lowObject(spt_fallback_devWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where low = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where low = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where low < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where low < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where low <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where low <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where low > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where low > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where low >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where low >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where low like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where low <= " + value;
					}
				}
			}
			#endregion

			private highObject _high = null;
			public highObject high
			{
				get
				{
					if (_high == null)
					{
						_high = new highObject(this);
					}
					return _high;
				}
			}

			#region Each field object
			internal class highObject
			{
				public readonly spt_fallback_devWhereObject Parent = null;
				protected highObject() { }
				public highObject(spt_fallback_devWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where high = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where high = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where high < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where high < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where high <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where high <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where high > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where high > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where high >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where high >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where high like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where high <= " + value;
					}
				}
			}
			#endregion

			private statusObject _status = null;
			public statusObject status
			{
				get
				{
					if (_status == null)
					{
						_status = new statusObject(this);
					}
					return _status;
				}
			}

			#region Each field object
			internal class statusObject
			{
				public readonly spt_fallback_devWhereObject Parent = null;
				protected statusObject() { }
				public statusObject(spt_fallback_devWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where status = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where status = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where status < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where status < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where status <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where status <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where status > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where status > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where status >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where status >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where status like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where status <= " + value;
					}
				}
			}
			#endregion

			private nameObject _name = null;
			public nameObject name
			{
				get
				{
					if (_name == null)
					{
						_name = new nameObject(this);
					}
					return _name;
				}
			}

			#region Each field object
			internal class nameObject
			{
				public readonly spt_fallback_devWhereObject Parent = null;
				protected nameObject() { }
				public nameObject(spt_fallback_devWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where name = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where name = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where name < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where name < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where name <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where name <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where name > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where name > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where name >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where name >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where name like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where name <= " + value;
					}
				}
			}
			#endregion

			private phynameObject _phyname = null;
			public phynameObject phyname
			{
				get
				{
					if (_phyname == null)
					{
						_phyname = new phynameObject(this);
					}
					return _phyname;
				}
			}

			#region Each field object
			internal class phynameObject
			{
				public readonly spt_fallback_devWhereObject Parent = null;
				protected phynameObject() { }
				public phynameObject(spt_fallback_devWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where phyname = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where phyname = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where phyname < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where phyname < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where phyname <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where phyname <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where phyname > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where phyname > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where phyname >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where phyname >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where phyname like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where phyname <= " + value;
					}
				}
			}
			#endregion

		}
		#endregion

	}
	class spt_fallback_usg
	{
		public static string TableName = "spt_fallback_usg";
		public string LastWhere { protected get; set; }
		#region Where
		private spt_fallback_usgWhereObject _whereObject = null;
		public spt_fallback_usgWhereObject Where
		{
			get
			{
				if (_whereObject == null)
				{
					_whereObject = new spt_fallback_usgWhereObject(this);
				}
				return _whereObject;
			}
		}
		#endregion

		#region Properties
		public object xserver_name { get; set; }
		public object xdttm_ins { get; set; }
		public object xdttm_last_ins_upd { get; set; }
		public object xfallback_vstart { get; set; }
		public object dbid { get; set; }
		public object segmap { get; set; }
		public object lstart { get; set; }
		public object sizepg { get; set; }
		public object vstart { get; set; }
		#endregion

		public static class Fields
		{
			public const string xserver_name = "xserver_name";
			public const string xdttm_ins = "xdttm_ins";
			public const string xdttm_last_ins_upd = "xdttm_last_ins_upd";
			public const string xfallback_vstart = "xfallback_vstart";
			public const string dbid = "dbid";
			public const string segmap = "segmap";
			public const string lstart = "lstart";
			public const string sizepg = "sizepg";
			public const string vstart = "vstart";
		}
		public static string[] FieldList = {Fields.xserver_name, Fields.xdttm_ins, Fields.xdttm_last_ins_upd, Fields.xfallback_vstart, Fields.dbid, Fields.segmap, Fields.lstart, Fields.sizepg, Fields.vstart};

		#region Methods
		public void Insert() { DBAdapter.Insert(this); }
		public void Update() { DBAdapter.Update(this); }
		public void Delete() { DBAdapter.Delete(this); }
		public DataSet Select() { return DBAdapter.Select(this); }
		#endregion

		#region Where Object
		public class spt_fallback_usgWhereObject
		{
			public readonly spt_fallback_usg Parent = null;
			protected spt_fallback_usgWhereObject(){ }
			public spt_fallback_usgWhereObject(spt_fallback_usg parent){ this.Parent = parent; }

			private xserver_nameObject _xserver_name = null;
			public xserver_nameObject xserver_name
			{
				get
				{
					if (_xserver_name == null)
					{
						_xserver_name = new xserver_nameObject(this);
					}
					return _xserver_name;
				}
			}

			#region Each field object
			internal class xserver_nameObject
			{
				public readonly spt_fallback_usgWhereObject Parent = null;
				protected xserver_nameObject() { }
				public xserver_nameObject(spt_fallback_usgWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where xserver_name = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where xserver_name = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xserver_name < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xserver_name < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xserver_name <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xserver_name <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xserver_name > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xserver_name > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xserver_name >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xserver_name >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xserver_name like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where xserver_name <= " + value;
					}
				}
			}
			#endregion

			private xdttm_insObject _xdttm_ins = null;
			public xdttm_insObject xdttm_ins
			{
				get
				{
					if (_xdttm_ins == null)
					{
						_xdttm_ins = new xdttm_insObject(this);
					}
					return _xdttm_ins;
				}
			}

			#region Each field object
			internal class xdttm_insObject
			{
				public readonly spt_fallback_usgWhereObject Parent = null;
				protected xdttm_insObject() { }
				public xdttm_insObject(spt_fallback_usgWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where xdttm_ins = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where xdttm_ins = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_ins < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xdttm_ins < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_ins <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xdttm_ins <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_ins > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xdttm_ins > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_ins >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xdttm_ins >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_ins like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where xdttm_ins <= " + value;
					}
				}
			}
			#endregion

			private xdttm_last_ins_updObject _xdttm_last_ins_upd = null;
			public xdttm_last_ins_updObject xdttm_last_ins_upd
			{
				get
				{
					if (_xdttm_last_ins_upd == null)
					{
						_xdttm_last_ins_upd = new xdttm_last_ins_updObject(this);
					}
					return _xdttm_last_ins_upd;
				}
			}

			#region Each field object
			internal class xdttm_last_ins_updObject
			{
				public readonly spt_fallback_usgWhereObject Parent = null;
				protected xdttm_last_ins_updObject() { }
				public xdttm_last_ins_updObject(spt_fallback_usgWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where xdttm_last_ins_upd = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where xdttm_last_ins_upd = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_last_ins_upd < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xdttm_last_ins_upd < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_last_ins_upd <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xdttm_last_ins_upd <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_last_ins_upd > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xdttm_last_ins_upd > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_last_ins_upd >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xdttm_last_ins_upd >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xdttm_last_ins_upd like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where xdttm_last_ins_upd <= " + value;
					}
				}
			}
			#endregion

			private xfallback_vstartObject _xfallback_vstart = null;
			public xfallback_vstartObject xfallback_vstart
			{
				get
				{
					if (_xfallback_vstart == null)
					{
						_xfallback_vstart = new xfallback_vstartObject(this);
					}
					return _xfallback_vstart;
				}
			}

			#region Each field object
			internal class xfallback_vstartObject
			{
				public readonly spt_fallback_usgWhereObject Parent = null;
				protected xfallback_vstartObject() { }
				public xfallback_vstartObject(spt_fallback_usgWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where xfallback_vstart = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where xfallback_vstart = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xfallback_vstart < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xfallback_vstart < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xfallback_vstart <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xfallback_vstart <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xfallback_vstart > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xfallback_vstart > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xfallback_vstart >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where xfallback_vstart >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where xfallback_vstart like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where xfallback_vstart <= " + value;
					}
				}
			}
			#endregion

			private dbidObject _dbid = null;
			public dbidObject dbid
			{
				get
				{
					if (_dbid == null)
					{
						_dbid = new dbidObject(this);
					}
					return _dbid;
				}
			}

			#region Each field object
			internal class dbidObject
			{
				public readonly spt_fallback_usgWhereObject Parent = null;
				protected dbidObject() { }
				public dbidObject(spt_fallback_usgWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where dbid = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where dbid = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where dbid < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where dbid < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where dbid <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where dbid <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where dbid > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where dbid > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where dbid >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where dbid >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where dbid like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where dbid <= " + value;
					}
				}
			}
			#endregion

			private segmapObject _segmap = null;
			public segmapObject segmap
			{
				get
				{
					if (_segmap == null)
					{
						_segmap = new segmapObject(this);
					}
					return _segmap;
				}
			}

			#region Each field object
			internal class segmapObject
			{
				public readonly spt_fallback_usgWhereObject Parent = null;
				protected segmapObject() { }
				public segmapObject(spt_fallback_usgWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where segmap = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where segmap = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where segmap < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where segmap < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where segmap <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where segmap <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where segmap > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where segmap > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where segmap >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where segmap >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where segmap like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where segmap <= " + value;
					}
				}
			}
			#endregion

			private lstartObject _lstart = null;
			public lstartObject lstart
			{
				get
				{
					if (_lstart == null)
					{
						_lstart = new lstartObject(this);
					}
					return _lstart;
				}
			}

			#region Each field object
			internal class lstartObject
			{
				public readonly spt_fallback_usgWhereObject Parent = null;
				protected lstartObject() { }
				public lstartObject(spt_fallback_usgWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where lstart = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where lstart = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where lstart < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where lstart < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where lstart <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where lstart <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where lstart > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where lstart > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where lstart >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where lstart >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where lstart like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where lstart <= " + value;
					}
				}
			}
			#endregion

			private sizepgObject _sizepg = null;
			public sizepgObject sizepg
			{
				get
				{
					if (_sizepg == null)
					{
						_sizepg = new sizepgObject(this);
					}
					return _sizepg;
				}
			}

			#region Each field object
			internal class sizepgObject
			{
				public readonly spt_fallback_usgWhereObject Parent = null;
				protected sizepgObject() { }
				public sizepgObject(spt_fallback_usgWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where sizepg = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where sizepg = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where sizepg < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where sizepg < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where sizepg <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where sizepg <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where sizepg > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where sizepg > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where sizepg >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where sizepg >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where sizepg like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where sizepg <= " + value;
					}
				}
			}
			#endregion

			private vstartObject _vstart = null;
			public vstartObject vstart
			{
				get
				{
					if (_vstart == null)
					{
						_vstart = new vstartObject(this);
					}
					return _vstart;
				}
			}

			#region Each field object
			internal class vstartObject
			{
				public readonly spt_fallback_usgWhereObject Parent = null;
				protected vstartObject() { }
				public vstartObject(spt_fallback_usgWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where vstart = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where vstart = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where vstart < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where vstart < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where vstart <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where vstart <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where vstart > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where vstart > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where vstart >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where vstart >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where vstart like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where vstart <= " + value;
					}
				}
			}
			#endregion

		}
		#endregion

	}
	class spt_monitor
	{
		public static string TableName = "spt_monitor";
		public string LastWhere { protected get; set; }
		#region Where
		private spt_monitorWhereObject _whereObject = null;
		public spt_monitorWhereObject Where
		{
			get
			{
				if (_whereObject == null)
				{
					_whereObject = new spt_monitorWhereObject(this);
				}
				return _whereObject;
			}
		}
		#endregion

		#region Properties
		public object lastrun { get; set; }
		public object cpu_busy { get; set; }
		public object io_busy { get; set; }
		public object idle { get; set; }
		public object pack_received { get; set; }
		public object pack_sent { get; set; }
		public object connections { get; set; }
		public object pack_errors { get; set; }
		public object total_read { get; set; }
		public object total_write { get; set; }
		public object total_errors { get; set; }
		#endregion

		public static class Fields
		{
			public const string lastrun = "lastrun";
			public const string cpu_busy = "cpu_busy";
			public const string io_busy = "io_busy";
			public const string idle = "idle";
			public const string pack_received = "pack_received";
			public const string pack_sent = "pack_sent";
			public const string connections = "connections";
			public const string pack_errors = "pack_errors";
			public const string total_read = "total_read";
			public const string total_write = "total_write";
			public const string total_errors = "total_errors";
		}
		public static string[] FieldList = {Fields.lastrun, Fields.cpu_busy, Fields.io_busy, Fields.idle, Fields.pack_received, Fields.pack_sent, Fields.connections, Fields.pack_errors, Fields.total_read, Fields.total_write, Fields.total_errors};

		#region Methods
		public void Insert() { DBAdapter.Insert(this); }
		public void Update() { DBAdapter.Update(this); }
		public void Delete() { DBAdapter.Delete(this); }
		public DataSet Select() { return DBAdapter.Select(this); }
		#endregion

		#region Where Object
		public class spt_monitorWhereObject
		{
			public readonly spt_monitor Parent = null;
			protected spt_monitorWhereObject(){ }
			public spt_monitorWhereObject(spt_monitor parent){ this.Parent = parent; }

			private lastrunObject _lastrun = null;
			public lastrunObject lastrun
			{
				get
				{
					if (_lastrun == null)
					{
						_lastrun = new lastrunObject(this);
					}
					return _lastrun;
				}
			}

			#region Each field object
			internal class lastrunObject
			{
				public readonly spt_monitorWhereObject Parent = null;
				protected lastrunObject() { }
				public lastrunObject(spt_monitorWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where lastrun = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where lastrun = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where lastrun < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where lastrun < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where lastrun <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where lastrun <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where lastrun > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where lastrun > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where lastrun >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where lastrun >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where lastrun like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where lastrun <= " + value;
					}
				}
			}
			#endregion

			private cpu_busyObject _cpu_busy = null;
			public cpu_busyObject cpu_busy
			{
				get
				{
					if (_cpu_busy == null)
					{
						_cpu_busy = new cpu_busyObject(this);
					}
					return _cpu_busy;
				}
			}

			#region Each field object
			internal class cpu_busyObject
			{
				public readonly spt_monitorWhereObject Parent = null;
				protected cpu_busyObject() { }
				public cpu_busyObject(spt_monitorWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where cpu_busy = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where cpu_busy = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where cpu_busy < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where cpu_busy < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where cpu_busy <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where cpu_busy <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where cpu_busy > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where cpu_busy > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where cpu_busy >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where cpu_busy >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where cpu_busy like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where cpu_busy <= " + value;
					}
				}
			}
			#endregion

			private io_busyObject _io_busy = null;
			public io_busyObject io_busy
			{
				get
				{
					if (_io_busy == null)
					{
						_io_busy = new io_busyObject(this);
					}
					return _io_busy;
				}
			}

			#region Each field object
			internal class io_busyObject
			{
				public readonly spt_monitorWhereObject Parent = null;
				protected io_busyObject() { }
				public io_busyObject(spt_monitorWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where io_busy = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where io_busy = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where io_busy < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where io_busy < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where io_busy <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where io_busy <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where io_busy > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where io_busy > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where io_busy >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where io_busy >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where io_busy like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where io_busy <= " + value;
					}
				}
			}
			#endregion

			private idleObject _idle = null;
			public idleObject idle
			{
				get
				{
					if (_idle == null)
					{
						_idle = new idleObject(this);
					}
					return _idle;
				}
			}

			#region Each field object
			internal class idleObject
			{
				public readonly spt_monitorWhereObject Parent = null;
				protected idleObject() { }
				public idleObject(spt_monitorWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where idle = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where idle = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where idle < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where idle < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where idle <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where idle <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where idle > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where idle > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where idle >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where idle >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where idle like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where idle <= " + value;
					}
				}
			}
			#endregion

			private pack_receivedObject _pack_received = null;
			public pack_receivedObject pack_received
			{
				get
				{
					if (_pack_received == null)
					{
						_pack_received = new pack_receivedObject(this);
					}
					return _pack_received;
				}
			}

			#region Each field object
			internal class pack_receivedObject
			{
				public readonly spt_monitorWhereObject Parent = null;
				protected pack_receivedObject() { }
				public pack_receivedObject(spt_monitorWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where pack_received = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where pack_received = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where pack_received < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where pack_received < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where pack_received <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where pack_received <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where pack_received > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where pack_received > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where pack_received >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where pack_received >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where pack_received like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where pack_received <= " + value;
					}
				}
			}
			#endregion

			private pack_sentObject _pack_sent = null;
			public pack_sentObject pack_sent
			{
				get
				{
					if (_pack_sent == null)
					{
						_pack_sent = new pack_sentObject(this);
					}
					return _pack_sent;
				}
			}

			#region Each field object
			internal class pack_sentObject
			{
				public readonly spt_monitorWhereObject Parent = null;
				protected pack_sentObject() { }
				public pack_sentObject(spt_monitorWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where pack_sent = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where pack_sent = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where pack_sent < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where pack_sent < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where pack_sent <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where pack_sent <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where pack_sent > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where pack_sent > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where pack_sent >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where pack_sent >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where pack_sent like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where pack_sent <= " + value;
					}
				}
			}
			#endregion

			private connectionsObject _connections = null;
			public connectionsObject connections
			{
				get
				{
					if (_connections == null)
					{
						_connections = new connectionsObject(this);
					}
					return _connections;
				}
			}

			#region Each field object
			internal class connectionsObject
			{
				public readonly spt_monitorWhereObject Parent = null;
				protected connectionsObject() { }
				public connectionsObject(spt_monitorWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where connections = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where connections = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where connections < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where connections < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where connections <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where connections <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where connections > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where connections > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where connections >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where connections >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where connections like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where connections <= " + value;
					}
				}
			}
			#endregion

			private pack_errorsObject _pack_errors = null;
			public pack_errorsObject pack_errors
			{
				get
				{
					if (_pack_errors == null)
					{
						_pack_errors = new pack_errorsObject(this);
					}
					return _pack_errors;
				}
			}

			#region Each field object
			internal class pack_errorsObject
			{
				public readonly spt_monitorWhereObject Parent = null;
				protected pack_errorsObject() { }
				public pack_errorsObject(spt_monitorWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where pack_errors = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where pack_errors = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where pack_errors < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where pack_errors < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where pack_errors <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where pack_errors <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where pack_errors > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where pack_errors > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where pack_errors >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where pack_errors >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where pack_errors like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where pack_errors <= " + value;
					}
				}
			}
			#endregion

			private total_readObject _total_read = null;
			public total_readObject total_read
			{
				get
				{
					if (_total_read == null)
					{
						_total_read = new total_readObject(this);
					}
					return _total_read;
				}
			}

			#region Each field object
			internal class total_readObject
			{
				public readonly spt_monitorWhereObject Parent = null;
				protected total_readObject() { }
				public total_readObject(spt_monitorWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where total_read = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where total_read = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where total_read < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where total_read < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where total_read <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where total_read <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where total_read > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where total_read > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where total_read >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where total_read >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where total_read like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where total_read <= " + value;
					}
				}
			}
			#endregion

			private total_writeObject _total_write = null;
			public total_writeObject total_write
			{
				get
				{
					if (_total_write == null)
					{
						_total_write = new total_writeObject(this);
					}
					return _total_write;
				}
			}

			#region Each field object
			internal class total_writeObject
			{
				public readonly spt_monitorWhereObject Parent = null;
				protected total_writeObject() { }
				public total_writeObject(spt_monitorWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where total_write = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where total_write = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where total_write < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where total_write < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where total_write <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where total_write <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where total_write > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where total_write > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where total_write >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where total_write >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where total_write like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where total_write <= " + value;
					}
				}
			}
			#endregion

			private total_errorsObject _total_errors = null;
			public total_errorsObject total_errors
			{
				get
				{
					if (_total_errors == null)
					{
						_total_errors = new total_errorsObject(this);
					}
					return _total_errors;
				}
			}

			#region Each field object
			internal class total_errorsObject
			{
				public readonly spt_monitorWhereObject Parent = null;
				protected total_errorsObject() { }
				public total_errorsObject(spt_monitorWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where total_errors = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where total_errors = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where total_errors < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where total_errors < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where total_errors <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where total_errors <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where total_errors > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where total_errors > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where total_errors >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where total_errors >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where total_errors like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where total_errors <= " + value;
					}
				}
			}
			#endregion

		}
		#endregion

	}
	class spt_values
	{
		public static string TableName = "spt_values";
		public string LastWhere { protected get; set; }
		#region Where
		private spt_valuesWhereObject _whereObject = null;
		public spt_valuesWhereObject Where
		{
			get
			{
				if (_whereObject == null)
				{
					_whereObject = new spt_valuesWhereObject(this);
				}
				return _whereObject;
			}
		}
		#endregion

		#region Properties
		public object name { get; set; }
		public object number { get; set; }
		public object type { get; set; }
		public object low { get; set; }
		public object high { get; set; }
		public object status { get; set; }
		#endregion

		public static class Fields
		{
			public const string name = "name";
			public const string number = "number";
			public const string type = "type";
			public const string low = "low";
			public const string high = "high";
			public const string status = "status";
		}
		public static string[] FieldList = {Fields.name, Fields.number, Fields.type, Fields.low, Fields.high, Fields.status};

		#region Methods
		public void Insert() { DBAdapter.Insert(this); }
		public void Update() { DBAdapter.Update(this); }
		public void Delete() { DBAdapter.Delete(this); }
		public DataSet Select() { return DBAdapter.Select(this); }
		#endregion

		#region Where Object
		public class spt_valuesWhereObject
		{
			public readonly spt_values Parent = null;
			protected spt_valuesWhereObject(){ }
			public spt_valuesWhereObject(spt_values parent){ this.Parent = parent; }

			private nameObject _name = null;
			public nameObject name
			{
				get
				{
					if (_name == null)
					{
						_name = new nameObject(this);
					}
					return _name;
				}
			}

			#region Each field object
			internal class nameObject
			{
				public readonly spt_valuesWhereObject Parent = null;
				protected nameObject() { }
				public nameObject(spt_valuesWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where name = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where name = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where name < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where name < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where name <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where name <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where name > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where name > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where name >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where name >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where name like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where name <= " + value;
					}
				}
			}
			#endregion

			private numberObject _number = null;
			public numberObject number
			{
				get
				{
					if (_number == null)
					{
						_number = new numberObject(this);
					}
					return _number;
				}
			}

			#region Each field object
			internal class numberObject
			{
				public readonly spt_valuesWhereObject Parent = null;
				protected numberObject() { }
				public numberObject(spt_valuesWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where number = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where number = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where number < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where number < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where number <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where number <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where number > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where number > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where number >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where number >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where number like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where number <= " + value;
					}
				}
			}
			#endregion

			private typeObject _type = null;
			public typeObject type
			{
				get
				{
					if (_type == null)
					{
						_type = new typeObject(this);
					}
					return _type;
				}
			}

			#region Each field object
			internal class typeObject
			{
				public readonly spt_valuesWhereObject Parent = null;
				protected typeObject() { }
				public typeObject(spt_valuesWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where type = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where type = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where type < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where type < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where type <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where type <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where type > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where type > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where type >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where type >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where type like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where type <= " + value;
					}
				}
			}
			#endregion

			private lowObject _low = null;
			public lowObject low
			{
				get
				{
					if (_low == null)
					{
						_low = new lowObject(this);
					}
					return _low;
				}
			}

			#region Each field object
			internal class lowObject
			{
				public readonly spt_valuesWhereObject Parent = null;
				protected lowObject() { }
				public lowObject(spt_valuesWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where low = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where low = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where low < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where low < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where low <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where low <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where low > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where low > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where low >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where low >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where low like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where low <= " + value;
					}
				}
			}
			#endregion

			private highObject _high = null;
			public highObject high
			{
				get
				{
					if (_high == null)
					{
						_high = new highObject(this);
					}
					return _high;
				}
			}

			#region Each field object
			internal class highObject
			{
				public readonly spt_valuesWhereObject Parent = null;
				protected highObject() { }
				public highObject(spt_valuesWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where high = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where high = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where high < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where high < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where high <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where high <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where high > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where high > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where high >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where high >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where high like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where high <= " + value;
					}
				}
			}
			#endregion

			private statusObject _status = null;
			public statusObject status
			{
				get
				{
					if (_status == null)
					{
						_status = new statusObject(this);
					}
					return _status;
				}
			}

			#region Each field object
			internal class statusObject
			{
				public readonly spt_valuesWhereObject Parent = null;
				protected statusObject() { }
				public statusObject(spt_valuesWhereObject parent) { this.Parent = parent; }
				public string Equal(Object value)
				{
					 string lastWhere = "";
					if (value.GetType() == typeof(string))
					{
						lastWhere = " where status = '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						lastWhere = " where status = " + value;
					}
					this.Parent.Parent.LastWhere = lastWhere;
					return lastWhere;
				}
				public string LessThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where status < '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where status < " + value;
					}
				}
				public string LessThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where status <= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where status <= " + value;
					}
				}
				public string GreaterThan(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where status > '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where status > " + value;
					}
				}
				public string GreaterThanEqual(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where status >= '" + value.ToString().Replace("'", "''") + "'";
					}
					else
					{
						return " where status >= " + value;
					}
				}
				public string Like(Object value)
				{
					if (value.GetType() == typeof(string))
					{
						return " where status like '%" + value.ToString().Replace("'", "''") + "%'";
					}
					else
					{
						return " where status <= " + value;
					}
				}
			}
			#endregion

		}
		#endregion

	}

    #region DBAdapter
    class DBAdapter
    {
        private static string mConStr = "Data Source=CBVN-PC037;Initial Catalog=MyFrameWork;Persist Security Info=True;Integrated Security=True";

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
                throw new ArgumentNullException("Where");
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
