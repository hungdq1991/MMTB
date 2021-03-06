﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMTB.DAO
{
    public class SYS_USER_DAO
    {
        private DBConnection conn;

        /// <constructor>
        /// Constructor SYS_USER_DAO
        /// </constructor>
        public SYS_USER_DAO()
        {
            conn = new DBConnection();
        }

        public DataTable GetInfoUser(string _userName, string _passWord)
        {
            string StrQuery = "";

            StrQuery = @"SELECT
                             UserID
                            ,Pw
                            ,IsAdmin
                            ,IsSupervisor
                            ,FullName
                            ,Descr
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
                            Sys_User
                        WHERE
                            UserID    = CONCAT('',@userName,'')
                        AND Pw        = CONCAT('',@passWord,'')";

            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@userName", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(_userName);
            sqlParameters[1] = new SqlParameter("@passWord", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(_passWord);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        public bool ChangePw(string _userName, string _passWordNew)
        {
            string StrQuery = "";
          
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"UPDATE  dbo.Sys_User
                            SET  Pw     = @_passWordNew, 
                            ModifyDate = GETDATE(),
                            ModifyUser = @_userName
                            WHERE UserID = @_userName";

            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@_passWordNew", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(_passWordNew);
            sqlParameters[1] = new SqlParameter("@_userName", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(_userName);

            return conn.executeUpdateQuery(StrQuery, sqlParameters);
        }
    }
}

