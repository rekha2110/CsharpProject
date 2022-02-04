using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeSheetManagement.DAL.Migrations
{
    public partial class AllModelsCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "manager",
                columns: table => new
                {
                    MgrID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MgrName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MgrEmaiID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MgrPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MgrUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MgrPsw = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MgrDOJ = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manager", x => x.MgrID);
                });

            migrationBuilder.CreateTable(
                name: "project",
                columns: table => new
                {
                    ProjectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_project", x => x.ProjectID);
                });

            migrationBuilder.CreateTable(
                name: "employee",
                columns: table => new
                {
                    EmpID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpEmailID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpPsw = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpDOJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MgrID = table.Column<int>(type: "int", nullable: false),
                    ProjectID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee", x => x.EmpID);
                    table.ForeignKey(
                        name: "FK_employee_manager_MgrID",
                        column: x => x.MgrID,
                        principalTable: "manager",
                        principalColumn: "MgrID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employee_project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_employee_MgrID",
                table: "employee",
                column: "MgrID");

            migrationBuilder.CreateIndex(
                name: "IX_employee_ProjectID",
                table: "employee",
                column: "ProjectID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employee");

            migrationBuilder.DropTable(
                name: "manager");

            migrationBuilder.DropTable(
                name: "project");
        }
    }
}
