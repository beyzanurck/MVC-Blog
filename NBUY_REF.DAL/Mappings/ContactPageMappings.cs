using NBUY_REF.Entities;
using System.Data.Entity.ModelConfiguration;



namespace NBUY_REF.DAL.Mappings
{
    public class ContactPageMappings : EntityTypeConfiguration<ContactPage>
    {
        public ContactPageMappings()
        {
            ToTable("Contact", "blog");
        }
    }
}
