namespace Library_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Welcome To Library Management System");
            Console.WriteLine("====================================");
            Library library = new Library();

            while (true)
            {
                
                Console.WriteLine("\n=== LOGIN (Press Enter on Username to Exit) ===");
                Console.Write("Username: ");
                string username = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(username)) break;

                Console.Write("Password: ");
                string password = Console.ReadLine();

                User currentUser;

                if (username == "admin" && password == "123456")
                    currentUser = new Admin { Username = "Administrator" };
                else
                    currentUser = new RegularUser { Username = username };

                currentUser.ShowMenu(library);
            }


        }
    }
}
