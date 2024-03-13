using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StarFitApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    illustration_path = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    published = table.Column<bool>(type: "boolean", nullable: false),
                    start_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    end_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SuperUsers",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    username = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "character varying(120)", maxLength: 120, nullable: false),
                    super_role = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperUsers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    identifier = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Badges",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    icon_path = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Badges", x => x.id);
                    table.ForeignKey(
                        name: "FK_Badges_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "DayOfWalk",
                columns: table => new
                {
                    date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    steps = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayOfWalk", x => new { x.date, x.user_id });
                    table.ForeignKey(
                        name: "FK_DayOfWalk_Users_user_id",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BadgesToUser",
                columns: table => new
                {
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    badge_id = table.Column<Guid>(type: "uuid", nullable: false),
                    obtained_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BadgesToUser", x => new { x.user_id, x.badge_id });
                    table.ForeignKey(
                        name: "FK_BadgesToUser_Badges_badge_id",
                        column: x => x.badge_id,
                        principalTable: "Badges",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BadgesToUser_Users_user_id",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Challenges",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    badge_id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    start_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    end_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    is_global = table.Column<bool>(type: "boolean", nullable: false),
                    objective = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Challenges", x => x.id);
                    table.ForeignKey(
                        name: "FK_Challenges_Badges_badge_id",
                        column: x => x.badge_id,
                        principalTable: "Badges",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "id", "created_at", "description", "end_date", "illustration_path", "published", "start_date", "title", "updated_at" },
                values: new object[,]
                {
                    { new Guid("11f93bcb-b527-4cd2-85cc-17e1021a2c63"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9070), "Content 9", null, "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9070), "Article 9", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9070) },
                    { new Guid("1c8715f1-f38b-49b8-be38-5890ab8c0998"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9010), "Content 3", null, "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9010), "Article 3", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9010) },
                    { new Guid("2e944d91-a2a3-4e5d-a682-3ab2233ab000"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9060), "Content 8", null, "https://previews.123rf.com/images/ambro/ambro1112/ambro111200418/11558816-businessman-with-thumbs-up.jpg", true, new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9060), "Article 8", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9060) },
                    { new Guid("4e6bac1c-a423-41ec-90d1-5012f9e83508"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9020), "Content 4", null, "https://thumbs.dreamstime.com/b/bald-man-thumbs-up-26364248.jpg", true, new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9020), "Article 4", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9020) },
                    { new Guid("577d8b53-95b1-40a1-a011-c83808360bbd"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9030), "Content 5", null, "https://previews.123rf.com/images/ambro/ambro1112/ambro111200418/11558816-businessman-with-thumbs-up.jpg", true, new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9030), "Article 5", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9030) },
                    { new Guid("a29cf351-52cc-4a5e-99a5-8cd9dddecc58"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9000), "Content 2", null, "https://previews.123rf.com/images/ambro/ambro1112/ambro111200418/11558816-businessman-with-thumbs-up.jpg", true, new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9000), "Article 2", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9000) },
                    { new Guid("bf18ae5f-ef0b-4bb2-bae6-fb144528832f"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9040), "Content 6", null, "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9040), "Article 6", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9040) },
                    { new Guid("db87c4ca-6d61-41cc-afea-e2c07b008c46"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8990), "Content 1", null, "https://thumbs.dreamstime.com/b/bald-man-thumbs-up-26364248.jpg", true, new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8990), "Article 1", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8990) },
                    { new Guid("dcc02c20-67b6-4d35-b9a8-42d9e359ad33"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8980), "Content 0", null, "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8980), "Article 0", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8980) },
                    { new Guid("f0b6609b-2f1d-41b3-bd50-8f7d66d33733"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9050), "Content 7", null, "https://thumbs.dreamstime.com/b/bald-man-thumbs-up-26364248.jpg", true, new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9050), "Article 7", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9050) }
                });

            migrationBuilder.InsertData(
                table: "Badges",
                columns: new[] { "id", "created_at", "description", "icon_path", "title", "updated_at", "UserId" },
                values: new object[,]
                {
                    { new Guid("0512e283-6301-4b6b-87e4-0871d3346911"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8750), "Content 7", "https://images.rawpixel.com/image_png_800/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvcHUyMzMxNjM5LWltYWdlXzItbDBqOXFvd3IucG5n.png", "Badge 7", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8750), null },
                    { new Guid("0c56fc63-1e71-4d26-8e87-64ab7f116096"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8690), "Content 1", "https://images.rawpixel.com/image_png_800/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvcHUyMzMxNjM5LWltYWdlXzItbDBqOXFvd3IucG5n.png", "Badge 1", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8700), null },
                    { new Guid("1adc6f90-de96-4373-8342-088458e19c5e"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8680), "Content 0", "https://png.pngtree.com/png-vector/20201229/ourmid/pngtree-a-squatting-tabby-cat-png-image_2664942.jpg", "Badge 0", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8690), null },
                    { new Guid("49bf3828-d339-4f20-9c33-48eceac85428"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8720), "Content 4", "https://images.rawpixel.com/image_png_800/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvcHUyMzMxNjM5LWltYWdlXzItbDBqOXFvd3IucG5n.png", "Badge 4", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8720), null },
                    { new Guid("8b536785-8986-41ed-a5fb-a1dae88837c3"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8710), "Content 3", "https://png.pngtree.com/png-vector/20201229/ourmid/pngtree-a-squatting-tabby-cat-png-image_2664942.jpg", "Badge 3", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8710), null },
                    { new Guid("bd8ceb2a-3f75-4a06-8df6-25385262a455"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8740), "Content 6", "https://png.pngtree.com/png-vector/20201229/ourmid/pngtree-a-squatting-tabby-cat-png-image_2664942.jpg", "Badge 6", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8740), null },
                    { new Guid("cf3a156f-9cf2-42c3-8ea7-f1d092fe52b2"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8730), "Content 5", "https://pngimg.com/uploads/cat/cat_PNG50447.png", "Badge 5", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8730), null },
                    { new Guid("d3f8bdbd-ab89-40cd-9724-6b12043e512a"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8760), "Content 8", "https://pngimg.com/uploads/cat/cat_PNG50447.png", "Badge 8", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8760), null },
                    { new Guid("e6d56383-0936-4e04-a231-02edf182dada"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8700), "Content 2", "https://pngimg.com/uploads/cat/cat_PNG50447.png", "Badge 2", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8700), null },
                    { new Guid("fb286aa1-972d-4b8d-84e1-281c54f73fcf"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8770), "Content 9", "https://png.pngtree.com/png-vector/20201229/ourmid/pngtree-a-squatting-tabby-cat-png-image_2664942.jpg", "Badge 9", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8770), null }
                });

            migrationBuilder.InsertData(
                table: "SuperUsers",
                columns: new[] { "id", "created_at", "password", "super_role", "updated_at", "username" },
                values: new object[] { new Guid("c5765917-b495-4d0a-a2f7-eb56522036fd"), new DateTime(2024, 3, 13, 9, 48, 22, 576, DateTimeKind.Local).AddTicks(3080), "$2a$05$CxlBQY4vhezUmKw5lHfsPeU42TDx9OtNyyTYVOevsf7dRz8Yn8Zn6", "superAdmin", new DateTime(2024, 3, 13, 9, 48, 22, 576, DateTimeKind.Local).AddTicks(3090), "superAdmin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "created_at", "identifier", "updated_at" },
                values: new object[,]
                {
                    { new Guid("11dd1bc2-363d-4e68-9bef-46af226bbf46"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8600), "user9", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8600) },
                    { new Guid("134c376e-033c-452b-abbd-d54a8ed44f54"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8540), "user2", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8540) },
                    { new Guid("322e9a8f-6008-4971-a401-fb04501cb095"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8590), "user8", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8590) },
                    { new Guid("4f9ac3bc-3db4-4021-8a6b-32c4b54327c5"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8550), "user3", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8550) },
                    { new Guid("5d9e78bd-4a17-4174-a984-26c58055841b"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8530), "user1", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8530) },
                    { new Guid("662cad55-6988-4ef3-a150-624f02d73106"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8570), "user5", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8570) },
                    { new Guid("80d19d46-a0ce-4a75-8700-b2ab68eeaaad"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8560), "user4", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8560) },
                    { new Guid("8331472e-f25d-4dbc-859a-76da9a5bf793"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8570), "user6", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8580) },
                    { new Guid("e8a8c0e5-9ac7-428c-85c9-fcdcf140b2d4"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8480), "user0", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8520) },
                    { new Guid("fb7c0e1f-2df1-44b9-b3fb-b955368266c0"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8580), "user7", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8580) }
                });

            migrationBuilder.InsertData(
                table: "BadgesToUser",
                columns: new[] { "badge_id", "user_id", "obtained_at" },
                values: new object[,]
                {
                    { new Guid("fb286aa1-972d-4b8d-84e1-281c54f73fcf"), new Guid("11dd1bc2-363d-4e68-9bef-46af226bbf46"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9300) },
                    { new Guid("e6d56383-0936-4e04-a231-02edf182dada"), new Guid("134c376e-033c-452b-abbd-d54a8ed44f54"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9290) },
                    { new Guid("d3f8bdbd-ab89-40cd-9724-6b12043e512a"), new Guid("322e9a8f-6008-4971-a401-fb04501cb095"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9290) },
                    { new Guid("8b536785-8986-41ed-a5fb-a1dae88837c3"), new Guid("4f9ac3bc-3db4-4021-8a6b-32c4b54327c5"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9290) },
                    { new Guid("0c56fc63-1e71-4d26-8e87-64ab7f116096"), new Guid("5d9e78bd-4a17-4174-a984-26c58055841b"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9290) },
                    { new Guid("cf3a156f-9cf2-42c3-8ea7-f1d092fe52b2"), new Guid("662cad55-6988-4ef3-a150-624f02d73106"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9290) },
                    { new Guid("49bf3828-d339-4f20-9c33-48eceac85428"), new Guid("80d19d46-a0ce-4a75-8700-b2ab68eeaaad"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9290) },
                    { new Guid("bd8ceb2a-3f75-4a06-8df6-25385262a455"), new Guid("8331472e-f25d-4dbc-859a-76da9a5bf793"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9290) },
                    { new Guid("1adc6f90-de96-4373-8342-088458e19c5e"), new Guid("e8a8c0e5-9ac7-428c-85c9-fcdcf140b2d4"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9280) },
                    { new Guid("0512e283-6301-4b6b-87e4-0871d3346911"), new Guid("fb7c0e1f-2df1-44b9-b3fb-b955368266c0"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9290) }
                });

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "id", "badge_id", "created_at", "description", "end_date", "is_global", "objective", "start_date", "title", "updated_at" },
                values: new object[,]
                {
                    { new Guid("34e729dd-0d77-4611-9f96-acf0b7287caa"), new Guid("49bf3828-d339-4f20-9c33-48eceac85428"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8890), "Content 4", new DateTime(2024, 4, 12, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8880), true, 15809, new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8880), "Challenge 4", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8890) },
                    { new Guid("4a4704a3-1b91-4993-882f-b829de47ad9b"), new Guid("d3f8bdbd-ab89-40cd-9724-6b12043e512a"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8940), "Content 8", new DateTime(2024, 4, 12, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8940), true, 43218, new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8940), "Challenge 8", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8940) },
                    { new Guid("4ad0f05d-7f92-40b8-964d-8410718d0f00"), new Guid("0c56fc63-1e71-4d26-8e87-64ab7f116096"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8850), "Content 1", new DateTime(2024, 4, 12, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8840), false, 94311, new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8840), "Challenge 1", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8850) },
                    { new Guid("4b74ebaf-b5aa-484b-8eb6-8261efd41a01"), new Guid("fb286aa1-972d-4b8d-84e1-281c54f73fcf"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8950), "Content 9", new DateTime(2024, 4, 12, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8950), false, 38619, new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8950), "Challenge 9", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8950) },
                    { new Guid("a2cd6e40-443d-4c10-9a49-eed2c325e092"), new Guid("bd8ceb2a-3f75-4a06-8df6-25385262a455"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8910), "Content 6", new DateTime(2024, 4, 12, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8910), true, 65913, new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8910), "Challenge 6", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8910) },
                    { new Guid("a80f6d6b-bb43-48c8-861c-a9137329dbbd"), new Guid("cf3a156f-9cf2-42c3-8ea7-f1d092fe52b2"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8900), "Content 5", new DateTime(2024, 4, 12, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8900), false, 85061, new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8900), "Challenge 5", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8900) },
                    { new Guid("bae37000-6739-4937-9af4-674cfc2f33c1"), new Guid("8b536785-8986-41ed-a5fb-a1dae88837c3"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8870), "Content 3", new DateTime(2024, 4, 12, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8870), false, 98278, new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8870), "Challenge 3", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8870) },
                    { new Guid("f3620b92-dd1d-43e9-a3aa-4f8a67d61b9a"), new Guid("1adc6f90-de96-4373-8342-088458e19c5e"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8830), "Content 0", new DateTime(2024, 4, 12, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8820), true, 85228, new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8820), "Challenge 0", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8830) },
                    { new Guid("f897c061-60cc-45b8-8845-18dbbc4c040a"), new Guid("e6d56383-0936-4e04-a231-02edf182dada"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8860), "Content 2", new DateTime(2024, 4, 12, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8860), true, 12246, new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8860), "Challenge 2", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8860) },
                    { new Guid("fc6dbfbf-4274-4421-b5d8-6f71d381ef1c"), new Guid("0512e283-6301-4b6b-87e4-0871d3346911"), new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8930), "Content 7", new DateTime(2024, 4, 12, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8920), false, 83530, new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8920), "Challenge 7", new DateTime(2024, 3, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(8930) }
                });

            migrationBuilder.InsertData(
                table: "DayOfWalk",
                columns: new[] { "date", "user_id", "steps" },
                values: new object[,]
                {
                    { new DateTime(2023, 12, 4, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9090), new Guid("e8a8c0e5-9ac7-428c-85c9-fcdcf140b2d4"), 1000 },
                    { new DateTime(2023, 12, 5, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9090), new Guid("5d9e78bd-4a17-4174-a984-26c58055841b"), 1000 },
                    { new DateTime(2023, 12, 6, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9090), new Guid("134c376e-033c-452b-abbd-d54a8ed44f54"), 1000 },
                    { new DateTime(2023, 12, 7, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9100), new Guid("4f9ac3bc-3db4-4021-8a6b-32c4b54327c5"), 1000 },
                    { new DateTime(2023, 12, 8, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9100), new Guid("80d19d46-a0ce-4a75-8700-b2ab68eeaaad"), 1000 },
                    { new DateTime(2023, 12, 9, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9100), new Guid("662cad55-6988-4ef3-a150-624f02d73106"), 1000 },
                    { new DateTime(2023, 12, 10, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9100), new Guid("8331472e-f25d-4dbc-859a-76da9a5bf793"), 1000 },
                    { new DateTime(2023, 12, 11, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9100), new Guid("fb7c0e1f-2df1-44b9-b3fb-b955368266c0"), 1000 },
                    { new DateTime(2023, 12, 12, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9120), new Guid("322e9a8f-6008-4971-a401-fb04501cb095"), 1000 },
                    { new DateTime(2023, 12, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9120), new Guid("11dd1bc2-363d-4e68-9bef-46af226bbf46"), 1000 },
                    { new DateTime(2023, 12, 14, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9120), new Guid("e8a8c0e5-9ac7-428c-85c9-fcdcf140b2d4"), 1000 },
                    { new DateTime(2023, 12, 15, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9120), new Guid("5d9e78bd-4a17-4174-a984-26c58055841b"), 1000 },
                    { new DateTime(2023, 12, 16, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9130), new Guid("134c376e-033c-452b-abbd-d54a8ed44f54"), 1000 },
                    { new DateTime(2023, 12, 17, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9130), new Guid("4f9ac3bc-3db4-4021-8a6b-32c4b54327c5"), 1000 },
                    { new DateTime(2023, 12, 18, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9130), new Guid("80d19d46-a0ce-4a75-8700-b2ab68eeaaad"), 1000 },
                    { new DateTime(2023, 12, 19, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9130), new Guid("662cad55-6988-4ef3-a150-624f02d73106"), 1000 },
                    { new DateTime(2023, 12, 20, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9130), new Guid("8331472e-f25d-4dbc-859a-76da9a5bf793"), 1000 },
                    { new DateTime(2023, 12, 21, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9130), new Guid("fb7c0e1f-2df1-44b9-b3fb-b955368266c0"), 1000 },
                    { new DateTime(2023, 12, 22, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9130), new Guid("322e9a8f-6008-4971-a401-fb04501cb095"), 1000 },
                    { new DateTime(2023, 12, 23, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9140), new Guid("11dd1bc2-363d-4e68-9bef-46af226bbf46"), 1000 },
                    { new DateTime(2023, 12, 24, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9140), new Guid("e8a8c0e5-9ac7-428c-85c9-fcdcf140b2d4"), 1000 },
                    { new DateTime(2023, 12, 25, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9140), new Guid("5d9e78bd-4a17-4174-a984-26c58055841b"), 1000 },
                    { new DateTime(2023, 12, 26, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9140), new Guid("134c376e-033c-452b-abbd-d54a8ed44f54"), 1000 },
                    { new DateTime(2023, 12, 27, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9140), new Guid("4f9ac3bc-3db4-4021-8a6b-32c4b54327c5"), 1000 },
                    { new DateTime(2023, 12, 28, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9140), new Guid("80d19d46-a0ce-4a75-8700-b2ab68eeaaad"), 1000 },
                    { new DateTime(2023, 12, 29, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9140), new Guid("662cad55-6988-4ef3-a150-624f02d73106"), 1000 },
                    { new DateTime(2023, 12, 30, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9140), new Guid("8331472e-f25d-4dbc-859a-76da9a5bf793"), 1000 },
                    { new DateTime(2023, 12, 31, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9140), new Guid("fb7c0e1f-2df1-44b9-b3fb-b955368266c0"), 1000 },
                    { new DateTime(2024, 1, 1, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9150), new Guid("322e9a8f-6008-4971-a401-fb04501cb095"), 1000 },
                    { new DateTime(2024, 1, 2, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9150), new Guid("11dd1bc2-363d-4e68-9bef-46af226bbf46"), 1000 },
                    { new DateTime(2024, 1, 3, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9150), new Guid("e8a8c0e5-9ac7-428c-85c9-fcdcf140b2d4"), 1000 },
                    { new DateTime(2024, 1, 4, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9150), new Guid("5d9e78bd-4a17-4174-a984-26c58055841b"), 1000 },
                    { new DateTime(2024, 1, 5, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9150), new Guid("134c376e-033c-452b-abbd-d54a8ed44f54"), 1000 },
                    { new DateTime(2024, 1, 6, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9150), new Guid("4f9ac3bc-3db4-4021-8a6b-32c4b54327c5"), 1000 },
                    { new DateTime(2024, 1, 7, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9150), new Guid("80d19d46-a0ce-4a75-8700-b2ab68eeaaad"), 1000 },
                    { new DateTime(2024, 1, 8, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9150), new Guid("662cad55-6988-4ef3-a150-624f02d73106"), 1000 },
                    { new DateTime(2024, 1, 9, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9160), new Guid("8331472e-f25d-4dbc-859a-76da9a5bf793"), 1000 },
                    { new DateTime(2024, 1, 10, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9160), new Guid("fb7c0e1f-2df1-44b9-b3fb-b955368266c0"), 1000 },
                    { new DateTime(2024, 1, 11, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9160), new Guid("322e9a8f-6008-4971-a401-fb04501cb095"), 1000 },
                    { new DateTime(2024, 1, 12, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9160), new Guid("11dd1bc2-363d-4e68-9bef-46af226bbf46"), 1000 },
                    { new DateTime(2024, 1, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9160), new Guid("e8a8c0e5-9ac7-428c-85c9-fcdcf140b2d4"), 1000 },
                    { new DateTime(2024, 1, 14, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9160), new Guid("5d9e78bd-4a17-4174-a984-26c58055841b"), 1000 },
                    { new DateTime(2024, 1, 15, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9160), new Guid("134c376e-033c-452b-abbd-d54a8ed44f54"), 1000 },
                    { new DateTime(2024, 1, 16, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9160), new Guid("4f9ac3bc-3db4-4021-8a6b-32c4b54327c5"), 1000 },
                    { new DateTime(2024, 1, 17, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9160), new Guid("80d19d46-a0ce-4a75-8700-b2ab68eeaaad"), 1000 },
                    { new DateTime(2024, 1, 18, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9170), new Guid("662cad55-6988-4ef3-a150-624f02d73106"), 1000 },
                    { new DateTime(2024, 1, 19, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9170), new Guid("8331472e-f25d-4dbc-859a-76da9a5bf793"), 1000 },
                    { new DateTime(2024, 1, 20, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9170), new Guid("fb7c0e1f-2df1-44b9-b3fb-b955368266c0"), 1000 },
                    { new DateTime(2024, 1, 21, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9170), new Guid("322e9a8f-6008-4971-a401-fb04501cb095"), 1000 },
                    { new DateTime(2024, 1, 22, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9170), new Guid("11dd1bc2-363d-4e68-9bef-46af226bbf46"), 1000 },
                    { new DateTime(2024, 1, 23, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9170), new Guid("e8a8c0e5-9ac7-428c-85c9-fcdcf140b2d4"), 1000 },
                    { new DateTime(2024, 1, 24, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9170), new Guid("5d9e78bd-4a17-4174-a984-26c58055841b"), 1000 },
                    { new DateTime(2024, 1, 25, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9170), new Guid("134c376e-033c-452b-abbd-d54a8ed44f54"), 1000 },
                    { new DateTime(2024, 1, 26, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9180), new Guid("4f9ac3bc-3db4-4021-8a6b-32c4b54327c5"), 1000 },
                    { new DateTime(2024, 1, 27, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9180), new Guid("80d19d46-a0ce-4a75-8700-b2ab68eeaaad"), 1000 },
                    { new DateTime(2024, 1, 28, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9180), new Guid("662cad55-6988-4ef3-a150-624f02d73106"), 1000 },
                    { new DateTime(2024, 1, 29, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9180), new Guid("8331472e-f25d-4dbc-859a-76da9a5bf793"), 1000 },
                    { new DateTime(2024, 1, 30, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9180), new Guid("fb7c0e1f-2df1-44b9-b3fb-b955368266c0"), 1000 },
                    { new DateTime(2024, 1, 31, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9180), new Guid("322e9a8f-6008-4971-a401-fb04501cb095"), 1000 },
                    { new DateTime(2024, 2, 1, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9180), new Guid("11dd1bc2-363d-4e68-9bef-46af226bbf46"), 1000 },
                    { new DateTime(2024, 2, 2, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9180), new Guid("e8a8c0e5-9ac7-428c-85c9-fcdcf140b2d4"), 1000 },
                    { new DateTime(2024, 2, 3, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9180), new Guid("5d9e78bd-4a17-4174-a984-26c58055841b"), 1000 },
                    { new DateTime(2024, 2, 4, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9190), new Guid("134c376e-033c-452b-abbd-d54a8ed44f54"), 1000 },
                    { new DateTime(2024, 2, 5, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9190), new Guid("4f9ac3bc-3db4-4021-8a6b-32c4b54327c5"), 1000 },
                    { new DateTime(2024, 2, 6, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9190), new Guid("80d19d46-a0ce-4a75-8700-b2ab68eeaaad"), 1000 },
                    { new DateTime(2024, 2, 7, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9190), new Guid("662cad55-6988-4ef3-a150-624f02d73106"), 1000 },
                    { new DateTime(2024, 2, 8, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9190), new Guid("8331472e-f25d-4dbc-859a-76da9a5bf793"), 1000 },
                    { new DateTime(2024, 2, 9, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9190), new Guid("fb7c0e1f-2df1-44b9-b3fb-b955368266c0"), 1000 },
                    { new DateTime(2024, 2, 10, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9190), new Guid("322e9a8f-6008-4971-a401-fb04501cb095"), 1000 },
                    { new DateTime(2024, 2, 11, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9190), new Guid("11dd1bc2-363d-4e68-9bef-46af226bbf46"), 1000 },
                    { new DateTime(2024, 2, 12, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9200), new Guid("e8a8c0e5-9ac7-428c-85c9-fcdcf140b2d4"), 1000 },
                    { new DateTime(2024, 2, 13, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9200), new Guid("5d9e78bd-4a17-4174-a984-26c58055841b"), 1000 },
                    { new DateTime(2024, 2, 14, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9200), new Guid("134c376e-033c-452b-abbd-d54a8ed44f54"), 1000 },
                    { new DateTime(2024, 2, 15, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9200), new Guid("4f9ac3bc-3db4-4021-8a6b-32c4b54327c5"), 1000 },
                    { new DateTime(2024, 2, 16, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9200), new Guid("80d19d46-a0ce-4a75-8700-b2ab68eeaaad"), 1000 },
                    { new DateTime(2024, 2, 17, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9200), new Guid("662cad55-6988-4ef3-a150-624f02d73106"), 1000 },
                    { new DateTime(2024, 2, 18, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9200), new Guid("8331472e-f25d-4dbc-859a-76da9a5bf793"), 1000 },
                    { new DateTime(2024, 2, 19, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9200), new Guid("fb7c0e1f-2df1-44b9-b3fb-b955368266c0"), 1000 },
                    { new DateTime(2024, 2, 20, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9210), new Guid("322e9a8f-6008-4971-a401-fb04501cb095"), 1000 },
                    { new DateTime(2024, 2, 21, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9210), new Guid("11dd1bc2-363d-4e68-9bef-46af226bbf46"), 1000 },
                    { new DateTime(2024, 2, 22, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9210), new Guid("e8a8c0e5-9ac7-428c-85c9-fcdcf140b2d4"), 1000 },
                    { new DateTime(2024, 2, 23, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9210), new Guid("5d9e78bd-4a17-4174-a984-26c58055841b"), 1000 },
                    { new DateTime(2024, 2, 24, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9210), new Guid("134c376e-033c-452b-abbd-d54a8ed44f54"), 1000 },
                    { new DateTime(2024, 2, 25, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9210), new Guid("4f9ac3bc-3db4-4021-8a6b-32c4b54327c5"), 1000 },
                    { new DateTime(2024, 2, 26, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9210), new Guid("80d19d46-a0ce-4a75-8700-b2ab68eeaaad"), 1000 },
                    { new DateTime(2024, 2, 27, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9210), new Guid("662cad55-6988-4ef3-a150-624f02d73106"), 1000 },
                    { new DateTime(2024, 2, 28, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9210), new Guid("8331472e-f25d-4dbc-859a-76da9a5bf793"), 1000 },
                    { new DateTime(2024, 2, 29, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9220), new Guid("fb7c0e1f-2df1-44b9-b3fb-b955368266c0"), 1000 },
                    { new DateTime(2024, 3, 1, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9220), new Guid("322e9a8f-6008-4971-a401-fb04501cb095"), 1000 },
                    { new DateTime(2024, 3, 2, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9220), new Guid("11dd1bc2-363d-4e68-9bef-46af226bbf46"), 1000 },
                    { new DateTime(2024, 3, 3, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9220), new Guid("e8a8c0e5-9ac7-428c-85c9-fcdcf140b2d4"), 1000 },
                    { new DateTime(2024, 3, 4, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9220), new Guid("5d9e78bd-4a17-4174-a984-26c58055841b"), 1000 },
                    { new DateTime(2024, 3, 5, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9220), new Guid("134c376e-033c-452b-abbd-d54a8ed44f54"), 1000 },
                    { new DateTime(2024, 3, 6, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9220), new Guid("4f9ac3bc-3db4-4021-8a6b-32c4b54327c5"), 1000 },
                    { new DateTime(2024, 3, 7, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9220), new Guid("80d19d46-a0ce-4a75-8700-b2ab68eeaaad"), 1000 },
                    { new DateTime(2024, 3, 8, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9230), new Guid("662cad55-6988-4ef3-a150-624f02d73106"), 1000 },
                    { new DateTime(2024, 3, 9, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9230), new Guid("8331472e-f25d-4dbc-859a-76da9a5bf793"), 1000 },
                    { new DateTime(2024, 3, 10, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9230), new Guid("fb7c0e1f-2df1-44b9-b3fb-b955368266c0"), 1000 },
                    { new DateTime(2024, 3, 11, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9230), new Guid("322e9a8f-6008-4971-a401-fb04501cb095"), 1000 },
                    { new DateTime(2024, 3, 12, 9, 48, 22, 572, DateTimeKind.Local).AddTicks(9230), new Guid("11dd1bc2-363d-4e68-9bef-46af226bbf46"), 1000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Badges_UserId",
                table: "Badges",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BadgesToUser_badge_id",
                table: "BadgesToUser",
                column: "badge_id");

            migrationBuilder.CreateIndex(
                name: "IX_Challenges_badge_id",
                table: "Challenges",
                column: "badge_id");

            migrationBuilder.CreateIndex(
                name: "IX_DayOfWalk_user_id",
                table: "DayOfWalk",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_SuperUsers_username",
                table: "SuperUsers",
                column: "username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_identifier",
                table: "Users",
                column: "identifier",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "BadgesToUser");

            migrationBuilder.DropTable(
                name: "Challenges");

            migrationBuilder.DropTable(
                name: "DayOfWalk");

            migrationBuilder.DropTable(
                name: "SuperUsers");

            migrationBuilder.DropTable(
                name: "Badges");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
