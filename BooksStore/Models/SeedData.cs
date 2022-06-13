using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.EntityFrameworkCore;

namespace BooksStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            BooksStoreDbContext context =
            app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService < BooksStoreDbContext > ();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Books.Any())
            {
                context.Books.AddRange(
               new Book
               {
                   Title = "To Kill a Mockingbird, by Harper Lee",
                   Description = "https://cdn.lifehack.org/wp-content/uploads/2015/03/50-anniversary-cover1.jpg",
                   Genre = "horrified",
                   Price = 20.000m
               },
                new Book
                {
                    Title = "1984, by George Orwell",
                    Description = "https://cdn.lifehack.org/wp-content/uploads/2015/03/1984.jpg",
                    Genre = "detective",
                    Price = 20.000m
                },
                new Book
                {
                    Title = "Harry Potter and the Philosopher’s Stone, by J.K. Rowling",
                    Description = "https://cdn.lifehack.org/wp-content/uploads/2015/03/harry_potter_and_the_Sorcerers_stone_adult_usa.jpg",
                    Genre = "humor",
                    Price = 2m
                },
                new Book
                {
                    Title = "The Lord of the Rings, by J.R.R. Tolkien",
                    Description = "https://cdn.lifehack.org/wp-content/uploads/2015/03/9780618640157_custom-s6-c30.jpg",
                    Genre = "History",
                    Price = 20.000m
                },
                new Book
                {
                    Title = "The Great Gatsby, by F. Scott Fitzgerald",
                    Description = "https://cdn.lifehack.org/wp-content/uploads/2015/03/Penguin-2.jpg",
                    Genre = "humor",
                    Price =20.000m
                },
                new Book
                {
                    Title = "Pride and Prejudice, by Jane Austen",
                    Description = "https://cdn.lifehack.org/wp-content/uploads/2015/03/pride_and_prejudice_book_cover_by_fourblackbirds-d533108.png",
                    Genre = "History",
                    Price = 20.000m
                },
                new Book
                {
                    Title = "The Diary Of A Young Girl, by Anne Frank",
                    Description = "https://cdn.lifehack.org/wp-content/uploads/2015/03/diary-of-anne-frank-postcard-front_0.jpg",
                    Genre = "humor",
                    Price =20.000m
                },
                new Book
                {
                    Title = "The Book Thief, by Markus Zusak",
                    Description = "https://cdn.lifehack.org/wp-content/uploads/2015/03/71h2sjik5al-_sl1380_.jpg",
                    Genre = "humor",
                    Price =20.000m
                },
                new Book
                {
                    Title = "The Hobbit, by J.R.R. Tolkien",
                    Description = "https://cdn.lifehack.org/wp-content/uploads/2015/03/Hobbit_book.jpg",
                    Genre = "humor",
                    Price =20.000m
                },
                );

                context.SaveChanges();
            }
        }
    }
}
