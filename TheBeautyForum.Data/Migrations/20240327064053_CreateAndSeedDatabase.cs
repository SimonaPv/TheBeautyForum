using System;
using Microsoft.EntityFrameworkCore.Migrations;

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
                name: "Studios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    OpenTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    CloseTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    StudioPictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Studios_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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
                name: "StudiosCategories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudiosCategories", x => new { x.StudioId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_StudiosCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudiosCategories_Studios_StudioId",
                        column: x => x.StudioId,
                        principalTable: "Studios",
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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("56bdecaf-285f-4a8e-b650-8bc997be759d"), "a778cea8-08b3-42c0-9e21-340e9a082042", "Administrator", "ADMINISTRATOR" },
                    { new Guid("5a322cf5-7101-4d4a-9e08-16382fc0a641"), "e8393d91-9ede-44d6-bdfb-7fecba284cbf", "User", "USER" },
                    { new Guid("71d6d7d8-f4f6-42b5-a9a9-ed2d3ef0bc73"), "16a14879-253d-46d4-b1d2-ab4c2f8dd55c", "StudioCreator", "STUDIOCREATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1674d538-3cf0-4a6e-bc27-aa070a230647"), 0, "a54847ec-e18f-4edd-abff-b4907e20a1a1", "monailieva@mail.com", false, "Mona", "Ilieva", false, null, "MONAILIEVA@MAIL.COM", "MONA", "AQAAAAEAACcQAAAAEP0BzPmGWf65E34edraFtphql3SLNxf+6BIzHe8QjJz//F5q74MlD0pYNPQULfpgvA==", "0887777777", false, "https://res.cloudinary.com/di1lcwb4r/image/upload/v1711366246/c1ijia1awr51quznbqgu.jpg", "6b2c6443-b36d-4874-8f6d-b4c2561fcbda", false, "Mona" },
                    { new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"), 0, "0e66db83-5928-4884-83c6-ea65358fdbcb", "lisaborisova@mail.com", false, "Lisa", "Borisova", false, null, "LISABORISOVA@MAIL.COM", "LISA", "AQAAAAEAACcQAAAAEBKlxkdpoiSkS8VVAxFr2+pOWX6eWWkT9ZbFugxs+E2MS+xwJXaLBEaiCZHFBAzRuw==", "0885555555", false, "https://res.cloudinary.com/di1lcwb4r/image/upload/v1709708446/am3nsitkxsxivfdoxey9.jpg", "e9c62266-7366-4bb9-b482-49159f75f419", false, "Lisa" },
                    { new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"), 0, "ffa3cf68-cf2a-499e-82ee-3b58784ac5df", "aylintodorova@mail.com", false, "Aylin", "Todorova", false, null, "AYLINTODOROVA@MAIL.COM", "AYLIN", "AQAAAAEAACcQAAAAEDTaohjyhmLWvARJjKq7a27zGeHB9A9+95gro9qDS3fbB8/fXXpGMscDd+7hBTTYWw==", "0883333333", false, "https://res.cloudinary.com/di1lcwb4r/image/upload/v1707378004/kgdkin0zow7lkpkc4hdy.jpg", "bb662a16-336f-405e-b358-a99619254b1b", false, "Aylin" },
                    { new Guid("3bea7392-a556-4a99-86c2-8cb244868283"), 0, "ed695ddf-ac36-4edc-b06b-62ed863e4dc3", "amayaivanova@mail.com", false, "Amaya", "Ivanova", false, null, "AMAYAIVANOVA@MAIL.COM", "AMAYA", "AQAAAAEAACcQAAAAEGv9Wdd8f/kiQRlrWQ4QKHZNnN2g3bi/hI0QmZkTdJV/Qnb4ovFh4onghLWS4KpZUw==", "0882222222", false, "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706685966/imzfycue1optdhfmwbuw.jpg", "2d6fd84c-d47f-48ef-b884-6121eca2a439", false, "Amaya" },
                    { new Guid("6774a48a-7836-4ce6-9ef1-ea7be75b4ec5"), 0, "106871dc-153e-4736-8577-bd5845527503", "simonapalieva@mail.com", false, "Simona", "Palieva", false, null, "SIMONAPALIEVA@MAIL.COM", "SIMONA", "AQAAAAEAACcQAAAAEBPzQL8sVS9NYe2uzTXB+VxdqiX22H8hBEj7EiiPqyTSPrRsLGiokGeqcVvuS6XDHA==", "0884912724", false, "https://res.cloudinary.com/di1lcwb4r/image/upload/v1711218695/fngujmuenduudydw6g0m.png", "8215f695-3eb2-4ff1-838b-91b0efda5a78", false, "Simona" },
                    { new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"), 0, "d2feb09a-cb10-49cc-b792-3418f465fa5d", "deboramileva@mail.com", false, "Debora", "Mileva", false, null, "DEBORAMILEVA@MAIL.COM", "DEBORA", "AQAAAAEAACcQAAAAEH6dbNoFt+U4ce1Q0aGRaARJ9kvhADrTm4h43JOLrmvSIRB0w9TbH0ymyWj7jGe4sA==", "0884444444", false, "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706685966/npkpvs3b2i1tldoc7dmi.jpg", "ac599d1a-1e74-4293-a1b5-014315e1d3a7", false, "Debora" },
                    { new Guid("b313e2e1-0270-4a86-924b-71256500be8b"), 0, "69bdbae7-b39a-4605-b8df-814ff1a1c1dc", "mirelametodieva@mail.com", false, "Mirela", "Metodieva", false, null, "MIRELAMETODIEVA@MAIL.COM", "MIRELA", "AQAAAAEAACcQAAAAEFaYVLlN2QJl8JwPeVJ1l7eEyFZ7u1YfL+2dbBG9Vd3XNZ9n/kL02PUNeZuVlumUGw==", "0886666666", false, "https://res.cloudinary.com/di1lcwb4r/image/upload/v1711219006/pqqa3hau5sceuvlbbvwk.jpg", "ec7296d0-f436-4087-b918-29a10010f9f6", false, "Mirela" },
                    { new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"), 0, "21150f80-bfdc-4f0e-851d-73e5d84fce4f", "mariageorgieva@mail.com", false, "Maria", "Georgieva", false, null, "MARIAGEORGIEVA@MAIL.COM", "MARIA", "AQAAAAEAACcQAAAAEGeSjiyIPUHHVCdvEq7trPl9aaTPPfDFgmty4E+8EomhLamBuGRBVnWwmrBl9flSjQ==", "0881111111", false, "https://res.cloudinary.com/di1lcwb4r/image/upload/v1707378748/einenpgospeodkzbw8a7.jpg", "ca20f5ba-335b-4a81-9bb0-d6553388f9de", false, "Maria" }
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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("71d6d7d8-f4f6-42b5-a9a9-ed2d3ef0bc73"), new Guid("1674d538-3cf0-4a6e-bc27-aa070a230647") },
                    { new Guid("5a322cf5-7101-4d4a-9e08-16382fc0a641"), new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b") },
                    { new Guid("5a322cf5-7101-4d4a-9e08-16382fc0a641"), new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d") },
                    { new Guid("5a322cf5-7101-4d4a-9e08-16382fc0a641"), new Guid("3bea7392-a556-4a99-86c2-8cb244868283") },
                    { new Guid("56bdecaf-285f-4a8e-b650-8bc997be759d"), new Guid("6774a48a-7836-4ce6-9ef1-ea7be75b4ec5") },
                    { new Guid("5a322cf5-7101-4d4a-9e08-16382fc0a641"), new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f") },
                    { new Guid("71d6d7d8-f4f6-42b5-a9a9-ed2d3ef0bc73"), new Guid("b313e2e1-0270-4a86-924b-71256500be8b") },
                    { new Guid("5a322cf5-7101-4d4a-9e08-16382fc0a641"), new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9") }
                });

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "CloseTime", "Description", "IsApproved", "Location", "Name", "OpenTime", "StudioPictureUrl", "UserId" },
                values: new object[,]
                {
                    { new Guid("0d753e1d-c98b-47c7-b260-0377048c529a"), new TimeSpan(0, 18, 0, 0, 0), "Hairstyling and Haircutting", true, "Stara Zagora, Bulgaria, ul. Tsar Kaloyan 3", "Murphy", new TimeSpan(0, 9, 0, 0, 0), "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706708324/fnk089i9d440zt0vuhjm.jpg", new Guid("b313e2e1-0270-4a86-924b-71256500be8b") },
                    { new Guid("ad94f69c-b7e6-419b-bef0-fa50ab04f254"), new TimeSpan(0, 18, 0, 0, 0), "Dream haircuts can come true!", false, "Varna, Bulgaria, ul. Zora 371", "Helita", new TimeSpan(0, 9, 0, 0, 0), "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706708324/cjb6es4kqpy6kukryk8r.jpg", new Guid("b313e2e1-0270-4a86-924b-71256500be8b") },
                    { new Guid("bf2832b2-5b62-471b-9980-583753504ca6"), new TimeSpan(0, 18, 0, 0, 0), "Ina Vasileva's Studio", true, "Varna, Bulgaria, ul. Veles 7", "IN Beauty", new TimeSpan(0, 9, 0, 0, 0), "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706708324/omikwkyqnrafjnju82jf.jpg", new Guid("1674d538-3cf0-4a6e-bc27-aa070a230647") },
                    { new Guid("c7998d5b-0017-4924-8544-49b4a276afe1"), new TimeSpan(0, 18, 0, 0, 0), "Hair Care Studio", true, "Sofia, Bulgaria, ul. Dospat 44", "N-Stage", new TimeSpan(0, 9, 0, 0, 0), "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706708324/ulq1xkktowireigsxuil.jpg", new Guid("1674d538-3cf0-4a6e-bc27-aa070a230647") },
                    { new Guid("d8fbc428-62b8-42aa-b3d7-b40658072dca"), new TimeSpan(0, 18, 0, 0, 0), "Bali&Thai Massages", true, "Sofia, Bulgaria, ul. Aksakov 11", "Arsanta", new TimeSpan(0, 9, 0, 0, 0), "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706708324/sf7gy9cpjrnlkn2ba8rs.jpg", new Guid("b313e2e1-0270-4a86-924b-71256500be8b") },
                    { new Guid("df44a062-9586-4815-8126-99c240433b22"), new TimeSpan(0, 18, 0, 0, 0), "SPA Studio", true, "Sofia, Bulgaria, ul. Erovete 7", "Wellness Center", new TimeSpan(0, 9, 0, 0, 0), "https://res.cloudinary.com/di1lcwb4r/image/upload/v1706708324/wrm1h8b2sfjf06xujkck.jpg", new Guid("1674d538-3cf0-4a6e-bc27-aa070a230647") }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "CategoryId", "Description", "EndDate", "StartDate", "StudioId", "UserId" },
                values: new object[,]
                {
                    { new Guid("1790311d-5712-44a9-abbd-3bfc47802419"), new Guid("4ebb7e23-2a49-4451-8c96-b5c6de99900e"), "Monthly manicure appointment.", new DateTime(2024, 7, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 14, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bf2832b2-5b62-471b-9980-583753504ca6"), new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9") },
                    { new Guid("2220ba4e-0941-4b06-abfa-e36a25ddb881"), new Guid("1125ebe4-4f81-4bb8-90ee-aceaf509c4f3"), "I need care for bleached hair.", new DateTime(2024, 3, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c7998d5b-0017-4924-8544-49b4a276afe1"), new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d") },
                    { new Guid("79e4af3b-6bcf-4476-8705-2457836a1968"), new Guid("569a4a94-57b0-48d3-930c-0d3ca92f7eb8"), "I need a relaxing massage.", new DateTime(2024, 6, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), new Guid("df44a062-9586-4815-8126-99c240433b22"), new Guid("3bea7392-a556-4a99-86c2-8cb244868283") },
                    { new Guid("8180ba4e-0941-4b06-abfa-e36a25ddb881"), new Guid("1125ebe4-4f81-4bb8-90ee-aceaf509c4f3"), "I need care for bleached hair.", new DateTime(2024, 6, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c7998d5b-0017-4924-8544-49b4a276afe1"), new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d") },
                    { new Guid("9b76ada8-1c16-4f05-b308-1c4ff3de137f"), new Guid("db7effe2-16bb-4539-9dec-0bda384b859f"), "I want platinum blond.", new DateTime(2024, 6, 18, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0d753e1d-c98b-47c7-b260-0377048c529a"), new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d") },
                    { new Guid("f1a43f31-6d82-442b-8f89-941f7b6da3ec"), new Guid("db7effe2-16bb-4539-9dec-0bda384b859f"), "I want slight balayage.", new DateTime(2024, 6, 20, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0d753e1d-c98b-47c7-b260-0377048c529a"), new Guid("3bea7392-a556-4a99-86c2-8cb244868283") }
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
                table: "Ratings",
                columns: new[] { "Id", "StudioId", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("168884a2-fc77-4169-836f-dc0a0599bc2e"), new Guid("d8fbc428-62b8-42aa-b3d7-b40658072dca"), new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"), 5 },
                    { new Guid("60502c16-c9bd-4653-94a6-fe623822a42e"), new Guid("0d753e1d-c98b-47c7-b260-0377048c529a"), new Guid("1eb3a2eb-2184-4f8e-8ddd-569ea1522f2b"), 4 },
                    { new Guid("9056efb3-0f7d-4393-bca6-a61c8e92ceb5"), new Guid("c7998d5b-0017-4924-8544-49b4a276afe1"), new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"), 2 },
                    { new Guid("912d1986-7424-43fa-a531-b9d811961386"), new Guid("d8fbc428-62b8-42aa-b3d7-b40658072dca"), new Guid("3bea7392-a556-4a99-86c2-8cb244868283"), 4 },
                    { new Guid("960c4945-0b04-4c40-bd17-c697cb8d5eda"), new Guid("d8fbc428-62b8-42aa-b3d7-b40658072dca"), new Guid("e482292a-5399-4938-9788-6d76fcb1b4d9"), 5 },
                    { new Guid("9f5c4415-ce99-4d50-82cf-43fda2cdb71b"), new Guid("bf2832b2-5b62-471b-9980-583753504ca6"), new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"), 3 },
                    { new Guid("bb10aa9c-da74-4846-a075-7b203f22aefc"), new Guid("0d753e1d-c98b-47c7-b260-0377048c529a"), new Guid("9f9bfaa5-da01-49bf-a819-3b88acf7487f"), 4 },
                    { new Guid("ffd265a7-832d-4fc1-925c-5e72eab2d02e"), new Guid("df44a062-9586-4815-8126-99c240433b22"), new Guid("2fceb9b7-fdd1-4062-b6d4-b81b3d7fd62d"), 4 }
                });

            migrationBuilder.InsertData(
                table: "StudiosCategories",
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
                name: "IX_Studios_UserId",
                table: "Studios",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StudiosCategories_CategoryId",
                table: "StudiosCategories",
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
                name: "Images");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "StudiosCategories");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Publications");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Studios");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
