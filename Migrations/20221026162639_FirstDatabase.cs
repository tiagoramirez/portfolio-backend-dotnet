using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace portfolio.Migrations
{
    public partial class FirstDatabase : Migration
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
                    Type = table.Column<int>(type: "int", nullable: false),
                    Institute = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TitleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    AboutMe = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                table: "Role",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { new Guid("2457aef0-6723-4636-bb39-9867426cf08f"), "Admin" },
                    { new Guid("d8de9611-dbb4-40e9-b0c2-dac1be12efce"), "User" }
                });

            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "Id", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("00557300-07e0-4910-a68c-d0456a59b774"), "Git", 2 },
                    { new Guid("05b622b6-a300-4cab-8ea7-58ce49587556"), "Linux", 2 },
                    { new Guid("096173a6-0664-47ba-b606-fadfbe585e52"), "MS SQL Server", 1 },
                    { new Guid("0b2dda01-f97f-421e-922c-bb92c751f8e2"), "Angular", 0 },
                    { new Guid("1fef43f8-acc2-47f7-8da5-b9d4f4857677"), "Scrum", 2 },
                    { new Guid("25ff7bc5-65fb-4ad8-b3f5-dbdecb90b406"), "HTML", 0 },
                    { new Guid("29be8168-3052-48d9-abe7-f3e1714ce6c1"), "ERD / DER", 2 },
                    { new Guid("33371bbc-3ac6-479e-a2f2-b3a70dd4ccb1"), "React", 0 },
                    { new Guid("494b6871-75ec-40da-8e0f-e83023b7bb41"), "UML", 2 },
                    { new Guid("65544614-4fae-4c61-bbd5-68f1a8be68ae"), "Java Spring", 1 },
                    { new Guid("6713afc4-9a32-433f-8cda-904c2cf6a102"), "Entity Framework", 1 },
                    { new Guid("6cd6f08c-dba8-437a-b614-ab7847c55fc1"), "TypeScript", 1 },
                    { new Guid("7eafd4a2-13ff-48cf-bcf8-6a19f18eb52e"), "Python", 1 },
                    { new Guid("7f15fb65-7daf-49cd-89e1-af50bca655fd"), "Java", 1 },
                    { new Guid("9366e95f-b34c-4f22-8cf3-562ec9eb1ec8"), ".NET", 1 },
                    { new Guid("98352d16-ac24-4333-95f6-7c8b20af0433"), "MySql", 1 },
                    { new Guid("9981420e-38d5-4753-90db-8e7a08108498"), "C#", 1 },
                    { new Guid("a1b1a919-2c2c-47c2-ba71-941cb987f1b2"), "JavaScript", 0 },
                    { new Guid("a5b33aef-8fb1-4d78-9729-095ec5b9cc24"), "CSS", 0 },
                    { new Guid("ab65021b-2f41-43a8-9bb6-c322cd09b611"), "SQL", 1 },
                    { new Guid("bf54c219-3871-47d8-aa30-88bf866b9d72"), "JWT", 2 },
                    { new Guid("dd05f7f4-637d-4e68-a466-925e60639d75"), "Bootstrap", 0 },
                    { new Guid("ded0cbb6-5b64-416c-9da4-c4989ad287a7"), "JavaScript", 1 },
                    { new Guid("f18ad434-b8a8-46d0-bf2c-12be824b3b3e"), "TypeScript", 0 },
                    { new Guid("fda68e16-516e-4be4-bf6e-2ac2506ed4e0"), ".NET WPF", 1 }
                });

            migrationBuilder.InsertData(
                table: "SocialMedia",
                columns: new[] { "Id", "IconClassName", "Name" },
                values: new object[,]
                {
                    { new Guid("3df48fad-124d-4a7c-94af-34e732bdcaff"), "bi bi-facebook", "Facebook" },
                    { new Guid("66948bab-38df-4cfb-b018-1e7f92c83928"), "bi bi-twitter", "Twitter" },
                    { new Guid("6b61b04c-028a-4c1e-92b3-79eededbaf8f"), "bi bi-github", "Github" },
                    { new Guid("7f36414c-063c-44e8-a256-5059d0dfa0e8"), "bi bi-youtube", "Youtube" },
                    { new Guid("8614df10-114f-4615-9727-050fb0739e91"), "bi bi-person-circle", "Web Personal" },
                    { new Guid("a1f17d1e-04c5-4dd5-986b-73f496f1646c"), "bi bi-instagram", "Instagram" },
                    { new Guid("e3d43a97-b73a-42c1-96ee-e213df1fb40b"), "bi bi-linkedin", "LinkedIn" },
                    { new Guid("e479b021-352e-4398-bc73-508be1de0144"), "bi bi-whatsapp", "Whatsapp" }
                });

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
