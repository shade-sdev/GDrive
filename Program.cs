using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDrive
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
            try
            {
                if (misc.checkSettings() == true)
                {
                    Application.Run(new GoogleDrive());
                }
                else
                {
                    Application.Run(new Settings());
                }
            } catch
            {
                Application.Run(new Settings());
            }
           
            

            
           
            } 
            
        }
    }

