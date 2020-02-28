using System;
using System.Data;
using System.Data.SqlClient;

namespace TAKAKO_ERP_3LAYER.DAO
{
    public class M0014_DAO
    {
        private DBConnection conn;
        /// <constructor>
        /// Constructor M0014_DAO
        /// </constructor>
        public M0014_DAO()
        {
            conn = new DBConnection();
        }

        public DataTable GetInfo_M0014()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
	                         Code
                            ,ACCcode
                            ,NameEN
                            ,NameVN
                            ,NameJP
                            ,Maker
                            ,Model
                            ,ItemCode
                            ,Unit
                            ,PriceRef
                            ,QtyNeed
                            ,LifeTime
                            ,Location
                            ,PurCode
                            ,ApplyDate
                            ,InActive
                            ,Memo
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
	                        M0014_BatteryMMTB";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DueDateFrom", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
    }
}