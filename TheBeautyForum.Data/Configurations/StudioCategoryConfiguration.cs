using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheBeautyForum.Data.Models;

namespace TheBeautyForum.Data.Configurations
{
    public class StudioCategoryConfiguration : IEntityTypeConfiguration<StudioCategory>
    {
        public void Configure(EntityTypeBuilder<StudioCategory> builder)
        {
            builder.HasData(StudioCategoryData());
        }

        private ICollection<StudioCategory> StudioCategoryData()
        {
            var data = new HashSet<StudioCategory>();

            //Helita start
            var stuCat = new StudioCategory()
            {
                StudioId = Guid.Parse("ad94f69c-b7e6-419b-bef0-fa50ab04f254"),
                CategoryId = Guid.Parse("3be6b016-9b6a-4f68-b7ee-bf32293acca9")
            };
            data.Add(stuCat);

            stuCat = new StudioCategory()
            {
                StudioId = Guid.Parse("ad94f69c-b7e6-419b-bef0-fa50ab04f254"),
                CategoryId = Guid.Parse("db7effe2-16bb-4539-9dec-0bda384b859f")
            };
            data.Add(stuCat);

            stuCat = new StudioCategory()
            {
                StudioId = Guid.Parse("ad94f69c-b7e6-419b-bef0-fa50ab04f254"),
                CategoryId = Guid.Parse("1125ebe4-4f81-4bb8-90ee-aceaf509c4f3")
            };
            data.Add(stuCat);

            stuCat = new StudioCategory()
            {
                StudioId = Guid.Parse("ad94f69c-b7e6-419b-bef0-fa50ab04f254"),
                CategoryId = Guid.Parse("8859c909-f5cf-4f72-ba53-5a9e6dfac34d")
            };
            data.Add(stuCat);
            //Helita end

            //Murphy start
            stuCat = new StudioCategory()
            {
                StudioId = Guid.Parse("0d753e1d-c98b-47c7-b260-0377048c529a"),
                CategoryId = Guid.Parse("3be6b016-9b6a-4f68-b7ee-bf32293acca9")
            };
            data.Add(stuCat);

            stuCat = new StudioCategory()
            {
                StudioId = Guid.Parse("0d753e1d-c98b-47c7-b260-0377048c529a"),
                CategoryId = Guid.Parse("db7effe2-16bb-4539-9dec-0bda384b859f")
            };
            data.Add(stuCat);

            stuCat = new StudioCategory()
            {
                StudioId = Guid.Parse("0d753e1d-c98b-47c7-b260-0377048c529a"),
                CategoryId = Guid.Parse("1125ebe4-4f81-4bb8-90ee-aceaf509c4f3")
            };
            data.Add(stuCat);

            stuCat = new StudioCategory()
            {
                StudioId = Guid.Parse("0d753e1d-c98b-47c7-b260-0377048c529a"),
                CategoryId = Guid.Parse("8859c909-f5cf-4f72-ba53-5a9e6dfac34d")
            };
            data.Add(stuCat);
            //Murphy end

            //IN Beauty start
            stuCat = new StudioCategory()
            {
                StudioId = Guid.Parse("bf2832b2-5b62-471b-9980-583753504ca6"),
                CategoryId = Guid.Parse("4ebb7e23-2a49-4451-8c96-b5c6de99900e")
            };
            data.Add(stuCat);

            stuCat = new StudioCategory()
            {
                StudioId = Guid.Parse("bf2832b2-5b62-471b-9980-583753504ca6"),
                CategoryId = Guid.Parse("2da87f9f-d52a-4d4b-a8c6-37200c4cfeea")
            };
            data.Add(stuCat);
            //IN beauty end

            //N-Stage start
            stuCat = new StudioCategory()
            {
                StudioId = Guid.Parse("c7998d5b-0017-4924-8544-49b4a276afe1"),
                CategoryId = Guid.Parse("3be6b016-9b6a-4f68-b7ee-bf32293acca9")
            };
            data.Add(stuCat);

            stuCat = new StudioCategory()
            {
                StudioId = Guid.Parse("c7998d5b-0017-4924-8544-49b4a276afe1"),
                CategoryId = Guid.Parse("db7effe2-16bb-4539-9dec-0bda384b859f")
            };
            data.Add(stuCat);

            stuCat = new StudioCategory()
            {
                StudioId = Guid.Parse("c7998d5b-0017-4924-8544-49b4a276afe1"),
                CategoryId = Guid.Parse("1125ebe4-4f81-4bb8-90ee-aceaf509c4f3")
            };
            data.Add(stuCat);

            stuCat = new StudioCategory()
            {
                StudioId = Guid.Parse("c7998d5b-0017-4924-8544-49b4a276afe1"),
                CategoryId = Guid.Parse("8859c909-f5cf-4f72-ba53-5a9e6dfac34d")
            };
            data.Add(stuCat);
            //N-Stage end

            //Wellness Centre start
            stuCat = new StudioCategory()
            {
                StudioId = Guid.Parse("df44a062-9586-4815-8126-99c240433b22"),
                CategoryId = Guid.Parse("f74035eb-e32d-4ddf-b381-8a757c7d5152")
            };
            data.Add(stuCat);

            stuCat = new StudioCategory()
            {
                StudioId = Guid.Parse("df44a062-9586-4815-8126-99c240433b22"),
                CategoryId = Guid.Parse("569a4a94-57b0-48d3-930c-0d3ca92f7eb8")
            };
            data.Add(stuCat);

            stuCat = new StudioCategory()
            {
                StudioId = Guid.Parse("df44a062-9586-4815-8126-99c240433b22"),
                CategoryId = Guid.Parse("42334109-d996-4339-b78c-4ba73fcdd824")
            };
            data.Add(stuCat);

            stuCat = new StudioCategory()
            {
                StudioId = Guid.Parse("df44a062-9586-4815-8126-99c240433b22"),
                CategoryId = Guid.Parse("6f3f3c4a-9213-48a9-a112-362e10188983")
            };
            data.Add(stuCat);
            //Wellness Centre end

            //Arsanta start
            stuCat = new StudioCategory()
            {
                StudioId = Guid.Parse("d8fbc428-62b8-42aa-b3d7-b40658072dca"),
                CategoryId = Guid.Parse("93474d31-0c93-4d01-9130-3b967b09a74a")
            };
            data.Add(stuCat);

            stuCat = new StudioCategory()
            {
                StudioId = Guid.Parse("d8fbc428-62b8-42aa-b3d7-b40658072dca"),
                CategoryId = Guid.Parse("f63198ba-741e-42ca-b112-f08c0e193bbb")
            };
            data.Add(stuCat);

            stuCat = new StudioCategory()
            {
                StudioId = Guid.Parse("d8fbc428-62b8-42aa-b3d7-b40658072dca"),
                CategoryId = Guid.Parse("b9b9950e-5ad6-4f44-87b0-e8811e9a59e2")
            };
            data.Add(stuCat);
            //Arsanta end

            return data;
        }
    }
}
