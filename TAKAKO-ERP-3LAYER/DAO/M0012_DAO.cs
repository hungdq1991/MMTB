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
                            ,L.UnitMultDiv
                            ,L.CnvFact
                            ,L.Point
                            ,L.MinimumQty
                            ,L.Lifetime
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
                                ,Unit
                                ,UnitMultDiv
                                ,CnvFact
                                ,Point
                                ,MinimumQty
                                ,Lifetime
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
        //Load dữ liệu từ Solomon
        //Mã tồn kho Solomon
        public DataTable GetInfo_Solomon_WH1()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
	                        InvtID
						   ,Descr
                        FROM 
	                        [SOLOMON-SERVER].[TVCAPP].[dbo].[Inventory]
                        WHERE 
                                InvtID like 'LM1%'
                            and TranStatusCode = 'AC'";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@InvtID", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        public DataTable GetInfo_Solomon_WH2()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
	                        InvtID
						   ,Descr
                        FROM 
	                        [SOLOMON-SERVER].[TVCAPP].[dbo].[Inventory]
                        WHERE 
                                InvtID like 'LM2%'
                            and TranStatusCode = 'AC'";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@InvtID", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Mã mua hàng Solomon
        public DataTable GetInfo_Solomon_PurCode()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
                             EF_InvtID
                            ,EF_InvtName
                            ,EF_PurUnit
                            ,EF_VendID
                            ,EF_VendName
                            ,EF_PurUnit
                            ,EF_PurCuryID
                            ,UnitMultDiv
                            ,CnvFact
                        FROM 
	                        [SOLOMON-SERVER].[TVCAPP].[dbo].[xt_CPMapPrice]
                        WHERE 
                            S4Future10 = 1";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@EF_InvtID", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        public DataTable GetInfo_M0012_Update()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                                 SessionID
							    ,ItemCode
                                ,NameEN
                                ,NameVN
                                ,NameJP
                                ,Maker
                                ,Unit
                                ,UnitMultDiv
                                ,CnvFact
                                ,Point
                                ,MinimumQty
                                ,Lifetime
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
                                M0012_SupplyMMTB
                            WHERE
                                InActive = 0";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ItemCode", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Check mã trùng trên table M0012
        public DataTable GetInfo_M0012_Check(string ItemCode, string Maker, int Point, int MinimumQty, int Lifetime, string PurCode, string WH1Code, string WH2Code)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
							     ItemCode
                                ,Maker
                                ,Point
                                ,MinimumQty
                                ,Lifetime
                                ,PurCode
                                ,WH1Code
                                ,WH2Code
                            FROM
                                M0012_SupplyMMTB
                            WHERE
                                ItemCode    = @ItemCode
                            AND Maker       = @Maker
                            AND Point       = @Point
                            AND MinimumQty  = @MinimumQty
                            AND Lifetime    = @Lifetime
                            AND PurCode     = @PurCode
                            AND WH1Code     = @WH1Code
                            AND WH2Code     = @WH2Code";
            SqlParameter[] sqlParameters = new SqlParameter[8];
            sqlParameters[0] = new SqlParameter("@ItemCode", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString(ItemCode);
            sqlParameters[1] = new SqlParameter("@Maker", SqlDbType.Text);
            sqlParameters[1].Value = Convert.ToString(Maker);
            sqlParameters[2] = new SqlParameter("@Point", SqlDbType.Int);
            sqlParameters[2].Value = Convert.ToInt32(Point);
            sqlParameters[3] = new SqlParameter("@MinimumQty", SqlDbType.Int);
            sqlParameters[3].Value = Convert.ToInt32(MinimumQty);
            sqlParameters[4] = new SqlParameter("@Lifetime", SqlDbType.Int);
            sqlParameters[4].Value = Convert.ToInt32(Lifetime);
            sqlParameters[5] = new SqlParameter("@PurCode", SqlDbType.Text);
            sqlParameters[5].Value = Convert.ToString(PurCode);
            sqlParameters[6] = new SqlParameter("@WH1Code", SqlDbType.Text);
            sqlParameters[6].Value = Convert.ToString(WH1Code);
            sqlParameters[7] = new SqlParameter("@WH2Code", SqlDbType.Text);
            sqlParameters[7].Value = Convert.ToString(WH2Code);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Update M0012
        public bool Update_M0012(DataTable _listM0012)
        {
            return conn.Update_M0012(_listM0012);
        }
    }
}