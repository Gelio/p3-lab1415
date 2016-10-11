using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lab14
{
    public class Library
    {
        public List<Book> Books { get; set; }

        public List<Author> Authors { get; set; }

        public List<Genre> Genres { get; set; } 

        public Library()
        {
            Books = new List<Book>();
            Authors = new List<Author>();
            Genres = new List<Genre>();

            FillLibrary();
        }

        private void FillLibrary()
        {
            Genres.Add(new Genre { Id = 1, Name = "Fantasy"});
            Genres.Add(new Genre { Id = 2, Name = "Science fiction"});
            Genres.Add(new Genre { Id = 3, Name = "Textbook"});

            Books.Add(new Book { Id = 1, Title = "Hobbit", AuthorId = 1,PublishingDate = new DateTime(1937, 9, 21), GenreId = 1, Pages = 320});
            Books.Add(new Book { Id = 2, Title = "The Fellowship of the Ring", AuthorId = 1, PublishingDate = new DateTime(1954, 7, 29), GenreId = 1, Pages = 398});
            Books.Add(new Book { Id = 3, Title = "The Two Towers", AuthorId = 1, PublishingDate = new DateTime(1954, 11, 11), GenreId = 1, Pages = 327});
            Books.Add(new Book { Id = 4, Title = "Thw Return of the King", AuthorId = 1, PublishingDate = new DateTime(1955, 10, 20), GenreId = 1, Pages = 412});

            Books.Add(new Book { Id = 5, Title = "Pro C# 2010 and the .NET 4 Platform", AuthorId = 3, PublishingDate = new DateTime(2010, 5, 12), GenreId = 3, Pages = 1752});
            Books.Add(new Book { Id = 6, Title = "Pro VB 2010 and the .NET 4.0 Platform", AuthorId = 3, PublishingDate = new DateTime(2010, 10, 18), GenreId = 3, Pages = 1800});
            Books.Add(new Book { Id = 7, Title = "COM and .NET Interoperability", AuthorId = 3, PublishingDate = new DateTime(2002, 4, 24), GenreId = 3, Pages = 816});

            Books.Add(new Book { Id = 8, Title = "Remade", AuthorId = 2, PublishingDate = new DateTime(2011, 9, 20), GenreId = 2, Pages = 1056});
            Books.Add(new Book { Id = 9, Title = "Zodiac", AuthorId = 2, PublishingDate = new DateTime(1988, 7, 10), GenreId = 2, Pages = 283});
            Books.Add(new Book { Id = 10, Title = "Anathem", AuthorId = 2, PublishingDate = new DateTime(2008, 9, 9), GenreId = 2, Pages = 928});

            Authors.Add(new Author { Country = "England", Id = 1, FirstName = "John Ronald Reuel", LastName = "Tolkien"});
            Authors.Add(new Author { Country = "USA", Id = 2, FirstName = "Neal", LastName = "Stephenson"});
            Authors.Add(new Author { Country = "USA", Id = 3, FirstName = "Andrew", LastName = "Troelsen"});
        }

        internal IEnumerable GetAuthorLastNameAndCountry()
        {
            //Metoda zwraca nazwiska autorów i ich kraje pochodzenia

            return new List<string>();
        }

        public IEnumerable<Book> GetBooksForGenre(string genreName)
        {
            //Metoda zwraca wszystkie książki gatunku o podanej nazwie

            return new List<Book>();
        }

        public IEnumerable GetAutorsWithPagesSums()
        {
            //Metoda zwraca imiona i nazwiska autorów razem z sumą stron napisanych przez nich książek

            return new List<object>();
        }

        public IEnumerable GetGenresSortedByNewestBook()
        {
            //Metoda zwraca nazwy gatunków posortowane wg. roku wydania najnowszej książki w danym gatunku

            return new List<object>();
        }
    }
}
