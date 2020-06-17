using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Escuela.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 5, nullable: false),
                    Jornada = table.Column<int>(nullable: false),
                    Dirección = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                name: "Alumnos",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    CursoId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumnos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alumnos_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Asignaturas",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    CursoId = table.Column<string>(nullable: true),
                    AlumnoId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignaturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asignaturas_Alumnos_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "Alumnos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asignaturas_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    AlumnoId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Alumnos_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "Alumnos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
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
                table: "Cursos",
                columns: new[] { "Id", "Dirección", "Jornada", "Nombre" },
                values: new object[,]
                {
                    { "dd6fd768-fedf-49d9-b113-a49416cb1b55", null, 0, "101" },
                    { "0926b725-a4b9-4b93-9699-d28906bea276", null, 1, "102" },
                    { "49e3c37e-6d67-4d3b-baf4-7d3bea1291e2", null, 0, "103" },
                    { "967fbe03-ab75-4372-ace4-ef80f1cf5d23", null, 2, "104" }
                });

            migrationBuilder.InsertData(
                table: "Asignaturas",
                columns: new[] { "Id", "AlumnoId", "CursoId", "Nombre" },
                values: new object[,]
                {
                    { "80d00e85-4f1d-4bcd-8df7-ed9467cdb95d", null, "dd6fd768-fedf-49d9-b113-a49416cb1b55", "Matemáticas" },
                    { "b03a0a25-5300-43da-a799-2927fbe91ced", null, "967fbe03-ab75-4372-ace4-ef80f1cf5d23", "Castellano" },
                    { "fe5bea6c-bf54-47a6-9b5c-8d057788f955", null, "967fbe03-ab75-4372-ace4-ef80f1cf5d23", "Educación Física" },
                    { "52e2a857-9d7c-47ee-bc08-3925adcd51ac", null, "967fbe03-ab75-4372-ace4-ef80f1cf5d23", "Matemáticas" },
                    { "db400b75-0bd1-45f6-993d-4d8f5d578d34", null, "49e3c37e-6d67-4d3b-baf4-7d3bea1291e2", "Programación" },
                    { "9c773177-c451-4f16-9487-521d1dc123f5", null, "49e3c37e-6d67-4d3b-baf4-7d3bea1291e2", "Ciencias Naturales" },
                    { "22a91149-dd7b-4cea-b403-3007d69f7221", null, "49e3c37e-6d67-4d3b-baf4-7d3bea1291e2", "Castellano" },
                    { "12b2ee01-05ba-43ad-9d45-49c15bdee722", null, "49e3c37e-6d67-4d3b-baf4-7d3bea1291e2", "Educación Física" },
                    { "24db15d1-bd63-4dfd-9093-067ecf89613e", null, "49e3c37e-6d67-4d3b-baf4-7d3bea1291e2", "Matemáticas" },
                    { "fdac5fb4-48bc-45c4-a24f-6a89ea7c8b76", null, "0926b725-a4b9-4b93-9699-d28906bea276", "Programación" },
                    { "5b709b79-b2ab-4c69-9468-bc82aa210065", null, "0926b725-a4b9-4b93-9699-d28906bea276", "Ciencias Naturales" },
                    { "dc8f1b36-4863-46f5-b6a4-5411c85c5069", null, "0926b725-a4b9-4b93-9699-d28906bea276", "Castellano" },
                    { "0a5e8ed9-22dd-4414-accc-f0523dc6c680", null, "0926b725-a4b9-4b93-9699-d28906bea276", "Educación Física" },
                    { "94378f5d-7959-41b9-9980-42b5996ad289", null, "0926b725-a4b9-4b93-9699-d28906bea276", "Matemáticas" },
                    { "94e5afa4-4814-4ec3-8489-334e9cda4876", null, "dd6fd768-fedf-49d9-b113-a49416cb1b55", "Programación" },
                    { "49288972-7bae-49cb-b7de-b588146708f0", null, "dd6fd768-fedf-49d9-b113-a49416cb1b55", "Ciencias Naturales" },
                    { "c68a2980-e138-49c1-bbd7-1e1a820fc359", null, "dd6fd768-fedf-49d9-b113-a49416cb1b55", "Castellano" },
                    { "4be9398d-90c0-4115-8ea1-2b46c84b8fdf", null, "dd6fd768-fedf-49d9-b113-a49416cb1b55", "Educación Física" },
                    { "2b0e3d61-15e2-40b1-9430-330877f474c7", null, "967fbe03-ab75-4372-ace4-ef80f1cf5d23", "Ciencias Naturales" },
                    { "3380b73f-25c4-4a05-8d61-a7f0688950ea", null, "967fbe03-ab75-4372-ace4-ef80f1cf5d23", "Programación" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_CursoId",
                table: "Alumnos",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Asignaturas_AlumnoId",
                table: "Asignaturas",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Asignaturas_CursoId",
                table: "Asignaturas",
                column: "CursoId");

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
                name: "IX_AspNetUsers_AlumnoId",
                table: "AspNetUsers",
                column: "AlumnoId");

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
                name: "Asignaturas");

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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Alumnos");

            migrationBuilder.DropTable(
                name: "Cursos");
        }
    }
}
