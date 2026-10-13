using Microsoft.EntityFrameworkCore;
using MYAcademy_Portfolio.Entities;

namespace MYAcademy_Portfolio.Context
{
    public class PortfolioContext : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
