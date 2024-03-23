using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Globalization;
using TheBeautyForum.Data.Models;

namespace TheBeautyForum.Data.Configurations
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.HasData(AppointmentsData());
        }

        private ICollection<Appointment> AppointmentsData()
        {
            var data = new HashSet<Appointment>();

            #region User1
            var app = new Appointment()
            {
                Id = Guid.Parse("0b561660-608b-4e07-80bc-96c168ff11ac"),
                UserId = Guid.Parse("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                StudioId = Guid.Parse("ad94f69c-b7e6-419b-bef0-fa50ab04f254"),
                CategoryId = Guid.Parse("3be6b016-9b6a-4f68-b7ee-bf32293acca9"),
                StartDate = DateTime.ParseExact("22-07-2024 12:00", "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("22-07-2024 13:00", "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture),
                Description = "I want a hairstyle for my birthday."
            };
            data.Add(app);

            app = new Appointment()
            {
                Id = Guid.Parse("1790311d-5712-44a9-abbd-3bfc47802419"),
                UserId = Guid.Parse("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                StudioId = Guid.Parse("bf2832b2-5b62-471b-9980-583753504ca6"),
                CategoryId = Guid.Parse("4ebb7e23-2a49-4451-8c96-b5c6de99900e"),
                StartDate = DateTime.ParseExact("22-07-2024 14:00", "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("22-07-2024 15:00", "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture),
                Description = "Monthly manicure appointment."
            };
            data.Add(app);
            #endregion

            #region User2
            app = new Appointment()
            {
                Id = Guid.Parse("f1a43f31-6d82-442b-8f89-941f7b6da3ec"),
                UserId = Guid.Parse("3bea7392-a556-4a99-86c2-8cb244868283"),
                StudioId = Guid.Parse("0d753e1d-c98b-47c7-b260-0377048c529a"),
                CategoryId = Guid.Parse("db7effe2-16bb-4539-9dec-0bda384b859f"),
                StartDate = DateTime.ParseExact("20-06-2024 12:00", "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("20-06-2024 13:00", "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture),
                Description = "I want slight balayage."
            };
            data.Add(app);

            app = new Appointment()
            {
                Id = Guid.Parse("79e4af3b-6bcf-4476-8705-2457836a1968"),
                UserId = Guid.Parse("3bea7392-a556-4a99-86c2-8cb244868283"),
                StudioId = Guid.Parse("df44a062-9586-4815-8126-99c240433b22"),
                CategoryId = Guid.Parse("569a4a94-57b0-48d3-930c-0d3ca92f7eb8"),
                StartDate = DateTime.ParseExact("04-06-2024 16:00", "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("04-06-2024 17:00", "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture),
                Description = "I need a relaxing massage."
            };
            data.Add(app);
            #endregion

            #region User3
            app = new Appointment()
            {
                Id = Guid.Parse("9b76ada8-1c16-4f05-b308-1c4ff3de137f"),
                UserId = Guid.Parse("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                StudioId = Guid.Parse("0d753e1d-c98b-47c7-b260-0377048c529a"),
                CategoryId = Guid.Parse("db7effe2-16bb-4539-9dec-0bda384b859f"),
                StartDate = DateTime.ParseExact("18-06-2024 12:00", "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("18-06-2024 13:00", "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture),
                Description = "I want platinum blond."
            };
            data.Add(app);

            app = new Appointment()
            {
                Id = Guid.Parse("8180ba4e-0941-4b06-abfa-e36a25ddb881"),
                UserId = Guid.Parse("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                StudioId = Guid.Parse("c7998d5b-0017-4924-8544-49b4a276afe1"),
                CategoryId = Guid.Parse("1125ebe4-4f81-4bb8-90ee-aceaf509c4f3"),
                StartDate = DateTime.ParseExact("20-06-2024 15:00", "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("20-06-2024 16:00", "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture),
                Description = "I need care for bleached hair."
            };
            data.Add(app);

            app = new Appointment()
            {
                Id = Guid.Parse("2220ba4e-0941-4b06-abfa-e36a25ddb881"),
                UserId = Guid.Parse("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                StudioId = Guid.Parse("c7998d5b-0017-4924-8544-49b4a276afe1"),
                CategoryId = Guid.Parse("1125ebe4-4f81-4bb8-90ee-aceaf509c4f3"),
                StartDate = DateTime.ParseExact("20-03-2024 15:00", "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact("20-03-2024 16:00", "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture),
                Description = "I need care for bleached hair."
            };
            data.Add(app);
            #endregion

            return data;
        }
    }
}
