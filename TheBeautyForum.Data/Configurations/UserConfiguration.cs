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

            var user = new User()
            {
                Id = Guid.Parse("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                UserName = "mariageorgieva@mail.com",
                NormalizedUserName = "MARIAGEORGIEVA@MAIL.COM",
                Email = "mariageorgieva@mail.com",
                NormalizedEmail = "MARIAGEORGIEVA@MAIL.COM",
                FirstName = "Maria",
                LastName = "Georgieva",
                PhoneNumber = "0881111111",
                ProfilePictureUrl = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706685966/domw93xprf2dlxj3n7in.jpg"
            };
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
                ProfilePictureUrl = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706685966/imzfycue1optdhfmwbuw.jpg"
            };
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
                ProfilePictureUrl = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706685966/qa7jgeb1ys6nfvhzhswl.jpg"
            };
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
                ProfilePictureUrl = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706685966/npkpvs3b2i1tldoc7dmi.jpg"
            };
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
                ProfilePictureUrl = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706685966/tgcfanokk6wo33rpsurj.jpg"
            };
            data.Add(user);

            return data;
        }
    }
}
