using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;

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
            Genres.Add(new Genre(){Id = 1, Name = "Fantasy"});
            Genres.Add(new Genre() { Id = 2, Name = "Science fiction"});
            Genres.Add(new Genre() { Id = 3, Name = "Textbook"});

            Books.Add(new Book(){Id = 1, Title = "Hobbit", AuthorId = 1,PublishingDate = new DateTime(1937, 9, 21), GenreId = 1, Pages = 320});
            Books.Add(new Book() { Id = 2, Title = "The Fellowship of the Ring", AuthorId = 1, PublishingDate = new DateTime(1954, 7, 29), GenreId = 1, Pages = 398});
            Books.Add(new Book(){Id = 3, Title = "The Two Towers", AuthorId = 1, PublishingDate = new DateTime(1954, 11, 11), GenreId = 1, Pages = 327});
            Books.Add(new Book(){Id = 4, Title = "Thw Return of the King", AuthorId = 1, PublishingDate = new DateTime(1955, 10, 20), GenreId = 1, Pages = 412});

            Books.Add(new Book() { Id = 5, Title = "Pro C# 2010 and the .NET 4 Platform", AuthorId = 3, PublishingDate = new DateTime(2010, 5, 12), GenreId = 3, Pages = 1752});
            Books.Add(new Book() { Id = 6, Title = "Pro VB 2010 and the .NET 4.0 Platform", AuthorId = 3, PublishingDate = new DateTime(2010, 10, 18), GenreId = 3, Pages = 1800});
            Books.Add(new Book() { Id = 7, Title = "COM and .NET Interoperability", AuthorId = 3, PublishingDate = new DateTime(2002, 4, 24), GenreId = 3, Pages = 816});

            Books.Add(new Book() { Id = 8, Title = "Remade", AuthorId = 2, PublishingDate = new DateTime(2011, 9, 20), GenreId = 2, Pages = 1056});
            Books.Add(new Book() { Id = 9, Title = "Zodiac", AuthorId = 2, PublishingDate = new DateTime(1988, 7, 10), GenreId = 2, Pages = 283});
            Books.Add(new Book() { Id = 10, Title = "Anathem", AuthorId = 2, PublishingDate = new DateTime(2008, 9, 9), GenreId = 2, Pages = 928});

            Authors.Add(new Author(){Country = "England", Id = 1, FirstName = "John Ronald Reuel", LastName = "Tolkien"});
            Authors.Add(new Author(){Country = "USA", Id = 2, FirstName = "Neal", LastName = "Stephenson"});
            Authors.Add(new Author(){Country = "USA", Id = 3, FirstName = "Andrew", LastName = "Troelsen"});
        }

        internal IEnumerable GetBookNamesAndPublishingYear()
        {
            //Metoda zwraca wszystkie tytuły książek z biblioteki wraz z rokiem publikacji
            var seq = from book in Books
                      select new { book.Title, book.PublishingDate.Year };

            return seq;
        }

        public IEnumerable<Book> GetBooksForAuthor(string firstName, string lastName)
        {
            //Metoda zwraca wszystkie książki autora podanego z imienia i nazwiska

            var seq = from author in Authors
                      where author.FirstName == firstName && author.LastName == lastName
                      join book in Books on author.Id equals book.AuthorId
                      select book;

            return seq;
        }

        public IEnumerable GetGenresWithPagesSums()
        {
            //Metoda zwraca nazwy gatunków i sumy stron książek należących do danego gatunku
            var seq = from genre in Genres
                      join book in Books on genre.Id equals book.GenreId into genreBooks
                      select new { Id = genre.Id, Name = genre.Name, Sum = genreBooks.Sum(book => book.Pages) };
            
            return seq;
        }

        public IEnumerable GetAuthorsSortedByOldestBook()
        {
            //Metoda zwraca imiona i nazwiska autorów posortowane wg. roku wydania najstarszej książki jaką napisali

            return new List<object>();
        }
    }
}
