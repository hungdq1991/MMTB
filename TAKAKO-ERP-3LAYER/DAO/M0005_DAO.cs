﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace TAKAKO_ERP_3LAYER.DAO
{
    public class M0005_DAO
    {
        private DBConnection conn;
        const String sp_Update_MMTB = "SP_TVC_UPDATE_MMTB";
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
                            ,NameEN
                            ,NameVN
                            ,NameJP
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
                            ,Doc_Date
                            ,SupplierID
                            ,SupplierName
                            ,InvNo
                            ,InvDate
                            ,ReceiptDate
                            ,ConfirmDate
                            ,ControlDept
                            ,Column1
                            ,Column2
                            ,Column3
                            ,Column4
                            ,Column5                        
                        FROM 
	                        M0005_ListMMTB";
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
		                        M0005_ListMMTB";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DocNo", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy dữ liệu lên Form_M0005_Detail_NT khi có số chứng từ
        public DataTable GetInfo_M0005_NT(string DocNo)
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
		                        ,M.Status
		                        ,M.Result
		                        ,M.Memo
		                        ,M.InstDoc
		                        ,M.ACCDoc
		                        ,M.DocNo_Disposal
		                        ,M.ACCDoc_Disposal
		                        ,M.DisposalDate
		                        ,D.DocNo
		                        ,D.DocDate
		                        ,D.EF_VendID
		                        ,D.SupplierID
		                        ,D.SupplierName
		                        ,D.InvNo
		                        ,D.InvDate
		                        ,D.ReceiptDate
		                        ,D.ConfirmDate
		                        ,D.ControlDept
                                ,D.DocStatus
		                        ,M.Column1
		                        ,M.Column2
		                        ,M.Column3
		                        ,M.Column4
		                        ,M.Column5
		                        ,L.OrgProcessCode
		                        ,L.OrgLineCode
		                        ,L.OrgLineEN
		                        ,L.OrgGroupLineACC
		                        ,L.OrgUsingDept
	                        FROM 
		                        M0005_ListMMTB M
	                        LEFT JOIN
		                        (SELECT 
			                         Code
			                        ,OrgProcessCode
			                        ,OrgLineCode
			                        ,OrgLineEN
			                        ,OrgGroupLineACC
			                        ,OrgUsingDept
			                        ,MIN(ApplyDate) ApplyDate
		                        FROM 
			                        M0005_ListMMTBLine
		                        GROUP BY
			                         Code
			                        ,OrgProcessCode
			                        ,OrgLineCode
			                        ,OrgLineEN
			                        ,OrgGroupLineACC
			                        ,OrgUsingDept) L
	                        ON
	                            M.Code = L.Code
                            JOIN 
								(SELECT 
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
								    M0005_ListMMTBDoc1 ) D
							    ON
								    M.DocNo = D.DocNo 
                            WHERE 
                                M.DocNo like @DocNo";
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
                            ,VendID
                            ,VendName
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
                             VendID
                            ,VendName
                        FROM 
	                        [SOLOMON-SERVER].[TVCAPP].[dbo].[xt_CPMapVend]
                        WHERE 
                            EF_VendID like @EF_VendID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@EF_VendID", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(EF_VendID);
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
        public int Update_MMTB(DataTable listMMTB, DataTable listMMTBLine)
        {
            return conn.Update_MMTB(listMMTB, listMMTBLine, sp_Update_MMTB);
        }
    }
}