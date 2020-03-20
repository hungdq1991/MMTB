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
        //Load dữ liệu trên form
        public DataTable GetInfo_M0012()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
							 L.ItemCode
                            ,L.NameEN
                            ,L.NameVN
                            ,L.NameJP
                            ,L.SessionID
                            ,L.Maker
                            ,P.EF_PurUnit
                            ,L.Unit
                            ,L.UnitMulDiv
                            ,L.CnvtQty
                            ,L.Point
                            ,L.MinimumQty
                            ,L.LifeTime
                            ,L.PurCode
                            ,L.WH1Code
                            ,L.WH2Code
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
							,L.Group1
							,L.Group2
							,CASE WHEN P.EF_PurCuryID IS NULL THEN '' ELSE P.EF_PurCuryID END AS Cury
							,CASE WHEN P.EF_PurCuryPrice IS NULL THEN 0 ELSE P.EF_PurCuryPrice END AS Price
							,CASE WHEN P.EF_EffDate is null THEN NULL ELSE P.EF_EffDate END AS EffDate
							,CASE WHEN P.EF_VendID is null THEN '' ELSE P.EF_VendID END AS EF_VendID
							,CASE WHEN P.EF_VendName is null THEN '' ELSE P.EF_VendName END AS EF_VendName
						FROM (SELECT 
	                             ItemCode
                                ,L.NameEN
                                ,L.NameVN
                                ,L.NameJP
                                ,CASE WHEN SessionID = 1 THEN 'LK' ELSE (CASE WHEN SessionID = 4 THEN N'Dầu' ELSE  'Pin' END ) END as SessionID
                                ,Maker
                                ,PurUnit
                                ,Unit
                                ,UnitMulDiv
                                ,CnvtQty
                                ,Point
                                ,MinimumQty
                                ,LifeTime
                                ,PurCode
                                ,WH1Code
                                ,WH2Code
                                ,L.ApplyDate
                                ,L.InActive
                                ,Memo
                                ,L.InputDate
                                ,L.InputUser
                                ,L.ModifyDate
                                ,L.ModifyUser
                                ,L.Column1
                                ,L.Column2
                                ,L.Column3
                                ,L.Column4
                                ,L.Column5
							    ,N.Group1
							    ,N.Group2
                            FROM
                                M0012_SupplyMMTB L
                            LEFT JOIN
                                M0002_GroupName N
                            ON
                                L.NameEN = N.NameEN) L
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
                            L.PurCode = P.EF_InvtID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ItemCode", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
    }
}