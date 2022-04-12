using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class SqlConnect
    {
        public static SqlConnection connect()
        {
            string strConn = "Data Source=.;Initial Catalog=QLBH;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strConn);
            return conn;
        }
    }
    public class DatabaseAccess
    {
        public SqlConnection conn = SqlConnect.connect();
        public string CheckLogin(LoginProp prop)
        {
            string user = null;

            SqlCommand cmd = new SqlCommand("PROC_LOGIN", this.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USERN", prop.username);
            cmd.Parameters.AddWithValue("@PASS", prop.password);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetString(0);
                }
                reader.Close();
                this.conn.Close();
            }
            else return "US_OR_PA-WRO";
            return user;
        }
        public DataTable SelectData(string tableName)
        {
            string query = String.Format("SELECT * FROM {0}", tableName);
            SqlDataAdapter adap = new SqlDataAdapter(query,this.conn);
            DataTable dt = new DataTable();
            dt.Clear();
            adap.Fill(dt);
            return dt;
        }
        public DataTable SelectDataORDER(string tableName, string id, string typeorder)
        {
            string query = String.Format("SELECT * FROM {0} ORDER BY {1} {2}", 
                tableName, id, typeorder);
            SqlDataAdapter adap = new SqlDataAdapter(query, this.conn);
            DataTable dt = new DataTable();
            dt.Clear();
            adap.Fill(dt);
            return dt;
        }
        public DataTable SelectData(string tableName, string idname, object id)
        {
            string query = String.Format("SELECT * FROM {0} WHERE {1} LIKE N'%{2}%'", tableName,
                idname, id);
            SqlDataAdapter adap = new SqlDataAdapter(query, this.conn);
            DataTable dt = new DataTable();
            dt.Clear();
            adap.Fill(dt);
            return dt;
        }
        public string InsertData(string tableName, Dictionary<string, object> columns)
        {
            string columnKey = "";
            string columnVal = "";
            foreach (var column in columns)
            {
                columnKey += String.Format("{0},", column.Key);
                columnVal += String.Format("{0},", column.Value);
            }
            
            string key = columnKey.Substring(0, columnKey.Length - 1);
            string value = columnVal.Substring(0, columnVal.Length - 1);
            string query = String.Format("INSERT INTO {0}({1}) VALUES({2})",
                tableName, key, value);
            SqlCommand cmd = new SqlCommand(query, this.conn);

            cmd.Connection.Open();
            string res = (cmd.ExecuteNonQuery() > 0) ?
                "Đã thêm thành công" :
                "Quá trình thêm thất bại";
            cmd.Connection.Close();
            return res;
        }
        public string UpdateData(string tableName, Dictionary<string,object> columns, object id, string idname)
        {
            string columnAll = "";
            var columnsQ = columns;
            foreach(var column in columnsQ)
            {
                columnAll += String.Format("{0}={1}", column.Key, column.Value);
            }
            string trulyColumns = columnAll.Substring(0, columnAll.Length - 2);
            string query = String.Format("UPDATE {0} SET {1} WHERE {2}={3}", trulyColumns,
            tableName, idname, id);
            SqlCommand cmd = new SqlCommand(query, this.conn);

            cmd.Connection.Open();
                string res = (cmd.ExecuteNonQuery() > 0) ? 
                    "Đã cập nhật thành công" : 
                    "Cập nhật thất bại";
            cmd.Connection.Close();
            return res;
        }
        public string DeleteData(string tableName, string idname, object id)
        {
            string query = String.Format("DELETE FROM {0} WHERE {1}={2}", 
                tableName, idname, id);
            SqlCommand cmd = new SqlCommand(query, this.conn);

            cmd.Connection.Open();
                string res = (cmd.ExecuteNonQuery() > 0) ?
                    "Đã xóa thành công" :
                    "Xóa thất bại";
            cmd.Connection.Close();
            return res;
        }
        public string[] AutoComplete(string tableName, string autoName, int lengthAC)
        {
            string[] nameCols; 
            string query = String.Format("SELECT * FROM {0}", tableName);
            SqlCommand cmd = new SqlCommand(query, this.conn);
            try
            {
                this.conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                int i = 0;
                nameCols = new string[lengthAC];
                while (reader.Read())
                {
                    nameCols[i] = reader[autoName].ToString();
                    i++;
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd != null) cmd.Dispose();
                if (conn != null) this.conn.Close();
            }
            return nameCols;
        }
        
    }
}
