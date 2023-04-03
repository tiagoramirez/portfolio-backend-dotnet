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
                    NativeAboutMe = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    HasEnglishAboutMe = table.Column<bool>(type: "bit", nullable: false),
                    EnglishAboutMe = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
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
                    NativeDesc = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    HasEnglishDesc = table.Column<bool>(type: "bit", nullable: false),
                    EnglishDesc = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
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
                    NativeDesc = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    HasEnglishDesc = table.Column<bool>(type: "bit", nullable: false),
                    EnglishDesc = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
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
                    NativeDesc = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    HasEnglishDesc = table.Column<bool>(type: "bit", nullable: false),
                    EnglishDesc = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
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
                    { new Guid("04f43fd4-75c1-4a7c-8e03-199254df28d0"), "Node", 2 },
                    { new Guid("0bb64ddf-a4fe-45ef-b691-c64505744a37"), "CSS", 0 },
                    { new Guid("1e76bf58-b23e-4a58-9677-97a9728ba352"), "Linux", 2 },
                    { new Guid("38fda3fb-1ff1-4d7c-9a9d-f5ff99a50da0"), "Java", 1 },
                    { new Guid("3a516c73-d967-4a53-a898-3564301b0826"), ".NET WPF", 1 },
                    { new Guid("3e1c8a36-8535-4565-a918-d39bddb2af4a"), "POO", 2 },
                    { new Guid("48337d7d-4d14-4763-8718-b6f8743370b9"), "Scrum", 2 },
                    { new Guid("4d67463e-9914-4a2f-be25-0b3ec2443c2b"), "Angular", 0 },
                    { new Guid("4e2ba87b-f1c3-4272-9a99-5f10b4332789"), "Entity Framework", 1 },
                    { new Guid("51cc10f0-a910-41b6-b2dc-fe6a3e4fbf34"), "JavaScript", 0 },
                    { new Guid("56b05c73-131b-45cb-97b5-c53d3a8248a6"), ".NET CORE 6", 1 },
                    { new Guid("5a1711d1-6304-4339-a93c-6291924027ea"), "Bootstrap", 0 },
                    { new Guid("66efc222-c90d-4d93-a6a0-4b32258bdff1"), "MySql", 1 },
                    { new Guid("683bf236-3f7a-4dd5-a228-1f23fcce5383"), "SQL", 1 },
                    { new Guid("719a7037-f09e-41cb-9065-f3819c9d2bca"), "React", 0 },
                    { new Guid("7400f474-9cae-4899-a208-29e432f79af7"), "Entity Relationship Diagram", 2 },
                    { new Guid("89296805-7b5d-4e5a-8d09-cec322e8566c"), "UML", 2 },
                    { new Guid("893cc65a-ff84-44f9-b283-487e3ece677f"), "Git", 2 },
                    { new Guid("90f90733-452c-4364-9d54-ab4d0fce4cd1"), "Vitest", 0 },
                    { new Guid("94d0c944-c13b-458c-9b4a-537b641757b4"), "MS SQL Server", 1 },
                    { new Guid("95b20d7b-e9c4-4b86-bab1-47c47db714e8"), "HTML", 0 },
                    { new Guid("965cecf3-98ac-46c8-8ac2-81446a8ba346"), "Fluent API", 1 },
                    { new Guid("9b2d6b9a-de84-40ac-971f-4f92423f72eb"), "Vite", 0 },
                    { new Guid("ac54d033-bc17-433c-be35-700e1ff6e913"), "REST API", 2 },
                    { new Guid("b1699df7-a872-429f-8b57-c0866c3acca6"), "Redux Toolkit", 0 },
                    { new Guid("b5dd4b86-6baf-42c0-80ca-0bf1d7233bb2"), "Migrations", 1 },
                    { new Guid("b6bec8c7-a632-4f37-a033-ed9dca7b8438"), "JWT", 2 },
                    { new Guid("bee3b50f-d976-44cd-bd80-44259d8f23d2"), "TypeScript", 0 },
                    { new Guid("c28c64eb-46aa-40c0-aab7-411e96fe1b1f"), "C#", 1 },
                    { new Guid("c5e127eb-1c93-495d-8164-f12bf4849302"), "Middlewares", 1 },
                    { new Guid("cd02cb9b-d6e9-4e80-b348-220dcc3c0a9a"), "Java Spring", 1 },
                    { new Guid("dd06c590-5468-4579-b9f8-a746697d6b22"), "React Router", 0 },
                    { new Guid("e0beea0f-331a-48fe-901f-4aaa8f5ab220"), ".NET API", 1 },
                    { new Guid("f0741707-a83d-45ee-8d04-fc1660426f8e"), "Python", 1 },
                    { new Guid("f484760e-7ef5-40a8-9e0b-c780d5135921"), "Testing library", 0 },
                    { new Guid("ffb641fa-b1cb-4837-8a34-7bf4c032b5fb"), "TailwindCss", 0 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "Email", "EnglishAboutMe", "EnglishDesc", "HasEnglishAboutMe", "HasEnglishDesc", "IsEnglishModeEnabled", "LocationCountry", "LocationState", "Name", "NativeAboutMe", "NativeDesc", "Status", "Username" },
                values: new object[] { "p7EW1FzwW5hgFi4YTV1mmdHTAnm1", new DateTime(2023, 4, 3, 19, 24, 22, 493, DateTimeKind.Local).AddTicks(7014), "tiagoramirez2001@gmail.com", "I'm Fullstack Developer with 1 year of experience in the IT area.\n\nMy main stack: React.js + Typescript + Node.js + .NET 6 API + SQL Server", "FullStack Dev. || React + Typescript + .NET 6 + SQL Server + Node.js || Student in Systems Engineering - UTN 🇦🇷", true, true, true, "Argentina", "C.A.B.A.", "Tiago Alberto Ramirez Marchisio", "Soy Fullstack Developer con 1 año de experiencia en el área de TI.\n\nMi stack principal: React.js + Typescript + Node.js + .NET 6 API + SQL Server", "FullStack Dev. || React + Typescript + .NET 6 + SQL Server + Node.js || Ing. en Sistemas de Información - UTN 🇦🇷", true, "tiagoramirez" });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "End", "EnglishDesc", "HasEnglishDesc", "Institute", "IsActual", "NativeDesc", "Start", "TitleName", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("328fd77b-caaf-446e-85e6-ee2035659b77"), null, "Currently at 3rd year with an average of 9/10.", true, "Universidad Tecnologica Nacional", true, "Me encuentro en 3er año con un promedio de 9/10.", new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ingenieria en Sistemas de Informacion", 1, "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("38d28d9a-a6f6-4f12-8e78-8d9e8230861a"), new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "We learned: C#, OOP, UML, .NET Framework, Entity Framework, Sql Server.\nFinal Project: https://github.com/tiagoramirez/tpFinalCursoDotNetNeorisUTN", true, "Universidad Tecnologica Nacional FRBA", false, "Aprendimos: C#, POO, UML, .NET Framework, Entity Framework, Sql Server.\nProyecto final: https://github.com/tiagoramirez/tpFinalCursoDotNetNeorisUTN", new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Desarrollador .NET", 4, "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("3e7148e0-4cc1-4218-883c-80280e6a4980"), new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C#, .NET 6, POO, Entity Framework, Fluent API, Sql Server.", true, "Platzi", false, "C#, .NET 6, POO, Entity Framework, Fluent API, Sql Server.", new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Entity Framework", 4, "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("80be2508-9ef3-4cf5-8e3a-62bfc9a2e185"), new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Topics:\n- Web Development and Applications (Introduction)\n- Static Front End Development (HTML, CSS, BOOTSTRAP, JavaScript y TypeScript)\n- Dynamic Front End Development (Angular)\n- BACKEND Development (MySQL + Java Spring)\n- Entity Relationship Diagram\n- JWT\n- DevOps", true, "Argentina Programa - INTI", false, "Temas:\n- Introducción a Desarrollo Web y Aplicaciones\n- Desarrollo Front End Estático (HTML, CSS, BOOTSTRAP, JavaScript y TypeScript)\n- Desarrollo Front End Dinámico (Angular)\n- Desarrollo Back End (MySQL+ Java Spring)\n- Diagrama Entidad Relación\n- JWT\n- DevOps", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Argentina Programa #YoProgramo", 4, "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("92bb7b75-c916-4899-a976-d2133fd63272"), new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "REST API, Middlewares, C#, .NET 6, POO, Entity Framework, Sql Server.", true, "Platzi", false, "REST API, Middlewares, C#, .NET 6, POO, Entity Framework, Sql Server.", new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ".NET API's", 4, "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("cf385290-e432-453c-8b16-a770352569d9"), new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "English classes. At the end we took the First Certificate in English exam (Cambridge Institute). My level was: B2.", true, "Instituto Nuestra Sra del Huerto - Cambridge", false, "Clases de ingles. Al final rendimos el examen First Certificate in English (Instituto Cambridge). Mi nivel fue: B2.", new DateTime(2011, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "English", 3, "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" }
                });

            migrationBuilder.InsertData(
                table: "Experience",
                columns: new[] { "Id", "Company", "End", "EnglishDesc", "HasEnglishDesc", "IsActual", "NativeDesc", "Position", "Start", "Type", "UserId" },
                values: new object[] { new Guid("1c6df46f-14d1-447c-adeb-646d8967ac85"), "Accusys", null, "Maintenance of an Bank Cash Control system.\nManagement and optimization of queries, tables, stored procedures and views in MS SQL Server databases.\nTechnologies: WPF, Classic ASP, VBS, HTML, Javascript, Java and IIS.", true, true, "Mantenimiento de un sistema para el Control del Efectivo Bancario.\nManejo y optimización de querys, tablas, stored procedures y vistas en bases de datos MS SQL Server.\nTecnologías: WPF, ASP Clásico, VBS, HTML, Javascript, Java y IIS.", "Analista Programador Junior", new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "EnglishDesc", "HasEnglishDesc", "Name", "NativeDesc", "Url", "UserId" },
                values: new object[] { new Guid("a8488cee-bc7e-4be0-b20f-715b6b1aee3d"), "Personal portfolio made with REACT + Typescript + Tailwindcss + .NET 6 + SQL Server", true, "Portfolio", "Portfolio personal realizado con REACT + Typescript + Tailwindcss + .NET 6 + SQL Server", "https://tiagoramirez-portfolio.netlify.app/tiagoramirez", "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" });

            migrationBuilder.InsertData(
                table: "SocialMedia",
                columns: new[] { "Id", "Name", "Url", "UserId" },
                values: new object[,]
                {
                    { new Guid("722c5cb0-5e38-424a-b58b-16bf7516416f"), 3, "https://www.linkedin.com/in/tiagoramirezmar/", "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("98e87057-981b-408b-af4e-dde1414dd7c7"), 1, "https://www.github.com/tiagoramirez/", "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" }
                });

            migrationBuilder.InsertData(
                table: "User_Skill",
                columns: new[] { "Id", "Percentage", "SkillId", "UserId" },
                values: new object[,]
                {
                    { new Guid("03d773de-5c42-431b-a17a-51cf102cf854"), 90, new Guid("38fda3fb-1ff1-4d7c-9a9d-f5ff99a50da0"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("06209e4c-ee8d-4704-93c0-e9a520ddd124"), 100, new Guid("7400f474-9cae-4899-a208-29e432f79af7"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("08088118-2c49-4f96-8e75-3177ecd63ba1"), 90, new Guid("b6bec8c7-a632-4f37-a033-ed9dca7b8438"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("19f835a3-07c9-4ee3-8779-a3210f3da311"), 80, new Guid("1e76bf58-b23e-4a58-9677-97a9728ba352"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("1b2669f7-a5fb-4534-93d5-e73c7c7fa9f1"), 90, new Guid("48337d7d-4d14-4763-8718-b6f8743370b9"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("1d5e5829-a4d5-4429-80a4-410f232e4743"), 90, new Guid("56b05c73-131b-45cb-97b5-c53d3a8248a6"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("2370162c-38ab-4402-a941-d04f54706cb5"), 90, new Guid("c5e127eb-1c93-495d-8164-f12bf4849302"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("24eb28fc-d3e8-4cd1-9f63-f8dfdb1e28be"), 80, new Guid("f484760e-7ef5-40a8-9e0b-c780d5135921"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("2bac558d-30a8-4aad-8fa7-9f27a569fe79"), 90, new Guid("95b20d7b-e9c4-4b86-bab1-47c47db714e8"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("3efcd50d-9b1f-4656-a89a-b5bba9dc80ed"), 100, new Guid("bee3b50f-d976-44cd-bd80-44259d8f23d2"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("43b70c26-51fc-49a1-8675-2f7b657372b1"), 70, new Guid("cd02cb9b-d6e9-4e80-b348-220dcc3c0a9a"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("4f1b73b0-b926-4937-b359-6830bf7a6fbd"), 95, new Guid("dd06c590-5468-4579-b9f8-a746697d6b22"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("5402b300-3445-4e8c-b8c4-b4880279fc11"), 95, new Guid("965cecf3-98ac-46c8-8ac2-81446a8ba346"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("565528af-e1ee-4a9a-bdaf-11da1ca316a9"), 95, new Guid("719a7037-f09e-41cb-9065-f3819c9d2bca"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("63b8b24f-29f6-4603-92a8-4d0bed34dd69"), 80, new Guid("9b2d6b9a-de84-40ac-971f-4f92423f72eb"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("6985d659-af82-4c73-a8c9-b79875ed4162"), 90, new Guid("e0beea0f-331a-48fe-901f-4aaa8f5ab220"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("74254a4c-002f-4b70-944b-b758bc24b9b7"), 100, new Guid("94d0c944-c13b-458c-9b4a-537b641757b4"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("75ee6176-5395-4e9e-b995-5eed56350dd9"), 100, new Guid("b5dd4b86-6baf-42c0-80ca-0bf1d7233bb2"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("77447e39-b62b-46a5-a53e-decd1b8c147e"), 75, new Guid("3a516c73-d967-4a53-a898-3564301b0826"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("778091fa-b3d3-4f3e-8633-e1293b774998"), 90, new Guid("ac54d033-bc17-433c-be35-700e1ff6e913"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("8a5c3a75-67ac-4c90-aa8d-8beba2046a19"), 80, new Guid("90f90733-452c-4364-9d54-ab4d0fce4cd1"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("8c5badfe-b483-494d-8611-554c865758cb"), 70, new Guid("66efc222-c90d-4d93-a6a0-4b32258bdff1"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("a438cc9a-b58c-4a70-938a-7f1da0a5fd57"), 90, new Guid("51cc10f0-a910-41b6-b2dc-fe6a3e4fbf34"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("a54bea87-17f1-41d5-a478-9f2d21a7aaf0"), 100, new Guid("683bf236-3f7a-4dd5-a228-1f23fcce5383"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("af24227d-cf0b-4476-aa5a-98a66494f39f"), 85, new Guid("04f43fd4-75c1-4a7c-8e03-199254df28d0"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("b427efc4-d42e-418a-ab68-f125b2671e2e"), 100, new Guid("c28c64eb-46aa-40c0-aab7-411e96fe1b1f"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("bce3e1a8-2335-4296-b624-ae3ec474b857"), 90, new Guid("893cc65a-ff84-44f9-b283-487e3ece677f"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("bdb86120-ce7d-4174-a9f2-140341fe53d5"), 70, new Guid("4d67463e-9914-4a2f-be25-0b3ec2443c2b"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("c71cec6f-ad02-4397-b25c-3572e6618bfe"), 90, new Guid("4e2ba87b-f1c3-4272-9a99-5f10b4332789"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("ca65e122-58df-4da4-b909-324d264a6a5c"), 100, new Guid("3e1c8a36-8535-4565-a918-d39bddb2af4a"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("ed61909d-a6c9-49d1-8fa3-b72004344779"), 100, new Guid("89296805-7b5d-4e5a-8d09-cec322e8566c"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("ef37339d-32a5-44c6-bc42-c2aa6f4bae2e"), 95, new Guid("ffb641fa-b1cb-4837-8a34-7bf4c032b5fb"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" }
                });

            migrationBuilder.InsertData(
                table: "User_Skill",
                columns: new[] { "Id", "Percentage", "SkillId", "UserId" },
                values: new object[] { new Guid("f5261380-baa9-4c14-8865-9bcb2b539d18"), 95, new Guid("b1699df7-a872-429f-8b57-c0866c3acca6"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" });

            migrationBuilder.InsertData(
                table: "User_Skill",
                columns: new[] { "Id", "Percentage", "SkillId", "UserId" },
                values: new object[] { new Guid("fa1dbad1-3b36-4084-8748-f176dfce4f23"), 80, new Guid("0bb64ddf-a4fe-45ef-b691-c64505744a37"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" });

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
