﻿using Microsoft.EntityFrameworkCore;

namespace MovieRazor.Models.MovieDbContext
{
    public class MovieDbContext:DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
