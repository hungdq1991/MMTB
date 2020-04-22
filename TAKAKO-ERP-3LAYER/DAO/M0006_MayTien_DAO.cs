using System;
using System.Data;
using System.Data.SqlClient;

namespace MMTB.DAO
{
    public class M0006_MayTien_DAO
    {
        private DBConnection conn;
        /// <constructor>
        /// Constructor M0006_MayTien_DAO
        /// </constructor>
        public M0006_MayTien_DAO()
        {
            conn = new DBConnection();
        }
        //Load dữ liệu trên Form_M0006 gridView2
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
                              ,M.Turret_TipQty
                              ,M.Horizontal_TipQty
                              ,M.Tailstock
                              ,M.AxisC
                              ,M.InActive
                              ,M.InputDate
                              ,M.InputUser
                              ,M.ModifyDate
                              ,M.ModifyUser
                        FROM 
	                        M0006_TechMMTB_T M
                        JOIN    
                            M0002_GroupName N
                        ON
                            M.NameEN = N.NameEN
                        WHERE 
                            M.InActive = 0
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
                           int Turret_TipQty,
                           int Horizontal_TipQty,
                           int Tailstock,
                           int AxisC,
                           int InActive,
                           string _userName)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"INSERT INTO [M0006_TechMMTB_T]
                            ([Code]
                            ,[ACCCode]
                            ,[NameEN]
                            ,[NameVN]
                            ,[NameJP]
                            ,[Maker]
                            ,[Model]
                            ,[Turret_TipQty]
                            ,[Horizontal_TipQty]
                            ,[Tailstock]
                            ,[AxisC]
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
                            ,@Turret_TipQty
                            ,@Horizontal_TipQty
                            ,@Tailstock
                            ,@AxisC
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
            SqlParameter[] sqlParameters = new SqlParameter[13];
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
            sqlParameters[7] = new SqlParameter("@Turret_TipQty", SqlDbType.Int);
            sqlParameters[7].Value = Convert.ToInt32(Turret_TipQty);
            sqlParameters[8] = new SqlParameter("@Horizontal_TipQty", SqlDbType.Int);
            sqlParameters[8].Value = Convert.ToInt32(Horizontal_TipQty);
            sqlParameters[9] = new SqlParameter("@Tailstock", SqlDbType.Int);
            sqlParameters[9].Value = Convert.ToInt32(Tailstock);
            sqlParameters[10] = new SqlParameter("@AxisC", SqlDbType.Int);
            sqlParameters[10].Value = Convert.ToInt32(AxisC);
            sqlParameters[11] = new SqlParameter("@InActive", SqlDbType.Int);
            sqlParameters[11].Value = Convert.ToInt32(InActive);
            sqlParameters[12] = new SqlParameter("@InputUser", SqlDbType.Text);
            sqlParameters[12].Value = Convert.ToString(_userName);

            return conn.executeInsertQuery(StrQuery, sqlParameters);
        }
        #endregion
        //Tạo class Update
        #region
        public bool Update(
                           string Code,
                           //int Turret_TipQty,
                           //int Horizontal_TipQty,
                           //int Tailstock,
                           //int AxisC,
                           //int InActive,
                           string _userName)

        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"UPDATE  dbo.M0006_TechMMTB_T
                            SET  
                                 InActive   = 1
                                ,ModifyDate = GETDATE()
                                ,ModifyUser = @InputUser
                            WHERE 
                                 Code               = @Code";
                                //,Turret_TipQty = @Turret_TipQty
                                //,Horizontal_TipQty = @Horizontal_TipQty
                                //,Tailstock = @Tailstock
                                //,AxisC = @AxisC

            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@Code", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(Code);
            //sqlParameters[1] = new SqlParameter("@Turret_TipQty", SqlDbType.Int);
            //sqlParameters[1].Value = Convert.ToInt32(Turret_TipQty);
            //sqlParameters[2] = new SqlParameter("@Horizontal_TipQty", SqlDbType.Int);
            //sqlParameters[2].Value = Convert.ToInt32(Horizontal_TipQty);
            //sqlParameters[3] = new SqlParameter("@Tailstock", SqlDbType.Int);
            //sqlParameters[3].Value = Convert.ToInt32(Tailstock);
            //sqlParameters[4] = new SqlParameter("@AxisC", SqlDbType.Int);
            //sqlParameters[4].Value = Convert.ToInt32(AxisC);
            //sqlParameters[5] = new SqlParameter("@InActive", SqlDbType.Int);
            //sqlParameters[5].Value = Convert.ToInt32(InActive);
            sqlParameters[1] = new SqlParameter("@InputUser", SqlDbType.Text);
            sqlParameters[1].Value = Convert.ToString(_userName);

            return conn.executeUpdateQuery(StrQuery, sqlParameters);
        }
        #endregion
        //Tạo class Check
        #region
        public DataTable GetInfo_M0006_Check(
                           string Code,
                           int Turret_TipQty,
                           int Horizontal_TipQty,
                           int Tailstock,
                           int AxisC)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	Code                       
                        FROM
                        	M0006_TechMMTB_T
                        WHERE 
                            (       Code               = @Code
                                and Turret_TipQty      = @Turret_TipQty
                                and Horizontal_TipQty  = @Horizontal_TipQty
                                and Tailstock          = @Tailstock
                                and AxisC              = @AxisC
                            )";

            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@Code", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(Code);
            sqlParameters[1] = new SqlParameter("@Turret_TipQty", SqlDbType.Int);
            sqlParameters[1].Value = Convert.ToInt32(Turret_TipQty);
            sqlParameters[2] = new SqlParameter("@Horizontal_TipQty", SqlDbType.Int);
            sqlParameters[2].Value = Convert.ToInt32(Horizontal_TipQty);
            sqlParameters[3] = new SqlParameter("@Tailstock", SqlDbType.Int);
            sqlParameters[3].Value = Convert.ToInt32(Tailstock);
            sqlParameters[4] = new SqlParameter("@AxisC", SqlDbType.Int);
            sqlParameters[4].Value = Convert.ToInt32(AxisC);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        #endregion
        //Lấy thông tin máy tiện load trên Form_M0006_Detail
        #region
        public DataTable GetInfo_Code(string Code)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	Code
                           ,Turret_TipQty
                           ,Horizontal_TipQty
                           ,Tailstock
                           ,AxisC
                           ,InActive
                        FROM
                            M0006_TechMMTB_T
                        WHERE
                            InActive = 0
                        and Code = @Code
                        ORDER BY
                        	Code
                           ,Turret_TipQty
                           ,Horizontal_TipQty
                           ,Tailstock
                           ,AxisC
                           ,InActive";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Code", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(Code);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
    }
    #endregion
}