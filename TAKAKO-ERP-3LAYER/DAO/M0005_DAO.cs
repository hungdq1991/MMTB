using System;
using System.Data;
using System.Data.SqlClient;

namespace TAKAKO_ERP_3LAYER.DAO
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
                        	 Code
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
                         	,L.Column1
                        	,L.Column2
                        	,L.Column3
                        	,L.Column4
                        	,L.Column5
                            ,N.Group1
                            ,N.Group2
                        FROM
                        	M0005_ListMMTB L
                        JOIN 
                            M0002_GroupName N
                        ON 
                            L.NameEN = N.NameEN";
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
		                        M0005_ListMMTBDoc1";
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
                            ,Column1
                            ,Column2
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

        //Lấy dữ liệu số chứng từ trên Form_M0005_Detail_TL
        public DataTable GetInfo_M0005_DocTL()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"	SELECT 
		                         DISTINCT 
                                 DocNo
		                        ,DocDate
		                        ,DisposalDate
		                        ,case when EF_VendID is null then '' else RTRIM(EF_VendID) end as EF_VendID
                                ,case when SupplierID is null then '' else SupplierID end as SupplierID
		                        ,case when SupplierName is null then '' else SupplierName end as SupplierName
		                        ,case when InvNo is null then '' else InvNo end as InvNo
	                        FROM 
		                        M0005_ListMMTBDoc2";
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
		                    ,case when EF_VendID is null then '' else RTRIM(EF_VendID) end as EF_VendID
                            ,isNull(SupplierID,'') as SupplierID
		                    ,case when SupplierName is null then '' else SupplierName end as SupplierName
		                    ,case when InvNo is null then '' else InvNo end as InvNo
                            ,isNull(InvDate,convert(DateTime,'2000-01-01')) as InvDate
                            ,DisposalDate
                            ,ControlDept
                            ,DocStatus
                            ,Column1
                            ,Column2
                            ,Column3
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
		                    ,L.DesProcessCode
		                    ,L.DesLineCode
		                    ,L.DesLineEN
		                    ,L.DesGroupLineACC
		                    ,L.DesUsingDept
		                    ,M.ControlDept
		                    ,M.DisposalMemo
	                    FROM 
		                    M0005_ListMMTB M
	                    LEFT JOIN
		                    (SELECT 
                                 DocNo_Disposal
                                ,Code
                                ,ACCCode
			                    ,DesProcessCode
			                    ,DesLineCode
                                ,DesLineEN
			                    ,DesGroupLineACC
			                    ,DesUsingDept
			                    ,MAX(ApplyDate) ApplyDate
		                    FROM 
			                    M0005_ListMMTBLine
                            WHERE 
                                DocNo_Disposal = @DocNo
		                    GROUP BY
			                     DocNo_Disposal
                                ,Code
                                ,ACCCode
			                    ,DesProcessCode
			                    ,DesLineCode
                                ,DesLineEN
			                    ,DesGroupLineACC
			                    ,DesUsingDept) L
	                    ON
	                        M.DocNo_Disposal    =   L.DocNo_Disposal
                        AND M.Code              =   L.Code
                        WHERE 
                            M.DocNo_Disposal    =   @DocNo";
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
        //NCC cũ không có trong table xt_CPMapVend
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
        //Update info MMTB
        public string Update_MMTB(DataTable listMMTB, DataTable _listDelete, DataTable listMMTBDoc1)
        {
            return conn.Update_MMTB(listMMTB, _listDelete , listMMTBDoc1);
        }
    }
}