using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Globalization;
using TheBeautyForum.Data.Models;

namespace TheBeautyForum.Data.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Publication>
    {
        public void Configure(EntityTypeBuilder<Publication> builder)
        {
            builder.HasData(PublicationsData());
        }

        private ICollection<Publication> PublicationsData()
        {
            var data = new HashSet<Publication>();

            Publication post = new Publication()
            {
                Id = Guid.Parse("3dff0a05-d97b-44f5-9118-80a276adad91"),
                UserId = Guid.Parse("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                StudioId = Guid.Parse("bf2832b2-5b62-471b-9980-583753504ca6"),
                Description = "Love my new nails!! #nailDay #newNails",
                DatePosted = DateTime.ParseExact("10-02-2024 15:23", "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture)
            };
            data.Add(post);

            post = new Publication()
            {
                Id = Guid.Parse("09d4bfa2-1b65-4085-ad6c-010c20427409"),
                UserId = Guid.Parse("3bea7392-a556-4a99-86c2-8cb244868283"),
                StudioId = Guid.Parse("df44a062-9586-4815-8126-99c240433b22"),
                Description = "Me time.. #spaDay #SPA",
                DatePosted = DateTime.ParseExact("09-02-2024 16:46", "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture)
            };
            data.Add(post);

            post = new Publication()
            {
                Id = Guid.Parse("368c82c4-7046-44ee-8315-149e4527bd47"),
                UserId = Guid.Parse("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                StudioId = Guid.Parse("d8fbc428-62b8-42aa-b3d7-b40658072dca"),
                Description = "A needed day OFF! #relax",
                DatePosted = DateTime.ParseExact("09-02-2024 12:04", "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture)
            };
            data.Add(post);

            post = new Publication()
            {
                Id = Guid.Parse("35b859db-5567-4336-bd2b-34aea67bf26a"),
                UserId = Guid.Parse("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                StudioId = Guid.Parse("0d753e1d-c98b-47c7-b260-0377048c529a"),
                Description = "Guess who's getting MARRIED!! #bride #love",
                DatePosted = DateTime.ParseExact("11-02-2024 09:11", "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture)
            };
            data.Add(post);

            post = new Publication()
            {
                Id = Guid.Parse("765a831a-5e10-43a8-adf2-e7e8d62fc7e0"),
                UserId = Guid.Parse("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                StudioId = Guid.Parse("c7998d5b-0017-4924-8544-49b4a276afe1"),
                Description = "Your curls can dream.. #curlyHair #healthy",
                DatePosted = DateTime.ParseExact("13-02-2024 13:19", "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture)
            };
            data.Add(post);

            return data;
        }
    }
}
