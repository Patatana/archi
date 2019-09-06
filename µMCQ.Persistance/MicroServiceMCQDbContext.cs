using MicroServiceMCQ.Domain.Entities;
using MicroServiceMCQ.Persistance.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceMCQ.Persistance
{
    public class MicroServiceMCQDbContext : DbContext  
    {
        public MicroServiceMCQDbContext() : base()
        {

        }

        public DbSet<Question> Question{ get; set; }
        public DbSet<Answer> Answer  { get; set; }
        public DbSet<QuestionType> QuestionType { get; set; }

        public MicroServiceMCQDbContext(DbContextOptions<MicroServiceMCQDbContext> options) : base(options) { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //Chaine de connexion
                var connection = "Data Source=localhost;Initial Catalog=testArchi;User ID=jean;Password=neymar";
                optionsBuilder.UseLazyLoadingProxies();
                //UseSqlServer => Determine le SGBD à utiliser
                optionsBuilder.UseSqlServer(connection);

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MicroServiceMCQDbContext).Assembly);

        }
    }
}
