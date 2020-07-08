using System;
using System.Data;
using System.Data.SqlClient;


namespace MMTB.DAO
{
    public class M0001_DAO
    {
        private DBConnection conn;

        /// <constructor>
        /// Constructor M0001_DAO
        /// </constructor>
        public M0001_DAO()
        {
            conn = new DBConnection();
        }

        public DataTable GetInfo_M0001()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	 NameEN
                        	,NameVN
                        	,NameJP
                        	,Name
                        	,Group1
                        	,Group2
                            ,Line
                        	,InActive
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
                        	M0001_Name
                        ORDER BY NameEN";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@NameEN", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        public bool Insert_Name(string NameEN,
                                     string NameVN,
                                     string NameJP,
                                     int Name,
                                     int Group1,
                                     int Group2,
                                     int Line,
                                     int InActive,
                                     string _userName)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"INSERT INTO [M0001_Name]
                            ([NameEN]
                            ,[NameVN]
                            ,[NameJP]
                            ,[Name]
                            ,[Group1]
                            ,[Group2]
                            ,[Line]
                            ,[InActive]
                            ,[InputDate]
                            ,[InputUser]
                            ,[ModifyDate]
                            ,[ModifyUser]
                            ,[Column1]
                            ,[Column2]
                            ,[Column3]
                            ,[Column4]
                            ,[Column5])
                        VALUES
                            (@NameEN
                            ,@NameVN
                            ,@NameJP
                            ,@Name
                            ,@Group1
                            ,@Group2
                            ,@Line
                            ,@InActive
                            ,GETDATE()
                            ,@InputUser
                            ,NULL
                            ,NULL
                            ,NULL
                            ,NULL
                            ,NULL
                            ,NULL
                            ,NULL)";
            SqlParameter[] sqlParameters = new SqlParameter[9];
            sqlParameters[0] = new SqlParameter("@NameEN", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(NameEN);
            sqlParameters[1] = new SqlParameter("@NameVN", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(NameVN);
            sqlParameters[2] = new SqlParameter("@NameJP", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(NameJP);
            sqlParameters[3] = new SqlParameter("@Name", SqlDbType.Bit);
            sqlParameters[3].Value = Convert.ToByte(Name);
            sqlParameters[4] = new SqlParameter("@Group1", SqlDbType.Bit);
            sqlParameters[4].Value = Convert.ToByte(Group1);
            sqlParameters[5] = new SqlParameter("@Group2", SqlDbType.Bit);
            sqlParameters[5].Value = Convert.ToByte(Group2);
            sqlParameters[6] = new SqlParameter("@Line", SqlDbType.Bit);
            sqlParameters[6].Value = Convert.ToByte(Line);
            sqlParameters[7] = new SqlParameter("@InActive", SqlDbType.Bit);
            sqlParameters[7].Value = Convert.ToByte(InActive);
            sqlParameters[8] = new SqlParameter("@InputUser", SqlDbType.Text);
            sqlParameters[8].Value = Convert.ToString(_userName);
            return conn.executeInsertQuery(StrQuery, sqlParameters);
        }

        public bool Update_Name(string NameEN,
                                string NameVN,
                                string NameJP,
                                int Name,
                                int Group1,
                                int Group2,
                                int Line,
                                int InActive,
                                string _userName)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"UPDATE  dbo.M0001_Name
                            SET  NameVN     = @NameVN
                                ,NameJP     = @NameJP
                                ,Name       = @Name
                                ,Group1     = @Group1
                                ,Group2     = @Group2
                                ,Line       = @Line
                                ,InActive   = @InActive
                                ,ModifyDate = GETDATE()
                                ,ModifyUser = @InputUser
                        WHERE NameEN = @NameEN";
            SqlParameter[] sqlParameters = new SqlParameter[9];
            sqlParameters[0] = new SqlParameter("@NameEN", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(NameEN);
            sqlParameters[1] = new SqlParameter("@NameVN", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(NameVN);
            sqlParameters[2] = new SqlParameter("@NameJP", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(NameJP);
            sqlParameters[3] = new SqlParameter("@Name", SqlDbType.Bit);
            sqlParameters[3].Value = Convert.ToByte(Name);
            sqlParameters[4] = new SqlParameter("@Group1", SqlDbType.Bit);
            sqlParameters[4].Value = Convert.ToByte(Group1);
            sqlParameters[5] = new SqlParameter("@Group2", SqlDbType.Bit);
            sqlParameters[5].Value = Convert.ToByte(Group2);
            sqlParameters[6] = new SqlParameter("@Line", SqlDbType.Bit);
            sqlParameters[6].Value = Convert.ToByte(Line);
            sqlParameters[7] = new SqlParameter("@InActive", SqlDbType.Bit);
            sqlParameters[7].Value = Convert.ToByte(InActive);
            sqlParameters[8] = new SqlParameter("@InputUser", SqlDbType.Text);
            sqlParameters[8].Value = Convert.ToString(_userName);

            return conn.executeUpdateQuery(StrQuery, sqlParameters);
        }

        public bool Delete_Name(string NameEN)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"DELETE FROM [dbo].[M0001_Name]
                            WHERE NameEN = @NameEN";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@NameEN", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(NameEN);

            return conn.executeDeleteQuery(StrQuery, sqlParameters);
        }
        //Kiểm tra lỗi trùng tên NameEN
        public DataTable GetInfo_M0001_Check(string NameEN)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	 NameEN
                        FROM
                        	M0001_Name
                        WHERE 
                            NameEN = @NameEN";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@NameEN", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(NameEN);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
    }
}