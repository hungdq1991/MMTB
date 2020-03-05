using System;
using System.Data;
using System.Data.SqlClient;

namespace TAKAKO_ERP_3LAYER.DAO
{
    public class M0005_Line_DAO
    {
        private DBConnection conn;
        /// <constructor>
        /// Constructor M0005_Line_DAO
        /// </constructor>
        public M0005_Line_DAO()
        {
            conn = new DBConnection();
        }

        //public DataTable GetInfo_M0005_Line()
        //{
        //    string StrQuery = "";
        //    DataTable _tempDataTable = new DataTable();

        //    StrQuery = @"SELECT
        //                	 Code
        //                	,ACCcode
        //                	,NameEN
        //                	,NameVN
        //                	,NameJP
        //                	,Maker
        //                	,Model
        //                	,Series
        //                	,OrgCountry
        //                	,ProDate
        //                	,Lifetime
        //                	,StartDeprDate
        //                	,EndDeprDate
        //                	,Status
        //                	,Result
        //                	,Memo
        //                	,InstDoc
        //                	,ACCDoc
        //                	,DocNo_Disposal
        //                	,ACCDoc_Disposal
        //                	,DisposalDate
        //                	,DocNo
        //                	,DocDate
        //                	,EF_VendID
        //                	,SupplierID
        //                	,SupplierName
        //                	,InvNo
        //                	,InvDate
        //                	,ReceiptDate
        //                	,ConfirmDate
        //                	,ControlDept
        //                	,Column1
        //                	,Column2
        //                	,Column3
        //                	,Column4
        //                	,Column5
        //                FROM
        //                	M0005_ListMMTB
        //                WHERE 
        //                    DisposalDate is not null ";
        //    SqlParameter[] sqlParameters = new SqlParameter[1];
        //    sqlParameters[0] = new SqlParameter("@Code", SqlDbType.Text);
        //    sqlParameters[0].Value = Convert.ToString("");
        //    return conn.executeSelectQuery(StrQuery, sqlParameters);
        //}
        //Lấy mã MMTB, điền thông tin MMTB
        public DataTable GetInfo_LineMMTB(string Code)
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
                            ,ConfDate
                            ,DocNo_Confirm
                            ,ControlDept
                            ,OrgUsingDept
                            ,OrgLineCode
                            ,OrgGroupLineACC
                            ,OrgLineEN
                            ,OrgProcessCode
                            ,SourceUsingDept
                            ,SourceLineCode
                            ,SourceGroupLineACC
                            ,SourceLineEN
                            ,SourceProcessCode
                        FROM 
	                        M0005_ListMMTBLine
                        WHERE 
                            Code = @Code";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Code", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString(Code);
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
    }
}