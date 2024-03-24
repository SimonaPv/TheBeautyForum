using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBeautyForum.Data.Migrations
{
    public partial class ModifyDb3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("0b561660-608b-4e07-80bc-96c168ff11ac"));

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: new Guid("beb87557-618d-4fbc-b5a4-12b8f54c5359"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5c967a6-cdd0-4975-a318-fde45661d2e6", "AQAAAAEAACcQAAAAENuaLHoeoluJgdBktwbG71LxuAY2am53NZ7wLpQ5DS9VVUd8SG4maJNXWFUFUmTYmA==", "42c1c46f-396d-4f96-b3be-685a285d0e49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83a8024d-156e-485e-9d9e-c31e8c56f43c", "AQAAAAEAACcQAAAAEET3H7gho6QCqZ94gGAcjo2jwJl/n1sFFKvhjm8USmN6MOv2UfZ1kAHxMjFlRlsKmw==", "f5cf8295-a6f7-4a11-8e89-4df4be62499d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bea7392-a556-4a99-86c2-8cb244868283"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d0fb6c9-8638-456b-bcea-22ecc365858b", "AQAAAAEAACcQAAAAELLUvIsx7WlsPqzyMpBfLNZto4iPaH/pzSsevfVlEyEUjLsgoEnyzKIYJW2I7gv9aw==", "767d8949-2b0b-47f5-8f10-41bd7a4b5d93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6774a48a-7836-4ce6-9ef1-ea7be75b4ec5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f344169-ec4b-444c-b9b2-2323dec89041", "AQAAAAEAACcQAAAAEGJPhwMmlVNCpx7khOWSYnsUFedEClSetbm53XwbvmJQaX/5WgDa3T15yXl6asnWDA==", "08def302-58f1-402c-87bf-52626356dab4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f135605-36fe-4307-8e78-44d43d5bd59a", "AQAAAAEAACcQAAAAEIo6V/1GlKtNFJpKoNmCWNoolaObqfHd2+RWnD9fk4FWXgMPJjd45WCa7tAoysWiIg==", "9f8470d2-e840-47cb-9a0e-057190014445" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b313e2e1-0270-4a86-924b-71256500be8b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91c28017-734c-42c1-944d-d7c634768592", "AQAAAAEAACcQAAAAEEEIe6DmFF9Uc4H3rRI9Rn7j1VBzlLNodtHlxNwwq5tSunnD4JfH+BXwImysW+w5QQ==", "b9e8ea4e-0b8c-4ef8-be0f-e175beda33ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68d9b7b7-093f-4e18-b33c-3e1c8870f2e2", "AQAAAAEAACcQAAAAEGmcuVtbjmztJD6VlKVznM1GDXGDJmNkDdWUDnTIYrGRgNP2rC2DXYujHsNwZ5XfJw==", "b88a2ce0-513f-4c0b-a303-898e445286a7" });

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

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: new Guid("ad94f69c-b7e6-419b-bef0-fa50ab04f254"),
                column: "IsApproved",
                value: false);

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: new Guid("d8fbc428-62b8-42aa-b3d7-b40658072dca"),
                column: "IsApproved",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "CategoryId", "Description", "EndDate", "StartDate", "StudioId", "UserId" },
                values: new object[] { new Guid("0b561660-608b-4e07-80bc-96c168ff11ac"), new Guid("3be6b016-9b6a-4f68-b7ee-bf32293acca9"), "I want a hairstyle for my birthday.", new DateTime(2024, 7, 22, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ad94f69c-b7e6-419b-bef0-fa50ab04f254"), new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9") });

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

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "StudioId", "UserId", "Value" },
                values: new object[] { new Guid("beb87557-618d-4fbc-b5a4-12b8f54c5359"), new Guid("ad94f69c-b7e6-419b-bef0-fa50ab04f254"), new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"), 3 });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: new Guid("ad94f69c-b7e6-419b-bef0-fa50ab04f254"),
                column: "IsApproved",
                value: true);

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: new Guid("d8fbc428-62b8-42aa-b3d7-b40658072dca"),
                column: "IsApproved",
                value: false);
        }
    }
}
