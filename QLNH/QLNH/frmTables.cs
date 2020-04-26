using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNH.Controller;
using QLNH.Model;

namespace QLNH
{
    public partial class frmTables : Form
    {

        BindingSource positionList = new BindingSource(); //khai bao bindingsource de moi lan load du lieu se thay doi theo binding
        BindingSource tableList = new BindingSource();
        public frmTables()
        {
            InitializeComponent();
        }

        private void mnuOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOther frm = new frmOther();
            frm.Show();
        }

        private void frmTables_Load(object sender, EventArgs e)
        {
            //load du lieu position
            position_Load();
            dtGridPosition.DataSource = positionList;

            //load du lieu table
            table_Load();
            dtGridTable.DataSource = tableList;

        }

        /*-------------------Tao cac ham xu ly Table---------------------*/
        private void table_Load()
        {
            tableList.DataSource = Controller.TableController.Instance.getListTable();
        }
        

        /*--------------------Tao cac ham xu ly position------------------*/
        private void position_Load()
        {
            positionList.DataSource = Controller.PositionController.Instance.getListPosition();
        }


    }
}
