using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class Admin:User
    {
        public override void ShowMenu(Library library)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"=== ADMIN PANEL ({Username}) ===");
                Console.WriteLine("1. View Books");
                Console.WriteLine("2. Add Book");
                Console.WriteLine("3. Remove Book");
                Console.WriteLine("4. Update Book");
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
                        library.AddBook();
                        Pause();
                        break;
                    case "3":
                        library.RemoveBook();
                        Pause();
                        break;
                    case "4":
                        library.UpdateBook();
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
    }
}
