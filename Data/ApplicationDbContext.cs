using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BoilerplateMVC.Models;

namespace BoilerplateMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        /*
            The main DbSet class
            Contains all class for performing a entity migration in the DB
        */
        public DbSet<Cliente> Movie { get; set; }
    }
}
