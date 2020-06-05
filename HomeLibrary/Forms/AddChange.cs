using System;
using System.Windows.Forms;

namespace HomeLibrary
{
    // Форма вікна додавання/редагування книг.
    public partial class AddChange : Form
    {
        static private bool isChange;
        private Book book;
        private readonly DataGridView bookListGrid;
        private readonly ComboBox departParam;

        public AddChange(DataGridView bookListGrid, ComboBox departParam)
        {
            InitializeComponent();
            this.bookListGrid = bookListGrid;
            this.departParam = departParam;
        }

        // Встановлення мітки додавання книги
        public void AddForm()
        {
            isChange = false;
        }

        // Заповнненя усіх полів обраної книги.
        public void ChangeForm(Book book)
        {
            // Встановлення мітки редагування книги.
            isChange = true;

            this.book = book;
            titleText.Text = book.Title;
            authorText.Text = book.Author;
            publisherText.Text = book.Publisher;
            yearText.Text = book.YearOfPublishing.ToString();
            bookSizeText.Text = book.Size.ToString();
            departmentText.Text = book.Department;
            fromWhereText.Text = book.FromWhere;
            rateText.Text = book.Rate;

            if (book.Avail)
                available.Checked = true;
            else
                nonAvailable.Checked = true;
        }

        private void SaveBook(object sender, EventArgs e)
        {
            Save();
        }

        private void BackToMain(object sender, EventArgs e)
        {
            Close();
        }

        // Метод для перевірки правильності введенних даних.
        private int Validation()
        {
            if (titleText.Text.Length != 0 && authorText.Text.Length != 0 
                && departmentText.Text.Length != 0 
                && (available.Checked != true && nonAvailable.Checked == true 
                || available.Checked == true && nonAvailable.Checked != true))
            {
                try
                {
                    if (bookSizeText.Text.Length != 0)
                        Convert.ToInt32(bookSizeText.Text);

                    if (yearText.Text.Length != 0)
                        Convert.ToInt32(yearText.Text);
                }
                catch (Exception)
                {
                    return 0;
                }
            }
            else
            {
                return -1;
            }

            return 1;
        }

        // Метод зберігання зміненої/доданої інформації.
        private void Save()
        {
            int res = Validation();
            if (res == 1)
            {
                bookListGrid.DataSource = null;
                departParam.DataSource = null;

                if (isChange)
                {
                    string oldDepart = book.Department;
                    book.ChangeInfo(titleText.Text, authorText.Text,
                                    departmentText.Text, available.Checked,
                                    publisherText.Text, Convert.ToInt32(yearText.Text),
                                    Convert.ToInt32(bookSizeText.Text),
                                    fromWhereText.Text, rateText.Text);

                    if (book.Department != oldDepart)
                    {
                        BookList.DelDepart(oldDepart);
                        BookList.AddDepart(book);
                    }
                }
                else
                {
                    Book newBook = new Book(titleText.Text, authorText.Text, departmentText.Text, available.Checked);
                    newBook.AddInfo(publisherText.Text, Convert.ToInt32(yearText.Text),
                                    Convert.ToInt32(bookSizeText.Text),
                                    fromWhereText.Text, rateText.Text);
                }

                bookListGrid.DataSource = BookList.GetList().GetRange(0, BookList.GetList().Count);
                SystemFile.Write("book_list.txt", BookList.GetList());

                departParam.DataSource = BookList.GetDeparts();
                departParam.SelectedIndex = -1;

                Close();
            }
            else if (res == 0)
            {
                MessageBox.Show("Введено некоректні значення року видання або кількості сторінок!",
                                                        "Попередження", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Заповність усі необхідні поля згідно з інструкцією: \n" +
                                                        "НАЗВА\nАВТОР\nРОЗДІЛ БІБЛІОТЕКИ\nНАЯВНІСТЬ",
                                                        "Попередження", MessageBoxButtons.OK);
            }
        }
    }
}
