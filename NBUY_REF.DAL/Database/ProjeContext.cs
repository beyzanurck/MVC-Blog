using NBUY_REF.DAL.Mappings;
using NBUY_REF.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace NBUY_REF.DAL.Database
{
    public class ProjeContext : DbContext
    {
        public ProjeContext()
            :base("defaultConnection")
        {
            var ensureDLLIsCopied =
           System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ContactPageMappings());
            modelBuilder.Configurations.Add(new AboutPageMappings());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<AboutPage> AboutPage { get; set; }

        public DbSet<ContactPage> ContactPage { get; set; }


    }
}
