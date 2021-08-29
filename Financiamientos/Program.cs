using Financiamientos.Forms;
using Financiamientos.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financiamientos
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home(new CUser("Marcos Kelvin","12345678901","MKelvin","1234","Administrador","U-001")));
        }
    }
}
