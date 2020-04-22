using System;
using System.Data;
using System.Data.SqlClient;

namespace MMTB.DAO
{
    public class M0006_MayPhay_DAO
    {
        private DBConnection conn;
        /// <constructor>
        /// Constructor M0006_MayPhay_DAO
        /// </constructor>
        public M0006_MayPhay_DAO()
        {
            conn = new DBConnection();
        }
        //Load dữ liệu
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
                              ,M.TableLength_L
                              ,M.TableLength_W
                              ,M.Speed
                              ,M.BTSize
                              ,M.TipQty
                              ,M.WaterLine
                              ,M.AxisXYZ
                              ,M.AxisA
                              ,M.AxisB
                              ,M.AxisC_P
                              ,M.InActive
                              ,M.InputDate
                              ,M.InputUser
                              ,M.ModifyDate
                              ,M.ModifyUser
                        FROM 
	                        M0006_TechMMTB_P M
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
                           int TableLength_L,
                           int TableLength_W,
                           int Speed,
                           decimal BTSize,
                           int TipQty,
                           int WaterLine,
                           int AxisXYZ,
                           int AxisA,
                           int AxisB,
                           int AxisC_P,
                           int InActive_P,
                           string _userName)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"INSERT INTO [M0006_TechMMTB_P]
                            ([Code]
                            ,[ACCCode]
                            ,[NameEN]
                            ,[NameVN]
                            ,[NameJP]
                            ,[Maker]
                            ,[Model]
                            ,[TableLength_L]
                            ,[TableLength_W]
                            ,[Speed]
                            ,[BTSize]
                            ,[TipQty]
                            ,[WaterLine]
                            ,[AxisXYZ]
                            ,[AxisA]
                            ,[AxisB]
                            ,[AxisC_P]
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
                            ,@TableLength_L
                            ,@TableLength_W
                            ,@Speed
                            ,@BTSize
                            ,@TipQty
                            ,@WaterLine
                            ,@AxisXYZ
                            ,@AxisA
                            ,@AxisB
                            ,@AxisC_P
                            ,@InActive_P
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
            sqlParameters[7] = new SqlParameter("@TableLength_L", SqlDbType.Int);
            sqlParameters[7].Value = Convert.ToInt32(TableLength_L);
            sqlParameters[8] = new SqlParameter("@TableLength_W", SqlDbType.Int);
            sqlParameters[8].Value = Convert.ToInt32(TableLength_W);
            sqlParameters[9] = new SqlParameter("@Speed", SqlDbType.Int);
            sqlParameters[9].Value = Convert.ToInt32(Speed);
            sqlParameters[10] = new SqlParameter("@BTSize", SqlDbType.Decimal);
            sqlParameters[10].Value = Convert.ToDecimal(BTSize);
            sqlParameters[11] = new SqlParameter("@TipQty", SqlDbType.Int);
            sqlParameters[11].Value = Convert.ToInt32(TipQty);
            sqlParameters[12] = new SqlParameter("@WaterLine", SqlDbType.Int);
            sqlParameters[12].Value = Convert.ToInt32(WaterLine);
            sqlParameters[13] = new SqlParameter("@AxisXYZ", SqlDbType.Int);
            sqlParameters[13].Value = Convert.ToInt32(AxisXYZ);
            sqlParameters[14] = new SqlParameter("@AxisA", SqlDbType.Int);
            sqlParameters[14].Value = Convert.ToInt32(AxisA);
            sqlParameters[15] = new SqlParameter("@AxisB", SqlDbType.Int);
            sqlParameters[15].Value = Convert.ToInt32(AxisB);
            sqlParameters[16] = new SqlParameter("@AxisC_P", SqlDbType.Int);
            sqlParameters[16].Value = Convert.ToInt32(AxisC_P);
            sqlParameters[17] = new SqlParameter("@InActive_P", SqlDbType.Int);
            sqlParameters[17].Value = Convert.ToInt32(InActive_P);
            sqlParameters[18] = new SqlParameter("@InputUser", SqlDbType.Text);
            sqlParameters[18].Value = Convert.ToString(_userName);

            return conn.executeInsertQuery(StrQuery, sqlParameters);
        }
        #endregion
        //Tạo class Update
        #region
        public bool Update(
                           string Code,
                           //int TableLength_L,
                           //int TableLength_W,
                           //int Speed,
                           //int BTSize,
                           //int TipQty,
                           //int WaterLine,
                           //int AxisXYZ,
                           //int AxisA,
                           //int AxisB,
                           //int AxisC_P,
                           //int InActive,
                           string _userName)

        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"UPDATE  dbo.M0006_TechMMTB_P
                            SET  
                                 InActive   = 1
                                ,ModifyDate = GETDATE()
                                ,ModifyUser = @InputUser
                            WHERE 
                                 Code           = @Code";
                                //,TableLength_L = @TableLength_L
                                //,TableLength_W = @TableLength_W
                                //,Speed = @Speed
                                //,BTSize = @BTSize
                                //,TipQty = @TipQty
                                //,WaterLine = @WaterLine
                                //,AxisXYZ = @AxisXYZ
                                //,AxisA = @AxisA
                                //,AxisB = @AxisB
                                //,AxisC_P = @AxisC_P

            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@Code", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(Code);
            //sqlParameters[1] = new SqlParameter("@TableLength_L", SqlDbType.Int);
            //sqlParameters[1].Value = Convert.ToInt32(TableLength_L);
            //sqlParameters[2] = new SqlParameter("@TableLength_W", SqlDbType.Int);
            //sqlParameters[2].Value = Convert.ToInt32(TableLength_W);
            //sqlParameters[3] = new SqlParameter("@Speed", SqlDbType.Int);
            //sqlParameters[3].Value = Convert.ToInt32(Speed);
            //sqlParameters[4] = new SqlParameter("@BTSize", SqlDbType.Int);
            //sqlParameters[4].Value = Convert.ToInt32(BTSize);
            //sqlParameters[5] = new SqlParameter("@TipQty", SqlDbType.Int);
            //sqlParameters[5].Value = Convert.ToInt32(TipQty);
            //sqlParameters[6] = new SqlParameter("@WaterLine", SqlDbType.Int);
            //sqlParameters[6].Value = Convert.ToInt32(WaterLine);
            //sqlParameters[7] = new SqlParameter("@AxisXYZ", SqlDbType.Int);
            //sqlParameters[7].Value = Convert.ToInt32(AxisXYZ);
            //sqlParameters[8] = new SqlParameter("@AxisA", SqlDbType.Int);
            //sqlParameters[8].Value = Convert.ToInt32(AxisA);
            //sqlParameters[9] = new SqlParameter("@AxisB", SqlDbType.Int);
            //sqlParameters[9].Value = Convert.ToInt32(AxisB);
            //sqlParameters[10] = new SqlParameter("@AxisC_P", SqlDbType.Int);
            //sqlParameters[10].Value = Convert.ToInt32(AxisC_P);
            //sqlParameters[11] = new SqlParameter("@InActive", SqlDbType.Int);
            //sqlParameters[11].Value = Convert.ToInt32(InActive);
            sqlParameters[1] = new SqlParameter("@InputUser", SqlDbType.Text);
            sqlParameters[1].Value = Convert.ToString(_userName);

