using Microsoft.EntityFrameworkCore;
using PetClinic.API.Models;

namespace PetClinic.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}

        public DbSet<Value> Values {get; set;}
    }
}