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
            addPositionBinding();

            //load du lieu table
            table_Load();
            dtGridTable.DataSource = tableList;
            addTableBinding();
            LoadPositionIntoComboBox(cbPosition); //combobox khu vuc cua bang table
        }

        /*Reset lai cac truong
        void ResetFields(bool status)
        {
            txtIDPos.Clear();
            txtNamePos.Clear();
            txtNotePos.Clear();
            txtIDTable.Clear();
            txtStatusPos.Clear();
            cbPosition.SelectedIndex = -1;
            

            radYes.Checked = true;
            radNo.Checked = false;
            btnSavePos.Enabled = status;
            btnSave.Enabled = status;
            btnCancel.Enabled = status;
            btnCanl.Enabled = status;
            btnAddPos.Enabled = !status;
            btnAdd.Enabled = !status;
            btnEdit.Enabled = !status;
            btnEditPos.Enabled = !status;
        }*/

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

        //tao xu kien cho nut them
        private void btnAddTable_Click(object sender, EventArgs e)
        {
            int ID_Pos = (cbPosition.SelectedItem as Position).ID_Pos;
            int Capability = (int)numCapa.Value;
            int sta = 0;

            if (radYes.Checked)
            {
                sta = 1;
            }

            if (TableController.Instance.InsertTable(ID_Pos, Capability, sta))
            {
                MessageBox.Show("Thêm bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                table_Load();
            }
            //MessageBox.Show("ID thanh cong" + ID_Pos);
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

        /* su kien click nut add
        private void btnAddPos_Click(object sender, EventArgs e)
        {
            try
            {
                PositionController.Instance.CheckAddPos(ID_Pos);
            }
            catch (Exception)
            {
                ID_Pos = 0;
            }
            ID_Pos = ID_Pos + 1;
            ResetFields(true);
            txtIDPos.Text = ID_Pos.ToString();
        }*/

       private void btnAddPos_Click(object sender, EventArgs e)
        {
            if(txtNamePos.Text == "" || txtStatusPos.Text == "")
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
                        }
                     }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        
    }
}
