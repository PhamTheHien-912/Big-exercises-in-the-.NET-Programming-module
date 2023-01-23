using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Detai
{
    public partial class Form1 : Form
    {
        public static string quyen;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dangnhap1TableAdapters.QueriesTableAdapter dn = new dangnhap1TableAdapters.QueriesTableAdapter();
            if(dn.CheckQuyenAdmin(quyen)==1)
            {
                bntBaiBao.Enabled = true;
                btnAbout.Enabled = true;
                btnAddAcc.Enabled = true;
                btnTTBaiBao.Enabled=true;
                btnTTDeTai.Enabled=true;
                bntDeTai.Enabled = true;
                bnttacgia.Enabled = true;
                brnDoimk.Enabled = true;
                //bntTK.Enabled = true;

            }
            else if(dn.CheckQuyenCB1(quyen) == 1)
            {
                bntBaiBao.Enabled = true;
                btnAbout.Enabled = true;
                btnAddAcc.Enabled = false;
                btnTTBaiBao.Enabled = true;
                btnTTDeTai.Enabled = true;
                bntDeTai.Enabled = true;
                bnttacgia.Enabled = true;
                brnDoimk.Enabled = true;
            } 
            else
            {
                bntBaiBao.Enabled = false;
                btnAbout.Enabled = true;
                btnAddAcc.Enabled = false;
                btnTTBaiBao.Enabled = true;
                btnTTDeTai.Enabled = true;
                bntDeTai.Enabled = false;
                bnttacgia.Enabled = false;
                brnDoimk.Enabled = true;

            }
           
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            FrDeTai formnew = new FrDeTai();
            formnew.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void btnNienKhoa_Click(object sender, EventArgs e)
        {
            FrXemBaiBao frXemBaiBao = new FrXemBaiBao();
            frXemBaiBao.Show();
            Hide();
        }

        private void btnHocVien_Click(object sender, EventArgs e)
        {
            //Hoc_Vien hocvien = new Hoc_Vien();
            //hocvien.Show();
        }

        private void btnBaiBao_Click(object sender, EventArgs e)
        {
            FrBaiBao formnew = new FrBaiBao();
            formnew.Show();
            this.Hide();
        }

        private void btnDiemTheoLop_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void btnQuyDinh_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXemDeTai_Click(object sender, EventArgs e)
        {
            FrXemDeTai frXemDeTai = new FrXemDeTai();
            frXemDeTai.Show();
            Hide();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Hide();
        }

        private void BtnExi_Click(object sender, EventArgs e)
        {
            Close();
            System.Windows.Forms.Application.Exit();
        }

        private void BtnAn_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            if (this.MaximizeBox == true) this.MinimizeBox = true;
            else this.MaximizeBox = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Close();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Hiển thị lại Form nếu doubleclick vào icon dưới System tray
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void brnDoimk_Click(object sender, EventArgs e)
        {
            DoiMk doimk = new DoiMk();
            doimk.Show();
        }

        private void BtnAddAcc_Click(object sender, EventArgs e)
        {
            FrTaiKhoan tk = new FrTaiKhoan();
            tk.Show();
            Hide();
        }

        private void bnttacgia_Click(object sender, EventArgs e)
        {
            FrTacGia tg = new FrTacGia();
            tg.Show();
            this.Hide();
        }

        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();

        }
    }
}
