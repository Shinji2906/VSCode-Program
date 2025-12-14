using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLyCafe.GUI
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
            using (var form_login = new Login())
            {
                form_login.ShowDialog();
                if (form_login.DialogResult == DialogResult.OK)
                {
                    Application.Run(new Form1());
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
