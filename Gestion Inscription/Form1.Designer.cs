namespace Gestion_Inscription
{
    partial class Form1
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
            txt_Message = new TextBox();
            btn_Afficher = new Button();
            SuspendLayout();
            // 
            // lbl_message
            // 
            lbl_message.AutoSize = true;
            lbl_message.Location = new Point(83, 96);
            lbl_message.Name = "lbl_message";
            lbl_message.Size = new Size(67, 20);
            lbl_message.TabIndex = 0;
            lbl_message.Text = "Message";
            // 
            // txt_Message
            // 
            txt_Message.Location = new Point(229, 89);
            txt_Message.Name = "txt_Message";
            txt_Message.Size = new Size(125, 27);
            txt_Message.TabIndex = 1;
            // 
            // btn_Afficher
            // 
            btn_Afficher.Location = new Point(246, 165);
            btn_Afficher.Name = "btn_Afficher";
            btn_Afficher.Size = new Size(94, 29);
            btn_Afficher.TabIndex = 2;
            btn_Afficher.Text = "Afficher";
            btn_Afficher.UseVisualStyleBackColor = true;
            btn_Afficher.Click += btn_Afficher_Click;
            btn_Afficher.MouseClick += btn_Afficher_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 340);
            Controls.Add(btn_Afficher);
            Controls.Add(txt_Message);
            Controls.Add(lbl_message);
            Name = "Form1";
            Text = "Message";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_message;
        private TextBox txt_Message;
        private Button btn_Afficher;
    }
}
