using System;
using System.Data;
using System.Data.SqlClient;

namespace MMTB.DAO
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
        public DataTable GetInfo_M0012(int InActive)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
							 L.ItemCode
                            ,L.NameEN
                            ,L.NameVN
                            ,L.NameJP
                            ,CASE 
                                WHEN L.ClassifyID = 1 THEN 'LK'
                                WHEN L.ClassifyID = 4 THEN 'Pin'
                                WHEN L.ClassifyID = 5 THEN N'Dầu'
                             END AS  ClassifyID
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
							,CASE
                                WHEN P.EF_PurCuryID IS NULL THEN ''
                                ELSE P.EF_PurCuryID
                            END AS Cury
							,CASE
                                WHEN P.EF_PurCuryPrice IS NULL THEN 0
                                ELSE P.EF_PurCuryPrice
                            END AS Price
							,CASE
                                WHEN P.EF_EffDate is NULL THEN NULL
                                ELSE P.EF_EffDate
                            END AS EffDate
							,CASE
                                WHEN P.EF_VendID is NULL THEN ''
                                ELSE P.EF_VendID
                            END AS EF_VendID
							,CASE
                                WHEN P.EF_VendName is NULL
                                THEN '' ELSE P.EF_VendName
                            END AS EF_VendName
						FROM (SELECT 
	                             ItemCode
                                ,L.NameEN
                                ,L.NameVN
                                ,L.NameJP
                                ,L.ClassifyID
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
                                L.NameEN = N.NameEN
                            ) L
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
                                FROM
                                    [SOLOMON-SERVER].[TVCAPP].[dbo].[xt_CPMapPrice] 
                                GROUP BY
                                    EF_InvtID
                                ) D
                            ON P.EF_InvtID      = D.EF_InvtID 
                            AND P.EF_EffDate    = D.EF_EffDate
                            WHERE P.S4Future10  = 1
                            ) P
                        ON
                            L.PurCode           = P.EF_InvtID
                        WHERE
                            L.InActive          = @InActive
                        ORDER BY
                             L.ClassifyID
                            ,L.ItemCode";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@InActive", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(InActive);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Load dữ liệu trên form xem thông tin tồn kho
      //  public DataTable GetInfo_M0012_Stock(int InActive)
      //  {
      //      string StrQuery = "";
      //      DataTable _tempDataTable = new DataTable();

      //      StrQuery = @"SELECT
						//	 L.ItemCode
      //                      ,L.NameEN
      //                      ,L.NameVN
      //                      ,L.NameJP
      //                      ,CASE 
      //                          WHEN L.ClassifyID = 1 THEN 'LK'
      //                          WHEN L.ClassifyID = 4 THEN 'Pin'
      //                          WHEN L.ClassifyID = 5 THEN N'Dầu'
      //                       END AS  ClassifyID
      //                      ,L.Maker
      //                      ,L.Unit
      //                      ,L.Point
      //                      ,L.MinimumQty
      //                      ,L.Lifetime
      //                      ,L.PurCode
      //                      ,L.WH1Code
      //                      ,L.WH2Code
      //                      ,L.ApplyDate
      //                      ,L.InActive
      //                      ,L.Memo
						//	,L.Group1
						//	,L.Group2
						//FROM 
      //                      M0012_SupplyMMTB
      //                  LEFT JOIN
      //                      [SOLOMON-SERVER].[TVCAPP].[dbo].[xt_CPMapPrice]
      //                  ORDER BY
      //                       L.ClassifyID
      //                      ,L.ItemCode";
      //      SqlParameter[] sqlParameters = new SqlParameter[1];
      //      sqlParameters[0] = new SqlParameter("@InActive", SqlDbType.Int);
      //      sqlParameters[0].Value = Convert.ToInt32(InActive);

      //      return conn.executeSelectQuery(StrQuery, sqlParameters);
      //  }
        //Lấy thông tin các mã hàng trùng
        public DataTable GetInfo_M0012_Dup()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
							 L.ItemCode
                            ,L.NameEN
                            ,L.NameVN
                            ,L.NameJP
                            ,L.ClassifyID
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
							,CASE
                                WHEN P.EF_PurCuryID IS NULL THEN ''
                                ELSE P.EF_PurCuryID
                            END AS Cury
							,CASE
                                WHEN P.EF_PurCuryPrice IS NULL THEN 0
                                ELSE P.EF_PurCuryPrice
                            END AS Price
							,CASE
                                WHEN P.EF_EffDate is null THEN NULL
                                ELSE P.EF_EffDate
                            END AS EffDate
							,CASE
                                WHEN P.EF_VendID is null THEN ''
                                ELSE P.EF_VendID
                            END AS EF_VendID
							,CASE
                                WHEN P.EF_VendName is null THEN ''
                                ELSE P.EF_VendName
                            END AS EF_VendName
						FROM (SELECT 
	                             ItemCode
                                ,L.NameEN
                                ,L.NameVN
                                ,L.NameJP
                                ,L.ClassifyID
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
                                L.NameEN = N.NameEN
                            ) L
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
                                FROM
                                    [SOLOMON-SERVER].[TVCAPP].[dbo].[xt_CPMapPrice] 
                                GROUP BY
                                    EF_InvtID
                                ) D
                            ON  P.EF_InvtID     = D.EF_InvtID 
                            AND P.EF_EffDate    = D.EF_EffDate
                            WHERE P.S4Future10  = 1
                        ) P
                        ON  L.PurCode = P.EF_InvtID
					JOIN
                        (SELECT
                             ItemCode
                            ,COUNT(ItemCode) as CountItem
                        FROM
                            M0012_SupplyMMTB
                        GROUP BY
                            ItemCode
                        HAVING COUNT
                            (ItemCode) > 1
                        ) C
					ON  L.ItemCode  = C.ItemCode
                    ORDER BY
                        L.ItemCode";
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
                            InvtID          like 'LM1%'
                        AND TranStatusCode  =   'AC'";
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
                            InvtID          like 'LM2%'
                        AND TranStatusCode  = 'AC'";
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
                                 L.ClassifyID
								,L3.ClassifyDesc
							    ,L.ItemCode
                                ,NameEN
                                ,NameVN
                                ,NameJP
                                ,L.Maker
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
                                M0012_SupplyMMTB L
                            JOIN
                                (SELECT 
                                     L1.ItemCode
                                    ,L1.Maker
                                    ,L1.ApplyDate
                                FROM
                                    M0012_SupplyMMTB L1
                                JOIN
                                    (SELECT 
                                         ItemCode
                                        ,Maker
                                        ,Max(ApplyDate) as ApplyDate
                                    FROM
                                        M0012_SupplyMMTB
                                    GROUP BY
										 ItemCode
                                        ,Maker
                                    ) L2
                                ON
                                    L1.ItemCode     = L2.ItemCode
								AND	L1.ApplyDate    = L2.ApplyDate
                                ) L1
                            ON
                                L.ItemCode          = L1.ItemCode
                            AND L.ApplyDate         = L1.ApplyDate
                            LEFT JOIN 
                                    (SELECT 
                                         ClassifyID
                                        ,ClassifyDesc
                                     FROM
                                        M01_Classify) L3
                            ON L.ClassifyID = L3.ClassifyID
                            ORDER BY L3.ClassifyDesc, L.NameEN, L.ItemCode";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ItemCode", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }

        //Check mã trùng trên table M0012
        public DataTable GetInfo_M0012_Check(string ItemCode
                                            ,string Maker
                                            ,int Point
                                            ,int MinimumQty
                                            ,int Lifetime)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                             ItemCode
                            ,Maker
                            ,Point
                            ,MinimumQty
                            ,Lifetime
                        FROM
                            M0012_SupplyMMTB
                        WHERE
                            ItemCode    = @ItemCode
                        AND Maker       = @Maker
                        AND Point       = @Point
                        AND MinimumQty  = @MinimumQty
                        AND Lifetime    = @Lifetime";

            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@ItemCode", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(ItemCode);
            sqlParameters[1] = new SqlParameter("@Maker", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(Maker);
            sqlParameters[2] = new SqlParameter("@Point", SqlDbType.Int);
            sqlParameters[2].Value = Convert.ToInt32(Point);
            sqlParameters[3] = new SqlParameter("@MinimumQty", SqlDbType.Int);
            sqlParameters[3].Value = Convert.ToInt32(MinimumQty);
            sqlParameters[4] = new SqlParameter("@Lifetime", SqlDbType.Int);
            sqlParameters[4].Value = Convert.ToInt32(Lifetime);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Update M0012
        public bool Insert_Supply_MMTB(DataTable _listM0012)
        {
            return conn.Insert_Supply_MMTB(_listM0012);
        }
        //Lấy thông tin mã LK thay thế
        public DataTable GetInfo_M0012_ItemCodeRe(string NameEN)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                                 L.ClassifyID
								,L3.ClassifyDesc
							    ,L.ItemCode
                                ,NameEN
                                ,NameVN
                                ,NameJP
                                ,Maker
                                ,Unit
                            FROM
                                M0012_SupplyMMTB L
                            LEFT JOIN 
                                    (SELECT 
                                         ClassifyID
                                        ,ClassifyDesc
                                     FROM
                                        M01_Classify) L3
                            ON L.ClassifyID = L3.ClassifyID
                            WHERE 
                                L.NameEN        = @NameEN
                            ORDER BY L3.ClassifyDesc, L.NameEN, L.ItemCode";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@NameEN", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString(NameEN);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
    }
}