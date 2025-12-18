using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class User
    {
        public string Username { get; set; } = string.Empty;

        public virtual void ShowMenu(Library library)
        {
            Console.WriteLine("Base user menu");
        }

        protected void Pause()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
