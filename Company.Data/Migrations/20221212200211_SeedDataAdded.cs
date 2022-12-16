using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Company.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name", "OrganisationNumber" },
                values: new object[] { 1, "Hugos Bilar AB", "1234567890" });

            migrationBuilder.InsertData(
                table: "Titles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Manager" },
                    { 2, "Chief Sales Officer" },
                    { 3, "Chief Support Officer" },
                    { 4, "Chief Distribution Officer" },
                    { 5, "Chief Marketing Officer" },
                    { 6, "Sales Officer" },
                    { 7, "Support Officer" },
                    { 8, "Distribution Officer" },
                    { 9, "Marketing Officer" },
                    { 10, "HR Officer" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CompanyId", "EmployeeId", "Name" },
                values: new object[,]
                {
                    { 1, 1, null, "HR" },
                    { 2, 1, null, "Sales" },
                    { 3, 1, null, "Support" },
                    { 4, 1, null, "Distribution" },
                    { 5, 1, null, "Marketing" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "FirstName", "IsUnionMember", "LastName", "Salary" },
                values: new object[,]
                {
                    { 1, 1, "Mathilda", false, "Ljung", 60000.00m },
                    { 2, 2, "Jonatan", true, "Grandelius", 55000.00m },
                    { 3, 3, "hugo", false, "Grandelius", 50000.00m },
                    { 4, 4, "John", true, "Anderson", 50000.00m },
                    { 5, 5, "Eric", true, "Johnson", 50000.00m },
                    { 6, 1, "Kerstin", false, "Nilsson", 45000.00m },
                    { 7, 2, "Frida", true, "Grandelius", 35000.00m },
                    { 8, 3, "Sofie", false, "Johansson", 30000.00m },
                    { 9, 4, "Fredrik", true, "Ericson", 35000.00m },
                    { 10, 5, "Annelee", true, "Johanson", 30000.00m },
                    { 11, 1, "Erik", true, "Nilsson", 10000.00m }
                });

            migrationBuilder.InsertData(
                table: "EmployeeTitles",
                columns: new[] { "EmployeeId", "TitleId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 7, 6 },
                    { 8, 7 },
                    { 9, 8 },
                    { 10, 9 },
                    { 1, 10 },
                    { 6, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeTitles",
                keyColumns: new[] { "EmployeeId", "TitleId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeeTitles",
                keyColumns: new[] { "EmployeeId", "TitleId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "EmployeeTitles",
                keyColumns: new[] { "EmployeeId", "TitleId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "EmployeeTitles",
                keyColumns: new[] { "EmployeeId", "TitleId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "EmployeeTitles",
                keyColumns: new[] { "EmployeeId", "TitleId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "EmployeeTitles",
                keyColumns: new[] { "EmployeeId", "TitleId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "EmployeeTitles",
                keyColumns: new[] { "EmployeeId", "TitleId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "EmployeeTitles",
                keyColumns: new[] { "EmployeeId", "TitleId" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "EmployeeTitles",
                keyColumns: new[] { "EmployeeId", "TitleId" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "EmployeeTitles",
                keyColumns: new[] { "EmployeeId", "TitleId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "EmployeeTitles",
                keyColumns: new[] { "EmployeeId", "TitleId" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
