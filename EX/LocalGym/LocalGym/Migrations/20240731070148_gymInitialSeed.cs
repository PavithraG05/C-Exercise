using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LocalGym.Migrations
{
    /// <inheritdoc />
    public partial class gymInitialSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainers_Trainers_TrainerId1",
                table: "Trainers");

            migrationBuilder.DropIndex(
                name: "IX_Trainers_TrainerId1",
                table: "Trainers");

            migrationBuilder.DropColumn(
                name: "TrainerId1",
                table: "Trainers");

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Email", "FirstName", "JoinDate", "LastName" },
                values: new object[,]
                {
                    { 1, "alice.johnson@example.com", "Alice", new DateOnly(2023, 1, 15), "Johnson" },
                    { 2, "bob.smith@example.com", "Bob", new DateOnly(2023, 2, 22), "Smith" },
                    { 3, "carol.davis@example.com", "Carol", new DateOnly(2023, 3, 10), "Davis" },
                    { 4, "dave.wilson@example.com", "Dave", new DateOnly(2023, 4, 5), "Wilson" },
                    { 5, "eve.brown@example.com", "Eve", new DateOnly(2023, 5, 20), "Brown" }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "TrainerId", "FeePer30Minutes", "FirstName", "HireDate", "LastName", "Speciality" },
                values: new object[,]
                {
                    { 1, 30.0, "John", new DateOnly(2022, 11, 1), "Carter", "Strength Training" },
                    { 2, 25.0, "Emma", new DateOnly(2023, 1, 15), "Green", "Yoga" },
                    { 3, 35.0, "Michael", new DateOnly(2023, 3, 10), "Lee", "Cardio" },
                    { 4, 28.0, "Sarah", new DateOnly(2023, 4, 20), "Martinez", "Pilates" },
                    { 5, 32.0, "Chris", new DateOnly(2023, 6, 1), "Clark", "Weightlifting" }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "SessionId", "CustomerId", "Duration", "SessionDate", "TrainerId" },
                values: new object[,]
                {
                    { 1, 1, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(45)), new DateOnly(2024, 7, 15), 2 },
                    { 2, 2, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(60)), new DateOnly(2024, 7, 16), 3 },
                    { 3, 3, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(30)), new DateOnly(2024, 7, 17), 1 },
                    { 4, 4, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(50)), new DateOnly(2024, 7, 18), 4 },
                    { 5, 5, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(40)), new DateOnly(2024, 7, 19), 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 5);

            migrationBuilder.AddColumn<int>(
                name: "TrainerId1",
                table: "Trainers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trainers_TrainerId1",
                table: "Trainers",
                column: "TrainerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainers_Trainers_TrainerId1",
                table: "Trainers",
                column: "TrainerId1",
                principalTable: "Trainers",
                principalColumn: "TrainerId");
        }
    }
}
