using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBeautyForum.Data.Migrations
{
    public partial class ModifyDatabase4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserRole",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1674d538-3cf0-4a6e-bc27-aa070a230647"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserRole" },
                values: new object[] { "9dbd1d41-581a-4bd0-837b-0d934e5e05db", "AQAAAAEAACcQAAAAELrT7UuVI3YNcePiY9XxCWdRhMNI+ULg320lckyfeJ0WeECjr/LcCVvG8QMZqaGxnw==", "cffa8728-a37c-4267-8fe7-239489c6adb8", "Studio creator" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserRole" },
                values: new object[] { "36c1aac9-64c6-409e-ad87-30559737ecf5", "AQAAAAEAACcQAAAAEKqgtnkQFUSdPxMMYnK3MpyuLSixlUjl6+7eewSQMwYoZxjPg3HbBtcN5pxpIOghLw==", "d7d13c5f-6f82-4a8d-973a-359c3ca3f3db", "User" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserRole" },
                values: new object[] { "e43ac627-f74b-4cae-82fe-fcd3ae9892ba", "AQAAAAEAACcQAAAAEMzUfy4mExF52zGHvsQ/RanbAwByT6BkA794faaCCJt+MaJC1vwk8NDqHDNW01RrtA==", "65575999-8738-4d05-8d16-fc47e03077e1", "User" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bea7392-a556-4a99-86c2-8cb244868283"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserRole" },
                values: new object[] { "84e935c5-baf4-4069-a943-f55c0cc5626d", "AQAAAAEAACcQAAAAEAQB08HsCNCtn0+qXr8JIfiIg+L6LdN7liNzLOcxN2fu1bGbGIDNgFxeoGb/o4EFIw==", "db30c391-80b1-4034-9fb7-f3f845638ea9", "User" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6774a48a-7836-4ce6-9ef1-ea7be75b4ec5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserRole" },
                values: new object[] { "55a46873-7bc5-4d20-8789-f419ab751be3", "AQAAAAEAACcQAAAAEFihLAuvJhAL7CfaExO2KyuvWJPIS4X8Bqz6Kr+SHsH2ultu73X7eObmD43HtXJUAg==", "a28b2c3d-a606-4121-b20f-bd8bf5cce6ce", "Administrator" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserRole" },
                values: new object[] { "c4fe0304-53fe-4eaa-9683-fcf9a9d5bc23", "AQAAAAEAACcQAAAAEMET5bLLO8nXmPaO3x01XnyezHMJb4SYEtVagRQfcn19qMZSmi/9D2lhR3PilEPIgw==", "aab74b24-851c-4a56-a43f-872d2238a3cb", "User" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b313e2e1-0270-4a86-924b-71256500be8b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserRole" },
                values: new object[] { "adb0c6a7-e6ee-4cbe-871c-22ae8f7e28c6", "AQAAAAEAACcQAAAAEBzyfV23XVXrg4nuoHnhgH7Uo4BSsNaAEQND9aZYXxqQWa7ES6bIzsI5oAUy955qYw==", "68fabf3f-10d3-4b11-b773-22278241780d", "Studio creator" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserRole" },
                values: new object[] { "cf32f72a-06d3-441d-abc8-13de649cb9e8", "AQAAAAEAACcQAAAAEPEHThhyXQ3i2DmdjPOPFVIVmKhRtZ3Sf5JbUlFS+3oT6QT3jSNI+ElN4jXiQR2Q2w==", "e39550f7-623a-4387-b8ff-609851df9612", "User" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserRole",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1674d538-3cf0-4a6e-bc27-aa070a230647"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c4f59c9-1c0d-44a3-b6bc-4bff26ed3c4f", "AQAAAAEAACcQAAAAEKoBeiGHVrcXiTA3QZaVi0Gc8dMzWxP4xIBbiBQlVgyOAR+0L0pH5ao8APepfYV0dw==", "de5eca45-aeba-4488-a488-37e84752c7fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2ff1907-6aa0-4fc4-89d8-f4d8ac7b7eee", "AQAAAAEAACcQAAAAEKYu/s+xFIr5IyIVdk5fVW0usLftJcrcjiasiVFkYtey50aGYiAQSgSFHx+fLrOCwA==", "91313f60-a007-493a-87f4-55a5347c6be4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9117589b-e3a7-475e-85b7-6adf5697388c", "AQAAAAEAACcQAAAAEGgf1uCRlI6htc3WPkYxT0JhoKU1ICuoirrC3MOp8vcMEuDs9Up0upNt/BRDWeR5Cw==", "bff7f3d3-365f-44a7-b8ce-bc2d4aefd011" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bea7392-a556-4a99-86c2-8cb244868283"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7f4898f-849d-44da-a35b-1690ac879443", "AQAAAAEAACcQAAAAEPt94NjOGEitPgdqU+Vi5of7ybh7XvKf+gkW+MMCIW+ZvcpkLyDTz77q38rgJQ+fhQ==", "50b4e9b2-bb39-4901-8bc4-70f31d1eed15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6774a48a-7836-4ce6-9ef1-ea7be75b4ec5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "445b77d9-c840-4abe-bd1a-172a50579a1a", "AQAAAAEAACcQAAAAECzwvJdSqGxuLTuAaVK6OKsH/MwWlUlvWm0NJ1wMLlblrMJCT0S+Sj6CMHfjx4cw0A==", "c7822040-f407-4e91-9e8f-c95a27ea31e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "820c9505-8bc4-4b8d-8d08-fe0768c191df", "AQAAAAEAACcQAAAAEHZyiGjiTKaqF4S61jIIb21dNGF1QMdTQt5bNSroRvy1uj2/cGoWFfhdQL6VrrXt1g==", "ea56f451-a0c7-4c1a-abc8-93864969e2cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b313e2e1-0270-4a86-924b-71256500be8b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a0cfc35-bdeb-4384-b9fb-a61b6c7fb094", "AQAAAAEAACcQAAAAEPEBuiJjRmuTWHe2wTkNO4634O8A256czZLuyG6l7sgS5Fn8IOvXXeDqyFVjQN6jZw==", "e5a51a69-e9b9-40e4-be3e-f9e9f44e74fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39aeff71-9c08-4a66-8919-2181be8e91b1", "AQAAAAEAACcQAAAAEA/QbehqS/fvIgKNgyTL92LUcjRZaUJ3ccOTvpFRRVw/YFboKGht7Rbho7WwUYQJKg==", "f6dfd6a0-3868-4263-a5ac-f65fa098dde3" });
        }
    }
}
