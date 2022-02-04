using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treino1
{
    public partial class Fase1 : Form
    {
        int Moral;
        int Dinheiro;
        public Fase1()
        {
            InitializeComponent();
        }

        private void lblMoral_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trabaiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trabaia1 ProxForm = new Trabaia1();
            this.Hide();
            ProxForm.ShowDialog();
        }
    }
}
