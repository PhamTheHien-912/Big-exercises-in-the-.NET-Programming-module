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
    public partial class InBaiBao : Form
    {
        public InBaiBao()
        {
            InitializeComponent();
        }

        private void InBaiBao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLDT1.View_3' table. You can move, or remove it, as needed.
            this.View_3TableAdapter.Fill(this.QLDT1.View_3);

            this.reportViewer1.RefreshReport();
        }
    }
}
