using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppCRUD.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Categoria> Categorie { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}