using System;
using System.Windows.Forms;
using TAKAKO_ERP_3LAYER.View;

namespace TAKAKO_ERP_3LAYER
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
            Application.Run(new Form_Menu());
        }
    }
}
