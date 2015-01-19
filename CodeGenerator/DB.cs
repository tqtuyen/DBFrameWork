using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Linq.Expressions;

namespace CodeGenerator
{
    class DB
    {
        public static String mConStr = "Data Source=CBVN-PC037;Initial Catalog=MyFrameWork;Persist Security Info=True;Integrated Security=True";

        private static SqlConnection getCon()
        {
            SqlConnection con = new SqlConnection(mConStr);
            con.Open();
            return con;
        }
        public static DataSet DataSet(int _fromDb, String _sql, String[] _parameters = null, Object[] _values = null)
        {
            //Sample: query 
            //String sql = " select ps.UserId, UserShopId, s.UserName ShopUserName, p.productId, productName, UnitPrice, Currency";
            //sql += " where pp.active = 1 and pp.personId = @personId order by pp.createdDate desc;";

            //DataSet ds = DB.DataSet(DB.__DBShop, sql, new String[] { "@personId" }, new Object[] { _personId });
            //===================================================================================

            DB db = new DB();
            
            SqlConnection con = getCon();
            SqlCommand cmd = new SqlCommand(_sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();

            if (_parameters != null && _values != null)
            {

                for (int i = 0; i < _parameters.Length; i++)
                {
                    cmd.Parameters.Add(new SqlParameter(_parameters.GetValue(i).ToString(), _values.GetValue(i)));
                }
            }

            da.SelectCommand = cmd;
            da.Fill(ds);
            con.Close();

            return ds;

        }
        public static void ExecuteQuery(int _fromDb, String _sql, String[] _parameters = null, Object[] _values = null)
        {

            DB db = new DB();

            SqlConnection con = getCon();
            SqlCommand cmd = new SqlCommand(_sql, con);

            if (_parameters != null && _values != null)
            {
                for (int i = 0; i < _parameters.Length; i++)
                {
                    cmd.Parameters.Add(new SqlParameter(_parameters.GetValue(i).ToString(), _values.GetValue(i)));
                }
            }

            cmd.ExecuteNonQuery();
            con.Close();

        }
        public static void ExecQuery(String sql)
        {

            SqlConnection con = getCon();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public static DataSet GetDataSet(String sql)
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
        public static DataTable GetTables()
        {
            DataTable oAllTables = new DataTable();
            DataTable UserTables = new DataTable();
            DataRow NewRow = null;
            try
            {
                using (SqlConnection conn = getCon())
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "sp_tables";
                        cmd.Connection = conn;

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(oAllTables);
                            UserTables = oAllTables.Clone();
                            foreach (DataRow oRow in oAllTables.Rows)
                            {
                                if (oRow["TABLE_TYPE"].ToString() == "SYSTEM TABLE") { continue; }
                                if (oRow["TABLE_TYPE"].ToString() == "VIEW") { continue; }
                                if (oRow["TABLE_NAME"].ToString() == "dtproperties") { continue; }
                                NewRow = UserTables.NewRow();
                                NewRow.ItemArray = oRow.ItemArray;
                                NewRow["TABLE_NAME"] = NewRow["TABLE_NAME"].ToString().Replace(" ", ""); 
                                UserTables.Rows.Add(NewRow);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return UserTables;
        }
        public static DataTable GetColumns(string tableName)
        {
            DataTable table = new DataTable();
            try
            {
                using (SqlConnection conn = getCon())
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "sp_columns";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@table_name", SqlDbType.NVarChar, 384));
                        cmd.Parameters["@table_name"].Value = tableName;

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(table);
                        }
                    }
                }
            }
            catch (Exception) { throw; }
            
            return table;
        }
    }
}
