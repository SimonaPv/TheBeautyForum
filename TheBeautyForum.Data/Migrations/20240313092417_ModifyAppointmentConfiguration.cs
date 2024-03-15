using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBeautyForum.Data.Migrations
{
    public partial class ModifyAppointmentConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("0b571660-608b-4e07-80bc-96c168ff11ac"));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("0b561660-608b-4e07-80bc-96c168ff11ac"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("9b76ada8-1c16-4f05-b308-1c4ff3de137f"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 18, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("f1a43f31-6d82-442b-8f89-941f7b6da3ec"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 20, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 20, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf84bba6-3165-4d6f-8f75-a2fcda0ed709", "AQAAAAEAACcQAAAAEILo887ZCMq3QHh0iYmfq9SBNApuj9T0LHWqM0jK6pt6tNbWy+mBdBTb4/xDRI+iKw==", "faf8214a-b047-4eb4-a83d-7a82ca823555" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "651f3468-f46b-4d8e-bb66-24ce2ce3d23f", "AQAAAAEAACcQAAAAEBtplOQUNfTzBl9jLdAP7UXBvJ/POQ0xxZXdChsFqjbeDbicuhRnYT6yuMZNNFByPw==", "faf904f4-6f7e-4c37-a5d1-271310d6cb4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bea7392-a556-4a99-86c2-8cb244868283"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9109cf13-2b67-43af-85d3-f8f21b1593ab", "AQAAAAEAACcQAAAAEOOaTMQ94DWUhbHzIC8TF/qkny5UZCNvdcWQNANN84B5CAaN6pRd4lcW5y6Xo9d+Uw==", "dab5bf2d-e7fe-4655-8742-2fbc81b4381a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37d09313-0cb0-4923-b581-e54dbc235005", "AQAAAAEAACcQAAAAEItCleN2zrnK+DMVgHKm+F3PedWCOTUl3tBwku2ZP/frB9s9yN73yA4pePQqgjordQ==", "7154d1db-95c0-4f0e-bb85-e7b65823a1d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "558197fb-b8f0-490a-adb5-02d1bf312cf8", "AQAAAAEAACcQAAAAEKCijYy1xqC9OEuGvW3gCRkaAk0TUiImH8NboGXvO9aj0Sd8koj9IWt95HSNO2qc0A==", "64a4c1b4-315d-4734-84e2-cc0a8aea2a64" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("0b561660-608b-4e07-80bc-96c168ff11ac"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("9b76ada8-1c16-4f05-b308-1c4ff3de137f"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 18, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("f1a43f31-6d82-442b-8f89-941f7b6da3ec"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 20, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 20, 12, 30, 0, 0, DateTimeKind.Unspecified) });

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
    }
}
