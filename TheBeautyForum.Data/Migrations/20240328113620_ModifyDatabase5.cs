using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBeautyForum.Data.Migrations
{
    public partial class ModifyDatabase5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1674d538-3cf0-4a6e-bc27-aa070a230647"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9598efac-d155-4099-ab2e-bdad272645a9", "MONAILIEVA@MAIL.COM", "AQAAAAEAACcQAAAAEFn6YB38/VnT0Qx8wWKWymgK7jr5mjfEYbn94S0tigfCebERdK3fVswemsToHqHUXQ==", "52156b9e-4055-4992-9fe0-470d84a758c2", "monailieva@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "790831bf-e992-4f34-ad44-bcee9cc9b350", "LISABORISOVA@MAIL.COM", "AQAAAAEAACcQAAAAECVpC3AMCgwmog7h/Z2iZFD/QfdbwNPDKuA/+3ePIHKLFCuBfBkXlZze7n5+dMMAGQ==", "24088c78-2f96-4926-96a8-bf5194cbff12", "lisaborisova@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7e72c156-bbfd-4eb1-b7e8-5685ed07c27e", "AYLINTODOROVA@MAIL.COM", "AQAAAAEAACcQAAAAEJ37TFnhFEFLyQc7xtCZOLSRx66VwJeOd/ZCdX9vw9tDhBsl0nKnWEXHbKr/rOPMDA==", "d82c8b2b-2a89-4298-b81d-aec59d50e7a1", "aylintodorova@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bea7392-a556-4a99-86c2-8cb244868283"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "99e513d7-73d7-4d3a-a48a-b883a8091360", "AMAYAIVANOVA@MAIL.COM", "AQAAAAEAACcQAAAAENZNBgDnLJBGs3NFKjEpHdHQzLstPs6vD9tLkD0xPBiLh1Qc8lMpgZfzvrWt1im5ZQ==", "32fac06b-1d25-4148-ac20-1a65396536f5", "amayaivanova@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6774a48a-7836-4ce6-9ef1-ea7be75b4ec5"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "79d5a2b3-16c5-4667-bcfb-2e724aa4307f", "SIMONAPALIEVA@MAIL.COM", "AQAAAAEAACcQAAAAEMtnkbvIPaJO51rJvo95JQHouYRCoxKwatB0CXJHC5nDB6rZ2Ak8aQhfduiogbk+/A==", "e3b1aa44-a0c5-4874-bfb0-e0b2458b3cd2", "simonapalieva@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0a3d4f70-e60b-4f94-b568-be9b5412ab36", "DEBORAMILEVA@MAIL.COM", "AQAAAAEAACcQAAAAEJvkwcH288ZU33szLLkjkiMTJMzqwhsZW8iqEBZ4QxjuBOxeq+uClWdxgjwcbTPa7A==", "07ffe96a-cc84-45be-80cc-853992906a3e", "deboramileva@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b313e2e1-0270-4a86-924b-71256500be8b"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ad13828d-7df5-49ab-aeee-7c477669042d", "MIRELAMETODIEVA@MAIL.COM", "AQAAAAEAACcQAAAAEFW9dFvnQ9aARUJB0GikBYvWLWW+PAhkFcz8pH+2R1OO5o5OdpUWgXu6piH4j1G7bw==", "e371aaa8-9caf-4ded-9817-a9d2e8828013", "mirelametodieva@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e6ee1032-07de-4e1d-962a-c1e79fd09b87", "MARIAGEORGIEVA@MAIL.COM", "AQAAAAEAACcQAAAAEBdei4ZdI3v4acgWvy8iqdxPqPr5jlr2xobvxD1ZvAdzYS1qRdDKEtGTSK8psRqTyA==", "0972c791-377e-4357-97a7-d41d642eafc4", "mariageorgieva@mail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1674d538-3cf0-4a6e-bc27-aa070a230647"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9dbd1d41-581a-4bd0-837b-0d934e5e05db", "MONA", "AQAAAAEAACcQAAAAELrT7UuVI3YNcePiY9XxCWdRhMNI+ULg320lckyfeJ0WeECjr/LcCVvG8QMZqaGxnw==", "cffa8728-a37c-4267-8fe7-239489c6adb8", "Mona" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "36c1aac9-64c6-409e-ad87-30559737ecf5", "LISA", "AQAAAAEAACcQAAAAEKqgtnkQFUSdPxMMYnK3MpyuLSixlUjl6+7eewSQMwYoZxjPg3HbBtcN5pxpIOghLw==", "d7d13c5f-6f82-4a8d-973a-359c3ca3f3db", "Lisa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e43ac627-f74b-4cae-82fe-fcd3ae9892ba", "AYLIN", "AQAAAAEAACcQAAAAEMzUfy4mExF52zGHvsQ/RanbAwByT6BkA794faaCCJt+MaJC1vwk8NDqHDNW01RrtA==", "65575999-8738-4d05-8d16-fc47e03077e1", "Aylin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bea7392-a556-4a99-86c2-8cb244868283"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "84e935c5-baf4-4069-a943-f55c0cc5626d", "AMAYA", "AQAAAAEAACcQAAAAEAQB08HsCNCtn0+qXr8JIfiIg+L6LdN7liNzLOcxN2fu1bGbGIDNgFxeoGb/o4EFIw==", "db30c391-80b1-4034-9fb7-f3f845638ea9", "Amaya" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6774a48a-7836-4ce6-9ef1-ea7be75b4ec5"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "55a46873-7bc5-4d20-8789-f419ab751be3", "SIMONA", "AQAAAAEAACcQAAAAEFihLAuvJhAL7CfaExO2KyuvWJPIS4X8Bqz6Kr+SHsH2ultu73X7eObmD43HtXJUAg==", "a28b2c3d-a606-4121-b20f-bd8bf5cce6ce", "Simona" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c4fe0304-53fe-4eaa-9683-fcf9a9d5bc23", "DEBORA", "AQAAAAEAACcQAAAAEMET5bLLO8nXmPaO3x01XnyezHMJb4SYEtVagRQfcn19qMZSmi/9D2lhR3PilEPIgw==", "aab74b24-851c-4a56-a43f-872d2238a3cb", "Debora" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b313e2e1-0270-4a86-924b-71256500be8b"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "adb0c6a7-e6ee-4cbe-871c-22ae8f7e28c6", "MIRELA", "AQAAAAEAACcQAAAAEBzyfV23XVXrg4nuoHnhgH7Uo4BSsNaAEQND9aZYXxqQWa7ES6bIzsI5oAUy955qYw==", "68fabf3f-10d3-4b11-b773-22278241780d", "Mirela" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cf32f72a-06d3-441d-abc8-13de649cb9e8", "MARIA", "AQAAAAEAACcQAAAAEPEHThhyXQ3i2DmdjPOPFVIVmKhRtZ3Sf5JbUlFS+3oT6QT3jSNI+ElN4jXiQR2Q2w==", "e39550f7-623a-4387-b8ff-609851df9612", "Maria" });
        }
    }
}
