using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MMTB.DAO;
using MMTB.DAL;

namespace MMTB.View
{
    public partial class Form_ChangePw : DevExpress.XtraEditors.XtraForm
    {
        public SYS_USER_DAO sys_user_DAO;

        public System_DAL _systemDAL = new System_DAL();
        public Form_ChangePw()
        {
            InitializeComponent();
        }
        public Form_ChangePw(System_DAL systemDAL)
        {
            InitializeComponent();
            _systemDAL = systemDAL;
        }

        private void Form_ChangePw_Load(object sender, EventArgs e)
        {
            sys_user_DAO = new SYS_USER_DAO();
            string _userName = _systemDAL.userName.ToUpper();
            txtUserName.Text = _userName;
        }

        #region Move Form
        bool mouseDown = false;
        Point startPoint = new Point(0, 0);
        private void labelTop_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void labelTop_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void labelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }
        #endregion

        #region event
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if(CheckError())
            {
                string _userName = txtUserName.Text.Trim();
                string _pwNew = txtPwNew.Text.Trim();
                if (sys_user_DAO.ChangePw(_userName, _pwNew))
                {
                    MessageBox.Show("Đã thay đổi mật khẩu thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thông tin không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                }
            }
        }
        #endregion

        private bool CheckError()
        {
            if (String.IsNullOrEmpty(txtPwNew.Text) || String.IsNullOrEmpty(txtPwNew1.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            if (txtPwNew.Text != txtPwNew1.Text)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}