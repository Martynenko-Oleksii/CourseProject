using System;

namespace HomeLibrary
{
    // Реалізація класу, призначеного для зберігання даних книг та взаємодії з ними.
    [Serializable]
    public class Book
    {
        private int yearOfPublish;
        private int size;


        public Book(string title, string author, string department, bool isInLibrary)
        {
            Title = title;
            Author = author;
            Department = department;
            Avail = isInLibrary;
            BookList.AddBook(this);
        }

        public int YearOfPublishing
        {
            // Встановлення додатнього значення року.
            private set
            {
                yearOfPublish = Math.Abs(value);
            }
            get 
            { 
                return yearOfPublish; 
            }
        }

        public int Size 
        { 
            // Встановлення додатнього значення кількості сторінок.
            private set
            {
                size = Math.Abs(value);
            }
            get 
            {
                return size;
            }
        }

        // Автоматичні властивості для полів класу.
        public string Title { private set; get; }
        public string Author { private set; get; }
        public string Department { private set; get; }
        public bool Avail { private set; get; }
        public string Publisher { private set; get; }
        public string FromWhere { private set; get; }
        public string Rate { private set; get; }

        // Метод встановлення значень додаткових даних при додаванні.
        public void AddInfo(string publisher, int year, int size,
                            string fromWhere, string rate)
        {
            SetAdditionalInfo(publisher, year, size, fromWhere, rate);
        }

        // Метод для зміни даних при редагуванні.
        public void ChangeInfo(string title, string author,
                               string depart, bool avail,
                               string publisher, int year, int size, 
                               string fromWhere, string rate)
        {
            SetMainInfo(title, author, depart, avail);
            SetAdditionalInfo(publisher, year, size, fromWhere, rate);
        }

        private void SetMainInfo(string title, string author, 
                                 string depart, bool avail)
        {
            Title = title;
            Author = author;
            Department = depart;
            Avail = avail;
        }

        private void SetAdditionalInfo(string publisher, int year, int size,
                                       string fromWhere, string rate)
        {
            Publisher = publisher;
            YearOfPublishing = year;
            Size = size;
            FromWhere = fromWhere;
            Rate = rate;
        }
    }
}
