using System;
using System.Data;
using System.Data.SqlClient;

namespace TAKAKO_ERP_3LAYER.DAO
{
    public class M0002_DAO
    {
        private DBConnection conn;

        /// <constructor>
        /// Constructor M0002_DAO
        /// </constructor>
        public M0002_DAO()
        {
            conn = new DBConnection();
        }
        //Load dữ liệu từ table M0002
        public DataTable GetInfo_M0002()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
	                         NameEN
	                        ,NameVN
	                        ,NameJP
	                        ,Group1
	                        ,Group2
	                        ,ClassifyID
	                        ,ClassifyDesc
	                        ,ApplyDate
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
	                        M0002_GroupName";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@NameEN", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Tạo class Insert
        public bool Insert(string NameEN,
                           string NameVN,
                           string NameJP,
                           string Group1,
                           string Group2,
                           string ClassifyID,
                           string ClassifyDesc,
                           DateTime ApplyDate,
                           int InActive,
                           string _userName)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"INSERT INTO [M0002_GroupName]
                            ([NameEN]
                            ,[NameVN]
                            ,[NameJP]
                            ,[Group1]
                            ,[Group2]
                            ,[ClassifyID]
                            ,[ClassifyDesc]
                            ,[ApplyDate]
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
                            ,@Group1
                            ,@Group2
                            ,@ClassifyID
                            ,@ClassifyDesc
                            ,@ApplyDate
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
            SqlParameter[] sqlParameters = new SqlParameter[10];
            sqlParameters[0] = new SqlParameter("@NameEN", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(NameEN);
            sqlParameters[1] = new SqlParameter("@NameVN", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(NameVN);
            sqlParameters[2] = new SqlParameter("@NameJP", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(NameJP);
            sqlParameters[3] = new SqlParameter("@Group1", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(Group1);
            sqlParameters[4] = new SqlParameter("@Group2", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(Group2);
            sqlParameters[5] = new SqlParameter("@ClassifyID", SqlDbType.Int);
            sqlParameters[5].Value = Convert.ToInt32(ClassifyID);
            sqlParameters[6] = new SqlParameter("@ClassifyDesc", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(ClassifyDesc);
            sqlParameters[7] = new SqlParameter("@ApplyDate", SqlDbType.DateTime);
            sqlParameters[7].Value = Convert.ToDateTime(ApplyDate);
            sqlParameters[8] = new SqlParameter("@InActive", SqlDbType.Bit);
            sqlParameters[8].Value = Convert.ToByte(InActive);
            sqlParameters[9] = new SqlParameter("@InputUser", SqlDbType.Text);
            sqlParameters[9].Value = Convert.ToString(_userName);
            return conn.executeInsertQuery(StrQuery, sqlParameters);
        }
        //Tạo class Update
        public bool Update(string NameEN,
                           string NameVN,
                           string NameJP,
                           string Group1,
                           string Group2,
                           string ClassifyID,
                           string ClassifyDesc,
                           DateTime ApplyDate,
                           int InActive,
                           string _userName)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"UPDATE  dbo.M0002_GroupName
                            SET  NameVN     = @NameVN
                                ,NameJP     = @NameJP
                                ,Group1     = @Group1
                                ,Group2     = @Group2
                                ,ClassifyID = @ClassifyID
                                ,ClassifyDesc = @ClassifyDesc
                                ,ModifyDate = GETDATE()
                                ,ModifyUser = @InputUser
                            WHERE NameEN = @NameEN";
            SqlParameter[] sqlParameters = new SqlParameter[10];
            sqlParameters[0] = new SqlParameter("@NameEN", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(NameEN);
            sqlParameters[1] = new SqlParameter("@NameVN", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(NameVN);
            sqlParameters[2] = new SqlParameter("@NameJP", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(NameJP);
            sqlParameters[3] = new SqlParameter("@Group1", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(Group1);
            sqlParameters[4] = new SqlParameter("@Group2", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(Group2);
            sqlParameters[5] = new SqlParameter("@ClassifyID", SqlDbType.Int);
            sqlParameters[5].Value = Convert.ToInt32(ClassifyID);
            sqlParameters[6] = new SqlParameter("@ClassifyDesc", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(ClassifyDesc);
            sqlParameters[7] = new SqlParameter("@ApplyDate", SqlDbType.DateTime);
            sqlParameters[7].Value = Convert.ToDateTime(ApplyDate);
            sqlParameters[8] = new SqlParameter("@InActive", SqlDbType.Bit);
            sqlParameters[8].Value = Convert.ToByte(InActive);
            sqlParameters[9] = new SqlParameter("@InputUser", SqlDbType.Text);
            sqlParameters[9].Value = Convert.ToString(_userName);

            return conn.executeUpdateQuery(StrQuery, sqlParameters);
        }
        //Tạo class Delete
        public bool Delete(string NameEN, DateTime ApplyDate)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"DELETE FROM [dbo].[M0002_GroupName]
                            WHERE NameEN = @NameEN and ApplyDate = @ApplyDate";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@NameEN", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(NameEN);
            sqlParameters[1] = new SqlParameter("@ApplyDate", SqlDbType.DateTime);
            sqlParameters[1].Value = Convert.ToDateTime(ApplyDate);

            return conn.executeDeleteQuery(StrQuery, sqlParameters);
        }
        //Tạo class Check
        public DataTable GetInfo_M0002_Check(string NameEN,
                                             string Group1,
                                             string Group2,
                                             string ClassifyID,
                                             DateTime ApplyDate)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	NameEN,
                            Group1,
                            Group2,
                            ClassifyID,
                            ApplyDate
                        FROM
                        	M0002_GroupName
                        WHERE 
                            (NameEN = @NameEN
                            and Group1 = @Group1
                            and Group2 = @Group2
                            and ClassifyID = @ClassifyID)
                        or (NameEN = @NameEN and ApplyDate = @ApplyDate)";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@NameEN", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(NameEN);
            sqlParameters[1] = new SqlParameter("@Group1", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(Group1);
            sqlParameters[2] = new SqlParameter("@Group2", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(Group2);
            sqlParameters[3] = new SqlParameter("@ClassifyID", SqlDbType.Int);
            sqlParameters[3].Value = Convert.ToInt32(ClassifyID);
            sqlParameters[4] = new SqlParameter("@ApplyDate", SqlDbType.DateTime);
            sqlParameters[4].Value = Convert.ToDateTime(ApplyDate);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
         //Lấy dữ liệu từ bảng M0001_Name (không có parammeter)_Điều kiện InActive = 0 và Name = 1
         //nhập NameEN
        public DataTable GetInfo_M0001_Name()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	 N.NameEN
                            ,N.NameVN
                            ,N.NameJP
                        FROM
                            M0001_Name N
                        INNER JOIN
                            (SELECT
                        	     NameEN
                            FROM
                                M0001_Name 
                            WHERE 
								InActive = 0
                                AND Name = 1) N1
                        ON
                            N.NameEn = N1.NameEN
                        ORDER BY
                            N.NameEN";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@NameEN", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy dữ liệu từ bảng M0001_Name (không có parammeter)_Điều kiện InActive = 0 và Group1 = 1
        //nhập Group1
        public DataTable GetInfo_M0001_Group1()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	 N.NameEN
                        FROM
                            M0001_Name N
                        INNER JOIN
                            (SELECT
                        	    NameEN
                            FROM
                                M0001_Name 
                            WHERE 
								InActive = 0
                                AND Group1 = 1) N1
                        ON
                            N.NameEn = N1.NameEN
                        ORDER BY
                            N.NameEN";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@NameEN", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy dữ liệu từ bảng M0001_Name (không có parammeter)_Điều kiện InActive = 0 và Group2 = 1
        //nhập Group2
        public DataTable GetInfo_M0001_Group2()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	 N.NameEN
                            ,N.NameVN
                            ,N.NameJP
                        FROM
                            M0001_Name N
                        INNER JOIN
                            (SELECT
                        	    NameEN
                            FROM
                                M0001_Name 
                            WHERE 
								InActive = 0
                                AND Group2 = 1) N1
                        ON
                            N.NameEn = N1.NameEN
                        ORDER BY
                            N.NameEN";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@NameEN", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy dữ liệu từ bảng M0001_Name (có parammeter)
        public DataTable GetInfo_Name(string NameEN)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	 NameVN
                        	,NameJP
                        FROM
                        	M0001_Name
                        WHERE
                            NameEN = @NameEN";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@NameEN", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(NameEN);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy dữ liệu từ bảng M01_Classify (không có parameter)
        //nhập Classify
        public DataTable GetInfo_M01_Classify()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	 M01.ClassifyID
                        	,M01.ClassifyDesc
                        FROM
                        	M01_Classify M01
                        INNER JOIN
                        	(
                        		SELECT
                        			 ClassifyID
                        			,MAX(InputDate)  As  InputDate
                        		FROM
                        			M01_Classify
                        		GROUP BY
                        			ClassifyID
                        	) M01_MAX
                        ON	M01.ClassifyID	=	M01_MAX.ClassifyID
                        AND	M01.InputDate	=	M01_MAX.InputDate
                        ORDER BY
                            M01.ClassifyID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ClassifyID", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy dữ liệu từ bảng M01_Classify (có parammeter)
        //từ ClassifyID -> lấy thông tin diễn giải Classify
        public DataTable GetInfo_M01_ClassifyD(int ClassifyID)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	ClassifyDesc
                        FROM
                        	M01_Classify
                        WHERE
                            ClassifyID = @ClassifyID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ClassifyID", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToString(ClassifyID);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Load dữ liệu từ table M0002
        public DataTable GetInfo_M0002_LK()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
	                         NameEN
	                        ,NameVN
	                        ,NameJP
	                        ,Max(ApplyDate)
                        FROM 
	                        M0002_GroupName
                        WHERE 
                                ClassifyID in (1,3)
                            and InActive = 0
                        GROUP BY
                        	 NameEN
	                        ,NameVN
	                        ,NameJP";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@NameEN", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
    }
}
