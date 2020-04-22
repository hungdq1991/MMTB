using System;
using System.Data;
using System.Data.SqlClient;

namespace TAKAKO_ERP_3LAYER.DAO
{
    public class M0015_DAO
    {
        private DBConnection conn;
        /// <constructor>
        /// Constructor M0015_DAO
        /// </constructor>
        public M0015_DAO()
        {
            conn = new DBConnection();
        }

        public DataTable GetInfo_M0015()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
	                         L.NameEN
                            ,L.NameVN
                            ,L.NameJP
                            ,L.Maker
                            ,L.Model
                            ,L.ItemCode
	                        ,L.ItemNameEN
                            ,L.ItemNameVN
                            ,L.ItemNameJP                
                            ,L.Unit
                            ,L.QtyNeed
                            ,L.LifeTime
                            ,L.Location
                            ,L.ApplyDate
                            ,L.InActive
                            ,L.Memo
                            ,L.InputDate
                            ,L.InputUser
                            ,L.ModifyDate
                            ,L.ModifyUser
                            ,L.Column1
                            ,L.Column2
                            ,L.Column3
                            ,L.Column4
                            ,L.Column5
							,S.PurCode
							,CASE WHEN P.EF_PurCuryID IS NULL THEN '' ELSE P.EF_PurCuryID END AS EF_PurCuryID
							,CASE WHEN P.EF_PurCuryPrice IS NULL THEN 0 ELSE P.EF_PurCuryPrice END AS EF_PurCuryPrice
							,CASE WHEN P.EF_EffDate is null THEN NULL ELSE P.EF_EffDate END AS EF_EffDate
							,CASE WHEN P.EF_VendID is null THEN '' ELSE P.EF_VendID END AS EF_VendID
							,CASE WHEN P.EF_VendName is null THEN '' ELSE P.EF_VendName END AS EF_VendName
							,CASE WHEN P.EF_PurUnit is null THEN '' ELSE P.EF_PurUnit END AS EF_PurUnit
                        FROM 
	                        M0015_PartMMTB L
                        JOIN
                            M0012_SupplyMMTB S
                        ON L.ItemCode = S.ItemCode
                        LEFT JOIN
                            (SELECT 
                                 P.EF_InvtID
                                ,P.EF_PurCuryID
                                ,P.EF_PurCuryPrice
                                ,P.EF_EffDate
                                ,P.EF_VendID
                                ,P.EF_VendName
                                ,P.EF_PurUnit
                            FROM [SOLOMON-SERVER].[TVCAPP].[dbo].[xt_CPMapPrice] P
                            JOIN 
                                (SELECT 
                                     EF_InvtID
                                    ,MAX(EF_EffDate) as EF_EffDate 
                                FROM [SOLOMON-SERVER].[TVCAPP].[dbo].[xt_CPMapPrice] 
                                GROUP BY EF_InvtID) D
                            ON P.EF_InvtID = D.EF_InvtID 
                            AND P.EF_EffDate = D.EF_EffDate
                            WHERE P.S4Future10 = 1) P
                        ON
                            S.PurCode = P.EF_InvtID
                        ORDER BY L.NameEN, L.Model";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DueDateFrom", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        public DataTable GetInfo_M0015_Model()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
	                         distinct NameEN
                            ,Model
                        FROM 
	                        M0015_PartMMTB";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@NameEN", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
    }

}