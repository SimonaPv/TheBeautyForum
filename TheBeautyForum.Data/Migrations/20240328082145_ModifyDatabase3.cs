using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBeautyForum.Data.Migrations
{
    public partial class ModifyDatabase3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1674d538-3cf0-4a6e-bc27-aa070a230647"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a54847ec-e18f-4edd-abff-b4907e20a1a1", "AQAAAAEAACcQAAAAEP0BzPmGWf65E34edraFtphql3SLNxf+6BIzHe8QjJz//F5q74MlD0pYNPQULfpgvA==", "6b2c6443-b36d-4874-8f6d-b4c2561fcbda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e66db83-5928-4884-83c6-ea65358fdbcb", "AQAAAAEAACcQAAAAEBKlxkdpoiSkS8VVAxFr2+pOWX6eWWkT9ZbFugxs+E2MS+xwJXaLBEaiCZHFBAzRuw==", "e9c62266-7366-4bb9-b482-49159f75f419" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffa3cf68-cf2a-499e-82ee-3b58784ac5df", "AQAAAAEAACcQAAAAEDTaohjyhmLWvARJjKq7a27zGeHB9A9+95gro9qDS3fbB8/fXXpGMscDd+7hBTTYWw==", "bb662a16-336f-405e-b358-a99619254b1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bea7392-a556-4a99-86c2-8cb244868283"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed695ddf-ac36-4edc-b06b-62ed863e4dc3", "AQAAAAEAACcQAAAAEGv9Wdd8f/kiQRlrWQ4QKHZNnN2g3bi/hI0QmZkTdJV/Qnb4ovFh4onghLWS4KpZUw==", "2d6fd84c-d47f-48ef-b884-6121eca2a439" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6774a48a-7836-4ce6-9ef1-ea7be75b4ec5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "106871dc-153e-4736-8577-bd5845527503", "AQAAAAEAACcQAAAAEBPzQL8sVS9NYe2uzTXB+VxdqiX22H8hBEj7EiiPqyTSPrRsLGiokGeqcVvuS6XDHA==", "8215f695-3eb2-4ff1-838b-91b0efda5a78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2feb09a-cb10-49cc-b792-3418f465fa5d", "AQAAAAEAACcQAAAAEH6dbNoFt+U4ce1Q0aGRaARJ9kvhADrTm4h43JOLrmvSIRB0w9TbH0ymyWj7jGe4sA==", "ac599d1a-1e74-4293-a1b5-014315e1d3a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b313e2e1-0270-4a86-924b-71256500be8b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69bdbae7-b39a-4605-b8df-814ff1a1c1dc", "AQAAAAEAACcQAAAAEFaYVLlN2QJl8JwPeVJ1l7eEyFZ7u1YfL+2dbBG9Vd3XNZ9n/kL02PUNeZuVlumUGw==", "ec7296d0-f436-4087-b918-29a10010f9f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21150f80-bfdc-4f0e-851d-73e5d84fce4f", "AQAAAAEAACcQAAAAEGeSjiyIPUHHVCdvEq7trPl9aaTPPfDFgmty4E+8EomhLamBuGRBVnWwmrBl9flSjQ==", "ca20f5ba-335b-4a81-9bb0-d6553388f9de" });
        }
    }
}
