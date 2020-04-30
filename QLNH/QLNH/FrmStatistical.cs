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
    public partial class FrmStatistical : Form
    {
        public FrmStatistical()
        {
            InitializeComponent();
            LoadDiscount();
        }

        void LoadDiscount()
        {
            List<Discount> listDiscount = DiscountController.Instance.GetListAllDiscount();
            gvDiscount.DataSource = listDiscount;
          
        }
    }
}
