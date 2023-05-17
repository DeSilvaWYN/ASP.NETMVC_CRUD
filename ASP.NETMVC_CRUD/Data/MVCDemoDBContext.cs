using ASP.NETMVC_CRUD.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ASP.NETMVC_CRUD.Data
{
    public class MVCDemoDBContext : DbContext
    {
        public MVCDemoDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; } 
    }
}