            return conn.executeUpdateQuery(StrQuery, sqlParameters);
        }
        #endregion
        //Tạo class Check
        #region
        public DataTable GetInfo_M0006_Check(
                           string Code,
                           int TableLength_L,
                           int TableLength_W,
                           int Speed,
                           decimal BTSize,
                           int TipQty,
                           int WaterLine,
                           int AxisXYZ,
                           int AxisA,
                           int AxisB,
                           int AxisC_P)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	Code                        
                        FROM
                        	M0006_TechMMTB_P
                        WHERE 
                            (       Code           = @Code
                                and TableLength_L  = @TableLength_L
                                and TableLength_W  = @TableLength_W
                                and Speed          = @Speed
                                and BTSize         = @BTSize
                                and TipQty         = @TipQty
                                and WaterLine      = @WaterLine
                                and AxisXYZ        = @AxisXYZ
                                and AxisA          = @AxisA
                                and AxisB          = @AxisB
                                and AxisC_P        = @AxisC_P
                            )";

            SqlParameter[] sqlParameters = new SqlParameter[11];
            sqlParameters[0] = new SqlParameter("@Code", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(Code);
            sqlParameters[1] = new SqlParameter("@TableLength_L", SqlDbType.Int);
            sqlParameters[1].Value = Convert.ToInt32(TableLength_L);
            sqlParameters[2] = new SqlParameter("@TableLength_W", SqlDbType.Int);
            sqlParameters[2].Value = Convert.ToInt32(TableLength_W);
            sqlParameters[3] = new SqlParameter("@Speed", SqlDbType.Int);
            sqlParameters[3].Value = Convert.ToInt32(Speed);
            sqlParameters[4] = new SqlParameter("@BTSize", SqlDbType.Decimal);
            sqlParameters[4].Value = Convert.ToDecimal(BTSize);
            sqlParameters[5] = new SqlParameter("@TipQty", SqlDbType.Int);
            sqlParameters[5].Value = Convert.ToInt32(TipQty);
            sqlParameters[6] = new SqlParameter("@WaterLine", SqlDbType.Int);
            sqlParameters[6].Value = Convert.ToInt32(WaterLine);
            sqlParameters[7] = new SqlParameter("@AxisXYZ", SqlDbType.Int);
            sqlParameters[7].Value = Convert.ToInt32(AxisXYZ);
            sqlParameters[8] = new SqlParameter("@AxisA", SqlDbType.Int);
            sqlParameters[8].Value = Convert.ToInt32(AxisA);
            sqlParameters[9] = new SqlParameter("@AxisB", SqlDbType.Int);
            sqlParameters[9].Value = Convert.ToInt32(AxisB);
            sqlParameters[10] = new SqlParameter("@AxisC_P", SqlDbType.Int);
            sqlParameters[10].Value = Convert.ToInt32(AxisC_P);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        #endregion
        //Lấy thông tin máy phay
        public DataTable GetInfo_Code(string Code)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	 Code
                            ,TableLength_L
                            ,TableLength_W
                            ,Speed
                            ,BTSize
                            ,TipQty
                            ,WaterLine
                            ,AxisXYZ
                            ,AxisA
                            ,AxisB
                            ,AxisC_P
                            ,InActive
                        FROM
                            M0006_TechMMTB_P
                        WHERE
                            InActive = 0
                        and Code = @Code
                        ORDER BY
                        	 Code
                            ,TableLength_L
                            ,TableLength_W
                            ,Speed
                            ,BTSize
                            ,TipQty
                            ,WaterLine
                            ,AxisXYZ
                            ,AxisA
                            ,AxisB
                            ,AxisC_P
                            ,InActive";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Code", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(Code);

            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
    }
}