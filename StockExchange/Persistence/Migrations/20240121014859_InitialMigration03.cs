using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("942c497e-a622-42b0-b864-9645d689c6cc"));

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("ae8e90a7-1cd2-4306-914d-ef3db84f3e69"));

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("b46c3b51-c3ae-4de1-bca6-69d5e2fe2c63"));

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("be11e97f-aa0e-4914-b78b-129dd617270e"));

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("d68ac55b-03bc-4b03-9b1c-a8b007b47dcf"));

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "CurrentPrice", "IsActive", "Symbol", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("436be331-dbff-4c00-95e8-5220ab4d654c"), null, null, 45m, true, "MSFT", null, null },
                    { new Guid("6f020b6d-40d8-4ae5-b2b2-237b4f43b6d1"), null, null, 50m, true, "GOOGL", null, null },
                    { new Guid("a6ec6fa3-72f4-4325-9e0f-cf21687b7bb8"), null, null, 67m, true, "TSLA", null, null },
                    { new Guid("b195b012-3b6a-40c9-a0fc-58dd811e2a69"), null, null, 34m, true, "AMZN", null, null },
                    { new Guid("f148d92c-35ff-4238-aee8-53acd94559fb"), null, null, 46m, true, "AAPL", null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("436be331-dbff-4c00-95e8-5220ab4d654c"));

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("6f020b6d-40d8-4ae5-b2b2-237b4f43b6d1"));

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("a6ec6fa3-72f4-4325-9e0f-cf21687b7bb8"));

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("b195b012-3b6a-40c9-a0fc-58dd811e2a69"));

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("f148d92c-35ff-4238-aee8-53acd94559fb"));

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "CurrentPrice", "IsActive", "Symbol", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("942c497e-a622-42b0-b864-9645d689c6cc"), null, null, 46m, true, "GOOGL", null, null },
                    { new Guid("ae8e90a7-1cd2-4306-914d-ef3db84f3e69"), null, null, 67m, true, "TSLA", null, null },
                    { new Guid("b46c3b51-c3ae-4de1-bca6-69d5e2fe2c63"), null, null, 34m, true, "AMZN", null, null },
                    { new Guid("be11e97f-aa0e-4914-b78b-129dd617270e"), null, null, 45m, true, "MSFT", null, null },
                    { new Guid("d68ac55b-03bc-4b03-9b1c-a8b007b47dcf"), null, null, 50m, true, "GOOGL", null, null }
                });
        }
    }
}
