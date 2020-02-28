using System;
using System.Data;
using System.Data.SqlClient;

namespace TAKAKO_ERP_3LAYER.DAO
{
    public class M0012_DAO
    {
        private DBConnection conn;
        /// <constructor>
        /// Constructor M0012_DAO
        /// </constructor>
        public M0012_DAO()
        {
            conn = new DBConnection();
        }

        public DataTable GetInfo_M0012()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
	                         ItemCode
                            ,NameEN
                            ,NameVN
                            ,NameJP
                            ,SessionID
                            ,Maker
                            ,PurUnit
                            ,Unit
                            ,UnitMulDiv
                            ,CnvtQty
                            ,PriceRef
                            ,Point
                            ,MinimumQty
                            ,LifeTime
                            ,PurCode
                            ,WH1Code
                            ,WH2Code
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
	                        M0012_SupplyMMTB";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DueDateFrom", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
    }
}