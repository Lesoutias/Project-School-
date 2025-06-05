namespace Gestion_Inscription
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            //Application.Run(new FrmPrincipal());
            //Application.Run(new FrmSaisieControle());
            //Application.Run(new FrmTextBoxMultiligne());
            //Application.Run(new FrmListeDeroulande());
            //Application.Run(new FrmCheckbox());
            Application.Run(new FrmListe());

        }
    }
}