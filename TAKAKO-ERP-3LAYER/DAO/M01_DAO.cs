using System;
using System.Data;
using System.Data.SqlClient;

namespace MMTB.DAO
{
    public class M01_DAO
    {
        private DBConnection conn;
        /// <constructor>
        /// Constructor M01_DAO
        /// </constructor>
        public M01_DAO()
        {
            conn = new DBConnection();
        }

        //Lấy thông tin trên gridControl
        public DataTable GetInfo_M01()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	 R.DocNo
                            ,D.DocDate
                            ,D.ControlDept
                            ,D.DocStatus
                            ,D.ReqMemo
                            ,D.UserName
                            ,R.[Check]
                            ,CASE WHEN R.Program IS NULL THEN '' ELSE R.Program END AS Program
                            ,CASE WHEN R.ProgramDesc IS NULL THEN '' ELSE R.ProgramDesc END AS ProgramDesc
                            ,R.ReqType
                            ,R.ReqDesc
                            ,R.Reason
                            ,R.Urgent
                            ,CASE WHEN R.Memo IS NULL THEN '' ELSE R.Memo END AS Memo
                            ,CASE WHEN D.ConfUser IS NULL THEN '' ELSE D.ConfUser END AS ConfUser 
                            ,D.ConfDate
                            ,CASE WHEN R.ITConfirm IS NULL THEN '' ELSE R.ITConfirm END AS ITConfirm 
                            ,R.ITConfDate
                            ,CASE WHEN R.ITMemo IS NULL THEN '' ELSE R.ITMemo END AS ITMemo          
                            ,R.Column1
                            ,R.Column2
                            ,R.Column3
                            ,R.Column4
                            ,R.Column5
                        FROM
                        	M01_Request R
                        JOIN
                            M01_Request_Doc D
                        ON
                            R.DocNo = D.DocNo
                        ORDER BY DocNo DESC";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DocNo", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy thông tin trên gridControl để lọc thông tin
        public DataTable GetInfo_M01_Filter()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                        	 R.DocNo
                            ,D.DocDate
                            ,D.ControlDept
                            ,D.DocStatus
                            ,D.ReqMemo
                            ,D.UserName
                            ,R.[Check]
                            ,R.Program
                            ,R.ProgramDesc
                            ,R.ReqType
                            ,R.ReqDesc
                            ,R.Reason
                            ,R.Urgent
                            ,R.Memo
                            ,D.ConfUser
                            ,D.ConfDate
                            ,R.ITConfirm
                            ,R.ITConfDate
                            ,R.ITMemo
                            ,R.Column1
                            ,R.Column2
                            ,R.Column3
                            ,R.Column4
                            ,R.Column5
                        FROM
                        	M01_Request R
                        JOIN
                            M01_Request_Doc D
                        ON
                            R.DocNo = D.DocNo
                        ORDER BY DocNo DESC";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DocNo", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy dữ liệu số chứng từ trên Form_M01_Detail
        public DataTable GetInfo_M01_DocNo()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"	SELECT 
                                 DocNo
		                        ,DocDate
                                ,ControlDept
                                ,DocStatus
                                ,ConfDate
                                ,ReqMemo
	                        FROM 
		                        M01_Request_Doc
                            ORDER BY
                                DocNo DESC";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DocNo", SqlDbType.Text);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }

        //Lấy dữ liệu lên Form_M01_Detail_NT khi có số chứng từ
        public DataTable GetInfo_M01_Header(string DocNo)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();
            StrQuery = @"SELECT 
                             DocNo
		                    ,DocDate
                            ,ControlDept
                            ,DocStatus
                            ,ReqMemo
                            ,UserName
                            ,CASE WHEN ConfUser IS NULL THEN '' ELSE ConfUser END AS ConfUser
                            ,CASE WHEN ITConf IS NULL THEN '' ELSE ITConf END AS ITConf
                        FROM 
                            M01_Request_Doc
                        WHERE 
                            DocNo = @DocNo";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DocNo", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(DocNo);
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }

        //Lấy dữ liệu lên Form_M01_Detail_NT khi có số chứng từ
        public DataTable GetInfo_M01_Detail(string DocNo)
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                             R.DocNo
                            ,R.[Check]
                            ,R.Program
                            ,R.ProgramDesc
                            ,R.ReqType
                            ,R.ReqDesc
                            ,R.Reason
                            ,R.Urgent
                            ,R.Memo
                            ,D.ConfUser
                            ,D.ConfDate
                            ,R.ITConfirm
                            ,R.ITConfDate
                            ,R.ITMemo
                        FROM 
		                    M01_Request R
                        JOIN
                            M01_Request_Doc D
                        ON
                            R.DocNo = D.DocNo
                        WHERE 
                            R.DocNo = @DocNo";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DocNo", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(DocNo);
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy thông tin bộ phận
        public DataTable GetInfo_ControlDept()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                             RTRIM([SectionID])   As SectionID
                            ,[SectionName]
                        FROM
                            [SOLOMON-SERVER].[TVCAPP].[dbo].[xt_XFASection]";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Dept", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }

        //Lấy thông tin Mã, tên chương trình
        public DataTable GetInfo_M01_Program()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT
                             Program
                            ,ProgramDesc
                        FROM
                            M01_Program
                        ORDER BY
                            Program";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Program", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Nhập danh sách yêu cầu
        public string Insert_Request(DataTable _listRequest, DataTable _listDelete, DataTable _listRequestDoc)
        {
            return conn.Insert_Request(_listRequest, _listDelete, _listRequestDoc);
        }
        //Xác nhận danh sách yêu cầu
        public bool Confirm_Request(DataTable _listRequest, DataTable _listDelete, DataTable _listRequestDoc)
        {
            return conn.Confirm_Request(_listRequest, _listDelete, _listRequestDoc);
        }
        //Nhập và xác nhận danh sách yêu cầu
        public string Insert_Confirm_Request(DataTable _listRequest, DataTable _listRequestDoc)
        {
            return conn.Insert_Confirm_Request(_listRequest, _listRequestDoc);
        }
        //Cập nhật danh sách yêu cầu (IT xác nhận)
        public bool Confirm_Request_IT(DataTable _listRequest, DataTable _listRequestDoc)
        {
            return conn.Confirm_Request_IT(_listRequest, _listRequestDoc);
        }

        //Thông tin IT
        //Lấy thông tin Email, ĐT
        public DataTable GetInfo_M01_TelEmail()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
                           MSNV
                          ,Name
	                      ,CASE WHEN H.DepartID IS NULL THEN 'OTHER' ELSE H.DepartID END AS DepartID
	                      ,CASE WHEN H.PositionID IS NULL THEN 'OTHER' ELSE H.PositionID END AS PositionID
                          ,E.Phone
                          ,IntPhone
                          ,HandPhone
                          ,E.Email
                          ,Memo
                          ,ApplyDate
                          ,InActiveIntPhone
	                      ,InActiveEmail                       
                          ,PwEmail
	                      ,CASE WHEN H.Status = 'I' THEN 'X' ELSE '' END AS Status
                      FROM [M01_TelEmail] E
                      LEFT JOIN [hr-server1].[TAKHRAPP].[dbo].[xt_HREmployee] H
                      ON E.MSNV = H.EmployeeID
                      WHERE E.InActiveIntPhone = 0 AND E.InActiveEmail = 0
                      ORDER BY DepartID, PositionID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MSNV", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy thông tin MSNV
        public DataTable GetInfo_M01_MSNV()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
                           EmployeeID
                          ,Name00
                      FROM [hr-server1].[TAKHRAPP].[dbo].[xt_HREmployee]
                      WHERE Status = 'A'
                      AND EmployeeID NOT IN (SELECT MSNV
                                             FROM M01_TelEmail)";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@EmployeeID", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Lấy thông tin MSNV cần InActie
        public DataTable GetInfo_M01_MSNV_Stop()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
                           MSNV
                          ,Name
                      FROM M01_TelEmail
                      WHERE Status = X AND ( InActiveIntPhone = 0 OR InActiveEmail = 0)";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MSNV", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
        //Nhập và xác nhận danh sách yêu cầu
        public bool Insert_TelEmail(DataTable _listTelEmail)
        {
            return conn.Insert_TelEmail(_listTelEmail);
        }
        //Cập nhật danh sách yêu cầu (IT xác nhận)
        public bool InActive_TelEmail(DataTable _listTelEmail)
        {
            return conn.InActive_TelEmail(_listTelEmail);
        }
        //Quản lý group email
        //Lấy thông tin Email, ĐT
        public DataTable GetInfo_M01_GroupEmail()
        {
            string StrQuery = "";
            DataTable _tempDataTable = new DataTable();

            StrQuery = @"SELECT 
                           GroupEmail
                          ,Memo
                          ,MSNV
                          ,Name
	                      ,CASE WHEN H.DepartID IS NULL THEN '' ELSE H.DepartID END AS DepartID
	                      ,CASE WHEN H.PositionID IS NULL THEN '' ELSE H.PositionID END AS PositionID
                          ,E.Email
                          ,Memo
                          ,ApplyDate
	                      ,InActive                    
                          ,PwEmail
	                      ,CASE WHEN H.Status = 'I' THEN 'X' ELSE '' END AS Status
                      FROM [M01_GroupEmail] E
                      LEFT JOIN [hr-server1].[TAKHRAPP].[dbo].[xt_HREmployee] H
                      ON E.MSNV = H.EmployeeID
                      WHERE E.InActive = 0
                      ORDER BY GroupEmail, DepartID, PositionID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MSNV", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString("");
            return conn.executeSelectQuery(StrQuery, sqlParameters);
        }
    }
}