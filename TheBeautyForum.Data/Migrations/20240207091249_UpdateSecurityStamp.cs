using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBeautyForum.Data.Migrations
{
    public partial class UpdateSecurityStamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3308d64c-c31a-4ffa-a727-ceb0b1fa90d4", "AQAAAAEAACcQAAAAEAmKOcMEiL+0oXYJFw7ADUSATjiHM1yohqzkNBVQXy0GhCU8MuaTIYHF3eEuM2NIcg==", "b5f3d0e3-7c2e-446f-8962-0c0858c8575c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66c3b92f-abbd-4fff-a539-02f1a65ff86f", "AQAAAAEAACcQAAAAEK4g8lHj4nV+0eOfoOY8oA5Tj68cgqcKcg9a1jgR+qiXi8oOe9rtuXisFZpS1BiJBw==", "faef0528-06af-4d15-89d2-5e4fb091b719" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bea7392-a556-4a99-86c2-8cb244868283"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf14f41a-7446-479e-b026-f32d4ecec5fc", "AQAAAAEAACcQAAAAENwBkLiYk/Igsd6LczGQqhXdkb/v/mGISnpsElV4q5NqIafturUA2+PUJv+lG4cuYw==", "27cfe125-4232-4b48-bf8f-70063f2642f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d14a92b2-abd8-4f91-9f51-dfe47d6e96ff", "AQAAAAEAACcQAAAAEEqg3Op+GGzahsCSkdWYuVhfx6QZQopaNdyd4OIB4bHYA1lms3XFqFr6IHHMuwEjoA==", "cbc0c242-049b-4a0e-9c1a-50323aaf43a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17548072-0938-4493-a7fd-02bcc55257d1", "AQAAAAEAACcQAAAAEPPeK+oueos3rYF68NMKIVhMTH0dfoHMiowtEwlyhy16H9U7xA9hee5TJiHrl/AEhA==", "ca7c8e19-8b16-403d-858b-0b85a4d896ca" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
