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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experience",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User_Skill",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User_SocialMedia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "Id", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("013edfa0-8360-4d40-a527-807c64467d5f"), "Node", 2 },
                    { new Guid("0409c919-93f0-4539-8528-e87a5d38b279"), "CSS", 0 },
                    { new Guid("160a18d1-89db-4066-9e7b-97ca65e7579b"), "Vite", 0 },
                    { new Guid("194bd24c-234e-4595-9739-8b4d42f5bbf0"), "Fluent API", 1 },
                    { new Guid("19f1777b-1cb9-465d-a038-0d7534a375fd"), "Bootstrap", 0 },
                    { new Guid("1a6ed2b6-3764-4361-8c14-4981e27b46b7"), "Testing library", 0 },
                    { new Guid("223d1817-e2ce-4faf-9b51-9f8bea5e27a8"), "JWT", 2 },
                    { new Guid("2cfc462d-d4f4-421e-91b8-397f2e3dae0d"), "SQL", 1 },
                    { new Guid("308a1bc1-f1ae-47a5-8eac-a0b46f00547c"), "Git", 2 },
                    { new Guid("35f3a94d-4a84-4f10-aab3-30bf7f348225"), "Middlewares", 1 },
                    { new Guid("36283495-e75c-4dbe-b123-a952c2833998"), "JavaScript", 0 },
                    { new Guid("36485eac-391d-4fec-bbba-953208f45446"), "React Router", 0 },
                    { new Guid("3b9e203e-cd34-404e-8bdd-942897c94fba"), ".NET CORE 6", 1 },
                    { new Guid("44460f48-b515-47ca-ad37-3f36f50c6bf4"), ".NET API", 1 },
                    { new Guid("4866ba30-45fd-482b-8c55-750b8f08a9a3"), ".NET WPF", 1 },
                    { new Guid("4aedfdd4-3186-42a7-873a-f874d26dc705"), "REST API", 2 },
                    { new Guid("5a8761a7-672e-4a9a-838b-5e5760e5fe86"), "Java Spring", 1 },
                    { new Guid("65476b02-4a91-4413-a878-a608b84fb1c7"), "Entity Framework", 1 },
                    { new Guid("6766e706-95f1-4a5a-bb88-9666b4688ed8"), "C#", 1 },
                    { new Guid("6ad111ed-fdce-4f64-a391-f4c8f58fcc4b"), "MySql", 1 },
                    { new Guid("74b92a1b-653a-40d9-9ab2-cea21bfe2b98"), "Scrum", 2 },
                    { new Guid("882c211a-f041-4266-bea8-79ad1e444c65"), "React", 0 },
                    { new Guid("8f4829c1-abaf-4b7b-85b0-1b63df652039"), "Vitest", 0 },
                    { new Guid("ab988062-44c6-46ed-91fb-f7133235b287"), "Linux", 2 },
                    { new Guid("b77ba9c1-d0b4-43ff-8f2f-388bc6b6f619"), "MS SQL Server", 1 },
                    { new Guid("b8601e35-050b-43d5-95dd-e7329e40dd9b"), "Java", 1 },
                    { new Guid("b9c7d499-6f03-47c0-a1dd-ed227002f7c6"), "Python", 1 },
                    { new Guid("cc3573d8-5ce9-4d54-957c-228f8d664620"), "TailwindCss", 0 },
                    { new Guid("d12f5371-3188-4093-92fe-f8e0cce79f08"), "UML", 2 },
                    { new Guid("da28b598-6c13-493e-9604-fcc5a2a0adf1"), "Migrations", 1 },
                    { new Guid("dc3f6090-61ad-4787-a069-083854970e3c"), "Angular", 0 },
                    { new Guid("df8c09ea-0b8d-4208-bf10-af33f6f246a5"), "HTML", 0 },
                    { new Guid("e5040d11-511b-4ad8-8122-e32184eb250f"), "Redux Toolkit", 0 },
                    { new Guid("ec8ae4d4-547d-478f-8165-0ab836c05517"), "TypeScript", 0 },
                    { new Guid("ed5db99f-9ee7-47b0-837a-4228b0ef455f"), "ERD / DER", 2 }
                });

            migrationBuilder.InsertData(
                table: "SocialMedia",
                columns: new[] { "Id", "IconClassName", "Name" },
                values: new object[,]
                {
                    { new Guid("2b941890-c242-40a0-8edc-d26df41674cb"), "bi bi-linkedin", "LinkedIn" },
                    { new Guid("47e58a44-637c-474e-8d65-7e2a835060ee"), "bi bi-facebook", "Facebook" },
                    { new Guid("4aba67d9-43c6-4131-a387-753f4e714691"), "bi bi-instagram", "Instagram" },
                    { new Guid("ac62a1f7-d350-40f2-8bc1-4b42bfdbe1ff"), "bi bi-person-circle", "Web Personal" },
                    { new Guid("c2215325-6e09-47be-a73a-ffca4bbc7dff"), "bi bi-github", "Github" },
                    { new Guid("d69938a6-6ac2-4562-8378-1bca0723fe81"), "bi bi-twitter", "Twitter" },
                    { new Guid("f18ac089-567b-4535-8149-32a5cfa48bd5"), "bi bi-whatsapp", "Whatsapp" }
                });

            migrationBuilder.InsertData(
                table: "SocialMedia",
                columns: new[] { "Id", "IconClassName", "Name" },
                values: new object[] { new Guid("fbb84a48-7496-4b4c-bed3-e3416203f844"), "bi bi-youtube", "Youtube" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "Email", "EnglishAboutMe", "EnglishDesc", "HasEnglishAboutMe", "HasEnglishDesc", "IsEnglishModeEnabled", "LocationCountry", "LocationState", "Name", "NativeAboutMe", "NativeDesc", "Password", "Phone", "Role", "Status", "Username" },
                values: new object[] { new Guid("0ddb19ca-da35-46a5-b267-f15ec3d11623"), new DateTime(2023, 1, 25, 14, 18, 39, 247, DateTimeKind.Local).AddTicks(6399), "tiagoramirez2001@gmail.com", "Fullstack Dev. with 1 year of experience in the IT area. My main stack: React + .NET 6 API + SQL Server + Node", "FullStack Dev. || React + .NET 6 + SQL Server + Node || Student in Systems Engineering - UTN (Argentina)", true, true, true, "Argentina", "Chaco", "Tiago Alberto Ramirez Marchisio", "Fullstack Dev. con 1 año de experiencia en el área de TI. Mi stack principal: React + .NET 6 API + SQL Server + Node", "FullStack Dev. || React + .NET 6 + SQL Server + Node || Ingeniería en Sistemas de Información - UTN (Argentina)", "9d1b8cbb1b368f7595dc0ec177a9415f1666beeb3bd3079b135559e58d523563499a1dc93eac521903b5bba6fc9fa63c01aab0a3037bc6af61c0c16c09fc2e74", null, "USR", true, "tiagoramirez" });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "End", "EnglishDesc", "HasEnglishDesc", "Institute", "IsActual", "NativeDesc", "Start", "TitleName", "Type", "UserId" },
                values: new object[] { new Guid("226e9ebd-0a5b-49b8-83a9-40d72e6e165d"), null, "3rd year with an average of 9/10", true, "Universidad Tecnologica Nacional", true, "Me encuentro en 3ro con un promedio de 9/10", new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ingenieria en Sistemas de Informacion", 1, new Guid("0ddb19ca-da35-46a5-b267-f15ec3d11623") });

            migrationBuilder.InsertData(
                table: "Experience",
                columns: new[] { "Id", "Company", "End", "EnglishDesc", "HasEnglishDesc", "IsActual", "NativeDesc", "Position", "Start", "Type", "UserId" },
                values: new object[] { new Guid("321f1b90-5cc1-45fe-b184-14c52c15e356"), "Accusys", null, "Management and optimization of queries, tables, stored procedures and views in MS SQL Server databases. I work with technologies such as WPF, Classic ASP, VBS, HTML, Javascript, Java and IIS", true, true, "Manejo y optimización de querys, tables, stored procedures y views en bases de datos MS SQL Server. Trabajo con tecnologías tales como WPF, ASP Clásico, VBS, HTML, Javascript, Java y IIS", "Analista Programador Junior", new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("0ddb19ca-da35-46a5-b267-f15ec3d11623") });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "EnglishDesc", "HasEnglishDesc", "Name", "NativeDesc", "Url", "UserId" },
                values: new object[] { new Guid("4924ae1d-c1e1-4648-b090-67a2d5babae8"), "Personal portfolio made with REACT + .NET 6 + SQL Server", true, "Portfolio", "Portfolio personal realizado con REACT + .NET 6 + SQL Server", "https://www.github.com/tiagoramirez", new Guid("0ddb19ca-da35-46a5-b267-f15ec3d11623") });

            migrationBuilder.InsertData(
                table: "User_Skill",
                columns: new[] { "Id", "Percentage", "SkillId", "UserId" },
                values: new object[] { new Guid("33b0765b-d4aa-4069-8804-63010c512db9"), 90, new Guid("6766e706-95f1-4a5a-bb88-9666b4688ed8"), new Guid("0ddb19ca-da35-46a5-b267-f15ec3d11623") });

            migrationBuilder.InsertData(
                table: "User_SocialMedia",
                columns: new[] { "Id", "SocialMediaId", "Url", "UserId" },
                values: new object[] { new Guid("d2df9f5b-0010-4284-aa68-24a5d3f6c39d"), new Guid("2b941890-c242-40a0-8edc-d26df41674cb"), "https://www.linkedin.com/in/tiagoramirezmar/", new Guid("0ddb19ca-da35-46a5-b267-f15ec3d11623") });

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
