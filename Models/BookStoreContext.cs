﻿using Microsoft.EntityFrameworkCore;

namespace BookStoreApi.Models
{
    //Make A BookStore Context
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options):base(options)
        {
        }
        public DbSet<Book> Books { get; set; } = null!;
    }
}
