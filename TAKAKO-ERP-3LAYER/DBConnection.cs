using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace MMTB
{
    public class DBConnection
    {
        private SqlDataAdapter myAdapter;
        private SqlConnection conn;
        /// <constructor>
        /// Initialise Connection
        /// </constructor>
        public DBConnection()
        {
            myAdapter = new SqlDataAdapter();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
        }

        /// <method>
        /// Open Database Connection if Closed or Broken
        /// </method>
        private SqlConnection openConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        /// <method>
        /// Select Query
        /// </method>
        public DataTable executeSelectQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            DataTable dataTable = new DataTable();
            dataTable = null;
            DataSet ds = new DataSet();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myCommand.ExecuteNonQuery();
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error - Connection.executeSelectQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return null;
            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }

        /// <method>
        /// Insert Query
        /// </method>
        public bool executeInsertQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            SqlTransaction transaction;                         //khai báo một transaction
            myCommand.Connection = openConnection();
            transaction = conn.BeginTransaction();              //bắt đầu quá trình quản lý transaction
            myCommand.CommandText = _query;
            myCommand.Parameters.AddRange(sqlParameter);
            myAdapter.InsertCommand = myCommand;
            myCommand.Transaction = transaction;                //gắn transaction

            try
            {
                myCommand.ExecuteNonQuery();
                transaction.Commit();                           //cam kết thực hiện thành công
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error - Connection.executeInsertQuery - Query: \n" + _query + " \nException: \n" + e.StackTrace.ToString());
                transaction.Rollback();                         //quay lùi
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
        /// <method>
        /// Update Query
        /// </method>
        public bool executeUpdateQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myAdapter.UpdateCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error - Connection.executeUpdateQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }

        /// <method>
        /// Delete Query
        /// </method>
        public bool executeDeleteQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myAdapter.DeleteCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error - Connection.executeUpdateQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
        /// <method>
        /// SP Insert MMTB_Nghiệm thu MMTB
        /// </method>
        public string Insert_MMTB(DataTable _listMMTB,DataTable _listDelete,DataTable _listMMTBDoc1)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_INSERT_MMTB", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            //Set timeout
            cmd.CommandTimeout = 300;

            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListMMTB", _listMMTB);    
            param = cmd.Parameters.AddWithValue("@tblList_Code_MMTB", _listDelete);
            param = cmd.Parameters.AddWithValue("@tblListMMTBDoc1", _listMMTBDoc1);

            var returnParameter = cmd.Parameters.Add("@DocNo", SqlDbType.NVarChar);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            string result = "";
            try
            {
                cmd.ExecuteNonQuery();
                result = Convert.ToString(returnParameter.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                //return false;
            }
            finally
            {
                // Close the SqlDataReader.
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            return result;
            //return true;
        }
        /// <method>
        /// SP Update MMTB_Xác nhận nghiệm thu MMTB
        /// </method>
        public bool Confirm_MMTB(DataTable _listMMTB, DataTable _listMMTBDoc1)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_CONFIRM_MMTB", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            //Set timeout
            cmd.CommandTimeout = 300;

            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListMMTB", _listMMTB);
            param = cmd.Parameters.AddWithValue("@tblListMMTBDoc1", _listMMTBDoc1);

            var returnParameter = cmd.Parameters.Add("@DocNo", SqlDbType.NVarChar);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            string result = "";
            try
            {
                cmd.ExecuteNonQuery();
                result = Convert.ToString(returnParameter.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;
            }
            finally
            {
                // Close the SqlDataReader.
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            //return result;
            return true;
        }
        /// <method>
        /// SP Insert & confirm MMTB_Nghiệm thu và xác nhận MMTB
        /// </method>
        public string Insert_Confirm_MMTB(DataTable _listMMTB, DataTable _listMMTBDoc1)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_INSERT_CONFIRM_MMTB", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            //Set timeout
            cmd.CommandTimeout = 300;

            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListMMTB", _listMMTB);
            param = cmd.Parameters.AddWithValue("@tblListMMTBDoc1", _listMMTBDoc1);

            var returnParameter = cmd.Parameters.Add("@DocNo", SqlDbType.NVarChar);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            string result = "";
            try
            {
                cmd.ExecuteNonQuery();
                result = Convert.ToString(returnParameter.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;
            }
            finally
            {
                // Close the SqlDataReader.
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            return result;
            //return true;
        }
        //Thanh lý MMTB_Chưa xác nhận
        public bool Disposal_MMTB(DataTable _listMMTB, DataTable _listMMTBDoc2)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_INSERT_DISPOSAL_MMTB_TEMP", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            //Set timeout
            cmd.CommandTimeout = 300;
            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListMMTB", _listMMTB);
            param = cmd.Parameters.AddWithValue("@tblListMMTBDoc2", _listMMTBDoc2);

            try
            {
                cmd.ExecuteNonQuery();
                //result = returnParameter.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // Close the SqlDataReader.
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            //return result;
            return true;
        }

        //Thanh lý MMTB_Xác nhận
        public bool Confirm_Disposal_MMTB(DataTable _listMMTB, DataTable _listMMTBDoc2)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_CONFIRM_DISPOSAL_MMTB", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            //Set timeout
            cmd.CommandTimeout = 300;
            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListMMTB", _listMMTB);
            param = cmd.Parameters.AddWithValue("@tblListMMTBDoc2", _listMMTBDoc2);

            try
            {
                cmd.ExecuteNonQuery();
                //result = returnParameter.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // Close the SqlDataReader.
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            //return result;
            return true;
        }
        //Thêm và xác nhận thanh lý MMTB
        public bool Insert_Confirm_Disposal_MMTB(DataTable _listMMTB, DataTable _listMMTBDoc2)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_INSERT_CONFIRM_DISPOSAL_MMTB", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            //Set timeout
            cmd.CommandTimeout = 300;
            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListMMTB", _listMMTB);
            param = cmd.Parameters.AddWithValue("@tblListMMTBDoc2", _listMMTBDoc2);

            try
            {
                cmd.ExecuteNonQuery();
                //result = returnParameter.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // Close the SqlDataReader.
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            //return result;
            return true;
        }
        //Di dời MMTB_Chưa xác nhận
        public bool Move_MMTB(DataTable _listMMTB, DataTable _listMMTBDoc3)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_INSERT_MOVE_MMTB_TEMP", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            //Set timeout
            cmd.CommandTimeout = 300;
            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListMMTB", _listMMTB);
            param = cmd.Parameters.AddWithValue("@tblListMMTBDoc3", _listMMTBDoc3);

            try
            {
                cmd.ExecuteNonQuery();
                //result = returnParameter.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // Close the SqlDataReader.
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            //return result;
            return true;
        }

        //Di dời MMTB_Xác nhận
        public bool Confirm_Move_MMTB(DataTable _listMMTB, DataTable _listMMTBDoc3)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_CONFIRM_MOVE_MMTB", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            //Set timeout
            cmd.CommandTimeout = 300;
            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListMMTB", _listMMTB);
            param = cmd.Parameters.AddWithValue("@tblListMMTBDoc3", _listMMTBDoc3);

            try
            {
                cmd.ExecuteNonQuery();
                //result = returnParameter.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // Close the SqlDataReader.
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            //return result;
            return true;
        }
        //Lưu và xác nhận di dời MMTB
        public bool Insert_Confirm_Move_MMTB(DataTable _listMMTB, DataTable _listMMTBDoc3)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_INSERT_CONFIRM_MOVE_MMTB", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            //Set timeout
            cmd.CommandTimeout = 300;
            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListMMTB", _listMMTB);
            param = cmd.Parameters.AddWithValue("@tblListMMTBDoc3", _listMMTBDoc3);

            try
            {
                cmd.ExecuteNonQuery();
                //result = returnParameter.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // Close the SqlDataReader.
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            //return result;
            return true;
        }
        //ACC bổ sung thông tin MMTB
        public bool ACC_Confirm_MMTB(DataTable _listMMTB)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_CONFIRM_MMTB_ACC", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            //Set timeout
            cmd.CommandTimeout = 300;

            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListMMTB", _listMMTB);

            try
            {
                cmd.ExecuteNonQuery();
                //result = returnParameter.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // Close the SqlDataReader.
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            //return result;
            return true;
        }

        //Bổ sung thông tin MMTB không sử dụng
        public string Insert_MMTB_No_Used(DataTable _listMMTB, DataTable _listDelete, DataTable _listMMTBDoc4)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_INSERT_NO_USED_MMTB", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            //Set timeout
            cmd.CommandTimeout = 300;

            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListMMTB", _listMMTB);
            param = cmd.Parameters.AddWithValue("@tblList_Code_MMTB", _listDelete);
            param = cmd.Parameters.AddWithValue("@tblListMMTBDoc4", _listMMTBDoc4);

            var returnParameter = cmd.Parameters.Add("@DocNo", SqlDbType.NVarChar);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            string result = "";
            try
            {
                cmd.ExecuteNonQuery();
                result = Convert.ToString(returnParameter.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;
            }
            finally
            {
                // Close the SqlDataReader.
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            return result;
            //return true;
        }
        //Xác nhận thông tin MMTB không sử dụng
        public bool Confirm_MMTB_No_Used(DataTable _listMMTB, DataTable _listDelete, DataTable _listMMTBDoc4)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_CONFIRM_NO_USED_MMTB", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            //Set timeout
            cmd.CommandTimeout = 300;

            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListMMTB", _listMMTB);
            param = cmd.Parameters.AddWithValue("@tblList_Code_MMTB", _listDelete);
            param = cmd.Parameters.AddWithValue("@tblListMMTBDoc4", _listMMTBDoc4);

            var returnParameter = cmd.Parameters.Add("@DocNo", SqlDbType.NVarChar);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            string result = "";
            try
            {
                cmd.ExecuteNonQuery();
                result = Convert.ToString(returnParameter.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;
            }
            finally
            {
                // Close the SqlDataReader.
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            //return result;
            return true;
        }
        //Thêm và xác nhận thông tin MMTB không sử dụng
        public string Insert_Confirm_MMTB_No_Used(DataTable _listMMTB, DataTable _listMMTBDoc4)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_INSERT_CONFIRM_NO_USED_MMTB", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            //Set timeout
            cmd.CommandTimeout = 300;

            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListMMTB", _listMMTB);
            param = cmd.Parameters.AddWithValue("@tblListMMTBDoc4", _listMMTBDoc4);

            var returnParameter = cmd.Parameters.Add("@DocNo", SqlDbType.NVarChar);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            string result = "";
            try
            {
                cmd.ExecuteNonQuery();
                result = Convert.ToString(returnParameter.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;
            }
            finally
            {
                // Close the SqlDataReader.
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            return result;
            //return true;
        }
        //Thêm danh mục LK, dầu, pin
        public bool Insert_Supply_MMTB(DataTable _listM0012)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_INSERT_SUPPLY_MMTB", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            //Set timeout
            cmd.CommandTimeout = 300;

            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListM0012", _listM0012);
            try
            {
                cmd.ExecuteNonQuery();
                //result = returnParameter.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // Close the SqlDataReader.
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            //return result;
            return true;
        }
        //Cập nhật Danh mục LK, dầu, pin
        public bool Update_Supply_MMTB(DataTable _listM0012)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_UPDATE_SUPPLY_MMTB", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            //Set timeout
            cmd.CommandTimeout = 300;

            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListM0012", _listM0012);
            try
            {
                cmd.ExecuteNonQuery();
                //result = returnParameter.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // Close the SqlDataReader.
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            //return result;
            return true;
        }

        //Thông tin Request
        public string Insert_Request(DataTable _listRequest, DataTable _listDelete, DataTable _listRequestDoc)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_INSERT_REQUEST", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            //Set timeout
            cmd.CommandTimeout = 300;

            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListRequest", _listRequest);
            param = cmd.Parameters.AddWithValue("@tblListRequest_Delete", _listDelete);
            param = cmd.Parameters.AddWithValue("@tblListRequest_Doc", _listRequestDoc);

            var returnParameter = cmd.Parameters.Add("@DocNo", SqlDbType.NVarChar);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            string result = "";
            try
            {
                cmd.ExecuteNonQuery();
                result = Convert.ToString(returnParameter.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;
            }
            finally
            {
                // Close the SqlDataReader.
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            return result;
            //return true;
        }
        //Xác nhận thông tin Request
        public bool Confirm_Request(DataTable _listRequest, DataTable _listDelete, DataTable _listRequestDoc)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_CONFIRM_REQUEST", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            //Set timeout
            cmd.CommandTimeout = 300;
            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListRequest", _listRequest);
            param = cmd.Parameters.AddWithValue("@tblListRequest_Delete", _listDelete);
            param = cmd.Parameters.AddWithValue("@tblListRequest_Doc", _listRequestDoc);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // Close the SqlDataReader
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            return true;
        }
        //Nhập và xác nhận thông tin Request
        public string Insert_Confirm_Request(DataTable _listRequest, DataTable _listRequestDoc)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_INSERT_CONFIRM_REQUEST", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            //Set timeout
            cmd.CommandTimeout = 300;

            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListRequest", _listRequest);
            param = cmd.Parameters.AddWithValue("@tblListRequest_Doc", _listRequestDoc);

            var returnParameter = cmd.Parameters.Add("@DocNo", SqlDbType.NVarChar);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            string result = "";
            try
            {
                cmd.ExecuteNonQuery();
                result = Convert.ToString(returnParameter.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;
            }
            finally
            {
                // Close the SqlDataReader.
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            return result;
            //return true;
        }
        //Bổ sung thông tin duyệt Request của IT
        public bool Confirm_Request_IT(DataTable _listRequest, DataTable _listRequestDoc)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_CONFIRM_REQUEST_IT", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            //Set timeout
            cmd.CommandTimeout = 300;
            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListRequest", _listRequest);
            param = cmd.Parameters.AddWithValue("@tblListRequest_Doc", _listRequestDoc);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // Close the SqlDataReader
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            return true;
        }
        //Thông tin Master theo model MMTB
        public string Insert_Master_ByModel(DataTable _listSummary, DataTable _listDelete, DataTable _listSummaryDoc)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_INSERT_MASTER_BY_MODEL", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            //Set timeout
            cmd.CommandTimeout = 300;

            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListSummary", _listSummary);
            param = cmd.Parameters.AddWithValue("@tblListSummary_Delete", _listDelete);
            param = cmd.Parameters.AddWithValue("@tblListSummary_Doc", _listSummaryDoc);

            var returnParameter = cmd.Parameters.Add("@DocNo", SqlDbType.NVarChar);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            string result = "";
            try
            {
                cmd.ExecuteNonQuery();
                result = Convert.ToString(returnParameter.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;
            }
            finally
            {
                // Close the SqlDataReader.
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            return result;
            //return true;
        }
        //Xác nhận Master theo model MMTB
        public bool Confirm_Master_ByModel(DataTable _listSummary, DataTable _listDelete, DataTable _listSummaryDoc)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_CONFIRM_MASTER_BY_MODEL", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            //Set timeout
            cmd.CommandTimeout = 300;
            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListSummary", _listSummary);
            param = cmd.Parameters.AddWithValue("@tblListSummary_Delete", _listDelete);
            param = cmd.Parameters.AddWithValue("@tblListSummary_Doc", _listSummaryDoc);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // Close the SqlDataReader
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            return true;
        }
        //Nhập và xác nhận Master theo model MMTB
        public string Insert_Confirm_Master_ByModel(DataTable _listSummary, DataTable _listSummaryDoc)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_INSERT_CONFIRM_MASTER_BY_MODEL", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            //Set timeout
            cmd.CommandTimeout = 300;

            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListSummary", _listSummary);
            param = cmd.Parameters.AddWithValue("@tblListSummary_Doc", _listSummaryDoc);

            var returnParameter = cmd.Parameters.Add("@DocNo", SqlDbType.NVarChar);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            string result = "";
            try
            {
                cmd.ExecuteNonQuery();
                result = Convert.ToString(returnParameter.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;
            }
            finally
            {
                // Close the SqlDataReader.
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            return result;
            //return true;
        }
        //Thông tin Master theo mã LK/pin/dầu
        public string Insert_Master_ByItem(DataTable _listSummary, DataTable _listDelete, DataTable _listSummaryDoc)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_INSERT_MASTER_BY_ITEM", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            //Set timeout
            cmd.CommandTimeout = 300;

            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListSummary", _listSummary);
            param = cmd.Parameters.AddWithValue("@tblListSummary_Delete", _listDelete);
            param = cmd.Parameters.AddWithValue("@tblListSummary_Doc", _listSummaryDoc);

            var returnParameter = cmd.Parameters.Add("@DocNo", SqlDbType.NVarChar);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            string result = "";
            try
            {
                cmd.ExecuteNonQuery();
                result = Convert.ToString(returnParameter.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;
            }
            finally
            {
                // Close the SqlDataReader.
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            return result;
            //return true;
        }
        //Xác nhận Master theo mã LK/pin/dầu
        public bool Confirm_Master_ByItem(DataTable _listSummary, DataTable _listDelete, DataTable _listSummaryDoc)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_CONFIRM_MASTER_BY_ITEM", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            //Set timeout
            cmd.CommandTimeout = 300;
            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListSummary", _listSummary);
            param = cmd.Parameters.AddWithValue("@tblListSummary_Delete", _listDelete);
            param = cmd.Parameters.AddWithValue("@tblListSummary_Doc", _listSummaryDoc);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // Close the SqlDataReader
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            return true;
        }
        //Nhập và xác nhận Master theo mã LK/pin/dầu
        public string Insert_Confirm_Master_ByItem(DataTable _listSummary, DataTable _listSummaryDoc)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_INSERT_CONFIRM_MASTER_BY_ITEM", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            //Set timeout
            cmd.CommandTimeout = 300;

            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListSummary", _listSummary);
            param = cmd.Parameters.AddWithValue("@tblListSummary_Doc", _listSummaryDoc);

            var returnParameter = cmd.Parameters.Add("@DocNo", SqlDbType.NVarChar);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            string result = "";
            try
            {
                cmd.ExecuteNonQuery();
                result = Convert.ToString(returnParameter.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;
            }
            finally
            {
                // Close the SqlDataReader.
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            return result;
            //return true;
        }
        
        //Nhập mã LK/pin/dầu thay thế (Replace)
        public bool Insert_Item_Replace(DataTable _listSummary)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_INSERT_ITEM_REPLACE", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            //Set timeout
            cmd.CommandTimeout = 300;

            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListSummary", _listSummary);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;
            }
            finally
            {
                // Close the SqlDataReader.
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            //return result;
            return true;
        }
        //InActive mã LK/pin/dầu thay thế (Replace)
        public bool InActive_Item_Replace(DataTable _listSummary)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_INACTIVE_ITEM_REPLACE", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            //Set timeout
            cmd.CommandTimeout = 300;

            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListSummary", _listSummary);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;
            }
            finally
            {
                // Close the SqlDataReader.
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            //return result;
            return true;
        }

        //Nhập mã LK/pin/dầu ngưng sử dụng (Cancel)
        public bool Insert_Item_Cancel(DataTable _listSummary)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_INSERT_ITEM_CANCEL", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            //Set timeout
            cmd.CommandTimeout = 300;

            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListSummary", _listSummary);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;
            }
            finally
            {
                // Close the SqlDataReader.
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            //return result;
            return true;
        }

        //Nhập thông tin NV mới
        public bool Insert_TelEmail(DataTable _listSummary)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_INSERT_TEL_EMAIL", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            //Set timeout
            cmd.CommandTimeout = 300;

            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListSummary", _listSummary);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;
            }
            finally
            {
                // Close the SqlDataReader.
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            //return result;
            return true;
        }
        //Bổ sung thông tin Email ĐT
        public bool Update_TelEmail(DataTable _listSummary)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_UPDATE_TEL_EMAIL", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            //Set timeout
            cmd.CommandTimeout = 300;

            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListSummary", _listSummary);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;
            }
            finally
            {
                // Close the SqlDataReader.
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            //return result;
            return true;
        }
        //InActive Email ĐT
        public bool InActive_TelEmail(DataTable _listSummary)
        {
            conn.Open();
            var cmd = new SqlCommand("SP_TVC_INACTIVE_TEL_EMAIL", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            //Set timeout
            cmd.CommandTimeout = 300;

            //Add param
            SqlParameter param = cmd.Parameters.AddWithValue("@tblListSummary", _listSummary);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;
            }
            finally
            {
                // Close the SqlDataReader.
                // The SqlBulkCopy object is automatically closed at the end of the using block.
                conn.Close();
            }
            conn.Close();
            //return result;
            return true;
        }
    }
}
