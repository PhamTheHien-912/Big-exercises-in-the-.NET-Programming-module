using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessLogic;
using Microsoft.SqlServer.Server;
using System.Collections.Specialized;

namespace Detai
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            dangnhap1TableAdapters.QueriesTableAdapter dn = new dangnhap1TableAdapters.QueriesTableAdapter();
            if (dn.CheckDangNhap(txtten.Text, txtpass.Text) == 1)
            {
                Form1.quyen = txtten.Text;
                FrDeTai.quyen = txtten.Text;
                FrBaiBao.quyen = txtten.Text;
                FrTacGia.quyen = txtten.Text;
                FrXemBaiBao.quyen = txtten.Text;
                FrXemDeTai.quyen = txtten.Text;
                if (MessageBox.Show("Bạn có muốn đăng nhập bằng tài khoản và mật khẩu này không?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Form1 main = new Form1();
                    main.Show();
                    Hide();
                }
            }
            else
            {
                if (this.txtten.TextLength == 0)
                {
                    MessageBox.Show("Tài khoản không được để trống", "Cảnh báo");
                    if (this.txtpass.TextLength == 0)
                        MessageBox.Show("Mật khẩu không được để trống", "Cảnh báo");

                }
                else if (this.txtpass.TextLength == 0)
                {
                    MessageBox.Show("Mật khẩu không được để trống", "Cảnh báo");
                }

                else MessageBox.Show("Tài khoản và mật khẩu không đúng? Vui lòng thử lại", "Cảnh báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtten.ResetText();
            txtpass.ResetText();
            txtten.Focus();
        }
    }
}
