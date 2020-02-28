using System;
using System.Data;
using System.Data.SqlClient;

namespace TAKAKO_ERP_3LAYER.DAO
{
    public class M01_Session_DAO
    {
        private DBConnection conn;
        /// <constructor>
        /// Constructor M01_Session_DAO
        /// </constructor>
        public M01_Session_DAO()
        {
            conn = new DBConnection();
        }
        ////Dữ liệu từ table M01_Section
        public DataTable GetInfo_M01_Session()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();
            StrQuery = @"SELECT
                        	   SessionID
                              ,SessionDesc
                              ,InputDate
                              ,InputUser
                         FROM
                        	  M01_Session";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DueDateFrom", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
    }
}
