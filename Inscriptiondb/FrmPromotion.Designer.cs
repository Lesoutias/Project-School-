namespace Inscriptiondb
{
    partial class FrmPromotion
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
            txtCode = new TextBox();
            txtOption = new TextBox();
            txtDesignation = new TextBox();
            btnAjouterPromotion = new Button();
            btnModifierPromotion = new Button();
            btnSupprimerPromotion = new Button();
            dgPromotion = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgPromotion).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(170, 27);
            label1.Name = "label1";
            label1.Size = new Size(437, 47);
            label1.TabIndex = 0;
            label1.Text = "Fiche pour la promotion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(60, 128);
            label2.Name = "label2";
            label2.Size = new Size(76, 28);
            label2.TabIndex = 1;
            label2.Text = "Code  :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(60, 197);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 2;
            label3.Text = "Option  :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(60, 274);
            label4.Name = "label4";
            label4.Size = new Size(137, 28);
            label4.TabIndex = 3;
            label4.Text = "Designation :";
            // 
            // txtCode
            // 
            txtCode.Enabled = false;
            txtCode.Location = new Point(220, 128);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(425, 27);
            txtCode.TabIndex = 4;
            // 
            // txtOption
            // 
            txtOption.Location = new Point(220, 197);
            txtOption.Name = "txtOption";
            txtOption.Size = new Size(425, 27);
            txtOption.TabIndex = 5;
            // 
            // txtDesignation
            // 
            txtDesignation.Location = new Point(220, 275);
            txtDesignation.Name = "txtDesignation";
            txtDesignation.Size = new Size(425, 27);
            txtDesignation.TabIndex = 6;
            // 
            // btnAjouterPromotion
            // 
            btnAjouterPromotion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjouterPromotion.Location = new Point(220, 353);
            btnAjouterPromotion.Name = "btnAjouterPromotion";
            btnAjouterPromotion.Size = new Size(104, 37);
            btnAjouterPromotion.TabIndex = 7;
            btnAjouterPromotion.Text = "Ajouter";
            btnAjouterPromotion.UseVisualStyleBackColor = true;
            // 
            // btnModifierPromotion
            // 
            btnModifierPromotion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModifierPromotion.Location = new Point(375, 353);
            btnModifierPromotion.Name = "btnModifierPromotion";
            btnModifierPromotion.Size = new Size(104, 37);
            btnModifierPromotion.TabIndex = 8;
            btnModifierPromotion.Text = "Modifier";
            btnModifierPromotion.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerPromotion
            // 
            btnSupprimerPromotion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupprimerPromotion.Location = new Point(523, 353);
            btnSupprimerPromotion.Name = "btnSupprimerPromotion";
            btnSupprimerPromotion.Size = new Size(122, 37);
            btnSupprimerPromotion.TabIndex = 9;
            btnSupprimerPromotion.Text = "Supprimer";
            btnSupprimerPromotion.UseVisualStyleBackColor = true;
            // 
            // dgPromotion
            // 
            dgPromotion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPromotion.Location = new Point(60, 453);
            dgPromotion.Name = "dgPromotion";
            dgPromotion.RowHeadersWidth = 51;
            dgPromotion.Size = new Size(585, 264);
            dgPromotion.TabIndex = 10;
            // 
            // FrmPromotion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 729);
            Controls.Add(dgPromotion);
            Controls.Add(btnSupprimerPromotion);
            Controls.Add(btnModifierPromotion);
            Controls.Add(btnAjouterPromotion);
            Controls.Add(txtDesignation);
            Controls.Add(txtOption);
            Controls.Add(txtCode);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmPromotion";
            Text = "FrmPromotion";
            ((System.ComponentModel.ISupportInitialize)dgPromotion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCode;
        private TextBox txtOption;
        private TextBox txtDesignation;
        private Button btnAjouterPromotion;
        private Button btnModifierPromotion;
        private Button btnSupprimerPromotion;
        private DataGridView dgPromotion;
    }
}