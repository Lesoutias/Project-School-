using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Inscription
{
    public partial class FrmTextBoxMultiligne : Form
    {
        public FrmTextBoxMultiligne()
        {
            InitializeComponent();
        }

        private void FrmTextBoxMultiligne_Load(object sender, EventArgs e)
        {
            textSaisie.Focus();
        }

        private void textSaisie_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            textBoxMultiline.Text += textSaisie.Text+Environment.NewLine;
            textSaisie.Clear();
        }
    }
}
