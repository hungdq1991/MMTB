using System;
using System.Data;
using System.Data.SqlClient;

namespace TAKAKO_ERP_3LAYER.DAO
{
    public class M0009_DAO
    {
        private DBConnection conn;
        /// <constructor>
        /// Constructor M0009_DAO
        /// </constructor>
        public M0009_DAO()
        {
            conn = new DBConnection();
        }

        public DataTable GetInfo_M0009()
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
	                        M0009_ListMMTBLine";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DueDateFrom", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
    }
}