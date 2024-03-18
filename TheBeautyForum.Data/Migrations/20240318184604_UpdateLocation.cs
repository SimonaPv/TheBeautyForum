using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBeautyForum.Data.Migrations
{
    public partial class UpdateLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03246963-2847-4dfc-ba4c-40726853a554", "AQAAAAEAACcQAAAAEMMp7dF9ZOgVEWbYjt2xfb9xonV5pgHfrUmcqqCG5OBOEtQYhuwDU+psgKZR8Iuo6g==", "986da44a-2657-41f2-b6ec-6a629cae0cdf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16da8ff9-837c-4e85-9c8a-5b9afc8206bd", "AQAAAAEAACcQAAAAEK83hhqlTeOn/ygJW+8KZ8LFbvv/MZnceJFc318mFr2+fevXdaD+rHAZx1sA9+gg/g==", "0ce00a5c-ebfe-4bfe-ba1a-51cef30f60fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bea7392-a556-4a99-86c2-8cb244868283"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdbebe2b-361e-4c93-9f57-848f11a6e5ad", "AQAAAAEAACcQAAAAECPmxIcF+YhA5HkLbQaPNT2zQ7MGVD5zm4zn4EVcXxH/IANyhVLgzo1zdZI5t8xHFw==", "7dabefad-e152-487d-bb4a-0e36491394d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "209a0dbe-25f9-4aa9-8569-1c8c9ce8b500", "AQAAAAEAACcQAAAAEMMgP6xv0hgUCzcxYjpswctNYGjmftby0duowoLX7N8bN141Io94m19tzrk+eUuLsQ==", "f8845aa7-8a20-4451-95e0-f2d913ebf31e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f386aede-a2af-427d-8c57-1065709a1d8c", "AQAAAAEAACcQAAAAEH3fvoKJVhG6bc+bXsAOzyFSEPjgK5aBNjbFuTA1ktoz6JdCENRhdFO0N05rokMgxg==", "d49011b7-dcf5-467a-9a69-17290d15607b" });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: new Guid("0d753e1d-c98b-47c7-b260-0377048c529a"),
                column: "Location",
                value: "Stara Zagora, Bulgaria, ul. Tsar Kaloyan 3");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01797a69-6ac6-43a5-9d69-134c5625e8ed", "AQAAAAEAACcQAAAAEDqcfqHGfKkdcpo1SKvir/S6HTZiFTDid2A8MQU2CTJT10BIDjut4nyNdp7MVzHPIg==", "4c4d8c1b-60a6-41d4-870a-0494af186b21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1830a0b4-5a92-4331-a803-9f281743cc2c", "AQAAAAEAACcQAAAAEEmZSqacNLNRWAipWCnD902hK+dr5RSVzWnStlcBkceUfo/4Mixy9lBz7lsX2ylSag==", "62d1980b-24d2-42c8-8e1a-571025df85a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bea7392-a556-4a99-86c2-8cb244868283"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff5c2a84-6e19-407a-86fb-b80f51bc7ca0", "AQAAAAEAACcQAAAAEK0b/IJmpcCqWI21oMgYC1Xekvx82yQUORKEvAv4sHdemrazkTl+dTtx+amRr1iJNA==", "7dc61433-213d-4d8c-8f86-5565cbb377c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1371d56d-6873-4a7c-ac2e-edbdbbafc80d", "AQAAAAEAACcQAAAAEP05IG4KV/kdumBaGhtMtbcrUTkVia1YjuTCgUSmDywxg1a2p0f0bTwL+k801apbqw==", "abc12f11-f9d1-48cc-a7ec-741fc9e2c4ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eaba9abd-ceb2-4039-ab23-b9fcaf7ef868", "AQAAAAEAACcQAAAAEOZvq73JslAOT6c2gN/iAPg7BsIcu4viJpWIsbQfUsUxMwflrdb/5lpepOXh0pOO8Q==", "2d29ed10-7c4a-4db3-8382-60ca27a3e419" });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: new Guid("0d753e1d-c98b-47c7-b260-0377048c529a"),
                column: "Location",
                value: "Stara Zagora, Bulgaria, ul. Vasil Levski 50");
        }
    }
}
