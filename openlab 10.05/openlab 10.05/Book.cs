using System;
using System.Collections.Generic;
using System.Text;

namespace openlab_10._05
{
    public class Book
    {
        /// <summary>
        /// static list with book categories
        /// </summary>
        public static string[] categoryList = new string[] { "detske", "romanticke", "naučne", "sci-fi", "dobrodružné" };
       

        
        public Book()
        {
            Title = "-1";
            ReleaseDate = -1;
            Author = "-1";
            Pages = -1;
            Category = "-1";
        }

        public Book(string titleofbook, int pagesofbook)
        {
            Title = titleofbook;
            ReleaseDate = -1;
            Author = "-1";
            Pages = pagesofbook;
            Category = "-1";
        }
        public Book(string titleofbook, string authorofbook, string categoryofbook, int pagesofbook, int releasedateofbook)
        {
            Title = titleofbook;
            ReleaseDate = releasedateofbook;
            Author = authorofbook;
            Pages = pagesofbook;
            
        }
        public string Title { set; get; }

        private string _category;  
        public string Category    
        {
            private get => _category;
            set => _category = value;
        }
        private int pages;
        public int Pages
        {

            get
            {
                return pages;
            }
            set
            {
                if (value < 0)
                {
                    value = 1;
                }
                pages = value;
            }

        }

        
        public string Author { set; get; }

        private int releaseDate;
        public int ReleaseDate
        {

            get
            {
                return releaseDate;
            }
            set
            {
                if (value < 1405)
                {
                    value = -1;
                }
                else
                {
                    if (value > 2021)
                    {
                        value = -1;
                    }
                }
                releaseDate = value;
            }

        }



        public void writeall()
        {

            Console.WriteLine(Title);
            Console.WriteLine(Pages);
           
            Console.WriteLine(Author);
            Console.WriteLine(ReleaseDate);
        }





    }
}
