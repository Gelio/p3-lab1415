using System;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();

            //UWAGA: w żadnym z etapów nie można używać pętli (for, while, foreach). 
            //Wszystkie zadania muszą być wykonane w technologii LINQ
            // Modyfikować można jedynie plik Library.cs, pozostałe pliki powinny pozostać niezmienione

            //Etap pierwszy - 0.5 punktu
            Console.WriteLine("==== Etap pierwszy ====");

            var authorsWithCountry = library.GetAuthorLastNameAndCountry();

            foreach (var author in authorsWithCountry)
                Console.WriteLine(author);

            Console.WriteLine();

            //Etap drugi - 1 punkt
            Console.WriteLine("==== Etap drugi ====");

            var booksForAuthor = library.GetBooksForGenre("Textbook");

            foreach (var book in booksForAuthor)
                Console.WriteLine(book.Title);

            Console.WriteLine();

            //Etap trzeci - 1.5 punktu
            Console.WriteLine("==== Etap trzeci ====");

            var autorsWithPagesSums = library.GetAutorsWithPagesSums();

            foreach (var autor in autorsWithPagesSums)
                Console.WriteLine(autor);

            Console.WriteLine();

            //Etap czwraty - 2 punkty
            Console.WriteLine("==== Etap czwarty ====");

            var genresByOldestBook = library.GetGenresSortedByNewestBook();

            foreach (var genre in genresByOldestBook)
                Console.WriteLine(genre);

            Console.WriteLine();
        }
    }
}
