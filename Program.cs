 using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormMain());



            string rootFolder = @"C:\Data\";
            string authorsFile = "0552.txt";

            try
            {
                // Check if file exists   
                if (File.Exists(Path.Combine(rootFolder, authorsFile)))
                {
                    Application.Run(new FormMain());
                }
                else
                {
                    Application.Run(new LoginForm());
                }
            }
            catch (IOException ioExp)
            {
                Console.WriteLine(ioExp.Message);
            }

        }
    }
}
