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
    public partial class InDeTai : Form
    {
        public InDeTai()
        {
            InitializeComponent();
        }

        private void InDeTai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLDT1.View_2' table. You can move, or remove it, as needed.
            this.View_2TableAdapter.Fill(this.QLDT1.View_2);

            this.reportViewer2.RefreshReport();
        }
    }
}
