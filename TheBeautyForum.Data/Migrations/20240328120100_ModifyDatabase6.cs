using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBeautyForum.Data.Migrations
{
    public partial class ModifyDatabase6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1674d538-3cf0-4a6e-bc27-aa070a230647"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "350c52d7-9798-4dc0-af72-0e249c2fe1b5", "AQAAAAEAACcQAAAAEFXOrYbxuvxiz2mYR1/7t34dxTXNyIj/KW1Fnktam4NzFja2SuaIm7d/zzixNP17ew==", "6774184d-a4ea-4f5e-ae11-367c5e92d2e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62db6ec6-f1c9-4531-813f-1cba1b211361", "AQAAAAEAACcQAAAAEH9TSpxD/MkyJXsoWY3IqM2TuUEHdNOvHwrKVLFYbSd9AErKiuC5xU3T38jaYD4WNA==", "598cde7a-32c2-4b78-9d9e-c70572a71367" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "451af74d-0fe1-4229-9a86-1462ea1d4ebd", "AQAAAAEAACcQAAAAELcsrsu/IMGOj3ecIwaZmwIz0xMme+Bc9c0nDpKS9rRAUqwFH9NIuZ+SVZ8P3c0frg==", "52be306b-e88b-4a5b-847b-985307811776" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bea7392-a556-4a99-86c2-8cb244868283"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ade5ff4-6c45-4349-885d-e6f3c147d938", "AQAAAAEAACcQAAAAEERLnpaKcAV0EI+cvQWxpi3Ye8e3dg2Gmf3KW3eC1b9kXGMpnASRnzXj0GiQW3CYqg==", "578a935e-9378-4651-b899-957154107960" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6774a48a-7836-4ce6-9ef1-ea7be75b4ec5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1276c67-5138-41e4-8970-7b2492d4a1d5", "AQAAAAEAACcQAAAAEGZ0yYePTnNdh959R0MRVF+6DFQl27lGs1sGItw48A2MbRT6bwqLCXdi/VcdZDcJDg==", "67aff362-c89f-4fac-b508-be5abb461ad8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94d00e4b-c059-4092-966d-93ebd7f99281", "AQAAAAEAACcQAAAAEIIUzZuPQ7a13P5wvCBogQkKleP3Jb3s2U7cl42H958azMVHc+vNiRRCvXmcTB2o2A==", "0a309c94-bf7e-46c4-b3f4-6ed5e4aa969a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b313e2e1-0270-4a86-924b-71256500be8b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca3ca7f0-6442-4991-bd81-007faf1a11f8", "AQAAAAEAACcQAAAAEOGMNqieNMaNZw5OmwzvtDYBnEsnKB6b+m4NQn/T4jHsDCZKzzeLCsEnfS+iD8Yrvg==", "9a875250-6933-4644-bffc-6dcb2e5f92c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8728e17-367d-4c66-a375-ade98af8976e", "AQAAAAEAACcQAAAAECsMoy0ZyjJ5Curxqh5FhXFIBcJDnIg9uMY5pjlOp/3qbh2HQwkSxJJ4GCU/JFTKRA==", "b2bb5ee0-e215-465f-bf4b-4478986e0c8a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1674d538-3cf0-4a6e-bc27-aa070a230647"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9598efac-d155-4099-ab2e-bdad272645a9", "AQAAAAEAACcQAAAAEFn6YB38/VnT0Qx8wWKWymgK7jr5mjfEYbn94S0tigfCebERdK3fVswemsToHqHUXQ==", "52156b9e-4055-4992-9fe0-470d84a758c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "790831bf-e992-4f34-ad44-bcee9cc9b350", "AQAAAAEAACcQAAAAECVpC3AMCgwmog7h/Z2iZFD/QfdbwNPDKuA/+3ePIHKLFCuBfBkXlZze7n5+dMMAGQ==", "24088c78-2f96-4926-96a8-bf5194cbff12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e72c156-bbfd-4eb1-b7e8-5685ed07c27e", "AQAAAAEAACcQAAAAEJ37TFnhFEFLyQc7xtCZOLSRx66VwJeOd/ZCdX9vw9tDhBsl0nKnWEXHbKr/rOPMDA==", "d82c8b2b-2a89-4298-b81d-aec59d50e7a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bea7392-a556-4a99-86c2-8cb244868283"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99e513d7-73d7-4d3a-a48a-b883a8091360", "AQAAAAEAACcQAAAAENZNBgDnLJBGs3NFKjEpHdHQzLstPs6vD9tLkD0xPBiLh1Qc8lMpgZfzvrWt1im5ZQ==", "32fac06b-1d25-4148-ac20-1a65396536f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6774a48a-7836-4ce6-9ef1-ea7be75b4ec5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79d5a2b3-16c5-4667-bcfb-2e724aa4307f", "AQAAAAEAACcQAAAAEMtnkbvIPaJO51rJvo95JQHouYRCoxKwatB0CXJHC5nDB6rZ2Ak8aQhfduiogbk+/A==", "e3b1aa44-a0c5-4874-bfb0-e0b2458b3cd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a3d4f70-e60b-4f94-b568-be9b5412ab36", "AQAAAAEAACcQAAAAEJvkwcH288ZU33szLLkjkiMTJMzqwhsZW8iqEBZ4QxjuBOxeq+uClWdxgjwcbTPa7A==", "07ffe96a-cc84-45be-80cc-853992906a3e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b313e2e1-0270-4a86-924b-71256500be8b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad13828d-7df5-49ab-aeee-7c477669042d", "AQAAAAEAACcQAAAAEFW9dFvnQ9aARUJB0GikBYvWLWW+PAhkFcz8pH+2R1OO5o5OdpUWgXu6piH4j1G7bw==", "e371aaa8-9caf-4ded-9817-a9d2e8828013" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6ee1032-07de-4e1d-962a-c1e79fd09b87", "AQAAAAEAACcQAAAAEBdei4ZdI3v4acgWvy8iqdxPqPr5jlr2xobvxD1ZvAdzYS1qRdDKEtGTSK8psRqTyA==", "0972c791-377e-4357-97a7-d41d642eafc4" });
        }
    }
}
