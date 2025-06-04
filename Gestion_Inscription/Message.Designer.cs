namespace Gestion_Inscription
{
    partial class Form_Message
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_message = new Label();
            txt = new TextBox();
            btn_Afficher = new Button();
            SuspendLayout();
            // 
            // lbl_message
            // 
            lbl_message.AutoSize = true;
            lbl_message.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lbl_message.Location = new Point(24, 94);
            lbl_message.Name = "lbl_message";
            lbl_message.Size = new Size(117, 35);
            lbl_message.TabIndex = 0;
            lbl_message.Text = "Message";
            // 
            // txt
            // 
            txt.Location = new Point(190, 78);
            txt.Multiline = true;
            txt.Name = "txt";
            txt.Size = new Size(239, 51);
            txt.TabIndex = 1;
            // 
            // btn_Afficher
            // 
            btn_Afficher.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn_Afficher.Location = new Point(244, 192);
            btn_Afficher.Name = "btn_Afficher";
            btn_Afficher.Size = new Size(146, 45);
            btn_Afficher.TabIndex = 2;
            btn_Afficher.Text = "Afficher";
            btn_Afficher.UseVisualStyleBackColor = true;
            btn_Afficher.Click += btn_Afficher_Click;
            // 
            // Form_Message
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 384);
            Controls.Add(btn_Afficher);
            Controls.Add(txt);
            Controls.Add(lbl_message);
            Name = "Form_Message";
            Text = "Message";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_message;
        private TextBox txt;
        private Button btn_Afficher;
    }
}
