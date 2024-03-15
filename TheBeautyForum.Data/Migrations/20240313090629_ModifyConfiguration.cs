using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBeautyForum.Data.Migrations
{
    public partial class ModifyConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "CategoryId", "Description", "EndDate", "StartDate", "StudioId", "UserId" },
                values: new object[] { new Guid("0b571660-608b-4e07-80bc-96c168ff11ac"), new Guid("3be6b016-9b6a-4f68-b7ee-bf32293acca9"), "I want a hairstyle for my birthday.", new DateTime(2024, 2, 22, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 12, 30, 0, 0, DateTimeKind.Unspecified), new Guid("ad94f69c-b7e6-419b-bef0-fa50ab04f254"), new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b7712bb-e6f7-44bc-8369-02ce6b25e89e", "AQAAAAEAACcQAAAAENH8PAG+7+8bis8oSUEmDZmrSkPAnzv9p/TUAptNYNIA4jTCNJ4MGIqe+sivfdzSXg==", "56712707-0577-44f5-aed4-5966b208c188" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ac66172-5e14-48fe-a52d-770ce8d6156b", "AQAAAAEAACcQAAAAEBB4gWaZDdABSYvPD8Ktr1Em9mmJcB8wCZ3kOe06JJTH9+EEy56wHpoUqq9XsO6gcQ==", "2718c425-a737-4925-84be-f6ca4e8a8b41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bea7392-a556-4a99-86c2-8cb244868283"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0812f101-f491-495d-b742-40fe1b77a876", "AQAAAAEAACcQAAAAEKkBnnIsjLIRFXlzbbmfkHPVucg3iDQX4SYtvY44KphvfdALDLZun5JDSglyaywHjg==", "0da9a55e-b142-415f-891a-54d84ed13265" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c8b62d3-65b5-4ba8-8167-15e344469cb5", "AQAAAAEAACcQAAAAEJ0L9Omisoc+JKyjMykRC+IudwH0BfjWQhN21DDxYGAnS+CFIaL54gKlvxZn/TZH1g==", "d610f661-2e38-4313-93a5-4db88a43dabd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c57ed7d-9ee0-4de2-aa4b-6d79a979e128", "AQAAAAEAACcQAAAAEIzdX1/FFJ59qsMfh1J/Txm0aoVASHA0y6HIMpulXrsq51dZazTi7oiC/f4/ENbWJA==", "e10ec6bc-28e5-48c8-8af1-0ecb3eeeb511" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("0b571660-608b-4e07-80bc-96c168ff11ac"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffc74668-3e2c-4698-9b9f-e49b760e6cbd", "AQAAAAEAACcQAAAAENN36eJLRff72dQE9GHBE16hxW4OrszhUWskOfV14BHj8iEXnJ5R7JG4k8gqDamJmw==", "4c7df510-3935-4f12-af14-1f652b412562" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45713c5c-1622-4c83-a922-5587b53e3409", "AQAAAAEAACcQAAAAEP+2WgujU1kIgGbKtNXhqTVp0i7UKxOuV+lVmjC/6KILC9hEyxwEarO70cxjqnVL1g==", "3552f358-9ad2-4d03-a175-13d66796b11b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bea7392-a556-4a99-86c2-8cb244868283"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3a7ff1b-4f40-4bc8-9b8a-292f30d99dc7", "AQAAAAEAACcQAAAAEFUXpE+4t6KQ1Rt6WrQIew28UbkdavfZC33H7f49VoIGj9H/LhOG+JwQ67mrLW2J6Q==", "6816829b-dea6-45c0-bc10-b55015700f24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99da7fee-1323-456b-81fe-c0de0dd83b74", "AQAAAAEAACcQAAAAEPh0FeynPzrT6Rb++KORRA+hRvW/fxKSoHPN3NixtTrGF62SuPxShq3xSxSVM3q3Ow==", "2fe8ddf0-b9b2-4ead-82a3-4e5d4a2a4885" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85afe34c-9642-48f9-a93b-8d3b8a77e0fb", "AQAAAAEAACcQAAAAEH59gb6pgcXeioHGsNlZIS6A7P83tDjvqyZdzVBYEdEYDGMmig8thtHEXOns8K5uzA==", "48a5e626-9162-45aa-9e61-7ec5f7f2e4a2" });
        }
    }
}
