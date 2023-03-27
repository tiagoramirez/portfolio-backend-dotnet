using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace portfolio.Migrations
{
    public partial class AddedDefaultUserIdFirebase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "00000000000000000000000000000");

            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "Id", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("0fc23861-f119-4b68-bc9f-184f4e6605a8"), "Vite", 0 },
                    { new Guid("168c4c07-3c09-41f8-8524-4592233bbbe0"), "TypeScript", 0 },
                    { new Guid("1d8be24e-6d45-4265-9bf3-a7325844834e"), "Scrum", 2 },
                    { new Guid("1ed46152-83b2-4e9a-a6fe-761b4aa0df5f"), "Node", 2 },
                    { new Guid("241ea3a9-a684-4d16-aac2-3ebf6f1b247f"), "JWT", 2 },
                    { new Guid("30e82877-d60d-4686-bb6b-f820f13e24f7"), "ERD / DER", 2 },
                    { new Guid("32d474ea-de50-4ac2-af59-7a78764cdbd1"), "React", 0 },
                    { new Guid("4d0313cc-37da-48da-95b6-f8a6eec155e8"), "Vitest", 0 },
                    { new Guid("4d58ab3e-5aa2-457e-90e3-9e87238e25fd"), ".NET API", 1 },
                    { new Guid("537dd86f-3600-46e9-ab87-5556fba3e926"), "Entity Framework", 1 },
                    { new Guid("58dce498-8423-4365-b247-6bc96888e07a"), "Git", 2 },
                    { new Guid("5a7d2439-2e74-479c-97a0-7695f677f2d7"), "Python", 1 },
                    { new Guid("5c7bdddf-4d00-4fb8-bf8c-9d3569bb84a6"), "UML", 2 },
                    { new Guid("62c43ee8-b8b1-4f7d-a688-a2b0584810ea"), "Angular", 0 },
                    { new Guid("70ef1eb6-ae3f-49a1-86e3-2573602bfa8b"), "React Router", 0 },
                    { new Guid("720d7c39-7c84-46c5-b406-f233d161f812"), "Testing library", 0 },
                    { new Guid("731cef62-5afb-45f3-91a9-44af718fd5e0"), "HTML", 0 },
                    { new Guid("740617df-d6dd-4b81-a93a-9c71db489c5c"), "MySql", 1 },
                    { new Guid("75960ecf-45ce-4477-8a8d-0584a6fbfe2c"), "JavaScript", 0 },
                    { new Guid("7b9b2d09-0193-4279-b221-5e4b01278dda"), "Java Spring", 1 },
                    { new Guid("7e0d9995-0e25-485e-9949-7f9369966c1f"), "C#", 1 },
                    { new Guid("84b663b6-6794-4e3e-8a51-6aa94d12e649"), ".NET WPF", 1 },
                    { new Guid("89a8b406-f775-4eda-a38d-fff806190dab"), "Bootstrap", 0 },
                    { new Guid("9e5a435d-80d9-42fe-b7a7-4a6f176afe9b"), ".NET CORE 6", 1 },
                    { new Guid("a81e5119-5028-46b3-8a9b-c673c18eed18"), "Java", 1 },
                    { new Guid("af6644fe-0bd9-457d-b72c-6a8bd2274411"), "Migrations", 1 },
                    { new Guid("bb6b27ca-ae1e-4dc9-bee8-e3c6c140aa43"), "CSS", 0 },
                    { new Guid("c06e900c-985a-4781-ac57-34d7e6b822b7"), "TailwindCss", 0 },
                    { new Guid("caff19cb-b84c-471c-acca-51a110350e55"), "Linux", 2 },
                    { new Guid("eb64f068-eb9d-442f-bdcc-c7228a74f476"), "REST API", 2 },
                    { new Guid("ec012913-3410-400f-9add-f034ffe3d524"), "Middlewares", 1 },
                    { new Guid("f2245684-fa41-4288-8383-035d1f3f5fd0"), "MS SQL Server", 1 },
                    { new Guid("f2f9c066-6633-4e88-9758-0a4dc16c9268"), "Fluent API", 1 },
                    { new Guid("f6de97d5-b29a-4b00-9390-3d23bdedd344"), "SQL", 1 },
                    { new Guid("fe5f14d1-1060-4bd8-b422-74cf9417840c"), "Redux Toolkit", 0 }
                });

            migrationBuilder.InsertData(
                table: "SocialMedia",
                columns: new[] { "Id", "IconClassName", "Name" },
                values: new object[,]
                {
                    { new Guid("0cc141d9-ef8a-4016-b2e9-0518d6047e2c"), "bi bi-youtube", "Youtube" },
                    { new Guid("13ef3d42-eeeb-469a-8a55-453a1b1ab4d0"), "bi bi-whatsapp", "Whatsapp" },
                    { new Guid("2d51885d-434e-4a02-bc1e-c548d7633672"), "bi bi-instagram", "Instagram" },
                    { new Guid("41891ccc-8461-47c7-933a-49a33c472581"), "bi bi-person-circle", "Personal" },
                    { new Guid("65fb075c-3e35-4302-ac61-42da71e9040d"), "bi bi-linkedin", "LinkedIn" },
                    { new Guid("7883bc79-de41-44a8-b5fc-8ead2d4eb31b"), "bi bi-facebook", "Facebook" },
                    { new Guid("8d91139d-b0f9-45d9-a0e8-37d8f10866e1"), "bi bi-twitter", "Twitter" }
                });

            migrationBuilder.InsertData(
                table: "SocialMedia",
                columns: new[] { "Id", "IconClassName", "Name" },
                values: new object[] { new Guid("96267af7-cc51-4ca2-a13d-64f954565c0a"), "bi bi-github", "Github" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "Email", "EnglishAboutMe", "EnglishDesc", "HasEnglishAboutMe", "HasEnglishDesc", "IsEnglishModeEnabled", "LocationCountry", "LocationState", "Name", "NativeAboutMe", "NativeDesc", "Phone", "Role", "Status", "Username" },
                values: new object[] { "p7EW1FzwW5hgFi4YTV1mmdHTAnm1", new DateTime(2023, 3, 27, 20, 2, 58, 389, DateTimeKind.Local).AddTicks(6658), "tiagoramirez2001@gmail.com", "Fullstack Web Dev. with 1 year of experience in the IT area. My main stack: React + Typescript + .NET 6 API + SQL Server + Node", "FullStack Web Dev. with +1yr exp. || React + Typescript + .NET 6 + SQL Server + Node || Student in Systems Engineering - UTN (Argentina)", true, true, true, "Argentina", "C.A.B.A.", "Tiago Alberto Ramirez Marchisio", "Fullstack Web Dev. con 1 año de experiencia en el área de TI. Mi stack principal: React + Typescript + .NET 6 API + SQL Server + Node", "FullStack Web Dev. con +1 año de exp. || React + Typescript + .NET 6 + SQL Server + Node || Ingeniería en Sistemas de Información - UTN (Argentina)", null, "USR", true, "tiagoramirez" });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "End", "EnglishDesc", "HasEnglishDesc", "Institute", "IsActual", "NativeDesc", "Start", "TitleName", "Type", "UserId" },
                values: new object[] { new Guid("ef540644-bf77-46b0-ae9b-7d95930e82fa"), null, "Currently at 3rd year with an average of 9/10", true, "Universidad Tecnologica Nacional", true, "Me encuentro en 3er año con un promedio de 9/10", new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ingenieria en Sistemas de Informacion", 1, "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" });

            migrationBuilder.InsertData(
                table: "Experience",
                columns: new[] { "Id", "Company", "End", "EnglishDesc", "HasEnglishDesc", "IsActual", "NativeDesc", "Position", "Start", "Type", "UserId" },
                values: new object[] { new Guid("6245192c-0de8-41c3-bb99-a901e9f29500"), "Accusys", null, "Management and optimization of queries, tables, stored procedures and views in MS SQL Server databases. I work with technologies such as WPF, Classic ASP, VBS, HTML, Javascript, Java and IIS", true, true, "Manejo y optimización de querys, tablas, stored procedures y vistas en bases de datos MS SQL Server. Trabajo con tecnologías tales como WPF, ASP Clásico, VBS, HTML, Javascript, Java y IIS", "Analista Programador Junior", new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "EnglishDesc", "HasEnglishDesc", "Name", "NativeDesc", "Url", "UserId" },
                values: new object[] { new Guid("d7a3e307-1e67-4c7a-a669-79e249f2191c"), "Personal portfolio made with REACT + Typescript + Tailwindcss + .NET 6 + SQL Server", true, "Portfolio", "Portfolio personal realizado con REACT + Typescript + Tailwindcss + .NET 6 + SQL Server", "https://tiagoramirez-portfolio.netlify.app/tiagoramirez", "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" });

            migrationBuilder.InsertData(
                table: "User_Skill",
                columns: new[] { "Id", "Percentage", "SkillId", "UserId" },
                values: new object[,]
                {
                    { new Guid("142613ef-a293-402d-bf2d-ef4c2ad5f492"), 95, new Guid("f2f9c066-6633-4e88-9758-0a4dc16c9268"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("17425902-ea48-422d-9554-2c0656a0fd88"), 90, new Guid("ec012913-3410-400f-9add-f034ffe3d524"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("18ebf1cf-d661-41fc-8656-876beeb41268"), 100, new Guid("30e82877-d60d-4686-bb6b-f820f13e24f7"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("1a8c4349-aae3-43fc-b4db-71e63ba3f464"), 95, new Guid("c06e900c-985a-4781-ac57-34d7e6b822b7"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("26613f2a-d331-4fe9-9f79-961e9487edf7"), 70, new Guid("62c43ee8-b8b1-4f7d-a688-a2b0584810ea"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("3b57fe61-5a00-4d8c-a61e-91a7521e548b"), 90, new Guid("75960ecf-45ce-4477-8a8d-0584a6fbfe2c"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("3e40bfd1-eb72-4f08-a0bb-42a5359abebb"), 80, new Guid("0fc23861-f119-4b68-bc9f-184f4e6605a8"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("40ae4620-ddf7-40fc-ae99-2abdc455f318"), 70, new Guid("740617df-d6dd-4b81-a93a-9c71db489c5c"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("49475a5e-13e0-44b1-aaef-ada31b62d726"), 100, new Guid("af6644fe-0bd9-457d-b72c-6a8bd2274411"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("49acfb52-0080-45da-8025-776acbb54bcd"), 90, new Guid("537dd86f-3600-46e9-ab87-5556fba3e926"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("4acb9555-7759-4728-a8f7-f96920bf639b"), 95, new Guid("32d474ea-de50-4ac2-af59-7a78764cdbd1"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("4e180985-2f54-4d60-912f-391b330c8dea"), 90, new Guid("4d58ab3e-5aa2-457e-90e3-9e87238e25fd"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("50b5c45e-4119-496a-beb2-d44ce4e68ced"), 100, new Guid("5c7bdddf-4d00-4fb8-bf8c-9d3569bb84a6"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("56a0263e-c26b-46f2-b953-d6d98046b31b"), 80, new Guid("bb6b27ca-ae1e-4dc9-bee8-e3c6c140aa43"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("5be873d7-b6c6-4cd1-a9e2-7c151e8dd556"), 90, new Guid("eb64f068-eb9d-442f-bdcc-c7228a74f476"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("67855177-8fdb-4439-87fe-f420dc0aad58"), 75, new Guid("84b663b6-6794-4e3e-8a51-6aa94d12e649"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("691c36fc-10de-4e4b-8f67-a7cda8a04077"), 90, new Guid("58dce498-8423-4365-b247-6bc96888e07a"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("6b36330f-6284-472b-b937-4684c646abb5"), 90, new Guid("241ea3a9-a684-4d16-aac2-3ebf6f1b247f"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("6d284dff-837f-4edc-afe9-4d53e453d6e0"), 70, new Guid("7b9b2d09-0193-4279-b221-5e4b01278dda"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("71877a5e-71d5-41a6-ad7b-479f83526a19"), 100, new Guid("f6de97d5-b29a-4b00-9390-3d23bdedd344"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("79331370-3302-4dad-a852-96bbb991d38e"), 85, new Guid("1ed46152-83b2-4e9a-a6fe-761b4aa0df5f"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("809ee80a-c336-4bb9-9c90-c64a61250716"), 95, new Guid("70ef1eb6-ae3f-49a1-86e3-2573602bfa8b"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("8a7af622-da8d-429e-8f0a-8b9cff61a416"), 80, new Guid("4d0313cc-37da-48da-95b6-f8a6eec155e8"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("8c01f0de-a4e1-4683-8ed9-0c8cbd163539"), 80, new Guid("caff19cb-b84c-471c-acca-51a110350e55"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("8e9968bd-9261-47d4-a719-92e96fd21796"), 90, new Guid("a81e5119-5028-46b3-8a9b-c673c18eed18"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("b4b99fb2-a1f7-4bb1-89a3-c83a12dcacc1"), 100, new Guid("7e0d9995-0e25-485e-9949-7f9369966c1f"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("b57c2eef-a687-43a1-907e-279ff2d4db59"), 100, new Guid("f2245684-fa41-4288-8383-035d1f3f5fd0"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("bdd88aa6-81d0-4b63-959f-b950672e93fd"), 90, new Guid("731cef62-5afb-45f3-91a9-44af718fd5e0"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("cbd8ed3d-304a-44a5-abf6-9d9f779fbd12"), 95, new Guid("fe5f14d1-1060-4bd8-b422-74cf9417840c"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("eccae706-05a3-498a-a1cb-9cd8075e2656"), 80, new Guid("720d7c39-7c84-46c5-b406-f233d161f812"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("f1a7d698-5bfc-4305-8c27-b6caa9c6d6ab"), 100, new Guid("168c4c07-3c09-41f8-8524-4592233bbbe0"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("fc6c15de-d45c-4b80-978f-b9213cdf85a8"), 90, new Guid("1d8be24e-6d45-4265-9bf3-a7325844834e"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("fcffc7de-14b0-4ca5-997f-101f93afc36b"), 90, new Guid("9e5a435d-80d9-42fe-b7a7-4a6f176afe9b"), "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" }
                });

            migrationBuilder.InsertData(
                table: "User_SocialMedia",
                columns: new[] { "Id", "SocialMediaId", "Url", "UserId" },
                values: new object[,]
                {
                    { new Guid("08cb7e33-09b4-4dd9-b166-e1a9abfb38b6"), new Guid("96267af7-cc51-4ca2-a13d-64f954565c0a"), "https://www.github.com/tiagoramirez/", "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" },
                    { new Guid("28c8502c-a944-4a26-a5ba-41205881ca21"), new Guid("65fb075c-3e35-4302-ac61-42da71e9040d"), "https://www.linkedin.com/in/tiagoramirezmar/", "p7EW1FzwW5hgFi4YTV1mmdHTAnm1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "Id",
                keyValue: new Guid("ef540644-bf77-46b0-ae9b-7d95930e82fa"));

            migrationBuilder.DeleteData(
                table: "Experience",
                keyColumn: "Id",
                keyValue: new Guid("6245192c-0de8-41c3-bb99-a901e9f29500"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("d7a3e307-1e67-4c7a-a669-79e249f2191c"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("5a7d2439-2e74-479c-97a0-7695f677f2d7"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("89a8b406-f775-4eda-a38d-fff806190dab"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("0cc141d9-ef8a-4016-b2e9-0518d6047e2c"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("13ef3d42-eeeb-469a-8a55-453a1b1ab4d0"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("2d51885d-434e-4a02-bc1e-c548d7633672"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("41891ccc-8461-47c7-933a-49a33c472581"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("7883bc79-de41-44a8-b5fc-8ead2d4eb31b"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("8d91139d-b0f9-45d9-a0e8-37d8f10866e1"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("142613ef-a293-402d-bf2d-ef4c2ad5f492"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("17425902-ea48-422d-9554-2c0656a0fd88"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("18ebf1cf-d661-41fc-8656-876beeb41268"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("1a8c4349-aae3-43fc-b4db-71e63ba3f464"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("26613f2a-d331-4fe9-9f79-961e9487edf7"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("3b57fe61-5a00-4d8c-a61e-91a7521e548b"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("3e40bfd1-eb72-4f08-a0bb-42a5359abebb"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("40ae4620-ddf7-40fc-ae99-2abdc455f318"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("49475a5e-13e0-44b1-aaef-ada31b62d726"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("49acfb52-0080-45da-8025-776acbb54bcd"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("4acb9555-7759-4728-a8f7-f96920bf639b"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("4e180985-2f54-4d60-912f-391b330c8dea"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("50b5c45e-4119-496a-beb2-d44ce4e68ced"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("56a0263e-c26b-46f2-b953-d6d98046b31b"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("5be873d7-b6c6-4cd1-a9e2-7c151e8dd556"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("67855177-8fdb-4439-87fe-f420dc0aad58"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("691c36fc-10de-4e4b-8f67-a7cda8a04077"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("6b36330f-6284-472b-b937-4684c646abb5"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("6d284dff-837f-4edc-afe9-4d53e453d6e0"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("71877a5e-71d5-41a6-ad7b-479f83526a19"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("79331370-3302-4dad-a852-96bbb991d38e"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("809ee80a-c336-4bb9-9c90-c64a61250716"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("8a7af622-da8d-429e-8f0a-8b9cff61a416"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("8c01f0de-a4e1-4683-8ed9-0c8cbd163539"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("8e9968bd-9261-47d4-a719-92e96fd21796"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("b4b99fb2-a1f7-4bb1-89a3-c83a12dcacc1"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("b57c2eef-a687-43a1-907e-279ff2d4db59"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("bdd88aa6-81d0-4b63-959f-b950672e93fd"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("cbd8ed3d-304a-44a5-abf6-9d9f779fbd12"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("eccae706-05a3-498a-a1cb-9cd8075e2656"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("f1a7d698-5bfc-4305-8c27-b6caa9c6d6ab"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("fc6c15de-d45c-4b80-978f-b9213cdf85a8"));

            migrationBuilder.DeleteData(
                table: "User_Skill",
                keyColumn: "Id",
                keyValue: new Guid("fcffc7de-14b0-4ca5-997f-101f93afc36b"));

            migrationBuilder.DeleteData(
                table: "User_SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("08cb7e33-09b4-4dd9-b166-e1a9abfb38b6"));

            migrationBuilder.DeleteData(
                table: "User_SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("28c8502c-a944-4a26-a5ba-41205881ca21"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("0fc23861-f119-4b68-bc9f-184f4e6605a8"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("168c4c07-3c09-41f8-8524-4592233bbbe0"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("1d8be24e-6d45-4265-9bf3-a7325844834e"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("1ed46152-83b2-4e9a-a6fe-761b4aa0df5f"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("241ea3a9-a684-4d16-aac2-3ebf6f1b247f"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("30e82877-d60d-4686-bb6b-f820f13e24f7"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("32d474ea-de50-4ac2-af59-7a78764cdbd1"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("4d0313cc-37da-48da-95b6-f8a6eec155e8"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("4d58ab3e-5aa2-457e-90e3-9e87238e25fd"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("537dd86f-3600-46e9-ab87-5556fba3e926"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("58dce498-8423-4365-b247-6bc96888e07a"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("5c7bdddf-4d00-4fb8-bf8c-9d3569bb84a6"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("62c43ee8-b8b1-4f7d-a688-a2b0584810ea"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("70ef1eb6-ae3f-49a1-86e3-2573602bfa8b"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("720d7c39-7c84-46c5-b406-f233d161f812"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("731cef62-5afb-45f3-91a9-44af718fd5e0"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("740617df-d6dd-4b81-a93a-9c71db489c5c"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("75960ecf-45ce-4477-8a8d-0584a6fbfe2c"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("7b9b2d09-0193-4279-b221-5e4b01278dda"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("7e0d9995-0e25-485e-9949-7f9369966c1f"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("84b663b6-6794-4e3e-8a51-6aa94d12e649"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("9e5a435d-80d9-42fe-b7a7-4a6f176afe9b"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("a81e5119-5028-46b3-8a9b-c673c18eed18"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("af6644fe-0bd9-457d-b72c-6a8bd2274411"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("bb6b27ca-ae1e-4dc9-bee8-e3c6c140aa43"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("c06e900c-985a-4781-ac57-34d7e6b822b7"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("caff19cb-b84c-471c-acca-51a110350e55"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("eb64f068-eb9d-442f-bdcc-c7228a74f476"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("ec012913-3410-400f-9add-f034ffe3d524"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("f2245684-fa41-4288-8383-035d1f3f5fd0"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("f2f9c066-6633-4e88-9758-0a4dc16c9268"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("f6de97d5-b29a-4b00-9390-3d23bdedd344"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("fe5f14d1-1060-4bd8-b422-74cf9417840c"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("65fb075c-3e35-4302-ac61-42da71e9040d"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("96267af7-cc51-4ca2-a13d-64f954565c0a"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "p7EW1FzwW5hgFi4YTV1mmdHTAnm1");

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
                    { new Guid("4abb1d53-6560-44b0-a693-3d79f9a9a5e5"), "bi bi-whatsapp", "Whatsapp" },
                    { new Guid("7d7c15e4-005b-4728-b734-153a1d618adf"), "bi bi-twitter", "Twitter" },
                    { new Guid("7e5dd30e-ffc8-4521-9735-0718646f5eb9"), "bi bi-facebook", "Facebook" },
                    { new Guid("b2c292ca-b7f2-4b8c-9e75-f6159439ca8d"), "bi bi-youtube", "Youtube" }
                });

            migrationBuilder.InsertData(
                table: "SocialMedia",
                columns: new[] { "Id", "IconClassName", "Name" },
                values: new object[] { new Guid("f404b236-ffa4-46a6-be61-39fe847e2508"), "bi bi-instagram", "Instagram" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "Email", "EnglishAboutMe", "EnglishDesc", "HasEnglishAboutMe", "HasEnglishDesc", "IsEnglishModeEnabled", "LocationCountry", "LocationState", "Name", "NativeAboutMe", "NativeDesc", "Phone", "Role", "Status", "Username" },
                values: new object[] { "00000000000000000000000000000", new DateTime(2023, 3, 15, 14, 41, 19, 468, DateTimeKind.Local).AddTicks(5989), "tiagoramirez2001@gmail.com", "Fullstack Web Dev. with 1 year of experience in the IT area. My main stack: React + Typescript + .NET 6 API + SQL Server + Node", "FullStack Web Dev. with +1yr exp. || React + Typescript + .NET 6 + SQL Server + Node || Student in Systems Engineering - UTN (Argentina)", true, true, true, "Argentina", "C.A.B.A.", "Tiago Alberto Ramirez Marchisio", "Fullstack Web Dev. con 1 año de experiencia en el área de TI. Mi stack principal: React + Typescript + .NET 6 API + SQL Server + Node", "FullStack Web Dev. con +1 año de exp. || React + Typescript + .NET 6 + SQL Server + Node || Ingeniería en Sistemas de Información - UTN (Argentina)", null, "USR", true, "tiagoramirez" });

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
    }
}
