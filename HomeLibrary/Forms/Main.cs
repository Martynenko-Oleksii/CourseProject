using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HomeLibrary
{
    // Форма головного вікна програми.
    public partial class Main : Form
    {
        private List<Book> filteredList;
        private bool isFiltered;

        public Main()
        {
            InitializeComponent();

            BookList.ReadFrom("book_list.txt");

            var res = SystemFile.Read("settings.txt");
            if (res == null)
            {
                GetInstructionsForm();
                SystemFile.Write("settings.txt", "First entry checked!");
            }

            bookListGrid.DataSource = BookList.GetList();

            departParamText.DataSource = BookList.GetDeparts();
            departParamText.SelectedIndex = -1;

            bookListGrid.KeyUp += KeyUpEvent;
        }

        private void AddBook(object sender, EventArgs e)
        {
            AddChange form = new AddChange(bookListGrid, departParamText);
            form.AddForm();
            form.ShowDialog();
        }

        private void EditBook(object sender, EventArgs e)
        {
            Book book = GetSelectedBook();
            if (book != null)
            {
                AddChange form = new AddChange(bookListGrid, departParamText);
                form.ChangeForm(book);
                form.ShowDialog();
            }
        }

        private void Inventorization(object sender, EventArgs e)
        {
            Inventorization form = new Inventorization();
            form.ShowDialog();
        }

        // Обробник подій натискання кнопок.
        private void KeyUpEvent(object sender, KeyEventArgs e)
        {
            Book book = GetSelectedBook();
            if  (book != null && e.KeyCode == Keys.Delete)
            {
                DialogResult result = MessageBox.Show("Видалити обрану книгу зі списку?", 
                                                    "Попередження", 
                                                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    BookList.RemoveBook(book);
                    bookListGrid.DataSource = null;
                    departParamText.DataSource = null;

                    if (isFiltered)
                    {
                        filteredList.Remove(book);
                        bookListGrid.DataSource = filteredList;
                    }
                    else
                    {
                        bookListGrid.DataSource = BookList.GetList();
                    }

                    BookList.DelDepart(book.Department);
                    departParamText.DataSource = BookList.GetDeparts();
                    departParamText.SelectedIndex = -1;

                    BookList.WriteTo("book_list.txt");
                }
            }

            if (e.KeyCode == Keys.F1)
            {
                GetInstructionsForm();
            }
        }

        private void GetBookInfo(object sender, EventArgs e)
        {
            Book book = GetSelectedBook();
            if (book != null)
            {
                BookInfo form = new BookInfo();
                form.AddInfo(book);
                form.ShowDialog();
            }
        }

        private void Sort(object sender, EventArgs e)
        {
            bookListGrid.DataSource = null;

            char param = SortParam();
            BookList.SortByParam(param, upSortParam.Checked);
            filteredList = BookList.FilterByParams(departParamText.Text, 
                                                   availParam.Checked, 
                                                   allParam.Checked);

            if (filteredList.Count != BookList.GetList().Count)
            {
                isFiltered = true;
                bookListGrid.DataSource = filteredList;
            }
            else
            {
                bookListGrid.DataSource = BookList.GetList();
            }
        }

        private void StandardState(object sender, EventArgs e)
        {
            isFiltered = false;

            bookListGrid.DataSource = null;
            bookListGrid.DataSource = BookList.GetList();
            departParamText.Text = null;
            departParamText.SelectedIndex = -1;
            titleParam.Checked = true;
            allParam.Checked = true;
            upSortParam.Checked = true;
        }

        private void InstructionToolClick(object sender, EventArgs e)
        {
            GetInstructionsForm();
        }

        // Метод отримання вибраної користувачем книги.
        private Book GetSelectedBook()
        {
            try
            {
                DataGridViewRow row = bookListGrid.SelectedRows[0];
                int idx = bookListGrid.Rows.IndexOf(row);
                if (isFiltered)
                    return filteredList[idx];
                else
                    return BookList.GetList()[idx];
            }
            catch (ArgumentOutOfRangeException)
            {
                return null;
            }
        }

        // Метод створення форми з інструкцією.
        private void GetInstructionsForm()
        {
            Instructions form = new Instructions();
            form.ShowDialog();
        }

        // Метод визначення параметру сортування.
        private char SortParam()
        {
            if (titleParam.Checked)
                return 't';
            else if (authorParam.Checked)
                return 'a';
            else if (publishParam.Checked)
                return 'p';
            else if (yearParam.Checked)
                return 'y';
            else
                return 's';
        }
    }
}
