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
        int currentIndex = 0;
        public FrmStatistical()
        {
            InitializeComponent();
            LoadDiscount();
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
    }
}
