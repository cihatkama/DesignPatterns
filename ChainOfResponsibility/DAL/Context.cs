using Microsoft.EntityFrameworkCore;

namespace ChainOfResponsibility.DAL
{
    public class Context : DbContext
    {
        // code first ile veri tabanı ayağa kaldırma yöntemi.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=CYK-VICTUS;initial catalog=DesignPattern1;integrated security=true;");
        }

        public DbSet<CustomerProcessViewModel> CustomerProcesses { get; set; }
    }
}
