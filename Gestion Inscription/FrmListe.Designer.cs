namespace Gestion_Inscription
{
    partial class FrmListe
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
            txtSaisi = new TextBox();
            list1 = new ListBox();
            btnAjouter = new Button();
            btnAffectelist2 = new Button();
            btnAffecterlist1 = new Button();
            list2 = new ListBox();
            btnEffacerList1 = new Button();
            btnEffacerList2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 30);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Tapez le texte";
            // 
            // txtSaisi
            // 
            txtSaisi.Location = new Point(32, 71);
            txtSaisi.Name = "txtSaisi";
            txtSaisi.Size = new Size(274, 27);
            txtSaisi.TabIndex = 1;
            txtSaisi.TextChanged += txtSaisi_TextChanged;
            // 
            // list1
            // 
            list1.FormattingEnabled = true;
            list1.Location = new Point(32, 129);
            list1.Name = "list1";
            list1.Size = new Size(274, 204);
            list1.TabIndex = 2;
            list1.SelectedIndexChanged += list1_SelectedIndexChanged;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(359, 69);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(94, 29);
            btnAjouter.TabIndex = 3;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnAffectelist2
            // 
            btnAffectelist2.Location = new Point(380, 171);
            btnAffectelist2.Name = "btnAffectelist2";
            btnAffectelist2.Size = new Size(47, 29);
            btnAffectelist2.TabIndex = 4;
            btnAffectelist2.Text = "->";
            btnAffectelist2.UseVisualStyleBackColor = true;
            btnAffectelist2.Click += btnAffectelist2_Click;
            // 
            // btnAffecterlist1
            // 
            btnAffecterlist1.Location = new Point(380, 247);
            btnAffecterlist1.Name = "btnAffecterlist1";
            btnAffecterlist1.Size = new Size(47, 29);
            btnAffecterlist1.TabIndex = 5;
            btnAffecterlist1.Text = "<-";
            btnAffecterlist1.UseVisualStyleBackColor = true;
            btnAffecterlist1.Click += btnAffecterlist1_Click;
            // 
            // list2
            // 
            list2.FormattingEnabled = true;
            list2.Location = new Point(507, 129);
            list2.Name = "list2";
            list2.Size = new Size(257, 204);
            list2.TabIndex = 6;
            list2.SelectedIndexChanged += list2_SelectedIndexChanged;
            // 
            // btnEffacerList1
            // 
            btnEffacerList1.Location = new Point(74, 368);
            btnEffacerList1.Name = "btnEffacerList1";
            btnEffacerList1.Size = new Size(94, 29);
            btnEffacerList1.TabIndex = 7;
            btnEffacerList1.Text = "Effacer";
            btnEffacerList1.UseVisualStyleBackColor = true;
            btnEffacerList1.Click += btnEffacerList1_Click;
            // 
            // btnEffacerList2
            // 
            btnEffacerList2.Location = new Point(597, 368);
            btnEffacerList2.Name = "btnEffacerList2";
            btnEffacerList2.Size = new Size(94, 29);
            btnEffacerList2.TabIndex = 8;
            btnEffacerList2.Text = "Effacer";
            btnEffacerList2.UseVisualStyleBackColor = true;
            btnEffacerList2.Click += btnEffacerList2_Click;
            // 
            // FrmListe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEffacerList2);
            Controls.Add(btnEffacerList1);
            Controls.Add(list2);
            Controls.Add(btnAffecterlist1);
            Controls.Add(btnAffectelist2);
            Controls.Add(btnAjouter);
            Controls.Add(list1);
            Controls.Add(txtSaisi);
            Controls.Add(label1);
            Name = "FrmListe";
            Text = "FrmListe";
            Load += FrmListe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSaisi;
        private ListBox list1;
        private Button btnAjouter;
        private Button btnAffectelist2;
        private Button btnAffecterlist1;
        private ListBox list2;
        private Button btnEffacerList1;
        private Button btnEffacerList2;
    }
}