namespace Inscriptiondb
{
    partial class FrmPrincipalDB
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
            menuStrip1 = new MenuStrip();
            fenetresToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            inscriptionToolStripMenuItem = new ToolStripMenuItem();
            promotionToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fenetresToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1083, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fenetresToolStripMenuItem
            // 
            fenetresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, inscriptionToolStripMenuItem, promotionToolStripMenuItem });
            fenetresToolStripMenuItem.Name = "fenetresToolStripMenuItem";
            fenetresToolStripMenuItem.Size = new Size(78, 24);
            fenetresToolStripMenuItem.Text = "Fenetres";
            fenetresToolStripMenuItem.Click += fenetresToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(162, 26);
            toolStripMenuItem1.Text = "Etudiant";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // inscriptionToolStripMenuItem
            // 
            inscriptionToolStripMenuItem.Name = "inscriptionToolStripMenuItem";
            inscriptionToolStripMenuItem.Size = new Size(162, 26);
            inscriptionToolStripMenuItem.Text = "Inscription";
            inscriptionToolStripMenuItem.Click += inscriptionToolStripMenuItem_Click;
            // 
            // promotionToolStripMenuItem
            // 
            promotionToolStripMenuItem.Name = "promotionToolStripMenuItem";
            promotionToolStripMenuItem.Size = new Size(162, 26);
            promotionToolStripMenuItem.Text = "Promotion";
            promotionToolStripMenuItem.Click += promotionToolStripMenuItem_Click;
            // 
            // FrmPrincipalDB
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 647);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipalDB";
            Text = "Gestion Inscription";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipalDB_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fenetresToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem inscriptionToolStripMenuItem;
        private ToolStripMenuItem promotionToolStripMenuItem;
    }
}