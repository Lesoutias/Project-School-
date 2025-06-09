namespace Gestion_Inscription
{
    partial class FrmPrincipal
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
            saisieToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            checkBoxToolStripMenuItem = new ToolStripMenuItem();
            listeBoxToolStripMenuItem = new ToolStripMenuItem();
            comboBoxToolStripMenuItem = new ToolStripMenuItem();
            saisieControleToolStripMenuItem = new ToolStripMenuItem();
            textBoxMultiligneToolStripMenuItem = new ToolStripMenuItem();
            afficherToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { saisieToolStripMenuItem, afficherToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // saisieToolStripMenuItem
            // 
            saisieToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, checkBoxToolStripMenuItem, listeBoxToolStripMenuItem, comboBoxToolStripMenuItem, saisieControleToolStripMenuItem, textBoxMultiligneToolStripMenuItem, loginToolStripMenuItem });
            saisieToolStripMenuItem.Name = "saisieToolStripMenuItem";
            saisieToolStripMenuItem.Size = new Size(61, 24);
            saisieToolStripMenuItem.Text = "Saisie";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(224, 26);
            toolStripMenuItem1.Text = "Message";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // checkBoxToolStripMenuItem
            // 
            checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
            checkBoxToolStripMenuItem.Size = new Size(224, 26);
            checkBoxToolStripMenuItem.Text = "CheckBox";
            checkBoxToolStripMenuItem.Click += checkBoxToolStripMenuItem_Click;
            // 
            // listeBoxToolStripMenuItem
            // 
            listeBoxToolStripMenuItem.Name = "listeBoxToolStripMenuItem";
            listeBoxToolStripMenuItem.Size = new Size(224, 26);
            listeBoxToolStripMenuItem.Text = "ListeBox";
            listeBoxToolStripMenuItem.Click += listeBoxToolStripMenuItem_Click;
            // 
            // comboBoxToolStripMenuItem
            // 
            comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            comboBoxToolStripMenuItem.Size = new Size(224, 26);
            comboBoxToolStripMenuItem.Text = "ComboBox";
            comboBoxToolStripMenuItem.Click += comboBoxToolStripMenuItem_Click;
            // 
            // saisieControleToolStripMenuItem
            // 
            saisieControleToolStripMenuItem.Name = "saisieControleToolStripMenuItem";
            saisieControleToolStripMenuItem.Size = new Size(224, 26);
            saisieControleToolStripMenuItem.Text = "SaisieControle";
            saisieControleToolStripMenuItem.Click += saisieControleToolStripMenuItem_Click;
            // 
            // textBoxMultiligneToolStripMenuItem
            // 
            textBoxMultiligneToolStripMenuItem.Name = "textBoxMultiligneToolStripMenuItem";
            textBoxMultiligneToolStripMenuItem.Size = new Size(224, 26);
            textBoxMultiligneToolStripMenuItem.Text = "TextBoxMultiligne";
            textBoxMultiligneToolStripMenuItem.Click += textBoxMultiligneToolStripMenuItem_Click;
            // 
            // afficherToolStripMenuItem
            // 
            afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            afficherToolStripMenuItem.Size = new Size(75, 24);
            afficherToolStripMenuItem.Text = "Afficher";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(224, 26);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            WindowState = FormWindowState.Maximized;
            FormClosing += FrmPrincipal_FormClosing;
            Load += FrmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem saisieToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem checkBoxToolStripMenuItem;
        private ToolStripMenuItem listeBoxToolStripMenuItem;
        private ToolStripMenuItem comboBoxToolStripMenuItem;
        private ToolStripMenuItem afficherToolStripMenuItem;
        private ToolStripMenuItem saisieControleToolStripMenuItem;
        private ToolStripMenuItem textBoxMultiligneToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
    }
}