using System;
using System.Data;
using System.Data.SqlClient;

namespace MMTB.DAO
{
    public class M00091_DAO
    {
        private DBConnection conn;
        /// <constructor>
        /// Constructor M00091_DAO
        /// </constructor>
        public M00091_DAO()
        {
            conn = new DBConnection();
        }

        public DataTable GetInfo_M00091()
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
                            ,ControlDept
                            ,OrgUsedDept
                            ,OrgLineCode
                            ,OrgGroupLineACC
                            ,OrgLineEN
                            ,OrgProcessCode
                            ,SourceUsedDept
                            ,SourceLineCode
                            ,SourceGroupLineACC
                            ,SourceLineEN
                            ,SourceProcessCode
                            ,DesUsedDept
                            ,DesLineCode
                            ,DesGroupLineACC
                            ,DesLineEN
                            ,DesProcessCode
                            ,ConfDate
                            ,DocNo_Confirm
                            ,MoveDate
                            ,DocNo_Move
                            ,DocNo_Disposal
                            ,ACCDoc_Disposal
                            ,DisposalDate
                        FROM 
	                        M0009_ListMMTBLine
                        WHERE DisposalDate is not null";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DueDateFrom", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
    }
}