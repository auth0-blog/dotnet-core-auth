using Microsoft.EntityFrameworkCore;

namespace dotnet_grocery_list.Models
{
    public class GroceryListContext : DbContext
    {
        public GroceryListContext(DbContextOptions<GroceryListContext> options)
            : base(options)
        {
        }

        public DbSet<GroceryItem> GroceryList { get; set; }

    }
}
