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
    public partial class DoiMk : Form
    {
        public DoiMk()
        {
            InitializeComponent();
        }
       
        /// <summary>
       DangNhapTaiKhoan ac = new DangNhapTaiKhoan();
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtACC.ResetText();
            txtMK.ResetText();
            txtMKmoi.ResetText();
            txtACC.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dangnhap1TableAdapters.QueriesTableAdapter dn = new  dangnhap1TableAdapters.QueriesTableAdapter();
            if (txtACC.TextLength == 0) MessageBox.Show("Chưa nhập tên tài khoản");
            else if (txtMK.TextLength == 0) MessageBox.Show("Chưa nhập mật khẩu");
            else if (txtMKmoi.TextLength == 0) MessageBox.Show("Chưa nhập mật khẩu mới");
            else if (txtnhaplai.TextLength == 0) MessageBox.Show("Chưa nhập mật khẩu nhập lại");
            else if (txtMKmoi.Text != txtnhaplai.Text) MessageBox.Show("Nhập lại mật khẩu không đúng!");
            else if(dn.CheckDangNhap(txtACC.Text,txtMK.Text)==1)
            {
                try
                {
                    if (dn.CheckQuyenAdmin(txtACC.Text) == 1)
                    {
                        ac.SuaTaiKhoan(txtACC.Text, txtMKmoi.Text, 1);
                        MessageBox.Show("Cập nhập mật khẩu thành công");
                    }
                    else if (dn.CheckQuyenCB1(txtACC.Text) == 1)
                    {
                        ac.SuaTaiKhoan(txtACC.Text, txtMKmoi.Text, 2);
                        MessageBox.Show("Cập nhập mật khẩu thành công");
                    }
                    else
                    {
                        ac.SuaTaiKhoan(txtACC.Text, txtMKmoi.Text, 3);
                        MessageBox.Show("Cập nhập mật khẩu thành công");
                    }    


                }
                catch
                {
                }
            }    
            
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            }
        }

       
    }
}
