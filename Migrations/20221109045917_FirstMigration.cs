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
                    Role = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
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
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    LocationState = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LocationCountry = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AboutMe = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ShowPhoto = table.Column<bool>(type: "bit", nullable: false),
                    ShowBanner = table.Column<bool>(type: "bit", nullable: false),
                    ShowLocation = table.Column<bool>(type: "bit", nullable: false),
                    ShowPhone = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.Id);
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
                table: "Skill",
                columns: new[] { "Id", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("18a95593-b682-4fee-be54-f1d09d238cad"), "React", 0 },
                    { new Guid("262fbd07-0eda-45bc-94df-b6d4f817455a"), "SQL", 1 },
                    { new Guid("293d7f9c-e690-46b0-b395-1a6e78565b59"), "Linux", 2 },
                    { new Guid("2cc5017f-1791-442e-b696-a8609b6945f8"), "Java Spring", 1 },
                    { new Guid("36c25853-003e-4b6d-ba87-1c02b8f0d1ff"), "JavaScript", 1 },
                    { new Guid("3768c235-8b65-4979-8c22-f6cb3f6e5c99"), "Bootstrap", 0 },
                    { new Guid("38e468b1-f0f2-4b9b-bd11-36d7ab8a9f26"), "TypeScript", 1 },
                    { new Guid("3e667d06-810a-481d-8a8f-0dc8decc71be"), "Git", 2 },
                    { new Guid("3f89db3e-4a3d-4e26-b2d7-af1ca9f21ed6"), "Angular", 0 },
                    { new Guid("49e693ad-5f1a-4b46-9c16-ebf6ae802bc3"), "Entity Framework", 1 },
                    { new Guid("4bf709e4-0943-4795-a556-efd213040dfa"), "Java", 1 },
                    { new Guid("584d9d09-9774-4cbf-8976-48235a1319fc"), "UML", 2 },
                    { new Guid("636ceeec-2e41-4d5c-9c24-ff0cc49e9fa9"), ".NET WPF", 1 },
                    { new Guid("6f0a7575-5c61-4cfc-86f2-6b5a9e0395a0"), "JavaScript", 0 },
                    { new Guid("7588dc0b-ca85-40e2-9aaf-fa194abb2136"), "CSS", 0 },
                    { new Guid("7c50337b-0123-4817-9296-993d6b487942"), "MS SQL Server", 1 },
                    { new Guid("9f7c8d04-4d3f-4178-a1e1-7d5117b99fe4"), "Python", 1 },
                    { new Guid("aa1792bd-8d18-4fb6-ac60-0de7194dea6e"), "JWT", 2 },
                    { new Guid("aa1ff9a7-5a49-4c35-b144-d3a9001f5fab"), "HTML", 0 },
                    { new Guid("c0effba8-3cbf-4e07-891e-64266b379a6b"), "Scrum", 2 },
                    { new Guid("d6626385-f711-4fd8-b15d-47621d82631b"), "ERD / DER", 2 },
                    { new Guid("ddc485a0-40f9-4eda-9374-abf5fe8d2f23"), "C#", 1 },
                    { new Guid("f2c17292-0918-460b-b4f8-c112d1a7cda8"), "TypeScript", 0 },
                    { new Guid("f4545c94-5789-46a9-b56f-eb8ff454d9ff"), "MySql", 1 },
                    { new Guid("fd806ee9-17d8-4a34-9f13-0bc96abb0988"), ".NET", 1 }
                });

            migrationBuilder.InsertData(
                table: "SocialMedia",
                columns: new[] { "Id", "IconClassName", "Name" },
                values: new object[,]
                {
                    { new Guid("2c45ad9d-e004-4794-95e6-12ad2ec8f137"), "bi bi-whatsapp", "Whatsapp" },
                    { new Guid("3a7cf925-a986-402f-b071-9af97c4675ba"), "bi bi-facebook", "Facebook" },
                    { new Guid("630b7386-3277-40cd-a351-2455518fb75f"), "bi bi-github", "Github" },
                    { new Guid("637cea0e-f422-46d7-aae5-833b7d896982"), "bi bi-youtube", "Youtube" },
                    { new Guid("6c5a5e1a-a263-47ef-845e-cee98ee0106a"), "bi bi-twitter", "Twitter" },
                    { new Guid("8d699d15-fffd-482b-a961-9da20435bdaf"), "bi bi-instagram", "Instagram" },
                    { new Guid("c1e31298-5fc3-464d-b3ff-38bb8f672ce2"), "bi bi-person-circle", "Web Personal" },
                    { new Guid("f235ed99-b649-407a-8b4a-1b5bf9c397ee"), "bi bi-linkedin", "LinkedIn" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "Email", "Name", "Password", "Role", "Status", "Username" },
                values: new object[] { new Guid("179bddbd-ce7b-4557-94d4-99a420b23e4b"), new DateTime(2022, 11, 9, 1, 59, 17, 128, DateTimeKind.Local).AddTicks(5327), "tiagoramirez2001@gmail.com", "Tiago Alberto Ramirez Marchisio", "9d1b8cbb1b368f7595dc0ec177a9415f1666beeb3bd3079b135559e58d523563499a1dc93eac521903b5bba6fc9fa63c01aab0a3037bc6af61c0c16c09fc2e74", "USR", true, "tiagoramirez" });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "End", "Institute", "IsActual", "Start", "TitleName", "Type", "UserId" },
                values: new object[] { new Guid("012573c5-95d7-477c-b6bc-65aa33eed87b"), null, "Universidad Tecnologica Nacional", true, new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ingenieria en Sistemas de Informacion", 1, new Guid("179bddbd-ce7b-4557-94d4-99a420b23e4b") });

            migrationBuilder.InsertData(
                table: "Experience",
                columns: new[] { "Id", "Company", "End", "IsActual", "Position", "Start", "Type", "UserId" },
                values: new object[] { new Guid("2e1f8b91-8240-49eb-953f-34ac20d08feb"), "Accusys", null, true, "Analista Programador Junior", new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("179bddbd-ce7b-4557-94d4-99a420b23e4b") });

            migrationBuilder.InsertData(
                table: "Profile",
                columns: new[] { "Id", "AboutMe", "Description", "LocationCountry", "LocationState", "Phone", "ShowBanner", "ShowLocation", "ShowPhone", "ShowPhoto", "UserId" },
                values: new object[] { new Guid("341e92cd-1b0f-4361-8773-4a2c1b13c8cf"), "Soy estudiante y programador. No se que mas poner salu2", "FullStack Developer || .NET + ANGULAR + SQL SERVER || Estudiante Ingeniería en Sistemas de Información en UTN", "Argentina", "Capital Federal", null, false, true, true, false, new Guid("179bddbd-ce7b-4557-94d4-99a420b23e4b") });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "Name", "Url", "UserId" },
                values: new object[] { new Guid("3cf4ab06-4291-4480-87b5-bc9690e9dbff"), "Portfolio", "https://www.google.com/", new Guid("179bddbd-ce7b-4557-94d4-99a420b23e4b") });

            migrationBuilder.InsertData(
                table: "User_Skill",
                columns: new[] { "Id", "Percentage", "SkillId", "UserId" },
                values: new object[] { new Guid("60cf3cd7-2136-4955-9dfd-48e7cef6f322"), 90, new Guid("ddc485a0-40f9-4eda-9374-abf5fe8d2f23"), new Guid("179bddbd-ce7b-4557-94d4-99a420b23e4b") });

            migrationBuilder.InsertData(
                table: "User_SocialMedia",
                columns: new[] { "Id", "SocialMediaId", "Url", "UserId" },
                values: new object[] { new Guid("b5379019-b458-4c5d-8b26-507c750c73e5"), new Guid("f235ed99-b649-407a-8b4a-1b5bf9c397ee"), "https://www.linkedin.com/in/tiagoramirezmar/", new Guid("179bddbd-ce7b-4557-94d4-99a420b23e4b") });

            migrationBuilder.InsertData(
                table: "Education_Description",
                columns: new[] { "Id", "Description", "EducationId", "ProfileId" },
                values: new object[] { new Guid("34d07f34-8d5b-498d-a476-4009caec806f"), "No se que poner aca", new Guid("012573c5-95d7-477c-b6bc-65aa33eed87b"), new Guid("341e92cd-1b0f-4361-8773-4a2c1b13c8cf") });

            migrationBuilder.InsertData(
                table: "Experience_Description",
                columns: new[] { "Id", "Description", "ExperienceId", "ProfileId" },
                values: new object[] { new Guid("463f14e1-6269-4564-8bb7-35557b728d1e"), "No se que poner aca 2", new Guid("2e1f8b91-8240-49eb-953f-34ac20d08feb"), new Guid("341e92cd-1b0f-4361-8773-4a2c1b13c8cf") });

            migrationBuilder.InsertData(
                table: "Project_Description",
                columns: new[] { "Id", "Description", "ProfileId", "ProjectId" },
                values: new object[] { new Guid("11b73830-fde5-4e71-863a-ff00e3cafea7"), "No se que poner aca 3", new Guid("341e92cd-1b0f-4361-8773-4a2c1b13c8cf"), new Guid("3cf4ab06-4291-4480-87b5-bc9690e9dbff") });

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
                name: "Skill");

            migrationBuilder.DropTable(
                name: "SocialMedia");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
