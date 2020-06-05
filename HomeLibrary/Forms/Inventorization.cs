using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HomeLibrary
{
    public partial class Inventorization : Form
    {
        public Inventorization()
        {
            InitializeComponent();
            availBooks.DataSource = BookList.GetAvailBooks();
        }

        private void Back(object sender, EventArgs e)
        {
            Close();
        }
    }
}
