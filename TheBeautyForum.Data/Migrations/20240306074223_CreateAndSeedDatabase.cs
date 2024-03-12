﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBeautyForum.Data.Migrations
{
    public partial class CreateAndSeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ProfilePictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Studios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    OpenTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    CloseTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    StudioPictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointments_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_Studios_StudioId",
                        column: x => x.StudioId,
                        principalTable: "Studios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Publications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    DatePosted = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Publications_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Publications_Studios_StudioId",
                        column: x => x.StudioId,
                        principalTable: "Studios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ratings_Studios_StudioId",
                        column: x => x.StudioId,
                        principalTable: "Studios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudioCategories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudioCategories", x => new { x.StudioId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_StudioCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudioCategories_Studios_StudioId",
                        column: x => x.StudioId,
                        principalTable: "Studios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PublicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Publications_PublicationId",
                        column: x => x.PublicationId,
                        principalTable: "Publications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PublicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UrlPath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Publications_PublicationId",
                        column: x => x.PublicationId,
                        principalTable: "Publications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PublicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Likes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Likes_Publications_PublicationId",
                        column: x => x.PublicationId,
                        principalTable: "Publications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"), 0, "9371c7cf-3047-4e2b-b4b8-95c30a339f07", "lisaborisova@mail.com", false, "Lisa", "Borisova", false, null, "LISABORISOVA@MAIL.COM", "LISA", "AQAAAAEAACcQAAAAEJwaMmqomH5MKMvlFmQSyLLSPbEY1vpfWRbm2v2Qd0IVtnd/hc8okgsAt63lOl14Ww==", "0885555555", false, "https://res.cloudinary.com/di1lcwb4r/image/upload/v1709708446/am3nsitkxsxivfdoxey9.jpg", "6c78eacc-c936-43f0-ad0d-c20db63e0b8a", false, "Lisa" },
                    { new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"), 0, "cbeb7687-b412-47c3-8cf2-7cdde3fec0b2", "aylintodorova@mail.com", false, "Aylin", "Todorova", false, null, "AYLINTODOROVA@MAIL.COM", "AYLIN", "AQAAAAEAACcQAAAAEBrPR1CMiya5cU2yKnl5CfrnUUWPdRieI07oIddwpJ84cQegCB1HrcAoeZ/aVU+Zag==", "0883333333", false, "https://res.cloudinary.com/di1lcwb4r/image/upload/v1707378004/kgdkin0zow7lkpkc4hdy.jpg", "55764138-8262-44eb-8064-8e8eabba1de1", false, "Aylin" },
                    { new Guid("3bea7392-a556-4a99-86c2-8cb244868283"), 0, "864ee9b5-8252-4b3f-a53d-e2598513b1e3", "amayaivanova@mail.com", false, "Amaya", "Ivanova", false, null, "AMAYAIVANOVA@MAIL.COM", "AMAYA", "AQAAAAEAACcQAAAAELc/hqZln3J4KEyp/kGEZ1IndcceM9M3irj8Vq8O1gS9BrDuiyaeSvaQTYKJc/VrYw==", "0882222222", false, "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706685966/imzfycue1optdhfmwbuw.jpg", "af533b36-b4d9-428c-884d-6e296c8910b4", false, "Amaya" },
                    { new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"), 0, "6e0c0ff8-34d3-4334-8b09-e7f6d110a2d8", "deboramileva@mail.com", false, "Debora", "Mileva", false, null, "DEBORAMILEVA@MAIL.COM", "DEBORA", "AQAAAAEAACcQAAAAEKnfcR+9V+8H88fzbGBA+BjU1Tl8+Pa2V0sc9UQjMSzcSPq6uAesBjb/X+FiR+zXpQ==", "0884444444", false, "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706685966/npkpvs3b2i1tldoc7dmi.jpg", "be749d30-ed7d-44c4-90b0-08f0454e3bf7", false, "Debora" },
                    { new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"), 0, "db2f8d78-39e5-45b8-994d-b809c04124c5", "mariageorgieva@mail.com", false, "Maria", "Georgieva", false, null, "MARIAGEORGIEVA@MAIL.COM", "MARIA", "AQAAAAEAACcQAAAAEJxk7ksDqNov/QSbqM5R+bRXtPGMdT2lSITCt52rvWH3BGsW5CPy08R6ibYlm15A6Q==", "0881111111", false, "https://res.cloudinary.com/di1lcwb4r/image/upload/v1707378748/einenpgospeodkzbw8a7.jpg", "f0be51c0-eaaf-4257-8dc3-4a3c6a6044a9", false, "Maria" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1125ebe4-4f81-4bb8-90ee-aceaf509c4f3"), "Haircare" },
                    { new Guid("1c39f073-d448-4e8b-9079-369aab2d816b"), "Facial therapy" },
                    { new Guid("2da87f9f-d52a-4d4b-a8c6-37200c4cfeea"), "Pedicure" },
                    { new Guid("3be6b016-9b6a-4f68-b7ee-bf32293acca9"), "Haircut" },
                    { new Guid("42334109-d996-4339-b78c-4ba73fcdd824"), "Stone massage" },
                    { new Guid("4ebb7e23-2a49-4451-8c96-b5c6de99900e"), "Manicure" },
                    { new Guid("569a4a94-57b0-48d3-930c-0d3ca92f7eb8"), "Full body massage" },
                    { new Guid("57edeb42-3369-4c8c-b2d2-8c6c0ac49cfc"), "Facial cleansing" },
                    { new Guid("6f3f3c4a-9213-48a9-a112-362e10188983"), "Aromatherapy massage" },
                    { new Guid("766f75cf-899f-491e-9c5a-6ff5949159a1"), "Facial stone therapy" },
                    { new Guid("8859c909-f5cf-4f72-ba53-5a9e6dfac34d"), "Hairstyle" },
                    { new Guid("93474d31-0c93-4d01-9130-3b967b09a74a"), "Reiki" },
                    { new Guid("acc8a306-8a0b-4ede-8a03-f1ab6e90eed4"), "Microblading" },
                    { new Guid("b9b9950e-5ad6-4f44-87b0-e8811e9a59e2"), "Bali massage" },
                    { new Guid("d079d974-8e76-4b0c-8c41-291ecd9042b1"), "Anti-age therapy" },
                    { new Guid("d5cbb5ce-65e7-4a6a-a03c-fd13fcf304de"), "Microneedling" },
                    { new Guid("db7effe2-16bb-4539-9dec-0bda384b859f"), "Hair coloring" },
                    { new Guid("f63198ba-741e-42ca-b112-f08c0e193bbb"), "Thai massage" },
                    { new Guid("f74035eb-e32d-4ddf-b381-8a757c7d5152"), "Full SPA" }
                });

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "CloseTime", "Description", "Location", "Name", "OpenTime", "StudioPictureUrl" },
                values: new object[,]
                {
                    { new Guid("0d753e1d-c98b-47c7-b260-0377048c529a"), new TimeSpan(0, 18, 0, 0, 0), "Hairstyling and Haircutting", "Stara Zagora, Bulgaria, ul. \"Ivan Vazov\" 13, Zagorka", "Murphy", new TimeSpan(0, 9, 0, 0, 0), "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706708324/fnk089i9d440zt0vuhjm.jpg" },
                    { new Guid("ad94f69c-b7e6-419b-bef0-fa50ab04f254"), new TimeSpan(0, 18, 0, 0, 0), "Dream haircuts can come true!", "Varna, Bulgaria, ul. \"Pozitano\" 125, 1309 Zona B-19", "Helita", new TimeSpan(0, 9, 0, 0, 0), "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706708324/cjb6es4kqpy6kukryk8r.jpg" },
                    { new Guid("bf2832b2-5b62-471b-9980-583753504ca6"), new TimeSpan(0, 18, 0, 0, 0), "Ina Vasileva's Studio", "Varna, Bulgaria, ul. \"Vejen St.\" 09", "IN Beauty", new TimeSpan(0, 9, 0, 0, 0), "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706708324/omikwkyqnrafjnju82jf.jpg" },
                    { new Guid("c7998d5b-0017-4924-8544-49b4a276afe1"), new TimeSpan(0, 18, 0, 0, 0), "Hair Care Studio", "Sofia, Bulgaria, ul. \"Zograf\" 26", "N-Stage", new TimeSpan(0, 9, 0, 0, 0), "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706708324/ulq1xkktowireigsxuil.jpg" },
                    { new Guid("d8fbc428-62b8-42aa-b3d7-b40658072dca"), new TimeSpan(0, 18, 0, 0, 0), "Bali&Thai Massages", "Sofia, Bulgaria, ul. \"Aksakov\" 11", "Arsanta", new TimeSpan(0, 9, 0, 0, 0), "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706708324/sf7gy9cpjrnlkn2ba8rs.jpg" },
                    { new Guid("df44a062-9586-4815-8126-99c240433b22"), new TimeSpan(0, 18, 0, 0, 0), "SPA Studio", "Sofia, Bulgaria, ul. \"St. Georgi\" 26", "Wellness Center", new TimeSpan(0, 9, 0, 0, 0), "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706708324/wrm1h8b2sfjf06xujkck.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "CategoryId", "Description", "EndDate", "StartDate", "StudioId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0b561660-608b-4e07-80bc-96c168ff11ac"), new Guid("3be6b016-9b6a-4f68-b7ee-bf32293acca9"), "I want a hairstyle for my birthday.", new DateTime(2024, 4, 22, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 12, 30, 0, 0, DateTimeKind.Unspecified), new Guid("ad94f69c-b7e6-419b-bef0-fa50ab04f254"), new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9") },
                    { new Guid("1790311d-5712-44a9-abbd-3bfc47802419"), new Guid("4ebb7e23-2a49-4451-8c96-b5c6de99900e"), "Monthly manicure appointment.", new DateTime(2024, 4, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 14, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0d753e1d-c98b-47c7-b260-0377048c529a"), new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9") },
                    { new Guid("79e4af3b-6bcf-4476-8705-2457836a1968"), new Guid("569a4a94-57b0-48d3-930c-0d3ca92f7eb8"), "I need a relaxing massage.", new DateTime(2024, 4, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), new Guid("df44a062-9586-4815-8126-99c240433b22"), new Guid("3bea7392-a556-4a99-86c2-8cb244868283") },
                    { new Guid("8180ba4e-0941-4b06-abfa-e36a25ddb881"), new Guid("1125ebe4-4f81-4bb8-90ee-aceaf509c4f3"), "I need care for bleached hair.", new DateTime(2024, 2, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c7998d5b-0017-4924-8544-49b4a276afe1"), new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d") },
                    { new Guid("9b76ada8-1c16-4f05-b308-1c4ff3de137f"), new Guid("db7effe2-16bb-4539-9dec-0bda384b859f"), "I want platinum blond.", new DateTime(2024, 2, 18, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 18, 12, 30, 0, 0, DateTimeKind.Unspecified), new Guid("0d753e1d-c98b-47c7-b260-0377048c529a"), new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d") },
                    { new Guid("f1a43f31-6d82-442b-8f89-941f7b6da3ec"), new Guid("db7effe2-16bb-4539-9dec-0bda384b859f"), "I want slight balayage.", new DateTime(2024, 3, 20, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 12, 30, 0, 0, DateTimeKind.Unspecified), new Guid("0d753e1d-c98b-47c7-b260-0377048c529a"), new Guid("3bea7392-a556-4a99-86c2-8cb244868283") }
                });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "DatePosted", "Description", "StudioId", "UserId" },
                values: new object[,]
                {
                    { new Guid("09d4bfa2-1b65-4085-ad6c-010c20427409"), new DateTime(2024, 2, 9, 16, 46, 0, 0, DateTimeKind.Unspecified), "Me time.. #spaDay #SPA", new Guid("df44a062-9586-4815-8126-99c240433b22"), new Guid("3bea7392-a556-4a99-86c2-8cb244868283") },
                    { new Guid("35b859db-5567-4336-bd2b-34aea67bf26a"), new DateTime(2024, 2, 11, 9, 11, 0, 0, DateTimeKind.Unspecified), "Guess who's getting MARRIED!! #bride #love", new Guid("0d753e1d-c98b-47c7-b260-0377048c529a"), new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f") },
                    { new Guid("368c82c4-7046-44ee-8315-149e4527bd47"), new DateTime(2024, 2, 9, 12, 4, 0, 0, DateTimeKind.Unspecified), "A needed day OFF! #relax", new Guid("d8fbc428-62b8-42aa-b3d7-b40658072dca"), new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d") },
                    { new Guid("3dff0a05-d97b-44f5-9118-80a276adad91"), new DateTime(2024, 2, 10, 15, 23, 0, 0, DateTimeKind.Unspecified), "Love my new nails!! #nailDay #newNails", new Guid("bf2832b2-5b62-471b-9980-583753504ca6"), new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9") },
                    { new Guid("765a831a-5e10-43a8-adf2-e7e8d62fc7e0"), new DateTime(2024, 2, 13, 13, 19, 0, 0, DateTimeKind.Unspecified), "Your curls can dream.. #curlyHair #healthy", new Guid("c7998d5b-0017-4924-8544-49b4a276afe1"), new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b") }
                });

            migrationBuilder.InsertData(
                table: "StudioCategories",
                columns: new[] { "CategoryId", "StudioId" },
                values: new object[,]
                {
                    { new Guid("1125ebe4-4f81-4bb8-90ee-aceaf509c4f3"), new Guid("0d753e1d-c98b-47c7-b260-0377048c529a") },
                    { new Guid("3be6b016-9b6a-4f68-b7ee-bf32293acca9"), new Guid("0d753e1d-c98b-47c7-b260-0377048c529a") },
                    { new Guid("8859c909-f5cf-4f72-ba53-5a9e6dfac34d"), new Guid("0d753e1d-c98b-47c7-b260-0377048c529a") },
                    { new Guid("db7effe2-16bb-4539-9dec-0bda384b859f"), new Guid("0d753e1d-c98b-47c7-b260-0377048c529a") },
                    { new Guid("1125ebe4-4f81-4bb8-90ee-aceaf509c4f3"), new Guid("ad94f69c-b7e6-419b-bef0-fa50ab04f254") },
                    { new Guid("3be6b016-9b6a-4f68-b7ee-bf32293acca9"), new Guid("ad94f69c-b7e6-419b-bef0-fa50ab04f254") },
                    { new Guid("8859c909-f5cf-4f72-ba53-5a9e6dfac34d"), new Guid("ad94f69c-b7e6-419b-bef0-fa50ab04f254") },
                    { new Guid("db7effe2-16bb-4539-9dec-0bda384b859f"), new Guid("ad94f69c-b7e6-419b-bef0-fa50ab04f254") },
                    { new Guid("2da87f9f-d52a-4d4b-a8c6-37200c4cfeea"), new Guid("bf2832b2-5b62-471b-9980-583753504ca6") },
                    { new Guid("4ebb7e23-2a49-4451-8c96-b5c6de99900e"), new Guid("bf2832b2-5b62-471b-9980-583753504ca6") },
                    { new Guid("1125ebe4-4f81-4bb8-90ee-aceaf509c4f3"), new Guid("c7998d5b-0017-4924-8544-49b4a276afe1") },
                    { new Guid("3be6b016-9b6a-4f68-b7ee-bf32293acca9"), new Guid("c7998d5b-0017-4924-8544-49b4a276afe1") },
                    { new Guid("8859c909-f5cf-4f72-ba53-5a9e6dfac34d"), new Guid("c7998d5b-0017-4924-8544-49b4a276afe1") },
                    { new Guid("db7effe2-16bb-4539-9dec-0bda384b859f"), new Guid("c7998d5b-0017-4924-8544-49b4a276afe1") },
                    { new Guid("93474d31-0c93-4d01-9130-3b967b09a74a"), new Guid("d8fbc428-62b8-42aa-b3d7-b40658072dca") },
                    { new Guid("b9b9950e-5ad6-4f44-87b0-e8811e9a59e2"), new Guid("d8fbc428-62b8-42aa-b3d7-b40658072dca") },
                    { new Guid("f63198ba-741e-42ca-b112-f08c0e193bbb"), new Guid("d8fbc428-62b8-42aa-b3d7-b40658072dca") },
                    { new Guid("42334109-d996-4339-b78c-4ba73fcdd824"), new Guid("df44a062-9586-4815-8126-99c240433b22") },
                    { new Guid("569a4a94-57b0-48d3-930c-0d3ca92f7eb8"), new Guid("df44a062-9586-4815-8126-99c240433b22") },
                    { new Guid("6f3f3c4a-9213-48a9-a112-362e10188983"), new Guid("df44a062-9586-4815-8126-99c240433b22") },
                    { new Guid("f74035eb-e32d-4ddf-b381-8a757c7d5152"), new Guid("df44a062-9586-4815-8126-99c240433b22") }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "PublicationId", "UrlPath" },
                values: new object[,]
                {
                    { new Guid("02fa054e-3efe-4923-b267-aca9ac769f81"), new Guid("765a831a-5e10-43a8-adf2-e7e8d62fc7e0"), "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706685966/v9b0ghriku0s2pfsppaj.jpg" },
                    { new Guid("120dbf97-04a7-4cf4-a4f9-aea8ffc3037f"), new Guid("368c82c4-7046-44ee-8315-149e4527bd47"), "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706685966/y7uikxn4ib53acmxt978.jpg" },
                    { new Guid("5b637ca8-0eaf-41d7-ae31-6f506bbcd812"), new Guid("35b859db-5567-4336-bd2b-34aea67bf26a"), "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706685965/x2kx2oeyhz22ouwandcr.jpg" },
                    { new Guid("dd2c855b-e8cb-43c8-8437-c8fbd54444a8"), new Guid("3dff0a05-d97b-44f5-9118-80a276adad91"), "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706685966/oaxk2efd2zcewio2tciv.jpg" },
                    { new Guid("e121ce4c-f437-4696-99fa-1859d1de6780"), new Guid("09d4bfa2-1b65-4085-ad6c-010c20427409"), "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706685965/bypcq7r5kqpgjbm8keka.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_CategoryId",
                table: "Appointments",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_StudioId",
                table: "Appointments",
                column: "StudioId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_UserId",
                table: "Appointments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PublicationId",
                table: "Comments",
                column: "PublicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_PublicationId",
                table: "Images",
                column: "PublicationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Likes_PublicationId",
                table: "Likes",
                column: "PublicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_UserId",
                table: "Likes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Publications_StudioId",
                table: "Publications",
                column: "StudioId");

            migrationBuilder.CreateIndex(
                name: "IX_Publications_UserId",
                table: "Publications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_StudioId",
                table: "Ratings",
                column: "StudioId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StudioCategories_CategoryId",
                table: "StudioCategories",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "StudioCategories");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Publications");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Studios");
        }
    }
}
