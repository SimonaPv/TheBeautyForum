using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheBeautyForum.Data.Models;

namespace TheBeautyForum.Data.Configurations
{
    public class StudioConfiguration : IEntityTypeConfiguration<Studio>
    {
        public void Configure(EntityTypeBuilder<Studio> builder)
        {
            builder.HasData(StudiosData());
        }

        private ICollection<Studio> StudiosData()
        {
            var data = new HashSet<Studio>();

            var studio = new Studio()
            {
                Id = Guid.Parse("ad94f69c-b7e6-419b-bef0-fa50ab04f254"),
                Name = "Helita",
                Description = "Dream haircuts can come true!",
                Location = "Varna, Bulgaria, ul. Zora 371",
                OpenTime = TimeOnly.Parse("9:00:00"),
                CloseTime = TimeOnly.Parse("18:00:00"),
                StudioPictureUrl = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706708324/cjb6es4kqpy6kukryk8r.jpg",
                IsApproved = false,
                UserId = Guid.Parse("b313e2e1-0270-4a86-924b-71256500be8b")
            };
            data.Add(studio);

            studio = new Studio()
            {
                Id = Guid.Parse("0d753e1d-c98b-47c7-b260-0377048c529a"),
                Name = "Murphy",
                Description = "Hairstyling and Haircutting",
                Location = "Stara Zagora, Bulgaria, ul. Tsar Kaloyan 3",
                OpenTime = TimeOnly.Parse("9:00:00"),
                CloseTime = TimeOnly.Parse("18:00:00"),
                StudioPictureUrl = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706708324/fnk089i9d440zt0vuhjm.jpg",
                IsApproved = true,
                UserId = Guid.Parse("b313e2e1-0270-4a86-924b-71256500be8b")
            };
            data.Add(studio);

            studio = new Studio()
            {
                Id = Guid.Parse("bf2832b2-5b62-471b-9980-583753504ca6"),
                Name = "IN Beauty",
                Description = "Ina Vasileva's Studio",
                Location = "Varna, Bulgaria, ul. Veles 7",
                OpenTime = TimeOnly.Parse("9:00:00"),
                CloseTime = TimeOnly.Parse("18:00:00"),
                StudioPictureUrl = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706708324/omikwkyqnrafjnju82jf.jpg",
                IsApproved = true,
                UserId = Guid.Parse("1674d538-3cf0-4a6e-bc27-aa070a230647")
            };
            data.Add(studio);

            studio = new Studio()
            {
                Id = Guid.Parse("c7998d5b-0017-4924-8544-49b4a276afe1"),
                Name = "N-Stage",
                Description = "Hair Care Studio",
                Location = "Sofia, Bulgaria, ul. Dospat 44",
                OpenTime = TimeOnly.Parse("9:00:00"),
                CloseTime = TimeOnly.Parse("18:00:00"),
                StudioPictureUrl = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706708324/ulq1xkktowireigsxuil.jpg",
                IsApproved = true,
                UserId = Guid.Parse("1674d538-3cf0-4a6e-bc27-aa070a230647")
            };
            data.Add(studio);

            studio = new Studio()
            {
                Id = Guid.Parse("df44a062-9586-4815-8126-99c240433b22"),
                Name = "Wellness Center",
                Description = "SPA Studio",
                Location = "Sofia, Bulgaria, ul. Erovete 7",
                OpenTime = TimeOnly.Parse("9:00:00"),
                CloseTime = TimeOnly.Parse("18:00:00"),
                StudioPictureUrl = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706708324/wrm1h8b2sfjf06xujkck.jpg",
                IsApproved = true,
                UserId = Guid.Parse("1674d538-3cf0-4a6e-bc27-aa070a230647")
            };
            data.Add(studio);

            studio = new Studio()
            {
                Id = Guid.Parse("d8fbc428-62b8-42aa-b3d7-b40658072dca"),
                Name = "Arsanta",
                Description = "Bali&Thai Massages",
                Location = "Sofia, Bulgaria, ul. Aksakov 11",
                OpenTime = TimeOnly.Parse("9:00:00"),
                CloseTime = TimeOnly.Parse("18:00:00"),
                StudioPictureUrl = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706708324/sf7gy9cpjrnlkn2ba8rs.jpg",
                IsApproved = true,
                UserId = Guid.Parse("b313e2e1-0270-4a86-924b-71256500be8b")
            };
            data.Add(studio);

            return data;
        }
    }
}
