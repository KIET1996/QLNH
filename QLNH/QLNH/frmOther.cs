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
    public partial class frmOther : Form
    {
        public frmOther()
        {
            InitializeComponent();
            load_Table();
        }

        void load_Table()
        {

        }



        private void btnOther_Click(object sender, EventArgs e)
        {

        }

        private void mnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Su kien dong form
        private void frmOther_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
