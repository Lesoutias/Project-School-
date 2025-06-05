namespace Gestion_Inscription
{
    partial class FrmCheckbox
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
            chkMoustiquaire = new CheckBox();
            rbFeminin = new RadioButton();
            rbMaculin = new RadioButton();
            btnValider = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // chkMoustiquaire
            // 
            chkMoustiquaire.AutoSize = true;
            chkMoustiquaire.Location = new Point(24, 195);
            chkMoustiquaire.Name = "chkMoustiquaire";
            chkMoustiquaire.Size = new Size(186, 24);
            chkMoustiquaire.TabIndex = 1;
            chkMoustiquaire.Text = "Dors sous moustiquaire";
            chkMoustiquaire.UseVisualStyleBackColor = true;
            // 
            // rbFeminin
            // 
            rbFeminin.AutoSize = true;
            rbFeminin.Location = new Point(224, 35);
            rbFeminin.Name = "rbFeminin";
            rbFeminin.Size = new Size(82, 24);
            rbFeminin.TabIndex = 2;
            rbFeminin.TabStop = true;
            rbFeminin.Text = "Feminin";
            rbFeminin.UseVisualStyleBackColor = true;
            rbFeminin.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbMaculin
            // 
            rbMaculin.AutoSize = true;
            rbMaculin.Location = new Point(36, 35);
            rbMaculin.Name = "rbMaculin";
            rbMaculin.Size = new Size(88, 24);
            rbMaculin.TabIndex = 3;
            rbMaculin.TabStop = true;
            rbMaculin.Text = "Masculin";
            rbMaculin.UseVisualStyleBackColor = true;
            rbMaculin.CheckedChanged += rbMaculin_CheckedChanged;
            // 
            // btnValider
            // 
            btnValider.Location = new Point(292, 190);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(94, 29);
            btnValider.TabIndex = 4;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbMaculin);
            groupBox1.Controls.Add(rbFeminin);
            groupBox1.Location = new Point(24, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(362, 94);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Genre";
            // 
            // FrmCheckbox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 276);
            Controls.Add(groupBox1);
            Controls.Add(btnValider);
            Controls.Add(chkMoustiquaire);
            Name = "FrmCheckbox";
            Text = "FrmCheckbox";
            Load += FrmCheckbox_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox chkMoustiquaire;
        private RadioButton rbFeminin;
        private RadioButton rbMaculin;
        private Button btnValider;
        private GroupBox groupBox1;
    }
}