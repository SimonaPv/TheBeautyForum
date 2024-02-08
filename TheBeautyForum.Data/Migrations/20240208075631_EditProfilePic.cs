using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBeautyForum.Data.Migrations
{
    public partial class EditProfilePic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1326c8e-f2ac-4183-8148-ee84bd369b3c", "AQAAAAEAACcQAAAAEP8mtUGpbPy4S5pAf3SWgDICt5xEDsIsZXZK9kSevehMxtXRNCpdeKRMZXBMRyYP+w==", "f24dbbc1-0101-47a1-bde9-38cb727a9ad7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfilePictureUrl", "SecurityStamp" },
                values: new object[] { "50e55b60-19f0-4a62-952a-76f8a94e7838", "AQAAAAEAACcQAAAAEBu8k8hQ4/MlmekKOqUEIHhaY5Ks5TPOIRU0BdylibvOSsWQVBFI2ge177hnoo+ZrA==", "https://res.cloudinary.com/di1lcwb4r/image/upload/v1707378004/kgdkin0zow7lkpkc4hdy.jpg", "ed159a17-bb5d-4593-b34f-1f747f887148" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bea7392-a556-4a99-86c2-8cb244868283"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c6e3cc7-6a68-402b-b52d-cc88f5dddbeb", "AQAAAAEAACcQAAAAEJO9sBfgmbEXGXvhyEh3WRMovimt1u8/t0xliCKtT4gHuV1KGkodnSeGg5IRG3COzQ==", "257bd8c9-b3c5-4d25-8c17-b6b8a8753c80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9a3ebc4-edbe-4f11-94c1-38df7ee2d929", "AQAAAAEAACcQAAAAEEBW809owFB0MosR78RYA/UGvypHsZGx6s1f317kkXvXZTITB1TnbHSCv4RNm4BM3Q==", "c8210314-e3e8-40f8-88ea-0f26db0d5db6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfilePictureUrl", "SecurityStamp" },
                values: new object[] { "dd6137e9-685c-4b13-bd97-be7c636b76d1", "AQAAAAEAACcQAAAAELgpoGo77d6dPaeTSIxfFlPM3cpAvAAuM1PK8hG+yaXdm+Tav+1VJLQ99VUn8SM9mg==", "https://res.cloudinary.com/di1lcwb4r/image/upload/v1707378748/einenpgospeodkzbw8a7.jpg", "dcb91e8b-6a5a-46a4-b4f1-e0386daf28a2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a655532d-6563-4fbf-a795-d26d0f5081b0", "AQAAAAEAACcQAAAAEOhqZGbYBbMXLMQATq4wkfkGcwRPxdvYAoeUwmn0NvCZM8I8fg5XJ1bqrCb/xBHArA==", "27d25d25-3c68-49b1-b7e7-c5788b40a492" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfilePictureUrl", "SecurityStamp" },
                values: new object[] { "debae5f3-2900-464b-9dcb-d0048dc1b7a7", "AQAAAAEAACcQAAAAEOizfPsU1c2QCsC0/8VfHL9V9//TV7eS61SFdeFCDW/QzKYg5HUco/DAsQvD/p5cXw==", "https://res.cloudinary.com/di1lcwb4r/image/upload/v1707378748/einenpgospeodkzbw8a7.jpg", "b12c3cf7-62d9-46e0-81da-497980d9cf5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bea7392-a556-4a99-86c2-8cb244868283"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91d658db-839b-4ec8-9330-6890cccce472", "AQAAAAEAACcQAAAAEDT7v8nL2KkVYk6s5OaanQhPI6JnsQ9XKyrVdhD2U1WF4lS2XoTB763OPUZJHY04rQ==", "e8ceaf6a-d628-4731-a1f7-806be7c2ca0f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4abaa570-fc96-45d0-8905-c3fea0f01aff", "AQAAAAEAACcQAAAAED8nEFkTu+A/p1Sxmwz50yHTq71+TQFhkYMte2TDxuKJ+O+gIDWCkJbVLRzs+GHozg==", "0ded07d0-4f09-4060-a50d-2a3ed4bfafeb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfilePictureUrl", "SecurityStamp" },
                values: new object[] { "bd199325-83f9-45e3-ac44-d0bac487a975", "AQAAAAEAACcQAAAAELmN9UsfpxNKd4bOcirexF2QXd4LWvMx37SvgRES2ge37IgRk6iW2xFxpGaB9NmRsA==", "https://res.cloudinary.com/di1lcwb4r/image/upload/v1707378004/kgdkin0zow7lkpkc4hdy.jpg", "022b8f97-924a-4222-94d3-5057571761fd" });
        }
    }
}
