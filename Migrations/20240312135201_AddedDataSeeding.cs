using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StarFitApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Badges_Users_UserId",
                table: "Badges");

            migrationBuilder.DropIndex(
                name: "IX_Badges_UserId",
                table: "Badges");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Badges");

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "id", "created_at", "description", "end_date", "illustration_path", "published", "start_date", "title", "updated_at" },
                values: new object[,]
                {
                    { new Guid("180a9fc1-8436-4b1a-aea6-42e6dce37e17"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5680), "Content 3", null, "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5680), "Article 3", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5680) },
                    { new Guid("1d028ab7-eadf-44db-b5e6-6108666ecf56"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5720), "Content 7", null, "https://thumbs.dreamstime.com/b/bald-man-thumbs-up-26364248.jpg", true, new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5720), "Article 7", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5720) },
                    { new Guid("4bf48208-a5cc-434c-9044-0a0cff14394e"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5660), "Content 1", null, "https://thumbs.dreamstime.com/b/bald-man-thumbs-up-26364248.jpg", true, new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5660), "Article 1", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5670) },
                    { new Guid("58cedbd3-fdf9-4d3a-8b8a-796ba8c4f1ee"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5650), "Content 0", null, "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5650), "Article 0", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5660) },
                    { new Guid("6b78785c-36a7-45c1-a6b8-a7c7023c0ab4"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5690), "Content 4", null, "https://thumbs.dreamstime.com/b/bald-man-thumbs-up-26364248.jpg", true, new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5690), "Article 4", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5690) },
                    { new Guid("83b76861-276b-4467-bd44-216fdd022944"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5670), "Content 2", null, "https://previews.123rf.com/images/ambro/ambro1112/ambro111200418/11558816-businessman-with-thumbs-up.jpg", true, new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5670), "Article 2", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5670) },
                    { new Guid("96f110b0-adc7-41ba-935b-37407f2dd73b"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5700), "Content 5", null, "https://previews.123rf.com/images/ambro/ambro1112/ambro111200418/11558816-businessman-with-thumbs-up.jpg", true, new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5700), "Article 5", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5700) },
                    { new Guid("e1d36973-c75d-4152-87a9-d5e7c9c3f694"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5730), "Content 8", null, "https://previews.123rf.com/images/ambro/ambro1112/ambro111200418/11558816-businessman-with-thumbs-up.jpg", true, new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5730), "Article 8", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5730) },
                    { new Guid("efe8bb92-f020-4073-9e6a-a24d45de44b2"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5740), "Content 9", null, "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5740), "Article 9", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5740) },
                    { new Guid("fffe1b91-4208-4a16-9673-7d4e7948820e"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5710), "Content 6", null, "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5710), "Article 6", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5710) }
                });

            migrationBuilder.InsertData(
                table: "Badges",
                columns: new[] { "id", "created_at", "description", "icon_path", "title", "updated_at" },
                values: new object[,]
                {
                    { new Guid("056787a9-a3b2-47e1-9b59-f14f2567da55"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5440), "Content 9", "https://png.pngtree.com/png-vector/20201229/ourmid/pngtree-a-squatting-tabby-cat-png-image_2664942.jpg", "Badge 9", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5440) },
                    { new Guid("0860b6b9-67f9-4f76-88f4-3da519c0a41a"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5430), "Content 8", "https://pngimg.com/uploads/cat/cat_PNG50447.png", "Badge 8", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5430) },
                    { new Guid("088a0a4a-f8ae-4d5c-8e8c-607306af44b6"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5420), "Content 6", "https://png.pngtree.com/png-vector/20201229/ourmid/pngtree-a-squatting-tabby-cat-png-image_2664942.jpg", "Badge 6", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5420) },
                    { new Guid("09f58060-d588-420d-9a23-d24fb55c30e6"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5410), "Content 5", "https://pngimg.com/uploads/cat/cat_PNG50447.png", "Badge 5", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5410) },
                    { new Guid("420ef61a-19d5-4753-abb9-f6a4a4d78541"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5370), "Content 3", "https://png.pngtree.com/png-vector/20201229/ourmid/pngtree-a-squatting-tabby-cat-png-image_2664942.jpg", "Badge 3", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5370) },
                    { new Guid("596a5968-88d8-464d-8819-41945b355b1e"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5370), "Content 2", "https://pngimg.com/uploads/cat/cat_PNG50447.png", "Badge 2", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5370) },
                    { new Guid("5a33a6b3-b7c6-4ce2-8175-3d039d563334"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5430), "Content 7", "https://images.rawpixel.com/image_png_800/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvcHUyMzMxNjM5LWltYWdlXzItbDBqOXFvd3IucG5n.png", "Badge 7", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5430) },
                    { new Guid("77ce9027-03cd-46f6-a324-959516ba7baf"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5380), "Content 4", "https://images.rawpixel.com/image_png_800/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvcHUyMzMxNjM5LWltYWdlXzItbDBqOXFvd3IucG5n.png", "Badge 4", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5380) },
                    { new Guid("d660c9ab-7e40-4c07-879f-02393941e7fa"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5360), "Content 1", "https://images.rawpixel.com/image_png_800/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvcHUyMzMxNjM5LWltYWdlXzItbDBqOXFvd3IucG5n.png", "Badge 1", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5360) },
                    { new Guid("d689d93f-c2d4-4fd3-9474-956689a0c0c0"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5350), "Content 0", "https://png.pngtree.com/png-vector/20201229/ourmid/pngtree-a-squatting-tabby-cat-png-image_2664942.jpg", "Badge 0", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5350) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "created_at", "identifier", "updated_at" },
                values: new object[,]
                {
                    { new Guid("072f8d0c-6eee-4134-967a-c3b9841d32bb"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5240), "user3", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5240) },
                    { new Guid("33bb9294-5a37-466d-99a6-f10a8943a7a1"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5230), "user1", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5230) },
                    { new Guid("35e2038f-1270-4e39-b339-0722fd96c290"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5240), "user2", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5240) },
                    { new Guid("3facdf10-34a5-4d32-8cd8-bee7a987fcdd"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5180), "user0", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5220) },
                    { new Guid("544a7928-1615-467b-8d78-43d58ef76fb9"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5270), "user7", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5280) },
                    { new Guid("6f06e222-9f13-46a6-b557-9d170c914400"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5290), "user9", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5290) },
                    { new Guid("9d35594b-1767-4c7d-a198-608cdc477c6f"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5260), "user5", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5260) },
                    { new Guid("a0cb37a9-c099-4ecf-bc5e-c9ea6321a288"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5250), "user4", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5250) },
                    { new Guid("dde09414-7bb9-4fc7-a1e0-e02405259f6b"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5270), "user6", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5270) },
                    { new Guid("ebf21593-ce34-426d-b8c6-388d67ddc9ed"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5280), "user8", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5280) }
                });

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "id", "badge_id", "created_at", "description", "end_date", "is_global", "objective", "start_date", "title", "updated_at" },
                values: new object[,]
                {
                    { new Guid("1c98675d-cb92-4ed5-b97e-3e2f48a3b630"), new Guid("5a33a6b3-b7c6-4ce2-8175-3d039d563334"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5600), "Content 7", new DateTime(2024, 4, 11, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5600), false, 16638, new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5600), "Challenge 7", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5600) },
                    { new Guid("268217ed-57a1-4534-ab36-33ffd341e44f"), new Guid("09f58060-d588-420d-9a23-d24fb55c30e6"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5570), "Content 5", new DateTime(2024, 4, 11, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5570), false, 39490, new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5570), "Challenge 5", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5580) },
                    { new Guid("2852fddd-d085-4bf1-9604-a8b453a0d5c3"), new Guid("088a0a4a-f8ae-4d5c-8e8c-607306af44b6"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5590), "Content 6", new DateTime(2024, 4, 11, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5590), true, 31508, new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5580), "Challenge 6", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5590) },
                    { new Guid("2deb17b8-8c6f-4ca7-8736-72c0765c24aa"), new Guid("77ce9027-03cd-46f6-a324-959516ba7baf"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5560), "Content 4", new DateTime(2024, 4, 11, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5560), true, 25580, new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5560), "Challenge 4", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5560) },
                    { new Guid("3c284fd6-59f7-4d8b-b31e-02d3efa06133"), new Guid("056787a9-a3b2-47e1-9b59-f14f2567da55"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5620), "Content 9", new DateTime(2024, 4, 11, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5620), false, 50488, new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5620), "Challenge 9", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5620) },
                    { new Guid("4d89709f-29a9-45b8-a176-cc1aabc94dc8"), new Guid("420ef61a-19d5-4753-abb9-f6a4a4d78541"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5550), "Content 3", new DateTime(2024, 4, 11, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5550), false, 20112, new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5550), "Challenge 3", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5550) },
                    { new Guid("4f6c0e85-53be-4d45-bfdf-787a76f133df"), new Guid("d689d93f-c2d4-4fd3-9474-956689a0c0c0"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5510), "Content 0", new DateTime(2024, 4, 11, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5500), true, 67579, new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5500), "Challenge 0", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5510) },
                    { new Guid("7d73a64f-7c9f-4c7a-b4a7-69956afafbff"), new Guid("d660c9ab-7e40-4c07-879f-02393941e7fa"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5520), "Content 1", new DateTime(2024, 4, 11, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5520), false, 24813, new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5520), "Challenge 1", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5530) },
                    { new Guid("a3f0d29d-dada-4b64-91a2-a953e50812ee"), new Guid("596a5968-88d8-464d-8819-41945b355b1e"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5540), "Content 2", new DateTime(2024, 4, 11, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5540), true, 8071, new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5540), "Challenge 2", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5540) },
                    { new Guid("ea039c2f-8931-405c-89d6-8b38fd2c9523"), new Guid("0860b6b9-67f9-4f76-88f4-3da519c0a41a"), new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5610), "Content 8", new DateTime(2024, 4, 11, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5610), true, 52989, new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5610), "Challenge 8", new DateTime(2024, 3, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5610) }
                });

            migrationBuilder.InsertData(
                table: "DayOfWalk",
                columns: new[] { "date", "user_id", "steps" },
                values: new object[,]
                {
                    { new DateTime(2023, 12, 3, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5760), new Guid("3facdf10-34a5-4d32-8cd8-bee7a987fcdd"), 1000 },
                    { new DateTime(2023, 12, 4, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5760), new Guid("33bb9294-5a37-466d-99a6-f10a8943a7a1"), 1000 },
                    { new DateTime(2023, 12, 5, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5770), new Guid("35e2038f-1270-4e39-b339-0722fd96c290"), 1000 },
                    { new DateTime(2023, 12, 6, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5770), new Guid("072f8d0c-6eee-4134-967a-c3b9841d32bb"), 1000 },
                    { new DateTime(2023, 12, 7, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5780), new Guid("a0cb37a9-c099-4ecf-bc5e-c9ea6321a288"), 1000 },
                    { new DateTime(2023, 12, 8, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5780), new Guid("9d35594b-1767-4c7d-a198-608cdc477c6f"), 1000 },
                    { new DateTime(2023, 12, 9, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5780), new Guid("dde09414-7bb9-4fc7-a1e0-e02405259f6b"), 1000 },
                    { new DateTime(2023, 12, 10, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5790), new Guid("544a7928-1615-467b-8d78-43d58ef76fb9"), 1000 },
                    { new DateTime(2023, 12, 11, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5790), new Guid("ebf21593-ce34-426d-b8c6-388d67ddc9ed"), 1000 },
                    { new DateTime(2023, 12, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5800), new Guid("6f06e222-9f13-46a6-b557-9d170c914400"), 1000 },
                    { new DateTime(2023, 12, 13, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5800), new Guid("3facdf10-34a5-4d32-8cd8-bee7a987fcdd"), 1000 },
                    { new DateTime(2023, 12, 14, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5800), new Guid("33bb9294-5a37-466d-99a6-f10a8943a7a1"), 1000 },
                    { new DateTime(2023, 12, 15, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5810), new Guid("35e2038f-1270-4e39-b339-0722fd96c290"), 1000 },
                    { new DateTime(2023, 12, 16, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5810), new Guid("072f8d0c-6eee-4134-967a-c3b9841d32bb"), 1000 },
                    { new DateTime(2023, 12, 17, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5820), new Guid("a0cb37a9-c099-4ecf-bc5e-c9ea6321a288"), 1000 },
                    { new DateTime(2023, 12, 18, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5820), new Guid("9d35594b-1767-4c7d-a198-608cdc477c6f"), 1000 },
                    { new DateTime(2023, 12, 19, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5820), new Guid("dde09414-7bb9-4fc7-a1e0-e02405259f6b"), 1000 },
                    { new DateTime(2023, 12, 20, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5830), new Guid("544a7928-1615-467b-8d78-43d58ef76fb9"), 1000 },
                    { new DateTime(2023, 12, 21, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5830), new Guid("ebf21593-ce34-426d-b8c6-388d67ddc9ed"), 1000 },
                    { new DateTime(2023, 12, 22, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5830), new Guid("6f06e222-9f13-46a6-b557-9d170c914400"), 1000 },
                    { new DateTime(2023, 12, 23, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5840), new Guid("3facdf10-34a5-4d32-8cd8-bee7a987fcdd"), 1000 },
                    { new DateTime(2023, 12, 24, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5840), new Guid("33bb9294-5a37-466d-99a6-f10a8943a7a1"), 1000 },
                    { new DateTime(2023, 12, 25, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5840), new Guid("35e2038f-1270-4e39-b339-0722fd96c290"), 1000 },
                    { new DateTime(2023, 12, 26, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5850), new Guid("072f8d0c-6eee-4134-967a-c3b9841d32bb"), 1000 },
                    { new DateTime(2023, 12, 27, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5850), new Guid("a0cb37a9-c099-4ecf-bc5e-c9ea6321a288"), 1000 },
                    { new DateTime(2023, 12, 28, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5850), new Guid("9d35594b-1767-4c7d-a198-608cdc477c6f"), 1000 },
                    { new DateTime(2023, 12, 29, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5860), new Guid("dde09414-7bb9-4fc7-a1e0-e02405259f6b"), 1000 },
                    { new DateTime(2023, 12, 30, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5860), new Guid("544a7928-1615-467b-8d78-43d58ef76fb9"), 1000 },
                    { new DateTime(2023, 12, 31, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5870), new Guid("ebf21593-ce34-426d-b8c6-388d67ddc9ed"), 1000 },
                    { new DateTime(2024, 1, 1, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5870), new Guid("6f06e222-9f13-46a6-b557-9d170c914400"), 1000 },
                    { new DateTime(2024, 1, 2, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5870), new Guid("3facdf10-34a5-4d32-8cd8-bee7a987fcdd"), 1000 },
                    { new DateTime(2024, 1, 3, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5880), new Guid("33bb9294-5a37-466d-99a6-f10a8943a7a1"), 1000 },
                    { new DateTime(2024, 1, 4, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5880), new Guid("35e2038f-1270-4e39-b339-0722fd96c290"), 1000 },
                    { new DateTime(2024, 1, 5, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5880), new Guid("072f8d0c-6eee-4134-967a-c3b9841d32bb"), 1000 },
                    { new DateTime(2024, 1, 6, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5890), new Guid("a0cb37a9-c099-4ecf-bc5e-c9ea6321a288"), 1000 },
                    { new DateTime(2024, 1, 7, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5890), new Guid("9d35594b-1767-4c7d-a198-608cdc477c6f"), 1000 },
                    { new DateTime(2024, 1, 8, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5890), new Guid("dde09414-7bb9-4fc7-a1e0-e02405259f6b"), 1000 },
                    { new DateTime(2024, 1, 9, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5900), new Guid("544a7928-1615-467b-8d78-43d58ef76fb9"), 1000 },
                    { new DateTime(2024, 1, 10, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5900), new Guid("ebf21593-ce34-426d-b8c6-388d67ddc9ed"), 1000 },
                    { new DateTime(2024, 1, 11, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5900), new Guid("6f06e222-9f13-46a6-b557-9d170c914400"), 1000 },
                    { new DateTime(2024, 1, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5910), new Guid("3facdf10-34a5-4d32-8cd8-bee7a987fcdd"), 1000 },
                    { new DateTime(2024, 1, 13, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5910), new Guid("33bb9294-5a37-466d-99a6-f10a8943a7a1"), 1000 },
                    { new DateTime(2024, 1, 14, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5910), new Guid("35e2038f-1270-4e39-b339-0722fd96c290"), 1000 },
                    { new DateTime(2024, 1, 15, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5920), new Guid("072f8d0c-6eee-4134-967a-c3b9841d32bb"), 1000 },
                    { new DateTime(2024, 1, 16, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5920), new Guid("a0cb37a9-c099-4ecf-bc5e-c9ea6321a288"), 1000 },
                    { new DateTime(2024, 1, 17, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5920), new Guid("9d35594b-1767-4c7d-a198-608cdc477c6f"), 1000 },
                    { new DateTime(2024, 1, 18, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5930), new Guid("dde09414-7bb9-4fc7-a1e0-e02405259f6b"), 1000 },
                    { new DateTime(2024, 1, 19, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5930), new Guid("544a7928-1615-467b-8d78-43d58ef76fb9"), 1000 },
                    { new DateTime(2024, 1, 20, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5940), new Guid("ebf21593-ce34-426d-b8c6-388d67ddc9ed"), 1000 },
                    { new DateTime(2024, 1, 21, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5940), new Guid("6f06e222-9f13-46a6-b557-9d170c914400"), 1000 },
                    { new DateTime(2024, 1, 22, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5940), new Guid("3facdf10-34a5-4d32-8cd8-bee7a987fcdd"), 1000 },
                    { new DateTime(2024, 1, 23, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5950), new Guid("33bb9294-5a37-466d-99a6-f10a8943a7a1"), 1000 },
                    { new DateTime(2024, 1, 24, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5950), new Guid("35e2038f-1270-4e39-b339-0722fd96c290"), 1000 },
                    { new DateTime(2024, 1, 25, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5950), new Guid("072f8d0c-6eee-4134-967a-c3b9841d32bb"), 1000 },
                    { new DateTime(2024, 1, 26, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5960), new Guid("a0cb37a9-c099-4ecf-bc5e-c9ea6321a288"), 1000 },
                    { new DateTime(2024, 1, 27, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5960), new Guid("9d35594b-1767-4c7d-a198-608cdc477c6f"), 1000 },
                    { new DateTime(2024, 1, 28, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5960), new Guid("dde09414-7bb9-4fc7-a1e0-e02405259f6b"), 1000 },
                    { new DateTime(2024, 1, 29, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5970), new Guid("544a7928-1615-467b-8d78-43d58ef76fb9"), 1000 },
                    { new DateTime(2024, 1, 30, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5970), new Guid("ebf21593-ce34-426d-b8c6-388d67ddc9ed"), 1000 },
                    { new DateTime(2024, 1, 31, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5970), new Guid("6f06e222-9f13-46a6-b557-9d170c914400"), 1000 },
                    { new DateTime(2024, 2, 1, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5980), new Guid("3facdf10-34a5-4d32-8cd8-bee7a987fcdd"), 1000 },
                    { new DateTime(2024, 2, 2, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5980), new Guid("33bb9294-5a37-466d-99a6-f10a8943a7a1"), 1000 },
                    { new DateTime(2024, 2, 3, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5980), new Guid("35e2038f-1270-4e39-b339-0722fd96c290"), 1000 },
                    { new DateTime(2024, 2, 4, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5990), new Guid("072f8d0c-6eee-4134-967a-c3b9841d32bb"), 1000 },
                    { new DateTime(2024, 2, 5, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5990), new Guid("a0cb37a9-c099-4ecf-bc5e-c9ea6321a288"), 1000 },
                    { new DateTime(2024, 2, 6, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5990), new Guid("9d35594b-1767-4c7d-a198-608cdc477c6f"), 1000 },
                    { new DateTime(2024, 2, 7, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6000), new Guid("dde09414-7bb9-4fc7-a1e0-e02405259f6b"), 1000 },
                    { new DateTime(2024, 2, 8, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6000), new Guid("544a7928-1615-467b-8d78-43d58ef76fb9"), 1000 },
                    { new DateTime(2024, 2, 9, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6000), new Guid("ebf21593-ce34-426d-b8c6-388d67ddc9ed"), 1000 },
                    { new DateTime(2024, 2, 10, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6010), new Guid("6f06e222-9f13-46a6-b557-9d170c914400"), 1000 },
                    { new DateTime(2024, 2, 11, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6010), new Guid("3facdf10-34a5-4d32-8cd8-bee7a987fcdd"), 1000 },
                    { new DateTime(2024, 2, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6020), new Guid("33bb9294-5a37-466d-99a6-f10a8943a7a1"), 1000 },
                    { new DateTime(2024, 2, 13, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6020), new Guid("35e2038f-1270-4e39-b339-0722fd96c290"), 1000 },
                    { new DateTime(2024, 2, 14, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6020), new Guid("072f8d0c-6eee-4134-967a-c3b9841d32bb"), 1000 },
                    { new DateTime(2024, 2, 15, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6030), new Guid("a0cb37a9-c099-4ecf-bc5e-c9ea6321a288"), 1000 },
                    { new DateTime(2024, 2, 16, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6030), new Guid("9d35594b-1767-4c7d-a198-608cdc477c6f"), 1000 },
                    { new DateTime(2024, 2, 17, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6030), new Guid("dde09414-7bb9-4fc7-a1e0-e02405259f6b"), 1000 },
                    { new DateTime(2024, 2, 18, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6040), new Guid("544a7928-1615-467b-8d78-43d58ef76fb9"), 1000 },
                    { new DateTime(2024, 2, 19, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6040), new Guid("ebf21593-ce34-426d-b8c6-388d67ddc9ed"), 1000 },
                    { new DateTime(2024, 2, 20, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6040), new Guid("6f06e222-9f13-46a6-b557-9d170c914400"), 1000 },
                    { new DateTime(2024, 2, 21, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6050), new Guid("3facdf10-34a5-4d32-8cd8-bee7a987fcdd"), 1000 },
                    { new DateTime(2024, 2, 22, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6050), new Guid("33bb9294-5a37-466d-99a6-f10a8943a7a1"), 1000 },
                    { new DateTime(2024, 2, 23, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6050), new Guid("35e2038f-1270-4e39-b339-0722fd96c290"), 1000 },
                    { new DateTime(2024, 2, 24, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6060), new Guid("072f8d0c-6eee-4134-967a-c3b9841d32bb"), 1000 },
                    { new DateTime(2024, 2, 25, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6060), new Guid("a0cb37a9-c099-4ecf-bc5e-c9ea6321a288"), 1000 },
                    { new DateTime(2024, 2, 26, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6060), new Guid("9d35594b-1767-4c7d-a198-608cdc477c6f"), 1000 },
                    { new DateTime(2024, 2, 27, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6070), new Guid("dde09414-7bb9-4fc7-a1e0-e02405259f6b"), 1000 },
                    { new DateTime(2024, 2, 28, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6070), new Guid("544a7928-1615-467b-8d78-43d58ef76fb9"), 1000 },
                    { new DateTime(2024, 2, 29, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6070), new Guid("ebf21593-ce34-426d-b8c6-388d67ddc9ed"), 1000 },
                    { new DateTime(2024, 3, 1, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6080), new Guid("6f06e222-9f13-46a6-b557-9d170c914400"), 1000 },
                    { new DateTime(2024, 3, 2, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6080), new Guid("3facdf10-34a5-4d32-8cd8-bee7a987fcdd"), 1000 },
                    { new DateTime(2024, 3, 3, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6080), new Guid("33bb9294-5a37-466d-99a6-f10a8943a7a1"), 1000 },
                    { new DateTime(2024, 3, 4, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6090), new Guid("35e2038f-1270-4e39-b339-0722fd96c290"), 1000 },
                    { new DateTime(2024, 3, 5, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6090), new Guid("072f8d0c-6eee-4134-967a-c3b9841d32bb"), 1000 },
                    { new DateTime(2024, 3, 6, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6100), new Guid("a0cb37a9-c099-4ecf-bc5e-c9ea6321a288"), 1000 },
                    { new DateTime(2024, 3, 7, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6100), new Guid("9d35594b-1767-4c7d-a198-608cdc477c6f"), 1000 },
                    { new DateTime(2024, 3, 8, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6100), new Guid("dde09414-7bb9-4fc7-a1e0-e02405259f6b"), 1000 },
                    { new DateTime(2024, 3, 9, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6110), new Guid("544a7928-1615-467b-8d78-43d58ef76fb9"), 1000 },
                    { new DateTime(2024, 3, 10, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6110), new Guid("ebf21593-ce34-426d-b8c6-388d67ddc9ed"), 1000 },
                    { new DateTime(2024, 3, 11, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6110), new Guid("6f06e222-9f13-46a6-b557-9d170c914400"), 1000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("180a9fc1-8436-4b1a-aea6-42e6dce37e17"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("1d028ab7-eadf-44db-b5e6-6108666ecf56"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("4bf48208-a5cc-434c-9044-0a0cff14394e"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("58cedbd3-fdf9-4d3a-8b8a-796ba8c4f1ee"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("6b78785c-36a7-45c1-a6b8-a7c7023c0ab4"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("83b76861-276b-4467-bd44-216fdd022944"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("96f110b0-adc7-41ba-935b-37407f2dd73b"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("e1d36973-c75d-4152-87a9-d5e7c9c3f694"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("efe8bb92-f020-4073-9e6a-a24d45de44b2"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("fffe1b91-4208-4a16-9673-7d4e7948820e"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("1c98675d-cb92-4ed5-b97e-3e2f48a3b630"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("268217ed-57a1-4534-ab36-33ffd341e44f"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("2852fddd-d085-4bf1-9604-a8b453a0d5c3"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("2deb17b8-8c6f-4ca7-8736-72c0765c24aa"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("3c284fd6-59f7-4d8b-b31e-02d3efa06133"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("4d89709f-29a9-45b8-a176-cc1aabc94dc8"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("4f6c0e85-53be-4d45-bfdf-787a76f133df"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("7d73a64f-7c9f-4c7a-b4a7-69956afafbff"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("a3f0d29d-dada-4b64-91a2-a953e50812ee"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("ea039c2f-8931-405c-89d6-8b38fd2c9523"));

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 3, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5760), new Guid("3facdf10-34a5-4d32-8cd8-bee7a987fcdd") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 4, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5760), new Guid("33bb9294-5a37-466d-99a6-f10a8943a7a1") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 5, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5770), new Guid("35e2038f-1270-4e39-b339-0722fd96c290") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 6, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5770), new Guid("072f8d0c-6eee-4134-967a-c3b9841d32bb") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 7, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5780), new Guid("a0cb37a9-c099-4ecf-bc5e-c9ea6321a288") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 8, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5780), new Guid("9d35594b-1767-4c7d-a198-608cdc477c6f") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 9, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5780), new Guid("dde09414-7bb9-4fc7-a1e0-e02405259f6b") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 10, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5790), new Guid("544a7928-1615-467b-8d78-43d58ef76fb9") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 11, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5790), new Guid("ebf21593-ce34-426d-b8c6-388d67ddc9ed") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5800), new Guid("6f06e222-9f13-46a6-b557-9d170c914400") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 13, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5800), new Guid("3facdf10-34a5-4d32-8cd8-bee7a987fcdd") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 14, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5800), new Guid("33bb9294-5a37-466d-99a6-f10a8943a7a1") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 15, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5810), new Guid("35e2038f-1270-4e39-b339-0722fd96c290") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 16, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5810), new Guid("072f8d0c-6eee-4134-967a-c3b9841d32bb") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 17, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5820), new Guid("a0cb37a9-c099-4ecf-bc5e-c9ea6321a288") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 18, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5820), new Guid("9d35594b-1767-4c7d-a198-608cdc477c6f") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 19, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5820), new Guid("dde09414-7bb9-4fc7-a1e0-e02405259f6b") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 20, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5830), new Guid("544a7928-1615-467b-8d78-43d58ef76fb9") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 21, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5830), new Guid("ebf21593-ce34-426d-b8c6-388d67ddc9ed") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 22, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5830), new Guid("6f06e222-9f13-46a6-b557-9d170c914400") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 23, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5840), new Guid("3facdf10-34a5-4d32-8cd8-bee7a987fcdd") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 24, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5840), new Guid("33bb9294-5a37-466d-99a6-f10a8943a7a1") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 25, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5840), new Guid("35e2038f-1270-4e39-b339-0722fd96c290") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 26, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5850), new Guid("072f8d0c-6eee-4134-967a-c3b9841d32bb") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 27, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5850), new Guid("a0cb37a9-c099-4ecf-bc5e-c9ea6321a288") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 28, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5850), new Guid("9d35594b-1767-4c7d-a198-608cdc477c6f") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 29, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5860), new Guid("dde09414-7bb9-4fc7-a1e0-e02405259f6b") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 30, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5860), new Guid("544a7928-1615-467b-8d78-43d58ef76fb9") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 31, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5870), new Guid("ebf21593-ce34-426d-b8c6-388d67ddc9ed") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 1, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5870), new Guid("6f06e222-9f13-46a6-b557-9d170c914400") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 2, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5870), new Guid("3facdf10-34a5-4d32-8cd8-bee7a987fcdd") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 3, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5880), new Guid("33bb9294-5a37-466d-99a6-f10a8943a7a1") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 4, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5880), new Guid("35e2038f-1270-4e39-b339-0722fd96c290") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 5, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5880), new Guid("072f8d0c-6eee-4134-967a-c3b9841d32bb") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 6, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5890), new Guid("a0cb37a9-c099-4ecf-bc5e-c9ea6321a288") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 7, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5890), new Guid("9d35594b-1767-4c7d-a198-608cdc477c6f") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 8, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5890), new Guid("dde09414-7bb9-4fc7-a1e0-e02405259f6b") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 9, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5900), new Guid("544a7928-1615-467b-8d78-43d58ef76fb9") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 10, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5900), new Guid("ebf21593-ce34-426d-b8c6-388d67ddc9ed") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 11, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5900), new Guid("6f06e222-9f13-46a6-b557-9d170c914400") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5910), new Guid("3facdf10-34a5-4d32-8cd8-bee7a987fcdd") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 13, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5910), new Guid("33bb9294-5a37-466d-99a6-f10a8943a7a1") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 14, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5910), new Guid("35e2038f-1270-4e39-b339-0722fd96c290") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 15, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5920), new Guid("072f8d0c-6eee-4134-967a-c3b9841d32bb") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 16, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5920), new Guid("a0cb37a9-c099-4ecf-bc5e-c9ea6321a288") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 17, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5920), new Guid("9d35594b-1767-4c7d-a198-608cdc477c6f") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 18, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5930), new Guid("dde09414-7bb9-4fc7-a1e0-e02405259f6b") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 19, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5930), new Guid("544a7928-1615-467b-8d78-43d58ef76fb9") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 20, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5940), new Guid("ebf21593-ce34-426d-b8c6-388d67ddc9ed") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 21, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5940), new Guid("6f06e222-9f13-46a6-b557-9d170c914400") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 22, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5940), new Guid("3facdf10-34a5-4d32-8cd8-bee7a987fcdd") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 23, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5950), new Guid("33bb9294-5a37-466d-99a6-f10a8943a7a1") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 24, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5950), new Guid("35e2038f-1270-4e39-b339-0722fd96c290") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 25, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5950), new Guid("072f8d0c-6eee-4134-967a-c3b9841d32bb") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 26, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5960), new Guid("a0cb37a9-c099-4ecf-bc5e-c9ea6321a288") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 27, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5960), new Guid("9d35594b-1767-4c7d-a198-608cdc477c6f") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 28, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5960), new Guid("dde09414-7bb9-4fc7-a1e0-e02405259f6b") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 29, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5970), new Guid("544a7928-1615-467b-8d78-43d58ef76fb9") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 30, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5970), new Guid("ebf21593-ce34-426d-b8c6-388d67ddc9ed") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 31, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5970), new Guid("6f06e222-9f13-46a6-b557-9d170c914400") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 1, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5980), new Guid("3facdf10-34a5-4d32-8cd8-bee7a987fcdd") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 2, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5980), new Guid("33bb9294-5a37-466d-99a6-f10a8943a7a1") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 3, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5980), new Guid("35e2038f-1270-4e39-b339-0722fd96c290") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 4, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5990), new Guid("072f8d0c-6eee-4134-967a-c3b9841d32bb") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 5, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5990), new Guid("a0cb37a9-c099-4ecf-bc5e-c9ea6321a288") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 6, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(5990), new Guid("9d35594b-1767-4c7d-a198-608cdc477c6f") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 7, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6000), new Guid("dde09414-7bb9-4fc7-a1e0-e02405259f6b") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 8, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6000), new Guid("544a7928-1615-467b-8d78-43d58ef76fb9") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 9, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6000), new Guid("ebf21593-ce34-426d-b8c6-388d67ddc9ed") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 10, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6010), new Guid("6f06e222-9f13-46a6-b557-9d170c914400") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 11, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6010), new Guid("3facdf10-34a5-4d32-8cd8-bee7a987fcdd") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 12, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6020), new Guid("33bb9294-5a37-466d-99a6-f10a8943a7a1") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 13, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6020), new Guid("35e2038f-1270-4e39-b339-0722fd96c290") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 14, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6020), new Guid("072f8d0c-6eee-4134-967a-c3b9841d32bb") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 15, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6030), new Guid("a0cb37a9-c099-4ecf-bc5e-c9ea6321a288") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 16, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6030), new Guid("9d35594b-1767-4c7d-a198-608cdc477c6f") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 17, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6030), new Guid("dde09414-7bb9-4fc7-a1e0-e02405259f6b") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 18, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6040), new Guid("544a7928-1615-467b-8d78-43d58ef76fb9") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 19, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6040), new Guid("ebf21593-ce34-426d-b8c6-388d67ddc9ed") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 20, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6040), new Guid("6f06e222-9f13-46a6-b557-9d170c914400") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 21, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6050), new Guid("3facdf10-34a5-4d32-8cd8-bee7a987fcdd") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 22, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6050), new Guid("33bb9294-5a37-466d-99a6-f10a8943a7a1") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 23, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6050), new Guid("35e2038f-1270-4e39-b339-0722fd96c290") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 24, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6060), new Guid("072f8d0c-6eee-4134-967a-c3b9841d32bb") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 25, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6060), new Guid("a0cb37a9-c099-4ecf-bc5e-c9ea6321a288") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 26, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6060), new Guid("9d35594b-1767-4c7d-a198-608cdc477c6f") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 27, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6070), new Guid("dde09414-7bb9-4fc7-a1e0-e02405259f6b") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 28, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6070), new Guid("544a7928-1615-467b-8d78-43d58ef76fb9") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 29, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6070), new Guid("ebf21593-ce34-426d-b8c6-388d67ddc9ed") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 1, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6080), new Guid("6f06e222-9f13-46a6-b557-9d170c914400") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 2, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6080), new Guid("3facdf10-34a5-4d32-8cd8-bee7a987fcdd") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 3, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6080), new Guid("33bb9294-5a37-466d-99a6-f10a8943a7a1") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 4, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6090), new Guid("35e2038f-1270-4e39-b339-0722fd96c290") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 5, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6090), new Guid("072f8d0c-6eee-4134-967a-c3b9841d32bb") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 6, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6100), new Guid("a0cb37a9-c099-4ecf-bc5e-c9ea6321a288") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 7, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6100), new Guid("9d35594b-1767-4c7d-a198-608cdc477c6f") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 8, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6100), new Guid("dde09414-7bb9-4fc7-a1e0-e02405259f6b") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 9, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6110), new Guid("544a7928-1615-467b-8d78-43d58ef76fb9") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 10, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6110), new Guid("ebf21593-ce34-426d-b8c6-388d67ddc9ed") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 11, 14, 52, 1, 790, DateTimeKind.Local).AddTicks(6110), new Guid("6f06e222-9f13-46a6-b557-9d170c914400") });

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("056787a9-a3b2-47e1-9b59-f14f2567da55"));

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("0860b6b9-67f9-4f76-88f4-3da519c0a41a"));

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("088a0a4a-f8ae-4d5c-8e8c-607306af44b6"));

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("09f58060-d588-420d-9a23-d24fb55c30e6"));

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("420ef61a-19d5-4753-abb9-f6a4a4d78541"));

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("596a5968-88d8-464d-8819-41945b355b1e"));

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("5a33a6b3-b7c6-4ce2-8175-3d039d563334"));

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("77ce9027-03cd-46f6-a324-959516ba7baf"));

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("d660c9ab-7e40-4c07-879f-02393941e7fa"));

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("d689d93f-c2d4-4fd3-9474-956689a0c0c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("072f8d0c-6eee-4134-967a-c3b9841d32bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("33bb9294-5a37-466d-99a6-f10a8943a7a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("35e2038f-1270-4e39-b339-0722fd96c290"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("3facdf10-34a5-4d32-8cd8-bee7a987fcdd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("544a7928-1615-467b-8d78-43d58ef76fb9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("6f06e222-9f13-46a6-b557-9d170c914400"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("9d35594b-1767-4c7d-a198-608cdc477c6f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("a0cb37a9-c099-4ecf-bc5e-c9ea6321a288"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("dde09414-7bb9-4fc7-a1e0-e02405259f6b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("ebf21593-ce34-426d-b8c6-388d67ddc9ed"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Badges",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Badges_UserId",
                table: "Badges",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Badges_Users_UserId",
                table: "Badges",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "id");
        }
    }
}
