using System;
using System.Data;
using System.Data.SqlClient;

namespace MMTB.DAO
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
                            ,ItemNameEN
                            ,ItemNameVN
                            ,ItemNameJP
                            ,Unit
                            ,QtyNeed
                            ,LifeTime
                            ,Location
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
	                        M0014_BatteryMMTB
                        ORDER BY NameEN, Model";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Code", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
    }
}