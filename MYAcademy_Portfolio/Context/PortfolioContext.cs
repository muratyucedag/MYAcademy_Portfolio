using Microsoft.EntityFrameworkCore;
using MYAcademy_Portfolio.Entities;

namespace MYAcademy_Portfolio.Context
{
    public class PortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-R7AR1ND;Database=PortfolioDbNight;integrated security=true;trust server certificate=true");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<HeroSection> HeroSections { get; set; }
    }
}
//override

//Payment--> Pay() ---> Havale/Eft, Kredi Kartı, Kapıda Ödeme