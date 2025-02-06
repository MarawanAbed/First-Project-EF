using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp10.Migrations
{
    /// <inheritdoc />
    public partial class navigatePropert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DepartmentId",
                table: "empolyees",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "EmpolyeeProject",
                columns: table => new
                {
                    EmpolyeesId = table.Column<long>(type: "bigint", nullable: false),
                    ProjectsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpolyeeProject", x => new { x.EmpolyeesId, x.ProjectsId });
                    table.ForeignKey(
                        name: "FK_EmpolyeeProject_empolyees_EmpolyeesId",
                        column: x => x.EmpolyeesId,
                        principalTable: "empolyees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpolyeeProject_projects_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "workFors",
                columns: table => new
                {
                    EmpolyeeId = table.Column<long>(type: "bigint", nullable: false),
                    ProjectId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workFors", x => new { x.EmpolyeeId, x.ProjectId });
                    table.ForeignKey(
                        name: "FK_workFors_empolyees_EmpolyeeId",
                        column: x => x.EmpolyeeId,
                        principalTable: "empolyees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_workFors_projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_empolyees_DepartmentId",
                table: "empolyees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpolyeeProject_ProjectsId",
                table: "EmpolyeeProject",
                column: "ProjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_workFors_ProjectId",
                table: "workFors",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_empolyees_departments_DepartmentId",
                table: "empolyees",
                column: "DepartmentId",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_empolyees_departments_DepartmentId",
                table: "empolyees");

            migrationBuilder.DropTable(
                name: "EmpolyeeProject");

            migrationBuilder.DropTable(
                name: "workFors");

            migrationBuilder.DropIndex(
                name: "IX_empolyees_DepartmentId",
                table: "empolyees");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "empolyees");
        }
    }
}
