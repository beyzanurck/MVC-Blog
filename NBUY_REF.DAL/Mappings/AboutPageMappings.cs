using NBUY_REF.Entities;

using System.Data.Entity.ModelConfiguration;


namespace NBUY_REF.DAL.Mappings
{
    public class AboutPageMappings: EntityTypeConfiguration<AboutPage>
    {
        public AboutPageMappings()
        {
            ToTable("About", "blog");
        }
    }

    
}
