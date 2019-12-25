using NBUY_REF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUY_REF.DAL.Mappings
{
    public class IndexPageMappings: EntityTypeConfiguration<IndexPage>
    {
        public IndexPageMappings()
        {
            ToTable("IndexPage", "blog");
        }
    }
}
