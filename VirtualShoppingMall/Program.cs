using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VirtualShoppingMall.Models;

namespace VirtualShoppingMall
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            PrototypeSession session = PrototypeSession.getInstance();
            session.loadTestData();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmHome());
        }
    }
}
