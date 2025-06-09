namespace Gestion_Inscription
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnQuitter = new Button();
            btnConnexion = new Button();
            txtMotDePasse = new TextBox();
            txtUtilisateur = new TextBox();
            cmbUtilisateur = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnQuitter);
            groupBox1.Controls.Add(btnConnexion);
            groupBox1.Controls.Add(txtMotDePasse);
            groupBox1.Controls.Add(txtUtilisateur);
            groupBox1.Controls.Add(cmbUtilisateur);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(33, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(556, 358);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // btnQuitter
            // 
            btnQuitter.Location = new Point(367, 308);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(94, 29);
            btnQuitter.TabIndex = 7;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = true;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // btnConnexion
            // 
            btnConnexion.Location = new Point(189, 308);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(94, 29);
            btnConnexion.TabIndex = 6;
            btnConnexion.Text = "Connexion";
            btnConnexion.UseVisualStyleBackColor = true;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // txtMotDePasse
            // 
            txtMotDePasse.Location = new Point(186, 220);
            txtMotDePasse.Name = "txtMotDePasse";
            txtMotDePasse.Size = new Size(319, 27);
            txtMotDePasse.TabIndex = 5;
            // 
            // txtUtilisateur
            // 
            txtUtilisateur.Location = new Point(188, 134);
            txtUtilisateur.Name = "txtUtilisateur";
            txtUtilisateur.Size = new Size(317, 27);
            txtUtilisateur.TabIndex = 4;
            // 
            // cmbUtilisateur
            // 
            cmbUtilisateur.FormattingEnabled = true;
            cmbUtilisateur.Location = new Point(186, 58);
            cmbUtilisateur.Name = "cmbUtilisateur";
            cmbUtilisateur.Size = new Size(319, 28);
            cmbUtilisateur.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 139);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 2;
            label3.Text = "Nom Utilisateur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 227);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 1;
            label2.Text = "Mot de Passe";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 55);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Type Utilisateur";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 382);
            Controls.Add(groupBox1);
            Name = "FrmLogin";
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtMotDePasse;
        private TextBox txtUtilisateur;
        private ComboBox cmbUtilisateur;
        private Label label3;
        private Button btnQuitter;
        private Button btnConnexion;
    }
}