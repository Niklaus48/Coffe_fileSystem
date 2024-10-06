using Coffe.Core.Storage;
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
            //define dataBase instance at entry point 
            DataBase.SetupDataBaseAsSingletone("D:\\Coffe");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPage());

        }
    }
}
