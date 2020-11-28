using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Marasescu_Flaviu_Lab8.Models;

namespace Marasescu_Flaviu_Lab8.Data
{
    public class Marasescu_Flaviu_Lab8Context : DbContext
    {
        public Marasescu_Flaviu_Lab8Context (DbContextOptions<Marasescu_Flaviu_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Marasescu_Flaviu_Lab8.Models.Book> Book { get; set; }

        public DbSet<Marasescu_Flaviu_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Marasescu_Flaviu_Lab8.Models.Category> Category { get; set; }
    }
}
