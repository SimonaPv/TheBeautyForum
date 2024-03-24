using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBeautyForum.Data.Migrations
{
    public partial class AddRolesToDb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("56bdecaf-285f-4a8e-b650-8bc997be759d"), "a778cea8-08b3-42c0-9e21-340e9a082042", "Administrator", "ADMINISTRATOR" },
                    { new Guid("5a322cf5-7101-4d4a-9e08-16382fc0a641"), "e8393d91-9ede-44d6-bdfb-7fecba284cbf", "User", "USER" },
                    { new Guid("71d6d7d8-f4f6-42b5-a9a9-ed2d3ef0bc73"), "16a14879-253d-46d4-b1d2-ab4c2f8dd55c", "StudioCreator", "STUDIOCREATOR" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e98abc6a-c194-4674-943d-831566940e92", "AQAAAAEAACcQAAAAEI6AdODYzrnZoIlku3xaJ968JNt7LwlJ9ubkJq4YYT+Gfq0tdQdNo8rEiBRwY7u4Lw==", "74f76300-a978-4ccb-b1af-1d6092ba6f8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1e32b3a-05d4-4426-b900-f23870a18a30", "AQAAAAEAACcQAAAAEGOKtP4JwSTdqzuMuzGTsBmXUQRrGNFoPLaxL4qNOSOEEMzXgXIIcRZJYuRzJwhQMQ==", "af7cbb39-d376-482e-b2ae-d4089a10091c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bea7392-a556-4a99-86c2-8cb244868283"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "636e4339-4e9e-4295-a6e3-08471bd30589", "AQAAAAEAACcQAAAAEL0VCYU2fixD+L2U8i80z2UeiBkJEiXn21jBKXe6XLSJtO4wzMx6F248XXn153VvdA==", "4e876ac8-998e-4cc8-95cc-e22c152b45c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6774a48a-7836-4ce6-9ef1-ea7be75b4ec5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4de921a-b5e4-4aa7-ba32-ff7a9bca23b8", "AQAAAAEAACcQAAAAEMiA8fbl8cIA0vccMk4pBhzIhTpvvDd38IbRls4ev2wD8O3p/K4gt5JKVloRcrLl5Q==", "5c91a8dc-5c92-4180-a93c-c561b977e10b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9445b58-0804-44a3-a19d-920a31b6a603", "AQAAAAEAACcQAAAAELqDqP5OIbLN6kk66nsGHLgWqwG/FjDQHAnLVF5niG+DttR41hGbyEKpK9SdcfZQbQ==", "d011927e-c660-4e22-b8a8-b6dea9c4fa89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b313e2e1-0270-4a86-924b-71256500be8b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdae669b-1c08-4929-8825-cd591c8f244e", "AQAAAAEAACcQAAAAECYFCKzOePPWZ2lgsrfpoS08iB2plUrYzJ2cFet0QLYvMEZ86TSjJPN3gt10W0oDpw==", "d259a60e-ced5-4a2b-bd83-1193e11fb022" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e970082-5715-4437-b31f-c8133a8d7b82", "AQAAAAEAACcQAAAAEGJv1E37v57CcTvHOEDue3+mT5Pt3rj/P9A0bRBvqLM58+wldwQ9Nggtxp7crxFBcA==", "705a25ef-ee19-4231-bbbd-02b6e59c3fe4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("5a322cf5-7101-4d4a-9e08-16382fc0a641"), new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b") },
                    { new Guid("5a322cf5-7101-4d4a-9e08-16382fc0a641"), new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d") },
                    { new Guid("5a322cf5-7101-4d4a-9e08-16382fc0a641"), new Guid("3bea7392-a556-4a99-86c2-8cb244868283") },
                    { new Guid("56bdecaf-285f-4a8e-b650-8bc997be759d"), new Guid("6774a48a-7836-4ce6-9ef1-ea7be75b4ec5") },
                    { new Guid("5a322cf5-7101-4d4a-9e08-16382fc0a641"), new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f") },
                    { new Guid("71d6d7d8-f4f6-42b5-a9a9-ed2d3ef0bc73"), new Guid("b313e2e1-0270-4a86-924b-71256500be8b") },
                    { new Guid("5a322cf5-7101-4d4a-9e08-16382fc0a641"), new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5a322cf5-7101-4d4a-9e08-16382fc0a641"), new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5a322cf5-7101-4d4a-9e08-16382fc0a641"), new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5a322cf5-7101-4d4a-9e08-16382fc0a641"), new Guid("3bea7392-a556-4a99-86c2-8cb244868283") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("56bdecaf-285f-4a8e-b650-8bc997be759d"), new Guid("6774a48a-7836-4ce6-9ef1-ea7be75b4ec5") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5a322cf5-7101-4d4a-9e08-16382fc0a641"), new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("71d6d7d8-f4f6-42b5-a9a9-ed2d3ef0bc73"), new Guid("b313e2e1-0270-4a86-924b-71256500be8b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5a322cf5-7101-4d4a-9e08-16382fc0a641"), new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("56bdecaf-285f-4a8e-b650-8bc997be759d"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5a322cf5-7101-4d4a-9e08-16382fc0a641"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("71d6d7d8-f4f6-42b5-a9a9-ed2d3ef0bc73"));

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
    }
}
