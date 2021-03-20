using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab5.NET.Models;
using Lab5.NET.Controllers;

namespace Lab5.NET.Data
{
    public class AnswerImageDataContext : DbContext
    {
        public DbSet<AnswerImage> AnswerImage { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnswerImage>().ToTable("AnswerImage");
        }
        public AnswerImageDataContext(DbContextOptions<AnswerImageDataContext> options)
          : base(options)
        {

        }

       

    }
}
