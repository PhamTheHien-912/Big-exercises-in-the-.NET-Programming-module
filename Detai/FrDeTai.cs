using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace Detai
{
    public partial class FrDeTai : Form
    {
        public FrDeTai()
        {
            InitializeComponent();
        }
        public static string quyen;
        DeTaiKH detai = new DeTaiKH();
        //Lop lh = new Lop();
        
        private void FrDeTai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDT.tblMaLoaiBaiBao' table. You can move, or remove it, as needed.
            


            DataTable dt = new DataTable();
            dt = detai.HienthiDeTai();
            dtgHienthi.DataSource = dt;
            txtdetai.ReadOnly = true;

            txttendetai.ReadOnly = true;

            dtpthoigian.Visible = false;
            cbMaLoaiDT.Enabled = false;
            cbmatg.Enabled = false;
            txtthoigian.Visible = true;
            buttonOK.Enabled = false;
            buttonOK.Visible = true;
            btnOk2.Visible = true;
            btnOk2.Enabled = false;
            btnThemMoi.Enabled = true;
            btnChihsua.Enabled = true;
            btnDelete.Enabled = true;
            binding();
            CanboLoad();
        }
        public void CanboLoad()
        {
            dangnhap1TableAdapters.QueriesTableAdapter dn = new dangnhap1TableAdapters.QueriesTableAdapter();
            if (dn.CheckQuyenCB1(quyen) == 1)
            {
                btnDelete.Enabled = false;
                btnChihsua.Enabled =false;
                btnThemMoi.Enabled=false;

            }
        }
        public void AdminLoad()
        {
            dangnhapTableAdapters.QueriesTableAdapter dn = new dangnhapTableAdapters.QueriesTableAdapter();
            if (dn.CheckQuyenAdmin(quyen) == 1)
            {
                

            }
        }
        public void binding()
        {
            txtdetai.DataBindings.Clear();
            txtdetai.DataBindings.Add("text", dtgHienthi.DataSource, "MaDeTai");
            txttendetai.DataBindings.Clear();
            txttendetai.DataBindings.Add("text", dtgHienthi.DataSource, "TenDeTai");
            txtthoigian.DataBindings.Clear();
            txtthoigian.DataBindings.Add("text", dtgHienthi.DataSource, "ThoiGian");
            cbmatg.DataBindings.Clear();
            cbmatg.DataBindings.Add("text", dtgHienthi.DataSource, "MaTacGia");
            cbMaLoaiDT.DataBindings.Clear();
            cbMaLoaiDT.DataBindings.Add("text", dtgHienthi.DataSource, "MaloaiDeTai");
        }
        
       

       
       
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtdetai.ResetText();
            txtdetai.ReadOnly = false;
            txttendetai.Clear();
            txttendetai.ReadOnly = false;
           
            dtpthoigian.Visible = true;
            cbMaLoaiDT.Enabled = true;
            cbmatg.Enabled = true;
            txtthoigian.Visible = false;
            buttonOK.Enabled = true;
            buttonOK.Visible = true;
            btnOk2.Visible = false;
            btnOk2.Enabled = false;
            btnThemMoi.Enabled = false;
            btnChihsua.Enabled = false;
            btnDelete.Enabled = false;
            tblMaLoaiDeTaiTableAdapter.Fill(qLDT.tblMaLoaiDeTai);
            tbTacGiaTableAdapter.Fill(qLDT.tbTacGia);
            
            
        }

        private void dtgHienthi_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dtgHienthi.RowCount; i++)
                dtgHienthi.Rows[i].Cells[0].Value = i + 1;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FrDeTai_Load(sender, e);


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnReset_Click(sender, e);
            
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnCancelCs_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOkCs_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin đề tài này không?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                detai.XoaDeTai(txtdetai.Text);
                MessageBox.Show("Đã xóa thông tin đề tài: " + txtdetai.Text + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrDeTai_Load(sender, e);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.TextLength == 0)
            {
                MessageBox.Show("Mã đề tài không được để trống");
                this.txtTimKiem.Focus();
            }
            else
            {
                DataTable dt = new DataTable();
                dt = detai.TimKiemDeTai(txtTimKiem.Text);
                dtgHienthi.DataSource = dt;
                
            }    
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            FrDeTai_Load(sender, e);
            txtTimKiem.ResetText();
            this.txtTimKiem.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnTroLai_Click(sender, e);
        }

        private void dtgHienthi_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (this.txtdetai.TextLength == 0)
            {
                MessageBox.Show("Mã đề tài không được để trống");
                this.txtdetai.Focus();
            }
            else
                if (this.txttendetai.TextLength < 5)
            {
                MessageBox.Show("Tên đề tài quá ngắn xin nhập lại");
                this.txttendetai.Focus();
            }
            else
                    if (this.txttendetai.TextLength == 0)
            {
                MessageBox.Show("Tên đề tài không được để trống");
                this.txttendetai.Focus();
            }

            else
            {
                try
                {
                    detai.ThemDeTai(txtdetai.Text,txttendetai.Text, dtpthoigian.Text,cbMaLoaiDT.SelectedValue.ToString(), cbmatg.Text);
                    MessageBox.Show("Đã thêm dự án thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrDeTai_Load(sender, e);


                }
                catch
                {
                    MessageBox.Show("Đề tài " + this.txtdetai.Text + " đã tồn tại");
                }
            }
        }

        private void btnChihsua_Click(object sender, EventArgs e)
        {
            
            txtdetai.ReadOnly = true;
            
            txttendetai.ReadOnly = false;

            dtpthoigian.Visible = true;
            cbMaLoaiDT.Enabled = true;
            cbmatg.Enabled = true;
            txtthoigian.Visible = false;
            buttonOK.Enabled = false;
            buttonOK.Visible = false;
            btnOk2.Visible = true;
            btnOk2.Enabled = true;
            btnThemMoi.Enabled = false;
            btnChihsua.Enabled = false;
            btnDelete.Enabled = false;
            tblMaLoaiDeTaiTableAdapter.Fill(qLDT.tblMaLoaiDeTai);
            tbTacGiaTableAdapter.Fill(qLDT.tbTacGia);
        }

        private void btnOk2_Click(object sender, EventArgs e)
        {
           
                if (this.txttendetai.TextLength < 5)
            {
                MessageBox.Show("Tên đề tài quá ngắn xin nhập lại");
                this.txttendetai.Focus();
            }
            else
                    if (this.txttendetai.TextLength == 0)
            {
                MessageBox.Show("Tên đề tài không được để trống");
                this.txttendetai.Focus();
            }

            else
            {
                try
                {
                    detai.SuaDeTai(txtdetai.Text, txttendetai.Text, dtpthoigian.Text, cbMaLoaiDT.SelectedValue.ToString(), cbmatg.Text);
                    MessageBox.Show("Đã sửa thông tin đề tài: "+txtdetai.Text+" thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrDeTai_Load(sender, e);


                }
                catch
                {
                    MessageBox.Show("Đề tài " + this.txtdetai.Text + " đã tồn tại");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
            
        }

        private void tblMaLoaiDeTaiBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tbTacGiaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tbDeTaiBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void tblBaiBaoKHBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
