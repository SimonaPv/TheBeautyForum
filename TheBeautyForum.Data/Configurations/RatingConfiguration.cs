using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheBeautyForum.Data.Models;

namespace TheBeautyForum.Data.Configurations
{
    public class RatingConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.HasData(RatingsData());
        }

        private ICollection<Rating> RatingsData()
        {
            var data = new HashSet<Rating>();

            #region Arsanta - Aylin, Amaya, Maria
            var rat = new Rating()
            {
                Id = Guid.Parse("168884a2-fc77-4169-836f-dc0a0599bc2e"),
                UserId = Guid.Parse("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                StudioId = Guid.Parse("d8fbc428-62b8-42aa-b3d7-b40658072dca"),
                Value = 5
            };
            data.Add(rat);

            rat = new Rating()
            {
                Id = Guid.Parse("912d1986-7424-43fa-a531-b9d811961386"),
                UserId = Guid.Parse("3bea7392-a556-4a99-86c2-8cb244868283"),
                StudioId = Guid.Parse("d8fbc428-62b8-42aa-b3d7-b40658072dca"),
                Value = 4
            };
            data.Add(rat);

            rat = new Rating()
            {
                Id = Guid.Parse("960c4945-0b04-4c40-bd17-c697cb8d5eda"),
                UserId = Guid.Parse("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                StudioId = Guid.Parse("d8fbc428-62b8-42aa-b3d7-b40658072dca"),
                Value = 5
            };
            data.Add(rat);
            #endregion

            #region Murphy - Debora, Lisa
            rat = new Rating()
            {
                Id = Guid.Parse("bb10aa9c-da74-4846-a075-7b203f22aefc"),
                UserId = Guid.Parse("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                StudioId = Guid.Parse("0d753e1d-c98b-47c7-b260-0377048c529a"),
                Value = 4
            };
            data.Add(rat);

            rat = new Rating()
            {
                Id = Guid.Parse("60502c16-c9bd-4653-94a6-fe623822a42e"),
                UserId = Guid.Parse("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                StudioId = Guid.Parse("0d753e1d-c98b-47c7-b260-0377048c529a"),
                Value = 4
            };
            data.Add(rat);
            #endregion

            #region N-Stage
            rat = new Rating()
            {
                Id = Guid.Parse("9056efb3-0f7d-4393-bca6-a61c8e92ceb5"),
                UserId = Guid.Parse("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                StudioId = Guid.Parse("c7998d5b-0017-4924-8544-49b4a276afe1"),
                Value = 2
            };
            data.Add(rat);
            #endregion

            #region IN Beauty
            rat = new Rating()
            {
                Id = Guid.Parse("9f5c4415-ce99-4d50-82cf-43fda2cdb71b"),
                UserId = Guid.Parse("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                StudioId = Guid.Parse("bf2832b2-5b62-471b-9980-583753504ca6"),
                Value = 3
            };
            data.Add(rat);
            #endregion

            #region Wellness Center
            rat = new Rating()
            {
                Id = Guid.Parse("ffd265a7-832d-4fc1-925c-5e72eab2d02e"),
                UserId = Guid.Parse("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                StudioId = Guid.Parse("df44a062-9586-4815-8126-99c240433b22"),
                Value = 4
            };
            data.Add(rat);
            #endregion

            #region Helita
            rat = new Rating()
            {
                Id = Guid.Parse("beb87557-618d-4fbc-b5a4-12b8f54c5359"),
                UserId = Guid.Parse("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                StudioId = Guid.Parse("ad94f69c-b7e6-419b-bef0-fa50ab04f254"),
                Value = 3
            };
            data.Add(rat);
            #endregion

            return data;
        }
    }
}
