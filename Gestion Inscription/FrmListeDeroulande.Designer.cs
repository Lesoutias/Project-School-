namespace Gestion_Inscription
{
    partial class FrmListeDeroulande
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
            lblList = new Label();
            cmbList = new ComboBox();
            SuspendLayout();
            // 
            // lblList
            // 
            lblList.AutoSize = true;
            lblList.Location = new Point(68, 140);
            lblList.Name = "lblList";
            lblList.Size = new Size(79, 20);
            lblList.TabIndex = 0;
            lblList.Text = "Promotion";
            // 
            // cmbList
            // 
            cmbList.FormattingEnabled = true;
            cmbList.Location = new Point(211, 142);
            cmbList.Name = "cmbList";
            cmbList.Size = new Size(151, 28);
            cmbList.TabIndex = 1;
            cmbList.SelectedIndexChanged += cmbList_SelectedIndexChanged;
            // 
            // FrmListeDeroulande
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbList);
            Controls.Add(lblList);
            Name = "FrmListeDeroulande";
            Text = "FrmListeDeroulande";
            Load += FrmListeDeroulande_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblList;
        private ComboBox cmbList;
    }
}