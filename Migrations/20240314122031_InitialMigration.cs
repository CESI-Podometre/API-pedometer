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
                    file_path = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
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
                columns: new[] { "id", "created_at", "description", "end_date", "file_path", "illustration_path", "published", "start_date", "title", "updated_at" },
                values: new object[,]
                {
                    { new Guid("39667f57-4037-42c7-ab8f-3a474d57a62a"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9330), "Content 1", null, "https://organzo.ca/wp-content/uploads/2013/05/FR_eggplant.pdf", "https://thumbs.dreamstime.com/b/bald-man-thumbs-up-26364248.jpg", true, new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9330), "Article 1", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9330) },
                    { new Guid("39bd6d10-4783-4c81-b122-cc8326004e5b"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9350), "Content 3", null, "https://lyc-jules-ferry.fr/wp-content/uploads/2021/03/6Cadavre-exquis-ecrit-2.pdf", "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9350), "Article 3", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9350) },
                    { new Guid("507ef10b-2b2f-48b2-a049-0efad5379fe1"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9400), "Content 9", null, "https://lyc-jules-ferry.fr/wp-content/uploads/2021/03/6Cadavre-exquis-ecrit-2.pdf", "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9400), "Article 9", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9400) },
                    { new Guid("5ce64891-96ff-4dc3-b70a-1d377c376804"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9350), "Content 4", null, "https://organzo.ca/wp-content/uploads/2013/05/FR_eggplant.pdf", "https://thumbs.dreamstime.com/b/bald-man-thumbs-up-26364248.jpg", true, new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9350), "Article 4", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9360) },
                    { new Guid("700a2332-3789-4b89-9d3f-e4883cef55ce"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9360), "Content 5", null, "https://www.icao.int/WACAF/Documents/Meetings/2015/Surveillance%20h%C3%A9listations/1.2%20Technique%20de%20l%27h%C3%A9licopt%C3%A8re.pdf", "https://previews.123rf.com/images/ambro/ambro1112/ambro111200418/11558816-businessman-with-thumbs-up.jpg", true, new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9360), "Article 5", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9360) },
                    { new Guid("a3526366-8fa6-4347-ba6f-9c5e4c6c2a0b"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9370), "Content 6", null, "https://lyc-jules-ferry.fr/wp-content/uploads/2021/03/6Cadavre-exquis-ecrit-2.pdf", "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9370), "Article 6", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9370) },
                    { new Guid("aa0dccf9-583e-47c3-8aa9-f1018c8590ef"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9390), "Content 8", null, "https://www.icao.int/WACAF/Documents/Meetings/2015/Surveillance%20h%C3%A9listations/1.2%20Technique%20de%20l%27h%C3%A9licopt%C3%A8re.pdf", "https://previews.123rf.com/images/ambro/ambro1112/ambro111200418/11558816-businessman-with-thumbs-up.jpg", true, new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9390), "Article 8", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9390) },
                    { new Guid("d228e337-3a72-4020-b1a0-2ca46a20a18d"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9380), "Content 7", null, "https://organzo.ca/wp-content/uploads/2013/05/FR_eggplant.pdf", "https://thumbs.dreamstime.com/b/bald-man-thumbs-up-26364248.jpg", true, new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9380), "Article 7", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9380) },
                    { new Guid("fc9aa619-755f-42bb-b17a-ba36d4c31a0a"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9320), "Content 0", null, "https://lyc-jules-ferry.fr/wp-content/uploads/2021/03/6Cadavre-exquis-ecrit-2.pdf", "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9320), "Article 0", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9320) },
                    { new Guid("fd4d18fc-cb89-4653-be13-d1f8d0ac8586"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9340), "Content 2", null, "https://www.icao.int/WACAF/Documents/Meetings/2015/Surveillance%20h%C3%A9listations/1.2%20Technique%20de%20l%27h%C3%A9licopt%C3%A8re.pdf", "https://previews.123rf.com/images/ambro/ambro1112/ambro111200418/11558816-businessman-with-thumbs-up.jpg", true, new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9340), "Article 2", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9340) }
                });

            migrationBuilder.InsertData(
                table: "Badges",
                columns: new[] { "id", "created_at", "description", "icon_path", "title", "updated_at", "UserId" },
                values: new object[,]
                {
                    { new Guid("0d38dca0-9eef-4773-93c7-28df526522e1"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9050), "Content 6", "https://png.pngtree.com/png-vector/20201229/ourmid/pngtree-a-squatting-tabby-cat-png-image_2664942.jpg", "Badge 6", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9050), null },
                    { new Guid("1e79fa82-5e4e-4df5-8d9d-20b5e5009e9a"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9030), "Content 4", "https://images.rawpixel.com/image_png_800/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvcHUyMzMxNjM5LWltYWdlXzItbDBqOXFvd3IucG5n.png", "Badge 4", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9030), null },
                    { new Guid("572f8398-10e2-45c4-b833-e90ac3762d05"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9010), "Content 1", "https://images.rawpixel.com/image_png_800/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvcHUyMzMxNjM5LWltYWdlXzItbDBqOXFvd3IucG5n.png", "Badge 1", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9010), null },
                    { new Guid("604f0c91-5c81-4940-8181-3a9f6ffa4a24"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9020), "Content 2", "https://pngimg.com/uploads/cat/cat_PNG50447.png", "Badge 2", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9020), null },
                    { new Guid("869c6c62-be8a-4a25-bdf7-25a389e58175"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9000), "Content 0", "https://png.pngtree.com/png-vector/20201229/ourmid/pngtree-a-squatting-tabby-cat-png-image_2664942.jpg", "Badge 0", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9000), null },
                    { new Guid("9a8244c8-b88c-4204-a4f3-a103fa2d83f0"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9020), "Content 3", "https://png.pngtree.com/png-vector/20201229/ourmid/pngtree-a-squatting-tabby-cat-png-image_2664942.jpg", "Badge 3", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9020), null },
                    { new Guid("9bc51a82-fd3f-4c7b-a9f0-90e4ff8f63aa"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9040), "Content 5", "https://pngimg.com/uploads/cat/cat_PNG50447.png", "Badge 5", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9040), null },
                    { new Guid("b5c0f1d8-4159-4c19-ab8f-9beabc77c437"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9060), "Content 7", "https://images.rawpixel.com/image_png_800/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvcHUyMzMxNjM5LWltYWdlXzItbDBqOXFvd3IucG5n.png", "Badge 7", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9060), null },
                    { new Guid("ccf67717-15f2-4d88-ad2c-35ac438a790e"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9070), "Content 9", "https://png.pngtree.com/png-vector/20201229/ourmid/pngtree-a-squatting-tabby-cat-png-image_2664942.jpg", "Badge 9", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9070), null },
                    { new Guid("ce63f9e8-7c52-4065-9a5f-54793840d309"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9060), "Content 8", "https://pngimg.com/uploads/cat/cat_PNG50447.png", "Badge 8", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9070), null }
                });

            migrationBuilder.InsertData(
                table: "SuperUsers",
                columns: new[] { "id", "created_at", "password", "super_role", "updated_at", "username" },
                values: new object[] { new Guid("30e5af02-7e72-43f8-916e-405083629ba8"), new DateTime(2024, 3, 14, 13, 20, 31, 235, DateTimeKind.Local).AddTicks(3400), "$2a$05$JM/RNqZoQtw7a336B.Zj9uX2uBHf0rC3uuWq8uo5MdY0lBa.HSpe2", "superAdmin", new DateTime(2024, 3, 14, 13, 20, 31, 235, DateTimeKind.Local).AddTicks(3410), "superAdmin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "created_at", "identifier", "updated_at" },
                values: new object[,]
                {
                    { new Guid("62888c3c-bdbe-4f38-8ddd-4aad542b5343"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(8890), "user5", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(8890) },
                    { new Guid("65892d8c-be91-4bf0-afd4-753715e49bfe"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(8810), "user0", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(8840) },
                    { new Guid("7e3f0fa0-a9f6-4a7e-81cc-1af71768cf5a"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(8860), "user2", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(8860) },
                    { new Guid("a61d4bd2-0b4c-4255-9643-a98a934f4fd9"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(8910), "user8", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(8910) },
                    { new Guid("aa2d1d4e-a1e9-4622-b7ec-2974ea4d7f88"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(8920), "user9", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(8920) },
                    { new Guid("b12707e1-0825-4f28-a393-baead7b33cbd"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(8890), "user6", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(8900) },
                    { new Guid("cb30ba49-7982-46fb-95a7-35331c531752"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(8850), "user1", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(8860) },
                    { new Guid("cb54e72f-3b57-4911-8247-f7479172598e"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(8900), "user7", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(8900) },
                    { new Guid("f4dd1a74-89f9-40f6-830c-a3ed1fd87000"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(8880), "user4", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(8880) },
                    { new Guid("f6471fd8-80df-4ced-b8bd-83a69ae8db25"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(8870), "user3", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(8870) }
                });

            migrationBuilder.InsertData(
                table: "BadgesToUser",
                columns: new[] { "badge_id", "user_id", "obtained_at" },
                values: new object[,]
                {
                    { new Guid("9bc51a82-fd3f-4c7b-a9f0-90e4ff8f63aa"), new Guid("62888c3c-bdbe-4f38-8ddd-4aad542b5343"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9590) },
                    { new Guid("869c6c62-be8a-4a25-bdf7-25a389e58175"), new Guid("65892d8c-be91-4bf0-afd4-753715e49bfe"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9570) },
                    { new Guid("604f0c91-5c81-4940-8181-3a9f6ffa4a24"), new Guid("7e3f0fa0-a9f6-4a7e-81cc-1af71768cf5a"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9570) },
                    { new Guid("ce63f9e8-7c52-4065-9a5f-54793840d309"), new Guid("a61d4bd2-0b4c-4255-9643-a98a934f4fd9"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9600) },
                    { new Guid("ccf67717-15f2-4d88-ad2c-35ac438a790e"), new Guid("aa2d1d4e-a1e9-4622-b7ec-2974ea4d7f88"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9600) },
                    { new Guid("0d38dca0-9eef-4773-93c7-28df526522e1"), new Guid("b12707e1-0825-4f28-a393-baead7b33cbd"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9590) },
                    { new Guid("572f8398-10e2-45c4-b833-e90ac3762d05"), new Guid("cb30ba49-7982-46fb-95a7-35331c531752"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9570) },
                    { new Guid("b5c0f1d8-4159-4c19-ab8f-9beabc77c437"), new Guid("cb54e72f-3b57-4911-8247-f7479172598e"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9600) },
                    { new Guid("1e79fa82-5e4e-4df5-8d9d-20b5e5009e9a"), new Guid("f4dd1a74-89f9-40f6-830c-a3ed1fd87000"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9590) },
                    { new Guid("9a8244c8-b88c-4204-a4f3-a103fa2d83f0"), new Guid("f6471fd8-80df-4ced-b8bd-83a69ae8db25"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9580) }
                });

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "id", "badge_id", "created_at", "description", "end_date", "is_global", "objective", "start_date", "title", "updated_at" },
                values: new object[,]
                {
                    { new Guid("13c5a2cf-393a-4dce-8cf4-79f36d93b867"), new Guid("604f0c91-5c81-4940-8181-3a9f6ffa4a24"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9200), "Content 2", new DateTime(2024, 4, 13, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9200), true, 50773, new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9200), "Challenge 2", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9200) },
                    { new Guid("2c75963c-ce6a-4773-af9d-0c579652e8d1"), new Guid("1e79fa82-5e4e-4df5-8d9d-20b5e5009e9a"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9220), "Content 4", new DateTime(2024, 4, 13, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9220), true, 84787, new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9220), "Challenge 4", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9230) },
                    { new Guid("2e9c76a8-6910-4e19-ab27-ddb31e4bdc34"), new Guid("9bc51a82-fd3f-4c7b-a9f0-90e4ff8f63aa"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9240), "Content 5", new DateTime(2024, 4, 13, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9240), false, 44267, new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9240), "Challenge 5", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9240) },
                    { new Guid("3aa5fda0-5981-40fd-9f64-17a868e97f94"), new Guid("0d38dca0-9eef-4773-93c7-28df526522e1"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9250), "Content 6", new DateTime(2024, 4, 13, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9250), true, 70368, new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9250), "Challenge 6", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9250) },
                    { new Guid("53e680e6-ba9d-422e-bb39-534f43231dcc"), new Guid("ce63f9e8-7c52-4065-9a5f-54793840d309"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9270), "Content 8", new DateTime(2024, 4, 13, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9270), true, 40380, new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9270), "Challenge 8", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9270) },
                    { new Guid("588e0c6e-710e-485f-9257-8d5575c05dfd"), new Guid("9a8244c8-b88c-4204-a4f3-a103fa2d83f0"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9210), "Content 3", new DateTime(2024, 4, 13, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9210), false, 94919, new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9210), "Challenge 3", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9210) },
                    { new Guid("809ef97f-1316-4890-9400-2dba94cdce40"), new Guid("572f8398-10e2-45c4-b833-e90ac3762d05"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9140), "Content 1", new DateTime(2024, 4, 13, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9140), false, 2345, new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9140), "Challenge 1", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9140) },
                    { new Guid("a73517d3-987d-4b66-bb9c-6608b6631f73"), new Guid("b5c0f1d8-4159-4c19-ab8f-9beabc77c437"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9260), "Content 7", new DateTime(2024, 4, 13, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9260), false, 99167, new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9260), "Challenge 7", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9260) },
                    { new Guid("b1bbbb09-ab8c-4d2e-933d-004d91d2271e"), new Guid("869c6c62-be8a-4a25-bdf7-25a389e58175"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9130), "Content 0", new DateTime(2024, 4, 13, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9120), true, 51147, new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9120), "Challenge 0", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9130) },
                    { new Guid("ef583f87-01b6-4f21-96a3-0664e51f182b"), new Guid("ccf67717-15f2-4d88-ad2c-35ac438a790e"), new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9290), "Content 9", new DateTime(2024, 4, 13, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9290), false, 75817, new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9280), "Challenge 9", new DateTime(2024, 3, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9290) }
                });

            migrationBuilder.InsertData(
                table: "DayOfWalk",
                columns: new[] { "date", "user_id", "steps" },
                values: new object[,]
                {
                    { new DateTime(2023, 12, 5, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9420), new Guid("65892d8c-be91-4bf0-afd4-753715e49bfe"), 1000 },
                    { new DateTime(2023, 12, 6, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9420), new Guid("cb30ba49-7982-46fb-95a7-35331c531752"), 1000 },
                    { new DateTime(2023, 12, 7, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9430), new Guid("7e3f0fa0-a9f6-4a7e-81cc-1af71768cf5a"), 1000 },
                    { new DateTime(2023, 12, 8, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9430), new Guid("f6471fd8-80df-4ced-b8bd-83a69ae8db25"), 1000 },
                    { new DateTime(2023, 12, 9, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9430), new Guid("f4dd1a74-89f9-40f6-830c-a3ed1fd87000"), 1000 },
                    { new DateTime(2023, 12, 10, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9430), new Guid("62888c3c-bdbe-4f38-8ddd-4aad542b5343"), 1000 },
                    { new DateTime(2023, 12, 11, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9430), new Guid("b12707e1-0825-4f28-a393-baead7b33cbd"), 1000 },
                    { new DateTime(2023, 12, 12, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9430), new Guid("cb54e72f-3b57-4911-8247-f7479172598e"), 1000 },
                    { new DateTime(2023, 12, 13, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9430), new Guid("a61d4bd2-0b4c-4255-9643-a98a934f4fd9"), 1000 },
                    { new DateTime(2023, 12, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9430), new Guid("aa2d1d4e-a1e9-4622-b7ec-2974ea4d7f88"), 1000 },
                    { new DateTime(2023, 12, 15, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9430), new Guid("65892d8c-be91-4bf0-afd4-753715e49bfe"), 1000 },
                    { new DateTime(2023, 12, 16, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9440), new Guid("cb30ba49-7982-46fb-95a7-35331c531752"), 1000 },
                    { new DateTime(2023, 12, 17, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9440), new Guid("7e3f0fa0-a9f6-4a7e-81cc-1af71768cf5a"), 1000 },
                    { new DateTime(2023, 12, 18, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9440), new Guid("f6471fd8-80df-4ced-b8bd-83a69ae8db25"), 1000 },
                    { new DateTime(2023, 12, 19, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9440), new Guid("f4dd1a74-89f9-40f6-830c-a3ed1fd87000"), 1000 },
                    { new DateTime(2023, 12, 20, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9440), new Guid("62888c3c-bdbe-4f38-8ddd-4aad542b5343"), 1000 },
                    { new DateTime(2023, 12, 21, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9440), new Guid("b12707e1-0825-4f28-a393-baead7b33cbd"), 1000 },
                    { new DateTime(2023, 12, 22, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9440), new Guid("cb54e72f-3b57-4911-8247-f7479172598e"), 1000 },
                    { new DateTime(2023, 12, 23, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9440), new Guid("a61d4bd2-0b4c-4255-9643-a98a934f4fd9"), 1000 },
                    { new DateTime(2023, 12, 24, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9440), new Guid("aa2d1d4e-a1e9-4622-b7ec-2974ea4d7f88"), 1000 },
                    { new DateTime(2023, 12, 25, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9440), new Guid("65892d8c-be91-4bf0-afd4-753715e49bfe"), 1000 },
                    { new DateTime(2023, 12, 26, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9450), new Guid("cb30ba49-7982-46fb-95a7-35331c531752"), 1000 },
                    { new DateTime(2023, 12, 27, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9450), new Guid("7e3f0fa0-a9f6-4a7e-81cc-1af71768cf5a"), 1000 },
                    { new DateTime(2023, 12, 28, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9450), new Guid("f6471fd8-80df-4ced-b8bd-83a69ae8db25"), 1000 },
                    { new DateTime(2023, 12, 29, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9450), new Guid("f4dd1a74-89f9-40f6-830c-a3ed1fd87000"), 1000 },
                    { new DateTime(2023, 12, 30, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9450), new Guid("62888c3c-bdbe-4f38-8ddd-4aad542b5343"), 1000 },
                    { new DateTime(2023, 12, 31, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9450), new Guid("b12707e1-0825-4f28-a393-baead7b33cbd"), 1000 },
                    { new DateTime(2024, 1, 1, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9450), new Guid("cb54e72f-3b57-4911-8247-f7479172598e"), 1000 },
                    { new DateTime(2024, 1, 2, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9450), new Guid("a61d4bd2-0b4c-4255-9643-a98a934f4fd9"), 1000 },
                    { new DateTime(2024, 1, 3, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9450), new Guid("aa2d1d4e-a1e9-4622-b7ec-2974ea4d7f88"), 1000 },
                    { new DateTime(2024, 1, 4, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9450), new Guid("65892d8c-be91-4bf0-afd4-753715e49bfe"), 1000 },
                    { new DateTime(2024, 1, 5, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9450), new Guid("cb30ba49-7982-46fb-95a7-35331c531752"), 1000 },
                    { new DateTime(2024, 1, 6, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9460), new Guid("7e3f0fa0-a9f6-4a7e-81cc-1af71768cf5a"), 1000 },
                    { new DateTime(2024, 1, 7, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9460), new Guid("f6471fd8-80df-4ced-b8bd-83a69ae8db25"), 1000 },
                    { new DateTime(2024, 1, 8, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9460), new Guid("f4dd1a74-89f9-40f6-830c-a3ed1fd87000"), 1000 },
                    { new DateTime(2024, 1, 9, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9460), new Guid("62888c3c-bdbe-4f38-8ddd-4aad542b5343"), 1000 },
                    { new DateTime(2024, 1, 10, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9460), new Guid("b12707e1-0825-4f28-a393-baead7b33cbd"), 1000 },
                    { new DateTime(2024, 1, 11, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9460), new Guid("cb54e72f-3b57-4911-8247-f7479172598e"), 1000 },
                    { new DateTime(2024, 1, 12, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9460), new Guid("a61d4bd2-0b4c-4255-9643-a98a934f4fd9"), 1000 },
                    { new DateTime(2024, 1, 13, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9460), new Guid("aa2d1d4e-a1e9-4622-b7ec-2974ea4d7f88"), 1000 },
                    { new DateTime(2024, 1, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9470), new Guid("65892d8c-be91-4bf0-afd4-753715e49bfe"), 1000 },
                    { new DateTime(2024, 1, 15, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9470), new Guid("cb30ba49-7982-46fb-95a7-35331c531752"), 1000 },
                    { new DateTime(2024, 1, 16, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9470), new Guid("7e3f0fa0-a9f6-4a7e-81cc-1af71768cf5a"), 1000 },
                    { new DateTime(2024, 1, 17, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9470), new Guid("f6471fd8-80df-4ced-b8bd-83a69ae8db25"), 1000 },
                    { new DateTime(2024, 1, 18, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9470), new Guid("f4dd1a74-89f9-40f6-830c-a3ed1fd87000"), 1000 },
                    { new DateTime(2024, 1, 19, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9470), new Guid("62888c3c-bdbe-4f38-8ddd-4aad542b5343"), 1000 },
                    { new DateTime(2024, 1, 20, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9470), new Guid("b12707e1-0825-4f28-a393-baead7b33cbd"), 1000 },
                    { new DateTime(2024, 1, 21, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9470), new Guid("cb54e72f-3b57-4911-8247-f7479172598e"), 1000 },
                    { new DateTime(2024, 1, 22, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9470), new Guid("a61d4bd2-0b4c-4255-9643-a98a934f4fd9"), 1000 },
                    { new DateTime(2024, 1, 23, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9470), new Guid("aa2d1d4e-a1e9-4622-b7ec-2974ea4d7f88"), 1000 },
                    { new DateTime(2024, 1, 24, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9480), new Guid("65892d8c-be91-4bf0-afd4-753715e49bfe"), 1000 },
                    { new DateTime(2024, 1, 25, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9480), new Guid("cb30ba49-7982-46fb-95a7-35331c531752"), 1000 },
                    { new DateTime(2024, 1, 26, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9480), new Guid("7e3f0fa0-a9f6-4a7e-81cc-1af71768cf5a"), 1000 },
                    { new DateTime(2024, 1, 27, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9480), new Guid("f6471fd8-80df-4ced-b8bd-83a69ae8db25"), 1000 },
                    { new DateTime(2024, 1, 28, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9480), new Guid("f4dd1a74-89f9-40f6-830c-a3ed1fd87000"), 1000 },
                    { new DateTime(2024, 1, 29, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9480), new Guid("62888c3c-bdbe-4f38-8ddd-4aad542b5343"), 1000 },
                    { new DateTime(2024, 1, 30, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9480), new Guid("b12707e1-0825-4f28-a393-baead7b33cbd"), 1000 },
                    { new DateTime(2024, 1, 31, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9480), new Guid("cb54e72f-3b57-4911-8247-f7479172598e"), 1000 },
                    { new DateTime(2024, 2, 1, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9480), new Guid("a61d4bd2-0b4c-4255-9643-a98a934f4fd9"), 1000 },
                    { new DateTime(2024, 2, 2, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9480), new Guid("aa2d1d4e-a1e9-4622-b7ec-2974ea4d7f88"), 1000 },
                    { new DateTime(2024, 2, 3, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9480), new Guid("65892d8c-be91-4bf0-afd4-753715e49bfe"), 1000 },
                    { new DateTime(2024, 2, 4, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9490), new Guid("cb30ba49-7982-46fb-95a7-35331c531752"), 1000 },
                    { new DateTime(2024, 2, 5, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9490), new Guid("7e3f0fa0-a9f6-4a7e-81cc-1af71768cf5a"), 1000 },
                    { new DateTime(2024, 2, 6, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9490), new Guid("f6471fd8-80df-4ced-b8bd-83a69ae8db25"), 1000 },
                    { new DateTime(2024, 2, 7, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9490), new Guid("f4dd1a74-89f9-40f6-830c-a3ed1fd87000"), 1000 },
                    { new DateTime(2024, 2, 8, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9490), new Guid("62888c3c-bdbe-4f38-8ddd-4aad542b5343"), 1000 },
                    { new DateTime(2024, 2, 9, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9490), new Guid("b12707e1-0825-4f28-a393-baead7b33cbd"), 1000 },
                    { new DateTime(2024, 2, 10, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9490), new Guid("cb54e72f-3b57-4911-8247-f7479172598e"), 1000 },
                    { new DateTime(2024, 2, 11, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9490), new Guid("a61d4bd2-0b4c-4255-9643-a98a934f4fd9"), 1000 },
                    { new DateTime(2024, 2, 12, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9490), new Guid("aa2d1d4e-a1e9-4622-b7ec-2974ea4d7f88"), 1000 },
                    { new DateTime(2024, 2, 13, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9490), new Guid("65892d8c-be91-4bf0-afd4-753715e49bfe"), 1000 },
                    { new DateTime(2024, 2, 14, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9500), new Guid("cb30ba49-7982-46fb-95a7-35331c531752"), 1000 },
                    { new DateTime(2024, 2, 15, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9500), new Guid("7e3f0fa0-a9f6-4a7e-81cc-1af71768cf5a"), 1000 },
                    { new DateTime(2024, 2, 16, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9500), new Guid("f6471fd8-80df-4ced-b8bd-83a69ae8db25"), 1000 },
                    { new DateTime(2024, 2, 17, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9500), new Guid("f4dd1a74-89f9-40f6-830c-a3ed1fd87000"), 1000 },
                    { new DateTime(2024, 2, 18, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9500), new Guid("62888c3c-bdbe-4f38-8ddd-4aad542b5343"), 1000 },
                    { new DateTime(2024, 2, 19, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9500), new Guid("b12707e1-0825-4f28-a393-baead7b33cbd"), 1000 },
                    { new DateTime(2024, 2, 20, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9500), new Guid("cb54e72f-3b57-4911-8247-f7479172598e"), 1000 },
                    { new DateTime(2024, 2, 21, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9500), new Guid("a61d4bd2-0b4c-4255-9643-a98a934f4fd9"), 1000 },
                    { new DateTime(2024, 2, 22, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9500), new Guid("aa2d1d4e-a1e9-4622-b7ec-2974ea4d7f88"), 1000 },
                    { new DateTime(2024, 2, 23, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9500), new Guid("65892d8c-be91-4bf0-afd4-753715e49bfe"), 1000 },
                    { new DateTime(2024, 2, 24, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9500), new Guid("cb30ba49-7982-46fb-95a7-35331c531752"), 1000 },
                    { new DateTime(2024, 2, 25, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9510), new Guid("7e3f0fa0-a9f6-4a7e-81cc-1af71768cf5a"), 1000 },
                    { new DateTime(2024, 2, 26, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9510), new Guid("f6471fd8-80df-4ced-b8bd-83a69ae8db25"), 1000 },
                    { new DateTime(2024, 2, 27, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9510), new Guid("f4dd1a74-89f9-40f6-830c-a3ed1fd87000"), 1000 },
                    { new DateTime(2024, 2, 28, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9510), new Guid("62888c3c-bdbe-4f38-8ddd-4aad542b5343"), 1000 },
                    { new DateTime(2024, 2, 29, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9510), new Guid("b12707e1-0825-4f28-a393-baead7b33cbd"), 1000 },
                    { new DateTime(2024, 3, 1, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9510), new Guid("cb54e72f-3b57-4911-8247-f7479172598e"), 1000 },
                    { new DateTime(2024, 3, 2, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9510), new Guid("a61d4bd2-0b4c-4255-9643-a98a934f4fd9"), 1000 },
                    { new DateTime(2024, 3, 3, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9510), new Guid("aa2d1d4e-a1e9-4622-b7ec-2974ea4d7f88"), 1000 },
                    { new DateTime(2024, 3, 4, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9510), new Guid("65892d8c-be91-4bf0-afd4-753715e49bfe"), 1000 },
                    { new DateTime(2024, 3, 5, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9510), new Guid("cb30ba49-7982-46fb-95a7-35331c531752"), 1000 },
                    { new DateTime(2024, 3, 6, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9510), new Guid("7e3f0fa0-a9f6-4a7e-81cc-1af71768cf5a"), 1000 },
                    { new DateTime(2024, 3, 7, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9520), new Guid("f6471fd8-80df-4ced-b8bd-83a69ae8db25"), 1000 },
                    { new DateTime(2024, 3, 8, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9520), new Guid("f4dd1a74-89f9-40f6-830c-a3ed1fd87000"), 1000 },
                    { new DateTime(2024, 3, 9, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9520), new Guid("62888c3c-bdbe-4f38-8ddd-4aad542b5343"), 1000 },
                    { new DateTime(2024, 3, 10, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9520), new Guid("b12707e1-0825-4f28-a393-baead7b33cbd"), 1000 },
                    { new DateTime(2024, 3, 11, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9520), new Guid("cb54e72f-3b57-4911-8247-f7479172598e"), 1000 },
                    { new DateTime(2024, 3, 12, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9520), new Guid("a61d4bd2-0b4c-4255-9643-a98a934f4fd9"), 1000 },
                    { new DateTime(2024, 3, 13, 13, 20, 31, 231, DateTimeKind.Local).AddTicks(9520), new Guid("aa2d1d4e-a1e9-4622-b7ec-2974ea4d7f88"), 1000 }
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
