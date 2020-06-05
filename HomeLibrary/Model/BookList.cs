using System.Collections.Generic;
using System.Linq;

namespace HomeLibrary
{
    // Клас-обгортка для зберігання та взаємодії зі списком книг.
    static class BookList
    {
        private static List<string> departList;
        private static List<Book> bookList;

        // Метод додавання нової книги.
        public static void AddBook(Book book)
        {
            bookList.Add(book);
            AddDepart(book);
        }

        // Метод видалення книги.
        public static void RemoveBook(Book book)
        {
            bookList.Remove(book);
        }

        // Додавання нового розділу бібліотеки до списку
        public static void AddDepart(Book book)
        {
            if (departList.IndexOf(book.Department) == -1)
            {
                departList.Add(book.Department);
            }
        }

        // Видалення розділу бібліотеки, якщо видалено останню книгу з ним.
        public static void DelDepart(string department)
        {
            List<Book> temp = bookList.Where(book => book.Department == department).ToList();
            if (temp.Count == 0)
            {
                BookList.departList.Remove(department);
            }
        }

        // Метод отримання списку  з книгами.
        public static List<Book> GetList()
        {
            return bookList;
        }

        // Метод отримання списку наявних книг.
        public static List<Book> GetAvailBooks()
        {
            return bookList.Where(book => book.Avail == true).ToList();
        }

        // Метод отримання списку розділів бібліотеки.
        public static List<string> GetDeparts()
        {
            return departList;
        }

        // Загальний метод сортування.
        public static void SortByParam(char param, bool upSort)
        {
            if (upSort)
            {
                bookList = SortUp(param).ToList();
            }
            else
            {
                bookList = SortDown(param).ToList();
            }
        }

        // Метод вибірки елементів зі списку книг.
        public static List<Book> FilterByParams(string departParam,
                                                bool availParam,
                                                bool isAll)
        {
            List<Book> filteredList = bookList;
            if (departParam.Length != 0)
                filteredList = filteredList.Where(book => book.Department == departParam).ToList();
            if (isAll != true)
                filteredList = filteredList.Where(book => book.Avail == availParam).ToList();

            return filteredList;
        }

        // Метод запису даних у файл.
        public static void WriteTo(string path)
        {
            SystemFile.Write(path, bookList);
        }

        // Метод отримання даних з файлу.
        public static void ReadFrom(string path)
        {
            if (SystemFile.Read(path) != null)
            {
                bookList = SortByTitle((List<Book>)SystemFile.Read(path)).ToList();
                departList = new List<string>();

                foreach (Book book in bookList)
                {
                    AddDepart(book);
                }
            }
            else
            {
                bookList = new List<Book>();
                departList = new List<string>();
            }
        }

        private static IOrderedEnumerable<Book> SortByTitle(List<Book> books)
        {
            return books.OrderBy(book => book.Title);
        }

        private static IOrderedEnumerable<Book> SortUp(char param)
        {
            switch (param)
            {
                case 'a':
                    return bookList.OrderBy(book => book.Author);
                case 'p':
                    return bookList.OrderBy(book => book.Publisher);
                case 'y':
                    return bookList.OrderBy(book => book.YearOfPublishing);
                case 's':
                    return bookList.OrderBy(book => book.Size);
                default:
                    return SortByTitle(bookList);
            }
        }

        private static IOrderedEnumerable<Book> SortDown(char param)
        {
            switch (param)
            {
                case 'a':
                    return bookList.OrderByDescending(book => book.Author);
                case 'p':
                    return bookList.OrderByDescending(book => book.Publisher);
                case 'y':
                    return bookList.OrderByDescending(book => book.YearOfPublishing);
                case 's':
                    return bookList.OrderByDescending(book => book.Size);
                default:
                    return bookList.OrderByDescending(book => book.Title);
            }
        }
    }
}
