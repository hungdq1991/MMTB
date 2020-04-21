using System;
using System.Data;
using System.Data.SqlClient;

namespace TAKAKO_ERP_3LAYER.DAO
{
    public class M0003_ProcessGroup_DAO
    {
        private DBConnection conn;
        /// <constructor>
        /// Constructor M0003_ProcessGroup_DAO
        /// </constructor>
        public M0003_ProcessGroup_DAO()
        {
            conn = new DBConnection();
        }
        //Load dữ liệu từ bảng M0003_ProcessGroup
        public DataTable GetInfo_M0003()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
	                         ProcessCode
	                        ,ProcessEN
	                        ,ProcessVN
	                        ,ProcessJP
	                        ,Point
                            ,ApplyDate
	                        ,InActive
	                        ,Memo
	                        ,InputDate
	                        ,InputUser
	                        ,ModifyDate
	                        ,ModifyUser
                        FROM 
	                        M0003_ProcessGroup
                        ORDER BY ProcessCode";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ProcessCode", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Tạo class Insert
        public bool Insert(string ProcessCode,
                           string ProcessEN,
                           string ProcessVN,
                           string ProcessJP,
                           int Point,
                           DateTime ApplyDate,
                           int InActive,
                           string Memo,
                           string _userName)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"INSERT INTO [M0003_ProcessGroup]
                            ([ProcessCode]
                            ,[ProcessEN]
                            ,[ProcessVN]
                            ,[ProcessJP]
                            ,[Point]
                            ,[ApplyDate]
                            ,[InActive]
                            ,[Memo]
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
                            (@ProcessCode
                            ,@ProcessEN
                            ,@ProcessVN
                            ,@ProcessJP
                            ,@Point
                            ,@ApplyDate
                            ,@InActive
                            ,@Memo
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
            sqlParameters[0] = new SqlParameter("@ProcessCode", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(ProcessCode);
            sqlParameters[1] = new SqlParameter("@ProcessEN", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(ProcessEN);
            sqlParameters[2] = new SqlParameter("@ProcessVN", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(ProcessVN);
            sqlParameters[3] = new SqlParameter("@ProcessJP", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(ProcessJP);
            sqlParameters[4] = new SqlParameter("@Point", SqlDbType.Int);
            sqlParameters[4].Value = Convert.ToInt32(Point);
            sqlParameters[5] = new SqlParameter("@ApplyDate", SqlDbType.DateTime);
            sqlParameters[5].Value = Convert.ToDateTime(ApplyDate);
            sqlParameters[6] = new SqlParameter("@InActive", SqlDbType.Bit);
            sqlParameters[6].Value = Convert.ToByte(InActive);
            sqlParameters[7] = new SqlParameter("@Memo", SqlDbType.NVarChar);
            sqlParameters[7].Value = Convert.ToString(Memo);
            sqlParameters[8] = new SqlParameter("@InputUser", SqlDbType.Text);
            sqlParameters[8].Value = Convert.ToString(_userName);

            return conn.executeInsertQuery(StrQuery, sqlParameters);
        }
        //Tạo class Update
        public bool Update(string ProcessCode,
                           string ProcessEN,
                           string ProcessVN,
                           string ProcessJP,
                           DateTime ApplyDate,
                           int InActive,
                           string Memo,
                           string _userName)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"UPDATE  dbo.M0003_ProcessGroup
                            SET  ProcessEN      = @ProcessEN
                                ,ProcessVN      = @ProcessVN
                                ,ProcessJP      = @ProcessJP
                                ,InActive       = @InActive
                                ,Memo           = @Memo
                                ,ModifyDate     = GETDATE()
                                ,ModifyUser     = @InputUser
                            WHERE 
                                ProcessCode    = @ProcessCode
                            AND ApplyDate       = @ApplyDate
                                    ";
            SqlParameter[] sqlParameters = new SqlParameter[8];
            sqlParameters[0] = new SqlParameter("@ProcessCode", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(ProcessCode);
            sqlParameters[1] = new SqlParameter("@ProcessEN", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(ProcessEN);
            sqlParameters[2] = new SqlParameter("@ProcessVN", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(ProcessVN);
            sqlParameters[3] = new SqlParameter("@ProcessJP", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(ProcessJP);
            sqlParameters[4] = new SqlParameter("@Memo", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(Memo);
            sqlParameters[5] = new SqlParameter("@ApplyDate", SqlDbType.DateTime);
            sqlParameters[5].Value = Convert.ToDateTime(ApplyDate);
            sqlParameters[6] = new SqlParameter("@InActive", SqlDbType.Int);
            sqlParameters[6].Value = Convert.ToInt32(InActive);
            sqlParameters[7] = new SqlParameter("@InputUser", SqlDbType.Text);
            sqlParameters[7].Value = Convert.ToString(_userName);

            return conn.executeUpdateQuery(StrQuery, sqlParameters);
        }
        //Tạo class Delete
        public bool Delete(string ProcessCode, DateTime ApplyDate)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"DELETE FROM [dbo].[M0003_ProcessGroup]
                        WHERE   ProcessCode     = @ProcessCode
                        AND     ApplyDate       = @ApplyDate";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@ProcessCode", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(ProcessCode);
            sqlParameters[1] = new SqlParameter("@ApplyDate", SqlDbType.DateTime);
            sqlParameters[1].Value = Convert.ToDateTime(ApplyDate);

            return conn.executeDeleteQuery(StrQuery, sqlParameters);
        }
        //Tạo class Check
        public DataTable GetInfo_M0003_Check(string ProcessCode, DateTime ApplyDate)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                            ProcessCode,
                            ApplyDate,
                            InActive
                        FROM
                        	M0003_ProcessGroup
                        WHERE 
                                ProcessCode   = @ProcessCode
                            AND InActive    = 0";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@ProcessCode", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(ProcessCode);
            sqlParameters[1] = new SqlParameter("@ApplyDate", SqlDbType.DateTime);
            sqlParameters[1].Value = Convert.ToDateTime(ApplyDate);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy dữ liệu từ bảng ProcessEF(không có parammeter)
        //nhập ProcessGroup
        public DataTable GetInfo_M0003_Process()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
                            PROCESS_CODE
                           ,PROCESS_NAME
                         FROM
                            [Takako_1].[dbo].[PROCESSMF]
                        WHERE 
                            WORK_FLAG = 1
                        UNION
                        SELECT
                            PROCESS_CODE
                           ,PROCESS_NAME
                        FROM
                            [Takako_2].[dbo].[PROCESSMF]
                        WHERE 
                            WORK_FLAG = 1
                        ORDER BY 
                            PROCESS_CODE";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@PROCESS_CODE", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }

        //Lấy dữ liệu từ bảng ProcessEF(có parammeter)
        //nhập lấy tên Process
        public DataTable GetInfo_M0003_ProcessGroup(string PROCESS_CODE)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
                            PROCESS_CODE
                           ,PROCESS_NAME
                           ,PROCESS_NAME_V
                           ,PROCESS_NAME_J
                        FROM
                            [Takako_1].[dbo].[PROCESSMF]
                        WHERE 
                            PROCESS_CODE    = @PROCESS_CODE
                            AND WORK_FLAG   = 1
                        UNION
                        SELECT
                            PROCESS_CODE
                           ,PROCESS_NAME
                           ,PROCESS_NAME_V
                           ,PROCESS_NAME_J
                        FROM
                            [Takako_2].[dbo].[PROCESSMF]
                        WHERE 
                            PROCESS_CODE    = @PROCESS_CODE
                        AND WORK_FLAG       = 1";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@PROCESS_CODE", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(PROCESS_CODE);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
    }
}
