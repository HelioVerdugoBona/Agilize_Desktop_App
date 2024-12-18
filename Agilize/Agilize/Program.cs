using System;
using System.IO;
using System.Windows.Forms;

namespace Agilize
{
    public static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //La primera vez que se ejecuta la aplicación, busca la ruta de Documents y crea una carpeta para la aplicación.
            //De base, si no se cambia nada la aplicación guardara toda la información ahí.
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string appFolder = Path.Combine(documentsPath, "Agilize");
            Directory.CreateDirectory(appFolder);  
            
            Application.Run(new Login(appFolder));
        }
    }
}
