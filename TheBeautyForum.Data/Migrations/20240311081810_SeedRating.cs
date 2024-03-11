using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBeautyForum.Data.Migrations
{
    public partial class SeedRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85b9dfde-fad3-4b56-9231-650a0c61d7f0", "AQAAAAEAACcQAAAAENFibELyxEteoQ2u/nADutllEMH73iNgs1sq4CZVYBru3CXyovA6Et5VS2Wtq3qxUQ==", "0f3eaca5-2441-4962-b517-80059876a7de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51b02f0f-43c1-4467-ad1d-f2b6ce50f5e8", "AQAAAAEAACcQAAAAEPekiM7CGCIZayI8Hbh5TG1AlKIuE45kj0H+H2BZAMKwfWiu569UZK3zh7sDiTec2Q==", "4ae3b5c5-a3c3-4cb4-bee6-961a6a3364cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bea7392-a556-4a99-86c2-8cb244868283"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25fb149f-7f7f-47e4-aff6-0ba23c25c935", "AQAAAAEAACcQAAAAEGs50si4A9MRTxghvRXufYobohk6GqBFmWH2uUXpzswg3exvub4xjJLbmKAqkSqeBQ==", "d0b3709d-0466-4174-9a52-a17ce4a5b63c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f05f1577-cc9e-4ad6-bd5e-0d587fd8ab31", "AQAAAAEAACcQAAAAEN6Fp2IeTEEWKJ/KCFWsu3kdpovjdLwMMPkEavKiHoIPEJHdjzhDLCu6okfqdpdAcw==", "f3b4fdde-a754-4d81-b9e3-4b92b3a356cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eed7898c-04b7-49f6-953b-cbd5b8e0dcb8", "AQAAAAEAACcQAAAAEBMIQi8Ki2XsEtHUSXKm0eODOZTfkO/+inloJRPhlDaC1QeB4YEbTXRr7NH8QhHuDw==", "5ccf1589-429f-4d36-b7d7-c1b5f9cf4764" });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "StudioId", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("168884a2-fc77-4169-836f-dc0a0599bc2e"), new Guid("d8fbc428-62b8-42aa-b3d7-b40658072dca"), new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"), 5 },
                    { new Guid("60502c16-c9bd-4653-94a6-fe623822a42e"), new Guid("0d753e1d-c98b-47c7-b260-0377048c529a"), new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"), 4 },
                    { new Guid("912d1986-7424-43fa-a531-b9d811961386"), new Guid("d8fbc428-62b8-42aa-b3d7-b40658072dca"), new Guid("3bea7392-a556-4a99-86c2-8cb244868283"), 4 },
                    { new Guid("960c4945-0b04-4c40-bd17-c697cb8d5eda"), new Guid("d8fbc428-62b8-42aa-b3d7-b40658072dca"), new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"), 5 },
                    { new Guid("bb10aa9c-da74-4846-a075-7b203f22aefc"), new Guid("0d753e1d-c98b-47c7-b260-0377048c529a"), new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"), 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("168884a2-fc77-4169-836f-dc0a0599bc2e"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("60502c16-c9bd-4653-94a6-fe623822a42e"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("912d1986-7424-43fa-a531-b9d811961386"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("960c4945-0b04-4c40-bd17-c697cb8d5eda"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("bb10aa9c-da74-4846-a075-7b203f22aefc"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9371c7cf-3047-4e2b-b4b8-95c30a339f07", "AQAAAAEAACcQAAAAEJwaMmqomH5MKMvlFmQSyLLSPbEY1vpfWRbm2v2Qd0IVtnd/hc8okgsAt63lOl14Ww==", "6c78eacc-c936-43f0-ad0d-c20db63e0b8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbeb7687-b412-47c3-8cf2-7cdde3fec0b2", "AQAAAAEAACcQAAAAEBrPR1CMiya5cU2yKnl5CfrnUUWPdRieI07oIddwpJ84cQegCB1HrcAoeZ/aVU+Zag==", "55764138-8262-44eb-8064-8e8eabba1de1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bea7392-a556-4a99-86c2-8cb244868283"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "864ee9b5-8252-4b3f-a53d-e2598513b1e3", "AQAAAAEAACcQAAAAELc/hqZln3J4KEyp/kGEZ1IndcceM9M3irj8Vq8O1gS9BrDuiyaeSvaQTYKJc/VrYw==", "af533b36-b4d9-428c-884d-6e296c8910b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e0c0ff8-34d3-4334-8b09-e7f6d110a2d8", "AQAAAAEAACcQAAAAEKnfcR+9V+8H88fzbGBA+BjU1Tl8+Pa2V0sc9UQjMSzcSPq6uAesBjb/X+FiR+zXpQ==", "be749d30-ed7d-44c4-90b0-08f0454e3bf7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db2f8d78-39e5-45b8-994d-b809c04124c5", "AQAAAAEAACcQAAAAEJxk7ksDqNov/QSbqM5R+bRXtPGMdT2lSITCt52rvWH3BGsW5CPy08R6ibYlm15A6Q==", "f0be51c0-eaaf-4257-8dc3-4a3c6a6044a9" });
        }
    }
}
