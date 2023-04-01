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
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsEnglishModeEnabled = table.Column<bool>(type: "bit", nullable: false),
                    NativeDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    HasEnglishDesc = table.Column<bool>(type: "bit", nullable: false),
                    EnglishDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
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
                name: "SocialMedia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Name = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocialMedia_User_UserId",
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

            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "Id", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("03badd18-142e-4ee1-8767-cfae38f1e8ea"), "Redux Toolkit", 0 },
                    { new Guid("06d85e3f-7305-44d2-9315-c1f99afb2b9c"), "Angular", 0 },
                    { new Guid("08167ec6-d30c-40a6-92d7-eb06113cf940"), "SQL", 1 },
                    { new Guid("09931a46-4f03-41ad-8494-a265f3c8754b"), ".NET WPF", 1 },
                    { new Guid("09e8b0dd-57e7-4054-8ffe-5b5a8af74ae4"), "React Router", 0 },
                    { new Guid("0a8e5f19-29e3-4f7b-b15e-79e0ef1e9e7b"), "Java", 1 },
                    { new Guid("0eef2041-ee33-4b3a-b93c-10fd257b527b"), "Scrum", 2 },
                    { new Guid("1f7dcb2c-0979-488c-b739-6913e86b5c99"), "MySql", 1 },
                    { new Guid("2bd96cc9-4cf9-459c-bea0-4eebbe2153ee"), "TypeScript", 0 },
                    { new Guid("2ca561c9-ef16-499b-bfe2-09b7e86792f2"), ".NET CORE 6", 1 },
                    { new Guid("33b99740-936e-40df-8e9a-aec0f686b702"), "Vite", 0 },
                    { new Guid("3b020f36-d959-4304-8be9-a0ad92105335"), "C#", 1 },
                    { new Guid("3e51e2b6-4f44-4341-91cb-c3150f3dfb12"), "CSS", 0 },
                    { new Guid("42f90172-c0e5-4a55-9ab1-ce63e5bc8803"), "Git", 2 },
                    { new Guid("4870b24a-8e82-47ee-93af-c88d3cd01238"), "REST API", 2 },
                    { new Guid("4d87ee36-7c36-4343-b135-e7852f2ff76e"), "TailwindCss", 0 },
                    { new Guid("57e18b6c-8f53-448f-ae72-1770e7d7a70a"), "Vitest", 0 },
                    { new Guid("62c8f993-8688-46cb-8ebb-7c4964af4d72"), "Node", 2 },
                    { new Guid("6d01c24c-2643-4b50-9afd-451248f665ca"), "HTML", 0 },
                    { new Guid("731ebb23-0cee-4f4a-a53f-dbe94823b993"), "Middlewares", 1 },
                    { new Guid("9539e24c-eb3b-4e4c-a13e-c517ea36e7be"), "JWT", 2 },
                    { new Guid("965d9fd5-0ffa-4150-8188-d9fe21117f8b"), "Fluent API", 1 },
                    { new Guid("a4743361-bdf0-4df2-9f65-4dee215bb433"), "Bootstrap", 0 },
                    { new Guid("abf491de-913d-46d4-a30a-b3a55eebc952"), "React", 0 },
                    { new Guid("ad4e69fe-9d22-4738-bb92-24e11f1d870e"), "ERD / DER", 2 },
                    { new Guid("b233ec82-3ffb-45f6-8fb3-338d583f5ac7"), "Linux", 2 },
                    { new Guid("cc3b831f-097a-4be0-8ccb-d1913fcb3961"), "Testing library", 0 },
                    { new Guid("d73abf96-3c66-45ff-a651-304ef12147bc"), ".NET API", 1 },
                    { new Guid("e6928cbd-a13f-4041-a4bb-1b729ced8238"), "Migrations", 1 },
                    { new Guid("e87dba1f-4ae1-4831-8e84-76af479379c8"), "Entity Framework", 1 },
                    { new Guid("f16d09ba-acb0-4f19-ada1-d10d84a77fbd"), "Java Spring", 1 },
                    { new Guid("f4a01dab-8aa4-4780-bd6e-4638b3ff7e19"), "MS SQL Server", 1 },
                    { new Guid("f771aa1b-8ee9-44e4-b71e-e4436d819997"), "UML", 2 },
                    { new Guid("fa1dd71f-4546-491d-919b-dd6deb895e0f"), "JavaScript", 0 },
                    { new Guid("fca0e724-edb4-4f26-90f1-9b9aabf916b2"), "Python", 1 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "Email", "EnglishAboutMe", "EnglishDesc", "HasEnglishAboutMe", "HasEnglishDesc", "IsEnglishModeEnabled", "LocationCountry", "LocationState", "Name", "NativeAboutMe", "NativeDesc", "Status", "Username" },
                values: new object[] { "p7EW1FzwW5hgFi4YTV1mmdHTAnm1", new DateTime(2023, 4, 1, 0, 10, 9, 967, DateTimeKind.Local).AddTicks(5713), "tiagoramirez2001@gmail.com", "Fullstack Web Dev. with 1 year of experience in the IT area. My main stack: React + Typescript + .NET 6 API + SQL Server + Node", "FullStack Web Dev. with +1yr exp. || React + Typescript + .NET 6 + SQL Server + Node || Student in Systems Engineering - UTN (Argentina)", true, true, true, "Argentina", "C.A.B.A.", "Tiago Alberto Ramirez Marchisio", "Fullstack Web Dev. con 1 año de experiencia en el área de TI. Mi stack principal: React + Typescript + .NET 6 API + SQL Server + Node", "FullStack Web Dev. con +1 año de exp. || React + Typescript + .NET 6 + SQL Server + Node || Ingeniería en Sistemas de Información - UTN (Argentina)", true, "tiagoramirez" });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "End", "EnglishDesc", "HasEnglishDesc", "Institute", "IsActual", "NativeDesc", "Start", "TitleName", "Type", "UserId" },
                values: new object[] { new Guid("bf047994-d546-48b1-9d0a-b6034aa50898"), null, "Currently at 3rd year with an average of 9/10", true, "Universidad Tecnologica Nacional", true, "Me encuentro en 3er año con un promedio de 9/10", new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ingenieria en Sistemas de Informacion", 1, "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" });

            migrationBuilder.InsertData(
                table: "Experience",
                columns: new[] { "Id", "Company", "End", "EnglishDesc", "HasEnglishDesc", "IsActual", "NativeDesc", "Position", "Start", "Type", "UserId" },
                values: new object[] { new Guid("a135e353-1f4f-45a7-b6b3-808ce8d2d7ef"), "Accusys", null, "Management and optimization of queries, tables, stored procedures and views in MS SQL Server databases. I work with technologies such as WPF, Classic ASP, VBS, HTML, Javascript, Java and IIS", true, true, "Manejo y optimización de querys, tablas, stored procedures y vistas en bases de datos MS SQL Server. Trabajo con tecnologías tales como WPF, ASP Clásico, VBS, HTML, Javascript, Java y IIS", "Analista Programador Junior", new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "EnglishDesc", "HasEnglishDesc", "Name", "NativeDesc", "Url", "UserId" },
                values: new object[] { new Guid("4d8c0738-424a-470b-a02d-bfe091558831"), "Personal portfolio made with REACT + Typescript + Tailwindcss + .NET 6 + SQL Server", true, "Portfolio", "Portfolio personal realizado con REACT + Typescript + Tailwindcss + .NET 6 + SQL Server", "https://tiagoramirez-portfolio.netlify.app/tiagoramirez", "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" });

            migrationBuilder.InsertData(
                table: "SocialMedia",
                columns: new[] { "Id", "Name", "Url", "UserId" },
                values: new object[,]
                {
                    { new Guid("7be37952-f510-490c-83c0-7c2281259330"), 3, "https://www.linkedin.com/in/tiagoramirezmar/", "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("d9e84842-7feb-4a54-acce-ab559a3b924c"), 1, "https://www.github.com/tiagoramirez/", "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" }
                });

            migrationBuilder.InsertData(
                table: "User_Skill",
                columns: new[] { "Id", "Percentage", "SkillId", "UserId" },
                values: new object[,]
                {
                    { new Guid("01e9bf64-efc7-4792-95ad-6d16a81eed08"), 90, new Guid("e87dba1f-4ae1-4831-8e84-76af479379c8"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("0de3503b-4ce0-4417-91e4-d05ae7b8c10b"), 95, new Guid("4d87ee36-7c36-4343-b135-e7852f2ff76e"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("1dad3e9a-2a79-4a10-b545-86060b9c488f"), 90, new Guid("9539e24c-eb3b-4e4c-a13e-c517ea36e7be"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("1f95b03c-dc42-4ec5-9074-c9fe746a930e"), 95, new Guid("03badd18-142e-4ee1-8767-cfae38f1e8ea"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("2340f117-ca92-4666-a456-cad721efe7de"), 100, new Guid("ad4e69fe-9d22-4738-bb92-24e11f1d870e"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("268aecf3-8e4c-402d-9c9f-a377daefed3d"), 85, new Guid("62c8f993-8688-46cb-8ebb-7c4964af4d72"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("3522b888-3554-4ff8-8909-85de2dbb8103"), 70, new Guid("1f7dcb2c-0979-488c-b739-6913e86b5c99"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("384dbda5-8436-4eec-83e8-2257a81635de"), 75, new Guid("09931a46-4f03-41ad-8494-a265f3c8754b"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("3dcf9455-3496-4137-81f9-7de6e3afeb00"), 100, new Guid("2bd96cc9-4cf9-459c-bea0-4eebbe2153ee"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("4bcbfbce-7291-40a8-8a44-107e59017b77"), 100, new Guid("08167ec6-d30c-40a6-92d7-eb06113cf940"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("4c19e963-29ae-4c41-9bd4-4a2b6313889b"), 95, new Guid("965d9fd5-0ffa-4150-8188-d9fe21117f8b"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("4e326a34-ac14-4299-b692-7b4ff6a3bb3a"), 90, new Guid("6d01c24c-2643-4b50-9afd-451248f665ca"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("56d2091c-3146-432b-b2b7-c37e0308cf94"), 90, new Guid("fa1dd71f-4546-491d-919b-dd6deb895e0f"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("57040d5f-a4be-46ad-b508-6751075fdd0e"), 90, new Guid("731ebb23-0cee-4f4a-a53f-dbe94823b993"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("6be3fc2c-e8ed-4d79-9115-813ed34b0610"), 100, new Guid("f4a01dab-8aa4-4780-bd6e-4638b3ff7e19"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("71507e1d-e02e-4a30-bbbf-8783247fa096"), 70, new Guid("06d85e3f-7305-44d2-9315-c1f99afb2b9c"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("803a9fe4-711a-418e-a6e0-cbba220f69b1"), 90, new Guid("d73abf96-3c66-45ff-a651-304ef12147bc"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("870d2802-2d47-4b56-8d03-b046fd8343e0"), 90, new Guid("4870b24a-8e82-47ee-93af-c88d3cd01238"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("8f314b99-1e2d-463e-92ac-2ff18dcccac7"), 80, new Guid("3e51e2b6-4f44-4341-91cb-c3150f3dfb12"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("94651e06-a108-48a2-94a8-4aa3dd6c4c97"), 95, new Guid("09e8b0dd-57e7-4054-8ffe-5b5a8af74ae4"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("9526b3de-26b2-4a83-b5c5-24fb15586447"), 80, new Guid("b233ec82-3ffb-45f6-8fb3-338d583f5ac7"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("983a1527-9a4a-4c53-ab7d-1f4c3f944c7a"), 100, new Guid("f771aa1b-8ee9-44e4-b71e-e4436d819997"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("9cc335c8-a6ce-4f46-9466-7b52772b6e92"), 95, new Guid("abf491de-913d-46d4-a30a-b3a55eebc952"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("a6b91e72-528b-4870-8d30-7434774fd1c0"), 70, new Guid("f16d09ba-acb0-4f19-ada1-d10d84a77fbd"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("aae7e4cb-21b4-4995-afc5-3f8079a87d2c"), 80, new Guid("cc3b831f-097a-4be0-8ccb-d1913fcb3961"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("b97dd71e-6b01-4d70-8ce2-9cb173141003"), 90, new Guid("0eef2041-ee33-4b3a-b93c-10fd257b527b"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("bfcaadb4-e5f0-46f2-a9d8-4e4355b332fa"), 100, new Guid("3b020f36-d959-4304-8be9-a0ad92105335"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("c9c64c70-5524-4c84-b585-675f20973c40"), 80, new Guid("57e18b6c-8f53-448f-ae72-1770e7d7a70a"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("cf1d3fb2-ea5f-442b-8a73-d0e6bad0a08c"), 80, new Guid("33b99740-936e-40df-8e9a-aec0f686b702"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("d1d3c91b-53bb-4c8c-827e-49d288fd377d"), 90, new Guid("2ca561c9-ef16-499b-bfe2-09b7e86792f2"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("d20f0593-602c-4a6f-98b8-347c0a3c9e7d"), 90, new Guid("0a8e5f19-29e3-4f7b-b15e-79e0ef1e9e7b"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("e67f1e10-7507-4401-a618-bf0ab857b932"), 90, new Guid("42f90172-c0e5-4a55-9ab1-ce63e5bc8803"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("eef647e5-9e26-4266-8b2d-65437f7dc73e"), 100, new Guid("e6928cbd-a13f-4041-a4bb-1b729ced8238"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" }
                });

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
                name: "IX_SocialMedia_UserId",
                table: "SocialMedia",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Skill_SkillId",
                table: "User_Skill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Skill_UserId",
                table: "User_Skill",
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
                name: "SocialMedia");

            migrationBuilder.DropTable(
                name: "User_Skill");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
