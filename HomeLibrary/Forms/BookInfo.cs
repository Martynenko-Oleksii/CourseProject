using System.Windows.Forms;

namespace HomeLibrary
{
    // Форма з додатковою інформацією книги.
    public partial class BookInfo : Form
    {
        public BookInfo()
        {
            InitializeComponent();
        }

        // Заповненя додаткової інформації про книгу.
        public void AddInfo(Book book)
        {
            this.infoBookTitle.Text = $"\"{book.Title}\"";
            this.infoBookPublisher.Text = book.Publisher;
            this.infoBookYear.Text = book.YearOfPublishing.ToString();
            this.infoBookSize.Text = book.Size.ToString();
            this.infoBookFrom.Text = book.FromWhere;
            this.infoBookRate.Text = book.Rate;
        }
    }
}
