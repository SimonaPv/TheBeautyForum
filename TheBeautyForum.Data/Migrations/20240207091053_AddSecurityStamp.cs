using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBeautyForum.Data.Migrations
{
    public partial class AddSecurityStamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fcbed755-35f0-48bd-8868-8204d37e9d12", "AQAAAAEAACcQAAAAECnpfJyahk63BmAhmmP2LHo40DIviN/E422M/ILVDhdCPgzFYhSvdDppzMbk9QvVgQ==", "37a0df65-712e-4600-974d-cbbb9e8c03a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c6b8f7a-185a-4b7b-a571-6afdf7161bb3", "AQAAAAEAACcQAAAAEC3I4zxstsOnfd9HhCShTYfueVF6NG8NkBXlPQ2U2Gns7+/kmRq7MkDkfkBTkRVEWw==", "e559c445-384b-4d37-9788-289407e6aa8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bea7392-a556-4a99-86c2-8cb244868283"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "624f1745-96e7-4496-a77d-6cf3035c7c33", "AQAAAAEAACcQAAAAEPOcF7p6Du7BXT+WF6ZkaxnmkoU2mWjnmKmHK69Wt7Fqv0wJWT8qA7Ef67ZhGaHjvw==", "dc38980c-1984-4fa9-a24f-2c0c427c1a0a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c66c0bbf-181e-4822-9f44-2f6df21c4e9e", "AQAAAAEAACcQAAAAEJRPyztpWyrJgLi+LuQfyi0oq5PYxbAap7fr0GRoDWKDfQasUjsNHpz8jxorsFHT8g==", "1ae3a7de-d092-4cff-8d55-9e815b09e63a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34281c2a-2b3a-458c-a7df-c56a07d0fa0d", "AQAAAAEAACcQAAAAEN+sTW0g4d7gajQB9qUd+SYB+Z08EBfrUV3lLtQ09LOhDp9rUDK7F1sZ8p1a1NpT7w==", "cd723ce1-a0bb-4a6f-a4ab-696d9f509e9f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff076685-c2dc-4444-a2d9-6617a49875ed", "AQAAAAEAACcQAAAAEKL5v6JXo7agnpGmXF1QkDeYV9zKYIzLo1NqTbMmQhqs8XV5GeZpOPh3s056sNepDQ==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03441a2d-062e-4794-bd6e-606ad44a25b7", "AQAAAAEAACcQAAAAEOkXvRHEG3qzJ3j+S+O8UNBnlmHSp7Lo/ho6E8Xbq5UrRQ2AKIdex0sK6udPSZRoog==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bea7392-a556-4a99-86c2-8cb244868283"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d65fea67-c68a-4b47-9aca-b1d172c9a326", "AQAAAAEAACcQAAAAEI3ijqk191W+i1/2LjM3IWRZRzeqGGsF+2nPNonY/rofg3Mp8450kMp5GmVafuZQVA==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ebd773b-34e7-426c-a5b7-6a2852799a94", "AQAAAAEAACcQAAAAEG/uD8x7vbyS9RcE98+unsKxeU3Lm6FaoM9foVNbbdR5FAhKel2P1cHuPPY/pXx6yQ==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6bc8946-7588-4a59-b6a2-09b26e4a4801", "AQAAAAEAACcQAAAAELQChvjiGQLvVDA6fjurEfdUw8fxGZ1OrAl7iD44CO8sDq+pJZqFNcqKo1b8EXPoDw==", null });
        }
    }
}
