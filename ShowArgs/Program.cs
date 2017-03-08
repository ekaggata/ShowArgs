using System;
using System.Linq;
using System.Windows.Forms;

namespace ShowArgs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            if (args == null || args.Length < 1 || args.All(string.IsNullOrWhiteSpace))
            {
                MessageBox.Show("No argumets detected", "ShowArgs", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
                
            Application.Run(new MainForm(args));
        }
    }
}
