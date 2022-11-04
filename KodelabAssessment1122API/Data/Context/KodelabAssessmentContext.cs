using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using KodelabAssessment1122DLL.DomainModels;

namespace KodelabAssessment1122API.Data.Context
{
    public class KodelabAssessmentContext : IdentityDbContext
    {

        public KodelabAssessmentContext(DbContextOptions<KodelabAssessmentContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    // optionsBuilder.UseSqlServer("");
        //    base.OnConfiguring(optionsBuilder);
        //}

        public DbSet<QuizQuestions> Questions { get; set; }

        public DbSet<Quiz> Quiz { get; set; }

        public DbSet<QuizAnswers> Answers { get; set; }

        public DbSet<UserAnswers> UserAnswers { get; set; }


    }
}
