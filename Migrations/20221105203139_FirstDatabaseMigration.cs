using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace portfolio.Migrations
{
    public partial class FirstDatabaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProfileConfig",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShowPhoto = table.Column<bool>(type: "bit", nullable: false),
                    ShowBanner = table.Column<bool>(type: "bit", nullable: false),
                    ShowLocation = table.Column<bool>(type: "bit", nullable: false),
                    ShowPhone = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileConfig", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

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
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    End = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    End = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                name: "Profile",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfileConfigId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    LocationState = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LocationCountry = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AboutMe = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profile_ProfileConfig_ProfileConfigId",
                        column: x => x.ProfileConfigId,
                        principalTable: "ProfileConfig",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Profile_User_UserId",
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
                    Url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
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
                name: "User_Role",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Role", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Role_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Role_User_UserId",
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

            migrationBuilder.CreateTable(
                name: "Education_Description",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EducationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education_Description", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Education_Description_Education_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Education",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Education_Description_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experience_Description",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExperienceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experience_Description", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experience_Description_Experience_ExperienceId",
                        column: x => x.ExperienceId,
                        principalTable: "Experience",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Experience_Description_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Project_Description",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project_Description", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Project_Description_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Project_Description_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "ProfileConfig",
                columns: new[] { "Id", "ProfileId", "ShowBanner", "ShowLocation", "ShowPhone", "ShowPhoto" },
                values: new object[] { new Guid("bdb6e2ce-da11-4d98-bbca-ef8908d64c5c"), new Guid("a0a12631-8100-461a-a899-317b8befab32"), true, true, true, true });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { new Guid("b022bf32-80bc-420c-afaa-1d19d698d265"), "User" },
                    { new Guid("e4476cc3-bee6-4d16-a693-9b07571562d3"), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "Id", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("1cb5222f-662e-4872-ac0f-97cd6c33c1d1"), "Entity Framework", 1 },
                    { new Guid("240a322f-a03a-4c50-ae8e-7d718ae75c89"), "React", 0 },
                    { new Guid("29d374f2-6767-428f-ba99-8eb82a621567"), "TypeScript", 1 },
                    { new Guid("302f56b3-1e5c-46be-83d9-40c8452acb4e"), "C#", 1 },
                    { new Guid("350cd918-5cb2-43e3-a46c-dc9545a8ecc2"), "Scrum", 2 },
                    { new Guid("3c4706c3-93a8-47fc-9494-582715a91fbe"), ".NET", 1 },
                    { new Guid("42712e8d-6b8e-45ef-ac26-3715a03fbffe"), "UML", 2 },
                    { new Guid("483504cd-ae60-4202-b650-a2e2c2e677d6"), "Bootstrap", 0 },
                    { new Guid("53a11c6d-4d99-4ff9-b929-f25823c77ee5"), "MS SQL Server", 1 },
                    { new Guid("59bed9bc-1fc4-48ce-810f-4b3d1a500ccd"), "SQL", 1 },
                    { new Guid("6271de2b-d86a-478f-a197-8cc5ae88e80a"), "JavaScript", 1 },
                    { new Guid("641b2819-d127-4937-beaf-c47e41aaf9d2"), "JWT", 2 },
                    { new Guid("7577131d-3c6f-4dfe-b141-459d9f0a1d5b"), "Java Spring", 1 },
                    { new Guid("7fd68f22-5269-47c9-8d54-8bd04cee5876"), ".NET WPF", 1 },
                    { new Guid("814824ac-7ddf-41c4-b999-421e458a6d66"), "MySql", 1 },
                    { new Guid("937df4ec-e0c8-488a-b99c-de58fb783e08"), "JavaScript", 0 },
                    { new Guid("a22cce13-3a6a-44ca-be77-f3bb48992043"), "Python", 1 },
                    { new Guid("af14652c-925c-4130-8664-d341d1048bf7"), "TypeScript", 0 },
                    { new Guid("b0efdce6-be60-4c30-ac81-2436ce690868"), "CSS", 0 },
                    { new Guid("b5ee8a8e-c7ed-45cd-8115-3e2ef6b3c711"), "Linux", 2 },
                    { new Guid("b8b2012f-aae4-4df9-b679-54133b7a2c57"), "HTML", 0 },
                    { new Guid("cdfaae3a-c1ef-47df-924c-a78fda04fa9e"), "Angular", 0 },
                    { new Guid("d5e64e12-5157-4478-98d6-47f8c3f84260"), "Git", 2 },
                    { new Guid("d7df352e-1ea0-4b0b-a358-b9e0284c4148"), "ERD / DER", 2 },
                    { new Guid("f23cafc1-fadc-4a17-b140-fcd5fae845c4"), "Java", 1 }
                });

            migrationBuilder.InsertData(
                table: "SocialMedia",
                columns: new[] { "Id", "IconClassName", "Name" },
                values: new object[,]
                {
                    { new Guid("0b393e67-1963-4e29-98e0-8e964d71e35f"), "bi bi-youtube", "Youtube" },
                    { new Guid("0c24eb93-87d7-44e6-864b-3d6972c31207"), "bi bi-github", "Github" },
                    { new Guid("1640b025-e825-4a42-8f26-eaf7fb8846bc"), "bi bi-person-circle", "Web Personal" },
                    { new Guid("30fc334d-171b-4c32-839b-5ec821206918"), "bi bi-twitter", "Twitter" },
                    { new Guid("42fe74e3-93c7-4066-b56f-4d3c29afdad8"), "bi bi-instagram", "Instagram" },
                    { new Guid("44431256-3806-4e57-b5bd-6f44bc9fa373"), "bi bi-facebook", "Facebook" },
                    { new Guid("7dc7c297-ee06-4c45-bb23-233a8bab6dc5"), "bi bi-linkedin", "LinkedIn" },
                    { new Guid("f047df25-d206-4e5d-ab0d-a3de39b13885"), "bi bi-whatsapp", "Whatsapp" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "Email", "Name", "Password", "Status", "Username" },
                values: new object[] { new Guid("3f3a9ce6-d6ad-475b-9aac-eda285e24043"), new DateTime(2022, 11, 5, 17, 31, 39, 99, DateTimeKind.Local).AddTicks(811), "tiagoramirez2001@gmail.com", "Tiago Alberto Ramirez Marchisio", "9d1b8cbb1b368f7595dc0ec177a9415f1666beeb3bd3079b135559e58d523563499a1dc93eac521903b5bba6fc9fa63c01aab0a3037bc6af61c0c16c09fc2e74", true, "tiagoramirez" });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "End", "Institute", "IsActual", "Start", "TitleName", "Type", "UserId" },
                values: new object[] { new Guid("b8f98496-02c6-40a1-9170-e11cf13895f3"), null, "Universidad Tecnologica Nacional", true, new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ingenieria en Sistemas de Informacion", 1, new Guid("3f3a9ce6-d6ad-475b-9aac-eda285e24043") });

            migrationBuilder.InsertData(
                table: "Experience",
                columns: new[] { "Id", "Company", "End", "IsActual", "Position", "Start", "Type", "UserId" },
                values: new object[] { new Guid("d9b2058b-604d-4b92-b9f9-8d1712034eb7"), "Accusys", null, true, "Analista Programador Junior", new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("3f3a9ce6-d6ad-475b-9aac-eda285e24043") });

            migrationBuilder.InsertData(
                table: "Profile",
                columns: new[] { "Id", "AboutMe", "Description", "LocationCountry", "LocationState", "Phone", "ProfileConfigId", "UserId" },
                values: new object[] { new Guid("a0a12631-8100-461a-a899-317b8befab32"), "Soy estudiante y programador. No se que mas poner salu2", "FullStack Developer || .NET + ANGULAR + SQL SERVER || Estudiante Ingeniería en Sistemas de Información en UTN", "Argentina", "Capital Federal", null, new Guid("bdb6e2ce-da11-4d98-bbca-ef8908d64c5c"), new Guid("3f3a9ce6-d6ad-475b-9aac-eda285e24043") });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "Name", "Url", "UserId" },
                values: new object[] { new Guid("55dd3f35-1054-4d79-a3f5-fe4233a6dadb"), "Portfolio", "https://www.google.com/", new Guid("3f3a9ce6-d6ad-475b-9aac-eda285e24043") });

            migrationBuilder.InsertData(
                table: "User_Role",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[] { new Guid("2e6aa0f3-3850-4475-a208-255b44d8b869"), new Guid("b022bf32-80bc-420c-afaa-1d19d698d265"), new Guid("3f3a9ce6-d6ad-475b-9aac-eda285e24043") });

            migrationBuilder.InsertData(
                table: "User_Skill",
                columns: new[] { "Id", "Percentage", "SkillId", "UserId" },
                values: new object[] { new Guid("dc9fccce-5f16-43c4-ac03-fa07d3f4e4ee"), 90, new Guid("302f56b3-1e5c-46be-83d9-40c8452acb4e"), new Guid("3f3a9ce6-d6ad-475b-9aac-eda285e24043") });

            migrationBuilder.InsertData(
                table: "User_SocialMedia",
                columns: new[] { "Id", "SocialMediaId", "Url", "UserId" },
                values: new object[] { new Guid("0db0d442-a207-4c4c-b1d5-c57f996b9253"), new Guid("7dc7c297-ee06-4c45-bb23-233a8bab6dc5"), "https://www.linkedin.com/in/tiagoramirezmar/", new Guid("3f3a9ce6-d6ad-475b-9aac-eda285e24043") });

            migrationBuilder.InsertData(
                table: "Education_Description",
                columns: new[] { "Id", "Description", "EducationId", "ProfileId" },
                values: new object[] { new Guid("c700f39a-3601-42a2-a3fc-9a8e33a89dc3"), "No se que poner aca", new Guid("b8f98496-02c6-40a1-9170-e11cf13895f3"), new Guid("a0a12631-8100-461a-a899-317b8befab32") });

            migrationBuilder.InsertData(
                table: "Experience_Description",
                columns: new[] { "Id", "Description", "ExperienceId", "ProfileId" },
                values: new object[] { new Guid("c5de045d-4fd9-4d06-b3e1-98fb54266ab5"), "No se que poner aca 2", new Guid("d9b2058b-604d-4b92-b9f9-8d1712034eb7"), new Guid("a0a12631-8100-461a-a899-317b8befab32") });

            migrationBuilder.InsertData(
                table: "Project_Description",
                columns: new[] { "Id", "Description", "ProfileId", "ProjectId" },
                values: new object[] { new Guid("d81ba0f0-3c8d-44e9-81ba-86531ee21ae3"), "No se que poner aca 3", new Guid("a0a12631-8100-461a-a899-317b8befab32"), new Guid("55dd3f35-1054-4d79-a3f5-fe4233a6dadb") });

            migrationBuilder.CreateIndex(
                name: "IX_Education_UserId",
                table: "Education",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Education_Description_EducationId",
                table: "Education_Description",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Education_Description_ProfileId",
                table: "Education_Description",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Experience_UserId",
                table: "Experience",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Experience_Description_ExperienceId",
                table: "Experience_Description",
                column: "ExperienceId");

            migrationBuilder.CreateIndex(
                name: "IX_Experience_Description_ProfileId",
                table: "Experience_Description",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Profile_ProfileConfigId",
                table: "Profile",
                column: "ProfileConfigId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Profile_UserId",
                table: "Profile",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_UserId",
                table: "Project",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_Description_ProfileId",
                table: "Project_Description",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_Description_ProjectId",
                table: "Project_Description",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Role_RoleId",
                table: "User_Role",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Role_UserId",
                table: "User_Role",
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
                name: "Education_Description");

            migrationBuilder.DropTable(
                name: "Experience_Description");

            migrationBuilder.DropTable(
                name: "Project_Description");

            migrationBuilder.DropTable(
                name: "User_Role");

            migrationBuilder.DropTable(
                name: "User_Skill");

            migrationBuilder.DropTable(
                name: "User_SocialMedia");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "Experience");

            migrationBuilder.DropTable(
                name: "Profile");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "SocialMedia");

            migrationBuilder.DropTable(
                name: "ProfileConfig");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
