using Microsoft.EntityFrameworkCore;
namespace LoginRegistration.Models
{ 
    // the MyContext class representing a session with our MySQL 
    // database allowing us to query for or save data
    public class LoginRegContext : DbContext 
    { 
        public LoginRegContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}