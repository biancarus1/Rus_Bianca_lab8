using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rus_Bianca_lab.Models;

namespace Rus_Bianca_lab.Data
{
    public class Rus_Bianca_labContext : DbContext
    {
        public Rus_Bianca_labContext (DbContextOptions<Rus_Bianca_labContext> options)
            : base(options)
        {
        }

        public DbSet<Rus_Bianca_lab.Models.Book> Book { get; set; }

        public DbSet<Rus_Bianca_lab.Models.Publisher> Publisher { get; set; }

        public DbSet<Rus_Bianca_lab.Models.Category> Category { get; set; }
    }
}
