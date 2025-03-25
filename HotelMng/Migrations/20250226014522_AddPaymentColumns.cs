using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelMng.Migrations
{
    /// <inheritdoc />
    public partial class AddPaymentColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Payment_CardCVC",
                table: "reservations",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Payment_CardExp",
                table: "reservations",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Payment_CardNumber",
                table: "reservations",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Payment_PaymentType",
                table: "reservations",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Payment_CardCVC",
                table: "reservations");

            migrationBuilder.DropColumn(
                name: "Payment_CardExp",
                table: "reservations");

            migrationBuilder.DropColumn(
                name: "Payment_CardNumber",
                table: "reservations");

            migrationBuilder.DropColumn(
                name: "Payment_PaymentType",
                table: "reservations");
        }
    }
}
