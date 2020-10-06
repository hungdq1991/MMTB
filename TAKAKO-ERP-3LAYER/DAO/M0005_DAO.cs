using System;
using System.Data;
using System.Data.SqlClient;

namespace MMTB.DAO
{
    public class M0005_DAO
    {
        private DBConnection conn;
        /// <constructor>
        /// Constructor M0005_DAO
        /// </constructor>
        public M0005_DAO()
        {
            conn = new DBConnection();
        }

        //Lấy thông tin trên gridControl
        public DataTable GetInfo_M0005()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	 L.Code
                        	,ACCcode
                        	,L.NameEN
                        	,L.NameVN
                        	,L.NameJP
                        	,Maker
                        	,Model
                        	,Series
                        	,OrgCountry
                        	,ProDate
                        	,Lifetime
                        	,StartDeprDate
                        	,EndDeprDate
                        	,Status
                        	,Result
                        	,Memo
                        	,InstDoc
                        	,ACCDoc
                        	,DocNo_Disposal
                        	,ACCDoc_Disposal
                        	,DisposalDate
                            ,DisposalMemo
                        	,DocNo
                        	,DocDate
                        	,EF_VendID
                        	,SupplierID
                        	,SupplierName
                        	,InvNo
                        	,InvDate
                        	,ReceiptDate
                        	,ConfirmDate
                        	,ControlDept
                         	,DisposalStatus
                        	,L.ConfUser
                        	,L.ConfDate
                        	,L.Column4
                        	,L.Column5
                            ,N.Group1
                            ,N.Group2
							,L1.DesProcessCode
							,L1.DesLineCode
							,L1.DesLineEN
							,L1.DesGroupLineACC
							,L1.DesUsingDept 
                            ,L.InputUser
                        FROM
                        	M0005_ListMMTB L
                        LEFT JOIN 
                            M0002_GroupName N
                        ON 
                            L.NameEN = N.NameEN
						LEFT JOIN
							(SELECT
								 L1.Code
								,L1.DesProcessCode
								,L1.DesLineCode
								,L1.DesLineEN
								,L1.DesGroupLineACC
								,L1.DesUsingDept
							FROM M0005_ListMMTBLine L1 
							JOIN (SELECT 
									 Code
									,Max(ApplyDate) as ApplyDate
								  FROM
                                    M0005_ListMMTBLine 
								  GROUP BY
                                    Code
                                ) L2 
							ON  L1.Code         = L2.Code 
                            AND L1.ApplyDate    = L2.ApplyDate) L1
						ON  L.Code              = L1.Code
                        WHERE L.DocNo_Disposal is null
                        ORDER BY L.Code";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Code", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy thông tin trên gridControl_ACC bổ sung thông tin
        public DataTable GetInfo_M0005_ACC()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	 L.Code
                        	,ACCcode
                        	,L.NameEN
                        	,L.NameVN
                        	,L.NameJP
                        	,Maker
                        	,Model
                        	,Series
                        	,OrgCountry
                        	,ProDate
                        	,Lifetime
                        	,StartDeprDate
                        	,EndDeprDate
                        	,Status
                        	,Result
                        	,Memo
                        	,InstDoc
                        	,ACCDoc
                        	,DocNo_Disposal
                        	,ACCDoc_Disposal
                        	,DisposalDate
                            ,DisposalMemo
                        	,DocNo
                        	,DocDate
                        	,EF_VendID
                        	,SupplierID
                        	,SupplierName
                        	,InvNo
                        	,InvDate
                        	,ReceiptDate
                        	,ConfirmDate
                        	,ControlDept
                         	,DisposalStatus
                        	,L.ConfUser
                        	,L.ConfDate
                        	,L.Column4
                        	,L.Column5
                            ,N.Group1
                            ,N.Group2
							,L1.DesProcessCode
							,L1.DesLineCode
							,L1.DesLineEN
							,L1.DesGroupLineACC
							,L1.DesUsingDept 
                            ,L.InputUser
                        FROM
                        	M0005_ListMMTB L
                        LEFT JOIN 
                            M0002_GroupName N
                        ON 
                            L.NameEN = N.NameEN
						LEFT JOIN
							(SELECT
								 L1.Code
								,L1.DesProcessCode
								,L1.DesLineCode
								,L1.DesLineEN
								,L1.DesGroupLineACC
								,L1.DesUsingDept
							FROM M0005_ListMMTBLine L1 
							JOIN (SELECT 
									 Code
									,Max(ApplyDate) as ApplyDate
								  FROM
                                    M0005_ListMMTBLine 
								  GROUP BY
                                    Code
                                ) L2 
							ON  L1.Code         = L2.Code 
                            AND L1.ApplyDate    = L2.ApplyDate) L1
						ON  L.Code              = L1.Code
                        ORDER BY L.Code";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Code", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy thông tin trên gridControl để lọc thông tin
        public DataTable GetInfo_M0005_Filter()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	 L.Code
                        	,ACCcode
                        	,L.NameEN
                        	,L.NameVN
                        	,L.NameJP
                        	,Maker
                        	,Model
                        	,Series
                        	,OrgCountry
                        	,ProDate
                        	,Lifetime
                        	,StartDeprDate
                        	,EndDeprDate
                        	,Status
                        	,Result
                        	,Memo
                        	,InstDoc
                        	,ACCDoc
                        	,DocNo_Disposal
                        	,ACCDoc_Disposal
                        	,DisposalDate
                            ,DisposalMemo
                        	,DocNo
                        	,DocDate
                        	,EF_VendID
                        	,SupplierID
                        	,SupplierName
                        	,InvNo
                        	,InvDate
                        	,ReceiptDate
                        	,ConfirmDate
                        	,ControlDept
                         	,DisposalStatus
                        	,L.ConfUser
                        	,L.ConfDate
                        	,L.Column4
                        	,L.Column5
                            ,N.Group1
                            ,N.Group2
							,L1.DesProcessCode
							,L1.DesLineCode
							,L1.DesLineEN
							,L1.DesGroupLineACC
							,L1.DesUsingDept 
                        FROM
                        	M0005_ListMMTB L
                         JOIN 
                            M0002_GroupName N
                        ON 
                            L.NameEN = N.NameEN
						LEFT JOIN
							(SELECT
								 L1.Code
								,L1.DesProcessCode
								,L1.DesLineCode
								,L1.DesLineEN
								,L1.DesGroupLineACC
								,L1.DesUsingDept 
							FROM M0005_ListMMTBLine L1 
							JOIN (SELECT 
									 Code
									,Max(ApplyDate) as ApplyDate
								  FROM M0005_ListMMTBLine 
								  GROUP BY Code) L2 
							ON		L1.Code = L2.Code 
								AND L1.ApplyDate = L2.ApplyDate) L1
						ON
							L.Code = L1.Code
                        ORDER BY L.Code";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Code", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy dữ liệu số chứng từ trên Form_M0005_Detail_NT
        public DataTable GetInfo_M0005_DocNT()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"	SELECT 
		                         DISTINCT 
                                 DocNo
		                        ,DocDate
		                        ,EF_VendID
                                ,SupplierID
		                        ,SupplierName
		                        ,InvNo
		                        ,InvDate
		                        ,ReceiptDate
		                        ,ConfirmDate
		                        ,ControlDept
	                        FROM 
		                        M0005_ListMMTBDoc1
                            ORDER BY
                                DocNo DESC";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DocNo", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }

