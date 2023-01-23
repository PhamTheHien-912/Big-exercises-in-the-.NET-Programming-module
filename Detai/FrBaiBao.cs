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
using Detai.QLDT1TableAdapters;

namespace Detai
{
    public partial class FrBaiBao : Form
    {
        public FrBaiBao()
        {
            InitializeComponent();
        }
        BaiBaoKH bb = new BaiBaoKH();
        public static string quyen;
        private void FrBaiBao_Load(object sender, EventArgs e)
        {
            




            DataTable dt = new DataTable();
            dt = bb.HienthiBaiBao();
            dtgHienthi.DataSource = dt;
            txtbaibao.ReadOnly = true;
            txtmota.ReadOnly = true;
            txttenbaibao.ReadOnly = true;

            dtpthoigian.Visible = false;
            cbmaloaiBB.Enabled = false;
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
                btnChihsua.Enabled = false;
                btnThemMoi.Enabled = false;

            }
        }

        public void binding()
        {
            txtbaibao.DataBindings.Clear();
            txtbaibao.DataBindings.Add("text", dtgHienthi.DataSource, "MaBaiBao");
            txttenbaibao.DataBindings.Clear();
            txttenbaibao.DataBindings.Add("text", dtgHienthi.DataSource, "TenBaiBao");
            txtthoigian.DataBindings.Clear();
            txtthoigian.DataBindings.Add("text", dtgHienthi.DataSource, "ThoiGian");
            txtmota.DataBindings.Clear();
            txtmota.DataBindings.Add("text", dtgHienthi.DataSource, "Mota");
            cbmatg.DataBindings.Clear();
            cbmatg.DataBindings.Add("text", dtgHienthi.DataSource, "MaTacGia");
            cbmaloaiBB.DataBindings.Clear();
            cbmaloaiBB.DataBindings.Add("text", dtgHienthi.DataSource, "MaloaiBaiBao");
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtbaibao.ResetText();
            txtbaibao.ReadOnly = false;
            txttenbaibao.Clear();
            txttenbaibao.ReadOnly = false;
            txtmota.Clear();
            txtmota.ReadOnly = false;
            dtpthoigian.Visible = true;
            cbmaloaiBB.Enabled = true;
            cbmatg.Enabled = true;
            txtthoigian.Visible = false;
            buttonOK.Enabled = true;
            buttonOK.Visible = true;
            btnOk2.Visible = false;
            btnOk2.Enabled = false;
            btnThemMoi.Enabled = false;
            btnChihsua.Enabled = false;
            btnDelete.Enabled = false;
            // TODO: This line of code loads data into the 'qLDT.tblMaLoaiBaiBao' table. You can move, or remove it, as needed.
            this.tblMaLoaiBaiBaoTableAdapter.Fill(this.qLDT.tblMaLoaiBaiBao);
            // TODO: This line of code loads data into the 'qLDT.tbTacGia' table. You can move, or remove it, as needed.
            this.tbTacGiaTableAdapter.Fill(this.qLDT.tbTacGia);

        }

        private void btnChihsua_Click(object sender, EventArgs e)
        {
            txtbaibao.ReadOnly = true;

            txttenbaibao.ReadOnly = false;
            txtmota.Clear();
            txtmota.ReadOnly = false;
            dtpthoigian.Visible = true;
            cbmaloaiBB.Enabled = true;
            cbmatg.Enabled = true;
            txtthoigian.Visible = false;
            buttonOK.Enabled = false;
            buttonOK.Visible = false;
            btnOk2.Visible = true;
            btnOk2.Enabled = true;
            btnThemMoi.Enabled = false;
            btnChihsua.Enabled = false;
            btnDelete.Enabled = false;
            // TODO: This line of code loads data into the 'qLDT.tbTacGia' table. You can move, or remove it, as needed.
            this.tbTacGiaTableAdapter.Fill(this.qLDT.tbTacGia);
            // TODO: This line of code loads data into the 'qLDT.tblMaLoaiBaiBao' table. You can move, or remove it, as needed.
       
            // TODO: This line of code loads data into the 'qLDT.tblMaLoaiBaiBao' table. You can move, or remove it, as needed.
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin bài báo này không?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bb.XoaBaiBao(txtbaibao.Text);
                MessageBox.Show("Đã xóa thông tin đề tài: " + txtbaibao.Text + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrBaiBao_Load(sender, e);
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
                dt = bb.TimKiemBaiBao(txtTimKiem.Text);
                dtgHienthi.DataSource = dt;

            }
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            FrBaiBao_Load(sender, e);
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
            if (this.txtbaibao.TextLength == 0)
            {
                MessageBox.Show("Mã bài báo không được để trống");
                this.txtbaibao.Focus();
            }
            else
                if (this.txttenbaibao.TextLength < 5)
            {
                MessageBox.Show("Tên bài báo quá ngắn xin nhập lại");
                this.txttenbaibao.Focus();
            }
            else
                    if (this.txttenbaibao.TextLength == 0)
            {
                MessageBox.Show("Tên bài báo không được để trống");
                this.txttenbaibao.Focus();
            }
            else
                    if (this.txtmota.TextLength == 0)
            {
                MessageBox.Show("Mô tả không được để trống");
                this.txtmota.Focus();
            }

            else
            {
                try
                {
                    bb.ThemBaiBao(txtbaibao.Text, txttenbaibao.Text, dtpthoigian.Text,txtmota.Text, cbmaloaiBB.SelectedValue.ToString(), cbmatg.Text);
                    MessageBox.Show("Đã thêm bài báo thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrBaiBao_Load(sender, e);


                }
                catch
                {
                    MessageBox.Show("Bài báo " + this.txtbaibao.Text + " đã tồn tại");
                }
            }
        }

        private void btnOk2_Click(object sender, EventArgs e)
        {

            if (this.txttenbaibao.TextLength < 5)
            {
                MessageBox.Show("Tên bài báo quá ngắn xin nhập lại");
                this.txttenbaibao.Focus();
            }
            else
                if (this.txttenbaibao.TextLength == 0)
            {
                MessageBox.Show("Tên đề tài không được để trống");
                this.txttenbaibao.Focus();
            }
            else
                    if (this.txtmota.TextLength == 0)
            {
                MessageBox.Show("Mô tả không được để trống");
                this.txtmota.Focus();
            }
            else
            {
                try
                {
                    bb.SuaBaiBao(txtbaibao.Text, txttenbaibao.Text, dtpthoigian.Text, txtmota.Text, cbmaloaiBB.SelectedValue.ToString(), cbmatg.Text);
                    MessageBox.Show("Đã sửa thông tin bài báo: " + txtbaibao.Text + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrBaiBao_Load(sender, e);


                }
                catch
                {
                    MessageBox.Show("Đề tài " + this.txtbaibao.Text + " đã tồn tại");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FrBaiBao_Load(sender, e);
        }
    }
}
