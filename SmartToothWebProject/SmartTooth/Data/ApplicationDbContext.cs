using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartTooth.Models;

namespace SmartTooth.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Dentist> DentistTable { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
