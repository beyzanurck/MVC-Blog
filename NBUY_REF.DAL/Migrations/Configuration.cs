namespace NBUY_REF.DAL.Migrations
{
    using NBUY_REF.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NBUY_REF.DAL.Database.ProjeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NBUY_REF.DAL.Database.ProjeContext context)
        {

            if (!context.AboutPage.Any())
            {
                var aboutPage = new AboutPage
                {
                    TitleName = "İlk başlık",
                    AboutDescription = "Seed ile geldi"
                };
                context.AboutPage.Add(aboutPage);
                context.SaveChanges();
            }
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
