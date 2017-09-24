namespace Register.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
	using Register.Models;

	internal sealed class Configuration : DbMigrationsConfiguration<RegisterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RegisterContext context)
        {
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data. E.g.
			//
			//    context.People.AddOrUpdate(
			//      p => p.FullName,
			//      new Person { FullName = "Andrew Peters" },
			//      new Person { FullName = "Brice Lambson" },
			//      new Person { FullName = "Rowan Miller" }
			//    );
			//
			context.Users.AddOrUpdate(
				p => p.UserName,
				new User
				{
					UserName = "OFuCodeFirst",
					Password = "Qwerty123",
					FirstName = "Oliver",
					LastName = "Fu",
					About = "Welcome to my basic social media app",
					RememberMe = true,
					Gender = "Male"
				}
				);
			context.Interests.AddOrUpdate(
				p => p.Id,
				new Interest { Name = "Bar-hopping and pub crawls" },
				new Interest { Name = "Board games" },
				new Interest { Name = "Car customization" },
				new Interest { Name = "Clubbing" },
				new Interest { Name = "Coding" },
				new Interest { Name = "Crafts (jewelry, woodworking, furniture, stationery, clothing, glass-blowing" },
				new Interest { Name = "Fishing" },
				new Interest { Name = "Foodie things" },
				new Interest { Name = "Hiking" },
				new Interest { Name = "Indoor rock climbing" },
				new Interest { Name = "Karaoke" },
				new Interest { Name = "Microbrewing" },
				new Interest { Name = "Reading" },
				new Interest { Name = "Social dancing" },
				new Interest { Name = "Visual arts (painting, drawing, sketching, watercolors, photography" },
				new Interest { Name = "Creative writing" },

				new Interest { Name = "Sport: baseball" },
				new Interest { Name = "Sport: basketball" },
				new Interest { Name = "Sport: dodgeball" },
				new Interest { Name = "Sport: foosball" },
				new Interest { Name = "Sport: American football" },
				new Interest { Name = "Sport: International-style football (soccer)" },
				new Interest { Name = "Sport: ultimate frisbee" },
				new Interest { Name = "Sport: ping pong" },
				new Interest { Name = "Sport: competitive swimming" },
				new Interest { Name = "Sport: tennis" },
				new Interest { Name = "Sport: water polo" },
				new Interest { Name = "Other" }
				);
        }
    }
}
