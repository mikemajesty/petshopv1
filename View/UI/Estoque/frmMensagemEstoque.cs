using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.UI.ViewEstoque
{
    public partial class frmMensagemEstoque : Form
    {
        public frmMensagemEstoque()
        {
            InitializeComponent();
        }

        private void frmMensagemEstoque_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = this.Location.X;
            int y = this.Location.Y;
            MessageBox.Show("Angulo X="+x+"\nAnlgulo y="+y);
        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
