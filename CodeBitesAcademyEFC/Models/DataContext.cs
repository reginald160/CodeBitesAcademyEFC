using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using CodeBitesAcademyEFC.Models;

namespace CodeBitesAcademyEFC.Models
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options) : base (options)
        {  }

        public DbSet<EmployeeModel> EmployeeTable { get; set; }
    }
}
