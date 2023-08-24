using Microsoft.EntityFrameworkCore;

namespace PokemonReviewApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {
            
        }
    }
}
