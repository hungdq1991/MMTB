using System;
using System.Data;
using System.Data.SqlClient;

namespace TAKAKO_ERP_3LAYER.DAO
{
    public class M0003_Process_DAO
    {
        private DBConnection conn;
        /// <constructor>
        /// Constructor M0003_Process_DAO
        /// </constructor>
        public M0003_Process_DAO()
        {
            conn = new DBConnection();
        }

        public DataTable GetInfo_M0003()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
                             ProcessID
                            ,ProcessNameEN
                            ,ProcessNameVN
                            ,ProcessNameJP
                            ,ProcessGroup
                            ,Point
                            ,Memo
                            ,isOutsource
                            ,InActive
                            ,InputDate
                            ,InputUser
                            ,ModifyDate
                            ,ModifyUser
                            ,Column1
                            ,Column2
                            ,Column3
                            ,Column4
                            ,Column5
                        FROM 
	                        M0003_Process";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DueDateFrom", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
    }
}