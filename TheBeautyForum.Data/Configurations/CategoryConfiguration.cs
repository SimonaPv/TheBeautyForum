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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(CategoriesData());
        }

        private ICollection<Category> CategoriesData()
        {
            var data = new HashSet<Category>();

            var cat = new Category()
            {
                Id = Guid.Parse("8859c909-f5cf-4f72-ba53-5a9e6dfac34d"),
                Name = "Hairstyle"
            };
            data.Add(cat);

            cat = new Category()
            {
                Id = Guid.Parse("3be6b016-9b6a-4f68-b7ee-bf32293acca9"),
                Name = "Haircut"
            };
            data.Add(cat);

            cat = new Category()
            {
                Id = Guid.Parse("db7effe2-16bb-4539-9dec-0bda384b859f"),
                Name = "Hair coloring"
            };
            data.Add(cat);

            cat = new Category()
            {
                Id = Guid.Parse("1125ebe4-4f81-4bb8-90ee-aceaf509c4f3"),
                Name = "Haircare"
            };
            data.Add(cat);

            cat = new Category()
            {
                Id = Guid.Parse("4ebb7e23-2a49-4451-8c96-b5c6de99900e"),
                Name = "Manicure"
            };
            data.Add(cat);

            cat = new Category()
            {
                Id = Guid.Parse("2da87f9f-d52a-4d4b-a8c6-37200c4cfeea"),
                Name = "Pedicure"
            };
            data.Add(cat);

            cat = new Category()
            {
                Id = Guid.Parse("f74035eb-e32d-4ddf-b381-8a757c7d5152"),
                Name = "Full SPA"
            };
            data.Add(cat);

            cat = new Category()
            {
                Id = Guid.Parse("569a4a94-57b0-48d3-930c-0d3ca92f7eb8"),
                Name = "Full body massage"
            };
            data.Add(cat);

            cat = new Category()
            {
                Id = Guid.Parse("42334109-d996-4339-b78c-4ba73fcdd824"),
                Name = "Stone massage"
            };
            data.Add(cat);

            cat = new Category()
            {
                Id = Guid.Parse("6f3f3c4a-9213-48a9-a112-362e10188983"),
                Name = "Aromatherapy massage"
            };
            data.Add(cat);

            cat = new Category()
            {
                Id = Guid.Parse("93474d31-0c93-4d01-9130-3b967b09a74a"),
                Name = "Reiki"
            };
            data.Add(cat);

            cat = new Category()
            {
                Id = Guid.Parse("f63198ba-741e-42ca-b112-f08c0e193bbb"),
                Name = "Thai massage"
            };
            data.Add(cat);

            cat = new Category()
            {
                Id = Guid.Parse("b9b9950e-5ad6-4f44-87b0-e8811e9a59e2"),
                Name = "Bali massage"
            };
            data.Add(cat);

            cat = new Category()
            {
                Id = Guid.Parse("766f75cf-899f-491e-9c5a-6ff5949159a1"),
                Name = "Facial stone therapy"
            };
            data.Add(cat);

            cat = new Category()
            {
                Id = Guid.Parse("1c39f073-d448-4e8b-9079-369aab2d816b"),
                Name = "Facial therapy"
            };
            data.Add(cat);

            cat = new Category()
            {
                Id = Guid.Parse("57edeb42-3369-4c8c-b2d2-8c6c0ac49cfc"),
                Name = "Facial cleansing"
            };
            data.Add(cat);

            cat = new Category()
            {
                Id = Guid.Parse("d079d974-8e76-4b0c-8c41-291ecd9042b1"),
                Name = "Anti-age therapy"
            };
            data.Add(cat);

            cat = new Category()
            {
                Id = Guid.Parse("d5cbb5ce-65e7-4a6a-a03c-fd13fcf304de"),
                Name = "Microneedling"
            };
            data.Add(cat);

            cat = new Category()
            {
                Id = Guid.Parse("acc8a306-8a0b-4ede-8a03-f1ab6e90eed4"),
                Name = "Microblading"
            };
            data.Add(cat);

            return data;
        }
    }
}
