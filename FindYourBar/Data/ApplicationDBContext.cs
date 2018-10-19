using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FindYourBar.Models;

namespace FindYourBar.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Bar> Bar { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}