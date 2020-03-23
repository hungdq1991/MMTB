using System;
using System.Data;
using System.Data.SqlClient;

namespace TAKAKO_ERP_3LAYER.DAO
{
    public class M0004_DAO
    {
        private DBConnection conn;
        /// <constructor>
        /// Constructor M0004_DAO
        /// </constructor>
        public M0004_DAO()
        {
            conn = new DBConnection();
        }
        //Load dữ liệu
        public DataTable GetInfo_M0004()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
	                         M.NameEN
	                        ,M.NameVN
	                        ,M.NameJP
                            ,N.Group1
                            ,N.Group2
	                        ,M.Maker
	                        ,M.Model
	                        ,M.InActive
                            ,M.Memo
	                        ,M.InputDate
	                        ,M.InputUser
	                        ,M.ModifyDate
	                        ,M.ModifyUser
	                        ,M.Column1
	                        ,M.Column2
	                        ,M.Column3
	                        ,M.Column4
	                        ,M.Column5
							,MAX(N.ApplyDate)
                        FROM 
	                        M0004_MakerModel M
                        JOIN
                            M0002_GroupName N 
                            ON M.NameEN = n.NameEN
						GROUP BY
							 M.NameEN
	                        ,M.NameVN
	                        ,M.NameJP
                            ,N.Group1
                            ,N.Group2
	                        ,M.Maker
	                        ,M.Model
                            ,M.InActive
                            ,M.Memo
	                        ,M.InputDate
	                        ,M.InputUser
	                        ,M.ModifyDate
	                        ,M.ModifyUser
	                        ,M.Column1
	                        ,M.Column2
	                        ,M.Column3
	                        ,M.Column4
	                        ,M.Column5";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@NameEN", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Tạo class Insert
        public bool Insert(
                           string NameEN,
                           string NameVN,
                           string NameJP,
                           string Maker,
                           string Model,
                           int InActive,
                           string Memo,
                           string _userName)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"INSERT INTO [M0004_MakerModel]
                            ([NameEN]
                            ,[NameVN]
                            ,[NameJP]
                            ,[Maker]
                            ,[Model]
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
                            (@NameEN
                            ,@NameVN
                            ,@NameJP
                            ,@Maker
                            ,@Model
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
            SqlParameter[] sqlParameters = new SqlParameter[8];
            sqlParameters[0] = new SqlParameter("@NameEN", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(NameEN);
            sqlParameters[1] = new SqlParameter("@NameVN", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(NameVN);
            sqlParameters[2] = new SqlParameter("@NameJP", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(NameJP);
            sqlParameters[3] = new SqlParameter("@Maker", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(Maker);
            sqlParameters[4] = new SqlParameter("@Model", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(Model);
            sqlParameters[5] = new SqlParameter("@InActive", SqlDbType.Bit);
            sqlParameters[5].Value = Convert.ToByte(InActive);
            sqlParameters[6] = new SqlParameter("@Memo", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(Memo);
            sqlParameters[7] = new SqlParameter("@InputUser", SqlDbType.Text);
            sqlParameters[7].Value = Convert.ToString(_userName);

            return conn.executeInsertQuery(StrQuery, sqlParameters);
        }
        //Tạo class Update
        public bool Update(string NameEN,
                           string Maker,
                           string Model,
                           int InActive,
                           string Memo,
                           string _userName)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"UPDATE  dbo.M0004_MakerModel
                            SET  
                                 InActive   = @InActive
                                ,ModifyDate = GETDATE()
                                ,ModifyUser = @InputUser
                                ,Memo       = @Memo
                            WHERE 
                                    NameEN  = @NameEN
                                and Maker   = @Maker
                                and Model   = @Model
                                    ";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@NameEN", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(NameEN);
            sqlParameters[1] = new SqlParameter("@Maker", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(Maker);
            sqlParameters[2] = new SqlParameter("@Model", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(Model);
            sqlParameters[3] = new SqlParameter("@InActive", SqlDbType.Int);
            sqlParameters[3].Value = Convert.ToInt32(InActive);
            sqlParameters[4] = new SqlParameter("@Memo", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(Memo);
            sqlParameters[5] = new SqlParameter("@InputUser", SqlDbType.Text);
            sqlParameters[5].Value = Convert.ToString(_userName);

            return conn.executeUpdateQuery(StrQuery, sqlParameters);
        }
        //Tạo class Delete
        public bool Delete(string NameEN,
                           string Maker,
                           string Model)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"DELETE FROM [dbo].[M0004_MakerModel]
                            WHERE NameEN = @NameEN and Maker = @Maker and Model = @Model";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@NameEN", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(NameEN);
            sqlParameters[1] = new SqlParameter("@Maker", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(Maker);
            sqlParameters[2] = new SqlParameter("@Model", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(Model);

            return conn.executeDeleteQuery(StrQuery, sqlParameters);
        }
        //Tạo class Check
        public DataTable GetInfo_M0004_Check(string NameEN,
                                             string Maker,
                                             string Model)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	NameEN,                        
                            Maker,
                            Model
                        FROM
                        	M0004_MakerModel
                        WHERE 
                            (   NameEN  = @NameEN
                            and Maker   = @Maker
                            and Model   = @Model
                            )";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@NameEN", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(NameEN);
            sqlParameters[1] = new SqlParameter("@Maker", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(Maker);
            sqlParameters[2] = new SqlParameter("@Model", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(Model);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy dữ liệu từ bảng M0001_Name (không có parammeter)
        //nhập tên NameEN
        public DataTable GetInfo_M0001_Name()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	NameEN,
                            NameVN,
                            NameJP
                        FROM
                            M0001_Name
                        WHERE
                            InActive = 0
                        and Name = 1
                        ORDER BY
                            NameEN,
                            NameVN,
                            NameJP";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@NameEN", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy dữ liệu từ bảng M0001_Name (có parammeter)
        //lấy tên NameVN, NameJP
        public DataTable GetInfo_Name(string NameEN)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                            NameVN,
                            NameJP
                        FROM
                            M0001_Name
                        WHERE
                            Name = 1
                        and InActive = 0
                        and NameEN = @NameEN";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@NameEN", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(NameEN);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        public DataTable GetInfo_Maker()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                             NameEN
                            ,NameVN
                            ,NameJP
                            ,Maker
                            ,Model
                        FROM
                            M0004_MakerModel";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@NameEN", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        public DataTable GetInfo_NationMF()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	 NATION_CODE
                            ,NATION_NAME
                        FROM
                            [Takako_1].[dbo].[NATIONMF]";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Nation", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        public DataTable GetInfo_ProgressGroup()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                             ProcessGroup
                            ,ProcessEN
                            ,ProcessVN
                            ,ProcessJP
                            ,Point
                            ,ApplyDate
                        FROM
                            M0003_ProcessGroup";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ProgressGroup", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
    }
}
