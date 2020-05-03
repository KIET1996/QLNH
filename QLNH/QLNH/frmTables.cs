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
        int currentIndex = 0;
        BindingSource positionList = new BindingSource(); //khai bao bindingsource de moi lan load du lieu se thay doi theo binding
        BindingSource tableList = new BindingSource();

        
        public frmTables()
        {
            InitializeComponent();
            ResetFieldsTable(false);
            ResetFieldsPosition(false);
        }



        private void frmTables_Load(object sender, EventArgs e)
        {
            //load du lieu position
            position_Load();
            dtGridPosition.DataSource = positionList;
            addPositionBinding();

            //load du lieu table
            table_Load();
            dtGridTable.DataSource = tableList;
            addTableBinding();
            LoadPositionIntoComboBox(cbPosition); //combobox khu vuc cua bang table
        }

        

        /*-------------------Tao cac ham xu ly Table---------------------*/
        private void table_Load()
        {
            tableList.DataSource = Controller.TableController.Instance.getListTable();
        }

        //load databinding ban
        void addTableBinding()
        {
            txtIDTable.DataBindings.Add(new Binding("Text", dtGridTable.DataSource, "ID_Table"));           
            numCapa.DataBindings.Add(new Binding("Value", dtGridTable.DataSource, "Capa"));                       
        }

        //load khu vuc ra combobox
        void LoadPositionIntoComboBox(ComboBox cb)
        {
            cb.DataSource = PositionController.Instance.getListPosition();
            cb.DisplayMember = "Pos";
        }

        //su kien load radiobuttton
        private void dtGridTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndex = dtGridTable.CurrentRow.Index;
            string sql = dtGridTable.Rows[currentIndex].Cells[3].Value.ToString();
            int check = Convert.ToInt32(sql);
            if (check == 1)
            {
                radYes.Checked = true;
                radNo.Checked = false;
            }
            else
            {
                radYes.Checked = false;
                radNo.Checked = true;
            }

        }


        //binding id khu vuc theo id ban
        private void txtIDTable_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtGridTable.SelectedCells.Count > 0)
                {
                    int id = (int)dtGridTable.SelectedCells[0].OwningRow.Cells["PositionTable"].Value;   //lay gia tri o id bat ky

                    Position pos = PositionController.Instance.getPositionByID(id);
                    cbPosition.SelectedItem = pos;

                    int index = -1;
                    int i = 0;
                    foreach (Position item in cbPosition.Items)
                    {
                        if (item.ID_Pos == pos.ID_Pos)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbPosition.SelectedIndex = index;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Reset lai cac truong của table
        void ResetFieldsTable(bool status)
        {
            txtIDTable.Clear();
            cbPosition.SelectedIndex = -1;
            numCapa.Value = numCapa.Minimum;

            radYes.Checked = false;
            radNo.Checked = true;
            btnSave.Enabled = status;
            btnCancel.Enabled = status;
            btnAdd.Enabled = !status;
            btnEdit.Enabled = !status;
            btnDelete.Enabled = !status;
        }

        //tao xu kien cho nut them
        private void btnAddTable_Click(object sender, EventArgs e)
        {
            if (TableController.Instance.ResetTable())
            {
                ResetFieldsTable(true);
                int count = TableController.Instance.GetMaxIDTable();
                count++;
                txtIDTable.Text = count.ToString();
            }        
        }

        //tao su kien cho nut huy
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetFieldsTable(false);
        }

        //Lưu cho su kien nut them ban
        private void btnSave_Click(object sender, EventArgs e)
        {
            int ID_Pos = (cbPosition.SelectedItem as Position).ID_Pos;
      //      MessageBox.Show("Hãy chọn khu vực!"+ID_Pos, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            int Capability = (int)numCapa.Value;
            int sta = 0;

            if (radYes.Checked)
            {
                sta = 1;
            }
            if (ID_Pos > 0)
            {
                if (TableController.Instance.InsertTable(ID_Pos, Capability, sta))
                {
                    MessageBox.Show("Thêm bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    table_Load();
                    ResetFieldsTable(false);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn khu vực!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            } 


        }

        //su kien xoa ban
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID_Table = Convert.ToInt32(txtIDTable.Text);

            DialogResult dr = MessageBox.Show("Bạn có muốn xóa bàn này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                if (TableController.Instance.DeleteTable(ID_Table))
                {
                    MessageBox.Show("Xóa bàn thành công!");
                    table_Load();
                }
                else
                {
                    MessageBox.Show("Xóa bàn thất bại!");
                }
            }
        }

        //Sua thong tin ban
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int ID_Table = Convert.ToInt32(txtIDTable.Text);
                int ID_Pos = (cbPosition.SelectedItem as Position).ID_Pos;
                int Capability = Convert.ToInt32(numCapa.Value);
                int Sta = 0;

                if (radYes.Checked)
                {
                    Sta = 1;
                }

                if (TableController.Instance.UpdateTable(ID_Table, ID_Pos, Capability, Sta))
                {
                    MessageBox.Show("Sửa thông tin thành công!");
                    table_Load();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nhập thông tin đầy đủ!");
            }
            
        }

        /*--------------------Tao cac ham xu ly position------------------*/

        /*Load list position*/
        private void position_Load()
        {
            positionList.DataSource = Controller.PositionController.Instance.getListPosition();
        }
        
        /*thong tin binding du lieu position*/
        void addPositionBinding()
        {
            txtNamePos.DataBindings.Add(new Binding("Text", dtGridPosition.DataSource, "Pos"));
            txtStatusPos.DataBindings.Add(new Binding("Text", dtGridPosition.DataSource, "Sta"));
            txtNotePos.DataBindings.Add(new Binding("Text", dtGridPosition.DataSource, "Note"));
            txtIDPos.DataBindings.Add(new Binding("Text", dtGridPosition.DataSource, "ID_Pos"));
        }

        void ResetFieldsPosition(bool status)
        {
            txtIDPos.Clear();
            txtNamePos.Clear();
            txtStatusPos.Clear();
            txtNotePos.Clear();

            btnSavePos.Enabled = status;
            btnCanl.Enabled = status;
            btnAddPos.Enabled = !status;
            btnEditPos.Enabled = !status;
            btnDeletePos.Enabled = !status;
        }

        //reset cac truong khi click them
        private void btnAddPos_Click(object sender, EventArgs e)
        {
            if (PositionController.Instance.ResetPosition())
            {
                ResetFieldsPosition(true);
                int count = PositionController.Instance.GetMaxIDPos();
                count++;
                txtIDPos.Text = count.ToString();
            }
        }

        private void btnSavePos_Click(object sender, EventArgs e)
        {
            if (txtNamePos.Text == "" || txtStatusPos.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên khu vực hoặc trạng thái. Vui lòng nhập đầy dủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string pos = txtNamePos.Text;
                    string sta = txtStatusPos.Text;
                    string note = txtNotePos.Text;

                    if (PositionController.Instance.CheckPosition(pos))
                    {
                        MessageBox.Show("Khu vực đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (PositionController.Instance.AddPosition(pos, sta, note))
                        {
                            MessageBox.Show("Thêm khu vực thành công!");
                            position_Load();
                            ResetFieldsPosition(false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCanl_Click(object sender, EventArgs e)
        {
            ResetFieldsPosition(false);
        }        

        private void btnDeletePos_Click(object sender, EventArgs e)
        {
            int ID_Pos = Convert.ToInt32(txtIDPos.Text);

            DialogResult dr = MessageBox.Show("Bạn có muốn xóa khu vực này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                if (PositionController.Instance.DeletePosition(ID_Pos))
                {
                    MessageBox.Show("Xóa khu vực thành công!");
                    position_Load();
                }
                else
                {
                    MessageBox.Show("Xóa khu vực thất bại!");
                }
            }
        }

        private void btnEditPos_Click(object sender, EventArgs e)
        {
            int ID_Pos = Convert.ToInt32(txtIDPos.Text);
            string name = txtNamePos.Text;
            string Sta = txtStatusPos.Text;
            string note = txtNotePos.Text;

            DialogResult dr = MessageBox.Show("Bạn có muốn chỉnh sửa khu vực này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                if (PositionController.Instance.UpdatePosition(ID_Pos, name, Sta, note))
                {
                    MessageBox.Show("Sửa thông tin thành công!");
                    position_Load();
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa khu vực thất bại!");
                }
            }            
        }

        //Chuyen sang form Quan ly thong ke
        private void mnStatistic_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStatistical frm = new FrmStatistical();
            frm.Show();
        }

        //Chuyen sang form Quan ly goi mon
        private void mnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOther frm = new QLNH.frmOther();
            frm.Show();
        }

        //Chuyen sang form Quan ly mon
        private void mnDish_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frm = new QLNH.frmMenu();
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

        //Tro ve login
        private void mnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                this.Hide();
                frmLogin frm = new frmLogin();
                frm.Show();
                this.Close();
                //Application.Exit();
            }
        }
    }
}
