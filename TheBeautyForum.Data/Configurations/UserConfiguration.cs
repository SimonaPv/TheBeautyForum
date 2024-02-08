using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                Id = Guid.Parse("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                UserName = "Maria",
                NormalizedUserName = "MARIA",
                Email = "mariageorgieva@mail.com",
                NormalizedEmail = "MARIAGEORGIEVA@MAIL.COM",
                FirstName = "Maria",
                LastName = "Georgieva",
                PhoneNumber = "0881111111",
                ProfilePictureUrl = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1707378748/einenpgospeodkzbw8a7.jpg",
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            user.PasswordHash = hasher.HashPassword(user, "123456");
            data.Add(user);
            
            user = new User()
            {
                Id = Guid.Parse("3bea7392-a556-4a99-86c2-8cb244868283"),
                UserName = "Amaya",
                NormalizedUserName = "AMAYA",
                Email = "amayaivanova@mail.com",
                NormalizedEmail = "amayaivanova@mail.com".ToUpper(),
                FirstName = "Amaya",
                LastName = "Ivanova",
                PhoneNumber = "0882222222",
                ProfilePictureUrl = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706685966/imzfycue1optdhfmwbuw.jpg",
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            user.PasswordHash = hasher.HashPassword(user, "123456");
            data.Add(user);

            user = new User()
            {
                Id = Guid.Parse("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                UserName = "Aylin",
                NormalizedUserName = "AYLIN".ToUpper(),
                Email = "aylintodorova@mail.com",
                NormalizedEmail = "aylintodorova@mail.com".ToUpper(),
                FirstName = "Aylin",
                LastName = "Todorova",
                PhoneNumber = "0883333333",
                ProfilePictureUrl = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1707378004/kgdkin0zow7lkpkc4hdy.jpg",
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            user.PasswordHash = hasher.HashPassword(user, "123456");
            data.Add(user);

            user = new User()
            {
                Id = Guid.Parse("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                UserName = "Debora",
                NormalizedUserName = "DEBORA",
                Email = "deboramileva@mail.com",
                NormalizedEmail = "deboramileva@mail.com".ToUpper(),
                FirstName = "Debora",
                LastName = "Mileva",
                PhoneNumber = "0884444444",
                ProfilePictureUrl = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706685966/npkpvs3b2i1tldoc7dmi.jpg",
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            user.PasswordHash = hasher.HashPassword(user, "123456");
            data.Add(user);

            user = new User()
            {
                Id = Guid.Parse("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                UserName = "Lisa",
                NormalizedUserName = "LISA",
                Email = "lisaborisova@mail.com",
                NormalizedEmail = "lisaborisova@mail.com".ToUpper(),
                FirstName = "Lisa",
                LastName = "Borisova",
                PhoneNumber = "0885555555",
                ProfilePictureUrl = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706685966/tgcfanokk6wo33rpsurj.jpg",
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            user.PasswordHash = hasher.HashPassword(user, "123456");
            data.Add(user);

            return data;
        }
    }
}
