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
            txtMatEt = new TextBox();
            txtCodeProm = new TextBox();
            txtDateInscr = new TextBox();
            txtObserv = new TextBox();
            btnAjouterInscription = new Button();
            btnModifierInscription = new Button();
            btnSupprimerInscription = new Button();
            cmbAnneeAcad = new ComboBox();
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
            txtId.Location = new Point(361, 160);
            txtId.Name = "txtId";
            txtId.Size = new Size(413, 27);
            txtId.TabIndex = 7;
            // 
            // txtMatEt
            // 
            txtMatEt.Location = new Point(361, 246);
            txtMatEt.Name = "txtMatEt";
            txtMatEt.Size = new Size(413, 27);
            txtMatEt.TabIndex = 8;
            // 
            // txtCodeProm
            // 
            txtCodeProm.Location = new Point(361, 339);
            txtCodeProm.Name = "txtCodeProm";
            txtCodeProm.Size = new Size(413, 27);
            txtCodeProm.TabIndex = 9;
            // 
            // txtDateInscr
            // 
            txtDateInscr.Location = new Point(361, 523);
            txtDateInscr.Name = "txtDateInscr";
            txtDateInscr.Size = new Size(413, 27);
            txtDateInscr.TabIndex = 10;
            // 
            // txtObserv
            // 
            txtObserv.Location = new Point(361, 610);
            txtObserv.Multiline = true;
            txtObserv.Name = "txtObserv";
            txtObserv.Size = new Size(413, 218);
            txtObserv.TabIndex = 11;
            // 
            // btnAjouterInscription
            // 
            btnAjouterInscription.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjouterInscription.Location = new Point(360, 888);
            btnAjouterInscription.Name = "btnAjouterInscription";
            btnAjouterInscription.Size = new Size(104, 39);
            btnAjouterInscription.TabIndex = 12;
            btnAjouterInscription.Text = "Ajouter";
            btnAjouterInscription.UseVisualStyleBackColor = true;
            // 
            // btnModifierInscription
            // 
            btnModifierInscription.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModifierInscription.Location = new Point(503, 888);
            btnModifierInscription.Name = "btnModifierInscription";
            btnModifierInscription.Size = new Size(104, 39);
            btnModifierInscription.TabIndex = 13;
            btnModifierInscription.Text = "Modifier";
            btnModifierInscription.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerInscription
            // 
            btnSupprimerInscription.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupprimerInscription.Location = new Point(648, 888);
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
            cmbAnneeAcad.Size = new Size(414, 28);
            cmbAnneeAcad.TabIndex = 15;
            // 
            // FrmInscription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 987);
            Controls.Add(cmbAnneeAcad);
            Controls.Add(btnSupprimerInscription);
            Controls.Add(btnModifierInscription);
            Controls.Add(btnAjouterInscription);
            Controls.Add(txtObserv);
            Controls.Add(txtDateInscr);
            Controls.Add(txtCodeProm);
            Controls.Add(txtMatEt);
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
        private TextBox txtMatEt;
        private TextBox txtCodeProm;
        private TextBox txtDateInscr;
        private TextBox txtObserv;
        private Button btnAjouterInscription;
        private Button btnModifierInscription;
        private Button btnSupprimerInscription;
        private ComboBox cmbAnneeAcad;
    }
}