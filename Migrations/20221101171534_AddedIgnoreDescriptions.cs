using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace portfolio.Migrations
{
    public partial class AddedIgnoreDescriptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("2457aef0-6723-4636-bb39-9867426cf08f"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("d8de9611-dbb4-40e9-b0c2-dac1be12efce"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("00557300-07e0-4910-a68c-d0456a59b774"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("05b622b6-a300-4cab-8ea7-58ce49587556"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("096173a6-0664-47ba-b606-fadfbe585e52"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("0b2dda01-f97f-421e-922c-bb92c751f8e2"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("1fef43f8-acc2-47f7-8da5-b9d4f4857677"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("25ff7bc5-65fb-4ad8-b3f5-dbdecb90b406"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("29be8168-3052-48d9-abe7-f3e1714ce6c1"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("33371bbc-3ac6-479e-a2f2-b3a70dd4ccb1"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("494b6871-75ec-40da-8e0f-e83023b7bb41"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("65544614-4fae-4c61-bbd5-68f1a8be68ae"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("6713afc4-9a32-433f-8cda-904c2cf6a102"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("6cd6f08c-dba8-437a-b614-ab7847c55fc1"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("7eafd4a2-13ff-48cf-bcf8-6a19f18eb52e"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("7f15fb65-7daf-49cd-89e1-af50bca655fd"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("9366e95f-b34c-4f22-8cf3-562ec9eb1ec8"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("98352d16-ac24-4333-95f6-7c8b20af0433"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("9981420e-38d5-4753-90db-8e7a08108498"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("a1b1a919-2c2c-47c2-ba71-941cb987f1b2"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("a5b33aef-8fb1-4d78-9729-095ec5b9cc24"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("ab65021b-2f41-43a8-9bb6-c322cd09b611"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("bf54c219-3871-47d8-aa30-88bf866b9d72"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("dd05f7f4-637d-4e68-a466-925e60639d75"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("ded0cbb6-5b64-416c-9da4-c4989ad287a7"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("f18ad434-b8a8-46d0-bf2c-12be824b3b3e"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("fda68e16-516e-4be4-bf6e-2ac2506ed4e0"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("3df48fad-124d-4a7c-94af-34e732bdcaff"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("66948bab-38df-4cfb-b018-1e7f92c83928"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("6b61b04c-028a-4c1e-92b3-79eededbaf8f"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("7f36414c-063c-44e8-a256-5059d0dfa0e8"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("8614df10-114f-4615-9727-050fb0739e91"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("a1f17d1e-04c5-4dd5-986b-73f496f1646c"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("e3d43a97-b73a-42c1-96ee-e213df1fb40b"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("e479b021-352e-4398-bc73-508be1de0144"));

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { new Guid("328d0ca0-4ba0-4a70-ade2-c054bc7cb0d2"), "User" },
                    { new Guid("ae71fb27-676f-43f0-8cab-0d2209369597"), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "Id", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("02b043f1-c0be-4a74-88dc-5ec271b465f3"), "MS SQL Server", 1 },
                    { new Guid("19d5999e-84cb-4825-bc0f-082ab6c2accd"), "UML", 2 },
                    { new Guid("2473e788-8a72-4a1d-a551-de3fa359afbf"), "Java", 1 },
                    { new Guid("3f713a12-ae3c-474d-9b54-d7763ca35d45"), "Python", 1 },
                    { new Guid("458011cd-0501-41fa-bdf0-a4008f5ae2da"), "MySql", 1 },
                    { new Guid("51d16dc0-c8b2-4ca2-96dd-ce5bfe1add98"), "Scrum", 2 },
                    { new Guid("579cc7d3-76df-4255-a390-9ca98d1d9bfe"), "React", 0 },
                    { new Guid("6639970a-366c-4776-8063-e5640af80c8a"), "Linux", 2 },
                    { new Guid("6d7fad5f-ace2-461a-9e19-76a49d859759"), "C#", 1 },
                    { new Guid("6dbda30a-7cb3-4f8e-8c0b-60294f0dbc7e"), "TypeScript", 0 },
                    { new Guid("72e0093f-eb87-49eb-bb6a-a1522eb54a32"), "JavaScript", 0 },
                    { new Guid("7b1ee93a-fd93-45d7-b5eb-5362b5040ae9"), ".NET WPF", 1 },
                    { new Guid("7e39892f-2670-4a3d-8a74-0ae549520f23"), "Angular", 0 },
                    { new Guid("87a5ef1b-06e6-47e9-b62a-cfb5445f14e8"), "JWT", 2 },
                    { new Guid("97fcce35-a6ea-4123-9c03-44eafc0197ac"), "CSS", 0 },
                    { new Guid("9d590db8-e3d0-46f5-b506-444dc7998815"), "Bootstrap", 0 },
                    { new Guid("cb63a9a4-fc52-4df8-9d8f-2243ec039f92"), "Git", 2 },
                    { new Guid("cf8ba91f-ef54-4aa7-b667-d70280d1c478"), "Java Spring", 1 },
                    { new Guid("d05e500b-6623-49d7-883d-ec45f21a9951"), ".NET", 1 },
                    { new Guid("d3acb776-edb9-4369-aa35-5d87a24bdd73"), "HTML", 0 },
                    { new Guid("e0357e64-6e4b-42f7-9277-3763f9bcbf25"), "JavaScript", 1 },
                    { new Guid("e14f279c-4619-4b1b-83c0-365240c9bc61"), "TypeScript", 1 },
                    { new Guid("e28ba5f0-f130-453c-bcf8-dbd389486544"), "ERD / DER", 2 },
                    { new Guid("e7562007-7022-49bb-86e9-7b3439cfc44b"), "Entity Framework", 1 },
                    { new Guid("f26c9a48-088e-45a3-9318-009a56976db7"), "SQL", 1 }
                });

            migrationBuilder.InsertData(
                table: "SocialMedia",
                columns: new[] { "Id", "IconClassName", "Name" },
                values: new object[,]
                {
                    { new Guid("341c9765-f0fb-47c9-8da6-cddf7733d96e"), "bi bi-facebook", "Facebook" },
                    { new Guid("57aa8cf7-5efb-41ba-8a67-2154f4aa083a"), "bi bi-whatsapp", "Whatsapp" },
                    { new Guid("5f5fdb95-f591-4cf9-9f55-62e08b2a60f1"), "bi bi-linkedin", "LinkedIn" },
                    { new Guid("8d9beed8-371d-458b-9dd8-788e12643b9a"), "bi bi-twitter", "Twitter" },
                    { new Guid("900913d2-1ed5-4bb8-994d-afcf6699d531"), "bi bi-person-circle", "Web Personal" },
                    { new Guid("b53ecc95-f25c-4a03-b47b-ce71bd4fee92"), "bi bi-instagram", "Instagram" },
                    { new Guid("cd061a63-9e6f-4fcb-a558-36768cec8dbe"), "bi bi-github", "Github" },
                    { new Guid("df68facb-b1db-4232-ac8b-b0287220afd6"), "bi bi-youtube", "Youtube" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("328d0ca0-4ba0-4a70-ade2-c054bc7cb0d2"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ae71fb27-676f-43f0-8cab-0d2209369597"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("02b043f1-c0be-4a74-88dc-5ec271b465f3"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("19d5999e-84cb-4825-bc0f-082ab6c2accd"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("2473e788-8a72-4a1d-a551-de3fa359afbf"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("3f713a12-ae3c-474d-9b54-d7763ca35d45"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("458011cd-0501-41fa-bdf0-a4008f5ae2da"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("51d16dc0-c8b2-4ca2-96dd-ce5bfe1add98"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("579cc7d3-76df-4255-a390-9ca98d1d9bfe"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("6639970a-366c-4776-8063-e5640af80c8a"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("6d7fad5f-ace2-461a-9e19-76a49d859759"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("6dbda30a-7cb3-4f8e-8c0b-60294f0dbc7e"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("72e0093f-eb87-49eb-bb6a-a1522eb54a32"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("7b1ee93a-fd93-45d7-b5eb-5362b5040ae9"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("7e39892f-2670-4a3d-8a74-0ae549520f23"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("87a5ef1b-06e6-47e9-b62a-cfb5445f14e8"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("97fcce35-a6ea-4123-9c03-44eafc0197ac"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("9d590db8-e3d0-46f5-b506-444dc7998815"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("cb63a9a4-fc52-4df8-9d8f-2243ec039f92"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("cf8ba91f-ef54-4aa7-b667-d70280d1c478"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("d05e500b-6623-49d7-883d-ec45f21a9951"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("d3acb776-edb9-4369-aa35-5d87a24bdd73"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("e0357e64-6e4b-42f7-9277-3763f9bcbf25"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("e14f279c-4619-4b1b-83c0-365240c9bc61"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("e28ba5f0-f130-453c-bcf8-dbd389486544"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("e7562007-7022-49bb-86e9-7b3439cfc44b"));

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: new Guid("f26c9a48-088e-45a3-9318-009a56976db7"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("341c9765-f0fb-47c9-8da6-cddf7733d96e"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("57aa8cf7-5efb-41ba-8a67-2154f4aa083a"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("5f5fdb95-f591-4cf9-9f55-62e08b2a60f1"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("8d9beed8-371d-458b-9dd8-788e12643b9a"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("900913d2-1ed5-4bb8-994d-afcf6699d531"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("b53ecc95-f25c-4a03-b47b-ce71bd4fee92"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("cd061a63-9e6f-4fcb-a558-36768cec8dbe"));

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: new Guid("df68facb-b1db-4232-ac8b-b0287220afd6"));

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
        }
    }
}
