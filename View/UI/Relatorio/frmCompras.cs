using System;
using System.Windows.Forms;

namespace View.Enum.UI.Relatorio
{
    public partial class frmCompras : Form
    {
        public frmCompras()
        {
            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            this.scalarQueryTableAdapter.Fill(this.relatorios.ScalarQuery);
            this.reportViewer1.RefreshReport();
        }
    }
}
