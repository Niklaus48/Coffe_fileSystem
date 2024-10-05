using Coffe.Core.Storage;
using Coffe.Entities.Users;
using System;
using System.Windows.Forms;


namespace Coffe
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPage());

        }
    }
}
