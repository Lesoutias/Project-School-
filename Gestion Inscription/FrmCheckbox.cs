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
    public partial class FrmCheckbox : Form
    {
        public FrmCheckbox()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (rbFeminin.Checked)
            {
                if (chkMoustiquaire.Checked)
                {
                    MessageBox.Show("Vous etes une femme et vous dormez sous moustiquaire", "Affichage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vous etes une femme et vous ne dormez pas sous moustiquaire", "Affichage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (chkMoustiquaire.Checked)
                {
                    MessageBox.Show("Vous etes un homme et vous dormez sous moustiquaire", "Affichage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vous etes un homme et vous ne dormez pas sous moustiquaire", "Affichage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void rbMaculin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmCheckbox_Load(object sender, EventArgs e)
        {
           rbMaculin.Checked = true;
        }
    }
}
