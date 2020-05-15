﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MMTB.DAO;
using MMTB.DAL;

namespace MMTB.View
{
    public partial class Form_Login : DevExpress.XtraEditors.XtraForm
    {
        public System_DAL _systemDAL;
        public SYS_USER_DAO sys_user_DAO;

        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            _systemDAL = new System_DAL();
            sys_user_DAO = new SYS_USER_DAO();
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
            Application.Exit();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            if(CheckError())
            {
                string _userName = txtUserName.Text.Trim();
                string _passWord = txtPassword.Text.Trim();
                DataTable _tempTable = sys_user_DAO.GetInfoUser(_userName, _passWord);

                if (_tempTable.Rows.Count > 0)
                {
                    this.Hide();

                    _systemDAL.userName = _userName;

                    Form_Menu _fonmMain = new Form_Menu(_systemDAL);
                    _fonmMain.StartPosition = FormStartPosition.Manual;
                    _fonmMain.Show();
                } else {
                    MessageBox.Show("Tên đăng nhập và mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserName.Focus();
                }
            }
        }
        #endregion

        private bool CheckError()
        {
            if (String.IsNullOrEmpty(txtUserName.Text) || String.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống!", "Lỗi đăng nhập", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}