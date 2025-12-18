using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Book
    {
        public int Code { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime? AvailableOn { get; set; }

        public Book(int code, string title, string author, bool isAvailable, DateTime? availableOn = null)
        {
            Code = code;
            Title = title;
            Author = author;
            IsAvailable = isAvailable;
            AvailableOn = availableOn;
        }

        public void Borrow(int days)
        {
            IsAvailable = false;
            AvailableOn = DateTime.Today.AddDays(days);
        }

        public void Return()
        {
            IsAvailable = true;
            AvailableOn = null;
        }

        public override string ToString()
        {
            string status = IsAvailable ? "[Available]" : $"[Due: {AvailableOn:yyyy-MM-dd}]";
            return $"#{Code}\t| {Title.PadRight(20)} | {Author.PadRight(15)} | {status}";
        }
    }
}
