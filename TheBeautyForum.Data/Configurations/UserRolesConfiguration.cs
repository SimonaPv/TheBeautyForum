using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TheBeautyForum.Data.Configurations
{
    public class UserRolesConfiguration : IEntityTypeConfiguration<IdentityUserRole<Guid>>
    {

        public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
        {
            builder.HasData(RolesData());
        }

        private ICollection<IdentityUserRole<Guid>> RolesData()
        {
            var data = new HashSet<IdentityUserRole<Guid>>();

            var userRole = new IdentityUserRole<Guid>()
            {
                UserId = Guid.Parse("6774a48a-7836-4ce6-9ef1-ea7be75b4ec5"),
                RoleId = Guid.Parse("56bdecaf-285f-4a8e-b650-8bc997be759d")
            };
            data.Add(userRole);

            userRole = new IdentityUserRole<Guid>()
            {
                UserId = Guid.Parse("b313e2e1-0270-4a86-924b-71256500be8b"),
                RoleId = Guid.Parse("71d6d7d8-f4f6-42b5-a9a9-ed2d3ef0bc73")
            };
            data.Add(userRole);

            userRole = new IdentityUserRole<Guid>()
            {
                UserId = Guid.Parse("1674d538-3cf0-4a6e-bc27-aa070a230647"),
                RoleId = Guid.Parse("71d6d7d8-f4f6-42b5-a9a9-ed2d3ef0bc73")
            };
            data.Add(userRole);

            userRole = new IdentityUserRole<Guid>()
            {
                UserId = Guid.Parse("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                RoleId = Guid.Parse("5a322cf5-7101-4d4a-9e08-16382fc0a641")
            };
            data.Add(userRole);

            userRole = new IdentityUserRole<Guid>()
            {
                UserId = Guid.Parse("3bea7392-a556-4a99-86c2-8cb244868283"),
                RoleId = Guid.Parse("5a322cf5-7101-4d4a-9e08-16382fc0a641")
            };
            data.Add(userRole);

            userRole = new IdentityUserRole<Guid>()
            {
                UserId = Guid.Parse("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                RoleId = Guid.Parse("5a322cf5-7101-4d4a-9e08-16382fc0a641")
            };
            data.Add(userRole);

            userRole = new IdentityUserRole<Guid>()
            {
                UserId = Guid.Parse("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                RoleId = Guid.Parse("5a322cf5-7101-4d4a-9e08-16382fc0a641")
            };
            data.Add(userRole);

            userRole = new IdentityUserRole<Guid>()
            {
                UserId = Guid.Parse("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                RoleId = Guid.Parse("5a322cf5-7101-4d4a-9e08-16382fc0a641")
            };
            data.Add(userRole);

            return data;
        }
    }
}
