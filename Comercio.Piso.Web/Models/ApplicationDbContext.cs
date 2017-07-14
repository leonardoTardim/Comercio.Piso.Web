using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Comercio.Piso.Web.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private int plura;

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Configuration.LazyLoadingEnabled = false;
       
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameconvention>();
           // modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvetion>();
            //modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvetion>();

            base.OnModelCreating(modelBuilder);
        }


        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Cliente> Clientes { get; set; }
    }

    internal class PluralizingTableNameconvention
    {
    }
}