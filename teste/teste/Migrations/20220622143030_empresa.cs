using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace teste.Migrations
{
    public partial class empresa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telefones_FornecedorComCnpj_FornecedorComCnpjId",
                table: "Telefones");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefones_FornecedorComCpf_FornecedorComCpfId",
                table: "Telefones");

            migrationBuilder.DropIndex(
                name: "IX_Telefones_FornecedorComCnpjId",
                table: "Telefones");

            migrationBuilder.DropIndex(
                name: "IX_Telefones_FornecedorComCpfId",
                table: "Telefones");

            migrationBuilder.DropColumn(
                name: "FornecedorComCnpjId",
                table: "Telefones");

            migrationBuilder.DropColumn(
                name: "FornecedorComCpfId",
                table: "Telefones");

            migrationBuilder.AddColumn<int>(
                name: "TelefoneId",
                table: "FornecedorComCpf",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TelefoneId",
                table: "FornecedorComCnpj",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TelefoneId",
                table: "FornecedorComCpf");

            migrationBuilder.DropColumn(
                name: "TelefoneId",
                table: "FornecedorComCnpj");

            migrationBuilder.AddColumn<int>(
                name: "FornecedorComCnpjId",
                table: "Telefones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FornecedorComCpfId",
                table: "Telefones",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_FornecedorComCnpjId",
                table: "Telefones",
                column: "FornecedorComCnpjId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_FornecedorComCpfId",
                table: "Telefones",
                column: "FornecedorComCpfId");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefones_FornecedorComCnpj_FornecedorComCnpjId",
                table: "Telefones",
                column: "FornecedorComCnpjId",
                principalTable: "FornecedorComCnpj",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefones_FornecedorComCpf_FornecedorComCpfId",
                table: "Telefones",
                column: "FornecedorComCpfId",
                principalTable: "FornecedorComCpf",
                principalColumn: "Id");
        }
    }
}
