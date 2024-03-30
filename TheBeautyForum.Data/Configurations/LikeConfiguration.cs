using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheBeautyForum.Data.Models;

namespace TheBeautyForum.Data.Configurations
{
    public class LikeConfiguration : IEntityTypeConfiguration<Like>
    {
        public void Configure(EntityTypeBuilder<Like> builder)
        {
            builder.HasData(LikesData());
        }

        private ICollection<Like> LikesData()
        {
            var data = new HashSet<Like>();

            #region Your curls can dream.. #curlyHair #healthy
            var like = new Like()
            {
                Id = Guid.Parse("ece7c6e7-4835-4efb-b79c-929f0b1ce9f3"),
                UserId = Guid.Parse("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"), // lisa
                PublicationId = Guid.Parse("765a831a-5e10-43a8-adf2-e7e8d62fc7e0") //Your curls can dream.. #curlyHair #healthy
            };
            data.Add(like);

            like = new Like()
            {
                Id = Guid.Parse("31322844-7f44-437a-8545-222497d89720"),
                UserId = Guid.Parse("9f9bfaa5-da01-49bf-a819-3b88acf7487f"), // debora
                PublicationId = Guid.Parse("765a831a-5e10-43a8-adf2-e7e8d62fc7e0") //Your curls can dream.. #curlyHair #healthy
            };
            data.Add(like);

            like = new Like()
            {
                Id = Guid.Parse("e132c310-99a1-4058-8781-11c28018e186"),
                UserId = Guid.Parse("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"), // aylin
                PublicationId = Guid.Parse("765a831a-5e10-43a8-adf2-e7e8d62fc7e0") //Your curls can dream.. #curlyHair #healthy
            };
            data.Add(like);

            like = new Like()
            {
                Id = Guid.Parse("98d71ed7-2895-4f0f-b0ec-1a25752efb50"),
                UserId = Guid.Parse("3bea7392-a556-4a99-86c2-8cb244868283"), // amaya
                PublicationId = Guid.Parse("765a831a-5e10-43a8-adf2-e7e8d62fc7e0") //Your curls can dream.. #curlyHair #healthy
            };
            data.Add(like);
            #endregion

            #region A needed day OFF! #relax
            like = new Like()
            {
                Id = Guid.Parse("4ca23634-c46b-470b-aa16-179763aad180"),
                UserId = Guid.Parse("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"), // lisa
                PublicationId = Guid.Parse("368c82c4-7046-44ee-8315-149e4527bd47") //A needed day OFF! #relax
            };
            data.Add(like);

            like = new Like()
            {
                Id = Guid.Parse("0e6636fd-f06f-4277-b928-18e4e2df9e52"),
                UserId = Guid.Parse("9f9bfaa5-da01-49bf-a819-3b88acf7487f"), // debora
                PublicationId = Guid.Parse("368c82c4-7046-44ee-8315-149e4527bd47") //A needed day OFF! #relax
            };
            data.Add(like);

            like = new Like()
            {
                Id = Guid.Parse("edac65d6-e0ef-44b4-b72b-734eb20ec9ff"),
                UserId = Guid.Parse("e482292a-5399-4938-9788-6d76fcb1b4d9"), // maria
                PublicationId = Guid.Parse("368c82c4-7046-44ee-8315-149e4527bd47") //A needed day OFF! #relax
            };
            data.Add(like);
            #endregion

            #region Guess who's getting MARRIED!! #bride #love
            like = new Like()
            {
                Id = Guid.Parse("d9274446-edf6-43d0-a892-16ea8e41b785"),
                UserId = Guid.Parse("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"), // lisa
                PublicationId = Guid.Parse("35b859db-5567-4336-bd2b-34aea67bf26a") // Guess who's getting MARRIED!! #bride #love
            };
            data.Add(like);

            like = new Like()
            {
                Id = Guid.Parse("284a98fd-2559-43f5-9aea-854c747b2d66"),
                UserId = Guid.Parse("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"), // aylin
                PublicationId = Guid.Parse("35b859db-5567-4336-bd2b-34aea67bf26a") //Guess who's getting MARRIED!! #bride #love
            };
            data.Add(like);
            #endregion

            return data;
        }
    }
}
