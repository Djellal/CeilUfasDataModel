using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataModel.Migrations
{
    /// <inheritdoc />
    public partial class CurrentSessionIdnotnullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppSettings_Sessions_CurrentSessionId",
                table: "AppSettings");

            migrationBuilder.AlterColumn<int>(
                name: "CurrentSessionId",
                table: "AppSettings",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AppSettings_Sessions_CurrentSessionId",
                table: "AppSettings",
                column: "CurrentSessionId",
                principalTable: "Sessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppSettings_Sessions_CurrentSessionId",
                table: "AppSettings");

            migrationBuilder.AlterColumn<int>(
                name: "CurrentSessionId",
                table: "AppSettings",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_AppSettings_Sessions_CurrentSessionId",
                table: "AppSettings",
                column: "CurrentSessionId",
                principalTable: "Sessions",
                principalColumn: "Id");
        }
    }
}
