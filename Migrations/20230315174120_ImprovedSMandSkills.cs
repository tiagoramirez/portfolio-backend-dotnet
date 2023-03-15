using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace portfolio.Migrations
{
    public partial class ImprovedSMandSkills : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("ecbe3d82-f053-433a-b0d8-87449c5d7323"));

            migrationBuilder.DeleteData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: new Guid("95c5f5ae-2587-4148-a89d-9c4215435e94"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("437db8da-4adb-4aaf-baf1-0551b4e80cd7"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("05a89055-2308-458d-a829-df535a77cbf2"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("11404bda-ba5e-4092-8153-8688431fcc39"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("19982c0b-5e59-4514-8686-eec11f22943e"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("1c20bb16-393d-448e-98e7-25395dedcace"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("1c5def7e-ddfe-4261-9a5d-487817e3d057"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("259585db-73ae-4a8b-ba7b-c7be407c3474"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("32d7cb4c-9e77-4ade-884c-92a9a91db87a"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("380c80ce-9025-4e21-bea4-24ba0d6f8525"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("3ae6184d-e53a-459d-adc7-7f2de62c5e1b"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("508435bb-bb2a-4091-9990-bd55297ebb74"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("51823903-9296-43b7-9ee8-dab85c4e29ea"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("54fc6e67-fb4a-4add-91be-443ac8ee3745"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("56c600f5-c5bf-4988-813a-5f5b5b6a5449"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("57999f5c-7934-4d16-b56c-27f2b80ae9fe"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("63394645-d9a3-460f-9f47-915107bdabc1"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("7270c665-91f0-45c0-8f8c-9ca814477610"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("901da623-2221-472b-bc6e-16845a7fce17"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("91cc9b4c-7ee7-4676-a660-15abf3be770e"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("9bde1fbe-91f5-4b3d-b230-12dad7feb3f3"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("a26fcf30-ce3f-4c7e-9f93-f0dc2f03f84f"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("a32286dc-0a4a-415c-af52-b6906faae8e2"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("a3e95dae-2c4d-4cff-b937-89b0588f11a6"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("a56f990a-c0d0-486f-8d0f-d086a278e252"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("c92798fc-3185-43cf-9127-dad825c12e9c"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("d1d70f2c-6933-47e6-9e70-cc10f8bce8b2"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("d386659f-746f-4e57-a52a-3a282e2cb407"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("d8d67b0e-7bb7-4744-a5a9-71d3e4bd330d"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("dab52178-a8b8-4f41-b20c-2d24f156f240"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("de5facb6-323b-413a-b119-2114bc688b27"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("df1d3199-2e55-4a4f-8105-65087a83d2a0"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("e104fa1a-4866-4058-8557-2e7b550c65ed"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("e91d1250-4b8c-4580-893b-85e7a5818d9f"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("e93827d3-2526-4d3c-989e-84bff8071644"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("ef61fdbf-94fc-4463-8852-5a804d60bee7"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("18f95ffc-b012-4e33-af96-de92a6ac728d"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("44989082-ea07-49db-9892-afe921dc7fbe"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("528978ba-3cbe-4d9f-9b3d-23200ca10eaa"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("92792965-3020-45b7-b5b6-56fcba6575fe"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("e14fea03-8971-4fad-b7ce-31e81151757d"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("e6bce127-a511-4f33-948c-6d00f4a9927e"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("fcd440d9-da36-4a93-a840-6ee8d22b88c2"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("b26ff75e-0556-4d30-b198-8d472ac10fed"));

            migrationBuilder.DeleteData(
                table: "User_SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("cc53d1cb-53cb-4b32-bb37-ca512223e639"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("27277b58-070f-4e2b-baac-f28a6200715a"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("78e464d4-ad11-4db5-936d-e92180abf3dd"));

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "End", "EnglishDesc", "HasEnglishDesc", "Institute", "IsActual", "NativeDesc", "Start", "TitleName", "Type", "UserId" },
                values: new object[] { new Guid("e5981b64-7e20-486a-b4a9-06dae0bf0d26"), null, "Currently at 3rd year with an average of 9/10", true, "Universidad Tecnologica Nacional", true, "Me encuentro en 3er año con un promedio de 9/10", new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ingenieria en Sistemas de Informacion", 1, "00000000000000000000000000000" });

            migrationBuilder.InsertData(
                table: "Experience",
                columns: new[] { "Id", "Company", "End", "EnglishDesc", "HasEnglishDesc", "IsActual", "NativeDesc", "Position", "Start", "Type", "UserId" },
                values: new object[] { new Guid("98e1a25f-64b3-4a87-82cb-c373df7f92a7"), "Accusys", null, "Management and optimization of queries, tables, stored procedures and views in MS SQL Server databases. I work with technologies such as WPF, Classic ASP, VBS, HTML, Javascript, Java and IIS", true, true, "Manejo y optimización de querys, tablas, stored procedures y vistas en bases de datos MS SQL Server. Trabajo con tecnologías tales como WPF, ASP Clásico, VBS, HTML, Javascript, Java y IIS", "Analista Programador Junior", new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "00000000000000000000000000000" });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "EnglishDesc", "HasEnglishDesc", "Name", "NativeDesc", "Url", "UserId" },
                values: new object[] { new Guid("ff35ac4e-66dc-4487-b20d-7682a6203eb3"), "Personal portfolio made with REACT + Typescript + Tailwindcss + .NET 6 + SQL Server", true, "Portfolio", "Portfolio personal realizado con REACT + Typescript + Tailwindcss + .NET 6 + SQL Server", "https://tiagoramirez-portfolio.netlify.app/tiagoramirez", "00000000000000000000000000000" });

            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "Id", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("00d7a50f-d03e-439e-98d1-0598edac66c8"), "Java", 1 },
                    { new Guid("01736635-6135-4855-ac64-8d506a00b7e3"), ".NET WPF", 1 },
                    { new Guid("07126d57-4c45-468d-8b79-d63fc0f404fb"), "MySql", 1 },
                    { new Guid("078b6b41-488e-48de-bd91-e35c00707a71"), "HTML", 0 },
                    { new Guid("0873ac3a-ebe0-4498-93f0-24ba05bd9aa9"), "Bootstrap", 0 },
                    { new Guid("0d79c929-375c-4f12-867f-a2231ece9cb8"), "ERD / DER", 2 },
                    { new Guid("1121bc0b-c794-493f-b082-a01434bd1600"), "C#", 1 },
                    { new Guid("1b677ea6-c7ba-4122-8568-2ac2d1a63775"), "Entity Framework", 1 },
                    { new Guid("2214731b-3cc1-4e68-ac3c-0f3cd6cdd9de"), "Scrum", 2 },
                    { new Guid("2a3e2976-1a46-4b37-bb72-1407a293c6f2"), "Middlewares", 1 },
                    { new Guid("52d2e5a9-6c7b-446a-9eed-2fdceecacba8"), "Java Spring", 1 },
                    { new Guid("531e893a-69b0-44f1-a1a5-a78fa45942df"), "Testing library", 0 },
                    { new Guid("55d5154c-0fe0-44e0-a858-dcf84cd722ab"), "Vite", 0 },
                    { new Guid("5846e310-ed1d-4ceb-ae3f-bbb1acbc5bb7"), "JWT", 2 },
                    { new Guid("5bbaa8fc-1fa7-4f5e-b794-bc4bb542e475"), "Migrations", 1 },
                    { new Guid("5f8ac962-29de-40a2-ae70-4a9454d13af0"), "Redux Toolkit", 0 },
                    { new Guid("74336b5a-99ba-4b9a-a45b-682a738759dd"), "REST API", 2 },
                    { new Guid("7dfdb4d5-ccf2-4289-a806-f8d6eb446976"), "Vitest", 0 },
                    { new Guid("7e55997c-65c8-4ad8-94cf-f202c70b790e"), "Angular", 0 },
                    { new Guid("83e7506c-1bce-4745-9fb5-d02bdb97ec55"), "React", 0 },
                    { new Guid("88b7fabd-bdfe-4482-8017-189281262f87"), "CSS", 0 },
                    { new Guid("89b26a42-7c0b-4ac2-aaf7-cbe966dbfa98"), "Node", 2 },
                    { new Guid("a0c607dc-b4a8-48c2-9b50-6c76307ee18f"), ".NET CORE 6", 1 },
                    { new Guid("a8bfd73f-60cb-4086-9a9d-5eecc5348b4a"), "Git", 2 },
                    { new Guid("ae5de5d2-5907-4c89-954b-5392fc468d61"), "SQL", 1 },
                    { new Guid("b4a0ac5c-6196-443b-b51a-bb713368a13c"), "React Router", 0 },
                    { new Guid("b7a709d4-5018-4e63-85af-e1c5aaf0e999"), "MS SQL Server", 1 },
                    { new Guid("cce7167a-c15c-4eeb-8233-ba21c7903b24"), "TailwindCss", 0 },
                    { new Guid("ce7eab35-5497-4c65-b347-b8946565b7ff"), "TypeScript", 0 },
                    { new Guid("d25a6709-4d66-4c71-9f73-5fe8c3f327b9"), "Linux", 2 },
                    { new Guid("df4f8daf-d2f2-4408-bca6-36817a59e276"), "Fluent API", 1 },
                    { new Guid("e5ec4653-de39-4c5f-850a-484c3571fa37"), "JavaScript", 0 },
                    { new Guid("ea519d0b-b411-4643-83d4-9f2309ee9f38"), "UML", 2 },
                    { new Guid("ed855864-59db-43c3-9a56-afc80db23dea"), "Python", 1 },
                    { new Guid("f20347f9-88ee-441c-a2c2-0be4ac3a12cb"), ".NET API", 1 }
                });

            migrationBuilder.InsertData(
                table: "SocialMedia",
                columns: new[] { "Id", "IconClassName", "Name" },
                values: new object[,]
                {
                    { new Guid("1c8c83aa-16e3-4ffd-a15a-9fb68454f537"), "bi bi-linkedin", "LinkedIn" },
                    { new Guid("33a0a8ef-474c-4755-9634-810b37c6c3e6"), "bi bi-github", "Github" },
                    { new Guid("40e062e4-c6f6-47a1-aad3-cce06047ca7e"), "bi bi-person-circle", "Personal" },
                    { new Guid("4abb1d53-6560-44b0-a693-3d79f9a9a5e5"), "bi bi-whatsapp", "Whatsapp" }
                });

            migrationBuilder.InsertData(
                table: "SocialMedia",
                columns: new[] { "Id", "IconClassName", "Name" },
                values: new object[,]
                {
                    { new Guid("7d7c15e4-005b-4728-b734-153a1d618adf"), "bi bi-twitter", "Twitter" },
                    { new Guid("7e5dd30e-ffc8-4521-9735-0718646f5eb9"), "bi bi-facebook", "Facebook" },
                    { new Guid("b2c292ca-b7f2-4b8c-9e75-f6159439ca8d"), "bi bi-youtube", "Youtube" },
                    { new Guid("f404b236-ffa4-46a6-be61-39fe847e2508"), "bi bi-instagram", "Instagram" }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "00000000000000000000000000000",
                columns: new[] { "Created", "LocationState" },
                values: new object[] { new DateTime(2023, 3, 15, 14, 41, 19, 468, DateTimeKind.Local).AddTicks(5989), "C.A.B.A." });

            migrationBuilder.InsertData(
                table: "User_Skill",
                columns: new[] { "Id", "Percentage", "SkillId", "UserId" },
                values: new object[,]
                {
                    { new Guid("03daf1d5-cd5f-4704-9bb1-acb29637383d"), 100, new Guid("ce7eab35-5497-4c65-b347-b8946565b7ff"), "00000000000000000000000000000" },
                    { new Guid("0de3e8b5-89d2-4b24-91d2-cb0a49bc9937"), 90, new Guid("078b6b41-488e-48de-bd91-e35c00707a71"), "00000000000000000000000000000" },
                    { new Guid("11c45bb1-88be-4f51-bc09-f88ccc715a89"), 85, new Guid("89b26a42-7c0b-4ac2-aaf7-cbe966dbfa98"), "00000000000000000000000000000" },
                    { new Guid("327ecfbc-b870-44d7-948c-fa6e4bbcfcd7"), 80, new Guid("88b7fabd-bdfe-4482-8017-189281262f87"), "00000000000000000000000000000" },
                    { new Guid("383db374-77bc-47e4-9113-85160b8afc5b"), 90, new Guid("2a3e2976-1a46-4b37-bb72-1407a293c6f2"), "00000000000000000000000000000" },
                    { new Guid("3eda72d6-fba6-4472-b233-b5fcae4ee951"), 90, new Guid("f20347f9-88ee-441c-a2c2-0be4ac3a12cb"), "00000000000000000000000000000" },
                    { new Guid("413e5cbc-8d8a-47dc-9e85-0861f6647b17"), 95, new Guid("df4f8daf-d2f2-4408-bca6-36817a59e276"), "00000000000000000000000000000" },
                    { new Guid("4ef53ebc-d0b4-4f47-91ce-12da23c70e19"), 95, new Guid("83e7506c-1bce-4745-9fb5-d02bdb97ec55"), "00000000000000000000000000000" },
                    { new Guid("537af6f0-05e4-43cc-bd3c-b0cfdb74a480"), 70, new Guid("52d2e5a9-6c7b-446a-9eed-2fdceecacba8"), "00000000000000000000000000000" },
                    { new Guid("54e27954-16e8-48be-bab4-490929b00660"), 90, new Guid("e5ec4653-de39-4c5f-850a-484c3571fa37"), "00000000000000000000000000000" },
                    { new Guid("57ae64d8-3a7e-4fc2-b549-31c73bc09a5d"), 70, new Guid("7e55997c-65c8-4ad8-94cf-f202c70b790e"), "00000000000000000000000000000" },
                    { new Guid("6b12c79c-8d17-4b1f-b25c-b2df1ace4d7a"), 90, new Guid("2214731b-3cc1-4e68-ac3c-0f3cd6cdd9de"), "00000000000000000000000000000" },
                    { new Guid("731739b2-3daf-4a5e-b34d-77e41e930a87"), 80, new Guid("55d5154c-0fe0-44e0-a858-dcf84cd722ab"), "00000000000000000000000000000" },
                    { new Guid("7addc2c9-fe10-4e49-8e4b-4484c9b08632"), 90, new Guid("00d7a50f-d03e-439e-98d1-0598edac66c8"), "00000000000000000000000000000" },
                    { new Guid("7d359684-0d90-4949-a4af-d6010b5462f2"), 100, new Guid("0d79c929-375c-4f12-867f-a2231ece9cb8"), "00000000000000000000000000000" },
                    { new Guid("82632860-3dfe-4bb1-b707-8b5f4c8f9f6a"), 100, new Guid("ae5de5d2-5907-4c89-954b-5392fc468d61"), "00000000000000000000000000000" },
                    { new Guid("83766c28-b27e-41cf-ad36-e91f06ff430a"), 95, new Guid("5f8ac962-29de-40a2-ae70-4a9454d13af0"), "00000000000000000000000000000" },
                    { new Guid("83fdb392-634b-4ab3-b879-34f38acb35e4"), 100, new Guid("1121bc0b-c794-493f-b082-a01434bd1600"), "00000000000000000000000000000" },
                    { new Guid("851231a8-15d3-4ec1-b1f7-c1ec62f92d67"), 80, new Guid("7dfdb4d5-ccf2-4289-a806-f8d6eb446976"), "00000000000000000000000000000" },
                    { new Guid("8a540f98-b998-4831-8a8a-be0b367c0233"), 90, new Guid("a8bfd73f-60cb-4086-9a9d-5eecc5348b4a"), "00000000000000000000000000000" },
                    { new Guid("94564d63-e18a-40d3-a49a-44732c6137c2"), 90, new Guid("5846e310-ed1d-4ceb-ae3f-bbb1acbc5bb7"), "00000000000000000000000000000" },
                    { new Guid("9d2bc86c-d1d5-4a6f-90d2-0c04d0810672"), 100, new Guid("5bbaa8fc-1fa7-4f5e-b794-bc4bb542e475"), "00000000000000000000000000000" },
                    { new Guid("a36da4d1-c873-4115-b721-101d6fc2e32b"), 75, new Guid("01736635-6135-4855-ac64-8d506a00b7e3"), "00000000000000000000000000000" },
                    { new Guid("a4798e8e-d9b1-4d3e-95c7-a03d2986b59a"), 90, new Guid("74336b5a-99ba-4b9a-a45b-682a738759dd"), "00000000000000000000000000000" },
                    { new Guid("b477a07c-3e32-4ad4-99f6-6425f6549cc1"), 95, new Guid("cce7167a-c15c-4eeb-8233-ba21c7903b24"), "00000000000000000000000000000" },
                    { new Guid("b49e9410-be31-4388-bada-7c256d0269a2"), 90, new Guid("a0c607dc-b4a8-48c2-9b50-6c76307ee18f"), "00000000000000000000000000000" },
                    { new Guid("c0a676c5-5c25-4934-8441-3ac6afab7028"), 95, new Guid("b4a0ac5c-6196-443b-b51a-bb713368a13c"), "00000000000000000000000000000" },
                    { new Guid("e08ab0a2-398f-4d16-aaec-111e4293ece6"), 80, new Guid("d25a6709-4d66-4c71-9f73-5fe8c3f327b9"), "00000000000000000000000000000" },
                    { new Guid("e2d52631-d7b0-4aa1-b74a-36e023cb26f6"), 100, new Guid("ea519d0b-b411-4643-83d4-9f2309ee9f38"), "00000000000000000000000000000" },
                    { new Guid("e63bba3b-26ac-4b73-84c3-faf330c48e65"), 100, new Guid("b7a709d4-5018-4e63-85af-e1c5aaf0e999"), "00000000000000000000000000000" },
                    { new Guid("e74ce1c6-dbc0-45b6-bd04-101bd0a430e6"), 80, new Guid("531e893a-69b0-44f1-a1a5-a78fa45942df"), "00000000000000000000000000000" },
                    { new Guid("f7e83d7d-3b31-47f7-bb25-f469cb10925c"), 90, new Guid("1b677ea6-c7ba-4122-8568-2ac2d1a63775"), "00000000000000000000000000000" },
                    { new Guid("fc500db9-15d4-457c-ad99-eb6542eff1ab"), 70, new Guid("07126d57-4c45-468d-8b79-d63fc0f404fb"), "00000000000000000000000000000" }
                });

            migrationBuilder.InsertData(
                table: "User_SocialMedia",
                columns: new[] { "Id", "SocialMediaId", "Url", "UserId" },
                values: new object[,]
                {
                    { new Guid("5ae61b37-537a-4600-b277-7224b6327beb"), new Guid("33a0a8ef-474c-4755-9634-810b37c6c3e6"), "https://www.github.com/tiagoramirez/", "00000000000000000000000000000" },
                    { new Guid("87709196-a2ea-4f46-9c11-f5f394d59378"), new Guid("1c8c83aa-16e3-4ffd-a15a-9fb68454f537"), "https://www.linkedin.com/in/tiagoramirezmar/", "00000000000000000000000000000" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("e5981b64-7e20-486a-b4a9-06dae0bf0d26"));

            migrationBuilder.DeleteData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: new Guid("98e1a25f-64b3-4a87-82cb-c373df7f92a7"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("ff35ac4e-66dc-4487-b20d-7682a6203eb3"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("0873ac3a-ebe0-4498-93f0-24ba05bd9aa9"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("ed855864-59db-43c3-9a56-afc80db23dea"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("40e062e4-c6f6-47a1-aad3-cce06047ca7e"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("4abb1d53-6560-44b0-a693-3d79f9a9a5e5"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("7d7c15e4-005b-4728-b734-153a1d618adf"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("7e5dd30e-ffc8-4521-9735-0718646f5eb9"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("b2c292ca-b7f2-4b8c-9e75-f6159439ca8d"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("f404b236-ffa4-46a6-be61-39fe847e2508"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("03daf1d5-cd5f-4704-9bb1-acb29637383d"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("0de3e8b5-89d2-4b24-91d2-cb0a49bc9937"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("11c45bb1-88be-4f51-bc09-f88ccc715a89"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("327ecfbc-b870-44d7-948c-fa6e4bbcfcd7"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("383db374-77bc-47e4-9113-85160b8afc5b"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("3eda72d6-fba6-4472-b233-b5fcae4ee951"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("413e5cbc-8d8a-47dc-9e85-0861f6647b17"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("4ef53ebc-d0b4-4f47-91ce-12da23c70e19"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("537af6f0-05e4-43cc-bd3c-b0cfdb74a480"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("54e27954-16e8-48be-bab4-490929b00660"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("57ae64d8-3a7e-4fc2-b549-31c73bc09a5d"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("6b12c79c-8d17-4b1f-b25c-b2df1ace4d7a"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("731739b2-3daf-4a5e-b34d-77e41e930a87"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("7addc2c9-fe10-4e49-8e4b-4484c9b08632"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("7d359684-0d90-4949-a4af-d6010b5462f2"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("82632860-3dfe-4bb1-b707-8b5f4c8f9f6a"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("83766c28-b27e-41cf-ad36-e91f06ff430a"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("83fdb392-634b-4ab3-b879-34f38acb35e4"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("851231a8-15d3-4ec1-b1f7-c1ec62f92d67"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("8a540f98-b998-4831-8a8a-be0b367c0233"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("94564d63-e18a-40d3-a49a-44732c6137c2"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("9d2bc86c-d1d5-4a6f-90d2-0c04d0810672"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("a36da4d1-c873-4115-b721-101d6fc2e32b"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("a4798e8e-d9b1-4d3e-95c7-a03d2986b59a"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("b477a07c-3e32-4ad4-99f6-6425f6549cc1"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("b49e9410-be31-4388-bada-7c256d0269a2"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("c0a676c5-5c25-4934-8441-3ac6afab7028"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("e08ab0a2-398f-4d16-aaec-111e4293ece6"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("e2d52631-d7b0-4aa1-b74a-36e023cb26f6"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("e63bba3b-26ac-4b73-84c3-faf330c48e65"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("e74ce1c6-dbc0-45b6-bd04-101bd0a430e6"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("f7e83d7d-3b31-47f7-bb25-f469cb10925c"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("fc500db9-15d4-457c-ad99-eb6542eff1ab"));

            migrationBuilder.DeleteData(
                table: "User_SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("5ae61b37-537a-4600-b277-7224b6327beb"));

            migrationBuilder.DeleteData(
                table: "User_SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("87709196-a2ea-4f46-9c11-f5f394d59378"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("00d7a50f-d03e-439e-98d1-0598edac66c8"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("01736635-6135-4855-ac64-8d506a00b7e3"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("07126d57-4c45-468d-8b79-d63fc0f404fb"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("078b6b41-488e-48de-bd91-e35c00707a71"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("0d79c929-375c-4f12-867f-a2231ece9cb8"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("1121bc0b-c794-493f-b082-a01434bd1600"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("1b677ea6-c7ba-4122-8568-2ac2d1a63775"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("2214731b-3cc1-4e68-ac3c-0f3cd6cdd9de"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("2a3e2976-1a46-4b37-bb72-1407a293c6f2"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("52d2e5a9-6c7b-446a-9eed-2fdceecacba8"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("531e893a-69b0-44f1-a1a5-a78fa45942df"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("55d5154c-0fe0-44e0-a858-dcf84cd722ab"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("5846e310-ed1d-4ceb-ae3f-bbb1acbc5bb7"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("5bbaa8fc-1fa7-4f5e-b794-bc4bb542e475"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("5f8ac962-29de-40a2-ae70-4a9454d13af0"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("74336b5a-99ba-4b9a-a45b-682a738759dd"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("7dfdb4d5-ccf2-4289-a806-f8d6eb446976"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("7e55997c-65c8-4ad8-94cf-f202c70b790e"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("83e7506c-1bce-4745-9fb5-d02bdb97ec55"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("88b7fabd-bdfe-4482-8017-189281262f87"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("89b26a42-7c0b-4ac2-aaf7-cbe966dbfa98"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("a0c607dc-b4a8-48c2-9b50-6c76307ee18f"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("a8bfd73f-60cb-4086-9a9d-5eecc5348b4a"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("ae5de5d2-5907-4c89-954b-5392fc468d61"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("b4a0ac5c-6196-443b-b51a-bb713368a13c"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("b7a709d4-5018-4e63-85af-e1c5aaf0e999"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("cce7167a-c15c-4eeb-8233-ba21c7903b24"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("ce7eab35-5497-4c65-b347-b8946565b7ff"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("d25a6709-4d66-4c71-9f73-5fe8c3f327b9"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("df4f8daf-d2f2-4408-bca6-36817a59e276"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("e5ec4653-de39-4c5f-850a-484c3571fa37"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("ea519d0b-b411-4643-83d4-9f2309ee9f38"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("f20347f9-88ee-441c-a2c2-0be4ac3a12cb"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("1c8c83aa-16e3-4ffd-a15a-9fb68454f537"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("33a0a8ef-474c-4755-9634-810b37c6c3e6"));

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "End", "EnglishDesc", "HasEnglishDesc", "Institute", "IsActual", "NativeDesc", "Start", "TitleName", "Type", "UserId" },
                values: new object[] { new Guid("ecbe3d82-f053-433a-b0d8-87449c5d7323"), null, "Currently at 3rd year with an average of 9/10", true, "Universidad Tecnologica Nacional", true, "Me encuentro en 3er año con un promedio de 9/10", new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ingenieria en Sistemas de Informacion", 1, "00000000000000000000000000000" });

            migrationBuilder.InsertData(
                table: "Experience",
                columns: new[] { "Id", "Company", "End", "EnglishDesc", "HasEnglishDesc", "IsActual", "NativeDesc", "Position", "Start", "Type", "UserId" },
                values: new object[] { new Guid("95c5f5ae-2587-4148-a89d-9c4215435e94"), "Accusys", null, "Management and optimization of queries, tables, stored procedures and views in MS SQL Server databases. I work with technologies such as WPF, Classic ASP, VBS, HTML, Javascript, Java and IIS", true, true, "Manejo y optimización de querys, tablas, stored procedures y vistas en bases de datos MS SQL Server. Trabajo con tecnologías tales como WPF, ASP Clásico, VBS, HTML, Javascript, Java y IIS", "Analista Programador Junior", new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "00000000000000000000000000000" });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "EnglishDesc", "HasEnglishDesc", "Name", "NativeDesc", "Url", "UserId" },
                values: new object[] { new Guid("437db8da-4adb-4aaf-baf1-0551b4e80cd7"), "Personal portfolio made with REACT + Typescript + Tailwindcss + .NET 6 + SQL Server", true, "Portfolio", "Portfolio personal realizado con REACT + Typescript + Tailwindcss + .NET 6 + SQL Server", "https://www.github.com/tiagoramirez", "00000000000000000000000000000" });

            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "Id", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("05a89055-2308-458d-a829-df535a77cbf2"), "JavaScript", 0 },
                    { new Guid("11404bda-ba5e-4092-8153-8688431fcc39"), "HTML", 0 },
                    { new Guid("19982c0b-5e59-4514-8686-eec11f22943e"), "MySql", 1 },
                    { new Guid("1c20bb16-393d-448e-98e7-25395dedcace"), "Angular", 0 },
                    { new Guid("1c5def7e-ddfe-4261-9a5d-487817e3d057"), "Redux Toolkit", 0 },
                    { new Guid("259585db-73ae-4a8b-ba7b-c7be407c3474"), "Node", 2 },
                    { new Guid("27277b58-070f-4e2b-baac-f28a6200715a"), "C#", 1 },
                    { new Guid("32d7cb4c-9e77-4ade-884c-92a9a91db87a"), "Migrations", 1 },
                    { new Guid("380c80ce-9025-4e21-bea4-24ba0d6f8525"), "Scrum", 2 },
                    { new Guid("3ae6184d-e53a-459d-adc7-7f2de62c5e1b"), "Vite", 0 },
                    { new Guid("508435bb-bb2a-4091-9990-bd55297ebb74"), "Testing library", 0 },
                    { new Guid("51823903-9296-43b7-9ee8-dab85c4e29ea"), "Middlewares", 1 },
                    { new Guid("54fc6e67-fb4a-4add-91be-443ac8ee3745"), "React", 0 },
                    { new Guid("56c600f5-c5bf-4988-813a-5f5b5b6a5449"), ".NET WPF", 1 },
                    { new Guid("57999f5c-7934-4d16-b56c-27f2b80ae9fe"), "JWT", 2 },
                    { new Guid("63394645-d9a3-460f-9f47-915107bdabc1"), "Vitest", 0 },
                    { new Guid("7270c665-91f0-45c0-8f8c-9ca814477610"), ".NET CORE 6", 1 },
                    { new Guid("901da623-2221-472b-bc6e-16845a7fce17"), "Java", 1 },
                    { new Guid("91cc9b4c-7ee7-4676-a660-15abf3be770e"), "Java Spring", 1 },
                    { new Guid("9bde1fbe-91f5-4b3d-b230-12dad7feb3f3"), "REST API", 2 },
                    { new Guid("a26fcf30-ce3f-4c7e-9f93-f0dc2f03f84f"), "CSS", 0 },
                    { new Guid("a32286dc-0a4a-415c-af52-b6906faae8e2"), "Bootstrap", 0 },
                    { new Guid("a3e95dae-2c4d-4cff-b937-89b0588f11a6"), "MS SQL Server", 1 },
                    { new Guid("a56f990a-c0d0-486f-8d0f-d086a278e252"), "SQL", 1 },
                    { new Guid("c92798fc-3185-43cf-9127-dad825c12e9c"), "Fluent API", 1 },
                    { new Guid("d1d70f2c-6933-47e6-9e70-cc10f8bce8b2"), "TypeScript", 0 },
                    { new Guid("d386659f-746f-4e57-a52a-3a282e2cb407"), "UML", 2 },
                    { new Guid("d8d67b0e-7bb7-4744-a5a9-71d3e4bd330d"), "Linux", 2 },
                    { new Guid("dab52178-a8b8-4f41-b20c-2d24f156f240"), ".NET API", 1 },
                    { new Guid("de5facb6-323b-413a-b119-2114bc688b27"), "Entity Framework", 1 },
                    { new Guid("df1d3199-2e55-4a4f-8105-65087a83d2a0"), "Git", 2 },
                    { new Guid("e104fa1a-4866-4058-8557-2e7b550c65ed"), "TailwindCss", 0 },
                    { new Guid("e91d1250-4b8c-4580-893b-85e7a5818d9f"), "ERD / DER", 2 },
                    { new Guid("e93827d3-2526-4d3c-989e-84bff8071644"), "React Router", 0 },
                    { new Guid("ef61fdbf-94fc-4463-8852-5a804d60bee7"), "Python", 1 }
                });

            migrationBuilder.InsertData(
                table: "SocialMedia",
                columns: new[] { "Id", "IconClassName", "Name" },
                values: new object[,]
                {
                    { new Guid("18f95ffc-b012-4e33-af96-de92a6ac728d"), "bi bi-facebook", "Facebook" },
                    { new Guid("44989082-ea07-49db-9892-afe921dc7fbe"), "bi bi-instagram", "Instagram" },
                    { new Guid("528978ba-3cbe-4d9f-9b3d-23200ca10eaa"), "bi bi-twitter", "Twitter" },
                    { new Guid("78e464d4-ad11-4db5-936d-e92180abf3dd"), "bi bi-linkedin", "LinkedIn" }
                });

            migrationBuilder.InsertData(
                table: "SocialMedia",
                columns: new[] { "Id", "IconClassName", "Name" },
                values: new object[,]
                {
                    { new Guid("92792965-3020-45b7-b5b6-56fcba6575fe"), "bi bi-person-circle", "Web Personal" },
                    { new Guid("e14fea03-8971-4fad-b7ce-31e81151757d"), "bi bi-whatsapp", "Whatsapp" },
                    { new Guid("e6bce127-a511-4f33-948c-6d00f4a9927e"), "bi bi-youtube", "Youtube" },
                    { new Guid("fcd440d9-da36-4a93-a840-6ee8d22b88c2"), "bi bi-github", "Github" }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "00000000000000000000000000000",
                columns: new[] { "Created", "LocationState" },
                values: new object[] { new DateTime(2023, 3, 1, 14, 21, 39, 274, DateTimeKind.Local).AddTicks(1910), "Chaco" });

            migrationBuilder.InsertData(
                table: "User_Skill",
                columns: new[] { "Id", "Percentage", "SkillId", "UserId" },
                values: new object[] { new Guid("b26ff75e-0556-4d30-b198-8d472ac10fed"), 90, new Guid("27277b58-070f-4e2b-baac-f28a6200715a"), "00000000000000000000000000000" });

            migrationBuilder.InsertData(
                table: "User_SocialMedia",
                columns: new[] { "Id", "SocialMediaId", "Url", "UserId" },
                values: new object[] { new Guid("cc53d1cb-53cb-4b32-bb37-ca512223e639"), new Guid("78e464d4-ad11-4db5-936d-e92180abf3dd"), "https://www.linkedin.com/in/tiagoramirezmar/", "00000000000000000000000000000" });
        }
    }
}