        //Lấy dữ liệu lên Form_M0005_Detail_NT khi có số chứng từ
        public DataTable GetInfo_M0005_NT_Header(string DocNo)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();
            StrQuery = @"SELECT 
                             DocNo
                            ,DocDate
                            ,EF_VendID
                            ,SupplierID
                            ,SupplierName
                            ,InvNo
                            ,InvDate
                            ,ReceiptDate
                            ,ConfirmDate
                            ,ControlDept
                            ,DocStatus
                            ,InputUser
                            ,ConfUser
                            ,ConfDate
                            ,Column3
                            ,Column4
                            ,Column5
                        FROM 
                            M0005_ListMMTBDoc1
                        WHERE 
                            DocNo = @DocNo";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DocNo", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(DocNo);
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }

        //Lấy dữ liệu lên Form_M0005_Detail_NT khi có số chứng từ
        public DataTable GetInfo_M0005_NT_Detail(string DocNo)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
			                 M.Code
		                    ,M.ACCcode
		                    ,M.NameEN
		                    ,M.NameVN
		                    ,M.NameJP
		                    ,M.Maker
		                    ,M.Model
		                    ,M.Series
		                    ,M.OrgCountry
		                    ,M.ProDate
		                    ,M.Lifetime
		                    ,M.StartDeprDate
		                    ,M.EndDeprDate
		                    ,L.OrgProcessCode
		                    ,L.OrgLineCode
		                    ,L.OrgLineEN
		                    ,L.OrgGroupLineACC
		                    ,L.OrgUsingDept
		                    ,M.Result
		                    ,M.Status
		                    ,M.Memo
                            ,M.InstDoc
                            ,M.DocNo
                            ,M.InputUser
	                    FROM 
		                    M0005_ListMMTB M
	                    LEFT JOIN
		                    (SELECT 
                                 DocNo_Confirm
                                ,Code
                                ,ACCCode
			                    ,OrgProcessCode
			                    ,OrgLineCode
                                ,OrgLineEN
			                    ,OrgGroupLineACC
			                    ,OrgUsingDept
			                    ,MIN(ApplyDate) ApplyDate
		                    FROM 
			                    M0005_ListMMTBLine
                            WHERE 
                                DocNo_Confirm = @DocNo
		                    GROUP BY
			                     DocNo_Confirm
                                ,Code
                                ,ACCCode
			                    ,OrgProcessCode
			                    ,OrgLineCode
			                    ,OrgGroupLineACC
			                    ,OrgUsingDept
			                    ,OrgLineEN) L
	                    ON
	                        M.DocNo     =   L.DocNo_Confirm
                        AND M.Code      =   L.Code
                        WHERE 
                            M.DocNo     =   @DocNo
                        ORDER BY
                            Code";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DocNo", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(DocNo);
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy mã NCC từ Solomon
        public DataTable GetInfo_VendorSolomon()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
	                         RTRIM(EF_VendID) AS EF_VendID
                            ,[VendID]
                            ,[VendName]
                        FROM 
	                        [SOLOMON-SERVER].[TVCAPP].[dbo].[xt_CPMapVend]
                        WHERE 
                            VendID <> ''";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@EF_VendID", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy mã NCC từ Solomon, điền tên NCC
        public DataTable GetInfo_VendorName(string EF_VendID)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                             [VendID]
                            ,[VendName]
                        FROM 
	                        [SOLOMON-SERVER].[TVCAPP].[dbo].[xt_CPMapVend]
                        WHERE 
                            EF_VendID like @EF_VendID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@EF_VendID", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(EF_VendID);
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //NCC cũ không có trong table xt_CPMapVend_Solomon
        public DataTable GetInfo_VendorName1(string EF_VendID)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                              [EF_VendID]
                             ,[SupplierID]
                             ,[SupplierName]
                        FROM 
	                        M0005_ListMMTBDoc1
                        WHERE 
                            EF_VendID like @EF_VendID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@EF_VendID", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(EF_VendID);
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy thông tin bộ phận
        public DataTable GetInfo_ControlDept()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                             RTRIM([SectionID])   As SectionID
                            ,[SectionName]
                        FROM
                            [SOLOMON-SERVER].[TVCAPP].[dbo].[xt_XFASection]";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Dept", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Check mã TS đã có
        public DataTable GetInfo_M0005_Check(string Code)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                             Code
                        FROM 
                             M0005_ListMMTB
                        WHERE 
                            Code = @Code";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Code", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(Code);
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Check mã TS ACC đã có
        public DataTable GetInfo_M0005_CheckACC(string ACCcode)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                             ACCcode
                        FROM 
                             M0005_ListMMTB
                        WHERE 
                            ACCcode = @ACCcode";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ACCcode", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(ACCcode);
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }

        //Insert info MMTB
        public string Insert_MMTB(DataTable listMMTB, DataTable _listDelete, DataTable listMMTBDoc1)
        {
            return conn.Insert_MMTB(listMMTB, _listDelete , listMMTBDoc1);
        }
        //Update info MMTB
        public bool Confirm_MMTB(DataTable listMMTB, DataTable listMMTBDoc1)
        {
            return conn.Confirm_MMTB(listMMTB, listMMTBDoc1);
        }
        //Insert & Update info MMTB
        public string Insert_Confirm_MMTB(DataTable listMMTB, DataTable listMMTBDoc1)
        {
            return conn.Insert_Confirm_MMTB(listMMTB, listMMTBDoc1);
        }
        #region Thanh lý MMTB
        //Lấy list MMTB chưa thanh lý
        public DataTable GetInfo_MMTB()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	 M.Code
		                    ,M.ACCcode
		                    ,M.NameEN
		                    ,M.NameVN
		                    ,M.NameJP
		                    ,M.Maker
		                    ,M.Model
		                    ,M.Series
		                    ,M.OrgCountry
		                    ,M.ProDate
		                    ,M.Lifetime
		                    ,M.StartDeprDate
		                    ,M.EndDeprDate
                            ,CASE when S.NetValue is null then 0 else CONVERT(decimal(16,4),S.NetValue) end as NetValue_Disposal
		                    ,L.DesProcessCode
		                    ,L.DesLineCode
		                    ,L.DesLineEN
		                    ,L.DesGroupLineACC
		                    ,L.DesUsingDept
                            ,M.DisposalDate            
		                    ,M.DisposalMemo
                            ,M.DisposalStatus
                            ,M.DocNo_Disposal
                            ,M.ControlDept
	                    FROM 
						    (SELECT *
						        FROM M0005_ListMMTB 
                                WHERE Code NOT IN 
                                (SELECT CODE FROM M0005_ListMMTBDisposal_Temp)) M
	                    LEFT JOIN
		                    (SELECT 
                                 L1.Code
                                ,ACCCode
			                    ,DesProcessCode
			                    ,DesLineCode
                                ,DesLineEN
			                    ,DesGroupLineACC
			                    ,DesUsingDept
		                    FROM 
			                    M0005_ListMMTBLine L1 
							JOIN
								(SELECT 
                                 Code
			                    ,MAX(ApplyDate) ApplyDate
		                    FROM 
			                    M0005_ListMMTBLine
		                    GROUP BY
                                 Code
							) L2 
							ON
								L1.Code = L2.Code
								AND L1.ApplyDate = L2.ApplyDate
							) L
	                    ON
                                M.Code         =   L.Code
                        LEFT JOIN
                            (SELECT 
                                     S1.AssetID
                                    ,S1.BookValue as NetValue
                                FROM
                                    [SOLOMON-SERVER].[TVCAPP].[dbo].[xt_XFAHist] S1
                            JOIN 
                                (SELECT
                                     AssetID
                                    ,MAX(Crtd_DateTime) as Crtd_DateTime
                                FROM
                                    [SOLOMON-SERVER].[TVCAPP].[dbo].[xt_XFAHist]
                                GROUP BY
                                    AssetID) S2
                            ON      S1.AssetID = S2.AssetID
                                AND S1.Crtd_DateTime = S2.Crtd_DateTime) S
                        ON 
                            M.ACCcode = S.AssetID
                        WHERE  M.DocNo_Disposal = '' 
                            OR M.DocNo_Disposal IS NULL";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Code", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy dữ liệu số chứng từ trên Form_M0005_Detail_TL
        public DataTable GetInfo_M0005_DocTL()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT DISTINCT 
                             DocNo
                            ,DocDate
                            ,DisposalDate
                            ,CASE
                                WHEN EF_VendID is null THEN ''
                                ELSE RTRIM(EF_VendID)
                            END AS EF_VendID
                            ,ISNULL(SupplierID,'') As SupplierID
                            ,ISNULL(SupplierName,'') As SupplierName
                            ,ISNULL(InvNo,'') As InvNo
	                     FROM 
		                     M0005_ListMMTBDoc2
                         ORDER BY
                            DocNo DESC";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DocNo", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy dữ liệu lên Form_M0005_Detail_TL khi có số chứng từ
        public DataTable GetInfo_M0005_TL_Header(string DocNo)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();
            StrQuery = @"SELECT 
                             DocNo
                            ,DocDate
		                    ,CASE
                                WHEN EF_VendID is null then ''
                                ELSE RTRIM(EF_VendID)
                            END AS EF_VendID
                            ,ISNULL(SupplierID,'') As SupplierID
		                    ,ISNULL(SupplierName,'') As SupplierName
		                    ,CASE
                                WHEN InvNo is null then ''
                                ELSE InvNo
                            END AS InvNo
                            ,ISNULL(InvDate,convert(DateTime,'')) as InvDate
                            ,DisposalDate
                            ,ControlDept
                            ,DocStatus
                            ,Memo
                            ,InputUser
                            ,ConfUser
                            ,ConfDate
                            ,Column4
                            ,Column5
                        FROM 
                            M0005_ListMMTBDoc2
                        WHERE 
                            DocNo = @DocNo";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DocNo", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(DocNo);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy dữ liệu lên Form_M0005_Detail_TL khi có số chứng từ
        //Trường hợp đã xác nhận chứng từ thanh lý
        public DataTable GetInfo_M0005_TL_Detail(string DocNo)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
			                 M.Code
		                    ,M.ACCcode
		                    ,M.NameEN
		                    ,M.NameVN
		                    ,M.NameJP
		                    ,M.Maker
		                    ,M.Model
		                    ,M.Series
		                    ,M.OrgCountry
		                    ,M.ProDate
		                    ,M.Lifetime
		                    ,M.StartDeprDate
		                    ,M.EndDeprDate
                            ,M.NetValue_Disposal
                            ,L.DesProcessCode
		                    ,L.DesLineCode
		                    ,L.DesLineEN
		                    ,L.DesGroupLineACC
		                    ,L.DesUsingDept
                            ,M.DisposalDate
                            ,M.DisposalMemo
                            ,M.DisposalStatus
                            ,M.DocNo_Disposal
		                    ,M.ControlDept
                            ,M.InputUser
	                    FROM 
		                    M0005_ListMMTB M
	                    LEFT JOIN
		                    (SELECT 
                                 L1.Code
                                ,ACCCode
			                    ,DesProcessCode
			                    ,DesLineCode
                                ,DesLineEN
			                    ,DesGroupLineACC
			                    ,DesUsingDept
		                    FROM 
			                    M0005_ListMMTBLine L1 
							JOIN
								(SELECT 
                                 Code
			                    ,MAX(ApplyDate) ApplyDate
		                    FROM 
			                    M0005_ListMMTBLine
		                    GROUP BY
                                Code
							) L2 
							ON
								L1.Code = L2.Code
								AND L1.ApplyDate = L2.ApplyDate
							) L	                    
	                    ON
                            M.Code              =   L.Code
                        WHERE 
                            M.DocNo_Disposal    =   @DocNo";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DocNo", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(DocNo);
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Trường hợp chưa xác nhận chứng từ thanh lý
        public DataTable GetInfo_M0005_TL_Detail_Temp(string DocNo)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
			                 M.Code
		                    ,M.ACCcode
		                    ,M.NameEN
		                    ,M.NameVN
		                    ,M.NameJP
		                    ,M.Maker
		                    ,M.Model
		                    ,M.Series
		                    ,M.OrgCountry
		                    ,M.ProDate
		                    ,M.Lifetime
		                    ,M.StartDeprDate
		                    ,M.EndDeprDate
                            ,M.NetValue_Disposal
                            ,L.DesProcessCode
		                    ,L.DesLineCode
		                    ,L.DesLineEN
		                    ,L.DesGroupLineACC
		                    ,L.DesUsingDept
                            ,M.DisposalDate
                            ,M.DisposalMemo
                            ,M.DisposalStatus
                            ,M.DocNo_Disposal
		                    ,M.ControlDept
                            ,M.InputUser
	                    FROM 
		                    M0005_ListMMTBDisposal_Temp M
	                    LEFT JOIN
		                    (SELECT 
                                 L1.Code
                                ,ACCCode
			                    ,DesProcessCode
			                    ,DesLineCode
                                ,DesLineEN
			                    ,DesGroupLineACC
			                    ,DesUsingDept
		                    FROM 
			                    M0005_ListMMTBLine L1 
							JOIN
								(SELECT 
                                 Code
			                    ,MAX(ApplyDate) ApplyDate
		                    FROM 
			                    M0005_ListMMTBLine
		                    GROUP BY
                                 Code
							) L2 
							ON
								L1.Code = L2.Code
								AND L1.ApplyDate = L2.ApplyDate
							) L	                    
                        ON
                            M.Code              =   L.Code
                        WHERE 
                            M.DocNo_Disposal    =   @DocNo";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DocNo", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(DocNo);
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }

        //Lấy dữ liệu lên Form_M0005_Detail_Report
        public DataTable GetInfo_M0005_NT_Report(string DocNo)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
			                 Doc1.DocNo
		                    ,Doc1.InvNo
		                    ,Doc1.ReceiptDate
		                    ,Doc1.ControlDept
                            ,MMTB.NameEN
                            ,MMTB.Model
                            ,MMTB.Series
                            ,MMTB.Maker
                            ,MMTB.ProDate
                            ,MMTB.Code
                            ,Line.OrgLineCode
                            ,MMTB.Status
                            ,MMTB.Result
                            ,MMTB.Memo
	                    FROM 
                            M0005_ListMMTBDoc1  Doc1
                        INNER JOIN
                            M0005_ListMMTB		MMTB
                        ON
                            Doc1.DocNo		=   MMTB.DocNo
                        INNER JOIN
                        	M0005_ListMMTBLine	Line
                        ON
                            MMTB.DocNo		=   Line.DocNo_Confirm
                        AND	MMTB.Code		=   Line.Code
                        WHERE 
                            Doc1.DocNo      =   @DocNo
                        ORDER BY
                            Code";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DocNo", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(DocNo);
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }

        //Lưu chứng từ thanh lý MMTB
        public bool Disposal_MMTB(DataTable listMMTB, DataTable listMMTBDoc2)
        {
            return conn.Disposal_MMTB(listMMTB, listMMTBDoc2);
        }
        //Xác nhận chứng từ thanh lý MMTB
        public bool Confirm_Disposal_MMTB(DataTable listMMTB, DataTable listMMTBDoc2)
        {
            return conn.Confirm_Disposal_MMTB(listMMTB, listMMTBDoc2);
        }
        //Lưu và Xác nhận chứng từ thanh lý MMTB
        public bool Insert_Confirm_Disposal_MMTB(DataTable listMMTB, DataTable listMMTBDoc2)
        {
            return conn.Insert_Confirm_Disposal_MMTB(listMMTB, listMMTBDoc2);
        }
        #endregion
        #region Di dời MMTB
        //Lấy list MMTB có thể di dời
        public DataTable GetInfo_MMTB_Move()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	 M.Code
		                    ,M.ACCcode
		                    ,M.NameEN
		                    ,M.NameVN
		                    ,M.NameJP
		                    ,M.Maker
		                    ,M.Model
                            ,M.ConfirmDate
                            ,M.DocNo_Confirm
                            ,M.ControlDept
                            ,M.OrgProcessCode
                            ,M.OrgLineCode
                            ,M.OrgLineEN
                            ,M.OrgGroupLineACC
                            ,M.OrgUsingDept
		                    ,M.DesProcessCode as SourceProcessCode
		                    ,M.DesLineCode as SourceLineCode
		                    ,M.DesLineEN as SourceLineEN
		                    ,M.DesGroupLineACC as SourceGroupLineACC
		                    ,M.DesUsingDept as SourceUsingDept
		                    ,'' as SourceProcessCode
		                    ,'' as SourceLineCode
		                    ,'' as SourceLineEN
		                    ,'' as SourceGroupLineACC
		                    ,'' as SourceUsingDept
					        ,M.MoveDate
					        ,M.DocNo_Move
                            ,M.ApplyDate
	                    FROM 
		                    M0005_ListMMTBLine M
	                    JOIN
		                    (SELECT
                                 Code
                                ,MAX(ApplyDate) ApplyDate
		                    FROM 
			                    M0005_ListMMTBLine
		                    GROUP BY
                                Code) L
	                    ON
                                M.Code           = L.Code
                            AND M.ApplyDate      = L.ApplyDate";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Code", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy dữ liệu số chứng từ trên Form_M0005_Detail_DD
        public DataTable GetInfo_M0005_DocDD()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"	SELECT 
                                 DocNo
		                        ,DocDate
		                        ,MoveDate
                                ,Memo
	                        FROM 
		                        M0005_ListMMTBDoc3
                            ORDER BY DocNo DESC";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DocNo", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy dữ liệu lên Form_M0005_Detail_DD khi có số chứng từ
        public DataTable GetInfo_M0005_DD_Header(string DocNo)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();
            StrQuery = @"SELECT 
                             DocNo
                            ,DocDate
                            ,MoveDate
                            ,ControlDept
                            ,DocStatus
                            ,Memo
                            ,InputUser
                            ,ConfUser
                            ,ConfDate
                            ,Column3
                            ,Column4
                            ,Column5
                        FROM 
                            M0005_ListMMTBDoc3
                        WHERE 
                            DocNo = @DocNo";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DocNo", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(DocNo);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy dữ liệu lên Form_M0005_Detail_DD khi đã xác nhận chứng từ 
        public DataTable GetInfo_M0005_DD_Detail(string DocNo)
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
                            ,ConfirmDate
                            ,DocNo_Confirm
                            ,ControlDept
		                    ,OrgProcessCode
		                    ,OrgLineCode
		                    ,OrgLineEN
		                    ,OrgGroupLineACC
		                    ,OrgUsingDept
		                    ,SourceProcessCode
		                    ,SourceLineCode
		                    ,SourceLineEN
		                    ,SourceGroupLineACC
		                    ,SourceUsingDept
		                    ,DesProcessCode
		                    ,DesLineCode
		                    ,DesLineEN
		                    ,DesGroupLineACC
		                    ,DesUsingDept
					        ,MoveDate
					        ,DocNo_Move
                            ,ApplyDate
                            ,InputUser
	                    FROM 
		                    M0005_ListMMTBLine
                        WHERE 
                            DocNo_Move = @DocNo";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DocNo", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(DocNo);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy dữ liệu lên Form_M0005_Detail_DD khi chưa xác nhận chứng từ 
        public DataTable GetInfo_M0005_DD_Detail_Temp(string DocNo)
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
                            ,ConfirmDate
                            ,DocNo_Confirm
                            ,ControlDept
		                    ,OrgProcessCode
		                    ,OrgLineCode
		                    ,OrgLineEN
		                    ,OrgGroupLineACC
		                    ,OrgUsingDept
		                    ,SourceProcessCode
		                    ,SourceLineCode
		                    ,SourceLineEN
		                    ,SourceGroupLineACC
		                    ,SourceUsingDept
		                    ,DesProcessCode
		                    ,DesLineCode
		                    ,DesLineEN
		                    ,DesGroupLineACC
		                    ,DesUsingDept
					        ,MoveDate
					        ,DocNo_Move
                            ,ApplyDate
                            ,InputUser
	                    FROM 
		                    M0005_ListMMTBMove_Temp
                        WHERE 
                            DocNo_Move = @DocNo";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DocNo", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(DocNo);
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }

        //Lưu chứng từ di dời MMTB
        public bool Move_MMTB(DataTable listMMTB, DataTable listMMTBDoc3)
        {
            return conn.Move_MMTB(listMMTB, listMMTBDoc3);
        }

        //Xác nhận chứng từ di dời MMTB
        public bool Confirm_Move_MMTB(DataTable listMMTB, DataTable listMMTBDoc3)
        {
            return conn.Confirm_Move_MMTB(listMMTB, listMMTBDoc3);
        }
        #endregion
        //Xác nhận chứng từ di dời MMTB
        public bool Insert_Confirm_Move_MMTB(DataTable listMMTB, DataTable listMMTBDoc3)
        {
            return conn.Insert_Confirm_Move_MMTB(listMMTB, listMMTBDoc3);
        }
        #region Bổ sung thông tin của ACC
        //Xác nhận mã ACC
        public DataTable Check_M0005_ACCcode(string ACCcode)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	ACCcode
                        FROM
                        	M0005_ListMMTB
                        WHERE 
                            ACCcode = @ACCcode";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ACCcode", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(ACCcode);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Xác nhận bổ sung thông tin
        public bool ACC_Confirm_MMTB(DataTable listMMTB)
        {
            return conn.ACC_Confirm_MMTB(listMMTB);
        }
        #endregion
        #region MMTB không sử dụng
        //Số chứng từ MMTB NoUsed
        public DataTable GetInfo_M0005_Doc_NoUsed()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                             DocNo
                            ,DocDate
                            ,FromDate
                            ,ToDate
                            ,CASE
                                WHEN DocStatus = 0 THEN N'Chuẩn bị'
                                ELSE N'Xác nhận'
                            END AS DocStatus
                        FROM 
                            M0005_ListMMTBDoc4
                        ORDER BY
                            DocNo DESC";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DocNo", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Số chứng từ MMTB NoUsed chưa xác nhận
        public DataTable GetInfo_M0005_Doc_NoUsed_Pre()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                             DocNo
                            ,DocDate
                            ,FromDate
                            ,ToDate
                            ,CASE
                                when DocStatus = 0 then N'Chuẩn bị' 
                                else N'Xác nhận'
                            end as DocStatus
                        FROM 
                            M0005_ListMMTBDoc4
                        WHERE
                            DocStatus = 0
                        ORDER BY
                            DocNo DESC";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DocNo", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Kiểm tra ngày bắt đầu
        public DataTable GetInfo_M0005_Doc_NoUsed_FromDate(DateTime fromDate)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                             DocNo
                            ,DocDate
                            ,FromDate
                        FROM 
                            M0005_ListMMTBDoc4
                        WHERE FromDate  >   @fromDate";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@FromDate", SqlDbType.DateTime);
            sqlParameters[0].Value = Convert.ToDateTime(fromDate);
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }

        //Số chứng từ MMTB NoUsed _ Header
        public DataTable GetInfo_M0005_NoUsed_Header(string DocNo)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                             DocNo
                            ,DocDate
                            ,FromDate
                            ,ToDate
                            ,DocStatus
                            ,ControlDept
                            ,InputUser
                        FROM 
                            M0005_ListMMTBDoc4
                        WHERE 
                            DocNo = @DocNo
                        ORDER BY
                            DocNo DESC";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DocNo", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(DocNo);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Danh sách MMTB NoUsed _ Detail
        public DataTable GetInfo_M0005_NoUsed_Detail(string DocNo)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                             [Code]
                            ,[ACCcode]
                            ,[NameEN]
                            ,[NameVN]
                            ,[NameJP]
                            ,[Maker]
                            ,[Model]
                            ,[Series]
                            ,[OrgCountry]
                            ,[ProDate]
                            ,[Lifetime]
                            ,[NetValue]
                            ,[StartDeprDate]
                            ,[EndDeprDate]
                            ,[Reason]
                            ,[CurStatus]
                            ,[CurPlan]
                            ,[Solve]                     
                            ,[InputUser]
                        FROM 
                            M0005_ListMMTBNoUsed
                        WHERE 
                            DocNo = @DocNo";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DocNo", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(DocNo);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        public DataTable GetInfo_M0005_NoUsed()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	  L.Code
                        	,ACCcode
                        	,NameEN
                        	,NameVN
                        	,NameJP
                        	,Maker
                        	,Model
                        	,Series
                        	,OrgCountry
                        	,ProDate
                        	,Lifetime
                            ,CASE
                                WHEN NetValue is null THEN 0
                                ELSE CONVERT(decimal(16,4),NetValue)
                            END AS NetValue
                        	,StartDeprDate
                        	,L.EndDeprDate
                            ,Reason
                            ,CurStatus
                            ,CurPlan
                            ,Solve
                            ,InputUser
                        FROM
                        	M0005_ListMMTBNoUsed L
                        JOIN
                            (SELECT 
                                 Code
                        	    ,MAX(ToDate) AS ToDate
                            FROM
                                M0005_ListMMTBNoUsed
                            GROUP BY Code) L1
                        ON 
                            L.Code     = L1.Code
                        AND L.ToDate   = L1.ToDate
                        ORDER BY
                            L.Code";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Code", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Xác nhận bổ sung thông tin
        public string Insert_MMTB_No_Used(DataTable listMMTB, DataTable _listDelete, DataTable listMMTBDoc4 )
        {
            return conn.Insert_MMTB_No_Used(listMMTB,_listDelete, listMMTBDoc4);
        }
        public bool Confirm_MMTB_No_Used(DataTable listMMTB, DataTable _listDelete, DataTable listMMTBDoc4)
        {
            return conn.Confirm_MMTB_No_Used(listMMTB, _listDelete, listMMTBDoc4);
        }
        public string Insert_Confirm_MMTB_No_Used(DataTable listMMTB, DataTable listMMTBDoc4)
        {
            return conn.Insert_Confirm_MMTB_No_Used(listMMTB, listMMTBDoc4);
        }
        #endregion
    }
}