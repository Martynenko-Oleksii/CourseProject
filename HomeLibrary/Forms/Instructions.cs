using System;
using System.Windows.Forms;

namespace HomeLibrary
{
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
        }

        private void Accept(object sender, EventArgs e)
        {
            Close();
        }
    }
}
