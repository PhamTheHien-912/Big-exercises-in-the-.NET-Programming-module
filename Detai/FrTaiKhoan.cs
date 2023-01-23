using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace Detai
{
    public partial class FrTaiKhoan : Form
    {
        public FrTaiKhoan()
        {
            InitializeComponent();
        }
        DangNhapTaiKhoan dntk = new DangNhapTaiKhoan();
        private void FrTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDT.tblDangNhap' table. You can move, or remove it, as needed.
            this.tblDangNhapTableAdapter.Fill(this.qLDT.tblDangNhap);
            txttendn.ReadOnly = true;
            txtmk.ReadOnly = true;
            
            cbquyen.Enabled = false;

            cbquyen.Enabled = false;
            cbquyen.Visible = true;
            comboBox1.Visible = false;
            buttonOK.Enabled = false;
            buttonOK.Visible = true;
            btnOk2.Visible = true;
            btnOk2.Enabled = false;
            btnThemMoi.Enabled = true;
            btnChihsua.Enabled = true;
            btnDelete.Enabled = true;
            binding();
        }
        public void binding()
        {
            txttendn.DataBindings.Clear();
            txttendn.DataBindings.Add("text", dtgHienthi.DataSource, "TenDangNhap");
            txtmk.DataBindings.Clear();
            txtmk.DataBindings.Add("text", dtgHienthi.DataSource, "MatKhau");
            cbquyen.DataBindings.Clear();
            cbquyen.DataBindings.Add("Text", dtgHienthi.DataSource, "QuyenDangNhap");
            
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txttendn.ResetText();
            txttendn.ReadOnly = false;
            txtmk.Clear();
            txtmk.ReadOnly = false;
            
           
            cbquyen.Visible = false;
            comboBox1.Visible = true;
            comboBox1.Enabled = true;
            buttonOK.Enabled = true;
            buttonOK.Visible = true;
            btnOk2.Visible = false;
            btnOk2.Enabled = false;
            btnThemMoi.Enabled = false;
            btnChihsua.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnChihsua_Click(object sender, EventArgs e)
        {
            
            txttendn.ReadOnly = true;
            txtmk.Clear();
            txtmk.ReadOnly = false;

            cbquyen.Visible = false;
            comboBox1.Visible = true;
            comboBox1.Enabled = true;

            buttonOK.Enabled = true;
            buttonOK.Visible = true;
            btnOk2.Visible = false;
            btnOk2.Enabled = false;
            btnThemMoi.Enabled = false;
            btnChihsua.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin tài khoản này không?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (txttendn.Text=="Administrator")
                {
                    MessageBox.Show("Bạn không thể xóa tài khoản quyền Admin?", "Cảnh báo");
                }
                else
                {
                    dntk.XoaTaiKhoan(txttendn.Text);
                    MessageBox.Show("Đã xóa tài khoản: " + txttendn.Text + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrTaiKhoan_Load(sender, e);
                }
            }
        }

        private void cbquyen_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cbquyen_TextChanged(object sender, EventArgs e)
        {
            if (cbquyen.Text == "1")
            {
                cbquyen.Text = "Admin";
            } else if  (cbquyen.Text == "2")
                {
                    cbquyen.Text = "Cán bộ";
                }
            else if (cbquyen.Text == "3")
            {
                cbquyen.Text = "Học viên";
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
                dt = dntk.TimKiemTK(txtTimKiem.Text);
                dtgHienthi.DataSource = dt;

            }
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            FrTaiKhoan_Load(sender, e);
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
            if (this.txttendn.TextLength == 0)
            {
                MessageBox.Show("Tên đăng nhập không được để trống");
                this.txttendn.Focus();
            }
            else
                if (this.txtmk.TextLength < 5)
            {
                MessageBox.Show("Mật khẩu quá ngắn xin nhập lại");
                this.txtmk.Focus();
            }
            else
                if (this.txtmk.TextLength == 0)
            {
                MessageBox.Show("Mật khẩu không được để trống xin nhập lại");
                this.txtmk.Focus();
            }

            else
            {
                try
                {
                    int mk = 0;
                    if (txttendn.Text == "Administrator")
                    {
                        MessageBox.Show("Không thể thêm tài khoản Administrator");
                    }
                    else
                    {
                        if (comboBox1.Text == "Admin")
                        {
                            mk = 1;
                        }
                        else if (comboBox1.Text == "Cán bộ")
                        {
                            mk = 2;
                        }
                        else if (comboBox1.Text == "Học viên")
                        { mk = 3; }



                        dntk.ThemTaiKhoan(txttendn.Text, txtmk.Text, mk);
                        MessageBox.Show("Đã thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrTaiKhoan_Load(sender, e);

                    }


                }
                catch
                {
                    MessageBox.Show("Tài khoản " + this.txttendn.Text + " đã tồn tại");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FrTaiKhoan_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }

        private void btnOk2_Click(object sender, EventArgs e)
        {
            
                if (this.txtmk.TextLength < 5)
            {
                MessageBox.Show("Mật khẩu quá ngắn xin nhập lại");
                this.txtmk.Focus();
            }
            else
                if (this.txtmk.TextLength == 0)
            {
                MessageBox.Show("Mật khẩu không được để trống xin nhập lại");
                this.txtmk.Focus();
            }

            else
            {
                try
                {
                    int mk=0;
                   
                        if(comboBox1.Text == "Admin")
                        {
                            mk = 1;
                        }
                        else if (comboBox1.Text == "Cán bộ")
                        {
                            mk = 2;
                        }
                        else if (comboBox1.Text == "Học viên")
                        { mk = 3; }


                        dntk.SuaTaiKhoan(txttendn.Text, txtmk.Text, mk);
                        MessageBox.Show("Đã sửa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrTaiKhoan_Load(sender, e);
                    
                    
                       

                    



                }
                catch
                {
                    MessageBox.Show("Tài khoản " + this.txttendn.Text + " không thể thay đổi được");
                }
            }
        }
    }
}
