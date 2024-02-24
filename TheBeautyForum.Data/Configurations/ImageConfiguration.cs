using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheBeautyForum.Data.Models;

namespace TheBeautyForum.Data.Configurations
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(ImagesData());
        }

        private ICollection<Image> ImagesData()
        {
            var data = new HashSet<Image>();

            Image img = new Image()
            {
                Id = Guid.Parse("dd2c855b-e8cb-43c8-8437-c8fbd54444a8"),
                PublicationId = Guid.Parse("3dff0a05-d97b-44f5-9118-80a276adad91"),
                UrlPath = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706685966/oaxk2efd2zcewio2tciv.jpg"
            };
            data.Add(img);

            img = new Image()
            {
                Id = Guid.Parse("e121ce4c-f437-4696-99fa-1859d1de6780"),
                PublicationId = Guid.Parse("09d4bfa2-1b65-4085-ad6c-010c20427409"),
                UrlPath = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706685965/bypcq7r5kqpgjbm8keka.jpg"
            };
            data.Add(img);

            img = new Image()
            {
                Id = Guid.Parse("120dbf97-04a7-4cf4-a4f9-aea8ffc3037f"),
                PublicationId = Guid.Parse("368c82c4-7046-44ee-8315-149e4527bd47"),
                UrlPath = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706685966/y7uikxn4ib53acmxt978.jpg"
            };
            data.Add(img);

            img = new Image()
            {
                Id = Guid.Parse("5b637ca8-0eaf-41d7-ae31-6f506bbcd812"),
                PublicationId = Guid.Parse("35b859db-5567-4336-bd2b-34aea67bf26a"),
                UrlPath = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706685965/x2kx2oeyhz22ouwandcr.jpg"
            };
            data.Add(img);

            img = new Image()
            {
                Id = Guid.Parse("02fa054e-3efe-4923-b267-aca9ac769f81"),
                PublicationId = Guid.Parse("765a831a-5e10-43a8-adf2-e7e8d62fc7e0"),
                UrlPath = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706685966/v9b0ghriku0s2pfsppaj.jpg"
            };
            data.Add(img);

            return data;
        }
    }
}
