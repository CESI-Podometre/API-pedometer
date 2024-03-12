using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StarFitApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrations : Migration
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
                    { new Guid("25e0f58c-9a35-4ba0-b124-ccadf54814bb"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3750), "Content 9", null, "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3750), "Article 9", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3750) },
                    { new Guid("2cddf95f-14c4-468a-913d-a476f2c1b459"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3650), "Content 0", null, "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3650), "Article 0", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3650) },
                    { new Guid("5a6a109d-3583-4d0c-8a10-98a7d25fa442"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3710), "Content 5", null, "https://previews.123rf.com/images/ambro/ambro1112/ambro111200418/11558816-businessman-with-thumbs-up.jpg", true, new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3710), "Article 5", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3720) },
                    { new Guid("8be2d632-f11a-45ee-bcbf-5e2cff5e6c5d"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3670), "Content 2", null, "https://previews.123rf.com/images/ambro/ambro1112/ambro111200418/11558816-businessman-with-thumbs-up.jpg", true, new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3670), "Article 2", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3670) },
                    { new Guid("8ce008af-ab55-4594-bbb8-0afec2a5e063"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3680), "Content 3", null, "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3680), "Article 3", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3680) },
                    { new Guid("8d06b463-c76b-450e-bef2-794d3a902477"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3740), "Content 8", null, "https://previews.123rf.com/images/ambro/ambro1112/ambro111200418/11558816-businessman-with-thumbs-up.jpg", true, new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3740), "Article 8", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3740) },
                    { new Guid("9aa5420c-d74b-41bf-a1ac-06d58a202d8c"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3660), "Content 1", null, "https://thumbs.dreamstime.com/b/bald-man-thumbs-up-26364248.jpg", true, new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3660), "Article 1", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3660) },
                    { new Guid("9b0baf81-8309-4b83-b1f5-83094139f516"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3720), "Content 6", null, "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3720), "Article 6", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3720) },
                    { new Guid("bbd40d30-ba67-4e47-a127-3b3cbe6641ec"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3730), "Content 7", null, "https://thumbs.dreamstime.com/b/bald-man-thumbs-up-26364248.jpg", true, new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3730), "Article 7", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3730) },
                    { new Guid("cd07a751-670c-4ee2-aaac-b08d9639a393"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3690), "Content 4", null, "https://thumbs.dreamstime.com/b/bald-man-thumbs-up-26364248.jpg", true, new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3690), "Article 4", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3690) }
                });

            migrationBuilder.InsertData(
                table: "Badges",
                columns: new[] { "id", "created_at", "description", "icon_path", "title", "updated_at", "UserId" },
                values: new object[,]
                {
                    { new Guid("01ae81ee-7eb3-433b-a2e4-46b5e3865adf"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3370), "Content 2", "https://pngimg.com/uploads/cat/cat_PNG50447.png", "Badge 2", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3380), null },
                    { new Guid("09ad58df-b5ad-4a19-826b-0c76d838bbc8"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3420), "Content 7", "https://images.rawpixel.com/image_png_800/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvcHUyMzMxNjM5LWltYWdlXzItbDBqOXFvd3IucG5n.png", "Badge 7", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3420), null },
                    { new Guid("12006009-4d55-4763-a26d-8e2d624fd3c4"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3390), "Content 4", "https://images.rawpixel.com/image_png_800/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvcHUyMzMxNjM5LWltYWdlXzItbDBqOXFvd3IucG5n.png", "Badge 4", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3390), null },
                    { new Guid("1888638c-0069-4874-81ac-3b0ca1b583a9"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3410), "Content 6", "https://png.pngtree.com/png-vector/20201229/ourmid/pngtree-a-squatting-tabby-cat-png-image_2664942.jpg", "Badge 6", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3410), null },
                    { new Guid("1da21246-c6c4-4721-a50c-80dc9bfa8098"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3380), "Content 3", "https://png.pngtree.com/png-vector/20201229/ourmid/pngtree-a-squatting-tabby-cat-png-image_2664942.jpg", "Badge 3", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3380), null },
                    { new Guid("5289271b-e3c6-4aa4-9006-03bc8bd7993e"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3360), "Content 0", "https://png.pngtree.com/png-vector/20201229/ourmid/pngtree-a-squatting-tabby-cat-png-image_2664942.jpg", "Badge 0", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3360), null },
                    { new Guid("5e14ccb3-dca2-45b5-94af-752602b52445"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3400), "Content 5", "https://pngimg.com/uploads/cat/cat_PNG50447.png", "Badge 5", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3400), null },
                    { new Guid("7b429312-5034-4cf0-ac86-70f4fae88857"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3430), "Content 9", "https://png.pngtree.com/png-vector/20201229/ourmid/pngtree-a-squatting-tabby-cat-png-image_2664942.jpg", "Badge 9", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3430), null },
                    { new Guid("9a8b45d3-9acb-4298-882f-f68e798e003c"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3420), "Content 8", "https://pngimg.com/uploads/cat/cat_PNG50447.png", "Badge 8", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3430), null },
                    { new Guid("bf797fc6-e033-4220-8575-318db36ba831"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3370), "Content 1", "https://images.rawpixel.com/image_png_800/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvcHUyMzMxNjM5LWltYWdlXzItbDBqOXFvd3IucG5n.png", "Badge 1", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3370), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "created_at", "identifier", "updated_at" },
                values: new object[,]
                {
                    { new Guid("245ca322-5ef8-4ca3-9205-fbaacdf5f3c4"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3190), "user2", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3190) },
                    { new Guid("2b427af7-6042-4cdf-bdf2-6753c7ab721f"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3200), "user3", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3200) },
                    { new Guid("678b67be-9cd7-4c57-8df3-4e5882e4ae12"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3230), "user7", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3230) },
                    { new Guid("9769ffb7-852d-4e97-80ed-19051890d5a1"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3100), "user0", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3170) },
                    { new Guid("9d586bd6-9d56-4741-86d7-d36d705a7aa8"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3250), "user9", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3250) },
                    { new Guid("a1293e40-19d1-46dd-8daf-71c71ae8e624"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3220), "user6", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3220) },
                    { new Guid("a98f8d20-4848-4433-a2a8-d43d566317cf"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3240), "user8", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3240) },
                    { new Guid("c6e6d055-ba56-4452-b8c1-cfe6e0485f04"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3200), "user4", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3200) },
                    { new Guid("f8a3a977-0c45-4496-985c-af3bd724bd4c"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3210), "user5", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3210) },
                    { new Guid("f99b3654-72bd-4ce2-9540-49530d6c0804"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3180), "user1", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3180) }
                });

            migrationBuilder.InsertData(
                table: "BadgesToUser",
                columns: new[] { "badge_id", "user_id", "obtained_at" },
                values: new object[,]
                {
                    { new Guid("01ae81ee-7eb3-433b-a2e4-46b5e3865adf"), new Guid("245ca322-5ef8-4ca3-9205-fbaacdf5f3c4"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4190) },
                    { new Guid("1da21246-c6c4-4721-a50c-80dc9bfa8098"), new Guid("2b427af7-6042-4cdf-bdf2-6753c7ab721f"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4190) },
                    { new Guid("09ad58df-b5ad-4a19-826b-0c76d838bbc8"), new Guid("678b67be-9cd7-4c57-8df3-4e5882e4ae12"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4200) },
                    { new Guid("5289271b-e3c6-4aa4-9006-03bc8bd7993e"), new Guid("9769ffb7-852d-4e97-80ed-19051890d5a1"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4190) },
                    { new Guid("7b429312-5034-4cf0-ac86-70f4fae88857"), new Guid("9d586bd6-9d56-4741-86d7-d36d705a7aa8"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4200) },
                    { new Guid("1888638c-0069-4874-81ac-3b0ca1b583a9"), new Guid("a1293e40-19d1-46dd-8daf-71c71ae8e624"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4200) },
                    { new Guid("9a8b45d3-9acb-4298-882f-f68e798e003c"), new Guid("a98f8d20-4848-4433-a2a8-d43d566317cf"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4200) },
                    { new Guid("12006009-4d55-4763-a26d-8e2d624fd3c4"), new Guid("c6e6d055-ba56-4452-b8c1-cfe6e0485f04"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4200) },
                    { new Guid("5e14ccb3-dca2-45b5-94af-752602b52445"), new Guid("f8a3a977-0c45-4496-985c-af3bd724bd4c"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4200) },
                    { new Guid("bf797fc6-e033-4220-8575-318db36ba831"), new Guid("f99b3654-72bd-4ce2-9540-49530d6c0804"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4190) }
                });

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "id", "badge_id", "created_at", "description", "end_date", "is_global", "objective", "start_date", "title", "updated_at" },
                values: new object[,]
                {
                    { new Guid("1eeb354b-baa0-4354-880d-a06eaf1f1f63"), new Guid("9a8b45d3-9acb-4298-882f-f68e798e003c"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3610), "Content 8", new DateTime(2024, 4, 11, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3610), true, 87002, new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3610), "Challenge 8", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3610) },
                    { new Guid("2355ddf2-b26a-4a53-8458-88706993b759"), new Guid("09ad58df-b5ad-4a19-826b-0c76d838bbc8"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3600), "Content 7", new DateTime(2024, 4, 11, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3600), false, 98634, new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3600), "Challenge 7", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3600) },
                    { new Guid("276710bf-c82e-4036-b20f-cbef361a7abd"), new Guid("01ae81ee-7eb3-433b-a2e4-46b5e3865adf"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3540), "Content 2", new DateTime(2024, 4, 11, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3540), true, 94902, new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3540), "Challenge 2", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3540) },
                    { new Guid("3343fb33-772d-469f-82aa-de8e061eb4af"), new Guid("12006009-4d55-4763-a26d-8e2d624fd3c4"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3560), "Content 4", new DateTime(2024, 4, 11, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3560), true, 10797, new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3560), "Challenge 4", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3560) },
                    { new Guid("5a26d287-295e-4591-8363-499f1e58940e"), new Guid("bf797fc6-e033-4220-8575-318db36ba831"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3530), "Content 1", new DateTime(2024, 4, 11, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3530), false, 96847, new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3520), "Challenge 1", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3530) },
                    { new Guid("6411679f-1e16-48ff-9432-812b76f5489b"), new Guid("7b429312-5034-4cf0-ac86-70f4fae88857"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3620), "Content 9", new DateTime(2024, 4, 11, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3620), false, 51079, new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3620), "Challenge 9", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3630) },
                    { new Guid("766f89a2-d15a-4d96-bc07-340f008387d0"), new Guid("5289271b-e3c6-4aa4-9006-03bc8bd7993e"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3510), "Content 0", new DateTime(2024, 4, 11, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3500), true, 86071, new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3480), "Challenge 0", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3510) },
                    { new Guid("8bc65ecc-627d-4015-81fa-546363fe6648"), new Guid("1888638c-0069-4874-81ac-3b0ca1b583a9"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3590), "Content 6", new DateTime(2024, 4, 11, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3590), true, 24152, new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3590), "Challenge 6", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3590) },
                    { new Guid("f37c9b37-f0a8-4891-89a3-c77af3e03e00"), new Guid("5e14ccb3-dca2-45b5-94af-752602b52445"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3580), "Content 5", new DateTime(2024, 4, 11, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3580), false, 98028, new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3570), "Challenge 5", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3580) },
                    { new Guid("fed20dd5-fa76-4dcb-a4a9-d33fbb97e348"), new Guid("1da21246-c6c4-4721-a50c-80dc9bfa8098"), new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3550), "Content 3", new DateTime(2024, 4, 11, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3550), false, 55021, new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3550), "Challenge 3", new DateTime(2024, 3, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3550) }
                });

            migrationBuilder.InsertData(
                table: "DayOfWalk",
                columns: new[] { "date", "user_id", "steps" },
                values: new object[,]
                {
                    { new DateTime(2023, 12, 3, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3800), new Guid("9769ffb7-852d-4e97-80ed-19051890d5a1"), 1000 },
                    { new DateTime(2023, 12, 4, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3810), new Guid("f99b3654-72bd-4ce2-9540-49530d6c0804"), 1000 },
                    { new DateTime(2023, 12, 5, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3810), new Guid("245ca322-5ef8-4ca3-9205-fbaacdf5f3c4"), 1000 },
                    { new DateTime(2023, 12, 6, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3810), new Guid("2b427af7-6042-4cdf-bdf2-6753c7ab721f"), 1000 },
                    { new DateTime(2023, 12, 7, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3820), new Guid("c6e6d055-ba56-4452-b8c1-cfe6e0485f04"), 1000 },
                    { new DateTime(2023, 12, 8, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3820), new Guid("f8a3a977-0c45-4496-985c-af3bd724bd4c"), 1000 },
                    { new DateTime(2023, 12, 9, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3820), new Guid("a1293e40-19d1-46dd-8daf-71c71ae8e624"), 1000 },
                    { new DateTime(2023, 12, 10, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3830), new Guid("678b67be-9cd7-4c57-8df3-4e5882e4ae12"), 1000 },
                    { new DateTime(2023, 12, 11, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3830), new Guid("a98f8d20-4848-4433-a2a8-d43d566317cf"), 1000 },
                    { new DateTime(2023, 12, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3840), new Guid("9d586bd6-9d56-4741-86d7-d36d705a7aa8"), 1000 },
                    { new DateTime(2023, 12, 13, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3840), new Guid("9769ffb7-852d-4e97-80ed-19051890d5a1"), 1000 },
                    { new DateTime(2023, 12, 14, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3840), new Guid("f99b3654-72bd-4ce2-9540-49530d6c0804"), 1000 },
                    { new DateTime(2023, 12, 15, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3850), new Guid("245ca322-5ef8-4ca3-9205-fbaacdf5f3c4"), 1000 },
                    { new DateTime(2023, 12, 16, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3850), new Guid("2b427af7-6042-4cdf-bdf2-6753c7ab721f"), 1000 },
                    { new DateTime(2023, 12, 17, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3850), new Guid("c6e6d055-ba56-4452-b8c1-cfe6e0485f04"), 1000 },
                    { new DateTime(2023, 12, 18, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3860), new Guid("f8a3a977-0c45-4496-985c-af3bd724bd4c"), 1000 },
                    { new DateTime(2023, 12, 19, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3860), new Guid("a1293e40-19d1-46dd-8daf-71c71ae8e624"), 1000 },
                    { new DateTime(2023, 12, 20, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3860), new Guid("678b67be-9cd7-4c57-8df3-4e5882e4ae12"), 1000 },
                    { new DateTime(2023, 12, 21, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3870), new Guid("a98f8d20-4848-4433-a2a8-d43d566317cf"), 1000 },
                    { new DateTime(2023, 12, 22, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3870), new Guid("9d586bd6-9d56-4741-86d7-d36d705a7aa8"), 1000 },
                    { new DateTime(2023, 12, 23, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3870), new Guid("9769ffb7-852d-4e97-80ed-19051890d5a1"), 1000 },
                    { new DateTime(2023, 12, 24, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3880), new Guid("f99b3654-72bd-4ce2-9540-49530d6c0804"), 1000 },
                    { new DateTime(2023, 12, 25, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3880), new Guid("245ca322-5ef8-4ca3-9205-fbaacdf5f3c4"), 1000 },
                    { new DateTime(2023, 12, 26, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3890), new Guid("2b427af7-6042-4cdf-bdf2-6753c7ab721f"), 1000 },
                    { new DateTime(2023, 12, 27, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3890), new Guid("c6e6d055-ba56-4452-b8c1-cfe6e0485f04"), 1000 },
                    { new DateTime(2023, 12, 28, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3890), new Guid("f8a3a977-0c45-4496-985c-af3bd724bd4c"), 1000 },
                    { new DateTime(2023, 12, 29, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3900), new Guid("a1293e40-19d1-46dd-8daf-71c71ae8e624"), 1000 },
                    { new DateTime(2023, 12, 30, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3900), new Guid("678b67be-9cd7-4c57-8df3-4e5882e4ae12"), 1000 },
                    { new DateTime(2023, 12, 31, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3900), new Guid("a98f8d20-4848-4433-a2a8-d43d566317cf"), 1000 },
                    { new DateTime(2024, 1, 1, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3910), new Guid("9d586bd6-9d56-4741-86d7-d36d705a7aa8"), 1000 },
                    { new DateTime(2024, 1, 2, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3910), new Guid("9769ffb7-852d-4e97-80ed-19051890d5a1"), 1000 },
                    { new DateTime(2024, 1, 3, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3910), new Guid("f99b3654-72bd-4ce2-9540-49530d6c0804"), 1000 },
                    { new DateTime(2024, 1, 4, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3920), new Guid("245ca322-5ef8-4ca3-9205-fbaacdf5f3c4"), 1000 },
                    { new DateTime(2024, 1, 5, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3920), new Guid("2b427af7-6042-4cdf-bdf2-6753c7ab721f"), 1000 },
                    { new DateTime(2024, 1, 6, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3920), new Guid("c6e6d055-ba56-4452-b8c1-cfe6e0485f04"), 1000 },
                    { new DateTime(2024, 1, 7, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3930), new Guid("f8a3a977-0c45-4496-985c-af3bd724bd4c"), 1000 },
                    { new DateTime(2024, 1, 8, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3930), new Guid("a1293e40-19d1-46dd-8daf-71c71ae8e624"), 1000 },
                    { new DateTime(2024, 1, 9, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3930), new Guid("678b67be-9cd7-4c57-8df3-4e5882e4ae12"), 1000 },
                    { new DateTime(2024, 1, 10, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3940), new Guid("a98f8d20-4848-4433-a2a8-d43d566317cf"), 1000 },
                    { new DateTime(2024, 1, 11, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3940), new Guid("9d586bd6-9d56-4741-86d7-d36d705a7aa8"), 1000 },
                    { new DateTime(2024, 1, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3950), new Guid("9769ffb7-852d-4e97-80ed-19051890d5a1"), 1000 },
                    { new DateTime(2024, 1, 13, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3950), new Guid("f99b3654-72bd-4ce2-9540-49530d6c0804"), 1000 },
                    { new DateTime(2024, 1, 14, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3950), new Guid("245ca322-5ef8-4ca3-9205-fbaacdf5f3c4"), 1000 },
                    { new DateTime(2024, 1, 15, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3960), new Guid("2b427af7-6042-4cdf-bdf2-6753c7ab721f"), 1000 },
                    { new DateTime(2024, 1, 16, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3960), new Guid("c6e6d055-ba56-4452-b8c1-cfe6e0485f04"), 1000 },
                    { new DateTime(2024, 1, 17, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3960), new Guid("f8a3a977-0c45-4496-985c-af3bd724bd4c"), 1000 },
                    { new DateTime(2024, 1, 18, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3970), new Guid("a1293e40-19d1-46dd-8daf-71c71ae8e624"), 1000 },
                    { new DateTime(2024, 1, 19, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3970), new Guid("678b67be-9cd7-4c57-8df3-4e5882e4ae12"), 1000 },
                    { new DateTime(2024, 1, 20, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3970), new Guid("a98f8d20-4848-4433-a2a8-d43d566317cf"), 1000 },
                    { new DateTime(2024, 1, 21, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3980), new Guid("9d586bd6-9d56-4741-86d7-d36d705a7aa8"), 1000 },
                    { new DateTime(2024, 1, 22, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3980), new Guid("9769ffb7-852d-4e97-80ed-19051890d5a1"), 1000 },
                    { new DateTime(2024, 1, 23, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3980), new Guid("f99b3654-72bd-4ce2-9540-49530d6c0804"), 1000 },
                    { new DateTime(2024, 1, 24, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3990), new Guid("245ca322-5ef8-4ca3-9205-fbaacdf5f3c4"), 1000 },
                    { new DateTime(2024, 1, 25, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3990), new Guid("2b427af7-6042-4cdf-bdf2-6753c7ab721f"), 1000 },
                    { new DateTime(2024, 1, 26, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3990), new Guid("c6e6d055-ba56-4452-b8c1-cfe6e0485f04"), 1000 },
                    { new DateTime(2024, 1, 27, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4000), new Guid("f8a3a977-0c45-4496-985c-af3bd724bd4c"), 1000 },
                    { new DateTime(2024, 1, 28, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4000), new Guid("a1293e40-19d1-46dd-8daf-71c71ae8e624"), 1000 },
                    { new DateTime(2024, 1, 29, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4000), new Guid("678b67be-9cd7-4c57-8df3-4e5882e4ae12"), 1000 },
                    { new DateTime(2024, 1, 30, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4010), new Guid("a98f8d20-4848-4433-a2a8-d43d566317cf"), 1000 },
                    { new DateTime(2024, 1, 31, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4010), new Guid("9d586bd6-9d56-4741-86d7-d36d705a7aa8"), 1000 },
                    { new DateTime(2024, 2, 1, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4020), new Guid("9769ffb7-852d-4e97-80ed-19051890d5a1"), 1000 },
                    { new DateTime(2024, 2, 2, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4020), new Guid("f99b3654-72bd-4ce2-9540-49530d6c0804"), 1000 },
                    { new DateTime(2024, 2, 3, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4020), new Guid("245ca322-5ef8-4ca3-9205-fbaacdf5f3c4"), 1000 },
                    { new DateTime(2024, 2, 4, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4030), new Guid("2b427af7-6042-4cdf-bdf2-6753c7ab721f"), 1000 },
                    { new DateTime(2024, 2, 5, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4030), new Guid("c6e6d055-ba56-4452-b8c1-cfe6e0485f04"), 1000 },
                    { new DateTime(2024, 2, 6, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4030), new Guid("f8a3a977-0c45-4496-985c-af3bd724bd4c"), 1000 },
                    { new DateTime(2024, 2, 7, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4040), new Guid("a1293e40-19d1-46dd-8daf-71c71ae8e624"), 1000 },
                    { new DateTime(2024, 2, 8, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4040), new Guid("678b67be-9cd7-4c57-8df3-4e5882e4ae12"), 1000 },
                    { new DateTime(2024, 2, 9, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4040), new Guid("a98f8d20-4848-4433-a2a8-d43d566317cf"), 1000 },
                    { new DateTime(2024, 2, 10, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4050), new Guid("9d586bd6-9d56-4741-86d7-d36d705a7aa8"), 1000 },
                    { new DateTime(2024, 2, 11, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4050), new Guid("9769ffb7-852d-4e97-80ed-19051890d5a1"), 1000 },
                    { new DateTime(2024, 2, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4050), new Guid("f99b3654-72bd-4ce2-9540-49530d6c0804"), 1000 },
                    { new DateTime(2024, 2, 13, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4060), new Guid("245ca322-5ef8-4ca3-9205-fbaacdf5f3c4"), 1000 },
                    { new DateTime(2024, 2, 14, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4060), new Guid("2b427af7-6042-4cdf-bdf2-6753c7ab721f"), 1000 },
                    { new DateTime(2024, 2, 15, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4060), new Guid("c6e6d055-ba56-4452-b8c1-cfe6e0485f04"), 1000 },
                    { new DateTime(2024, 2, 16, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4070), new Guid("f8a3a977-0c45-4496-985c-af3bd724bd4c"), 1000 },
                    { new DateTime(2024, 2, 17, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4070), new Guid("a1293e40-19d1-46dd-8daf-71c71ae8e624"), 1000 },
                    { new DateTime(2024, 2, 18, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4080), new Guid("678b67be-9cd7-4c57-8df3-4e5882e4ae12"), 1000 },
                    { new DateTime(2024, 2, 19, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4080), new Guid("a98f8d20-4848-4433-a2a8-d43d566317cf"), 1000 },
                    { new DateTime(2024, 2, 20, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4080), new Guid("9d586bd6-9d56-4741-86d7-d36d705a7aa8"), 1000 },
                    { new DateTime(2024, 2, 21, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4090), new Guid("9769ffb7-852d-4e97-80ed-19051890d5a1"), 1000 },
                    { new DateTime(2024, 2, 22, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4090), new Guid("f99b3654-72bd-4ce2-9540-49530d6c0804"), 1000 },
                    { new DateTime(2024, 2, 23, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4090), new Guid("245ca322-5ef8-4ca3-9205-fbaacdf5f3c4"), 1000 },
                    { new DateTime(2024, 2, 24, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4100), new Guid("2b427af7-6042-4cdf-bdf2-6753c7ab721f"), 1000 },
                    { new DateTime(2024, 2, 25, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4100), new Guid("c6e6d055-ba56-4452-b8c1-cfe6e0485f04"), 1000 },
                    { new DateTime(2024, 2, 26, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4110), new Guid("f8a3a977-0c45-4496-985c-af3bd724bd4c"), 1000 },
                    { new DateTime(2024, 2, 27, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4110), new Guid("a1293e40-19d1-46dd-8daf-71c71ae8e624"), 1000 },
                    { new DateTime(2024, 2, 28, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4110), new Guid("678b67be-9cd7-4c57-8df3-4e5882e4ae12"), 1000 },
                    { new DateTime(2024, 2, 29, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4120), new Guid("a98f8d20-4848-4433-a2a8-d43d566317cf"), 1000 },
                    { new DateTime(2024, 3, 1, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4120), new Guid("9d586bd6-9d56-4741-86d7-d36d705a7aa8"), 1000 },
                    { new DateTime(2024, 3, 2, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4120), new Guid("9769ffb7-852d-4e97-80ed-19051890d5a1"), 1000 },
                    { new DateTime(2024, 3, 3, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4130), new Guid("f99b3654-72bd-4ce2-9540-49530d6c0804"), 1000 },
                    { new DateTime(2024, 3, 4, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4130), new Guid("245ca322-5ef8-4ca3-9205-fbaacdf5f3c4"), 1000 },
                    { new DateTime(2024, 3, 5, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4130), new Guid("2b427af7-6042-4cdf-bdf2-6753c7ab721f"), 1000 },
                    { new DateTime(2024, 3, 6, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4140), new Guid("c6e6d055-ba56-4452-b8c1-cfe6e0485f04"), 1000 },
                    { new DateTime(2024, 3, 7, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4140), new Guid("f8a3a977-0c45-4496-985c-af3bd724bd4c"), 1000 },
                    { new DateTime(2024, 3, 8, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4140), new Guid("a1293e40-19d1-46dd-8daf-71c71ae8e624"), 1000 },
                    { new DateTime(2024, 3, 9, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4150), new Guid("678b67be-9cd7-4c57-8df3-4e5882e4ae12"), 1000 },
                    { new DateTime(2024, 3, 10, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4150), new Guid("a98f8d20-4848-4433-a2a8-d43d566317cf"), 1000 },
                    { new DateTime(2024, 3, 11, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4150), new Guid("9d586bd6-9d56-4741-86d7-d36d705a7aa8"), 1000 }
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
                name: "Badges");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
