using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Detai
{
    public partial class FrTacGia : Form
    {
        public FrTacGia()
        {
            InitializeComponent();
        }
        TacGia bb = new TacGia();
        public static string quyen;

        private void FrTacGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDT.tbTacGia' table. You can move, or remove it, as needed.
            this.tbTacGiaTableAdapter.Fill(this.qLDT.tbTacGia);
            DataTable dt = new DataTable();
            dt = bb.HienthiTacGia();
            dtgHienthi.DataSource = dt;
            txtmatg.ReadOnly = true;
            txtdonvi.ReadOnly = true;
            txttentg.ReadOnly = true;
            txtemail.ReadOnly = true;
            txtsdt.ReadOnly = true;
            cbdonvi.Enabled = false;
            cbchucvu.Enabled = false;
            
            
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
                btnChihsua.Enabled = false;
                btnThemMoi.Enabled = false;

            }
        }

        public void binding()
        {
            txtmatg.DataBindings.Clear();
            txtmatg.DataBindings.Add("text", dtgHienthi.DataSource, "MaTacGia");
            txttentg.DataBindings.Clear();
            txttentg.DataBindings.Add("text", dtgHienthi.DataSource, "TenTacGia");
            cbchucvu.DataBindings.Clear();
            cbchucvu.DataBindings.Add("text", dtgHienthi.DataSource, "ChucVu");
            cbdonvi.DataBindings.Clear();
            cbdonvi.DataBindings.Add("text", dtgHienthi.DataSource, "DonVi");
            txtsdt.DataBindings.Clear();
            txtsdt.DataBindings.Add("text", dtgHienthi.DataSource, "DienThoai");
            txtemail.DataBindings.Clear();
            txtemail.DataBindings.Add("text", dtgHienthi.DataSource, "Email");
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtmatg.ResetText();
            txtmatg.ReadOnly = false;
            txttentg.Clear();
            txttentg.ReadOnly = false;
            txtsdt.Clear();
            txtsdt.ReadOnly = false;
            cbchucvu.Enabled = true;
            txtemail.Clear();
            txtemail.ReadOnly = false;
            cbdonvi.Enabled = false;
            
            buttonOK.Enabled = true;
            buttonOK.Visible = true;
            btnOk2.Visible = false;
            btnOk2.Enabled = false;
            btnThemMoi.Enabled = false;
            btnChihsua.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void cbchucvu_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbchucvu_DisplayMemberChanged(object sender, EventArgs e)
        {
            

        }

        private void cbchucvu_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbchucvu.Text == "Cán bộ"  || cbchucvu.Text == "Nhân Viên" )
            {
                cbdonvi.Enabled = true;
                cbdonvi.Visible = true;
                txtdonvi.Visible = false;
            }
            else
            {
                cbdonvi.Visible = false;
                cbdonvi.Enabled = false;
                txtdonvi.Clear();
                txtdonvi.Visible = true;
                txtdonvi.ReadOnly= false;
                txtdonvi.Enabled=true;
            }

        }

        private void btnChihsua_Click(object sender, EventArgs e)
        {
           
            txtmatg.ReadOnly = true;
            txttentg.Clear();
            txttentg.ReadOnly = false;
            txtsdt.Clear();
            txtsdt.ReadOnly = false;
            cbchucvu.Enabled = true;
            txtemail.Clear();
            txtemail.ReadOnly = false;
            cbdonvi.Enabled = false;

            buttonOK.Enabled = false;
            buttonOK.Visible = false;
            btnOk2.Visible = true;
            btnOk2.Enabled = true;
            btnThemMoi.Enabled = false;
            btnChihsua.Enabled = false;
            btnDelete.Enabled = false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin tác giả này không?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bb.XoaTacGia(txtmatg.Text);
                MessageBox.Show("Đã xóa thông tin tác giả: " + txtmatg.Text + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrTacGia_Load(sender, e);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.TextLength == 0)
            {
                MessageBox.Show("Tìm kiếm không được để trống");
                this.txtTimKiem.Focus();
            }
            else
            {
                DataTable dt = new DataTable();
                dt = bb.TimKiemTacGia(txtTimKiem.Text);
                dtgHienthi.DataSource = dt;

            }
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            FrTacGia_Load(sender, e);
            txtTimKiem.ResetText();
            this.txtTimKiem.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
            Dispose();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (this.txtmatg.TextLength == 0)
            {
                MessageBox.Show("Mã tác giả không được để trống");
                this.txtmatg.Focus();
            }
            else
                if (this.txttentg.TextLength < 5)
            {
                MessageBox.Show("Tên tác giả quá ngắn xin nhập lại");
                this.txttentg.Focus();
            }
            else
                    if (this.txttentg.TextLength == 0)
            {
                MessageBox.Show("Tên tác giả không được để trống");
                this.txttentg.Focus();
            }
            else
                    if (this.cbdonvi.Text == "")
            {
                MessageBox.Show("Đơn vị không được để trống");
                this.cbdonvi.Focus();
            }
            else
                    if (this.cbchucvu.Text == "")
            {
                MessageBox.Show("Chức vụ không được để trống");
                this.cbchucvu.Focus();
            }
            else
                    if (this.txtsdt.TextLength ==0)
            {
                MessageBox.Show("Số điện thoại không được để trống");
                this.txtsdt.Focus();
            }
            else
                    if (this.txtemail.TextLength == 0)
            {
                MessageBox.Show("Số điện thoại không được để trống");
                this.txtemail.Focus();
            }
            else
            {
                try
                {
                   
                    if (cbdonvi.Enabled == true && cbdonvi.Visible == true)
                    {
                          bb.ThemTacGia(txtmatg.Text, txttentg.Text, cbdonvi.Text, txtsdt.Text, txtemail.Text, cbchucvu.Text);
                          MessageBox.Show("Đã thêm tác giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          FrTacGia_Load(sender, e);
                        
                      
                    }else
                    {
                        bb.ThemTacGia(txtmatg.Text, txttentg.Text, txtdonvi.Text, txtsdt.Text, txtemail.Text, cbchucvu.Text);
                        MessageBox.Show("Đã thêm tác giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrTacGia_Load(sender, e);
                    }
                   

                }
                catch
                {
                    MessageBox.Show("Tác giả " + this.txtmatg.Text + " đã tồn tại");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FrTacGia_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }

        private void btnOk2_Click(object sender, EventArgs e)
        {
            
                if (this.txttentg.TextLength < 5)
            {
                MessageBox.Show("Tên tác giả quá ngắn xin nhập lại");
                this.txttentg.Focus();
            }
            else
                    if (this.txttentg.TextLength == 0)
            {
                MessageBox.Show("Tên tác giả không được để trống");
                this.txttentg.Focus();
            }
            else
                    if (this.cbdonvi.Text == "")
            {
                MessageBox.Show("Đơn vị không được để trống");
                this.cbdonvi.Focus();
            }
            if (this.txtdonvi.Text == "")
            {
                MessageBox.Show("Đơn vị không được để trống");
                this.txtdonvi.Focus();
            }
            else
                    if (this.cbchucvu.Text == "")
            {
                MessageBox.Show("Chức vụ không được để trống");
                this.cbchucvu.Focus();
            }
            else
                    if (this.txtsdt.TextLength == 0)
            {
                MessageBox.Show("Số điện thoại không được để trống");
                this.txtsdt.Focus();
            }
            else
                    if (this.txtemail.TextLength == 0)
            {
                MessageBox.Show("Email không được để trống");
                this.txtemail.Focus();
            }
            else
            {
                try
                {

                    if (cbdonvi.Enabled == true && cbdonvi.Visible == true)
                    {
                        bb.SuaTacGia(txtmatg.Text, txttentg.Text, cbdonvi.Text, txtsdt.Text, txtemail.Text, cbchucvu.Text);
                        MessageBox.Show("Đã sửa tác giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrTacGia_Load(sender, e);


                    }
                    else
                    {
                        bb.SuaTacGia(txtmatg.Text, txttentg.Text, txtdonvi.Text, txtsdt.Text, txtemail.Text, cbchucvu.Text);
                        MessageBox.Show("Đã sửa tác giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrTacGia_Load(sender, e);
                    }


                }
                catch
                {
                    MessageBox.Show("Tác giả " + this.txtmatg.Text + " đã tồn tại");
                }
            }
        }
    }
}
