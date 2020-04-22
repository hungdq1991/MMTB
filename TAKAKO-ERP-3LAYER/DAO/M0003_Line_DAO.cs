using System;
using System.Data;
using System.Data.SqlClient;

namespace MMTB.DAO
{
    public class M0003_Line_DAO
    {
        private DBConnection conn;
        /// <constructor>
        /// Constructor M0003_DAO
        /// </constructor>
        public M0003_Line_DAO()
        {
            conn = new DBConnection();
        }
        //Load dữ liệu từ bảng M0003_Line
        public DataTable GetInfo_M0003()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                               TVC 
                              ,LineCode
                              ,LineEN
                              ,LineVN
                              ,LineJP
                              ,ProcessCode
                              ,GroupLineACC
                              ,UsingDept
                              ,Point                              
                              ,ExpenseGroup
                              ,ApplyDate
                              ,InActive
                              ,Memo
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
	                           M0003_Line
                            ORDER BY TVC, LineCode";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@LineCode", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Tạo class Insert
        public bool Insert(
                           string TVC,
                           string LineCode, 
                           string LineEN,
                           string LineVN,
                           string LineJP,
                           string ProcessCode,
                           string GroupLineACC,
                           string UsingDept,
                           int Point,
                           string ExpenseGroup,
                           DateTime ApplyDate,
                           int InActive,
                           string Memo,
                           string _userName)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"INSERT INTO [M0003_Line]
                            ([TVC]
                            ,[LineCode]
                            ,[LineEN]
                            ,[LineVN]
                            ,[LineJP]
                            ,[ProcessCode]
                            ,[GroupLineACC]
                            ,[UsingDept]
                            ,[Point]
                            ,[ExpenseGroup]
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
                            (@TVC
                            ,@LineCode
                            ,@LineEN
                            ,@LineVN
                            ,@LineJP
                            ,@ProcessCode
                            ,@GroupLineACC
                            ,@UsingDept
                            ,@Point
                            ,@ExpenseGroup
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
            SqlParameter[] sqlParameters = new SqlParameter[14];
            sqlParameters[0] = new SqlParameter("@TVC", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(TVC);
            sqlParameters[1] = new SqlParameter("@LineCode", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(LineCode);
            sqlParameters[2] = new SqlParameter("@LineEN", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(LineEN);
            sqlParameters[3] = new SqlParameter("@LineVN", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(LineVN);
            sqlParameters[4] = new SqlParameter("@LineJP", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(LineJP);
            sqlParameters[5] = new SqlParameter("@ProcessCode", SqlDbType.NVarChar);
            sqlParameters[5].Value = Convert.ToString(ProcessCode);
            sqlParameters[6] = new SqlParameter("@GroupLineACC", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(GroupLineACC);
            sqlParameters[7] = new SqlParameter("@UsingDept", SqlDbType.NVarChar);
            sqlParameters[7].Value = Convert.ToString(UsingDept);
            sqlParameters[8] = new SqlParameter("@Point", SqlDbType.Int);
            sqlParameters[8].Value = Convert.ToInt32(Point);
            sqlParameters[9] = new SqlParameter("@ExpenseGroup", SqlDbType.NVarChar);
            sqlParameters[9].Value = Convert.ToString(ExpenseGroup);
            sqlParameters[10] = new SqlParameter("@ApplyDate", SqlDbType.DateTime);
            sqlParameters[10].Value = Convert.ToDateTime(ApplyDate);
            sqlParameters[11] = new SqlParameter("@InActive", SqlDbType.Bit);
            sqlParameters[11].Value = Convert.ToByte(InActive);
            sqlParameters[12] = new SqlParameter("@Memo", SqlDbType.NVarChar);
            sqlParameters[12].Value = Convert.ToString(Memo);
            sqlParameters[13] = new SqlParameter("@InputUser", SqlDbType.Text);
            sqlParameters[13].Value = Convert.ToString(_userName);

            return conn.executeInsertQuery(StrQuery, sqlParameters);
        }
        //Tạo class Update
        public bool Update(string LineCode,
                           string LineEN,
                           string LineVN,
                           string LineJP,
                           DateTime ApplyDate,
                           int InActive,
                           string Memo,
                           string _userName)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"UPDATE  dbo.M0003_Line
                            SET  
                                 LineEN     = @LineEN
                                ,LineVN     = @LineVN
                                ,LineJP     = @LineJP
                                ,InActive   = @InActive
                                ,Memo       = @Memo
                                ,ModifyDate = GETDATE()
                                ,ModifyUser = @InputUser
                            WHERE 
                                    LineCode    = @LineCode
                                and ApplyDate = @ApplyDate
                                    ";
            SqlParameter[] sqlParameters = new SqlParameter[8];
            sqlParameters[0] = new SqlParameter("@LineCode", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(LineCode);
            sqlParameters[1] = new SqlParameter("@LineEN", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(LineEN);
            sqlParameters[2] = new SqlParameter("@LineVN", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(LineVN);
            sqlParameters[3] = new SqlParameter("@LineJP", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(LineJP);
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
        public bool Delete(string LineCode, DateTime ApplyDate)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"DELETE FROM [dbo].[M0003_Line]
                            WHERE LineCode = @LineCode and ApplyDate = @ApplyDate";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@LineCode", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(LineCode);
            sqlParameters[1] = new SqlParameter("@ApplyDate", SqlDbType.DateTime);
            sqlParameters[1].Value = Convert.ToDateTime(ApplyDate);

            return conn.executeDeleteQuery(StrQuery, sqlParameters);
        }
        //Tạo class Check
        public DataTable GetInfo_M0003_Check(string LineCode,
                                             string ProcessCode,
                                             string GroupLineACC,
                                             string UsingDept,
                                             string ExpenseGroup,
                                             DateTime ApplyDate)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	LineCode,                        
                            ProcessCode,
                            GroupLineACC,
                            UsingDept,
                            ExpenseGroup,
                            ApplyDate,
                            InActive
                        FROM
                        	M0003_Line
                        WHERE 
                            (   LineCode         = @LineCode
                            and ProcessCode   = @ProcessCode
                            and GroupLineACC   = @GroupLineACC
                            and UsingDept = @UsingDept)
                        or (LineCode = @LineCode and ApplyDate = @ApplyDate)
                        or (LineCode = @LineCode and InActive = 0)";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@LineCode", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(LineCode);
            sqlParameters[1] = new SqlParameter("@GroupLineACC", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(GroupLineACC);
            sqlParameters[2] = new SqlParameter("@ProcessCode", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(ProcessCode);
            sqlParameters[3] = new SqlParameter("@UsingDept", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(UsingDept);
            sqlParameters[4] = new SqlParameter("@ExpenseGroup", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(ExpenseGroup);
            sqlParameters[5] = new SqlParameter("@ApplyDate", SqlDbType.DateTime);
            sqlParameters[5].Value = Convert.ToDateTime(ApplyDate);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }

        //Lấy dữ liệu từ bảng M0003_Process (không có parammeter)
        //nhập ProcessCode
        public DataTable GetInfo_M0003_ProcessCode()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	 ProcessCode
                            ,ProcessEN
                            ,ProcessVN
                        FROM
                            M0003_ProcessCode
                        ORDER BY
                            ProcessCode";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ProcessCode", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }

            //Lấy dữ liệu từ bảng M0003_Line (không có parammeter)
            //nhập Tên line
            public DataTable GetInfo_M0001_LineEN()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
                        	 NameEN
                            ,NameVN
                        FROM
                            M0001_Name
                        WHERE 
                            Line = 1
                        and InActive = 0
                        ORDER BY
                            NameEN";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@LineEN", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy dữ liệu từ bảng M0003_Line (không có parammeter)
        //nhập UsingDept
        public DataTable GetInfo_M0003_UsingDept()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT distinct
                        	UsingDept
                        FROM
                            M0003_Line
                        ORDER BY
                            UsingDept";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@UsingDept", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy dữ liệu từ bảng M0003_Line (không có parammeter)
        //nhập GroupLineACC
        public DataTable GetInfo_M0003_GroupLineACC()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
                        	 rtrim(ConsolSub) as ConsolSub
                            ,Descr
                        FROM
                            [SOLOMON-SERVER].[TVCAPP].[dbo].[SubAcct]
                        WHERE 
                            Active = 1";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ConsolSub", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy dữ liệu từ bảng M0003_Line (không có parammeter)
        //nhập ExpenseGroup
        public DataTable GetInfo_M0003_ExpenseGroup()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT distinct
                        	ExpenseGroup
                        FROM
                            M0003_Line
                        ORDER BY
                            ExpenseGroup";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ExpenseGroup", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy dữ liệu từ bảng M0003_Line (không có parammeter)
        //nhập Memo
        public DataTable GetInfo_M0003_Memo()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT distinct
                        	Memo
                        FROM
                            M0003_Line
                        ORDER BY
                            Memo";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Memo", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }

        public DataTable GetInfo_M0003_ProgressGroup()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                               TVC 
                              ,LineCode
                              ,LineEN
                              ,LineVN
                              ,LineJP
                              ,ProcessCode
                              ,GroupLineACC
                              ,UsingDept
                              ,ApplyDate
                              ,InActive                  
                            FROM 
	                           M0003_Line";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@LineCode", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
    }
}
