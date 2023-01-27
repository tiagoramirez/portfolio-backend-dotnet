using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace portfolio.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IconClassName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsEnglishModeEnabled = table.Column<bool>(type: "bit", nullable: false),
                    NativeDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    HasEnglishDesc = table.Column<bool>(type: "bit", nullable: false),
                    EnglishDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    LocationCountry = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LocationState = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NativeAboutMe = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    HasEnglishAboutMe = table.Column<bool>(type: "bit", nullable: false),
                    EnglishAboutMe = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TitleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Institute = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    IsActual = table.Column<bool>(type: "bit", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NativeDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    HasEnglishDesc = table.Column<bool>(type: "bit", nullable: false),
                    EnglishDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Education_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Experience",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Company = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    IsActual = table.Column<bool>(type: "bit", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NativeDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    HasEnglishDesc = table.Column<bool>(type: "bit", nullable: false),
                    EnglishDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experience", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experience_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NativeDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    HasEnglishDesc = table.Column<bool>(type: "bit", nullable: false),
                    EnglishDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Project_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "User_Skill",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SkillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Percentage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Skill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Skill_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Skill_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "User_SocialMedia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SocialMediaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_SocialMedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_SocialMedia_SocialMedia_SocialMediaId",
                        column: x => x.SocialMediaId,
                        principalTable: "SocialMedia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_SocialMedia_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "Id", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("009449a7-cab2-4f00-8661-9d6f136798c0"), ".NET API", 1 },
                    { new Guid("0b953884-df06-46fc-8ce6-d126a4fd06d5"), "Redux Toolkit", 0 },
                    { new Guid("10e7ac35-e1c3-4c1d-b84d-236614f47a5c"), "Git", 2 },
                    { new Guid("185f83c2-45d2-4b5a-a051-c0ce7a924149"), "Angular", 0 },
                    { new Guid("1888a2c9-b9e8-4983-8978-1a67cc438d41"), "TailwindCss", 0 },
                    { new Guid("1914733e-44d4-45f4-b604-d71144f87622"), "Java", 1 },
                    { new Guid("1973d1db-eecc-4ce3-be99-6f1d28535d6b"), "REST API", 2 },
                    { new Guid("1fafc381-ef56-40fc-a860-e90eefaad6f9"), "C#", 1 },
                    { new Guid("3db5f181-c902-4c88-b7fd-29ff0cb6fae7"), "UML", 2 },
                    { new Guid("40923394-e520-46bd-8fa0-76d6d70101b1"), "Scrum", 2 },
                    { new Guid("41de505c-dab9-49ae-aab8-cd46aee26fa4"), "MS SQL Server", 1 },
                    { new Guid("47418b12-2db2-4525-9432-d27406fdb91c"), "Vite", 0 },
                    { new Guid("5891c7bc-2f8d-4050-97f5-c3d9c1bf2c44"), "Linux", 2 },
                    { new Guid("58ad90f3-78fb-4386-b534-7bf9bc44faad"), "Node", 2 },
                    { new Guid("5c8349d1-2beb-4f83-9a98-2246c54223e1"), "Java Spring", 1 },
                    { new Guid("5cf8da37-180a-47b2-ac26-15411b93a645"), "Migrations", 1 },
                    { new Guid("684ece0d-e804-4ec8-bc2a-464e4edaca49"), "ERD / DER", 2 },
                    { new Guid("6cb4d166-b320-44d8-a04a-6bd6fe2a460c"), "Middlewares", 1 },
                    { new Guid("6daa120f-1622-428b-ba45-f34e0dfb5df0"), "HTML", 0 },
                    { new Guid("73ef0920-a5c6-4649-b0e9-ca2a65ba59db"), "Fluent API", 1 },
                    { new Guid("7561e3c0-c475-4f8b-8721-9787b7a25335"), "MySql", 1 },
                    { new Guid("7a5e811c-1431-4376-b070-fb56b58e370d"), ".NET WPF", 1 },
                    { new Guid("86a7cd21-d61b-4c65-8e14-5f18f5a1d89d"), "JavaScript", 0 },
                    { new Guid("87683501-d404-43fc-b8d8-22a56135dc5a"), ".NET CORE 6", 1 },
                    { new Guid("87763761-f810-4858-baa3-243f35175572"), "SQL", 1 },
                    { new Guid("8f31dd42-6662-4140-aab9-686f9b937bf3"), "TypeScript", 0 },
                    { new Guid("9265be6f-c29f-488d-a0f7-f9b94594924b"), "JWT", 2 },
                    { new Guid("a403c7c1-765f-403b-b11e-736047ef7f6f"), "Vitest", 0 },
                    { new Guid("b3748093-8b87-4c43-990e-db2b4d101c62"), "Python", 1 },
                    { new Guid("b5114435-d2b6-4db2-b44b-eb0b4b25c9d1"), "Bootstrap", 0 },
                    { new Guid("c959f053-04ea-4826-b285-001277ac0860"), "React", 0 },
                    { new Guid("e66a25f8-720e-4e40-9f43-6ab8436724b5"), "Entity Framework", 1 },
                    { new Guid("e9154598-5040-4412-b2f0-caa1dda8aee5"), "React Router", 0 },
                    { new Guid("ea0beb59-5b21-4f28-9d96-8ae2f6bf38ea"), "Testing library", 0 },
                    { new Guid("ffb798d8-1325-4b51-bc61-715a51f61803"), "CSS", 0 }
                });

            migrationBuilder.InsertData(
                table: "SocialMedia",
                columns: new[] { "Id", "IconClassName", "Name" },
                values: new object[,]
                {
                    { new Guid("229676cf-976a-4a29-a64f-a2b2b2f12f02"), "bi bi-linkedin", "LinkedIn" },
                    { new Guid("72fea8f4-9829-4b25-9677-efaa48aef906"), "bi bi-youtube", "Youtube" },
                    { new Guid("922e05a2-c347-45ab-93e9-ade3f6f76b5d"), "bi bi-facebook", "Facebook" },
                    { new Guid("a1a44a81-c969-40e9-b329-e11e1dce46ce"), "bi bi-twitter", "Twitter" },
                    { new Guid("bb62519d-9d64-4b87-a4ee-6e1cde6334c5"), "bi bi-instagram", "Instagram" },
                    { new Guid("daccccb2-44c8-4d4e-b4d3-8701f75d756a"), "bi bi-person-circle", "Web Personal" },
                    { new Guid("df932255-a86c-412b-878e-0b904584008f"), "bi bi-whatsapp", "Whatsapp" }
                });

            migrationBuilder.InsertData(
                table: "SocialMedia",
                columns: new[] { "Id", "IconClassName", "Name" },
                values: new object[] { new Guid("f7d825b4-9aab-4b1f-b93a-0c777c8e5436"), "bi bi-github", "Github" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "Email", "EnglishAboutMe", "EnglishDesc", "HasEnglishAboutMe", "HasEnglishDesc", "IsEnglishModeEnabled", "LocationCountry", "LocationState", "Name", "NativeAboutMe", "NativeDesc", "Phone", "Role", "Status", "Username" },
                values: new object[] { "XShNoGTpZzRov6b2yFVcLCIFRZ33", new DateTime(2023, 1, 27, 16, 19, 44, 419, DateTimeKind.Local).AddTicks(7568), "tiagoramirez2001@gmail.com", "Fullstack Dev. with 1 year of experience in the IT area. My main stack: React + .NET 6 API + SQL Server + Node", "FullStack Dev. || React + .NET 6 + SQL Server + Node || Student in Systems Engineering - UTN (Argentina)", true, true, true, "Argentina", "Chaco", "Tiago Alberto Ramirez Marchisio", "Fullstack Dev. con 1 año de experiencia en el área de TI. Mi stack principal: React + .NET 6 API + SQL Server + Node", "FullStack Dev. || React + .NET 6 + SQL Server + Node || Ingeniería en Sistemas de Información - UTN (Argentina)", null, "USR", true, "tiagoramirez" });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "End", "EnglishDesc", "HasEnglishDesc", "Institute", "IsActual", "NativeDesc", "Start", "TitleName", "Type", "UserId" },
                values: new object[] { new Guid("d66d8386-1459-4547-8c17-828aa38732be"), null, "3rd year with an average of 9/10", true, "Universidad Tecnologica Nacional", true, "Me encuentro en 3ro con un promedio de 9/10", new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ingenieria en Sistemas de Informacion", 1, "XShNoGTpZzRov6b2yFVcLCIFRZ33" });

            migrationBuilder.InsertData(
                table: "Experience",
                columns: new[] { "Id", "Company", "End", "EnglishDesc", "HasEnglishDesc", "IsActual", "NativeDesc", "Position", "Start", "Type", "UserId" },
                values: new object[] { new Guid("e63f3f4a-ccf3-4d93-8348-cbc1e37db98f"), "Accusys", null, "Management and optimization of queries, tables, stored procedures and views in MS SQL Server databases. I work with technologies such as WPF, Classic ASP, VBS, HTML, Javascript, Java and IIS", true, true, "Manejo y optimización de querys, tables, stored procedures y views en bases de datos MS SQL Server. Trabajo con tecnologías tales como WPF, ASP Clásico, VBS, HTML, Javascript, Java y IIS", "Analista Programador Junior", new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "XShNoGTpZzRov6b2yFVcLCIFRZ33" });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "EnglishDesc", "HasEnglishDesc", "Name", "NativeDesc", "Url", "UserId" },
                values: new object[] { new Guid("ff97958c-ee0d-4c3a-979d-d54c3640de31"), "Personal portfolio made with REACT + .NET 6 + SQL Server", true, "Portfolio", "Portfolio personal realizado con REACT + .NET 6 + SQL Server", "https://www.github.com/tiagoramirez", "XShNoGTpZzRov6b2yFVcLCIFRZ33" });

            migrationBuilder.InsertData(
                table: "User_Skill",
                columns: new[] { "Id", "Percentage", "SkillId", "UserId" },
                values: new object[] { new Guid("584c9ec2-2873-4d55-ba52-bcccc0937eba"), 90, new Guid("1fafc381-ef56-40fc-a860-e90eefaad6f9"), "XShNoGTpZzRov6b2yFVcLCIFRZ33" });

            migrationBuilder.InsertData(
                table: "User_SocialMedia",
                columns: new[] { "Id", "SocialMediaId", "Url", "UserId" },
                values: new object[] { new Guid("ff1f9313-b616-4d00-b683-c956d97bc711"), new Guid("229676cf-976a-4a29-a64f-a2b2b2f12f02"), "https://www.linkedin.com/in/tiagoramirezmar/", "XShNoGTpZzRov6b2yFVcLCIFRZ33" });

            migrationBuilder.CreateIndex(
                name: "IX_Education_UserId",
                table: "Education",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Experience_UserId",
                table: "Experience",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_UserId",
                table: "Project",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Skill_SkillId",
                table: "User_Skill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Skill_UserId",
                table: "User_Skill",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_SocialMedia_SocialMediaId",
                table: "User_SocialMedia",
                column: "SocialMediaId");

            migrationBuilder.CreateIndex(
                name: "IX_User_SocialMedia_UserId",
                table: "User_SocialMedia",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "Experience");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "User_Skill");

            migrationBuilder.DropTable(
                name: "User_SocialMedia");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "SocialMedia");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
