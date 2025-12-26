using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class RegularUser : User
    {
        public override void ShowMenu(Library library)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"=== USER DASHBOARD ({Username}) ===");
                Console.WriteLine("1. Browse Library");
                Console.WriteLine("2. Borrow Book");
                Console.WriteLine("3. Return Book");
                Console.WriteLine("0. Logout");
                Console.Write("Select: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        library.DisplayBooks();
                        Pause();
                        break;
                    case "2":
                        BorrowProcess(library);
                        Pause();
                        break;
                    case "3":
                        ReturnProcess(library);
                        Pause();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid selection.");
                        Pause();
                        break;
                }
            }
        }

        private void BorrowProcess(Library library)
        {
            library.DisplayBooks();
            checkcode:
            Console.Write("\nEnter book code to borrow: ");
            if (int.TryParse(Console.ReadLine(), out int code))
            {
                Book book = library.GetBookByCode(code);
                if (book != null && book.IsAvailable)
                {
                    Console.Write("Enter days : ");

                    if (int.TryParse(Console.ReadLine(), out int days) && days > 0 && days <= 14)
                    {
                        book.Borrow(days);
                        Console.Write($"Borrowed '{book.Title}' for {days} days.");
                        Console.WriteLine($"Cost :{days * 1} $");
                    }
                    else
                    {
                        Console.WriteLine("Pls enter range 1 to 14  days.");
                    }
                }
                else
                {
                    Console.WriteLine("Book not found or unavailable.");
                }
            }
            else 
            { 
                Console.WriteLine("Pls enter right code from list show up"); 
                goto checkcode;
            }
        }

        private void ReturnProcess(Library library)
        {
            Console.Write("\nEnter book code to return: ");
            if (int.TryParse(Console.ReadLine(), out int code))
            {
                Book book = library.GetBookByCode(code);
                if (book != null && !book.IsAvailable)
                {
                    book.Return();
                    Console.WriteLine($"Returned '{book.Title}'.");
                }
                else
                {
                    Console.WriteLine("Book invalid or already available.");
                }
            }
        }
    }
}
