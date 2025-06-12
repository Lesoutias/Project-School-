using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inscriptiondb
{
    public partial class FrmInscription : Form
    {
        public FrmInscription()
        {
            InitializeComponent();
        }

        private void FrmInscription_Load(object sender, EventArgs e)
        {
            string[] AnneeAcad = { "2023-2024", "2024-2025", "2025-2026" };
            cmbAnneeAcad.Items.AddRange(AnneeAcad);
            cmbProm.DataSource = new Promotion().getPromotion();
            cmbProm.ValueMember = "Code";
            cmbProm.DisplayMember = "Designation";


            cmbMat.DataSource = new Etudiant().getEtudiant();
            cmbMat.ValueMember = "Matricule";
            cmbMat.DisplayMember = "Nom";
            dgvInscription.DataSource = inscri.getInscription();
            btnModifierInscription.Enabled = false;
            btnSupprimerInscription.Enabled = false;
        }

        Inscription inscri = new Inscription();
        private void Valeur()
        {
            inscri.MatriculeEtudiant = cmbMat.SelectedValue.ToString();
            inscri.CodePromotion = Convert.ToInt32(cmbProm.SelectedValue);
            inscri.DateInscription = txtDateInscr.Text;
            inscri.Observation = txtObserv.Text;
            inscri.AnneeAcademinque1 = cmbAnneeAcad.Text;
        }

        private void ClearText()
        {
            txtId.Text = "";
            cmbMat.Text = "";
            cmbProm.Text = "";
            txtDateInscr.Text = "";
            txtObserv.Text = "";
            cmbAnneeAcad.Text = "";
        }

        private void btnAjouterInscription_Click(object sender, EventArgs e)
        {
            Valeur();
            int resultat = inscri.AjouterInscription(inscri);
            if (resultat > 0)
            {
                MessageBox.Show("Etudiant ajoutée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearText();
                dgvInscription.DataSource = inscri.getInscription();
            }
            else
            {
                MessageBox.Show("Erreur lors de l'ajout de l'Etudiant.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
