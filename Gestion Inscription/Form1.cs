namespace Gestion_Inscription
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Afficher_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Nous sommes en C#");
            if (txt_Message.Text != "")
            {
                MessageBox.Show(txt_Message.Text, "Afficher Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreur, pas de message", "Afficher Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Afficher_Click(object sender, EventArgs e)
        {

        }
    }
}
