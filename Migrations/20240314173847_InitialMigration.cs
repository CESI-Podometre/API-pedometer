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
                name: "Variables",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    conversion_money = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variables", x => x.id);
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
                    illustration_path = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
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
                    { new Guid("1b5b0f24-d206-480e-befe-1dd0c2054bc0"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8240), "Content 2", null, "https://www.icao.int/WACAF/Documents/Meetings/2015/Surveillance%20h%C3%A9listations/1.2%20Technique%20de%20l%27h%C3%A9licopt%C3%A8re.pdf", "https://previews.123rf.com/images/ambro/ambro1112/ambro111200418/11558816-businessman-with-thumbs-up.jpg", true, new DateTime(2024, 2, 28, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8230), "Article 2", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8240) },
                    { new Guid("2b1a1329-7297-468a-b956-2ffb0639683d"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8270), "Content 5", null, "https://www.icao.int/WACAF/Documents/Meetings/2015/Surveillance%20h%C3%A9listations/1.2%20Technique%20de%20l%27h%C3%A9licopt%C3%A8re.pdf", "https://previews.123rf.com/images/ambro/ambro1112/ambro111200418/11558816-businessman-with-thumbs-up.jpg", true, new DateTime(2024, 3, 2, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8270), "Article 5", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8270) },
                    { new Guid("330d2a1f-18a2-41d4-bb1e-75db0f3fff0b"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8210), "Content 0", null, "https://lyc-jules-ferry.fr/wp-content/uploads/2021/03/6Cadavre-exquis-ecrit-2.pdf", "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, new DateTime(2024, 3, 3, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8210), "Article 0", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8210) },
                    { new Guid("38a9e955-f09e-4cca-9207-83ee815af65d"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8250), "Content 3", null, "https://lyc-jules-ferry.fr/wp-content/uploads/2021/03/6Cadavre-exquis-ecrit-2.pdf", "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, new DateTime(2024, 3, 8, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8250), "Article 3", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8250) },
                    { new Guid("513cfecd-ce64-4e68-b3cb-f0e59baca8e0"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8280), "Content 6", null, "https://lyc-jules-ferry.fr/wp-content/uploads/2021/03/6Cadavre-exquis-ecrit-2.pdf", "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, new DateTime(2024, 3, 12, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8280), "Article 6", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8290) },
                    { new Guid("5dc38b88-77b3-4a96-a8bf-22f56a2f95d5"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8320), "Content 9", null, "https://lyc-jules-ferry.fr/wp-content/uploads/2021/03/6Cadavre-exquis-ecrit-2.pdf", "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, new DateTime(2024, 3, 10, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8320), "Article 9", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8320) },
                    { new Guid("703875a1-7119-44a3-ae5e-b287a363a189"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8230), "Content 1", null, "https://organzo.ca/wp-content/uploads/2013/05/FR_eggplant.pdf", "https://thumbs.dreamstime.com/b/bald-man-thumbs-up-26364248.jpg", true, new DateTime(2024, 3, 6, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8220), "Article 1", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8230) },
                    { new Guid("a7fbdcc0-b2ec-4ab2-ad5b-79077f59630d"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8300), "Content 7", null, "https://organzo.ca/wp-content/uploads/2013/05/FR_eggplant.pdf", "https://thumbs.dreamstime.com/b/bald-man-thumbs-up-26364248.jpg", true, new DateTime(2024, 3, 12, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8290), "Article 7", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8300) },
                    { new Guid("f70e279c-0a9c-4126-95df-d61d1a5affa5"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8260), "Content 4", null, "https://organzo.ca/wp-content/uploads/2013/05/FR_eggplant.pdf", "https://thumbs.dreamstime.com/b/bald-man-thumbs-up-26364248.jpg", true, new DateTime(2024, 3, 5, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8260), "Article 4", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8260) },
                    { new Guid("f8cd2908-1334-4767-b702-143802bf50ff"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8310), "Content 8", null, "https://www.icao.int/WACAF/Documents/Meetings/2015/Surveillance%20h%C3%A9listations/1.2%20Technique%20de%20l%27h%C3%A9licopt%C3%A8re.pdf", "https://previews.123rf.com/images/ambro/ambro1112/ambro111200418/11558816-businessman-with-thumbs-up.jpg", true, new DateTime(2024, 2, 29, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8300), "Article 8", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8310) }
                });

            migrationBuilder.InsertData(
                table: "Badges",
                columns: new[] { "id", "created_at", "description", "icon_path", "title", "updated_at", "UserId" },
                values: new object[,]
                {
                    { new Guid("09ae7517-3b69-4f0d-b748-9f39b3f8a1db"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7960), "Content 6", "https://png.pngtree.com/png-vector/20201229/ourmid/pngtree-a-squatting-tabby-cat-png-image_2664942.jpg", "Badge 6", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7960), null },
                    { new Guid("111dc192-1bac-46e1-8392-83efdf280931"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7940), "Content 3", "https://png.pngtree.com/png-vector/20201229/ourmid/pngtree-a-squatting-tabby-cat-png-image_2664942.jpg", "Badge 3", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7940), null },
                    { new Guid("1750b94d-5d1c-4aaf-8854-e1d17cd58ecd"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7930), "Content 2", "https://pngimg.com/uploads/cat/cat_PNG50447.png", "Badge 2", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7930), null },
                    { new Guid("50c0f6b4-5603-4391-a39d-80e6f1c2809d"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7920), "Content 1", "https://images.rawpixel.com/image_png_800/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvcHUyMzMxNjM5LWltYWdlXzItbDBqOXFvd3IucG5n.png", "Badge 1", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7920), null },
                    { new Guid("6a2b22fc-b149-4169-a30d-7b65700424d3"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7910), "Content 0", "https://png.pngtree.com/png-vector/20201229/ourmid/pngtree-a-squatting-tabby-cat-png-image_2664942.jpg", "Badge 0", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7910), null },
                    { new Guid("9b6f5d48-713a-4a1d-9663-f0ff992d936d"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7980), "Content 8", "https://pngimg.com/uploads/cat/cat_PNG50447.png", "Badge 8", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7980), null },
                    { new Guid("b5991a07-cf0d-4941-912b-d8b2e4550c6a"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7950), "Content 5", "https://pngimg.com/uploads/cat/cat_PNG50447.png", "Badge 5", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7960), null },
                    { new Guid("c072fe17-a2d9-49a3-aa35-ca6fd268b5aa"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7950), "Content 4", "https://images.rawpixel.com/image_png_800/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvcHUyMzMxNjM5LWltYWdlXzItbDBqOXFvd3IucG5n.png", "Badge 4", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7950), null },
                    { new Guid("ccf1f8a3-a8e5-4432-91b6-0a7deb8d4120"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7990), "Content 9", "https://png.pngtree.com/png-vector/20201229/ourmid/pngtree-a-squatting-tabby-cat-png-image_2664942.jpg", "Badge 9", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7990), null },
                    { new Guid("d7eb2dda-ffb3-4cc9-a008-9dd81fbf8f91"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7970), "Content 7", "https://images.rawpixel.com/image_png_800/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvcHUyMzMxNjM5LWltYWdlXzItbDBqOXFvd3IucG5n.png", "Badge 7", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7970), null }
                });

            migrationBuilder.InsertData(
                table: "SuperUsers",
                columns: new[] { "id", "created_at", "password", "super_role", "updated_at", "username" },
                values: new object[] { new Guid("5c4b24f7-61ac-4750-bfb9-a79e2f9430a4"), new DateTime(2024, 3, 14, 18, 38, 47, 44, DateTimeKind.Local).AddTicks(3640), "$2a$05$FmubF3EUV54WQayZQoZZWexob3pOjvwvJMmAXATPWg5Yi.veUBqbO", "superAdmin", new DateTime(2024, 3, 14, 18, 38, 47, 44, DateTimeKind.Local).AddTicks(3640), "superAdmin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "created_at", "identifier", "updated_at" },
                values: new object[,]
                {
                    { new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7800), "user4", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7800) },
                    { new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7770), "user1", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7770) },
                    { new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7810), "user5", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7810) },
                    { new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7780), "user2", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7780) },
                    { new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7830), "user8", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7830) },
                    { new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7810), "user6", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7810) },
                    { new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7790), "user3", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7790) },
                    { new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7820), "user7", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7820) },
                    { new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7730), "user0", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7760) },
                    { new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7840), "user9", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(7840) }
                });

            migrationBuilder.InsertData(
                table: "Variables",
                columns: new[] { "id", "conversion_money" },
                values: new object[] { new Guid("2462e2c9-9c76-4f96-9693-aa391f0c528f"), "1000" });

            migrationBuilder.InsertData(
                table: "BadgesToUser",
                columns: new[] { "badge_id", "user_id", "obtained_at" },
                values: new object[,]
                {
                    { new Guid("c072fe17-a2d9-49a3-aa35-ca6fd268b5aa"), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), new DateTime(2024, 3, 14, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(230) },
                    { new Guid("50c0f6b4-5603-4391-a39d-80e6f1c2809d"), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), new DateTime(2024, 3, 14, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(230) },
                    { new Guid("b5991a07-cf0d-4941-912b-d8b2e4550c6a"), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), new DateTime(2024, 3, 14, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(240) },
                    { new Guid("1750b94d-5d1c-4aaf-8854-e1d17cd58ecd"), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), new DateTime(2024, 3, 14, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(230) },
                    { new Guid("9b6f5d48-713a-4a1d-9663-f0ff992d936d"), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), new DateTime(2024, 3, 14, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(240) },
                    { new Guid("09ae7517-3b69-4f0d-b748-9f39b3f8a1db"), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), new DateTime(2024, 3, 14, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(240) },
                    { new Guid("111dc192-1bac-46e1-8392-83efdf280931"), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), new DateTime(2024, 3, 14, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(230) },
                    { new Guid("d7eb2dda-ffb3-4cc9-a008-9dd81fbf8f91"), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), new DateTime(2024, 3, 14, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(240) },
                    { new Guid("6a2b22fc-b149-4169-a30d-7b65700424d3"), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), new DateTime(2024, 3, 14, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(230) },
                    { new Guid("ccf1f8a3-a8e5-4432-91b6-0a7deb8d4120"), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), new DateTime(2024, 3, 14, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(240) }
                });

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "id", "badge_id", "created_at", "description", "end_date", "illustration_path", "is_global", "objective", "start_date", "title", "updated_at" },
                values: new object[,]
                {
                    { new Guid("14346a95-e3d7-46bc-80c2-bf04fea702b8"), new Guid("9b6f5d48-713a-4a1d-9663-f0ff992d936d"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8170), "Content 8", new DateTime(2024, 4, 13, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8170), "https://previews.123rf.com/images/ambro/ambro1112/ambro111200418/11558816-businessman-with-thumbs-up.jpg", true, 70758, new DateTime(2024, 3, 11, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8170), "Challenge 8", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8170) },
                    { new Guid("1948a767-59fb-4df8-84cc-e9b724c1b49c"), new Guid("d7eb2dda-ffb3-4cc9-a008-9dd81fbf8f91"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8150), "Content 7", new DateTime(2024, 4, 13, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8150), "https://thumbs.dreamstime.com/b/bald-man-thumbs-up-26364248.jpg", false, 96654, new DateTime(2024, 2, 23, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8150), "Challenge 7", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8160) },
                    { new Guid("677fad3f-7b50-4e4d-9a34-9c74b3bd17bd"), new Guid("b5991a07-cf0d-4941-912b-d8b2e4550c6a"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8130), "Content 5", new DateTime(2024, 4, 13, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8120), "https://previews.123rf.com/images/ambro/ambro1112/ambro111200418/11558816-businessman-with-thumbs-up.jpg", false, 45255, new DateTime(2024, 3, 12, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8120), "Challenge 5", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8130) },
                    { new Guid("7bea1866-5392-4c38-9ff8-3641aac45b33"), new Guid("ccf1f8a3-a8e5-4432-91b6-0a7deb8d4120"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8180), "Content 9", new DateTime(2024, 4, 13, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8180), "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", false, 94368, new DateTime(2024, 3, 1, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8180), "Challenge 9", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8190) },
                    { new Guid("8d13e3a3-1b43-4532-9f09-ab3496253ecc"), new Guid("50c0f6b4-5603-4391-a39d-80e6f1c2809d"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8060), "Content 1", new DateTime(2024, 4, 13, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8060), "https://thumbs.dreamstime.com/b/bald-man-thumbs-up-26364248.jpg", false, 28196, new DateTime(2024, 3, 1, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8060), "Challenge 1", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8060) },
                    { new Guid("a265c667-e5e1-4f33-8b68-6236cc34d2ca"), new Guid("c072fe17-a2d9-49a3-aa35-ca6fd268b5aa"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8110), "Content 4", new DateTime(2024, 4, 13, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8110), "https://thumbs.dreamstime.com/b/bald-man-thumbs-up-26364248.jpg", true, 9303, new DateTime(2024, 2, 26, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8100), "Challenge 4", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8110) },
                    { new Guid("a2b7d155-c051-4359-b70e-3b62695da0c5"), new Guid("09ae7517-3b69-4f0d-b748-9f39b3f8a1db"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8140), "Content 6", new DateTime(2024, 4, 13, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8140), "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, 46726, new DateTime(2024, 2, 26, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8140), "Challenge 6", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8140) },
                    { new Guid("b43d31c7-c103-4a38-a095-a16c1d36f892"), new Guid("1750b94d-5d1c-4aaf-8854-e1d17cd58ecd"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8080), "Content 2", new DateTime(2024, 4, 13, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8080), "https://previews.123rf.com/images/ambro/ambro1112/ambro111200418/11558816-businessman-with-thumbs-up.jpg", true, 42637, new DateTime(2024, 2, 26, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8070), "Challenge 2", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8080) },
                    { new Guid("b5f79a28-2ffd-45af-9791-9c00910d5110"), new Guid("111dc192-1bac-46e1-8392-83efdf280931"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8090), "Content 3", new DateTime(2024, 4, 13, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8090), "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", false, 47046, new DateTime(2024, 2, 28, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8090), "Challenge 3", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8090) },
                    { new Guid("e2eb9ab5-5768-4838-af15-ffd52fc1b2c2"), new Guid("6a2b22fc-b149-4169-a30d-7b65700424d3"), new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8050), "Content 0", new DateTime(2024, 4, 13, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8040), "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, 98149, new DateTime(2024, 3, 5, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8030), "Challenge 0", new DateTime(2024, 3, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8050) }
                });

            migrationBuilder.InsertData(
                table: "DayOfWalk",
                columns: new[] { "date", "user_id", "steps" },
                values: new object[,]
                {
                    { new DateTime(2024, 1, 24, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8340), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 96194 },
                    { new DateTime(2024, 1, 24, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8530), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 33456 },
                    { new DateTime(2024, 1, 24, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8700), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 6855 },
                    { new DateTime(2024, 1, 24, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8890), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 2268 },
                    { new DateTime(2024, 1, 24, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9050), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 27632 },
                    { new DateTime(2024, 1, 24, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9240), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 7932 },
                    { new DateTime(2024, 1, 24, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9410), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 4367 },
                    { new DateTime(2024, 1, 24, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9590), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 75020 },
                    { new DateTime(2024, 1, 24, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9760), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 19785 },
                    { new DateTime(2024, 1, 24, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9930), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 58171 },
                    { new DateTime(2024, 1, 25, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8340), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 76349 },
                    { new DateTime(2024, 1, 25, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8530), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 6182 },
                    { new DateTime(2024, 1, 25, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8700), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 87961 },
                    { new DateTime(2024, 1, 25, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8890), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 62683 },
                    { new DateTime(2024, 1, 25, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9060), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 57808 },
                    { new DateTime(2024, 1, 25, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9240), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 31635 },
                    { new DateTime(2024, 1, 25, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9410), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 72786 },
                    { new DateTime(2024, 1, 25, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9600), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 2224 },
                    { new DateTime(2024, 1, 25, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9770), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 67136 },
                    { new DateTime(2024, 1, 25, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9940), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 58889 },
                    { new DateTime(2024, 1, 26, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8350), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 65499 },
                    { new DateTime(2024, 1, 26, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8540), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 79980 },
                    { new DateTime(2024, 1, 26, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8710), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 5629 },
                    { new DateTime(2024, 1, 26, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8890), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 79243 },
                    { new DateTime(2024, 1, 26, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9060), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 5141 },
                    { new DateTime(2024, 1, 26, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9240), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 30248 },
                    { new DateTime(2024, 1, 26, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9420), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 48656 },
                    { new DateTime(2024, 1, 26, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9600), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 11968 },
                    { new DateTime(2024, 1, 26, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9770), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 39157 },
                    { new DateTime(2024, 1, 26, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9940), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 15977 },
                    { new DateTime(2024, 1, 27, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8350), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 51757 },
                    { new DateTime(2024, 1, 27, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8540), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 47745 },
                    { new DateTime(2024, 1, 27, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8710), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 3747 },
                    { new DateTime(2024, 1, 27, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8900), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 48864 },
                    { new DateTime(2024, 1, 27, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9060), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 80120 },
                    { new DateTime(2024, 1, 27, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9250), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 26920 },
                    { new DateTime(2024, 1, 27, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9420), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 6518 },
                    { new DateTime(2024, 1, 27, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9600), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 94759 },
                    { new DateTime(2024, 1, 27, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9770), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 97668 },
                    { new DateTime(2024, 1, 27, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9940), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 14383 },
                    { new DateTime(2024, 1, 28, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8350), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 89676 },
                    { new DateTime(2024, 1, 28, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8540), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 17230 },
                    { new DateTime(2024, 1, 28, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8710), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 35493 },
                    { new DateTime(2024, 1, 28, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8900), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 21997 },
                    { new DateTime(2024, 1, 28, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9070), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 76129 },
                    { new DateTime(2024, 1, 28, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9250), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 93407 },
                    { new DateTime(2024, 1, 28, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9420), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 22618 },
                    { new DateTime(2024, 1, 28, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9610), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 31796 },
                    { new DateTime(2024, 1, 28, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9780), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 8052 },
                    { new DateTime(2024, 1, 28, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9950), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 43664 },
                    { new DateTime(2024, 1, 29, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8360), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 85833 },
                    { new DateTime(2024, 1, 29, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8550), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 44518 },
                    { new DateTime(2024, 1, 29, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8720), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 51301 },
                    { new DateTime(2024, 1, 29, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8900), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 2183 },
                    { new DateTime(2024, 1, 29, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9070), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 63001 },
                    { new DateTime(2024, 1, 29, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9250), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 28638 },
                    { new DateTime(2024, 1, 29, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9430), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 52135 },
                    { new DateTime(2024, 1, 29, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9610), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 96795 },
                    { new DateTime(2024, 1, 29, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9780), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 87607 },
                    { new DateTime(2024, 1, 29, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9950), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 10757 },
                    { new DateTime(2024, 1, 30, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8360), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 90050 },
                    { new DateTime(2024, 1, 30, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8550), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 91853 },
                    { new DateTime(2024, 1, 30, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8720), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 97544 },
                    { new DateTime(2024, 1, 30, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8910), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 54547 },
                    { new DateTime(2024, 1, 30, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9070), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 1914 },
                    { new DateTime(2024, 1, 30, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9260), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 27640 },
                    { new DateTime(2024, 1, 30, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9430), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 65787 },
                    { new DateTime(2024, 1, 30, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9610), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 97229 },
                    { new DateTime(2024, 1, 30, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9780), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 48061 },
                    { new DateTime(2024, 1, 30, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9950), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 50161 },
                    { new DateTime(2024, 1, 31, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8370), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 24474 },
                    { new DateTime(2024, 1, 31, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8550), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 25388 },
                    { new DateTime(2024, 1, 31, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8720), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 40800 },
                    { new DateTime(2024, 1, 31, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8910), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 89439 },
                    { new DateTime(2024, 1, 31, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9080), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 43108 },
                    { new DateTime(2024, 1, 31, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9260), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 61933 },
                    { new DateTime(2024, 1, 31, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9430), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 21891 },
                    { new DateTime(2024, 1, 31, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9620), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 58348 },
                    { new DateTime(2024, 1, 31, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9790), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 34261 },
                    { new DateTime(2024, 1, 31, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9960), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 99037 },
                    { new DateTime(2024, 2, 1, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8370), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 46162 },
                    { new DateTime(2024, 2, 1, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8560), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 81092 },
                    { new DateTime(2024, 2, 1, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8730), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 78851 },
                    { new DateTime(2024, 2, 1, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8910), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 17267 },
                    { new DateTime(2024, 2, 1, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9080), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 14162 },
                    { new DateTime(2024, 2, 1, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9270), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 12274 },
                    { new DateTime(2024, 2, 1, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9440), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 23633 },
                    { new DateTime(2024, 2, 1, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9620), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 23850 },
                    { new DateTime(2024, 2, 1, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9790), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 79771 },
                    { new DateTime(2024, 2, 1, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9960), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 53542 },
                    { new DateTime(2024, 2, 2, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8370), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 42071 },
                    { new DateTime(2024, 2, 2, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8560), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 6048 },
                    { new DateTime(2024, 2, 2, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8730), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 86674 },
                    { new DateTime(2024, 2, 2, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8920), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 19033 },
                    { new DateTime(2024, 2, 2, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9080), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 32117 },
                    { new DateTime(2024, 2, 2, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9270), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 15286 },
                    { new DateTime(2024, 2, 2, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9440), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 46183 },
                    { new DateTime(2024, 2, 2, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9620), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 11381 },
                    { new DateTime(2024, 2, 2, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9790), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 60770 },
                    { new DateTime(2024, 2, 2, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9960), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 76004 },
                    { new DateTime(2024, 2, 3, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8380), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 10939 },
                    { new DateTime(2024, 2, 3, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8560), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 67701 },
                    { new DateTime(2024, 2, 3, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8730), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 62566 },
                    { new DateTime(2024, 2, 3, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8920), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 96170 },
                    { new DateTime(2024, 2, 3, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9090), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 45286 },
                    { new DateTime(2024, 2, 3, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9270), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 22059 },
                    { new DateTime(2024, 2, 3, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9440), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 63689 },
                    { new DateTime(2024, 2, 3, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9630), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 69180 },
                    { new DateTime(2024, 2, 3, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9800), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 21028 },
                    { new DateTime(2024, 2, 3, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9970), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 27907 },
                    { new DateTime(2024, 2, 4, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8380), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 67551 },
                    { new DateTime(2024, 2, 4, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8570), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 29958 },
                    { new DateTime(2024, 2, 4, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8740), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 5297 },
                    { new DateTime(2024, 2, 4, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8920), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 15508 },
                    { new DateTime(2024, 2, 4, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9090), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 4563 },
                    { new DateTime(2024, 2, 4, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9280), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 39950 },
                    { new DateTime(2024, 2, 4, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9450), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 49068 },
                    { new DateTime(2024, 2, 4, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9630), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 47671 },
                    { new DateTime(2024, 2, 4, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9800), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 36316 },
                    { new DateTime(2024, 2, 4, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9970), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 83604 },
                    { new DateTime(2024, 2, 5, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8380), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 51590 },
                    { new DateTime(2024, 2, 5, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8570), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 31296 },
                    { new DateTime(2024, 2, 5, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8740), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 97048 },
                    { new DateTime(2024, 2, 5, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8930), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 64128 },
                    { new DateTime(2024, 2, 5, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9090), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 87961 },
                    { new DateTime(2024, 2, 5, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9280), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 79054 },
                    { new DateTime(2024, 2, 5, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9450), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 77713 },
                    { new DateTime(2024, 2, 5, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9630), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 46272 },
                    { new DateTime(2024, 2, 5, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9800), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 58035 },
                    { new DateTime(2024, 2, 5, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9970), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 94663 },
                    { new DateTime(2024, 2, 6, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8390), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 47750 },
                    { new DateTime(2024, 2, 6, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8570), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 12076 },
                    { new DateTime(2024, 2, 6, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8740), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 92828 },
                    { new DateTime(2024, 2, 6, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8930), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 91949 },
                    { new DateTime(2024, 2, 6, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9100), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 28167 },
                    { new DateTime(2024, 2, 6, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9280), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 16631 },
                    { new DateTime(2024, 2, 6, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9450), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 56360 },
                    { new DateTime(2024, 2, 6, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9640), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 51344 },
                    { new DateTime(2024, 2, 6, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9810), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 96772 },
                    { new DateTime(2024, 2, 6, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9990), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 69905 },
                    { new DateTime(2024, 2, 7, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8390), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 22401 },
                    { new DateTime(2024, 2, 7, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8580), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 12109 },
                    { new DateTime(2024, 2, 7, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8750), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 94604 },
                    { new DateTime(2024, 2, 7, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8930), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 91459 },
                    { new DateTime(2024, 2, 7, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9100), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 25641 },
                    { new DateTime(2024, 2, 7, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9290), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 27496 },
                    { new DateTime(2024, 2, 7, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9460), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 38969 },
                    { new DateTime(2024, 2, 7, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9640), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 8863 },
                    { new DateTime(2024, 2, 7, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9810), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 67185 },
                    { new DateTime(2024, 2, 7, 18, 38, 47, 41, DateTimeKind.Local), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 99948 },
                    { new DateTime(2024, 2, 8, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8410), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 4075 },
                    { new DateTime(2024, 2, 8, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8580), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 53979 },
                    { new DateTime(2024, 2, 8, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8750), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 13907 },
                    { new DateTime(2024, 2, 8, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8940), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 7174 },
                    { new DateTime(2024, 2, 8, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9100), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 87584 },
                    { new DateTime(2024, 2, 8, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9290), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 88987 },
                    { new DateTime(2024, 2, 8, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9460), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 37820 },
                    { new DateTime(2024, 2, 8, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9640), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 20250 },
                    { new DateTime(2024, 2, 8, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9810), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 75283 },
                    { new DateTime(2024, 2, 8, 18, 38, 47, 41, DateTimeKind.Local), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 30269 },
                    { new DateTime(2024, 2, 9, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8420), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 36096 },
                    { new DateTime(2024, 2, 9, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8590), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 38122 },
                    { new DateTime(2024, 2, 9, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8750), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 34213 },
                    { new DateTime(2024, 2, 9, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8940), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 26397 },
                    { new DateTime(2024, 2, 9, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9110), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 48555 },
                    { new DateTime(2024, 2, 9, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9290), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 58727 },
                    { new DateTime(2024, 2, 9, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9460), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 34748 },
                    { new DateTime(2024, 2, 9, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9650), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 76160 },
                    { new DateTime(2024, 2, 9, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9820), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 44180 },
                    { new DateTime(2024, 2, 9, 18, 38, 47, 41, DateTimeKind.Local), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 8026 },
                    { new DateTime(2024, 2, 10, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8420), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 30176 },
                    { new DateTime(2024, 2, 10, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8590), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 68233 },
                    { new DateTime(2024, 2, 10, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8760), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 54772 },
                    { new DateTime(2024, 2, 10, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8940), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 27468 },
                    { new DateTime(2024, 2, 10, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9110), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 77470 },
                    { new DateTime(2024, 2, 10, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9300), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 3365 },
                    { new DateTime(2024, 2, 10, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9470), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 3724 },
                    { new DateTime(2024, 2, 10, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9650), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 42215 },
                    { new DateTime(2024, 2, 10, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9820), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 18094 },
                    { new DateTime(2024, 2, 10, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(10), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 13203 },
                    { new DateTime(2024, 2, 11, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8420), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 39702 },
                    { new DateTime(2024, 2, 11, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8590), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 45348 },
                    { new DateTime(2024, 2, 11, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8760), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 96481 },
                    { new DateTime(2024, 2, 11, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8950), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 10977 },
                    { new DateTime(2024, 2, 11, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9110), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 64231 },
                    { new DateTime(2024, 2, 11, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9300), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 61871 },
                    { new DateTime(2024, 2, 11, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9470), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 81731 },
                    { new DateTime(2024, 2, 11, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9650), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 15484 },
                    { new DateTime(2024, 2, 11, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9820), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 60545 },
                    { new DateTime(2024, 2, 11, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(10), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 66042 },
                    { new DateTime(2024, 2, 12, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8430), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 11876 },
                    { new DateTime(2024, 2, 12, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8600), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 32782 },
                    { new DateTime(2024, 2, 12, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8760), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 21605 },
                    { new DateTime(2024, 2, 12, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8950), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 31153 },
                    { new DateTime(2024, 2, 12, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9120), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 13277 },
                    { new DateTime(2024, 2, 12, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9300), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 80976 },
                    { new DateTime(2024, 2, 12, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9470), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 71997 },
                    { new DateTime(2024, 2, 12, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9660), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 27713 },
                    { new DateTime(2024, 2, 12, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9830), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 3359 },
                    { new DateTime(2024, 2, 12, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(20), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 41207 },
                    { new DateTime(2024, 2, 13, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8430), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 63153 },
                    { new DateTime(2024, 2, 13, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8600), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 92182 },
                    { new DateTime(2024, 2, 13, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8770), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 53700 },
                    { new DateTime(2024, 2, 13, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8950), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 10580 },
                    { new DateTime(2024, 2, 13, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9120), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 11859 },
                    { new DateTime(2024, 2, 13, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9310), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 84060 },
                    { new DateTime(2024, 2, 13, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9480), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 27938 },
                    { new DateTime(2024, 2, 13, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9660), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 5934 },
                    { new DateTime(2024, 2, 13, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9830), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 46879 },
                    { new DateTime(2024, 2, 13, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(20), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 89020 },
                    { new DateTime(2024, 2, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8430), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 39335 },
                    { new DateTime(2024, 2, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8600), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 18296 },
                    { new DateTime(2024, 2, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8770), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 32443 },
                    { new DateTime(2024, 2, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8960), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 8631 },
                    { new DateTime(2024, 2, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9120), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 75042 },
                    { new DateTime(2024, 2, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9310), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 70343 },
                    { new DateTime(2024, 2, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9480), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 56094 },
                    { new DateTime(2024, 2, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9660), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 53426 },
                    { new DateTime(2024, 2, 14, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9830), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 95005 },
                    { new DateTime(2024, 2, 14, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(20), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 30942 },
                    { new DateTime(2024, 2, 15, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8440), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 54819 },
                    { new DateTime(2024, 2, 15, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8610), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 55366 },
                    { new DateTime(2024, 2, 15, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8770), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 52778 },
                    { new DateTime(2024, 2, 15, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8960), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 54615 },
                    { new DateTime(2024, 2, 15, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9130), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 65623 },
                    { new DateTime(2024, 2, 15, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9320), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 24640 },
                    { new DateTime(2024, 2, 15, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9480), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 40879 },
                    { new DateTime(2024, 2, 15, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9670), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 18490 },
                    { new DateTime(2024, 2, 15, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9840), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 44099 },
                    { new DateTime(2024, 2, 15, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(30), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 37269 },
                    { new DateTime(2024, 2, 16, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8440), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 94544 },
                    { new DateTime(2024, 2, 16, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8610), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 28017 },
                    { new DateTime(2024, 2, 16, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8780), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 99105 },
                    { new DateTime(2024, 2, 16, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8960), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 37349 },
                    { new DateTime(2024, 2, 16, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9130), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 12308 },
                    { new DateTime(2024, 2, 16, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9320), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 53063 },
                    { new DateTime(2024, 2, 16, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9490), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 10286 },
                    { new DateTime(2024, 2, 16, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9670), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 30453 },
                    { new DateTime(2024, 2, 16, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9840), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 23698 },
                    { new DateTime(2024, 2, 16, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(30), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 31629 },
                    { new DateTime(2024, 2, 17, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8440), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 62750 },
                    { new DateTime(2024, 2, 17, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8610), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 53561 },
                    { new DateTime(2024, 2, 17, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8780), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 20754 },
                    { new DateTime(2024, 2, 17, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8970), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 79400 },
                    { new DateTime(2024, 2, 17, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9140), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 32644 },
                    { new DateTime(2024, 2, 17, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9320), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 72511 },
                    { new DateTime(2024, 2, 17, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9490), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 8601 },
                    { new DateTime(2024, 2, 17, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9670), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 89894 },
                    { new DateTime(2024, 2, 17, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9840), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 27078 },
                    { new DateTime(2024, 2, 17, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(30), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 64805 },
                    { new DateTime(2024, 2, 18, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8450), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 11968 },
                    { new DateTime(2024, 2, 18, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8620), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 54200 },
                    { new DateTime(2024, 2, 18, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8780), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 2657 },
                    { new DateTime(2024, 2, 18, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8970), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 40705 },
                    { new DateTime(2024, 2, 18, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9140), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 73168 },
                    { new DateTime(2024, 2, 18, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9330), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 33049 },
                    { new DateTime(2024, 2, 18, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9490), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 93246 },
                    { new DateTime(2024, 2, 18, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9680), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 80256 },
                    { new DateTime(2024, 2, 18, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9850), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 26554 },
                    { new DateTime(2024, 2, 18, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(40), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 60624 },
                    { new DateTime(2024, 2, 19, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8450), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 38486 },
                    { new DateTime(2024, 2, 19, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8620), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 18074 },
                    { new DateTime(2024, 2, 19, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8790), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 13949 },
                    { new DateTime(2024, 2, 19, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8970), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 56762 },
                    { new DateTime(2024, 2, 19, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9140), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 13213 },
                    { new DateTime(2024, 2, 19, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9330), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 12665 },
                    { new DateTime(2024, 2, 19, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9500), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 77672 },
                    { new DateTime(2024, 2, 19, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9680), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 35664 },
                    { new DateTime(2024, 2, 19, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9850), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 15427 },
                    { new DateTime(2024, 2, 19, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(40), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 37135 },
                    { new DateTime(2024, 2, 20, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8450), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 29834 },
                    { new DateTime(2024, 2, 20, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8620), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 61262 },
                    { new DateTime(2024, 2, 20, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8790), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 93164 },
                    { new DateTime(2024, 2, 20, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8980), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 76086 },
                    { new DateTime(2024, 2, 20, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9150), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 49315 },
                    { new DateTime(2024, 2, 20, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9330), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 91292 },
                    { new DateTime(2024, 2, 20, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9500), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 97131 },
                    { new DateTime(2024, 2, 20, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9680), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 1423 },
                    { new DateTime(2024, 2, 20, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9860), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 13717 },
                    { new DateTime(2024, 2, 20, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(40), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 74755 },
                    { new DateTime(2024, 2, 21, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8460), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 45057 },
                    { new DateTime(2024, 2, 21, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8630), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 44076 },
                    { new DateTime(2024, 2, 21, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8810), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 43619 },
                    { new DateTime(2024, 2, 21, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8980), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 8279 },
                    { new DateTime(2024, 2, 21, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9150), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 33587 },
                    { new DateTime(2024, 2, 21, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9340), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 52404 },
                    { new DateTime(2024, 2, 21, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9500), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 58370 },
                    { new DateTime(2024, 2, 21, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9690), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 22520 },
                    { new DateTime(2024, 2, 21, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9860), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 66310 },
                    { new DateTime(2024, 2, 21, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(50), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 90775 },
                    { new DateTime(2024, 2, 22, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8460), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 27442 },
                    { new DateTime(2024, 2, 22, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8630), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 42874 },
                    { new DateTime(2024, 2, 22, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8820), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 86875 },
                    { new DateTime(2024, 2, 22, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8980), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 69823 },
                    { new DateTime(2024, 2, 22, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9150), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 9709 },
                    { new DateTime(2024, 2, 22, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9340), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 63464 },
                    { new DateTime(2024, 2, 22, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9510), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 36027 },
                    { new DateTime(2024, 2, 22, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9690), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 85707 },
                    { new DateTime(2024, 2, 22, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9860), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 77995 },
                    { new DateTime(2024, 2, 22, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(50), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 9637 },
                    { new DateTime(2024, 2, 23, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8460), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 11226 },
                    { new DateTime(2024, 2, 23, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8630), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 43023 },
                    { new DateTime(2024, 2, 23, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8820), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 90521 },
                    { new DateTime(2024, 2, 23, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8990), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 6062 },
                    { new DateTime(2024, 2, 23, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9160), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 77399 },
                    { new DateTime(2024, 2, 23, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9340), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 52257 },
                    { new DateTime(2024, 2, 23, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9510), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 18990 },
                    { new DateTime(2024, 2, 23, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9690), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 3427 },
                    { new DateTime(2024, 2, 23, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9870), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 69575 },
                    { new DateTime(2024, 2, 23, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(50), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 41062 },
                    { new DateTime(2024, 2, 24, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8470), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 90905 },
                    { new DateTime(2024, 2, 24, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8640), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 82457 },
                    { new DateTime(2024, 2, 24, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8820), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 59072 },
                    { new DateTime(2024, 2, 24, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8990), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 51483 },
                    { new DateTime(2024, 2, 24, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9160), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 21005 },
                    { new DateTime(2024, 2, 24, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9350), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 38084 },
                    { new DateTime(2024, 2, 24, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9510), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 48761 },
                    { new DateTime(2024, 2, 24, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9700), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 38299 },
                    { new DateTime(2024, 2, 24, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9870), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 96637 },
                    { new DateTime(2024, 2, 24, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(60), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 15794 },
                    { new DateTime(2024, 2, 25, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8470), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 69819 },
                    { new DateTime(2024, 2, 25, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8640), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 55394 },
                    { new DateTime(2024, 2, 25, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8830), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 29612 },
                    { new DateTime(2024, 2, 25, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8990), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 19428 },
                    { new DateTime(2024, 2, 25, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9160), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 24654 },
                    { new DateTime(2024, 2, 25, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9350), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 83479 },
                    { new DateTime(2024, 2, 25, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9520), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 91156 },
                    { new DateTime(2024, 2, 25, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9700), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 52640 },
                    { new DateTime(2024, 2, 25, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9870), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 31419 },
                    { new DateTime(2024, 2, 25, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(60), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 21169 },
                    { new DateTime(2024, 2, 26, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8470), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 43388 },
                    { new DateTime(2024, 2, 26, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8640), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 10702 },
                    { new DateTime(2024, 2, 26, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8830), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 46005 },
                    { new DateTime(2024, 2, 26, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9000), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 53711 },
                    { new DateTime(2024, 2, 26, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9170), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 87493 },
                    { new DateTime(2024, 2, 26, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9350), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 41341 },
                    { new DateTime(2024, 2, 26, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9520), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 15174 },
                    { new DateTime(2024, 2, 26, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9700), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 23649 },
                    { new DateTime(2024, 2, 26, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9880), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 70843 },
                    { new DateTime(2024, 2, 26, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(60), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 66754 },
                    { new DateTime(2024, 2, 27, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8480), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 89946 },
                    { new DateTime(2024, 2, 27, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8650), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 84614 },
                    { new DateTime(2024, 2, 27, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8830), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 22508 },
                    { new DateTime(2024, 2, 27, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9000), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 44259 },
                    { new DateTime(2024, 2, 27, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9170), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 48893 },
                    { new DateTime(2024, 2, 27, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9360), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 67546 },
                    { new DateTime(2024, 2, 27, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9520), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 91662 },
                    { new DateTime(2024, 2, 27, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9710), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 61766 },
                    { new DateTime(2024, 2, 27, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9880), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 43411 },
                    { new DateTime(2024, 2, 27, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(70), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 6070 },
                    { new DateTime(2024, 2, 28, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8480), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 29000 },
                    { new DateTime(2024, 2, 28, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8650), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 81609 },
                    { new DateTime(2024, 2, 28, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8840), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 40423 },
                    { new DateTime(2024, 2, 28, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9000), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 36197 },
                    { new DateTime(2024, 2, 28, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9170), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 29748 },
                    { new DateTime(2024, 2, 28, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9360), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 83956 },
                    { new DateTime(2024, 2, 28, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9540), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 22436 },
                    { new DateTime(2024, 2, 28, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9710), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 48580 },
                    { new DateTime(2024, 2, 28, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9880), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 36965 },
                    { new DateTime(2024, 2, 28, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(70), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 73393 },
                    { new DateTime(2024, 2, 29, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8480), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 42669 },
                    { new DateTime(2024, 2, 29, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8650), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 48444 },
                    { new DateTime(2024, 2, 29, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8840), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 13734 },
                    { new DateTime(2024, 2, 29, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9010), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 99611 },
                    { new DateTime(2024, 2, 29, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9180), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 46154 },
                    { new DateTime(2024, 2, 29, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9360), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 35141 },
                    { new DateTime(2024, 2, 29, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9550), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 57573 },
                    { new DateTime(2024, 2, 29, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9710), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 70383 },
                    { new DateTime(2024, 2, 29, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9890), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 5966 },
                    { new DateTime(2024, 2, 29, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(70), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 58158 },
                    { new DateTime(2024, 3, 1, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8490), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 95302 },
                    { new DateTime(2024, 3, 1, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8660), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 75614 },
                    { new DateTime(2024, 3, 1, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8840), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 35963 },
                    { new DateTime(2024, 3, 1, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9010), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 95878 },
                    { new DateTime(2024, 3, 1, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9180), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 5717 },
                    { new DateTime(2024, 3, 1, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9370), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 50990 },
                    { new DateTime(2024, 3, 1, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9550), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 25289 },
                    { new DateTime(2024, 3, 1, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9720), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 98378 },
                    { new DateTime(2024, 3, 1, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9890), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 90853 },
                    { new DateTime(2024, 3, 1, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(80), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 50124 },
                    { new DateTime(2024, 3, 2, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8490), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 63395 },
                    { new DateTime(2024, 3, 2, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8660), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 64948 },
                    { new DateTime(2024, 3, 2, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8850), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 29606 },
                    { new DateTime(2024, 3, 2, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9010), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 30404 },
                    { new DateTime(2024, 3, 2, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9180), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 33644 },
                    { new DateTime(2024, 3, 2, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9370), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 83997 },
                    { new DateTime(2024, 3, 2, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9550), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 16470 },
                    { new DateTime(2024, 3, 2, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9720), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 91100 },
                    { new DateTime(2024, 3, 2, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9890), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 70868 },
                    { new DateTime(2024, 3, 2, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(80), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 36624 },
                    { new DateTime(2024, 3, 3, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8490), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 28602 },
                    { new DateTime(2024, 3, 3, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8660), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 45407 },
                    { new DateTime(2024, 3, 3, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8850), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 29109 },
                    { new DateTime(2024, 3, 3, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9020), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 13116 },
                    { new DateTime(2024, 3, 3, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9190), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 49636 },
                    { new DateTime(2024, 3, 3, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9370), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 22973 },
                    { new DateTime(2024, 3, 3, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9560), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 32057 },
                    { new DateTime(2024, 3, 3, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9720), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 87912 },
                    { new DateTime(2024, 3, 3, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9900), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 44134 },
                    { new DateTime(2024, 3, 3, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(80), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 40102 },
                    { new DateTime(2024, 3, 4, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8500), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 30297 },
                    { new DateTime(2024, 3, 4, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8670), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 5517 },
                    { new DateTime(2024, 3, 4, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8850), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 36115 },
                    { new DateTime(2024, 3, 4, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9020), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 88322 },
                    { new DateTime(2024, 3, 4, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9200), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 15364 },
                    { new DateTime(2024, 3, 4, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9380), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 59095 },
                    { new DateTime(2024, 3, 4, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9560), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 27708 },
                    { new DateTime(2024, 3, 4, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9730), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 39833 },
                    { new DateTime(2024, 3, 4, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9900), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 23963 },
                    { new DateTime(2024, 3, 4, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(90), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 62664 },
                    { new DateTime(2024, 3, 5, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8500), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 85836 },
                    { new DateTime(2024, 3, 5, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8670), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 71011 },
                    { new DateTime(2024, 3, 5, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8860), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 75600 },
                    { new DateTime(2024, 3, 5, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9020), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 71081 },
                    { new DateTime(2024, 3, 5, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9210), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 92476 },
                    { new DateTime(2024, 3, 5, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9380), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 14951 },
                    { new DateTime(2024, 3, 5, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9560), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 57694 },
                    { new DateTime(2024, 3, 5, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9730), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 78605 },
                    { new DateTime(2024, 3, 5, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9900), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 23722 },
                    { new DateTime(2024, 3, 5, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(90), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 11463 },
                    { new DateTime(2024, 3, 6, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8500), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 98516 },
                    { new DateTime(2024, 3, 6, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8670), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 86964 },
                    { new DateTime(2024, 3, 6, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8860), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 40186 },
                    { new DateTime(2024, 3, 6, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9030), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 22541 },
                    { new DateTime(2024, 3, 6, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9210), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 77882 },
                    { new DateTime(2024, 3, 6, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9380), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 82867 },
                    { new DateTime(2024, 3, 6, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9570), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 65081 },
                    { new DateTime(2024, 3, 6, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9740), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 57164 },
                    { new DateTime(2024, 3, 6, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9910), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 49029 },
                    { new DateTime(2024, 3, 6, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(90), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 52570 },
                    { new DateTime(2024, 3, 7, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8510), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 12877 },
                    { new DateTime(2024, 3, 7, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8680), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 49112 },
                    { new DateTime(2024, 3, 7, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8860), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 36538 },
                    { new DateTime(2024, 3, 7, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9030), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 62927 },
                    { new DateTime(2024, 3, 7, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9210), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 65471 },
                    { new DateTime(2024, 3, 7, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9390), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 75450 },
                    { new DateTime(2024, 3, 7, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9570), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 16534 },
                    { new DateTime(2024, 3, 7, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9740), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 68268 },
                    { new DateTime(2024, 3, 7, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9910), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 63937 },
                    { new DateTime(2024, 3, 7, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(100), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 81037 },
                    { new DateTime(2024, 3, 8, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8510), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 7597 },
                    { new DateTime(2024, 3, 8, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8680), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 14386 },
                    { new DateTime(2024, 3, 8, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8870), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 51684 },
                    { new DateTime(2024, 3, 8, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9030), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 58409 },
                    { new DateTime(2024, 3, 8, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9220), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 46356 },
                    { new DateTime(2024, 3, 8, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9390), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 6673 },
                    { new DateTime(2024, 3, 8, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9570), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 45283 },
                    { new DateTime(2024, 3, 8, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9740), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 48059 },
                    { new DateTime(2024, 3, 8, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9910), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 69448 },
                    { new DateTime(2024, 3, 8, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(100), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 70230 },
                    { new DateTime(2024, 3, 9, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8510), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 16786 },
                    { new DateTime(2024, 3, 9, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8680), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 95653 },
                    { new DateTime(2024, 3, 9, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8870), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 90132 },
                    { new DateTime(2024, 3, 9, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9040), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 58508 },
                    { new DateTime(2024, 3, 9, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9220), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 8254 },
                    { new DateTime(2024, 3, 9, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9390), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 74727 },
                    { new DateTime(2024, 3, 9, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9580), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 46008 },
                    { new DateTime(2024, 3, 9, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9750), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 13968 },
                    { new DateTime(2024, 3, 9, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9920), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 61112 },
                    { new DateTime(2024, 3, 9, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(100), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 66693 },
                    { new DateTime(2024, 3, 10, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8520), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 56983 },
                    { new DateTime(2024, 3, 10, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8690), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 25014 },
                    { new DateTime(2024, 3, 10, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8870), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 9366 },
                    { new DateTime(2024, 3, 10, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9040), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 72847 },
                    { new DateTime(2024, 3, 10, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9220), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 39323 },
                    { new DateTime(2024, 3, 10, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9400), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 57091 },
                    { new DateTime(2024, 3, 10, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9580), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 1034 },
                    { new DateTime(2024, 3, 10, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9750), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 71776 },
                    { new DateTime(2024, 3, 10, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9920), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 87071 },
                    { new DateTime(2024, 3, 10, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(110), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 80348 },
                    { new DateTime(2024, 3, 11, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8520), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 62334 },
                    { new DateTime(2024, 3, 11, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8690), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 31638 },
                    { new DateTime(2024, 3, 11, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8880), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 48598 },
                    { new DateTime(2024, 3, 11, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9040), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 45918 },
                    { new DateTime(2024, 3, 11, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9230), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 86053 },
                    { new DateTime(2024, 3, 11, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9400), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 60758 },
                    { new DateTime(2024, 3, 11, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9580), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 18381 },
                    { new DateTime(2024, 3, 11, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9750), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 28580 },
                    { new DateTime(2024, 3, 11, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9920), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 75832 },
                    { new DateTime(2024, 3, 11, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(110), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 34110 },
                    { new DateTime(2024, 3, 12, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8520), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 29592 },
                    { new DateTime(2024, 3, 12, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8690), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 78091 },
                    { new DateTime(2024, 3, 12, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8880), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 56083 },
                    { new DateTime(2024, 3, 12, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9050), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 34565 },
                    { new DateTime(2024, 3, 12, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9230), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 31624 },
                    { new DateTime(2024, 3, 12, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9400), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 64138 },
                    { new DateTime(2024, 3, 12, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9590), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 52488 },
                    { new DateTime(2024, 3, 12, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9760), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 84564 },
                    { new DateTime(2024, 3, 12, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9930), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 35785 },
                    { new DateTime(2024, 3, 12, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(110), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 81917 },
                    { new DateTime(2024, 3, 13, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8530), new Guid("e5bedcc8-3730-4bc4-8a14-71dc11c3d150"), 76982 },
                    { new DateTime(2024, 3, 13, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8700), new Guid("1e78c3d2-d832-4cad-8819-ab2fd3d5520e"), 5096 },
                    { new DateTime(2024, 3, 13, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(8880), new Guid("4bc2fd27-5abc-41e7-9ec7-462318c7d122"), 56649 },
                    { new DateTime(2024, 3, 13, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9050), new Guid("b282e00c-f9cd-4293-b92b-cd97aad593bb"), 75369 },
                    { new DateTime(2024, 3, 13, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9230), new Guid("02ec0d77-a3bc-4a96-b74d-3f3a8c1e1e22"), 43550 },
                    { new DateTime(2024, 3, 13, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9410), new Guid("4237fea8-26e3-4a74-9649-710a609e0f42"), 3009 },
                    { new DateTime(2024, 3, 13, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9590), new Guid("77a22535-d2d7-498d-88e2-fd21145af4c9"), 36516 },
                    { new DateTime(2024, 3, 13, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9760), new Guid("dc266dc3-56a2-4960-bd7d-625f0b215a59"), 36215 },
                    { new DateTime(2024, 3, 13, 18, 38, 47, 40, DateTimeKind.Local).AddTicks(9930), new Guid("5dfda2c3-f865-45af-9bfc-a498fe0725a1"), 6213 },
                    { new DateTime(2024, 3, 13, 18, 38, 47, 41, DateTimeKind.Local).AddTicks(120), new Guid("ea1befec-bbff-4187-a522-6cd1abc96a86"), 4505 }
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
                name: "Variables");

            migrationBuilder.DropTable(
                name: "Badges");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
