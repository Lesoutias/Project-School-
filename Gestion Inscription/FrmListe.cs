using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Inscription
{
    public partial class FrmListe : Form
    {
        public FrmListe()
        {
            InitializeComponent();
        }

        private void FrmListe_Load(object sender, EventArgs e)
        {
            btnAjouter.Enabled = false;
            btnAffecterlist1.Enabled = false;
            btnAffectelist2.Enabled = false;
            btnEffacerList1.Enabled = false;
            btnEffacerList2.Enabled = false;
        }

        private void txtSaisi_TextChanged(object sender, EventArgs e)
        {
            if (txtSaisi.Text != "")
            {
                btnAjouter.Enabled = true;
            }
            else
            {
                btnAjouter.Enabled = false;
            }

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            list1.Items.Add(txtSaisi.Text);
            txtSaisi.Text = "";
            txtSaisi.Focus();
            btnAjouter.Enabled = false;
        }

        private void list1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list1.SelectedItems.Count > 0)
            {
                btnAffectelist2.Enabled = true;
            }
            else
            {
                btnAffectelist2.Enabled = false;
            }
            if (list1 != null)
            {
                btnEffacerList1.Enabled = true;
            }
            else
            {
                btnEffacerList1.Enabled = false;
            }
        }

        private void btnAffectelist2_Click(object sender, EventArgs e)
        {
            list2.Items.Add(list1.SelectedItem);
            list1.Items.Remove(list1.SelectedItem);
            if (list1.Items.Count == 0)
            {
                btnEffacerList1.Enabled = false;
            }
        }

        private void list2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list2.SelectedItems.Count > 0)
            {
                btnAffecterlist1.Enabled = true;
            }
            else
            {
                btnAffecterlist1.Enabled = false;
            }
            if (list2 != null)
            {
                btnEffacerList2.Enabled = true;
            }
            else
            {
                btnEffacerList2.Enabled = false;
            }
        }

        private void btnAffecterlist1_Click(object sender, EventArgs e)
        {
            list1.Items.Add(list2.SelectedItem);
            list2.Items.Remove(list2.SelectedItem);
            if (list2.Items.Count == 0)
            {
                btnEffacerList2.Enabled = false;
            }
        }

        private void btnEffacerList1_Click(object sender, EventArgs e)
        {

            list1.Items.Clear();
            btnEffacerList1.Enabled = false;
        }

        private void btnEffacerList2_Click(object sender, EventArgs e)
        {
            list2.Items.Clear();
            btnEffacerList2.Enabled = false;
        }
    }
}
