namespace Assignment02C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1

            string title = "clean code";
            string upperTitle = title.ToUpper();
            Console.WriteLine(title);
            Console.WriteLine(upperTitle);

            #endregion


            #region Question2
            /*
            string variable1 = "Clean Code";
                string variable2 = "Clean Code";
                Console.WriteLine(ReferenceEquals(variable1, variable2));
           */
            #endregion

            #region Question3 & 4
            /*
            StringBuilder sb = new StringBuilder();
                sb.Append("Book List");
                sb.Append(" - Updated");
                Console.WriteLine(sb);         

                sb.Replace("Book List", "Library");
                Console.WriteLine(sb);          
            */
            #endregion

            #region Question5
            /*
            string title = "Clean Code";
                int pages = 464;
                string sentence = "Book: " + title + ", Pages: " + pages;
                Console.WriteLine(sentence);
            */
            #endregion


            #region Question6
            /*
            string title = "Clean Code";
                int pages = 464;
                string sentence = $"Book: {title}, Pages: {pages}";
                Console.WriteLine(sentence);
           */
            #endregion

            #region Question7
            /*
            string title = "Clean Code";
                int pages = 464;
                string sentence = string.Format("Book: {0}, Pages: {1}", title, pages);
                Console.WriteLine(sentence);
            */
            #endregion

            #region Question8
            /*
            int pages = 464;
                if (pages > 300)
                {
                    Console.WriteLine("Long Book");
                }
                else
                {
                    Console.WriteLine("Short Book");
                }
            */
            #endregion


            #region Question9
            /*
            int pages = 464;
                bool isAvailable = true;
                if (pages > 300 && isAvailable)
                {
                    Console.WriteLine("You can borrow this book");
                }
            */
            #endregion


            #region Question10
            /*
            string title = "Refactoring";
                switch (title)
                {
                    case "Clean Code":
                        Console.WriteLine("Great choice!");
                        break;
                    case "Refactoring":
                        Console.WriteLine("Nice pick!");
                        break;
                    default:
                        Console.WriteLine("Never heard of it");
                        break;
                }
            */
            #endregion



            #region Question11
            /*
            int pages = 464;
                string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
                Console.WriteLine(sizeLabel);
            */
            #endregion

            #region Question12
            /*
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
                for (int i = 0; i < books.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {books[i]}");
                }
          */
            #endregion


            #region Question13
            /*
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
                int i = 0;
                while (i < books.Length)
                {
                    Console.WriteLine(books[i]);
                    i++;
                }
            */
            #endregion

            #region Question14
            /*
            int count = 0;
                do
                {
                    Console.WriteLine("Checking book...");
                    count++;
                } while (count < 3);
            */
            #endregion

            #region Question15
            /*
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
                foreach (string book in books)
                {
                    Console.WriteLine(book);
                }
            */
            #endregion

            #region Question16
            /*
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
                foreach (string book in books)
                {
                    if (book == "Refactoring")
                    {
                        break;
                    }
                    Console.WriteLine(book);
                }
            */
            #endregion

            #region Question17
            /*
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
                foreach (string book in books)
                {
                    if (book == "The Pragmatic Programmer")
                    {
                        continue;
                    }
                    Console.WriteLine(book);
                }
            */
            #endregion

            #region Question18
            /*
            static void PrintFirstBook(string[] books)
            {
                if (books.Length == 0)
                {
                    return;
                }
                Console.WriteLine(books[0]);
            }
                string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
                PrintFirstBook(books);                 
                PrintFirstBook(Array.Empty<string>()); 
            */
            #endregion
        }
    }
}
