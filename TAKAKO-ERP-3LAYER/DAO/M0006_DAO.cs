using System;
using System.Data;
using System.Data.SqlClient;

namespace MMTB.DAO
{
    public class M0006_DAO
    {
        private DBConnection conn;
        /// <constructor>
        /// Constructor M0006_DAO
        /// </constructor>
        public M0006_DAO()
        {
            conn = new DBConnection();
        }
        //Load dữ liệu trên Form_M0006 gridView
        public DataTable GetInfo_M0006()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
	                         M.Code
                            ,M.ACCcode
                            ,M.NameEN
                            ,M.NameVN
                            ,M.NameJP
                            ,M.Maker
                            ,M.Model
                            ,N.Group1
                            ,N.Group2
                            ,M.Level
                            ,M.SizeL
                            ,M.SizeW
                            ,M.SizeH
                            ,M.Chuck3Jaw
                            ,M.Collet1
                            ,M.Collet2
                            ,M.Collet3
                            ,M.Voltage
                            ,M.OperatingSys
                            ,M.Wattage_KVA
                            ,M.ApplyDate
                            ,M.InActive
                            ,M.InputDate
                            ,M.InputUser
                            ,M.ModifyDate
                            ,M.ModifyUser
                        FROM 
	                        M0006_TechMMTB M
                        JOIN    
                            M0002_GroupName N
                        ON
                            M.NameEN = N.NameEN
                        INNER JOIN 
						(SELECT 
                            Code, 
                            Max(ApplyDate) ApplyDate 
                        FROM 
                            M0006_TechMMTB 
                        GROUP BY 
                            Code) A
						ON M.Code = A.Code
						AND M.ApplyDate = A.ApplyDate
                        AND M.InActive = 0
                        ORDER BY
                           M.Code";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Code", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Tạo class Insert
        #region
        public bool Insert(
                           string Code,
                           string ACCCode,
                           string NameEN,
                           string NameVN,
                           string NameJP,
                           string Maker,
                           string Model,
                           int Level,
                           int SizeL,
                           int SizeW,
                           int SizeH,
                           string Chuck3Jaw,
                           string Collet1,
                           string Collet2,
                           string Collet3,
                           string Voltage,
                           string OperatingSys,
                           decimal Wattage_KVA,
                           int InActive,
                           string _userName)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"INSERT INTO [M0006_TechMMTB]
                            ([Code]
                            ,[ACCCode]
                            ,[NameEN]
                            ,[NameVN]
                            ,[NameJP]
                            ,[Maker]
                            ,[Model]
                            ,[Level]
                            ,[SizeL]
                            ,[SizeW]
                            ,[SizeH]
                            ,[Chuck3Jaw]
                            ,[Collet1]
                            ,[Collet2]
                            ,[Collet3]
                            ,[Voltage]
                            ,[OperatingSys]
                            ,[Wattage_KVA]
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
                            (@Code
                            ,@ACCCode
                            ,@NameEN
                            ,@NameVN
                            ,@NameJP
                            ,@Maker
                            ,@Model
                            ,@Level
                            ,@SizeL
                            ,@SizeW
                            ,@SizeH
                            ,@Chuck3Jaw
                            ,@Collet1
                            ,@Collet2
                            ,@Collet3
                            ,@Voltage
                            ,@OperatingSys
                            ,@Wattage_KVA
                            ,GETDATE()
                            ,0
                            ,GETDATE()
                            ,@InputUser
                            ,NULL
                            ,NULL
                            ,NULL
                            ,NULL
                            ,NULL
                            ,NULL
                            ,NULL)";
            SqlParameter[] sqlParameters = new SqlParameter[19];
            sqlParameters[0] = new SqlParameter("@Code", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(Code);
            sqlParameters[1] = new SqlParameter("@ACCCode", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(ACCCode);
            sqlParameters[2] = new SqlParameter("@NameEN", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(NameEN);
            sqlParameters[3] = new SqlParameter("@NameVN", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(NameVN);
            sqlParameters[4] = new SqlParameter("@NameJP", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(NameJP);
            sqlParameters[5] = new SqlParameter("@Maker", SqlDbType.NVarChar);
            sqlParameters[5].Value = Convert.ToString(Maker);
            sqlParameters[6] = new SqlParameter("@Model", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(Model);
            sqlParameters[7] = new SqlParameter("@Level", SqlDbType.Int);
            sqlParameters[7].Value = Convert.ToInt32(Level);
            sqlParameters[8] = new SqlParameter("@SizeL", SqlDbType.Int);
            sqlParameters[8].Value = Convert.ToInt32(SizeL);
            sqlParameters[9] = new SqlParameter("@SizeW", SqlDbType.Int);
            sqlParameters[9].Value = Convert.ToInt32(SizeW);
            sqlParameters[10] = new SqlParameter("@SizeH", SqlDbType.Int);
            sqlParameters[10].Value = Convert.ToInt32(SizeH);
            sqlParameters[11] = new SqlParameter("@Chuck3Jaw", SqlDbType.NVarChar);
            sqlParameters[11].Value = Convert.ToString(Chuck3Jaw);
            sqlParameters[12] = new SqlParameter("@Collet1", SqlDbType.NVarChar);
            sqlParameters[12].Value = Convert.ToString(Collet1);
            sqlParameters[13] = new SqlParameter("@Collet2", SqlDbType.NVarChar);
            sqlParameters[13].Value = Convert.ToString(Collet2);
            sqlParameters[14] = new SqlParameter("@Collet3", SqlDbType.NVarChar);
            sqlParameters[14].Value = Convert.ToString(Collet3);
            sqlParameters[15] = new SqlParameter("@Voltage", SqlDbType.NVarChar);
            sqlParameters[15].Value = Convert.ToString(Voltage);
            sqlParameters[16] = new SqlParameter("@OperatingSys", SqlDbType.NVarChar);
            sqlParameters[16].Value = Convert.ToString(OperatingSys);
            sqlParameters[17] = new SqlParameter("@Wattage_KVA", SqlDbType.Decimal);
            sqlParameters[17].Value = Convert.ToDecimal(Wattage_KVA);
            sqlParameters[18] = new SqlParameter("@InputUser", SqlDbType.Text);
            sqlParameters[18].Value = Convert.ToString(_userName);

            return conn.executeInsertQuery(StrQuery, sqlParameters);
        }
        #endregion
        //Tạo class UpDate
        #region
        public bool Update(
                           string Code,
                           string _userName)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"UPDATE
                        	M0006_TechMMTB
                        SET
                             InActive = 1
                            ,ModifyDate = GETDATE()
                            ,ModifyUser = @InputUser
                        WHERE 
                            Code = @Code";

            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@Code", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(Code);
            sqlParameters[1] = new SqlParameter("@InputUser", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(_userName);

            return conn.executeUpdateQuery(StrQuery, sqlParameters);
        }
        #endregion
        //Tạo class Check
        #region
        public DataTable GetInfo_M0006_Check(
                           string Code,
                           int Level,
                           int SizeL,
                           int SizeW,
                           int SizeH,
                           string Chuck3Jaw,
                           string Collet1,
                           string Collet2,
                           string Collet3,
                           string Voltage,
                           string OperatingSys,
                           decimal Wattage_KVA)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	Code                        
                        FROM
                        	M0006_TechMMTB
                        WHERE 
                            (       Code           = @Code
                                and Level          = @Level
                                and SizeL          = @SizeL
                                and SizeW          = @SizeW
                                and SizeH          = @SizeH
                                and Chuck3Jaw      = @Chuck3Jaw
                                and Collet1        = @Collet1
                                and Collet2        = @Collet2
                                and Collet3        = @Collet3
                                and Voltage        = @Voltage
                                and OperatingSys   = @OperatingSys
                                and Wattage_KVA    = @Wattage_KVA
                            )";

            SqlParameter[] sqlParameters = new SqlParameter[12];
            sqlParameters[0] = new SqlParameter("@Code", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(Code);
            sqlParameters[1] = new SqlParameter("@Level", SqlDbType.Int);
            sqlParameters[1].Value = Convert.ToInt32(Level);
            sqlParameters[2] = new SqlParameter("@SizeL", SqlDbType.Int);
            sqlParameters[2].Value = Convert.ToInt32(SizeL);
            sqlParameters[3] = new SqlParameter("@SizeW", SqlDbType.Int);
            sqlParameters[3].Value = Convert.ToInt32(SizeW);
            sqlParameters[4] = new SqlParameter("@SizeH", SqlDbType.Int);
            sqlParameters[4].Value = Convert.ToInt32(SizeH);
            sqlParameters[5] = new SqlParameter("@Chuck3Jaw", SqlDbType.NVarChar);
            sqlParameters[5].Value = Convert.ToString(Chuck3Jaw);
            sqlParameters[6] = new SqlParameter("@Collet1", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(Collet1);
            sqlParameters[7] = new SqlParameter("@Collet2", SqlDbType.NVarChar);
            sqlParameters[7].Value = Convert.ToString(Collet2);
            sqlParameters[8] = new SqlParameter("@Collet3", SqlDbType.NVarChar);
            sqlParameters[8].Value = Convert.ToString(Collet3);
            sqlParameters[9] = new SqlParameter("@Voltage", SqlDbType.NVarChar);
            sqlParameters[9].Value = Convert.ToString(Voltage);
            sqlParameters[10] = new SqlParameter("@OperatingSys", SqlDbType.NVarChar);
            sqlParameters[10].Value = Convert.ToString(OperatingSys);
            sqlParameters[11] = new SqlParameter("@Wattage_KVA", SqlDbType.Decimal);
            sqlParameters[11].Value = Convert.ToDecimal(Wattage_KVA);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        #endregion
        //Lấy dữ liệu từ bảng M0005_ListMMTB (không có parammeter)
        //nhập mã MMTB trên Form_M0006_Detail
        public DataTable GetInfo_M0005_Code()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	 M.Code
                            ,M.ACCCode
                            ,M.NameEN
                            ,M.Maker
                            ,M.Model
                            ,N.Group2
                        FROM
                            M0005_ListMMTB M
                        JOIN
                            M0002_GroupName N
                        ON M.NameEN = N.NameEN
                        WHERE 
                            M.Code
                        NOT IN
                            (SELECT 
                                   Code
                             FROM M0006_TechMMTB)
                        OR M.Code = ''
                        ORDER BY
                        	 M.Code
                            ,M.ACCCode
                            ,M.NameEN
                            ,M.Maker
                            ,M.Model
                            ,N.Group2
                        ";
            
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Code", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy thông tin M0006_TechMMTB
        //thông tin mã MMTB trên Form_M0006_Detail khi double click gridView Form_M0006
        public DataTable GetInfo_M0006_Code()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	 M.Code
                            ,M.ACCCode
                            ,M.NameEN
                            ,M.Maker
                            ,M.Model
                            ,N.Group2
                        FROM
                            M0006_TechMMTB M
                        JOIN
                            M0002_GroupName N
                        ON M.NameEN = N.NameEN
                        ORDER BY
                        	 M.Code
                            ,M.ACCCode
                            ,M.NameEN
                            ,M.Maker
                            ,M.Model
                            ,N.Group2";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Code", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString("");

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy dữ liệu từ bảng M0005_ListMMTB (có parammeter)
        //load thông tin mã ACCCode, NameEN, Maker, Model trên Form_M0006_Detail
        public DataTable GetInfo_Code(string Code)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	 M.Code
                            ,M.ACCCode
                            ,M.NameEN
                            ,M.NameVN
                            ,M.NameJP
                            ,M.Maker
                            ,M.Model
                            ,N.Group2
                        FROM
                            M0005_ListMMTB M
                        JOIN
                            M0002_GroupName N
                        ON M.NameEN = N.NameEN
                        WHERE M.Code = @Code
                        ORDER BY
                        	 M.Code
                            ,M.ACCCode
                            ,M.NameEN
                            ,M.NameVN
                            ,M.NameJP
                            ,M.Maker
                            ,M.Model
                            ,N.Group2";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Code", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(Code);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy dữ liệu từ bảng M0006_TechMMTB (có parammeter)
        //load thông tin chung MMTB trên Form_M0006_Detail
        public DataTable GetInfo_M0006_Code(string Code)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	 M.Code
                            ,M.ACCCode
                            ,M.NameEN
                            ,M.NameVN
                            ,M.NameJP
                            ,M.Maker
                            ,M.Model
                            ,N.Group2
                            ,M.Level
                            ,M.SizeL
                            ,M.SizeW
                            ,M.SizeH
                            ,M.Chuck3Jaw
                            ,M.Collet1
                            ,M.Collet2
                            ,M.Collet3
                            ,M.Voltage
                            ,M.OperatingSys
                            ,M.Wattage_KVA
                            ,M.ApplyDate
                            ,M.InActive
                        FROM
                            M0006_TechMMTB M
                        JOIN
                            M0002_GroupName N
                        ON M.NameEN = N.NameEN
                        WHERE M.Code = @Code
                        ORDER BY
                        	 M.Code
                            ,M.ACCCode
                            ,M.NameEN
                            ,M.NameVN
                            ,M.NameJP
                            ,M.Maker
                            ,M.Model
                            ,N.Group2";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Code", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(Code);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
    }
}