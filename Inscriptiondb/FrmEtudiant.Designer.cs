namespace Inscriptiondb
{
    partial class FrmEtudiant
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtMatricule = new TextBox();
            txtNom = new TextBox();
            txtPostNom = new TextBox();
            txtPrenom = new TextBox();
            txtDateNaiss = new TextBox();
            txtLieuNaiss = new TextBox();
            cmbEtatCivil = new ComboBox();
            btnAjouter = new Button();
            btnModifier = new Button();
            btnSupprimer = new Button();
            dgvEtudiant = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEtudiant).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(187, 9);
            label1.Name = "label1";
            label1.Size = new Size(696, 47);
            label1.TabIndex = 0;
            label1.Text = "Formulaire d'Inscription pour l'Etudiant";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 157);
            label2.Name = "label2";
            label2.Size = new Size(79, 31);
            label2.TabIndex = 1;
            label2.Text = "Nom :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 225);
            label3.Name = "label3";
            label3.Size = new Size(125, 31);
            label3.TabIndex = 2;
            label3.Text = "PostNom :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 94);
            label4.Name = "label4";
            label4.Size = new Size(129, 31);
            label4.TabIndex = 3;
            label4.Text = "Matricule :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(45, 293);
            label5.Name = "label5";
            label5.Size = new Size(110, 31);
            label5.TabIndex = 4;
            label5.Text = "Prenom :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(45, 360);
            label6.Name = "label6";
            label6.Size = new Size(115, 31);
            label6.TabIndex = 5;
            label6.Text = "Etat Civil:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(45, 435);
            label7.Name = "label7";
            label7.Size = new Size(220, 31);
            label7.TabIndex = 6;
            label7.Text = "Date de Naissance :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(45, 511);
            label8.Name = "label8";
            label8.Size = new Size(215, 31);
            label8.TabIndex = 7;
            label8.Text = "Lieu de Naissance :";
            // 
            // txtMatricule
            // 
            txtMatricule.Location = new Point(352, 98);
            txtMatricule.Name = "txtMatricule";
            txtMatricule.Size = new Size(350, 27);
            txtMatricule.TabIndex = 8;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(352, 161);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(350, 27);
            txtNom.TabIndex = 9;
            // 
            // txtPostNom
            // 
            txtPostNom.Location = new Point(352, 229);
            txtPostNom.Name = "txtPostNom";
            txtPostNom.Size = new Size(350, 27);
            txtPostNom.TabIndex = 10;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(352, 297);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(350, 27);
            txtPrenom.TabIndex = 11;
            // 
            // txtDateNaiss
            // 
            txtDateNaiss.Location = new Point(352, 439);
            txtDateNaiss.Name = "txtDateNaiss";
            txtDateNaiss.Size = new Size(350, 27);
            txtDateNaiss.TabIndex = 12;
            // 
            // txtLieuNaiss
            // 
            txtLieuNaiss.Location = new Point(352, 515);
            txtLieuNaiss.Name = "txtLieuNaiss";
            txtLieuNaiss.Size = new Size(350, 27);
            txtLieuNaiss.TabIndex = 13;
            // 
            // cmbEtatCivil
            // 
            cmbEtatCivil.FormattingEnabled = true;
            cmbEtatCivil.Location = new Point(355, 370);
            cmbEtatCivil.Name = "cmbEtatCivil";
            cmbEtatCivil.Size = new Size(347, 28);
            cmbEtatCivil.TabIndex = 14;
            cmbEtatCivil.SelectedIndexChanged += cmbEtatCivil_SelectedIndexChanged;
            // 
            // btnAjouter
            // 
            btnAjouter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjouter.Location = new Point(297, 596);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(111, 41);
            btnAjouter.TabIndex = 15;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnModifier
            // 
            btnModifier.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModifier.Location = new Point(453, 596);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(110, 41);
            btnModifier.TabIndex = 16;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupprimer.Location = new Point(613, 596);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(121, 41);
            btnSupprimer.TabIndex = 17;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // dgvEtudiant
            // 
            dgvEtudiant.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEtudiant.Location = new Point(731, 98);
            dgvEtudiant.Name = "dgvEtudiant";
            dgvEtudiant.RowHeadersWidth = 51;
            dgvEtudiant.Size = new Size(840, 444);
            dgvEtudiant.TabIndex = 18;
            dgvEtudiant.CellDoubleClick += dgvEtudiant_CellDoubleClick;
            // 
            // FrmEtudiant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1583, 688);
            Controls.Add(dgvEtudiant);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(cmbEtatCivil);
            Controls.Add(txtLieuNaiss);
            Controls.Add(txtDateNaiss);
            Controls.Add(txtPrenom);
            Controls.Add(txtPostNom);
            Controls.Add(txtNom);
            Controls.Add(txtMatricule);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmEtudiant";
            Text = "FrmEtudiant";
            Load += FrmEtudiant_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEtudiant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtMatricule;
        private TextBox txtNom;
        private TextBox txtPostNom;
        private TextBox txtPrenom;
        private TextBox txtDateNaiss;
        private TextBox txtLieuNaiss;
        private ComboBox cmbEtatCivil;
        private Button btnAjouter;
        private Button btnModifier;
        private Button btnSupprimer;
        private DataGridView dgvEtudiant;
    }
}