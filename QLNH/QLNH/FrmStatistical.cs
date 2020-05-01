using QLNH.Controller;
using QLNH.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNH
{
    public partial class FrmStatistical : Form
    {
        int currentIndex = 0;
        public FrmStatistical()
        {
            InitializeComponent();
            LoadDiscount();
            loadProfit(dtDTStart.Value, dtDTFinish.Value);
            loadStatisticDish(dtStatisticStart.Value, dtStatisticFinish.Value);
            resetField(true);
        }

        // load danh sách các chương trình giảm giá
        void LoadDiscount()
        {
            List<Discount> listDiscount = DiscountController.Instance.GetListAllDiscount();
            gvDiscount.DataSource = listDiscount;
          
        }

        // Bắt sự kiện khi click vào bất kì hàng dữ liệu nào trong data girdview
        private void gvDiscount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndex = gvDiscount.CurrentRow.Index;
            txtIDDis.Text = gvDiscount.Rows[currentIndex].Cells[0].Value.ToString();
            nudPercent.Value = Convert.ToInt32(gvDiscount.Rows[currentIndex].Cells[1].Value.ToString());
            txtDiscription.Text = gvDiscount.Rows[currentIndex].Cells[2].Value.ToString();
            dtStart.Value = (DateTime)gvDiscount.Rows[currentIndex].Cells[3].Value;
            DateTime temp = (DateTime)gvDiscount.Rows[currentIndex].Cells[4].Value;
            if (temp < dtFinish.MinDate)
            {
                dtFinish.Value = dtFinish.MaxDate;
            }
            else
            {
                dtFinish.Value = temp;
            }
        }


        // Reset các trường của groupbox discount
        void resetField(bool status)
        {
            nudPercent.Value = nudPercent.Minimum;
            txtDiscription.Clear();
            dtStart.Value = DateTime.Today;
            dtFinish.Value = DateTime.Today;
            btnSave.Enabled = !status;
            btnCancel.Enabled = !status;
            btnEdit.Enabled = status;
            btnDelete.Enabled = status;
            btnAdd.Enabled = status;
        }

        // Xử lí sự kiện khi click button "Thêm"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            resetField(false);
            int temp = DiscountController.Instance.GetMaxIDDis();
            temp++;
            txtIDDis.Text = temp.ToString();
        }

        // Xử lí sự kiện khi click button "Lưu"
        private void btnSave_Click(object sender, EventArgs e)
        {

            double per = Convert.ToDouble(nudPercent.Value);
            string descript = txtDiscription.Text;
            DateTime start = dtStart.Value;
            DateTime finish = dtFinish.Value;

            if (txtDiscription.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mô tả giảm giá. Vui lòng nhập đầy dủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (start > finish)
                {
                    MessageBox.Show("Ngày bắt đầu giảm giá không thể lớn hơn ngày kết thúc. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (DiscountController.Instance.InsertDiscount(per, descript, start, finish))
                    {
                        MessageBox.Show("Thêm chương trình giảm giá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                        LoadDiscount();
                        resetField(true);
                    }
                }

            }
        }

        // Xử lí sự kiện khi click button "sửa"
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int ID_Dis = Convert.ToInt32(txtIDDis.Text);
            Double per = Convert.ToDouble(nudPercent.Value);
            string descript = txtDiscription.Text;
            DateTime start = dtStart.Value;

            DateTime finish = dtFinish.Value;
            if (DiscountController.Instance.UpdateDiscount(ID_Dis, per, descript, start, finish))
            {
                MessageBox.Show("Sửa thông tin thành công!");
                LoadDiscount();
            }
        }

        // Xử lí sự kiện khi click button "xóa"
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID_Dis = Convert.ToInt32(txtIDDis.Text);

            DialogResult dr = MessageBox.Show("Bạn có muốn xóa chương trình giảm giá này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                if (DiscountController.Instance.DeleteDiscount(ID_Dis))
                {
                    MessageBox.Show("Xóa chương trình giảm giá thành công!");
                    LoadDiscount();
                }
                else
                {
                    MessageBox.Show("Xóa chương trình giảm giá thất bại!");
                }
            }
        }

        //Load doanh thu tu ngay a den ngay b
        public void loadProfit(DateTime start, DateTime finish)
        {
            double total = 0;
            List<Profit> listProfit = ProfitController.Instance.GetListProfit(start, finish);
            foreach (Profit item in listProfit)
            {   
                total += item.Total_price;
            }
            gvProfit.DataSource = listProfit;
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTotal.Text = total.ToString("C", culture);

        }

        //Chon xem danh doanh thu tu ngay a den ngay b
        private void btnDTSeen_Click(object sender, EventArgs e)
        {
            DateTime start = dtDTStart.Value;
            DateTime finish = dtDTFinish.Value;
            loadProfit(start, finish);
        }

        //Load doanh thu tu ngay a den ngay b
        public void loadStatisticDish(DateTime start, DateTime finish)
        {
            double total = 0;
            List<Statistic> list = StatisticController.Instance.GetListStatistic(start, finish);
            foreach (Statistic item in list)
            {
                total += item.Total;
            }
            gvStatisticDish.DataSource = list;
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTotalStatistic.Text = total.ToString("C", culture);

        }

        //Thong ke so luong ban va doanh thu cac mon tu ngay a den ngay b
        private void btnSeen_Click(object sender, EventArgs e)
        {
            DateTime start = dtStatisticStart.Value;
            DateTime finish = dtStatisticFinish.Value;
            loadStatisticDish(start, finish);
        }

        //Chuyen sang form Quan ly ban
        private void mnManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTables frm = new frmTables();
            frm.Show();
        }

        //Chuyen sang form Quan ly mon
        private void mnDish_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frm = new frmMenu();
            frm.Show();
        }

        //Chuyen sang form Quan ly goi mon
        private void mnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOther frm = new frmOther();
            frm.Show();
        }

        //Thoát chương trình
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        //huy hoat dong luu
        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetField(true);
        }
    }
}
