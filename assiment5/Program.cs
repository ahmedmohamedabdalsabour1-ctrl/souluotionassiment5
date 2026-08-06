using System;

namespace assiment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            //Console.WriteLine(book.password); // Erro
            // Console.WriteLine(book.copiesInStock);
            // book.Title = "Clean Code";
            // Console.WriteLine(book.Title);

           /* book.Genre = Genre.Science;

            Console.WriteLine(book.Genre);
            Console.WriteLine((int)Genre.Fiction);
            Console.WriteLine((int)Genre.NonFiction);
            Console.WriteLine((int)Genre.Science);
            Genre genre = Genre.Fiction;
            string genreName = genre.ToString();
            Console.WriteLine(genreName);*/
            string genreText = "Mystery";

            if (Enum.TryParse(genreText, out Genre genre))
            {
                Console.WriteLine(genre);
            }
            else
            {
                Console.WriteLine("Unknown genre");
            }

        }
    }
}
