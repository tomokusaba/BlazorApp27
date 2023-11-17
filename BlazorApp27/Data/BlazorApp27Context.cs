using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorApp27.Model;

namespace BlazorApp27.Data
{
    public class BlazorApp27Context : DbContext
    {
        public BlazorApp27Context (DbContextOptions<BlazorApp27Context> options)
            : base(options)
        {
        }

        public DbSet<BlazorApp27.Model.Books> Books { get; set; } = default!;
    }
}
