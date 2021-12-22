using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace openlab_10._05
{
    class Program
    {
        static void Main(string[] args)
        {

            Book LOTR = new Book();


            LOTR.Title = "LOTR";
            LOTR.Author = "J. R. R. Tolkien";
            LOTR.Category = "Fantasy";
            LOTR.Pages = 9250;
            LOTR.ReleaseDate = 1954;

            Book LOTR2 = new Book();
            Book LOTR3 = new Book("LOTR3", 156);
            Book HOBIT = new Book("HOBIT", "J. R. R. Tolkien", "Fantasy", 6544, 5);
            HOBIT.Category = Book.categoryList[4];
            LOTR.writeall();
            LOTR2.writeall();
            LOTR3.writeall();
            HOBIT.writeall();
            Console.WriteLine(HOBIT.Category);
            
            
        }
    }

}
