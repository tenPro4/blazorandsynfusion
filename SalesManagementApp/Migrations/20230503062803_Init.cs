using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesManagementApp.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAllDay = table.Column<bool>(type: "bit", nullable: false),
                    RecurrenceRule = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecurrenceException = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecurrenceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RetailOutletId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeJobTitles",
                columns: table => new
                {
                    EmployeeJobTitleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeJobTitles", x => x.EmployeeJobTitleId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReportToEmpId = table.Column<int>(type: "int", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeJobTitleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RetailOutlets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RetailOutlets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrderReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    OrderDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderQty = table.Column<int>(type: "int", nullable: false),
                    OrderItemId = table.Column<int>(type: "int", nullable: false),
                    OrderItemQty = table.Column<int>(type: "int", nullable: false),
                    OrderItemPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    ClientFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RetailOutletId = table.Column<int>(type: "int", nullable: false),
                    RetailOutletLocation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderReports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Email", "FirstName", "JobTitle", "LastName", "PhoneNumber", "RetailOutletId" },
                values: new object[,]
                {
                    { 1, "james.tailor@company.com", "James", "Buyer", "Tailor", "000000000", 1 },
                    { 2, "jill.hutton@company.com", "Jill", "Buyer", "Hutton", "000000000", 2 },
                    { 3, "craig.rice@company.com", "Craig", "Buyer", "Rice", "000000000", 3 },
                    { 4, "amy.smith@company.com", "Amy", "Buyer", "Smith", "000000000", 4 }
                });

            migrationBuilder.InsertData(
                table: "EmployeeJobTitles",
                columns: new[] { "EmployeeJobTitleId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Sales Manager", "SM" },
                    { 2, "Team Leader", "TL" },
                    { 3, "Sales Rep", "SR" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "Email", "EmployeeJobTitleId", "FirstName", "Gender", "ImagePath", "LastName", "ReportToEmpId" },
                values: new object[,]
                {
                    { 1, new DateTime(1974, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "bob.jones@oexl.com", 1, "Bob", "Male", "/Images/Profile/BobJones.jpg", "Jones", null },
                    { 2, new DateTime(1976, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "jenny.marks@oexl.com", 2, "Jenny", "Female", "/Images/Profile/JennyMarks.jpg", "Marks", 1 },
                    { 3, new DateTime(1981, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "henry.andrews@oexl.com", 2, "Henry", "Male", "/Images/Profile/HenryAndrews.jpg", "Andrews", 1 },
                    { 4, new DateTime(1984, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.jameson@oexl.com", 2, "John", "Male", "/Images/Profile/JohnJameson.jpg", "Jameson", 1 },
                    { 5, new DateTime(1993, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "noah.robinson@oexl.com", 3, "Noah", "Male", "/Images/Profile/NoahRobinson.jpg", "Robinson", 2 },
                    { 6, new DateTime(1993, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "elijah.hamilton@oexl.com", 3, "Elijah", "Male", "/Images/Profile/ElijahHamilton.jpg", "Hamilton", 2 },
                    { 7, new DateTime(1992, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "jamie.fisher@oexl.com", 3, "Jamie", "Male", "/Images/Profile/JamieFisher.jpg", "Fisher", 2 },
                    { 8, new DateTime(1990, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "olivia.mills@oexl.com", 3, "Olivia", "Female", "/Images/Profile/OliviaMills.jpg", "Mills", 3 },
                    { 9, new DateTime(1993, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "benjamin.lucas@oexl.com", 3, "Benjamin", "Male", "/Images/Profile/BenjaminLucas.jpg", "Lucas", 3 },
                    { 10, new DateTime(1993, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "sarah.henderson@oexl.com", 3, "Sarah", "Female", "/Images/Profile/SarahHenderson.jpg", "Henderson", 3 },
                    { 11, new DateTime(1995, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "emma.lee@oexl.com", 3, "Emma", "Female", "/Images/Profile/EmmaLee.jpg", "Lee", 4 },
                    { 12, new DateTime(1998, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "ava.williams@oexl.com", 3, "Ava", "Female", "/Images/Profile/AvaWilliams.jpg", "Williams", 4 },
                    { 13, new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "angela.moore@oexl.com", 3, "Angela", "Female", "/Images/Profile/AngelaMoore.jpg", "Moore", 4 }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mountain Bikes" },
                    { 2, "Road Bikes" },
                    { 3, "Camping" },
                    { 4, "Hiking" },
                    { 5, "Boots" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImagePath", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/products/MountainBike1.jpg", "Mountain Bike 1", 200m },
                    { 2, 1, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/products/MountainBike2.jpg", "Mountain Bike 2", 210m },
                    { 3, 2, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/products/RoadBike1.jpg", "Road Bike 1", 240m },
                    { 4, 2, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/products/RoadBike2.jpg", "Road Bike 2", 250m },
                    { 5, 2, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/products/RoadBike3.jpg", "Road Bike 3", 252m },
                    { 6, 2, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/products/RoadBike4.jpg", "Road Bike 4", 230m },
                    { 7, 3, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/products/Tent1.jpg", "Tent 1", 230m },
                    { 8, 3, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/products/Tent2.jpg", "Tent 2", 230m },
                    { 9, 3, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/products/Mattress1.jpg", "Air Mattress 1", 11m },
                    { 10, 3, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/products/Mattress2.jpg", "Air Mattress 2", 40m },
                    { 11, 3, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/products/Mattress3.jpg", "Air Mattress 3", 54m },
                    { 12, 3, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/products/Mattress4.jpg", "Air Mattress 4", 15m },
                    { 13, 4, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/products/Pack1.jpg", "Pack 1", 24m },
                    { 14, 4, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/products/Pack2.jpg", "Pack 2", 30m },
                    { 15, 4, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/products/Pack3.jpg", "Pack 3", 35m },
                    { 16, 5, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/products/Boot1.jpg", "Boot 1", 20m },
                    { 17, 5, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/products/Boot2.jpg", "Boot 2", 38m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImagePath", "Name", "Price" },
                values: new object[,]
                {
                    { 18, 5, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/products/Boot3.jpg", "Boot 3", 35m },
                    { 19, 5, "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ", "/Images/products/Boot4.jpg", "Boot 4", 31m }
                });

            migrationBuilder.InsertData(
                table: "RetailOutlets",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "TX", "Texas Outdoor Store" },
                    { 2, "CA", "California Outdoor Store" },
                    { 3, "NY", "New York Outdoor Store" },
                    { 4, "WA", " Washington Outdoor Store" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "EmployeeJobTitles");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "RetailOutlets");

            migrationBuilder.DropTable(
                name: "SalesOrderReports");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
