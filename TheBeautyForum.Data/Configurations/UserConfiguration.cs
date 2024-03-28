using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheBeautyForum.Data.Models;

namespace TheBeautyForum.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(UsersData());
        }

        private ICollection<User> UsersData()
        {
            var data = new HashSet<User>();
            var hasher = new PasswordHasher<User>();

            var user = new User()
            {
                Id = Guid.Parse("6774a48a-7836-4ce6-9ef1-ea7be75b4ec5"),
                UserName = "simonapalieva@mail.com",
                NormalizedUserName = "simonapalieva@mail.com".ToUpper(),
                Email = "simonapalieva@mail.com",
                NormalizedEmail = "SIMONAPALIEVA@MAIL.COM",
                FirstName = "Simona",
                LastName = "Palieva",
                PhoneNumber = "0884912724",
                ProfilePictureUrl = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1711218695/fngujmuenduudydw6g0m.png",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                UserRole = "Administrator"
            };
            user.PasswordHash = hasher.HashPassword(user, "123456");
            data.Add(user);

            user = new User()
            {
                Id = Guid.Parse("b313e2e1-0270-4a86-924b-71256500be8b"),
                UserName = "mirelametodieva@mail.com",
                NormalizedUserName = "mirelametodieva@mail.com".ToUpper(),
                Email = "mirelametodieva@mail.com",
                NormalizedEmail = "MIRELAMETODIEVA@MAIL.COM",
                FirstName = "Mirela",
                LastName = "Metodieva",
                PhoneNumber = "0886666666",
                ProfilePictureUrl = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1711219006/pqqa3hau5sceuvlbbvwk.jpg",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                UserRole = "Studio creator"
            };
            user.PasswordHash = hasher.HashPassword(user, "123456");
            data.Add(user);

            user = new User()
            {
                Id = Guid.Parse("1674d538-3cf0-4a6e-bc27-aa070a230647"),
                UserName = "monailieva@mail.com",
                NormalizedUserName = "monailieva@mail.com".ToUpper(),
                Email = "monailieva@mail.com",
                NormalizedEmail = "MONAILIEVA@MAIL.COM",
                FirstName = "Mona",
                LastName = "Ilieva",
                PhoneNumber = "0887777777",
                ProfilePictureUrl = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1711366246/c1ijia1awr51quznbqgu.jpg",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                UserRole = "Studio creator"
            };
            user.PasswordHash = hasher.HashPassword(user, "123456");
            data.Add(user);

            user = new User()
            {
                Id = Guid.Parse("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                UserName = "mariageorgieva@mail.com",
                NormalizedUserName = "mariageorgieva@mail.com".ToUpper(),
                Email = "mariageorgieva@mail.com",
                NormalizedEmail = "MARIAGEORGIEVA@MAIL.COM",
                FirstName = "Maria",
                LastName = "Georgieva",
                PhoneNumber = "0881111111",
                ProfilePictureUrl = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1707378748/einenpgospeodkzbw8a7.jpg",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                UserRole = "User"
            };
            user.PasswordHash = hasher.HashPassword(user, "123456");
            data.Add(user);

            user = new User()
            {
                Id = Guid.Parse("3bea7392-a556-4a99-86c2-8cb244868283"),
                UserName = "amayaivanova@mail.com",
                NormalizedUserName = "amayaivanova@mail.com".ToUpper(),
                Email = "amayaivanova@mail.com",
                NormalizedEmail = "amayaivanova@mail.com".ToUpper(),
                FirstName = "Amaya",
                LastName = "Ivanova",
                PhoneNumber = "0882222222",
                ProfilePictureUrl = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706685966/imzfycue1optdhfmwbuw.jpg",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                UserRole = "User"
            };
            user.PasswordHash = hasher.HashPassword(user, "123456");
            data.Add(user);

            user = new User()
            {
                Id = Guid.Parse("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                UserName = "aylintodorova@mail.com",
                NormalizedUserName = "aylintodorova@mail.com".ToUpper(),
                Email = "aylintodorova@mail.com",
                NormalizedEmail = "aylintodorova@mail.com".ToUpper(),
                FirstName = "Aylin",
                LastName = "Todorova",
                PhoneNumber = "0883333333",
                ProfilePictureUrl = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1707378004/kgdkin0zow7lkpkc4hdy.jpg",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                UserRole = "User"
            };
            user.PasswordHash = hasher.HashPassword(user, "123456");
            data.Add(user);

            user = new User()
            {
                Id = Guid.Parse("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                UserName = "deboramileva@mail.com",
                NormalizedUserName = "deboramileva@mail.com".ToUpper(),
                Email = "deboramileva@mail.com",
                NormalizedEmail = "deboramileva@mail.com".ToUpper(),
                FirstName = "Debora",
                LastName = "Mileva",
                PhoneNumber = "0884444444",
                ProfilePictureUrl = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706685966/npkpvs3b2i1tldoc7dmi.jpg",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                UserRole = "User"
            };
            user.PasswordHash = hasher.HashPassword(user, "123456");
            data.Add(user);

            user = new User()
            {
                Id = Guid.Parse("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                UserName = "lisaborisova@mail.com",
                NormalizedUserName = "lisaborisova@mail.com".ToUpper(),
                Email = "lisaborisova@mail.com",
                NormalizedEmail = "lisaborisova@mail.com".ToUpper(),
                FirstName = "Lisa",
                LastName = "Borisova",
                PhoneNumber = "0885555555",
                ProfilePictureUrl = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1709708446/am3nsitkxsxivfdoxey9.jpg",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                UserRole = "User"
            };
            user.PasswordHash = hasher.HashPassword(user, "123456");
            data.Add(user);

            return data;
        }
    }
}
