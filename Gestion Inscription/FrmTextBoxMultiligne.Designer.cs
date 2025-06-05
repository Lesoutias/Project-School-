namespace Gestion_Inscription
{
    partial class FrmTextBoxMultiligne
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
            textBoxMultiline = new TextBox();
            btnAjouter = new Button();
            label1 = new Label();
            textSaisie = new TextBox();
            SuspendLayout();
            // 
            // textBoxMultiline
            // 
            textBoxMultiline.Enabled = false;
            textBoxMultiline.Location = new Point(21, 35);
            textBoxMultiline.Multiline = true;
            textBoxMultiline.Name = "textBoxMultiline";
            textBoxMultiline.Size = new Size(401, 236);
            textBoxMultiline.TabIndex = 0;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(328, 312);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(94, 29);
            btnAjouter.TabIndex = 1;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 321);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 2;
            label1.Text = "Tapez le texte en bas";
            // 
            // textSaisie
            // 
            textSaisie.Location = new Point(21, 386);
            textSaisie.Name = "textSaisie";
            textSaisie.Size = new Size(401, 27);
            textSaisie.TabIndex = 0;
            textSaisie.TextChanged += textSaisie_TextChanged;
            // 
            // FrmTextBoxMultiligne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 450);
            Controls.Add(textSaisie);
            Controls.Add(label1);
            Controls.Add(btnAjouter);
            Controls.Add(textBoxMultiline);
            Name = "FrmTextBoxMultiligne";
            Text = "FrmTextBoxMultiligne";
            Load += FrmTextBoxMultiligne_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMultiline;
        private Button btnAjouter;
        private Label label1;
        private TextBox textSaisie;
    }
}