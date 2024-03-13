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
                    { new Guid("1deec16b-670a-4f87-80d7-6c79a061470e"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5540), "Content 2", null, "https://previews.123rf.com/images/ambro/ambro1112/ambro111200418/11558816-businessman-with-thumbs-up.jpg", true, new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5540), "Article 2", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5540) },
                    { new Guid("30aa28d4-cb79-48a5-8c2d-4c778f4bbabc"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5530), "Content 1", null, "https://thumbs.dreamstime.com/b/bald-man-thumbs-up-26364248.jpg", true, new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5530), "Article 1", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5540) },
                    { new Guid("3d44926f-60e6-48f0-ae08-92c8cf82bef2"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5600), "Content 8", null, "https://previews.123rf.com/images/ambro/ambro1112/ambro111200418/11558816-businessman-with-thumbs-up.jpg", true, new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5600), "Article 8", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5600) },
                    { new Guid("43cb147c-f3c4-447d-8de5-2b887200be95"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5590), "Content 7", null, "https://thumbs.dreamstime.com/b/bald-man-thumbs-up-26364248.jpg", true, new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5590), "Article 7", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5590) },
                    { new Guid("53b3c661-6683-4098-80ec-11c98e8ff86f"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5570), "Content 5", null, "https://previews.123rf.com/images/ambro/ambro1112/ambro111200418/11558816-businessman-with-thumbs-up.jpg", true, new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5570), "Article 5", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5570) },
                    { new Guid("6cc38a52-1ec6-4818-bf8d-919c3732b87d"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5610), "Content 9", null, "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5610), "Article 9", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5610) },
                    { new Guid("8c11ea1f-d643-4cc3-989a-be2682a8d33b"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5550), "Content 3", null, "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5550), "Article 3", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5550) },
                    { new Guid("b1dbc66c-f222-450e-8f1c-0982432f5c25"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5560), "Content 4", null, "https://thumbs.dreamstime.com/b/bald-man-thumbs-up-26364248.jpg", true, new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5560), "Article 4", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5560) },
                    { new Guid("bcd3cbea-9d1b-4230-b58a-855ce99e8ebc"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5580), "Content 6", null, "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5580), "Article 6", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5580) },
                    { new Guid("f5ea13ed-fb6d-4991-bba2-f35d958852fb"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5520), "Content 0", null, "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5520), "Article 0", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5530) }
                });

            migrationBuilder.InsertData(
                table: "Badges",
                columns: new[] { "id", "created_at", "description", "icon_path", "title", "updated_at", "UserId" },
                values: new object[,]
                {
                    { new Guid("11d90959-5e46-427b-a36d-7218bdb25558"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5240), "Content 0", "https://png.pngtree.com/png-vector/20201229/ourmid/pngtree-a-squatting-tabby-cat-png-image_2664942.jpg", "Badge 0", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5240), null },
                    { new Guid("15edbc45-4d4d-4bec-bcb5-ad970229d5af"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5250), "Content 1", "https://images.rawpixel.com/image_png_800/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvcHUyMzMxNjM5LWltYWdlXzItbDBqOXFvd3IucG5n.png", "Badge 1", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5250), null },
                    { new Guid("240fac90-e939-44b7-aadd-ff1207f186a4"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5270), "Content 3", "https://png.pngtree.com/png-vector/20201229/ourmid/pngtree-a-squatting-tabby-cat-png-image_2664942.jpg", "Badge 3", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5270), null },
                    { new Guid("2ffdaa12-c15a-4550-824e-5e8962b03605"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5260), "Content 2", "https://pngimg.com/uploads/cat/cat_PNG50447.png", "Badge 2", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5260), null },
                    { new Guid("3e267ec0-3971-4315-ab53-af72729e7c47"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5300), "Content 7", "https://images.rawpixel.com/image_png_800/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvcHUyMzMxNjM5LWltYWdlXzItbDBqOXFvd3IucG5n.png", "Badge 7", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5300), null },
                    { new Guid("6fb5cf6c-ad79-4335-bd97-3f339c3d9f27"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5280), "Content 5", "https://pngimg.com/uploads/cat/cat_PNG50447.png", "Badge 5", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5280), null },
                    { new Guid("8ab827e1-6f36-4948-93a2-07f0ac9a064b"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5310), "Content 8", "https://pngimg.com/uploads/cat/cat_PNG50447.png", "Badge 8", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5310), null },
                    { new Guid("e1e32864-72cf-435e-b803-9595b33088c9"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5270), "Content 4", "https://images.rawpixel.com/image_png_800/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvcHUyMzMxNjM5LWltYWdlXzItbDBqOXFvd3IucG5n.png", "Badge 4", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5270), null },
                    { new Guid("e3835220-42cc-4044-8af7-42988d999ec7"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5310), "Content 9", "https://png.pngtree.com/png-vector/20201229/ourmid/pngtree-a-squatting-tabby-cat-png-image_2664942.jpg", "Badge 9", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5320), null },
                    { new Guid("ec6d2ddd-056f-4ba3-a02d-eaad65398050"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5290), "Content 6", "https://png.pngtree.com/png-vector/20201229/ourmid/pngtree-a-squatting-tabby-cat-png-image_2664942.jpg", "Badge 6", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5290), null }
                });

            migrationBuilder.InsertData(
                table: "SuperUsers",
                columns: new[] { "id", "created_at", "password", "super_role", "updated_at", "username" },
                values: new object[] { new Guid("0729612a-9693-4d6d-b179-b7d8c7544750"), new DateTime(2024, 3, 13, 9, 25, 29, 899, DateTimeKind.Local).AddTicks(9290), "$2a$05$WDZbqAg1VHlZa.uBz33k.OrMsg79Nn80.MWvZLEAA9WCrthpUoStO", "superAdmin", new DateTime(2024, 3, 13, 9, 25, 29, 899, DateTimeKind.Local).AddTicks(9290), "superAdmin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "created_at", "identifier", "updated_at" },
                values: new object[,]
                {
                    { new Guid("420c3a0a-1f9c-433a-9e3f-8b6f9a904dc3"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5010), "user0", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5050) },
                    { new Guid("54cc6ef5-ba2b-439e-95b1-497097f90fae"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5080), "user3", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5080) },
                    { new Guid("67a4cd57-52a8-48b8-86e6-8908d68891b1"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5090), "user4", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5090) },
                    { new Guid("72d0e2db-cf56-47fd-bf2d-96b4e2fa63df"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5120), "user8", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5120) },
                    { new Guid("9b0d0861-9076-4c54-8139-3f493889e17b"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5110), "user7", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5110) },
                    { new Guid("a1260164-dd80-461c-8cae-b96272ee3176"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5100), "user6", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5100) },
                    { new Guid("a3645c08-488a-442a-b231-0f3d082feb25"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5060), "user1", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5060) },
                    { new Guid("b94479bd-7194-4635-9cf7-b54404822084"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5150), "user9", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5150) },
                    { new Guid("bffa7c13-f94d-4f8d-bf8b-0c42d083c141"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5070), "user2", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5070) },
                    { new Guid("c005dc28-a96a-42d1-8d90-863ad782aef7"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5100), "user5", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5100) }
                });

            migrationBuilder.InsertData(
                table: "BadgesToUser",
                columns: new[] { "badge_id", "user_id", "obtained_at" },
                values: new object[,]
                {
                    { new Guid("11d90959-5e46-427b-a36d-7218bdb25558"), new Guid("420c3a0a-1f9c-433a-9e3f-8b6f9a904dc3"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5800) },
                    { new Guid("240fac90-e939-44b7-aadd-ff1207f186a4"), new Guid("54cc6ef5-ba2b-439e-95b1-497097f90fae"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5800) },
                    { new Guid("e1e32864-72cf-435e-b803-9595b33088c9"), new Guid("67a4cd57-52a8-48b8-86e6-8908d68891b1"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5800) },
                    { new Guid("8ab827e1-6f36-4948-93a2-07f0ac9a064b"), new Guid("72d0e2db-cf56-47fd-bf2d-96b4e2fa63df"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5810) },
                    { new Guid("3e267ec0-3971-4315-ab53-af72729e7c47"), new Guid("9b0d0861-9076-4c54-8139-3f493889e17b"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5800) },
                    { new Guid("ec6d2ddd-056f-4ba3-a02d-eaad65398050"), new Guid("a1260164-dd80-461c-8cae-b96272ee3176"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5800) },
                    { new Guid("15edbc45-4d4d-4bec-bcb5-ad970229d5af"), new Guid("a3645c08-488a-442a-b231-0f3d082feb25"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5800) },
                    { new Guid("e3835220-42cc-4044-8af7-42988d999ec7"), new Guid("b94479bd-7194-4635-9cf7-b54404822084"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5810) },
                    { new Guid("2ffdaa12-c15a-4550-824e-5e8962b03605"), new Guid("bffa7c13-f94d-4f8d-bf8b-0c42d083c141"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5800) },
                    { new Guid("6fb5cf6c-ad79-4335-bd97-3f339c3d9f27"), new Guid("c005dc28-a96a-42d1-8d90-863ad782aef7"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5800) }
                });

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "id", "badge_id", "created_at", "description", "end_date", "is_global", "objective", "start_date", "title", "updated_at" },
                values: new object[,]
                {
                    { new Guid("0c65cab9-72e2-4143-b707-2b4b4272a0d0"), new Guid("e3835220-42cc-4044-8af7-42988d999ec7"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5490), "Content 9", new DateTime(2024, 4, 12, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5490), false, 8120, new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5480), "Challenge 9", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5490) },
                    { new Guid("5759d211-2023-4e84-8f74-7f8b365616ee"), new Guid("11d90959-5e46-427b-a36d-7218bdb25558"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5370), "Content 0", new DateTime(2024, 4, 12, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5360), true, 18349, new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5360), "Challenge 0", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5370) },
                    { new Guid("6d5464f5-c544-4807-b4e3-53b4f97a23d8"), new Guid("6fb5cf6c-ad79-4335-bd97-3f339c3d9f27"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5440), "Content 5", new DateTime(2024, 4, 12, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5440), false, 50939, new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5440), "Challenge 5", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5440) },
                    { new Guid("74b53410-644a-427f-bcc7-ce0a7289c70e"), new Guid("15edbc45-4d4d-4bec-bcb5-ad970229d5af"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5390), "Content 1", new DateTime(2024, 4, 12, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5390), false, 73916, new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5390), "Challenge 1", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5390) },
                    { new Guid("771d5aee-21dc-4ce9-9424-a12b7179b1b3"), new Guid("2ffdaa12-c15a-4550-824e-5e8962b03605"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5400), "Content 2", new DateTime(2024, 4, 12, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5400), true, 57954, new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5400), "Challenge 2", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5400) },
                    { new Guid("7e5525d2-46cb-4cb9-b331-30c181d99ae2"), new Guid("e1e32864-72cf-435e-b803-9595b33088c9"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5420), "Content 4", new DateTime(2024, 4, 12, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5420), true, 38121, new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5420), "Challenge 4", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5430) },
                    { new Guid("7f36a21e-002f-493a-a6d6-9f5389cf192d"), new Guid("240fac90-e939-44b7-aadd-ff1207f186a4"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5410), "Content 3", new DateTime(2024, 4, 12, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5410), false, 59999, new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5410), "Challenge 3", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5410) },
                    { new Guid("8a1da8a7-da79-49bc-837d-742d1dca08dc"), new Guid("ec6d2ddd-056f-4ba3-a02d-eaad65398050"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5450), "Content 6", new DateTime(2024, 4, 12, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5450), true, 85250, new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5450), "Challenge 6", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5450) },
                    { new Guid("c5f10631-3bf3-417d-a939-b414637d428c"), new Guid("8ab827e1-6f36-4948-93a2-07f0ac9a064b"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5470), "Content 8", new DateTime(2024, 4, 12, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5470), true, 23401, new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5470), "Challenge 8", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5470) },
                    { new Guid("c73e5b91-36da-41d5-aeee-06f0fe241f7c"), new Guid("3e267ec0-3971-4315-ab53-af72729e7c47"), new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5460), "Content 7", new DateTime(2024, 4, 12, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5460), false, 71615, new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5460), "Challenge 7", new DateTime(2024, 3, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5460) }
                });

            migrationBuilder.InsertData(
                table: "DayOfWalk",
                columns: new[] { "date", "user_id", "steps" },
                values: new object[,]
                {
                    { new DateTime(2023, 12, 4, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5630), new Guid("420c3a0a-1f9c-433a-9e3f-8b6f9a904dc3"), 1000 },
                    { new DateTime(2023, 12, 5, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5630), new Guid("a3645c08-488a-442a-b231-0f3d082feb25"), 1000 },
                    { new DateTime(2023, 12, 6, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5630), new Guid("bffa7c13-f94d-4f8d-bf8b-0c42d083c141"), 1000 },
                    { new DateTime(2023, 12, 7, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5630), new Guid("54cc6ef5-ba2b-439e-95b1-497097f90fae"), 1000 },
                    { new DateTime(2023, 12, 8, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5630), new Guid("67a4cd57-52a8-48b8-86e6-8908d68891b1"), 1000 },
                    { new DateTime(2023, 12, 9, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5640), new Guid("c005dc28-a96a-42d1-8d90-863ad782aef7"), 1000 },
                    { new DateTime(2023, 12, 10, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5640), new Guid("a1260164-dd80-461c-8cae-b96272ee3176"), 1000 },
                    { new DateTime(2023, 12, 11, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5640), new Guid("9b0d0861-9076-4c54-8139-3f493889e17b"), 1000 },
                    { new DateTime(2023, 12, 12, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5640), new Guid("72d0e2db-cf56-47fd-bf2d-96b4e2fa63df"), 1000 },
                    { new DateTime(2023, 12, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5640), new Guid("b94479bd-7194-4635-9cf7-b54404822084"), 1000 },
                    { new DateTime(2023, 12, 14, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5640), new Guid("420c3a0a-1f9c-433a-9e3f-8b6f9a904dc3"), 1000 },
                    { new DateTime(2023, 12, 15, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5640), new Guid("a3645c08-488a-442a-b231-0f3d082feb25"), 1000 },
                    { new DateTime(2023, 12, 16, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5640), new Guid("bffa7c13-f94d-4f8d-bf8b-0c42d083c141"), 1000 },
                    { new DateTime(2023, 12, 17, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5640), new Guid("54cc6ef5-ba2b-439e-95b1-497097f90fae"), 1000 },
                    { new DateTime(2023, 12, 18, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5650), new Guid("67a4cd57-52a8-48b8-86e6-8908d68891b1"), 1000 },
                    { new DateTime(2023, 12, 19, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5650), new Guid("c005dc28-a96a-42d1-8d90-863ad782aef7"), 1000 },
                    { new DateTime(2023, 12, 20, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5650), new Guid("a1260164-dd80-461c-8cae-b96272ee3176"), 1000 },
                    { new DateTime(2023, 12, 21, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5650), new Guid("9b0d0861-9076-4c54-8139-3f493889e17b"), 1000 },
                    { new DateTime(2023, 12, 22, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5650), new Guid("72d0e2db-cf56-47fd-bf2d-96b4e2fa63df"), 1000 },
                    { new DateTime(2023, 12, 23, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5650), new Guid("b94479bd-7194-4635-9cf7-b54404822084"), 1000 },
                    { new DateTime(2023, 12, 24, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5650), new Guid("420c3a0a-1f9c-433a-9e3f-8b6f9a904dc3"), 1000 },
                    { new DateTime(2023, 12, 25, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5650), new Guid("a3645c08-488a-442a-b231-0f3d082feb25"), 1000 },
                    { new DateTime(2023, 12, 26, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5650), new Guid("bffa7c13-f94d-4f8d-bf8b-0c42d083c141"), 1000 },
                    { new DateTime(2023, 12, 27, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5650), new Guid("54cc6ef5-ba2b-439e-95b1-497097f90fae"), 1000 },
                    { new DateTime(2023, 12, 28, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5660), new Guid("67a4cd57-52a8-48b8-86e6-8908d68891b1"), 1000 },
                    { new DateTime(2023, 12, 29, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5660), new Guid("c005dc28-a96a-42d1-8d90-863ad782aef7"), 1000 },
                    { new DateTime(2023, 12, 30, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5660), new Guid("a1260164-dd80-461c-8cae-b96272ee3176"), 1000 },
                    { new DateTime(2023, 12, 31, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5660), new Guid("9b0d0861-9076-4c54-8139-3f493889e17b"), 1000 },
                    { new DateTime(2024, 1, 1, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5660), new Guid("72d0e2db-cf56-47fd-bf2d-96b4e2fa63df"), 1000 },
                    { new DateTime(2024, 1, 2, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5660), new Guid("b94479bd-7194-4635-9cf7-b54404822084"), 1000 },
                    { new DateTime(2024, 1, 3, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5660), new Guid("420c3a0a-1f9c-433a-9e3f-8b6f9a904dc3"), 1000 },
                    { new DateTime(2024, 1, 4, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5660), new Guid("a3645c08-488a-442a-b231-0f3d082feb25"), 1000 },
                    { new DateTime(2024, 1, 5, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5660), new Guid("bffa7c13-f94d-4f8d-bf8b-0c42d083c141"), 1000 },
                    { new DateTime(2024, 1, 6, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5660), new Guid("54cc6ef5-ba2b-439e-95b1-497097f90fae"), 1000 },
                    { new DateTime(2024, 1, 7, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5670), new Guid("67a4cd57-52a8-48b8-86e6-8908d68891b1"), 1000 },
                    { new DateTime(2024, 1, 8, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5670), new Guid("c005dc28-a96a-42d1-8d90-863ad782aef7"), 1000 },
                    { new DateTime(2024, 1, 9, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5670), new Guid("a1260164-dd80-461c-8cae-b96272ee3176"), 1000 },
                    { new DateTime(2024, 1, 10, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5670), new Guid("9b0d0861-9076-4c54-8139-3f493889e17b"), 1000 },
                    { new DateTime(2024, 1, 11, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5670), new Guid("72d0e2db-cf56-47fd-bf2d-96b4e2fa63df"), 1000 },
                    { new DateTime(2024, 1, 12, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5670), new Guid("b94479bd-7194-4635-9cf7-b54404822084"), 1000 },
                    { new DateTime(2024, 1, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5670), new Guid("420c3a0a-1f9c-433a-9e3f-8b6f9a904dc3"), 1000 },
                    { new DateTime(2024, 1, 14, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5670), new Guid("a3645c08-488a-442a-b231-0f3d082feb25"), 1000 },
                    { new DateTime(2024, 1, 15, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5670), new Guid("bffa7c13-f94d-4f8d-bf8b-0c42d083c141"), 1000 },
                    { new DateTime(2024, 1, 16, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5670), new Guid("54cc6ef5-ba2b-439e-95b1-497097f90fae"), 1000 },
                    { new DateTime(2024, 1, 17, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5680), new Guid("67a4cd57-52a8-48b8-86e6-8908d68891b1"), 1000 },
                    { new DateTime(2024, 1, 18, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5680), new Guid("c005dc28-a96a-42d1-8d90-863ad782aef7"), 1000 },
                    { new DateTime(2024, 1, 19, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5680), new Guid("a1260164-dd80-461c-8cae-b96272ee3176"), 1000 },
                    { new DateTime(2024, 1, 20, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5680), new Guid("9b0d0861-9076-4c54-8139-3f493889e17b"), 1000 },
                    { new DateTime(2024, 1, 21, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5680), new Guid("72d0e2db-cf56-47fd-bf2d-96b4e2fa63df"), 1000 },
                    { new DateTime(2024, 1, 22, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5680), new Guid("b94479bd-7194-4635-9cf7-b54404822084"), 1000 },
                    { new DateTime(2024, 1, 23, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5680), new Guid("420c3a0a-1f9c-433a-9e3f-8b6f9a904dc3"), 1000 },
                    { new DateTime(2024, 1, 24, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5680), new Guid("a3645c08-488a-442a-b231-0f3d082feb25"), 1000 },
                    { new DateTime(2024, 1, 25, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5680), new Guid("bffa7c13-f94d-4f8d-bf8b-0c42d083c141"), 1000 },
                    { new DateTime(2024, 1, 26, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5680), new Guid("54cc6ef5-ba2b-439e-95b1-497097f90fae"), 1000 },
                    { new DateTime(2024, 1, 27, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5680), new Guid("67a4cd57-52a8-48b8-86e6-8908d68891b1"), 1000 },
                    { new DateTime(2024, 1, 28, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5690), new Guid("c005dc28-a96a-42d1-8d90-863ad782aef7"), 1000 },
                    { new DateTime(2024, 1, 29, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5690), new Guid("a1260164-dd80-461c-8cae-b96272ee3176"), 1000 },
                    { new DateTime(2024, 1, 30, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5690), new Guid("9b0d0861-9076-4c54-8139-3f493889e17b"), 1000 },
                    { new DateTime(2024, 1, 31, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5690), new Guid("72d0e2db-cf56-47fd-bf2d-96b4e2fa63df"), 1000 },
                    { new DateTime(2024, 2, 1, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5690), new Guid("b94479bd-7194-4635-9cf7-b54404822084"), 1000 },
                    { new DateTime(2024, 2, 2, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5690), new Guid("420c3a0a-1f9c-433a-9e3f-8b6f9a904dc3"), 1000 },
                    { new DateTime(2024, 2, 3, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5690), new Guid("a3645c08-488a-442a-b231-0f3d082feb25"), 1000 },
                    { new DateTime(2024, 2, 4, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5690), new Guid("bffa7c13-f94d-4f8d-bf8b-0c42d083c141"), 1000 },
                    { new DateTime(2024, 2, 5, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5690), new Guid("54cc6ef5-ba2b-439e-95b1-497097f90fae"), 1000 },
                    { new DateTime(2024, 2, 6, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5690), new Guid("67a4cd57-52a8-48b8-86e6-8908d68891b1"), 1000 },
                    { new DateTime(2024, 2, 7, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5700), new Guid("c005dc28-a96a-42d1-8d90-863ad782aef7"), 1000 },
                    { new DateTime(2024, 2, 8, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5700), new Guid("a1260164-dd80-461c-8cae-b96272ee3176"), 1000 },
                    { new DateTime(2024, 2, 9, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5700), new Guid("9b0d0861-9076-4c54-8139-3f493889e17b"), 1000 },
                    { new DateTime(2024, 2, 10, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5700), new Guid("72d0e2db-cf56-47fd-bf2d-96b4e2fa63df"), 1000 },
                    { new DateTime(2024, 2, 11, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5700), new Guid("b94479bd-7194-4635-9cf7-b54404822084"), 1000 },
                    { new DateTime(2024, 2, 12, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5700), new Guid("420c3a0a-1f9c-433a-9e3f-8b6f9a904dc3"), 1000 },
                    { new DateTime(2024, 2, 13, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5700), new Guid("a3645c08-488a-442a-b231-0f3d082feb25"), 1000 },
                    { new DateTime(2024, 2, 14, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5700), new Guid("bffa7c13-f94d-4f8d-bf8b-0c42d083c141"), 1000 },
                    { new DateTime(2024, 2, 15, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5700), new Guid("54cc6ef5-ba2b-439e-95b1-497097f90fae"), 1000 },
                    { new DateTime(2024, 2, 16, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5700), new Guid("67a4cd57-52a8-48b8-86e6-8908d68891b1"), 1000 },
                    { new DateTime(2024, 2, 17, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5710), new Guid("c005dc28-a96a-42d1-8d90-863ad782aef7"), 1000 },
                    { new DateTime(2024, 2, 18, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5710), new Guid("a1260164-dd80-461c-8cae-b96272ee3176"), 1000 },
                    { new DateTime(2024, 2, 19, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5710), new Guid("9b0d0861-9076-4c54-8139-3f493889e17b"), 1000 },
                    { new DateTime(2024, 2, 20, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5710), new Guid("72d0e2db-cf56-47fd-bf2d-96b4e2fa63df"), 1000 },
                    { new DateTime(2024, 2, 21, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5710), new Guid("b94479bd-7194-4635-9cf7-b54404822084"), 1000 },
                    { new DateTime(2024, 2, 22, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5710), new Guid("420c3a0a-1f9c-433a-9e3f-8b6f9a904dc3"), 1000 },
                    { new DateTime(2024, 2, 23, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5710), new Guid("a3645c08-488a-442a-b231-0f3d082feb25"), 1000 },
                    { new DateTime(2024, 2, 24, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5710), new Guid("bffa7c13-f94d-4f8d-bf8b-0c42d083c141"), 1000 },
                    { new DateTime(2024, 2, 25, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5710), new Guid("54cc6ef5-ba2b-439e-95b1-497097f90fae"), 1000 },
                    { new DateTime(2024, 2, 26, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5710), new Guid("67a4cd57-52a8-48b8-86e6-8908d68891b1"), 1000 },
                    { new DateTime(2024, 2, 27, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5710), new Guid("c005dc28-a96a-42d1-8d90-863ad782aef7"), 1000 },
                    { new DateTime(2024, 2, 28, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5730), new Guid("a1260164-dd80-461c-8cae-b96272ee3176"), 1000 },
                    { new DateTime(2024, 2, 29, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5730), new Guid("9b0d0861-9076-4c54-8139-3f493889e17b"), 1000 },
                    { new DateTime(2024, 3, 1, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5730), new Guid("72d0e2db-cf56-47fd-bf2d-96b4e2fa63df"), 1000 },
                    { new DateTime(2024, 3, 2, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5740), new Guid("b94479bd-7194-4635-9cf7-b54404822084"), 1000 },
                    { new DateTime(2024, 3, 3, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5740), new Guid("420c3a0a-1f9c-433a-9e3f-8b6f9a904dc3"), 1000 },
                    { new DateTime(2024, 3, 4, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5740), new Guid("a3645c08-488a-442a-b231-0f3d082feb25"), 1000 },
                    { new DateTime(2024, 3, 5, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5740), new Guid("bffa7c13-f94d-4f8d-bf8b-0c42d083c141"), 1000 },
                    { new DateTime(2024, 3, 6, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5740), new Guid("54cc6ef5-ba2b-439e-95b1-497097f90fae"), 1000 },
                    { new DateTime(2024, 3, 7, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5740), new Guid("67a4cd57-52a8-48b8-86e6-8908d68891b1"), 1000 },
                    { new DateTime(2024, 3, 8, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5740), new Guid("c005dc28-a96a-42d1-8d90-863ad782aef7"), 1000 },
                    { new DateTime(2024, 3, 9, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5740), new Guid("a1260164-dd80-461c-8cae-b96272ee3176"), 1000 },
                    { new DateTime(2024, 3, 10, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5740), new Guid("9b0d0861-9076-4c54-8139-3f493889e17b"), 1000 },
                    { new DateTime(2024, 3, 11, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5740), new Guid("72d0e2db-cf56-47fd-bf2d-96b4e2fa63df"), 1000 },
                    { new DateTime(2024, 3, 12, 9, 25, 29, 896, DateTimeKind.Local).AddTicks(5740), new Guid("b94479bd-7194-4635-9cf7-b54404822084"), 1000 }
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
