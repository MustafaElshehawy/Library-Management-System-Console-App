using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    
        public class Library
        {
            private List<Book> books = new List<Book>();
            private int nextCode = 1;

            public Library()
            {
                // Seed data
                books.Add(new Book(nextCode++, "Clean Code", "Robert C. Martin", true));
                books.Add(new Book(nextCode++, "The Pragmatic Programmer", "Andrew Hunt", true));
                books.Add(new Book(nextCode++, "Design Patterns", "GoF", false, DateTime.Today.AddDays(5)));
            }

            public void DisplayBooks()
            {
                Console.WriteLine("\n================= LIBRARY BOOKS ==================");
                Console.WriteLine("Code\t| Title                | Author          | Status");
                Console.WriteLine("--------------------------------------------------");
                foreach (var book in books)
                {
                    Console.WriteLine(book);
                }
                Console.WriteLine("--------------------------------------------------");
            }

            public Book GetBookByCode(int code)
            {
                return books.FirstOrDefault(b => b.Code == code);
            }

            public void AddBook()
            {
                Console.WriteLine("\n--- Add New Book ---");
                Console.Write("Title: ");
                string title = Console.ReadLine();
                for (int i = 0; i < books.Count; i++) 
                {
                while (books[i].Title == title) 
                {
                    Console.WriteLine($"Pls enter title differnt this name:{title} areardy eixits");
                    Console.Write("Title: ");
                    title = Console.ReadLine();
                }
                }

                Console.Write("Author: ");
                string author = Console.ReadLine();

                bool isAvailable = false;
                while (true)
                {
                    Console.Write("Is available now? (Y/N): ");
                    string input = Console.ReadLine()?.Trim().ToUpper();
                    if (input == "Y"|| input =="YES") { isAvailable = true; break; }
                    if (input == "N") { isAvailable = false; break; }
                }

                DateTime? availableOn = null;
                if (!isAvailable)
                {
                    Console.Write("Available from date (yyyy-mm-dd): ");
                    if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
                    {
                        availableOn = date;
                    }
                }

                books.Add(new Book(nextCode++, title, author, isAvailable, availableOn));
                Console.WriteLine("Book added successfully!");
            }

            public void UpdateBook()
            {
            DisplayBooks();
            Console.Write("\nEnter book code to update: ");
            if (!int.TryParse(Console.ReadLine(), out int code))
            {
                Console.WriteLine("Pls enter valid code.");
                return;
            }

            Book book = GetBookByCode(code);
            if (book == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }

            Console.WriteLine("\nUpdate Old Book values ");
            Console.Write($"Title ({book.Title}): ");
           
            string titleInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(titleInput))
            {
                for (int i = 0; i < books.Count; i++)
                {
                    while (books[i].Title == titleInput)
                    {
                        Console.WriteLine($"Pls enter title differnt this name:{titleInput} areardy eixits");
                        Console.Write("Title: ");
                        titleInput = Console.ReadLine();
                    }
                    book.Title = titleInput;

                }
            }

            Console.Write($"Auther ({book.Author})");
            string authorInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(authorInput))
                book.Author = authorInput;

            Console.Write($"Is available now? (Y/N) [{(book.IsAvailable ? "Y" : "N")}]: ");
            string input = Console.ReadLine()?.Trim().ToUpper();

            if (input == "Y" || input == "YES" || input == "NO" || input == "N")
            {
                if (input == "Y" || input == "YES")
                {
                    book.IsAvailable = true;
                    book.AvailableOn = null;

                }

                if (input == "N" || input == "NO")
                {
                    book.IsAvailable = false;
                    Console.Write("Available from date (yyyy-mm-dd): ");
                    if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
                    {
                        book.AvailableOn = date;
                    }
                }
                Console.WriteLine("Book updated successfully!");


            }
            else
            {
                Console.WriteLine("Please enter Y or YES or N or NO.");

            }




        }


        public void RemoveBook()
            {
                DisplayBooks();
                Console.Write("Enter code to remove: ");
                if (int.TryParse(Console.ReadLine(), out int code))
                {
                    Book book = GetBookByCode(code);
                    if (book != null)
                    {
                        books.Remove(book);
                        Console.WriteLine("Book removed.");
                    }
                    else
                    {
                        Console.WriteLine("Book not found.");
                    }
                }
            }
        }
}
