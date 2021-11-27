using System;
namespace Open_Lab_10._02
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.RelaseDate = 2020;
            LOTR.Pages = 69;
            LOTR.Title = "Petrov Život";
            LOTR.Cathegory = "Funny";
            LOTR.Author = "Ján Kábel";
            LOTR.Write();
        }
        public class Book
        {
            public string Title { get; set; }
            private int pages;
            public int Pages
            {
                get { return pages; }
                set
                {
                    if (value < 0)
                    {
                        pages = 1;
                    }
                    else
                    {
                        pages = value;
                    }
                }
            }
            public string Cathegory { get; set; }
            public string Author { get; set; }
            private int relaseDate;
            public int RelaseDate
            {
                get { return relaseDate;}
                set 
                {
                    if (value < 1450 || value > 2021)
                    {
                        relaseDate = -1;
                    }
                    else
                    {
                        relaseDate = value;
                    }
                }
            }


            public void Write()
            {
                Console.WriteLine("Názov: " + Title);
                Console.WriteLine("Počet strán: " + Pages);
                Console.WriteLine("Žáner: " + Cathegory);
                Console.WriteLine("Autor: " + Author);
                Console.WriteLine("Dátum vydania: " + RelaseDate);

            }
        }
    }
}