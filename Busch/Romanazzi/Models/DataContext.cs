using System.Data.Entity;

namespace Romanazzi.Models
{
    public class DataContext: DbContext
    {
        public DataContext(): base ("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Romanazzi.Models.Clown> Clowns { get; set; }
    }
}