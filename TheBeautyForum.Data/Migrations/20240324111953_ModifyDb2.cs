using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBeautyForum.Data.Migrations
{
    public partial class ModifyDb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Studios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ac9f9de-412f-4923-bb24-91b8bf795dfd", "AQAAAAEAACcQAAAAEDRixNEf+yD090tTrYC85lAbOvQnoFWRbfslXU8bqWgmGB19ajovBaJEnx2bHuN4+Q==", "cbe6e2b9-3917-4d9c-b1bf-cf8ad36c824f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b97dc94-696d-4a89-8e5a-556727d2cf6e", "AQAAAAEAACcQAAAAEKcTSnva/Vzfv+0iNBxV7U8NPJvxnzzeKHY3t4sFAyi0sGqCmclMrS0PnA/IJnOxlw==", "ae50c374-a23a-4ace-b792-77c1615c7f3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bea7392-a556-4a99-86c2-8cb244868283"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8963cd3-4671-46b4-8c61-63276c41d6ed", "AQAAAAEAACcQAAAAEAhz6kOpFo/iRmiQRzic2ynEYmiIJBZefzQiKfzf3GMiX3fQkC3q/jQeNVDkZBtMIw==", "cde19e86-6945-4ace-b69c-4362aa6fda06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6774a48a-7836-4ce6-9ef1-ea7be75b4ec5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c08d1393-67b1-48ae-bc3f-64cf2a9ce786", "AQAAAAEAACcQAAAAEDWDGy0cqn5NmR1g1q4SX+lAbmCv1Zw8gdjRK21fOIUO87MdPkhcI6+aXBzAxYzccQ==", "da4d1b2e-550e-41f8-a6c2-49fc330ed366" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc37a191-4a4c-4bea-9f01-c90cba90ad7c", "AQAAAAEAACcQAAAAEDfoYBG7GvdC25Zls6/AHAlBL6tQBUH3EmClIrwY9do085fGiQxp2pRevQTVXhBnsA==", "0929e402-91c5-43e6-ab9e-59b24c91c8ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b313e2e1-0270-4a86-924b-71256500be8b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71f86965-4cb1-477e-a94b-acfa5cb69a6e", "AQAAAAEAACcQAAAAEDo4USrrJbc25rSoHEPHHXjGQCuDDY2QW374lwD5x0P7roASoIe8drSzk9OTd/xXPw==", "4199b149-2615-4de7-a115-f0b37d4ad21a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e70a0aa5-d2a0-4840-8e7e-96242279da91", "AQAAAAEAACcQAAAAEHComKVb6XDvIlv3xBpAhV0PtAt+mvnjn8+/TBsjdZwkqWaxOTmuQy5/sbR70gC6Pw==", "23a4de28-9d10-4670-9c3b-8cd76687630a" });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("168884a2-fc77-4169-836f-dc0a0599bc2e"),
                column: "StudioId",
                value: new Guid("bf2832b2-5b62-471b-9980-583753504ca6"));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("912d1986-7424-43fa-a531-b9d811961386"),
                column: "StudioId",
                value: new Guid("bf2832b2-5b62-471b-9980-583753504ca6"));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("960c4945-0b04-4c40-bd17-c697cb8d5eda"),
                column: "StudioId",
                value: new Guid("bf2832b2-5b62-471b-9980-583753504ca6"));

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: new Guid("0d753e1d-c98b-47c7-b260-0377048c529a"),
                column: "IsApproved",
                value: true);

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: new Guid("ad94f69c-b7e6-419b-bef0-fa50ab04f254"),
                column: "IsApproved",
                value: true);

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: new Guid("bf2832b2-5b62-471b-9980-583753504ca6"),
                column: "IsApproved",
                value: true);

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: new Guid("c7998d5b-0017-4924-8544-49b4a276afe1"),
                column: "IsApproved",
                value: true);

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: new Guid("df44a062-9586-4815-8126-99c240433b22"),
                column: "IsApproved",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Studios");

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

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("168884a2-fc77-4169-836f-dc0a0599bc2e"),
                column: "StudioId",
                value: new Guid("d8fbc428-62b8-42aa-b3d7-b40658072dca"));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("912d1986-7424-43fa-a531-b9d811961386"),
                column: "StudioId",
                value: new Guid("d8fbc428-62b8-42aa-b3d7-b40658072dca"));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("960c4945-0b04-4c40-bd17-c697cb8d5eda"),
                column: "StudioId",
                value: new Guid("d8fbc428-62b8-42aa-b3d7-b40658072dca"));
        }
    }
}
