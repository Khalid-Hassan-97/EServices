using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EServicesAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "Name", "PasswordHash", "PhoneNumber", "UserType", "Username" },
                values: new object[,]
                {
                    { 1, "ahmed@email.com", "Ahmed Ali Omer Yassir", "QWhtZWRAMTIz", "+971112345667", 2, "Ahmed_50" },
                    { 2, "ali@email.com", "Ali Omer Yassir Ahmed", "QWxpQDEyMw==", "+971112345667", 2, "Ali_51" },
                    { 3, "omer@email.com", "Omer Yassir Ahmed Ali", "T21lckAxMjM=", "+971112345667", 2, "Omer_52" },
                    { 4, "yassir@email.com", "Yassir Ahmed Ali Omer", "WWFzc2lyQDEyMw==", "+971112345667", 2, "Yassir_53" },
                    { 5, "rami@email.com", "Rami Ali Ammar", "UmFtaUAxMjM=", "+971112345667", 1, "Rami_90" },
                    { 6, "hussam@email.com", "Hussam Ali Ammar", "SHVzc2FtQDEyMw==", "+971112345667", 1, "Hussam_91" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6);
        }
    }
}
