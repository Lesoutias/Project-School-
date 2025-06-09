namespace Gestion_Inscription
{
    partial class FrmSaisieControle
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
            lblControle = new Label();
            txtSaisie = new TextBox();
            btnEffacer = new Button();
            btnquitter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 75);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 0;
            label1.Text = "Saisie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(89, 151);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 1;
            label2.Text = "Controle";
            // 
            // lblControle
            // 
            lblControle.AutoSize = true;
            lblControle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblControle.ForeColor = SystemColors.Highlight;
            lblControle.Location = new Point(219, 151);
            lblControle.Name = "lblControle";
            lblControle.Size = new Size(0, 28);
            lblControle.TabIndex = 2;
            // 
            // txtSaisie
            // 
            txtSaisie.Location = new Point(219, 76);
            txtSaisie.Name = "txtSaisie";
            txtSaisie.Size = new Size(252, 27);
            txtSaisie.TabIndex = 3;
            txtSaisie.TextChanged += txtSaisie_TextChanged;
            // 
            // btnEffacer
            // 
            btnEffacer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEffacer.Location = new Point(219, 242);
            btnEffacer.Name = "btnEffacer";
            btnEffacer.Size = new Size(123, 39);
            btnEffacer.TabIndex = 4;
            btnEffacer.Text = "Effacer";
            btnEffacer.UseVisualStyleBackColor = true;
            btnEffacer.Click += btnEffacer_Click;
            // 
            // btnquitter
            // 
            btnquitter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnquitter.Location = new Point(377, 242);
            btnquitter.Name = "btnquitter";
            btnquitter.Size = new Size(116, 39);
            btnquitter.TabIndex = 5;
            btnquitter.Text = "Quitter";
            btnquitter.UseVisualStyleBackColor = true;
            btnquitter.Click += btnquitter_Click;
            // 
            // FrmSaisieControle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnquitter);
            Controls.Add(btnEffacer);
            Controls.Add(txtSaisie);
            Controls.Add(lblControle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmSaisieControle";
            Text = "FrmSaisieControle";
            Load += FrmSaisieControle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblControle;
        private TextBox txtSaisie;
        private Button btnEffacer;
        private Button btnquitter;
    }
}