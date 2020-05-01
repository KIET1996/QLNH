using QLNH.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNH
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtUserName.Text = "vankiet";
            txtpwd.Text = "123";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String userName = txtUserName.Text;
            String passWord = txtpwd.Text;
            if (txtUserName.Text == " " || txtpwd.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Login(userName, passWord))
                {
                    frmMenu menu = new frmMenu();
                    this.Hide();
                    menu.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Bạn đã nhập sai tên hoặc mật khẩu");
                }
            }
        }

        //Login
        bool Login(string userName, string passWord)
        {
            return UserController.Instance.Login(userName, passWord);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
