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
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
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
                    { new Guid("014633c5-2767-4736-85fb-1fe8bbab3931"), ".NET CORE 6", 1 },
                    { new Guid("0749acb2-87e8-460c-81ee-ae37676f7b0f"), "Java Spring", 1 },
                    { new Guid("094ba69d-edee-4fa2-bbd4-8ddc3ebbcde0"), "Vite", 0 },
                    { new Guid("1f813416-62f8-4151-a627-4e3809d06992"), "Migrations", 1 },
                    { new Guid("25337d23-87e0-4b04-985c-8d0d17be8093"), "Entity Framework", 1 },
                    { new Guid("26e3c863-f2e1-4dc4-9718-b3dae0a7dd04"), "React", 0 },
                    { new Guid("28d8f96e-5a00-4413-8501-7d66eeea97f3"), "Git", 2 },
                    { new Guid("2f1e14cc-1f52-4b3e-b01b-6cdc1a878f21"), "HTML", 0 },
                    { new Guid("3ac74277-64c2-461e-9097-1cd0d592ea75"), ".NET API", 1 },
                    { new Guid("3e8a0e07-bbdb-4a1a-b866-132c22db4cd7"), "REST API", 2 },
                    { new Guid("457012cc-1ee3-4941-8fab-dac9fcdbae1c"), "Scrum", 2 },
                    { new Guid("487fba6c-0c35-4fa5-af18-53fb0cb922c6"), "Bootstrap", 0 },
                    { new Guid("4fc0941e-d64f-496a-8557-32db7fb4504c"), "Middlewares", 1 },
                    { new Guid("53e59760-58ab-402a-a261-1d9d2ad5e709"), "Redux Toolkit", 0 },
                    { new Guid("618d696e-3de2-455d-963b-77152fa2fa86"), "Angular", 0 },
                    { new Guid("61d3a2d5-bd4f-4906-bead-9b61b5437e8d"), "Testing library", 0 },
                    { new Guid("717c0440-c700-4b12-a431-53c5dca4d96a"), "Vitest", 0 },
                    { new Guid("755b6b22-a2d4-4533-bce5-5247ce58985e"), "Node", 2 },
                    { new Guid("8b525a78-81fe-4416-8408-97ecf86654f6"), "ERD / DER", 2 },
                    { new Guid("8d80f814-f57c-4786-b139-17616a929ba2"), "JWT", 2 },
                    { new Guid("9823aebc-db4b-4bc1-946e-2c93e89af71b"), "SQL", 1 },
                    { new Guid("b8b937df-e02e-436d-977c-243f7fcc97fc"), "CSS", 0 },
                    { new Guid("bb05f08f-cc32-4cf3-9440-49923d2336d0"), "TypeScript", 0 },
                    { new Guid("c46c4d39-dc74-4fdf-bfab-48cb4aadaa46"), "UML", 2 },
                    { new Guid("ccf97f36-a6e1-44c3-8e4c-3414071a28d9"), "Linux", 2 },
                    { new Guid("ce45c4eb-9f2b-4bf4-a260-cabf77a66197"), "JavaScript", 0 },
                    { new Guid("d0938a3f-2bd4-473b-bb10-270531665cd1"), "C#", 1 },
                    { new Guid("d5cedb6c-bdc7-4769-ab44-b75e800cfdf3"), "React Router", 0 },
                    { new Guid("d806b2b4-4727-4f6c-9a69-cd90eac1a419"), "Fluent API", 1 },
                    { new Guid("dea83442-6947-4606-af62-c9feea00dc28"), "Python", 1 },
                    { new Guid("ea323063-81e0-4130-b07d-0b0a19a97c01"), "MS SQL Server", 1 },
                    { new Guid("f35f33ac-b759-49b9-9d53-8b63378b6b9d"), "Java", 1 },
                    { new Guid("f3d75026-0855-41da-b18a-cd207341fe76"), "MySql", 1 },
                    { new Guid("fa6eff2f-e2cc-42c2-8318-171800dd3540"), "TailwindCss", 0 },
                    { new Guid("fc3ddd76-225c-496b-852a-18056bba8401"), ".NET WPF", 1 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "Email", "EnglishAboutMe", "EnglishDesc", "HasEnglishAboutMe", "HasEnglishDesc", "IsEnglishModeEnabled", "LocationCountry", "LocationState", "Name", "NativeAboutMe", "NativeDesc", "Status", "Username" },
                values: new object[] { "p7EW1FzwW5hgFi4YTV1mmdHTAnm1", new DateTime(2023, 3, 29, 1, 31, 47, 188, DateTimeKind.Local).AddTicks(3036), "tiagoramirez2001@gmail.com", "Fullstack Web Dev. with 1 year of experience in the IT area. My main stack: React + Typescript + .NET 6 API + SQL Server + Node", "FullStack Web Dev. with +1yr exp. || React + Typescript + .NET 6 + SQL Server + Node || Student in Systems Engineering - UTN (Argentina)", true, true, true, "Argentina", "C.A.B.A.", "Tiago Alberto Ramirez Marchisio", "Fullstack Web Dev. con 1 año de experiencia en el área de TI. Mi stack principal: React + Typescript + .NET 6 API + SQL Server + Node", "FullStack Web Dev. con +1 año de exp. || React + Typescript + .NET 6 + SQL Server + Node || Ingeniería en Sistemas de Información - UTN (Argentina)", true, "tiagoramirez" });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "End", "EnglishDesc", "HasEnglishDesc", "Institute", "IsActual", "NativeDesc", "Start", "TitleName", "Type", "UserId" },
                values: new object[] { new Guid("d79fdf42-42d9-49e0-81ab-0330d0ddbf9c"), null, "Currently at 3rd year with an average of 9/10", true, "Universidad Tecnologica Nacional", true, "Me encuentro en 3er año con un promedio de 9/10", new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ingenieria en Sistemas de Informacion", 1, "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" });

            migrationBuilder.InsertData(
                table: "Experience",
                columns: new[] { "Id", "Company", "End", "EnglishDesc", "HasEnglishDesc", "IsActual", "NativeDesc", "Position", "Start", "Type", "UserId" },
                values: new object[] { new Guid("b3bf98c1-1f5d-406c-a8ed-4083ea564af0"), "Accusys", null, "Management and optimization of queries, tables, stored procedures and views in MS SQL Server databases. I work with technologies such as WPF, Classic ASP, VBS, HTML, Javascript, Java and IIS", true, true, "Manejo y optimización de querys, tablas, stored procedures y vistas en bases de datos MS SQL Server. Trabajo con tecnologías tales como WPF, ASP Clásico, VBS, HTML, Javascript, Java y IIS", "Analista Programador Junior", new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "EnglishDesc", "HasEnglishDesc", "Name", "NativeDesc", "Url", "UserId" },
                values: new object[] { new Guid("618bdbcf-7304-492f-a347-b989a6904099"), "Personal portfolio made with REACT + Typescript + Tailwindcss + .NET 6 + SQL Server", true, "Portfolio", "Portfolio personal realizado con REACT + Typescript + Tailwindcss + .NET 6 + SQL Server", "https://tiagoramirez-portfolio.netlify.app/tiagoramirez", "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" });

            migrationBuilder.InsertData(
                table: "SocialMedia",
                columns: new[] { "Id", "Name", "Url", "UserId" },
                values: new object[,]
                {
                    { new Guid("00eeeead-1e0c-4e90-bfe9-bf81409f8387"), "LinkedIn", "https://www.linkedin.com/in/tiagoramirezmar/", "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("78146e6c-8ee4-476a-bd71-268e2a10ef26"), "Github", "https://www.github.com/tiagoramirez/", "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" }
                });

            migrationBuilder.InsertData(
                table: "User_Skill",
                columns: new[] { "Id", "Percentage", "SkillId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0688b498-14d1-48d3-acbf-d193ffbc63b0"), 90, new Guid("3ac74277-64c2-461e-9097-1cd0d592ea75"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("11f285a6-9a59-4cc8-895e-f2ed25bf8c58"), 90, new Guid("014633c5-2767-4736-85fb-1fe8bbab3931"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("1b2f1138-43cf-4a3c-86b3-72eb32fe788d"), 100, new Guid("bb05f08f-cc32-4cf3-9440-49923d2336d0"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("262f8834-f7ca-4fe8-b699-f069fef575f8"), 80, new Guid("b8b937df-e02e-436d-977c-243f7fcc97fc"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("2f9f6947-c007-4267-b0f1-703aec821665"), 100, new Guid("d0938a3f-2bd4-473b-bb10-270531665cd1"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("31f4c8e6-3a95-4b5e-869c-c025c62d2551"), 90, new Guid("28d8f96e-5a00-4413-8501-7d66eeea97f3"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("37060ad4-1b61-45d9-a313-c4eb5292cfa5"), 95, new Guid("d5cedb6c-bdc7-4769-ab44-b75e800cfdf3"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("3e6468ff-3e3e-44f8-9ea5-53d136867e3d"), 70, new Guid("0749acb2-87e8-460c-81ee-ae37676f7b0f"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("4b83855c-fb6b-44f4-8bdb-cd218ae0a8c2"), 100, new Guid("c46c4d39-dc74-4fdf-bfab-48cb4aadaa46"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("527255c1-91fe-4159-aade-eb57190d2368"), 70, new Guid("f3d75026-0855-41da-b18a-cd207341fe76"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("54a9b699-9a86-4f42-b2a9-0b100b135a3d"), 90, new Guid("3e8a0e07-bbdb-4a1a-b866-132c22db4cd7"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("6380fd1d-4eec-49f5-833c-dd07a5877bd7"), 90, new Guid("457012cc-1ee3-4941-8fab-dac9fcdbae1c"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("6432879a-6583-4cc2-8c9d-8820741a17d6"), 90, new Guid("4fc0941e-d64f-496a-8557-32db7fb4504c"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("6e17776a-3b4b-4ba6-ae1f-33b7b4989e45"), 90, new Guid("f35f33ac-b759-49b9-9d53-8b63378b6b9d"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("6fbbae4d-4935-4680-9af0-3d10831ebbc7"), 100, new Guid("8b525a78-81fe-4416-8408-97ecf86654f6"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("83d87ef6-9c3d-40ee-861b-ea50fc8f2498"), 80, new Guid("717c0440-c700-4b12-a431-53c5dca4d96a"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("93671bb2-456f-4cb7-bfb3-08d4335314b7"), 80, new Guid("61d3a2d5-bd4f-4906-bead-9b61b5437e8d"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("a2ae240d-8e4c-4699-bb9b-42e9cdc92956"), 95, new Guid("d806b2b4-4727-4f6c-9a69-cd90eac1a419"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("a547e991-f657-423a-9c65-d9dff034ef7b"), 100, new Guid("1f813416-62f8-4151-a627-4e3809d06992"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("a64dc248-e1c7-414b-9a44-a9a98447f8a0"), 85, new Guid("755b6b22-a2d4-4533-bce5-5247ce58985e"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("ae8ba168-8b3a-4e0b-b8b2-b38042bba166"), 95, new Guid("26e3c863-f2e1-4dc4-9718-b3dae0a7dd04"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("b01e5bda-1b0c-4c96-9616-dd7ce6008f5d"), 75, new Guid("fc3ddd76-225c-496b-852a-18056bba8401"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("b12850c9-e5c1-40c9-80f9-43df14ab316b"), 95, new Guid("53e59760-58ab-402a-a261-1d9d2ad5e709"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("b9c53b89-9a6d-41c4-b448-4b529f35af33"), 80, new Guid("ccf97f36-a6e1-44c3-8e4c-3414071a28d9"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("bd52b781-40c6-48ef-a453-25dae8c800c5"), 100, new Guid("ea323063-81e0-4130-b07d-0b0a19a97c01"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("bded44ff-58bb-4144-87c3-c1d4dec0d9ec"), 100, new Guid("9823aebc-db4b-4bc1-946e-2c93e89af71b"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("c3f148dd-05f7-4850-9c94-f102a7c11559"), 80, new Guid("094ba69d-edee-4fa2-bbd4-8ddc3ebbcde0"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("c4217a9c-0937-4aad-857a-93abaa17dad1"), 95, new Guid("fa6eff2f-e2cc-42c2-8318-171800dd3540"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("c7d09100-ecd9-4e43-977f-c1f4395fd18b"), 90, new Guid("ce45c4eb-9f2b-4bf4-a260-cabf77a66197"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("c8d5c425-7ffb-465f-9dcf-4145fd1f93d7"), 90, new Guid("2f1e14cc-1f52-4b3e-b01b-6cdc1a878f21"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("c917b886-dcac-45f8-879e-6ae33b5df6b5"), 90, new Guid("25337d23-87e0-4b04-985c-8d0d17be8093"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("e023a21c-c1a7-46a0-92bf-7594cdfb1683"), 90, new Guid("8d80f814-f57c-4786-b139-17616a929ba2"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("fcc1f7ca-c146-42d1-b44c-8b8582e148b0"), 70, new Guid("618d696e-3de2-455d-963b-77152fa2fa86"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" }
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
