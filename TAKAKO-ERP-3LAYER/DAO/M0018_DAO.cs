using System;
using System.Data;
using System.Data.SqlClient;

namespace MMTB.DAO
{
    public class M0018_DAO
    {
        private DBConnection conn;
        /// <constructor>
        /// Constructor M0018_DAO
        /// </constructor>
        public M0018_DAO()
        {
            conn = new DBConnection();
        }

        public DataTable GetInfo_M0018()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
	                         MSNV
                            ,FullName
                            ,JoinDate
                            ,ElecDynamic
                            ,ElecControl
                            ,CompressedAir
                            ,HydraulicSys
                            ,DriveSys
                            ,MechanicalSys
                            ,OtherSkill
                            ,Inactive
                            ,Memo
                            ,InputDate
                            ,InputUser
                            ,ModifyDate
                            ,ModifyUser
                        FROM 
	                        M0018_SkillEmployee";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DueDateFrom", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
    }
}