﻿using FIT.Data;
using FIT.Data.IB220240;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace FIT.Infrastructure
{
    public class DLWMSDbContext : DbContext
    {
        private readonly string dbPutanja;

        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
    
        public DbSet<Predmeti> Predmeti{ get; set; }
        public DbSet<Semestri> Semestri { get; set; }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<PolozeniPredmeti> PolozeniPredmeti{ get; set; }
        public DbSet<StudentiUvjerenja> StudentiUvjerenja { get; set; }

    }
}