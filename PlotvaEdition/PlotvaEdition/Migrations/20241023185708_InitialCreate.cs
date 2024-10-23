using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlotvaEdition.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderStatuses",
                columns: table => new
                {
                    StatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatuses", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserPhone = table.Column<string>(nullable: false),
                    UserPassword = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserPhone);
                });

            migrationBuilder.CreateTable(
                name: "Parcels",
                columns: table => new
                {
                    ParcelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderPhone = table.Column<string>(maxLength: 10, nullable: false),
                    ReceiverPhone = table.Column<string>(maxLength: 10, nullable: false),
                    DispatchDate = table.Column<DateTime>(nullable: false),
                    DeliveryDate = table.Column<DateTime>(nullable: false),
                    OrderStatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parcels", x => x.ParcelId);
                    table.ForeignKey(
                        name: "FK_Parcels_OrderStatuses_OrderStatusId",
                        column: x => x.OrderStatusId,
                        principalTable: "OrderStatuses",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    UserPhone = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(maxLength: 50, nullable: false),
                    UserPhone1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.UserPhone);
                    table.ForeignKey(
                        name: "FK_UserDetails_Users_UserPhone1",
                        column: x => x.UserPhone1,
                        principalTable: "Users",
                        principalColumn: "UserPhone",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    ParcelId = table.Column<int>(nullable: true),
                    PaymentDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payments_Parcels_ParcelId",
                        column: x => x.ParcelId,
                        principalTable: "Parcels",
                        principalColumn: "ParcelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parcels_OrderStatusId",
                table: "Parcels",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ParcelId",
                table: "Payments",
                column: "ParcelId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_UserPhone1",
                table: "UserDetails",
                column: "UserPhone1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "UserDetails");

            migrationBuilder.DropTable(
                name: "Parcels");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "OrderStatuses");
        }
    }
}
