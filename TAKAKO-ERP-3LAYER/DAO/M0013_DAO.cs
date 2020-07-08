using System;
using System.Data;
using System.Data.SqlClient;

namespace MMTB.DAO
{
    public class M0013_DAO
    {
        private DBConnection conn;
        /// <constructor>
        /// Constructor M0013_DAO
        /// </constructor>
        public M0013_DAO()
        {
            conn = new DBConnection();
        }
     
        /// <summary>
        /// Load thông tin Master LK, pin, dầu (lấy giá mua)
        /// </summary>
        /// <returns></returns>
        public DataTable GetInfo_M0013(string ClassifyID)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
                             L.NameEN
                            ,L.NameVN
                            ,L.NameJP
                            ,L.Maker
                            ,L.Model 
							,L.DocNo
                            ,L.DocDate
                            ,L.ClassifyID
                            ,L.ItemCode
                            ,S.NameEN as ItemNameEN
                            ,S.NameVN as ItemNameVN
                            ,L.ItemMaker
                            ,S.Unit
                            ,L.QtyNeed
                            ,L.Lifetime
                            ,L.Location
                            ,L.Point
                            ,L.Using
                            ,L.Memo
                            ,L.ApplyDate
                            ,L.InActive
                            ,L.InputUser
                            ,L.InputDate
                            ,L.ConfUser
                            ,L.ConfDate
                            ,L.Column5
							,CASE WHEN P.EF_PurCuryID IS NULL THEN '' ELSE P.EF_PurCuryID END AS EF_PurCuryID
							,CASE WHEN P.EF_PurCuryPrice IS NULL THEN 0 ELSE P.EF_PurCuryPrice END AS EF_PurCuryPrice
							,CASE WHEN P.EF_EffDate is null THEN NULL ELSE P.EF_EffDate END AS EF_EffDate
							,CASE WHEN P.EF_VendID is null THEN '' ELSE P.EF_VendID END AS EF_VendID
							,CASE WHEN P.EF_VendName is null THEN '' ELSE P.EF_VendName END AS EF_VendName
							,CASE WHEN S.PurCode is null THEN '' ELSE S.PurCode END AS PurCode
                        FROM 
	                        M0013_Master_Supply L
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
                        WHERE 
                            L.ClassifyID like @ClassifyID
                        ORDER BY L.NameEN, L.Model, L.ClassifyID, L.ItemCode";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ClassifyID", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString(ClassifyID);
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        /// <summary>
        /// Load thông tin Master LK, pin, dầu (không lấy giá mua)
        /// </summary>
        /// <returns></returns>
        public DataTable GetInfo_M0013_NoPrice(string ClassifyID)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
                             L.NameEN
                            ,L.NameVN
                            ,L.NameJP
                            ,L.Maker
                            ,L.Model 
							,L.DocNo
                            ,L.DocDate
                            ,L.ClassifyID
                            ,L.ItemCode
                            ,S.NameEN as ItemNameEN
                            ,S.NameVN as ItemNameVN
                            ,L.ItemMaker
                            ,S.Unit
                            ,L.QtyNeed
                            ,L.Lifetime
                            ,L.Location
                            ,L.Point
                            ,L.Using
                            ,L.Memo
                            ,L.ApplyDate
                            ,L.InActive
                            ,L.InputUser
                            ,L.InputDate
                            ,L.ConfUser
                            ,L.ConfDate
                            ,L.Column5
							,CASE WHEN S.PurCode is null THEN '' ELSE S.PurCode END AS PurCode
                        FROM 
	                        M0013_Master_Supply L
                        JOIN
                            M0012_SupplyMMTB S
                        ON L.ItemCode = S.ItemCode
                        WHERE 
                            L.ClassifyID like @ClassifyID
                        ORDER BY L.NameEN, L.Model, L.ClassifyID, L.ItemCode";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ClassifyID", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString(ClassifyID);
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        /// <summary>
        /// Lấy thông tin DocNo theo tên MMTB
        /// </summary>
        /// <param name="DocNo"></param>
        /// <returns></returns>
        public DataTable GetInfo_M0013_DocNo(string Program)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT DISTINCT
							 DocNo
                            ,CASE WHEN DocStatus = 0 THEN N'Chuẩn bị' ELSE N'Xác nhận' END AS DocStatus 
                            ,DocDate AS DocDate
                            ,NameEN AS NameEN 
                            ,NameVN AS NameVN
                            ,NameJP AS NameJP
                            ,Maker
                            ,Model
                            ,ClassifyID                            
                            ,ItemCode
                            ,ItemNameEN AS ItemNameEN 
                            ,ItemNameVN AS ItemNameVN
                            ,ItemNameJP AS ItemNameJP
                            ,ItemMaker
                            ,Unit
                        FROM
                        	M0013_Master_Supply
                        WHERE 
                            Program = @Program
                        ORDER BY
                            DocNo DESC";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@program", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(Program);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        /// <summary>
        /// Lấy thông tin Header của DocNo theo tên MMTB
        /// </summary>
        /// <returns></returns>
        public DataTable GetInfo_M0013_Header_Model(string DocNo)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT DISTINCT
							 S.DocNo
                            ,S.DocDate
                            ,S.DocStatus
                            ,S.Program
                            ,S.NameEN
                            ,S.NameVN
                            ,S.NameJP
							,CASE WHEN S.Maker IS NULL THEN '' ELSE S.Maker END AS Maker
							,CASE WHEN S.Model IS NULL THEN '' ELSE S.Model END AS Model
                            ,CASE WHEN S.Unit IS NULL THEN '' ELSE S.Unit END AS Unit
                            ,S.ClassifyID
                            ,D.InputUser as UserName
                            ,CASE WHEN D.ConfUser IS NULL THEN '' ELSE D.ConfUser END AS ConfUser
                        FROM
                        	M0013_Master_Supply S
						JOIN
							M0013_Master_Supply_Doc D
						ON
							S.DocNo = D.DocNo
                        WHERE 
                            S.DocNo = @DocNo";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DocNo", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(DocNo);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        /// <summary>
        /// Lấy thông tin Header của DocNo theo tên LK\Pin\Dầu
        /// </summary>
        /// <returns></returns>
        public DataTable GetInfo_M0013_Header_Item(string DocNo)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT DISTINCT
							 S.DocNo
                            ,S.DocDate
                            ,S.DocStatus
                            ,S.Program
                            ,S.ItemNameEN AS NameEN
                            ,S.ItemNameVN AS NameVN
                            ,S.ItemNameJP AS NameJP
							,CASE WHEN S.ItemMaker IS NULL THEN '' ELSE S.ItemMaker END AS Maker
                            ,S.ItemCode AS Model_Item
                            ,CASE WHEN S.Unit IS NULL THEN '' ELSE S.Unit END AS Unit
                            ,S.ClassifyID
                            ,D.InputUser as UserName
                            ,CASE WHEN D.ConfUser IS NULL THEN '' ELSE D.ConfUser END AS ConfUser
                        FROM
                        	M0013_Master_Supply S
						JOIN
							M0013_Master_Supply_Doc D
						ON
							S.DocNo = D.DocNo
                        WHERE 
                            S.DocNo = @DocNo";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DocNo", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(DocNo);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        /// <summary>
        /// Lấy thông tin chi tiết của DocNo
        /// </summary>
        /// <param name="DocNo"></param>
        /// <returns></returns>
        public DataTable GetInfo_M0013_Detail(string DocNo)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
                             DocNo
                            ,NameEN
                            ,NameVN
                            ,NameJP
                            ,Maker
                            ,Model
                            ,ClassifyID
                            ,ItemCode
                            ,ItemNameEN
                            ,ItemNameVN
                            ,ItemNameJP
                            ,ItemMaker
                            ,Unit
                            ,QtyNeed
                            ,Lifetime
                            ,Point
                            ,Location
                            ,Using
                            ,Memo
                            ,ApplyDate
                            ,InActive
                            ,InActiveDate
                            ,InActiveUser
                        FROM
                        	M0013_Master_Supply 
                        WHERE 
                            DocNo = @DocNo
                        ORDER BY 
                            ClassifyID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DocNo", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(DocNo);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        /// <summary>
        /// Lấy thông tin chi tiết của MMTB theo Model
        /// </summary>
        /// <param name="DocNo"></param>
        /// <returns></returns>
        public DataTable GetInfo_M0013_Detail_Model(string NameEN, string Maker, string Model)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                             DocNo
                            ,NameEN
                            ,NameVN
                            ,NameJP
                            ,Maker
                            ,Model
                            ,ClassifyID
                            ,ItemCode
                            ,ItemNameEN
                            ,ItemNameVN
                            ,ItemNameJP
                            ,ItemMaker
                            ,Unit
                            ,QtyNeed
                            ,Lifetime
                            ,Point
                            ,Location
                            ,Using
                            ,Memo
                            ,ApplyDate
                            ,InActive
                            ,InActiveDate
                            ,InActiveUser
                        FROM
                        	M0013_Master_Supply 
                        WHERE 
                            NameEN = @NameEN
                        AND Maker = @Maker
                        AND Model = @Model
                        AND InActive = 0
                        ORDER BY 
                            ClassifyID";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@NameEN", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(NameEN);
            sqlParameters[1] = new SqlParameter("@Maker", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(Maker);
            sqlParameters[2] = new SqlParameter("@Model", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(Model);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        /// <summary>
        /// Lấy thông tin chi tiết của MMTB theo Item
        /// </summary>
        /// <param name="DocNo"></param>
        /// <returns></returns>
        public DataTable GetInfo_M0013_Detail_Item(string ItemCode)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                             DocNo
                            ,NameEN
                            ,NameVN
                            ,NameJP
                            ,Maker
                            ,Model
                            ,ClassifyID
                            ,ItemCode
                            ,ItemNameEN
                            ,ItemNameVN
                            ,ItemNameJP
                            ,ItemMaker
                            ,Unit
                            ,QtyNeed
                            ,Lifetime
                            ,Point
                            ,Location
                            ,Using
                            ,Memo
                            ,ApplyDate
                            ,InActive
                            ,InActiveDate
                            ,InActiveUser
                        FROM
                        	M0013_Master_Supply 
                        WHERE 
                            ItemCode = @ItemCode
                        AND InActive = 0
                        ORDER BY 
                            ClassifyID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ItemCode", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(ItemCode);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        /// <summary>
        /// Lấy thông tin MMTB đang nhập chưa xác nhận
        /// </summary>
        /// <param name="NameEN"></param>
        /// <returns></returns>
        public DataTable GetInfo_M0013_Model(string NameEN, string Maker, string Model)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                             NameEN
                            ,Maker
                            ,Model_Item
                        FROM
                        	M0013_Master_Supply_Doc 
                        WHERE 
                            NameEN = @NameEN
                        AND Maker = @Maker
                        AND Model_Item = @Model
                        AND DocStatus = 0";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@NameEN", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(NameEN);
            sqlParameters[1] = new SqlParameter("@Maker", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(Maker);
            sqlParameters[2] = new SqlParameter("@Model", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(Model);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        /// <summary>
        /// Lấy thông tin ItemCode đang nhập chưa xác nhận
        /// </summary>
        /// <param name="NameEN"></param>
        /// <returns></returns>
        public DataTable GetInfo_M0013_Item(string ItemCode)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                            Model_Item
                        FROM
                        	M0013_Master_Supply_Doc 
                        WHERE 
                            Model_Item = @ItemCode
                        AND DocStatus = 0";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ItemCode", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(ItemCode);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        /// <summary>
        /// Kiểm tra thông tin master trùng
        /// </summary>
        /// <param name="NameEN"></param>
        /// <returns></returns>
        public DataTable GetInfo_M0013_Check(string NameEN, string Maker, string Model, string ItemCode, int QtyNeed, int Lifetime, int Point)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                             NameEN
                            ,Maker
                            ,Model
                            ,ItemCode
                            ,QtyNeed
                            ,Lifetime
                            ,Point
                        FROM
                        	M0013_Master_Supply 
                        WHERE 
                            NameEN      = @NameEN
                        AND Maker       = @Maker
                        AND Model       = @Model
                        AND ItemCode    = @ItemCode
                        AND QtyNeed     = @QtyNeed
                        AND Lifetime    = @Lifetime
                        AND Point       = @Point";
            SqlParameter[] sqlParameters = new SqlParameter[7];
            sqlParameters[0] = new SqlParameter("@NameEN", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(NameEN);
            sqlParameters[1] = new SqlParameter("@Maker", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(Maker);
            sqlParameters[2] = new SqlParameter("@Model", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(Model);
            sqlParameters[3] = new SqlParameter("@ItemCode", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(ItemCode);
            sqlParameters[4] = new SqlParameter("@QtyNeed", SqlDbType.Int);
            sqlParameters[4].Value = Convert.ToInt32(QtyNeed);
            sqlParameters[5] = new SqlParameter("@Lifetime", SqlDbType.Int);
            sqlParameters[5].Value = Convert.ToInt32(Lifetime);
            sqlParameters[6] = new SqlParameter("@Point", SqlDbType.Int);
            sqlParameters[6].Value = Convert.ToInt32(Point);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Thông tin Master theo model MMTB
        public string Insert_Master_ByModel(DataTable _listSummary, DataTable _listDelete, DataTable _listSummaryDoc)
        {
            return conn.Insert_Master_ByModel(_listSummary, _listDelete, _listSummaryDoc);
        }
        //Xác nhận Master theo model MMTB
        public bool Confirm_Master_ByModel(DataTable _listSummary, DataTable _listDelete, DataTable _listSummaryDoc)
        {
            return conn.Confirm_Master_ByModel(_listSummary, _listDelete, _listSummaryDoc);
        }
        //Nhập và xác nhận Master theo model MMTB
        public string Insert_Confirm_Master_ByModel(DataTable _listSummary, DataTable _listSummaryDoc)
        {
            return conn.Insert_Confirm_Master_ByModel(_listSummary, _listSummaryDoc);
        }
        //Thông tin Master theo mã LK/pin/dầu
        public string Insert_Master_ByItem(DataTable _listSummary, DataTable _listDelete, DataTable _listSummaryDoc)
        {
            return conn.Insert_Master_ByItem(_listSummary, _listDelete, _listSummaryDoc);
        }
        //Xác nhận Master theo mã LK/pin/dầu
        public bool Confirm_Master_ByItem(DataTable _listSummary, DataTable _listDelete, DataTable _listSummaryDoc)
        {
            return conn.Confirm_Master_ByItem(_listSummary, _listDelete, _listSummaryDoc);
        }
        //Nhập và xác nhận Master theo mã LK/pin/dầu
        public string Insert_Confirm_Master_ByItem(DataTable _listSummary, DataTable _listSummaryDoc)
        {
            return conn.Insert_Confirm_Master_ByItem(_listSummary, _listSummaryDoc);
        }

        /// <summary>
        /// Liên quan nghiệp vụ xác định mã LK/Pin/Dầu thay thế
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        ///Load dữ liệu từ M0013_Master_Supply_Replace
        public DataTable GetInfo_M0013_Replace()
        {
            string StrQuery = "";
        DataTable _tempDataTable = new DataTable();

        StrQuery = @"SELECT 
                           ClassifyID
                          ,ItemCode
                          ,NameEN
                          ,NameVN
                          ,NameJP
                          ,Maker
                          ,Unit
                          ,ItemCodeRe
                          ,NameENRe
                          ,NameVNRe
                          ,NameJPRe
                          ,MakerRe
                          ,UnitRe
                          ,Memo
                          ,ApplyDate
                          ,InActive
                          ,InActiveDate
                          ,InActiveUser
                        FROM 
	                        M0013_Master_Supply_Replace L
                        ORDER BY L.ClassifyID, L.ItemCode";
            SqlParameter[] sqlParameters = new SqlParameter[1];
        sqlParameters[0] = new SqlParameter("@ItemCode", SqlDbType.Text);
        sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        /// <summary>
        /// Check mã trùng trong M0013_Master_Supply_Replace
        /// </summary>
        /// <param name="NameEN"></param>
        /// <param name="Maker"></param>
        /// <param name="Model"></param>
        /// <param name="ItemCode"></param>
        /// <param name="QtyNeed"></param>
        /// <param name="Lifetime"></param>
        /// <param name="Point"></param>
        /// <returns></returns>
        public DataTable GetInfo_M0013_CheckReplace(string ItemCode, string Maker, string ItemCodeRe, string MakerRe)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                             ItemCode
                            ,Maker
                            ,ItemCodeRe
                            ,MakerRe
                        FROM
                        	M0013_Master_Supply_Replace 
                        WHERE 
                            ItemCode        = @ItemCode
                        AND Maker           = @Maker
                        AND ItemCodeRe      = @ItemCodeRe
                        AND MakerRe         = @MakerRe";

            SqlParameter[] sqlParameters = new SqlParameter[4];

            sqlParameters[0] = new SqlParameter("@ItemCode", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(ItemCode);
            sqlParameters[1] = new SqlParameter("@Maker", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(Maker);
            sqlParameters[2] = new SqlParameter("@ItemCodeRe", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(ItemCodeRe);
            sqlParameters[3] = new SqlParameter("@MakerRe", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(MakerRe);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
    }
}
