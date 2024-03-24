using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBeautyForum.Data.Migrations
{
    public partial class AddRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c735bad-12f5-412d-bdae-e71953e2c6e7", "AQAAAAEAACcQAAAAEIozq0a3iL+do/1yiAgU5WKErUtr/E01uuf5w7qnxq+CezwRMQKBPMLK9rOEEbeRJQ==", "ac778bca-87fb-4fed-85fb-8c0dca01e34f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38c6bb11-1ed0-4535-95b1-8de06cdab9db", "AQAAAAEAACcQAAAAEEeP0qojYtO5CkW+aiWYjRAnnBXmNBO6jSwyKFNOBQnimw7yNSbl5dfy9tDL7WcDHw==", "d5698a5d-1293-412d-a2de-3ec06da269ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bea7392-a556-4a99-86c2-8cb244868283"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3da6bcc4-46e5-4b02-a3ad-3a47d1df131b", "AQAAAAEAACcQAAAAEMLzYT7BG4BlD088D7Ckrgizq6sS9u1YW3z2QewWsX/EtJzkdo2hsnCBv0Cstbqj3w==", "bc964d88-0d7b-483b-8866-015d40c522ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6774a48a-7836-4ce6-9ef1-ea7be75b4ec5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5dbf049d-6320-48e0-b1c6-fbc675519da7", "AQAAAAEAACcQAAAAEOXPa+UO2wwUf1VYNOOKOatUWu+zyaeDKcB/5D5018wmWA2TwMHzsAaHJt8sqejXnQ==", "9ad04364-a80b-4583-a16e-770a355ca0a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c482d218-c8eb-43b9-82dc-7e8e223bd992", "AQAAAAEAACcQAAAAEGT/bCSg+YaDcNUniM/uF/qydJtZsoREYk+sbBn8eovtvTgS/PAhuygWUfxYYzsQwg==", "18a999ff-dc29-435c-9ff8-daf7269b874a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b313e2e1-0270-4a86-924b-71256500be8b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d65cd90e-6ef5-426d-bc42-b52303eacc11", "AQAAAAEAACcQAAAAELrelDFRjoN+pwNtWnTgBKfGcRN3it9BD/X6OJjOytU/6U7tDkB0ZeLhKl0BpFwBuQ==", "296ac737-d3ff-4716-aedd-0df8f7c056c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "485444be-51e3-40c2-a496-1d6f1b66ca94", "AQAAAAEAACcQAAAAEKcE/elNVLMOjSJ/kcrU6AIt2oeZ1BitXvBDWoGvY2B7tgDbY5c8EZuGMyLrwq3g2w==", "14d66a25-d5ca-48be-8241-25ad38834582" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: new Guid("6774a48a-7836-4ce6-9ef1-ea7be75b4ec5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "934b37d6-d50c-4baa-b8f8-0e7e47b50807", "AQAAAAEAACcQAAAAEFdyj4W8As3X2mlWkEfU6nspziBowkt2J0pbpflnHhx+0/5TmXCHrXkU+3vP3K4t6g==", "ae0b0036-0812-4a82-91b1-c7c40147728b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e56e5367-9e41-4ca5-971c-971fb75e2fc5", "AQAAAAEAACcQAAAAEBBseNW+pKovlM3ANjdJWGE5o6JAIj5uZ18csGHJvQCyruKD/JKEQrvhGAv0+WW+Ew==", "5e6e49b0-b1f5-4a0e-99bb-6c51f397f5d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b313e2e1-0270-4a86-924b-71256500be8b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7076d66d-584f-4032-8a88-84cd1bc0b220", "AQAAAAEAACcQAAAAEOcTVZFYOs1h1UnA5vGajmC49QgYbcQ/PxOJuPfCrv7dnSzDn3XKUH4pCVLVdoGc0A==", "77a51ee7-0491-4e69-8ac4-f7b3b3fe7dd5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34563d1c-fd73-4216-b3c5-592dd310ee65", "AQAAAAEAACcQAAAAEEuWTINSrANMKhzDdhjoi4GZGAqjfBEKFNGiCY9MeGfJ2sCBZ98Ob9YyGnnfjgRgKw==", "4118eaab-47f7-47b5-b7e8-e6457706e9dd" });
        }
    }
}
