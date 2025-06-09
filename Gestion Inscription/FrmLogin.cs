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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            string[] TypeUtilisateur = { "Enseignant", "Etudiant", "Visiteur" };
            cmbUtilisateur.Items.AddRange(TypeUtilisateur);
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (cmbUtilisateur.Text == "Enseignant")
            {
                if (txtMotDePasse.Text == "enseignant21" && txtUtilisateur.Text == "enseignant")
                {
                    MessageBox.Show("Connexion reussie en tant qu'Enseignant", "Affichage connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nom d'utilisateur ou Mot de passe incorrects; Veuillez entrer les bonnes information", "Affichage connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (cmbUtilisateur.Text == "Etudiant")
            {
                if (txtMotDePasse.Text == "etudiant23" && txtUtilisateur.Text == "etudiant")
                {
                    MessageBox.Show("Connexion reussie en tant qu'Etudiant", "Affichage connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nom d'utilisateur ou Mot de passe incorrects; Veuillez entrer les bonnes information", "Affichage connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else if (cmbUtilisateur.Text == "Visiteur")
            {
                if (txtMotDePasse.Text == "visiteur24" && txtUtilisateur.Text == "visiteur")
                {
                    MessageBox.Show("Connexion reussie en tant que Visiteur", "Affichage connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nom d'utilisateur ou Mot de passe incorrects; Veuillez entrer les bonnes information", "Affichage connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            else
            {
                MessageBox.Show("Nom d'utilisateur ou Mot de passe incorrects; Veuillez entrer les bonnes information", "Affichage connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
