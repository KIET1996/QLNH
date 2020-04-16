using QLNH.Controller;
using QLNH.Model;
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

        // Load danh sach ban
        void load_Table()
        {
            List<Table> tableList = TableController.Instance.list_Table();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableController.TableWidth, Height = TableController.TableHeight };
                btn.Text = item.ID + Environment.NewLine + item.Status;

                switch (item.Status)
                {
                    case 0:
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }

                fpnTable.Controls.Add(btn);
            }
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
