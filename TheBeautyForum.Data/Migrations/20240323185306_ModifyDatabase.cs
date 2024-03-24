using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBeautyForum.Data.Migrations
{
    public partial class ModifyDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudioCategories_Categories_CategoryId",
                table: "StudioCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_StudioCategories_Studios_StudioId",
                table: "StudioCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudioCategories",
                table: "StudioCategories");

            migrationBuilder.RenameTable(
                name: "StudioCategories",
                newName: "StudiosCategories");

            migrationBuilder.RenameIndex(
                name: "IX_StudioCategories_CategoryId",
                table: "StudiosCategories",
                newName: "IX_StudiosCategories_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudiosCategories",
                table: "StudiosCategories",
                columns: new[] { "StudioId", "CategoryId" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b78dcb1-7128-47e2-8500-5fca5e8157f5", "AQAAAAEAACcQAAAAECje98RsEzf/jV2GcJR7BhCzht92B6BoE9DWUDBqoUqrZ+crfnUO4SoWuC6g1gccTA==", "28528be4-76dc-4e8b-adff-cb0de7adbbe2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f96fb610-728f-4c08-8498-8f6906be6b98", "AQAAAAEAACcQAAAAEOFLlfMAOxo71M7+uTdtsoFgGfuNbrKPMj4YWkdy3tMCY3CrNJv0FHCNu+wSpE4x5g==", "53a443ae-a446-4436-9f05-0c1cf38f86e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bea7392-a556-4a99-86c2-8cb244868283"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0cb66db3-c9dc-4e9f-ac45-592555412a57", "AQAAAAEAACcQAAAAEJDW0sYcQETzAr82eZsHHEAQ2+DunNdLej69+WWKYIB9DZCcVR3dRQMTGNBl58p8/g==", "c8d2352c-60a3-4f4d-b1cb-9df4a3f1b9fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e56e5367-9e41-4ca5-971c-971fb75e2fc5", "AQAAAAEAACcQAAAAEBBseNW+pKovlM3ANjdJWGE5o6JAIj5uZ18csGHJvQCyruKD/JKEQrvhGAv0+WW+Ew==", "5e6e49b0-b1f5-4a0e-99bb-6c51f397f5d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34563d1c-fd73-4216-b3c5-592dd310ee65", "AQAAAAEAACcQAAAAEEuWTINSrANMKhzDdhjoi4GZGAqjfBEKFNGiCY9MeGfJ2sCBZ98Ob9YyGnnfjgRgKw==", "4118eaab-47f7-47b5-b7e8-e6457706e9dd" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("6774a48a-7836-4ce6-9ef1-ea7be75b4ec5"), 0, "934b37d6-d50c-4baa-b8f8-0e7e47b50807", "simonapalieva@mail.com", false, "Simona", "Palieva", false, null, "SIMONAPALIEVA@MAIL.COM", "SIMONA", "AQAAAAEAACcQAAAAEFdyj4W8As3X2mlWkEfU6nspziBowkt2J0pbpflnHhx+0/5TmXCHrXkU+3vP3K4t6g==", "0884912724", false, "https://res.cloudinary.com/di1lcwb4r/image/upload/v1711218695/fngujmuenduudydw6g0m.png", "ae0b0036-0812-4a82-91b1-c7c40147728b", false, "Simona" },
                    { new Guid("b313e2e1-0270-4a86-924b-71256500be8b"), 0, "7076d66d-584f-4032-8a88-84cd1bc0b220", "mirelametodieva@mail.com", false, "Mirela", "Metodieva", false, null, "MIRELAMETODIEVA@MAIL.COM", "MIRELA", "AQAAAAEAACcQAAAAEOcTVZFYOs1h1UnA5vGajmC49QgYbcQ/PxOJuPfCrv7dnSzDn3XKUH4pCVLVdoGc0A==", "0886666666", false, "https://res.cloudinary.com/di1lcwb4r/image/upload/v1711219006/pqqa3hau5sceuvlbbvwk.jpg", "77a51ee7-0491-4e69-8ac4-f7b3b3fe7dd5", false, "Mirela" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_StudiosCategories_Categories_CategoryId",
                table: "StudiosCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudiosCategories_Studios_StudioId",
                table: "StudiosCategories",
                column: "StudioId",
                principalTable: "Studios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudiosCategories_Categories_CategoryId",
                table: "StudiosCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_StudiosCategories_Studios_StudioId",
                table: "StudiosCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudiosCategories",
                table: "StudiosCategories");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6774a48a-7836-4ce6-9ef1-ea7be75b4ec5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b313e2e1-0270-4a86-924b-71256500be8b"));

            migrationBuilder.RenameTable(
                name: "StudiosCategories",
                newName: "StudioCategories");

            migrationBuilder.RenameIndex(
                name: "IX_StudiosCategories_CategoryId",
                table: "StudioCategories",
                newName: "IX_StudioCategories_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudioCategories",
                table: "StudioCategories",
                columns: new[] { "StudioId", "CategoryId" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76af14a2-5b2e-4ffe-a875-8bac472feb56", "AQAAAAEAACcQAAAAEJKEkecHqAGBwMK822AG4xmCl95Cl14VAKFDwESYZDOorv8G0SYiWUSfr5S5EJA9LQ==", "27069507-9590-41c5-949d-8ba275497db2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4c00325-226d-46dc-8938-04c2a45a723b", "AQAAAAEAACcQAAAAEMbY0zEfkTLMr4GLTBLtatS32+NyclTej236dmYF6ODHsGsddei4fxaFLzrGkVTYCw==", "d300f37d-51fd-4a56-84f1-3f597e76c014" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bea7392-a556-4a99-86c2-8cb244868283"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54de783a-5b0b-4923-b5f3-7ce5a6773ef7", "AQAAAAEAACcQAAAAEOXhl3EL3OWtlzWfLcW1bdGzYS0gaqSmIqcDIWpZ9gJUWcO4C0vN1MGMOYFXDlUe0A==", "91987b88-bc77-4964-846c-b95298d25baa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7e8b963-d66e-4082-86fb-a1b74f5385be", "AQAAAAEAACcQAAAAECNuNk7DUQlUMuA2GyETstepg9J2Vtqb+L8GbC/UNRSqOCAt29gTjEtWJYWke3DwGg==", "c1277dbf-5f98-4843-afd5-ad961212e45c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19b7df60-5b25-4ee7-8929-0672f4e1f592", "AQAAAAEAACcQAAAAEKdU1Sf1LoTQeOUkU5a22VKstRwVpQFBsF4+BklU/UhgDCLIFafICiy3HW19SjRzLg==", "190e5f58-8218-4ef6-bc56-fb46408eceff" });

            migrationBuilder.AddForeignKey(
                name: "FK_StudioCategories_Categories_CategoryId",
                table: "StudioCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudioCategories_Studios_StudioId",
                table: "StudioCategories",
                column: "StudioId",
                principalTable: "Studios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
