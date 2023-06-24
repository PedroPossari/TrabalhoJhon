using TrabalhoLipa.Models;

namespace TrabalhoLipa
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
            CRUD.Init_BD();
            Application.Run(new FormLogin());
        }
        public static void Altura(KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != 8) 
                e.Handled = true;
        }
    }
}