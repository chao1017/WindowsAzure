namespace ContactManager.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ContactManager.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ContactManager.Models.ContactManagerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ContactManager.Models.ContactManagerContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.Friends.AddOrUpdate(p => p.Name,
                        new Friends
                        {
                            Name = "Debra Garcia",
                            Address = "1234 Main St",
                            City = "Redmond",
                            County = "WA",
                            Zip = "10999",
                            Email = "debra@example.com",
                        },
                         new Friends
                         {
                             Name = "Thorsten Weinrich",
                             Address = "5678 1st Ave W",
                             City = "Redmond",
                             County = "WA",
                             Zip = "10999",
                             Email = "thorsten@example.com",
                         },
                         new Friends
                         {
                             Name = "Yuhong Li",
                             Address = "9012 State st",
                             City = "Redmond",
                             County = "WA",
                             Zip = "10999",
                             Email = "yuhong@example.com",
                         },
                         new Friends
                         {
                             Name = "Jon Orton",
                             Address = "3456 Maple St",
                             City = "Redmond",
                             County = "WA",
                             Zip = "10999",
                             Email = "jon@example.com",
                         },
                         new Friends
                         {
                             Name = "Diliana Alexieva-Bosseva",
                             Address = "7890 2nd Ave E",
                             City = "Redmond",
                             County = "WA",
                             Zip = "10999",
                             Email = "diliana@example.com",
                         }
            );
        }//protected override void Seed(ContactManager.Models.ContactManagerContext context)
    }
}
