using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class global
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public global(string title, string author, string genre)
        {
            Title = title;
            Author = author;
            Genre = genre;
        }
       
        //public static void Main(string[] args)
        //{
        //    Book[] books = new Book[3] { new Book("Дэн Браун", "Инферно" ),
        //                            new Book( "Джордж Браун", "Игра престолов" ),
        //                            new Book( "Айн Рэнд", "Атлант расправил плечи" ) };
       
        //}
    }
}
