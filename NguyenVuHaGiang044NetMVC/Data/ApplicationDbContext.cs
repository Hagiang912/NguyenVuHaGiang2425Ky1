using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenVuHaGiang044NetMVC.Models;

namespace NguyenVuHaGiang044NetMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<NguyenVuHaGiang044NetMVC.Models.Employee> Employee { get; set; } = default!;
    }
}
