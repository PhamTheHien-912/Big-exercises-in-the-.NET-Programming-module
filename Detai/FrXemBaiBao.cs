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
    public partial class FrXemBaiBao : Form
    {
        public FrXemBaiBao()
        {
            InitializeComponent();
        }
        XemBaiBao xembaibao = new XemBaiBao();
        public static string quyen;
        private void FrXemBaiBao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDT.View_3' table. You can move, or remove it, as needed.
            this.view_3TableAdapter.Fill(this.qLDT.View_3);
            CanboLoad();
        }
        public void CanboLoad()
        {
            dangnhap1TableAdapters.QueriesTableAdapter dn = new dangnhap1TableAdapters.QueriesTableAdapter();
            if (dn.CheckQuyenCB1(quyen) == 1 || dn.CheckQuyenAdmin(quyen) == 1)
            {
                bntIn.Enabled = true;


            }
            else
            {
                bntIn.Enabled = false;
            }
        }

        private void brnDoimk_Click(object sender, EventArgs e)
        {
            DoiMk doiMk = new DoiMk();
            doiMk.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Dispose();
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
                dt = xembaibao.TimKiemXemBaiBao(txtTimKiem.Text);
                dtgHienthi.DataSource = dt;

            }

        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            FrXemBaiBao_Load(sender, e);
            txtTimKiem.ResetText();
            this.txtTimKiem.Focus();
        }

        private void bntIn_Click(object sender, EventArgs e)
        {
            InBaiBao inBaiBao = new InBaiBao();
            inBaiBao.Show();
        }
    }
}
