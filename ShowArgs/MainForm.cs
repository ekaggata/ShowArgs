using System;
using System.Linq;
using System.Windows.Forms;

namespace ShowArgs
{
    public partial class MainForm : Form
    {
        public MainForm(string[] args)
        {
            if (args == null || args.Length < 1 || args.All(string.IsNullOrWhiteSpace))
            {
                throw new ArgumentNullException(nameof(args));
            }

            InitializeComponent();

            foreach(var arg in args)
            {
                argsTextBox.AppendText(arg);

                argsTextBox.AppendText(Environment.NewLine);
            }
        }
    }
}
