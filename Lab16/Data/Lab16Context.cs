using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using persons.Models;

namespace Lab16.Data
{
    public class Lab16Context : DbContext
    {
        public Lab16Context (DbContextOptions<Lab16Context> options)
            : base(options)
        {
        }

        public DbSet<persons.Models.Person> Person { get; set; }
    }
}
