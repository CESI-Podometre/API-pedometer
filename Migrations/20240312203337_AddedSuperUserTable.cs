using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StarFitApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedSuperUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("25e0f58c-9a35-4ba0-b124-ccadf54814bb"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("2cddf95f-14c4-468a-913d-a476f2c1b459"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("5a6a109d-3583-4d0c-8a10-98a7d25fa442"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("8be2d632-f11a-45ee-bcbf-5e2cff5e6c5d"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("8ce008af-ab55-4594-bbb8-0afec2a5e063"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("8d06b463-c76b-450e-bef2-794d3a902477"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("9aa5420c-d74b-41bf-a1ac-06d58a202d8c"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("9b0baf81-8309-4b83-b1f5-83094139f516"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("bbd40d30-ba67-4e47-a127-3b3cbe6641ec"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("cd07a751-670c-4ee2-aaac-b08d9639a393"));

            migrationBuilder.DeleteData(
                table: "BadgesToUser",
                keyColumns: new[] { "badge_id", "user_id" },
                keyValues: new object[] { new Guid("01ae81ee-7eb3-433b-a2e4-46b5e3865adf"), new Guid("245ca322-5ef8-4ca3-9205-fbaacdf5f3c4") });

            migrationBuilder.DeleteData(
                table: "BadgesToUser",
                keyColumns: new[] { "badge_id", "user_id" },
                keyValues: new object[] { new Guid("1da21246-c6c4-4721-a50c-80dc9bfa8098"), new Guid("2b427af7-6042-4cdf-bdf2-6753c7ab721f") });

            migrationBuilder.DeleteData(
                table: "BadgesToUser",
                keyColumns: new[] { "badge_id", "user_id" },
                keyValues: new object[] { new Guid("09ad58df-b5ad-4a19-826b-0c76d838bbc8"), new Guid("678b67be-9cd7-4c57-8df3-4e5882e4ae12") });

            migrationBuilder.DeleteData(
                table: "BadgesToUser",
                keyColumns: new[] { "badge_id", "user_id" },
                keyValues: new object[] { new Guid("5289271b-e3c6-4aa4-9006-03bc8bd7993e"), new Guid("9769ffb7-852d-4e97-80ed-19051890d5a1") });

            migrationBuilder.DeleteData(
                table: "BadgesToUser",
                keyColumns: new[] { "badge_id", "user_id" },
                keyValues: new object[] { new Guid("7b429312-5034-4cf0-ac86-70f4fae88857"), new Guid("9d586bd6-9d56-4741-86d7-d36d705a7aa8") });

            migrationBuilder.DeleteData(
                table: "BadgesToUser",
                keyColumns: new[] { "badge_id", "user_id" },
                keyValues: new object[] { new Guid("1888638c-0069-4874-81ac-3b0ca1b583a9"), new Guid("a1293e40-19d1-46dd-8daf-71c71ae8e624") });

            migrationBuilder.DeleteData(
                table: "BadgesToUser",
                keyColumns: new[] { "badge_id", "user_id" },
                keyValues: new object[] { new Guid("9a8b45d3-9acb-4298-882f-f68e798e003c"), new Guid("a98f8d20-4848-4433-a2a8-d43d566317cf") });

            migrationBuilder.DeleteData(
                table: "BadgesToUser",
                keyColumns: new[] { "badge_id", "user_id" },
                keyValues: new object[] { new Guid("12006009-4d55-4763-a26d-8e2d624fd3c4"), new Guid("c6e6d055-ba56-4452-b8c1-cfe6e0485f04") });

            migrationBuilder.DeleteData(
                table: "BadgesToUser",
                keyColumns: new[] { "badge_id", "user_id" },
                keyValues: new object[] { new Guid("5e14ccb3-dca2-45b5-94af-752602b52445"), new Guid("f8a3a977-0c45-4496-985c-af3bd724bd4c") });

            migrationBuilder.DeleteData(
                table: "BadgesToUser",
                keyColumns: new[] { "badge_id", "user_id" },
                keyValues: new object[] { new Guid("bf797fc6-e033-4220-8575-318db36ba831"), new Guid("f99b3654-72bd-4ce2-9540-49530d6c0804") });

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("1eeb354b-baa0-4354-880d-a06eaf1f1f63"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("2355ddf2-b26a-4a53-8458-88706993b759"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("276710bf-c82e-4036-b20f-cbef361a7abd"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("3343fb33-772d-469f-82aa-de8e061eb4af"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("5a26d287-295e-4591-8363-499f1e58940e"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("6411679f-1e16-48ff-9432-812b76f5489b"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("766f89a2-d15a-4d96-bc07-340f008387d0"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("8bc65ecc-627d-4015-81fa-546363fe6648"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("f37c9b37-f0a8-4891-89a3-c77af3e03e00"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("fed20dd5-fa76-4dcb-a4a9-d33fbb97e348"));

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 3, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3800), new Guid("9769ffb7-852d-4e97-80ed-19051890d5a1") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 4, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3810), new Guid("f99b3654-72bd-4ce2-9540-49530d6c0804") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 5, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3810), new Guid("245ca322-5ef8-4ca3-9205-fbaacdf5f3c4") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 6, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3810), new Guid("2b427af7-6042-4cdf-bdf2-6753c7ab721f") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 7, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3820), new Guid("c6e6d055-ba56-4452-b8c1-cfe6e0485f04") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 8, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3820), new Guid("f8a3a977-0c45-4496-985c-af3bd724bd4c") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 9, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3820), new Guid("a1293e40-19d1-46dd-8daf-71c71ae8e624") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 10, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3830), new Guid("678b67be-9cd7-4c57-8df3-4e5882e4ae12") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 11, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3830), new Guid("a98f8d20-4848-4433-a2a8-d43d566317cf") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3840), new Guid("9d586bd6-9d56-4741-86d7-d36d705a7aa8") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 13, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3840), new Guid("9769ffb7-852d-4e97-80ed-19051890d5a1") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 14, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3840), new Guid("f99b3654-72bd-4ce2-9540-49530d6c0804") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 15, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3850), new Guid("245ca322-5ef8-4ca3-9205-fbaacdf5f3c4") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 16, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3850), new Guid("2b427af7-6042-4cdf-bdf2-6753c7ab721f") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 17, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3850), new Guid("c6e6d055-ba56-4452-b8c1-cfe6e0485f04") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 18, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3860), new Guid("f8a3a977-0c45-4496-985c-af3bd724bd4c") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 19, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3860), new Guid("a1293e40-19d1-46dd-8daf-71c71ae8e624") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 20, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3860), new Guid("678b67be-9cd7-4c57-8df3-4e5882e4ae12") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 21, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3870), new Guid("a98f8d20-4848-4433-a2a8-d43d566317cf") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 22, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3870), new Guid("9d586bd6-9d56-4741-86d7-d36d705a7aa8") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 23, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3870), new Guid("9769ffb7-852d-4e97-80ed-19051890d5a1") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 24, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3880), new Guid("f99b3654-72bd-4ce2-9540-49530d6c0804") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 25, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3880), new Guid("245ca322-5ef8-4ca3-9205-fbaacdf5f3c4") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 26, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3890), new Guid("2b427af7-6042-4cdf-bdf2-6753c7ab721f") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 27, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3890), new Guid("c6e6d055-ba56-4452-b8c1-cfe6e0485f04") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 28, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3890), new Guid("f8a3a977-0c45-4496-985c-af3bd724bd4c") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 29, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3900), new Guid("a1293e40-19d1-46dd-8daf-71c71ae8e624") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 30, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3900), new Guid("678b67be-9cd7-4c57-8df3-4e5882e4ae12") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 31, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3900), new Guid("a98f8d20-4848-4433-a2a8-d43d566317cf") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 1, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3910), new Guid("9d586bd6-9d56-4741-86d7-d36d705a7aa8") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 2, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3910), new Guid("9769ffb7-852d-4e97-80ed-19051890d5a1") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 3, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3910), new Guid("f99b3654-72bd-4ce2-9540-49530d6c0804") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 4, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3920), new Guid("245ca322-5ef8-4ca3-9205-fbaacdf5f3c4") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 5, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3920), new Guid("2b427af7-6042-4cdf-bdf2-6753c7ab721f") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 6, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3920), new Guid("c6e6d055-ba56-4452-b8c1-cfe6e0485f04") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 7, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3930), new Guid("f8a3a977-0c45-4496-985c-af3bd724bd4c") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 8, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3930), new Guid("a1293e40-19d1-46dd-8daf-71c71ae8e624") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 9, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3930), new Guid("678b67be-9cd7-4c57-8df3-4e5882e4ae12") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 10, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3940), new Guid("a98f8d20-4848-4433-a2a8-d43d566317cf") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 11, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3940), new Guid("9d586bd6-9d56-4741-86d7-d36d705a7aa8") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3950), new Guid("9769ffb7-852d-4e97-80ed-19051890d5a1") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 13, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3950), new Guid("f99b3654-72bd-4ce2-9540-49530d6c0804") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 14, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3950), new Guid("245ca322-5ef8-4ca3-9205-fbaacdf5f3c4") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 15, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3960), new Guid("2b427af7-6042-4cdf-bdf2-6753c7ab721f") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 16, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3960), new Guid("c6e6d055-ba56-4452-b8c1-cfe6e0485f04") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 17, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3960), new Guid("f8a3a977-0c45-4496-985c-af3bd724bd4c") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 18, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3970), new Guid("a1293e40-19d1-46dd-8daf-71c71ae8e624") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 19, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3970), new Guid("678b67be-9cd7-4c57-8df3-4e5882e4ae12") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 20, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3970), new Guid("a98f8d20-4848-4433-a2a8-d43d566317cf") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 21, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3980), new Guid("9d586bd6-9d56-4741-86d7-d36d705a7aa8") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 22, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3980), new Guid("9769ffb7-852d-4e97-80ed-19051890d5a1") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 23, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3980), new Guid("f99b3654-72bd-4ce2-9540-49530d6c0804") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 24, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3990), new Guid("245ca322-5ef8-4ca3-9205-fbaacdf5f3c4") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 25, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3990), new Guid("2b427af7-6042-4cdf-bdf2-6753c7ab721f") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 26, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(3990), new Guid("c6e6d055-ba56-4452-b8c1-cfe6e0485f04") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 27, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4000), new Guid("f8a3a977-0c45-4496-985c-af3bd724bd4c") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 28, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4000), new Guid("a1293e40-19d1-46dd-8daf-71c71ae8e624") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 29, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4000), new Guid("678b67be-9cd7-4c57-8df3-4e5882e4ae12") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 30, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4010), new Guid("a98f8d20-4848-4433-a2a8-d43d566317cf") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 31, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4010), new Guid("9d586bd6-9d56-4741-86d7-d36d705a7aa8") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 1, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4020), new Guid("9769ffb7-852d-4e97-80ed-19051890d5a1") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 2, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4020), new Guid("f99b3654-72bd-4ce2-9540-49530d6c0804") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 3, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4020), new Guid("245ca322-5ef8-4ca3-9205-fbaacdf5f3c4") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 4, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4030), new Guid("2b427af7-6042-4cdf-bdf2-6753c7ab721f") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 5, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4030), new Guid("c6e6d055-ba56-4452-b8c1-cfe6e0485f04") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 6, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4030), new Guid("f8a3a977-0c45-4496-985c-af3bd724bd4c") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 7, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4040), new Guid("a1293e40-19d1-46dd-8daf-71c71ae8e624") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 8, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4040), new Guid("678b67be-9cd7-4c57-8df3-4e5882e4ae12") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 9, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4040), new Guid("a98f8d20-4848-4433-a2a8-d43d566317cf") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 10, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4050), new Guid("9d586bd6-9d56-4741-86d7-d36d705a7aa8") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 11, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4050), new Guid("9769ffb7-852d-4e97-80ed-19051890d5a1") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 12, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4050), new Guid("f99b3654-72bd-4ce2-9540-49530d6c0804") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 13, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4060), new Guid("245ca322-5ef8-4ca3-9205-fbaacdf5f3c4") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 14, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4060), new Guid("2b427af7-6042-4cdf-bdf2-6753c7ab721f") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 15, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4060), new Guid("c6e6d055-ba56-4452-b8c1-cfe6e0485f04") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 16, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4070), new Guid("f8a3a977-0c45-4496-985c-af3bd724bd4c") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 17, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4070), new Guid("a1293e40-19d1-46dd-8daf-71c71ae8e624") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 18, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4080), new Guid("678b67be-9cd7-4c57-8df3-4e5882e4ae12") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 19, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4080), new Guid("a98f8d20-4848-4433-a2a8-d43d566317cf") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 20, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4080), new Guid("9d586bd6-9d56-4741-86d7-d36d705a7aa8") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 21, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4090), new Guid("9769ffb7-852d-4e97-80ed-19051890d5a1") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 22, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4090), new Guid("f99b3654-72bd-4ce2-9540-49530d6c0804") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 23, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4090), new Guid("245ca322-5ef8-4ca3-9205-fbaacdf5f3c4") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 24, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4100), new Guid("2b427af7-6042-4cdf-bdf2-6753c7ab721f") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 25, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4100), new Guid("c6e6d055-ba56-4452-b8c1-cfe6e0485f04") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 26, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4110), new Guid("f8a3a977-0c45-4496-985c-af3bd724bd4c") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 27, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4110), new Guid("a1293e40-19d1-46dd-8daf-71c71ae8e624") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 28, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4110), new Guid("678b67be-9cd7-4c57-8df3-4e5882e4ae12") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 29, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4120), new Guid("a98f8d20-4848-4433-a2a8-d43d566317cf") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 1, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4120), new Guid("9d586bd6-9d56-4741-86d7-d36d705a7aa8") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 2, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4120), new Guid("9769ffb7-852d-4e97-80ed-19051890d5a1") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 3, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4130), new Guid("f99b3654-72bd-4ce2-9540-49530d6c0804") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 4, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4130), new Guid("245ca322-5ef8-4ca3-9205-fbaacdf5f3c4") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 5, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4130), new Guid("2b427af7-6042-4cdf-bdf2-6753c7ab721f") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 6, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4140), new Guid("c6e6d055-ba56-4452-b8c1-cfe6e0485f04") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 7, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4140), new Guid("f8a3a977-0c45-4496-985c-af3bd724bd4c") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 8, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4140), new Guid("a1293e40-19d1-46dd-8daf-71c71ae8e624") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 9, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4150), new Guid("678b67be-9cd7-4c57-8df3-4e5882e4ae12") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 10, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4150), new Guid("a98f8d20-4848-4433-a2a8-d43d566317cf") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 11, 15, 43, 57, 883, DateTimeKind.Local).AddTicks(4150), new Guid("9d586bd6-9d56-4741-86d7-d36d705a7aa8") });

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("01ae81ee-7eb3-433b-a2e4-46b5e3865adf"));

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("09ad58df-b5ad-4a19-826b-0c76d838bbc8"));

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("12006009-4d55-4763-a26d-8e2d624fd3c4"));

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("1888638c-0069-4874-81ac-3b0ca1b583a9"));

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("1da21246-c6c4-4721-a50c-80dc9bfa8098"));

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("5289271b-e3c6-4aa4-9006-03bc8bd7993e"));

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("5e14ccb3-dca2-45b5-94af-752602b52445"));

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("7b429312-5034-4cf0-ac86-70f4fae88857"));

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("9a8b45d3-9acb-4298-882f-f68e798e003c"));

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("bf797fc6-e033-4220-8575-318db36ba831"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("245ca322-5ef8-4ca3-9205-fbaacdf5f3c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("2b427af7-6042-4cdf-bdf2-6753c7ab721f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("678b67be-9cd7-4c57-8df3-4e5882e4ae12"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("9769ffb7-852d-4e97-80ed-19051890d5a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("9d586bd6-9d56-4741-86d7-d36d705a7aa8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("a1293e40-19d1-46dd-8daf-71c71ae8e624"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("a98f8d20-4848-4433-a2a8-d43d566317cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("c6e6d055-ba56-4452-b8c1-cfe6e0485f04"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("f8a3a977-0c45-4496-985c-af3bd724bd4c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("f99b3654-72bd-4ce2-9540-49530d6c0804"));

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

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "id", "created_at", "description", "end_date", "illustration_path", "published", "start_date", "title", "updated_at" },
                values: new object[,]
                {
                    { new Guid("2766f6a8-e509-410d-8915-074441d6af04"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6550), "Content 2", null, "https://previews.123rf.com/images/ambro/ambro1112/ambro111200418/11558816-businessman-with-thumbs-up.jpg", true, new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6550), "Article 2", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6550) },
                    { new Guid("328a8d1f-0e82-4029-a1f1-b7acd84be780"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6580), "Content 5", null, "https://previews.123rf.com/images/ambro/ambro1112/ambro111200418/11558816-businessman-with-thumbs-up.jpg", true, new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6580), "Article 5", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6580) },
                    { new Guid("4cf8d8b9-0628-467b-9285-34a14a47986b"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6540), "Content 1", null, "https://thumbs.dreamstime.com/b/bald-man-thumbs-up-26364248.jpg", true, new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6540), "Article 1", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6540) },
                    { new Guid("5648dfee-e174-4798-8862-1b321d9704a7"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6530), "Content 0", null, "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6530), "Article 0", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6530) },
                    { new Guid("63cb7e99-4e60-4e6d-b00a-7b179eed7675"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6610), "Content 8", null, "https://previews.123rf.com/images/ambro/ambro1112/ambro111200418/11558816-businessman-with-thumbs-up.jpg", true, new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6610), "Article 8", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6610) },
                    { new Guid("7c3e145e-8d32-424e-980c-9555ff7eceac"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6560), "Content 3", null, "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6560), "Article 3", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6560) },
                    { new Guid("8e41c9f9-f11c-4e07-b5b0-7d99b6c682f5"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6570), "Content 4", null, "https://thumbs.dreamstime.com/b/bald-man-thumbs-up-26364248.jpg", true, new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6570), "Article 4", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6570) },
                    { new Guid("bc204755-d233-4951-83d6-1af77b706467"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6620), "Content 9", null, "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6620), "Article 9", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6620) },
                    { new Guid("e23be446-a112-472a-97ea-1009c2fb98bf"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6600), "Content 7", null, "https://thumbs.dreamstime.com/b/bald-man-thumbs-up-26364248.jpg", true, new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6600), "Article 7", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6600) },
                    { new Guid("ea864f4f-e0f1-4c1c-b96a-256488f28fe3"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6590), "Content 6", null, "https://media.istockphoto.com/id/182060276/photo/casual-man-gesturing-thumbs-up-isolated.jpg?s=612x612&w=0&k=20&c=YYCr9xSywy1pxJRskxEPYuM8T0PYTX3ylFG0C1pXyd4=", true, new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6590), "Article 6", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6590) }
                });

            migrationBuilder.InsertData(
                table: "Badges",
                columns: new[] { "id", "created_at", "description", "icon_path", "title", "updated_at", "UserId" },
                values: new object[,]
                {
                    { new Guid("08823ad9-9907-48a9-8ba0-b147e4d55d5c"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6310), "Content 9", "https://png.pngtree.com/png-vector/20201229/ourmid/pngtree-a-squatting-tabby-cat-png-image_2664942.jpg", "Badge 9", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6310), null },
                    { new Guid("21788ab5-8329-4339-9e56-7b709772f6ea"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6300), "Content 8", "https://pngimg.com/uploads/cat/cat_PNG50447.png", "Badge 8", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6300), null },
                    { new Guid("22b8a2fc-62b9-49b6-8926-91a297ae2d00"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6240), "Content 1", "https://images.rawpixel.com/image_png_800/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvcHUyMzMxNjM5LWltYWdlXzItbDBqOXFvd3IucG5n.png", "Badge 1", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6240), null },
                    { new Guid("2ed7d868-efd2-47d8-8375-eead449bb1ea"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6260), "Content 4", "https://images.rawpixel.com/image_png_800/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvcHUyMzMxNjM5LWltYWdlXzItbDBqOXFvd3IucG5n.png", "Badge 4", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6270), null },
                    { new Guid("36f7239e-502d-413b-847f-2ac07362f70c"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6290), "Content 7", "https://images.rawpixel.com/image_png_800/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvcHUyMzMxNjM5LWltYWdlXzItbDBqOXFvd3IucG5n.png", "Badge 7", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6290), null },
                    { new Guid("44cacbd7-ed31-4116-a5fa-f750020e0b1e"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6230), "Content 0", "https://png.pngtree.com/png-vector/20201229/ourmid/pngtree-a-squatting-tabby-cat-png-image_2664942.jpg", "Badge 0", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6230), null },
                    { new Guid("879a4b23-d8a8-4d58-87c3-54a08c6f5bf3"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6270), "Content 5", "https://pngimg.com/uploads/cat/cat_PNG50447.png", "Badge 5", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6270), null },
                    { new Guid("d0046aa4-dbec-47ba-9e28-2ffcae66fbfb"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6260), "Content 3", "https://png.pngtree.com/png-vector/20201229/ourmid/pngtree-a-squatting-tabby-cat-png-image_2664942.jpg", "Badge 3", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6260), null },
                    { new Guid("e8a4ab9d-3eae-4dd3-8900-ee2debbf90f1"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6280), "Content 6", "https://png.pngtree.com/png-vector/20201229/ourmid/pngtree-a-squatting-tabby-cat-png-image_2664942.jpg", "Badge 6", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6280), null },
                    { new Guid("ebeb732c-d0f0-47ae-b1ce-b572403c26b7"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6250), "Content 2", "https://pngimg.com/uploads/cat/cat_PNG50447.png", "Badge 2", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6250), null }
                });

            migrationBuilder.InsertData(
                table: "SuperUsers",
                columns: new[] { "id", "created_at", "password", "super_role", "updated_at", "username" },
                values: new object[] { new Guid("ed0e5b0e-c49b-45db-89a2-e6cf6ba46170"), new DateTime(2024, 3, 12, 21, 33, 37, 279, DateTimeKind.Local).AddTicks(780), "$2a$05$byED3tyE5RJ8kwWg19fDuuQivzPwrJrTqKeC/RKyNV2dlffOhvFAi", "superAdmin", new DateTime(2024, 3, 12, 21, 33, 37, 279, DateTimeKind.Local).AddTicks(790), "superAdmin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "created_at", "identifier", "updated_at" },
                values: new object[,]
                {
                    { new Guid("368c6dee-0c79-4673-b178-bf23125a7d0a"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6030), "user0", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6080) },
                    { new Guid("5099b530-3bf7-47ba-b894-8291236a0198"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6130), "user6", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6130) },
                    { new Guid("51485224-7236-4cdf-a155-76f66c3d1795"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6110), "user4", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6110) },
                    { new Guid("6718d752-9569-4126-90b2-7e00f5990b0a"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6100), "user3", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6110) },
                    { new Guid("7956c394-e9c5-4b9c-904f-954c459bad02"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6140), "user7", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6140) },
                    { new Guid("98296d73-6a0c-4da9-8362-6fa8dcfb5de7"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6120), "user5", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6120) },
                    { new Guid("ac6b08e1-53e3-4364-a6af-0a7ecc299154"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6150), "user9", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6150) },
                    { new Guid("ad4f12f8-6280-47a1-9e8f-54e97b84e792"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6100), "user2", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6100) },
                    { new Guid("c35e44b0-57ef-456f-8d7a-d0a12f9df13b"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6150), "user8", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6150) },
                    { new Guid("e61d255f-8b80-4e08-9c08-dbab8df42f17"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6090), "user1", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6090) }
                });

            migrationBuilder.InsertData(
                table: "BadgesToUser",
                columns: new[] { "badge_id", "user_id", "obtained_at" },
                values: new object[,]
                {
                    { new Guid("44cacbd7-ed31-4116-a5fa-f750020e0b1e"), new Guid("368c6dee-0c79-4673-b178-bf23125a7d0a"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6780) },
                    { new Guid("e8a4ab9d-3eae-4dd3-8900-ee2debbf90f1"), new Guid("5099b530-3bf7-47ba-b894-8291236a0198"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6790) },
                    { new Guid("2ed7d868-efd2-47d8-8375-eead449bb1ea"), new Guid("51485224-7236-4cdf-a155-76f66c3d1795"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6790) },
                    { new Guid("d0046aa4-dbec-47ba-9e28-2ffcae66fbfb"), new Guid("6718d752-9569-4126-90b2-7e00f5990b0a"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6790) },
                    { new Guid("36f7239e-502d-413b-847f-2ac07362f70c"), new Guid("7956c394-e9c5-4b9c-904f-954c459bad02"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6790) },
                    { new Guid("879a4b23-d8a8-4d58-87c3-54a08c6f5bf3"), new Guid("98296d73-6a0c-4da9-8362-6fa8dcfb5de7"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6790) },
                    { new Guid("08823ad9-9907-48a9-8ba0-b147e4d55d5c"), new Guid("ac6b08e1-53e3-4364-a6af-0a7ecc299154"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6810) },
                    { new Guid("ebeb732c-d0f0-47ae-b1ce-b572403c26b7"), new Guid("ad4f12f8-6280-47a1-9e8f-54e97b84e792"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6790) },
                    { new Guid("21788ab5-8329-4339-9e56-7b709772f6ea"), new Guid("c35e44b0-57ef-456f-8d7a-d0a12f9df13b"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6790) },
                    { new Guid("22b8a2fc-62b9-49b6-8926-91a297ae2d00"), new Guid("e61d255f-8b80-4e08-9c08-dbab8df42f17"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6790) }
                });

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "id", "badge_id", "created_at", "description", "end_date", "is_global", "objective", "start_date", "title", "updated_at" },
                values: new object[,]
                {
                    { new Guid("083b6ace-924e-43bd-90e2-cc9ea1283a2f"), new Guid("22b8a2fc-62b9-49b6-8926-91a297ae2d00"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6380), "Content 1", new DateTime(2024, 4, 11, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6380), false, 9359, new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6380), "Challenge 1", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6380) },
                    { new Guid("153cdeda-6f23-44cd-9d7a-b2d28031de5d"), new Guid("21788ab5-8329-4339-9e56-7b709772f6ea"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6490), "Content 8", new DateTime(2024, 4, 11, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6490), true, 92495, new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6490), "Challenge 8", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6490) },
                    { new Guid("171a179f-1a6c-41b5-91e7-fe3991cd8bf0"), new Guid("e8a4ab9d-3eae-4dd3-8900-ee2debbf90f1"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6460), "Content 6", new DateTime(2024, 4, 11, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6460), true, 16050, new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6460), "Challenge 6", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6460) },
                    { new Guid("268fb02f-6d22-42a4-9581-a20ea9c42228"), new Guid("2ed7d868-efd2-47d8-8375-eead449bb1ea"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6440), "Content 4", new DateTime(2024, 4, 11, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6440), true, 23502, new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6430), "Challenge 4", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6440) },
                    { new Guid("2a92a319-5e77-4deb-99eb-3cdbc83bb03d"), new Guid("08823ad9-9907-48a9-8ba0-b147e4d55d5c"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6500), "Content 9", new DateTime(2024, 4, 11, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6500), false, 6993, new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6500), "Challenge 9", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6500) },
                    { new Guid("723f1c4b-5c9f-4c14-8b3a-8f94a2551131"), new Guid("ebeb732c-d0f0-47ae-b1ce-b572403c26b7"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6390), "Content 2", new DateTime(2024, 4, 11, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6390), true, 84028, new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6390), "Challenge 2", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6390) },
                    { new Guid("82c02a0c-6101-43bf-9e0f-c8b76f47cc4c"), new Guid("d0046aa4-dbec-47ba-9e28-2ffcae66fbfb"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6420), "Content 3", new DateTime(2024, 4, 11, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6420), false, 61343, new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6420), "Challenge 3", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6420) },
                    { new Guid("b8f8f98e-b975-4bef-8627-be31b31b404e"), new Guid("36f7239e-502d-413b-847f-2ac07362f70c"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6470), "Content 7", new DateTime(2024, 4, 11, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6470), false, 21578, new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6470), "Challenge 7", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6470) },
                    { new Guid("c21ea06b-ddd6-406f-aba0-0054224867f1"), new Guid("44cacbd7-ed31-4116-a5fa-f750020e0b1e"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6360), "Content 0", new DateTime(2024, 4, 11, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6360), true, 90177, new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6350), "Challenge 0", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6360) },
                    { new Guid("f46ec2c0-ac8c-4561-a118-79d7c7a35524"), new Guid("879a4b23-d8a8-4d58-87c3-54a08c6f5bf3"), new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6450), "Content 5", new DateTime(2024, 4, 11, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6450), false, 77579, new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6450), "Challenge 5", new DateTime(2024, 3, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6450) }
                });

            migrationBuilder.InsertData(
                table: "DayOfWalk",
                columns: new[] { "date", "user_id", "steps" },
                values: new object[,]
                {
                    { new DateTime(2023, 12, 3, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6640), new Guid("368c6dee-0c79-4673-b178-bf23125a7d0a"), 1000 },
                    { new DateTime(2023, 12, 4, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6640), new Guid("e61d255f-8b80-4e08-9c08-dbab8df42f17"), 1000 },
                    { new DateTime(2023, 12, 5, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6640), new Guid("ad4f12f8-6280-47a1-9e8f-54e97b84e792"), 1000 },
                    { new DateTime(2023, 12, 6, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6640), new Guid("6718d752-9569-4126-90b2-7e00f5990b0a"), 1000 },
                    { new DateTime(2023, 12, 7, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6640), new Guid("51485224-7236-4cdf-a155-76f66c3d1795"), 1000 },
                    { new DateTime(2023, 12, 8, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6640), new Guid("98296d73-6a0c-4da9-8362-6fa8dcfb5de7"), 1000 },
                    { new DateTime(2023, 12, 9, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6650), new Guid("5099b530-3bf7-47ba-b894-8291236a0198"), 1000 },
                    { new DateTime(2023, 12, 10, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6650), new Guid("7956c394-e9c5-4b9c-904f-954c459bad02"), 1000 },
                    { new DateTime(2023, 12, 11, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6650), new Guid("c35e44b0-57ef-456f-8d7a-d0a12f9df13b"), 1000 },
                    { new DateTime(2023, 12, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6650), new Guid("ac6b08e1-53e3-4364-a6af-0a7ecc299154"), 1000 },
                    { new DateTime(2023, 12, 13, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6650), new Guid("368c6dee-0c79-4673-b178-bf23125a7d0a"), 1000 },
                    { new DateTime(2023, 12, 14, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6650), new Guid("e61d255f-8b80-4e08-9c08-dbab8df42f17"), 1000 },
                    { new DateTime(2023, 12, 15, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6650), new Guid("ad4f12f8-6280-47a1-9e8f-54e97b84e792"), 1000 },
                    { new DateTime(2023, 12, 16, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6650), new Guid("6718d752-9569-4126-90b2-7e00f5990b0a"), 1000 },
                    { new DateTime(2023, 12, 17, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6650), new Guid("51485224-7236-4cdf-a155-76f66c3d1795"), 1000 },
                    { new DateTime(2023, 12, 18, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6660), new Guid("98296d73-6a0c-4da9-8362-6fa8dcfb5de7"), 1000 },
                    { new DateTime(2023, 12, 19, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6660), new Guid("5099b530-3bf7-47ba-b894-8291236a0198"), 1000 },
                    { new DateTime(2023, 12, 20, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6660), new Guid("7956c394-e9c5-4b9c-904f-954c459bad02"), 1000 },
                    { new DateTime(2023, 12, 21, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6660), new Guid("c35e44b0-57ef-456f-8d7a-d0a12f9df13b"), 1000 },
                    { new DateTime(2023, 12, 22, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6660), new Guid("ac6b08e1-53e3-4364-a6af-0a7ecc299154"), 1000 },
                    { new DateTime(2023, 12, 23, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6660), new Guid("368c6dee-0c79-4673-b178-bf23125a7d0a"), 1000 },
                    { new DateTime(2023, 12, 24, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6660), new Guid("e61d255f-8b80-4e08-9c08-dbab8df42f17"), 1000 },
                    { new DateTime(2023, 12, 25, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6660), new Guid("ad4f12f8-6280-47a1-9e8f-54e97b84e792"), 1000 },
                    { new DateTime(2023, 12, 26, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6660), new Guid("6718d752-9569-4126-90b2-7e00f5990b0a"), 1000 },
                    { new DateTime(2023, 12, 27, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6660), new Guid("51485224-7236-4cdf-a155-76f66c3d1795"), 1000 },
                    { new DateTime(2023, 12, 28, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6670), new Guid("98296d73-6a0c-4da9-8362-6fa8dcfb5de7"), 1000 },
                    { new DateTime(2023, 12, 29, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6670), new Guid("5099b530-3bf7-47ba-b894-8291236a0198"), 1000 },
                    { new DateTime(2023, 12, 30, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6670), new Guid("7956c394-e9c5-4b9c-904f-954c459bad02"), 1000 },
                    { new DateTime(2023, 12, 31, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6670), new Guid("c35e44b0-57ef-456f-8d7a-d0a12f9df13b"), 1000 },
                    { new DateTime(2024, 1, 1, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6670), new Guid("ac6b08e1-53e3-4364-a6af-0a7ecc299154"), 1000 },
                    { new DateTime(2024, 1, 2, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6670), new Guid("368c6dee-0c79-4673-b178-bf23125a7d0a"), 1000 },
                    { new DateTime(2024, 1, 3, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6670), new Guid("e61d255f-8b80-4e08-9c08-dbab8df42f17"), 1000 },
                    { new DateTime(2024, 1, 4, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6670), new Guid("ad4f12f8-6280-47a1-9e8f-54e97b84e792"), 1000 },
                    { new DateTime(2024, 1, 5, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6680), new Guid("6718d752-9569-4126-90b2-7e00f5990b0a"), 1000 },
                    { new DateTime(2024, 1, 6, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6680), new Guid("51485224-7236-4cdf-a155-76f66c3d1795"), 1000 },
                    { new DateTime(2024, 1, 7, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6680), new Guid("98296d73-6a0c-4da9-8362-6fa8dcfb5de7"), 1000 },
                    { new DateTime(2024, 1, 8, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6680), new Guid("5099b530-3bf7-47ba-b894-8291236a0198"), 1000 },
                    { new DateTime(2024, 1, 9, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6680), new Guid("7956c394-e9c5-4b9c-904f-954c459bad02"), 1000 },
                    { new DateTime(2024, 1, 10, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6680), new Guid("c35e44b0-57ef-456f-8d7a-d0a12f9df13b"), 1000 },
                    { new DateTime(2024, 1, 11, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6680), new Guid("ac6b08e1-53e3-4364-a6af-0a7ecc299154"), 1000 },
                    { new DateTime(2024, 1, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6680), new Guid("368c6dee-0c79-4673-b178-bf23125a7d0a"), 1000 },
                    { new DateTime(2024, 1, 13, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6680), new Guid("e61d255f-8b80-4e08-9c08-dbab8df42f17"), 1000 },
                    { new DateTime(2024, 1, 14, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6690), new Guid("ad4f12f8-6280-47a1-9e8f-54e97b84e792"), 1000 },
                    { new DateTime(2024, 1, 15, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6690), new Guid("6718d752-9569-4126-90b2-7e00f5990b0a"), 1000 },
                    { new DateTime(2024, 1, 16, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6690), new Guid("51485224-7236-4cdf-a155-76f66c3d1795"), 1000 },
                    { new DateTime(2024, 1, 17, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6690), new Guid("98296d73-6a0c-4da9-8362-6fa8dcfb5de7"), 1000 },
                    { new DateTime(2024, 1, 18, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6690), new Guid("5099b530-3bf7-47ba-b894-8291236a0198"), 1000 },
                    { new DateTime(2024, 1, 19, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6690), new Guid("7956c394-e9c5-4b9c-904f-954c459bad02"), 1000 },
                    { new DateTime(2024, 1, 20, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6690), new Guid("c35e44b0-57ef-456f-8d7a-d0a12f9df13b"), 1000 },
                    { new DateTime(2024, 1, 21, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6690), new Guid("ac6b08e1-53e3-4364-a6af-0a7ecc299154"), 1000 },
                    { new DateTime(2024, 1, 22, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6690), new Guid("368c6dee-0c79-4673-b178-bf23125a7d0a"), 1000 },
                    { new DateTime(2024, 1, 23, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6690), new Guid("e61d255f-8b80-4e08-9c08-dbab8df42f17"), 1000 },
                    { new DateTime(2024, 1, 24, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6700), new Guid("ad4f12f8-6280-47a1-9e8f-54e97b84e792"), 1000 },
                    { new DateTime(2024, 1, 25, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6700), new Guid("6718d752-9569-4126-90b2-7e00f5990b0a"), 1000 },
                    { new DateTime(2024, 1, 26, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6700), new Guid("51485224-7236-4cdf-a155-76f66c3d1795"), 1000 },
                    { new DateTime(2024, 1, 27, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6700), new Guid("98296d73-6a0c-4da9-8362-6fa8dcfb5de7"), 1000 },
                    { new DateTime(2024, 1, 28, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6700), new Guid("5099b530-3bf7-47ba-b894-8291236a0198"), 1000 },
                    { new DateTime(2024, 1, 29, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6700), new Guid("7956c394-e9c5-4b9c-904f-954c459bad02"), 1000 },
                    { new DateTime(2024, 1, 30, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6700), new Guid("c35e44b0-57ef-456f-8d7a-d0a12f9df13b"), 1000 },
                    { new DateTime(2024, 1, 31, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6700), new Guid("ac6b08e1-53e3-4364-a6af-0a7ecc299154"), 1000 },
                    { new DateTime(2024, 2, 1, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6700), new Guid("368c6dee-0c79-4673-b178-bf23125a7d0a"), 1000 },
                    { new DateTime(2024, 2, 2, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6700), new Guid("e61d255f-8b80-4e08-9c08-dbab8df42f17"), 1000 },
                    { new DateTime(2024, 2, 3, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6710), new Guid("ad4f12f8-6280-47a1-9e8f-54e97b84e792"), 1000 },
                    { new DateTime(2024, 2, 4, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6710), new Guid("6718d752-9569-4126-90b2-7e00f5990b0a"), 1000 },
                    { new DateTime(2024, 2, 5, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6710), new Guid("51485224-7236-4cdf-a155-76f66c3d1795"), 1000 },
                    { new DateTime(2024, 2, 6, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6710), new Guid("98296d73-6a0c-4da9-8362-6fa8dcfb5de7"), 1000 },
                    { new DateTime(2024, 2, 7, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6710), new Guid("5099b530-3bf7-47ba-b894-8291236a0198"), 1000 },
                    { new DateTime(2024, 2, 8, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6710), new Guid("7956c394-e9c5-4b9c-904f-954c459bad02"), 1000 },
                    { new DateTime(2024, 2, 9, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6710), new Guid("c35e44b0-57ef-456f-8d7a-d0a12f9df13b"), 1000 },
                    { new DateTime(2024, 2, 10, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6710), new Guid("ac6b08e1-53e3-4364-a6af-0a7ecc299154"), 1000 },
                    { new DateTime(2024, 2, 11, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6710), new Guid("368c6dee-0c79-4673-b178-bf23125a7d0a"), 1000 },
                    { new DateTime(2024, 2, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6720), new Guid("e61d255f-8b80-4e08-9c08-dbab8df42f17"), 1000 },
                    { new DateTime(2024, 2, 13, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6720), new Guid("ad4f12f8-6280-47a1-9e8f-54e97b84e792"), 1000 },
                    { new DateTime(2024, 2, 14, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6720), new Guid("6718d752-9569-4126-90b2-7e00f5990b0a"), 1000 },
                    { new DateTime(2024, 2, 15, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6720), new Guid("51485224-7236-4cdf-a155-76f66c3d1795"), 1000 },
                    { new DateTime(2024, 2, 16, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6720), new Guid("98296d73-6a0c-4da9-8362-6fa8dcfb5de7"), 1000 },
                    { new DateTime(2024, 2, 17, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6720), new Guid("5099b530-3bf7-47ba-b894-8291236a0198"), 1000 },
                    { new DateTime(2024, 2, 18, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6720), new Guid("7956c394-e9c5-4b9c-904f-954c459bad02"), 1000 },
                    { new DateTime(2024, 2, 19, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6720), new Guid("c35e44b0-57ef-456f-8d7a-d0a12f9df13b"), 1000 },
                    { new DateTime(2024, 2, 20, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6720), new Guid("ac6b08e1-53e3-4364-a6af-0a7ecc299154"), 1000 },
                    { new DateTime(2024, 2, 21, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6720), new Guid("368c6dee-0c79-4673-b178-bf23125a7d0a"), 1000 },
                    { new DateTime(2024, 2, 22, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6730), new Guid("e61d255f-8b80-4e08-9c08-dbab8df42f17"), 1000 },
                    { new DateTime(2024, 2, 23, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6730), new Guid("ad4f12f8-6280-47a1-9e8f-54e97b84e792"), 1000 },
                    { new DateTime(2024, 2, 24, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6730), new Guid("6718d752-9569-4126-90b2-7e00f5990b0a"), 1000 },
                    { new DateTime(2024, 2, 25, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6730), new Guid("51485224-7236-4cdf-a155-76f66c3d1795"), 1000 },
                    { new DateTime(2024, 2, 26, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6730), new Guid("98296d73-6a0c-4da9-8362-6fa8dcfb5de7"), 1000 },
                    { new DateTime(2024, 2, 27, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6730), new Guid("5099b530-3bf7-47ba-b894-8291236a0198"), 1000 },
                    { new DateTime(2024, 2, 28, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6730), new Guid("7956c394-e9c5-4b9c-904f-954c459bad02"), 1000 },
                    { new DateTime(2024, 2, 29, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6730), new Guid("c35e44b0-57ef-456f-8d7a-d0a12f9df13b"), 1000 },
                    { new DateTime(2024, 3, 1, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6730), new Guid("ac6b08e1-53e3-4364-a6af-0a7ecc299154"), 1000 },
                    { new DateTime(2024, 3, 2, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6730), new Guid("368c6dee-0c79-4673-b178-bf23125a7d0a"), 1000 },
                    { new DateTime(2024, 3, 3, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6740), new Guid("e61d255f-8b80-4e08-9c08-dbab8df42f17"), 1000 },
                    { new DateTime(2024, 3, 4, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6740), new Guid("ad4f12f8-6280-47a1-9e8f-54e97b84e792"), 1000 },
                    { new DateTime(2024, 3, 5, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6740), new Guid("6718d752-9569-4126-90b2-7e00f5990b0a"), 1000 },
                    { new DateTime(2024, 3, 6, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6740), new Guid("51485224-7236-4cdf-a155-76f66c3d1795"), 1000 },
                    { new DateTime(2024, 3, 7, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6740), new Guid("98296d73-6a0c-4da9-8362-6fa8dcfb5de7"), 1000 },
                    { new DateTime(2024, 3, 8, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6740), new Guid("5099b530-3bf7-47ba-b894-8291236a0198"), 1000 },
                    { new DateTime(2024, 3, 9, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6740), new Guid("7956c394-e9c5-4b9c-904f-954c459bad02"), 1000 },
                    { new DateTime(2024, 3, 10, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6740), new Guid("c35e44b0-57ef-456f-8d7a-d0a12f9df13b"), 1000 },
                    { new DateTime(2024, 3, 11, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6740), new Guid("ac6b08e1-53e3-4364-a6af-0a7ecc299154"), 1000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SuperUsers_username",
                table: "SuperUsers",
                column: "username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuperUsers");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("2766f6a8-e509-410d-8915-074441d6af04"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("328a8d1f-0e82-4029-a1f1-b7acd84be780"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("4cf8d8b9-0628-467b-9285-34a14a47986b"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("5648dfee-e174-4798-8862-1b321d9704a7"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("63cb7e99-4e60-4e6d-b00a-7b179eed7675"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("7c3e145e-8d32-424e-980c-9555ff7eceac"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("8e41c9f9-f11c-4e07-b5b0-7d99b6c682f5"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("bc204755-d233-4951-83d6-1af77b706467"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("e23be446-a112-472a-97ea-1009c2fb98bf"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "id",
                keyValue: new Guid("ea864f4f-e0f1-4c1c-b96a-256488f28fe3"));

            migrationBuilder.DeleteData(
                table: "BadgesToUser",
                keyColumns: new[] { "badge_id", "user_id" },
                keyValues: new object[] { new Guid("44cacbd7-ed31-4116-a5fa-f750020e0b1e"), new Guid("368c6dee-0c79-4673-b178-bf23125a7d0a") });

            migrationBuilder.DeleteData(
                table: "BadgesToUser",
                keyColumns: new[] { "badge_id", "user_id" },
                keyValues: new object[] { new Guid("e8a4ab9d-3eae-4dd3-8900-ee2debbf90f1"), new Guid("5099b530-3bf7-47ba-b894-8291236a0198") });

            migrationBuilder.DeleteData(
                table: "BadgesToUser",
                keyColumns: new[] { "badge_id", "user_id" },
                keyValues: new object[] { new Guid("2ed7d868-efd2-47d8-8375-eead449bb1ea"), new Guid("51485224-7236-4cdf-a155-76f66c3d1795") });

            migrationBuilder.DeleteData(
                table: "BadgesToUser",
                keyColumns: new[] { "badge_id", "user_id" },
                keyValues: new object[] { new Guid("d0046aa4-dbec-47ba-9e28-2ffcae66fbfb"), new Guid("6718d752-9569-4126-90b2-7e00f5990b0a") });

            migrationBuilder.DeleteData(
                table: "BadgesToUser",
                keyColumns: new[] { "badge_id", "user_id" },
                keyValues: new object[] { new Guid("36f7239e-502d-413b-847f-2ac07362f70c"), new Guid("7956c394-e9c5-4b9c-904f-954c459bad02") });

            migrationBuilder.DeleteData(
                table: "BadgesToUser",
                keyColumns: new[] { "badge_id", "user_id" },
                keyValues: new object[] { new Guid("879a4b23-d8a8-4d58-87c3-54a08c6f5bf3"), new Guid("98296d73-6a0c-4da9-8362-6fa8dcfb5de7") });

            migrationBuilder.DeleteData(
                table: "BadgesToUser",
                keyColumns: new[] { "badge_id", "user_id" },
                keyValues: new object[] { new Guid("08823ad9-9907-48a9-8ba0-b147e4d55d5c"), new Guid("ac6b08e1-53e3-4364-a6af-0a7ecc299154") });

            migrationBuilder.DeleteData(
                table: "BadgesToUser",
                keyColumns: new[] { "badge_id", "user_id" },
                keyValues: new object[] { new Guid("ebeb732c-d0f0-47ae-b1ce-b572403c26b7"), new Guid("ad4f12f8-6280-47a1-9e8f-54e97b84e792") });

            migrationBuilder.DeleteData(
                table: "BadgesToUser",
                keyColumns: new[] { "badge_id", "user_id" },
                keyValues: new object[] { new Guid("21788ab5-8329-4339-9e56-7b709772f6ea"), new Guid("c35e44b0-57ef-456f-8d7a-d0a12f9df13b") });

            migrationBuilder.DeleteData(
                table: "BadgesToUser",
                keyColumns: new[] { "badge_id", "user_id" },
                keyValues: new object[] { new Guid("22b8a2fc-62b9-49b6-8926-91a297ae2d00"), new Guid("e61d255f-8b80-4e08-9c08-dbab8df42f17") });

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("083b6ace-924e-43bd-90e2-cc9ea1283a2f"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("153cdeda-6f23-44cd-9d7a-b2d28031de5d"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("171a179f-1a6c-41b5-91e7-fe3991cd8bf0"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("268fb02f-6d22-42a4-9581-a20ea9c42228"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("2a92a319-5e77-4deb-99eb-3cdbc83bb03d"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("723f1c4b-5c9f-4c14-8b3a-8f94a2551131"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("82c02a0c-6101-43bf-9e0f-c8b76f47cc4c"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("b8f8f98e-b975-4bef-8627-be31b31b404e"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("c21ea06b-ddd6-406f-aba0-0054224867f1"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "id",
                keyValue: new Guid("f46ec2c0-ac8c-4561-a118-79d7c7a35524"));

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 3, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6640), new Guid("368c6dee-0c79-4673-b178-bf23125a7d0a") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 4, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6640), new Guid("e61d255f-8b80-4e08-9c08-dbab8df42f17") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 5, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6640), new Guid("ad4f12f8-6280-47a1-9e8f-54e97b84e792") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 6, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6640), new Guid("6718d752-9569-4126-90b2-7e00f5990b0a") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 7, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6640), new Guid("51485224-7236-4cdf-a155-76f66c3d1795") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 8, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6640), new Guid("98296d73-6a0c-4da9-8362-6fa8dcfb5de7") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 9, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6650), new Guid("5099b530-3bf7-47ba-b894-8291236a0198") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 10, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6650), new Guid("7956c394-e9c5-4b9c-904f-954c459bad02") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 11, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6650), new Guid("c35e44b0-57ef-456f-8d7a-d0a12f9df13b") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6650), new Guid("ac6b08e1-53e3-4364-a6af-0a7ecc299154") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 13, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6650), new Guid("368c6dee-0c79-4673-b178-bf23125a7d0a") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 14, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6650), new Guid("e61d255f-8b80-4e08-9c08-dbab8df42f17") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 15, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6650), new Guid("ad4f12f8-6280-47a1-9e8f-54e97b84e792") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 16, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6650), new Guid("6718d752-9569-4126-90b2-7e00f5990b0a") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 17, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6650), new Guid("51485224-7236-4cdf-a155-76f66c3d1795") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 18, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6660), new Guid("98296d73-6a0c-4da9-8362-6fa8dcfb5de7") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 19, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6660), new Guid("5099b530-3bf7-47ba-b894-8291236a0198") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 20, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6660), new Guid("7956c394-e9c5-4b9c-904f-954c459bad02") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 21, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6660), new Guid("c35e44b0-57ef-456f-8d7a-d0a12f9df13b") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 22, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6660), new Guid("ac6b08e1-53e3-4364-a6af-0a7ecc299154") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 23, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6660), new Guid("368c6dee-0c79-4673-b178-bf23125a7d0a") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 24, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6660), new Guid("e61d255f-8b80-4e08-9c08-dbab8df42f17") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 25, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6660), new Guid("ad4f12f8-6280-47a1-9e8f-54e97b84e792") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 26, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6660), new Guid("6718d752-9569-4126-90b2-7e00f5990b0a") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 27, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6660), new Guid("51485224-7236-4cdf-a155-76f66c3d1795") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 28, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6670), new Guid("98296d73-6a0c-4da9-8362-6fa8dcfb5de7") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 29, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6670), new Guid("5099b530-3bf7-47ba-b894-8291236a0198") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 30, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6670), new Guid("7956c394-e9c5-4b9c-904f-954c459bad02") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2023, 12, 31, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6670), new Guid("c35e44b0-57ef-456f-8d7a-d0a12f9df13b") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 1, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6670), new Guid("ac6b08e1-53e3-4364-a6af-0a7ecc299154") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 2, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6670), new Guid("368c6dee-0c79-4673-b178-bf23125a7d0a") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 3, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6670), new Guid("e61d255f-8b80-4e08-9c08-dbab8df42f17") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 4, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6670), new Guid("ad4f12f8-6280-47a1-9e8f-54e97b84e792") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 5, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6680), new Guid("6718d752-9569-4126-90b2-7e00f5990b0a") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 6, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6680), new Guid("51485224-7236-4cdf-a155-76f66c3d1795") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 7, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6680), new Guid("98296d73-6a0c-4da9-8362-6fa8dcfb5de7") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 8, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6680), new Guid("5099b530-3bf7-47ba-b894-8291236a0198") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 9, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6680), new Guid("7956c394-e9c5-4b9c-904f-954c459bad02") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 10, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6680), new Guid("c35e44b0-57ef-456f-8d7a-d0a12f9df13b") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 11, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6680), new Guid("ac6b08e1-53e3-4364-a6af-0a7ecc299154") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6680), new Guid("368c6dee-0c79-4673-b178-bf23125a7d0a") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 13, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6680), new Guid("e61d255f-8b80-4e08-9c08-dbab8df42f17") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 14, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6690), new Guid("ad4f12f8-6280-47a1-9e8f-54e97b84e792") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 15, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6690), new Guid("6718d752-9569-4126-90b2-7e00f5990b0a") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 16, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6690), new Guid("51485224-7236-4cdf-a155-76f66c3d1795") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 17, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6690), new Guid("98296d73-6a0c-4da9-8362-6fa8dcfb5de7") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 18, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6690), new Guid("5099b530-3bf7-47ba-b894-8291236a0198") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 19, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6690), new Guid("7956c394-e9c5-4b9c-904f-954c459bad02") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 20, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6690), new Guid("c35e44b0-57ef-456f-8d7a-d0a12f9df13b") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 21, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6690), new Guid("ac6b08e1-53e3-4364-a6af-0a7ecc299154") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 22, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6690), new Guid("368c6dee-0c79-4673-b178-bf23125a7d0a") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 23, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6690), new Guid("e61d255f-8b80-4e08-9c08-dbab8df42f17") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 24, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6700), new Guid("ad4f12f8-6280-47a1-9e8f-54e97b84e792") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 25, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6700), new Guid("6718d752-9569-4126-90b2-7e00f5990b0a") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 26, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6700), new Guid("51485224-7236-4cdf-a155-76f66c3d1795") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 27, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6700), new Guid("98296d73-6a0c-4da9-8362-6fa8dcfb5de7") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 28, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6700), new Guid("5099b530-3bf7-47ba-b894-8291236a0198") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 29, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6700), new Guid("7956c394-e9c5-4b9c-904f-954c459bad02") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 30, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6700), new Guid("c35e44b0-57ef-456f-8d7a-d0a12f9df13b") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 1, 31, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6700), new Guid("ac6b08e1-53e3-4364-a6af-0a7ecc299154") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 1, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6700), new Guid("368c6dee-0c79-4673-b178-bf23125a7d0a") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 2, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6700), new Guid("e61d255f-8b80-4e08-9c08-dbab8df42f17") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 3, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6710), new Guid("ad4f12f8-6280-47a1-9e8f-54e97b84e792") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 4, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6710), new Guid("6718d752-9569-4126-90b2-7e00f5990b0a") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 5, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6710), new Guid("51485224-7236-4cdf-a155-76f66c3d1795") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 6, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6710), new Guid("98296d73-6a0c-4da9-8362-6fa8dcfb5de7") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 7, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6710), new Guid("5099b530-3bf7-47ba-b894-8291236a0198") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 8, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6710), new Guid("7956c394-e9c5-4b9c-904f-954c459bad02") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 9, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6710), new Guid("c35e44b0-57ef-456f-8d7a-d0a12f9df13b") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 10, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6710), new Guid("ac6b08e1-53e3-4364-a6af-0a7ecc299154") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 11, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6710), new Guid("368c6dee-0c79-4673-b178-bf23125a7d0a") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 12, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6720), new Guid("e61d255f-8b80-4e08-9c08-dbab8df42f17") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 13, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6720), new Guid("ad4f12f8-6280-47a1-9e8f-54e97b84e792") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 14, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6720), new Guid("6718d752-9569-4126-90b2-7e00f5990b0a") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 15, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6720), new Guid("51485224-7236-4cdf-a155-76f66c3d1795") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 16, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6720), new Guid("98296d73-6a0c-4da9-8362-6fa8dcfb5de7") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 17, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6720), new Guid("5099b530-3bf7-47ba-b894-8291236a0198") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 18, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6720), new Guid("7956c394-e9c5-4b9c-904f-954c459bad02") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 19, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6720), new Guid("c35e44b0-57ef-456f-8d7a-d0a12f9df13b") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 20, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6720), new Guid("ac6b08e1-53e3-4364-a6af-0a7ecc299154") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 21, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6720), new Guid("368c6dee-0c79-4673-b178-bf23125a7d0a") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 22, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6730), new Guid("e61d255f-8b80-4e08-9c08-dbab8df42f17") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 23, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6730), new Guid("ad4f12f8-6280-47a1-9e8f-54e97b84e792") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 24, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6730), new Guid("6718d752-9569-4126-90b2-7e00f5990b0a") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 25, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6730), new Guid("51485224-7236-4cdf-a155-76f66c3d1795") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 26, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6730), new Guid("98296d73-6a0c-4da9-8362-6fa8dcfb5de7") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 27, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6730), new Guid("5099b530-3bf7-47ba-b894-8291236a0198") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 28, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6730), new Guid("7956c394-e9c5-4b9c-904f-954c459bad02") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 2, 29, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6730), new Guid("c35e44b0-57ef-456f-8d7a-d0a12f9df13b") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 1, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6730), new Guid("ac6b08e1-53e3-4364-a6af-0a7ecc299154") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 2, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6730), new Guid("368c6dee-0c79-4673-b178-bf23125a7d0a") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 3, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6740), new Guid("e61d255f-8b80-4e08-9c08-dbab8df42f17") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 4, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6740), new Guid("ad4f12f8-6280-47a1-9e8f-54e97b84e792") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 5, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6740), new Guid("6718d752-9569-4126-90b2-7e00f5990b0a") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 6, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6740), new Guid("51485224-7236-4cdf-a155-76f66c3d1795") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 7, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6740), new Guid("98296d73-6a0c-4da9-8362-6fa8dcfb5de7") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 8, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6740), new Guid("5099b530-3bf7-47ba-b894-8291236a0198") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 9, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6740), new Guid("7956c394-e9c5-4b9c-904f-954c459bad02") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 10, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6740), new Guid("c35e44b0-57ef-456f-8d7a-d0a12f9df13b") });

            migrationBuilder.DeleteData(
                table: "DayOfWalk",
                keyColumns: new[] { "date", "user_id" },
                keyValues: new object[] { new DateTime(2024, 3, 11, 21, 33, 37, 275, DateTimeKind.Local).AddTicks(6740), new Guid("ac6b08e1-53e3-4364-a6af-0a7ecc299154") });

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("08823ad9-9907-48a9-8ba0-b147e4d55d5c"));

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("21788ab5-8329-4339-9e56-7b709772f6ea"));

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("22b8a2fc-62b9-49b6-8926-91a297ae2d00"));

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("2ed7d868-efd2-47d8-8375-eead449bb1ea"));

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("36f7239e-502d-413b-847f-2ac07362f70c"));

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("44cacbd7-ed31-4116-a5fa-f750020e0b1e"));

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("879a4b23-d8a8-4d58-87c3-54a08c6f5bf3"));

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("d0046aa4-dbec-47ba-9e28-2ffcae66fbfb"));

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("e8a4ab9d-3eae-4dd3-8900-ee2debbf90f1"));

            migrationBuilder.DeleteData(
                table: "Badges",
                keyColumn: "id",
                keyValue: new Guid("ebeb732c-d0f0-47ae-b1ce-b572403c26b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("368c6dee-0c79-4673-b178-bf23125a7d0a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("5099b530-3bf7-47ba-b894-8291236a0198"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("51485224-7236-4cdf-a155-76f66c3d1795"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("6718d752-9569-4126-90b2-7e00f5990b0a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("7956c394-e9c5-4b9c-904f-954c459bad02"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("98296d73-6a0c-4da9-8362-6fa8dcfb5de7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("ac6b08e1-53e3-4364-a6af-0a7ecc299154"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("ad4f12f8-6280-47a1-9e8f-54e97b84e792"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("c35e44b0-57ef-456f-8d7a-d0a12f9df13b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("e61d255f-8b80-4e08-9c08-dbab8df42f17"));

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
        }
    }
}
