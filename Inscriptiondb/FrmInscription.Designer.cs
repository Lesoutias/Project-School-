namespace Inscriptiondb
{
    partial class FrmInscription
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
            txtId = new TextBox();
            txtDateInscr = new TextBox();
            txtObserv = new TextBox();
            btnAjouterInscription = new Button();
            btnModifierInscription = new Button();
            btnSupprimerInscription = new Button();
            cmbAnneeAcad = new ComboBox();
            dgvInscription = new DataGridView();
            cmbMat = new ComboBox();
            cmbProm = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvInscription).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(260, 49);
            label1.Name = "label1";
            label1.Size = new Size(514, 47);
            label1.TabIndex = 0;
            label1.Text = "Formulaire pour l'Inscription";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 154);
            label2.Name = "label2";
            label2.Size = new Size(47, 31);
            label2.TabIndex = 1;
            label2.Text = "Id :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(70, 333);
            label3.Name = "label3";
            label3.Size = new Size(202, 31);
            label3.TabIndex = 2;
            label3.Text = "Code Promotion :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(70, 240);
            label4.Name = "label4";
            label4.Size = new Size(226, 31);
            label4.TabIndex = 3;
            label4.Text = "Matricule Etudiant :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(70, 426);
            label5.Name = "label5";
            label5.Size = new Size(233, 31);
            label5.TabIndex = 4;
            label5.Text = "Annee Academique :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(70, 517);
            label6.Name = "label6";
            label6.Size = new Size(198, 31);
            label6.TabIndex = 5;
            label6.Text = "Date Inscription :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(70, 604);
            label7.Name = "label7";
            label7.Size = new Size(167, 31);
            label7.TabIndex = 6;
            label7.Text = "Observations :";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(364, 160);
            txtId.Name = "txtId";
            txtId.Size = new Size(306, 27);
            txtId.TabIndex = 7;
            // 
            // txtDateInscr
            // 
            txtDateInscr.Location = new Point(361, 523);
            txtDateInscr.Name = "txtDateInscr";
            txtDateInscr.Size = new Size(306, 27);
            txtDateInscr.TabIndex = 10;
            // 
            // txtObserv
            // 
            txtObserv.Location = new Point(361, 610);
            txtObserv.Multiline = true;
            txtObserv.Name = "txtObserv";
            txtObserv.Size = new Size(309, 173);
            txtObserv.TabIndex = 11;
            // 
            // btnAjouterInscription
            // 
            btnAjouterInscription.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjouterInscription.Location = new Point(281, 843);
            btnAjouterInscription.Name = "btnAjouterInscription";
            btnAjouterInscription.Size = new Size(104, 39);
            btnAjouterInscription.TabIndex = 12;
            btnAjouterInscription.Text = "Ajouter";
            btnAjouterInscription.UseVisualStyleBackColor = true;
            btnAjouterInscription.Click += btnAjouterInscription_Click;
            // 
            // btnModifierInscription
            // 
            btnModifierInscription.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModifierInscription.Location = new Point(423, 843);
            btnModifierInscription.Name = "btnModifierInscription";
            btnModifierInscription.Size = new Size(104, 39);
            btnModifierInscription.TabIndex = 13;
            btnModifierInscription.Text = "Modifier";
            btnModifierInscription.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerInscription
            // 
            btnSupprimerInscription.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupprimerInscription.Location = new Point(567, 843);
            btnSupprimerInscription.Name = "btnSupprimerInscription";
            btnSupprimerInscription.Size = new Size(126, 39);
            btnSupprimerInscription.TabIndex = 14;
            btnSupprimerInscription.Text = "Supprimer";
            btnSupprimerInscription.UseVisualStyleBackColor = true;
            // 
            // cmbAnneeAcad
            // 
            cmbAnneeAcad.FormattingEnabled = true;
            cmbAnneeAcad.Location = new Point(360, 432);
            cmbAnneeAcad.Name = "cmbAnneeAcad";
            cmbAnneeAcad.Size = new Size(307, 28);
            cmbAnneeAcad.TabIndex = 15;
            // 
            // dgvInscription
            // 
            dgvInscription.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInscription.Location = new Point(714, 160);
            dgvInscription.Name = "dgvInscription";
            dgvInscription.RowHeadersWidth = 51;
            dgvInscription.Size = new Size(687, 722);
            dgvInscription.TabIndex = 16;
            // 
            // cmbMat
            // 
            cmbMat.FormattingEnabled = true;
            cmbMat.Location = new Point(364, 251);
            cmbMat.Name = "cmbMat";
            cmbMat.Size = new Size(303, 28);
            cmbMat.TabIndex = 17;
            // 
            // cmbProm
            // 
            cmbProm.FormattingEnabled = true;
            cmbProm.Location = new Point(364, 339);
            cmbProm.Name = "cmbProm";
            cmbProm.Size = new Size(301, 28);
            cmbProm.TabIndex = 18;
            // 
            // FrmInscription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1413, 987);
            Controls.Add(cmbProm);
            Controls.Add(cmbMat);
            Controls.Add(dgvInscription);
            Controls.Add(cmbAnneeAcad);
            Controls.Add(btnSupprimerInscription);
            Controls.Add(btnModifierInscription);
            Controls.Add(btnAjouterInscription);
            Controls.Add(txtObserv);
            Controls.Add(txtDateInscr);
            Controls.Add(txtId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmInscription";
            Text = "FrmInscription";
            Load += FrmInscription_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInscription).EndInit();
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
        private TextBox txtId;
        private TextBox txtDateInscr;
        private TextBox txtObserv;
        private Button btnAjouterInscription;
        private Button btnModifierInscription;
        private Button btnSupprimerInscription;
        private ComboBox cmbAnneeAcad;
        private DataGridView dgvInscription;
        private ComboBox cmbMat;
        private ComboBox cmbProm;
    }
}