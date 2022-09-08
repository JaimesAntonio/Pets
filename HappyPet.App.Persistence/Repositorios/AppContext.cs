using Microsoft.EntityFrameworkCore;
using happypet.app.Domain;
namespace HappyPet.App.Persistence
{
    public class AppContext : DbContext
    {
        public Dbset<Pesona> Personas {get; set;}
        protected overrride void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer(Data source = (localdb)\\MSSQLLlocalDB; Initial Catalog = HappyPetData);
            }
        }
    }
    
}