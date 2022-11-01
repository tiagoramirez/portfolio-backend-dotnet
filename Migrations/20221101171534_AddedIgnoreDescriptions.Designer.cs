﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using portfolio;

#nullable disable

namespace portfolio.Migrations
{
    [DbContext(typeof(PortfolioContext))]
    [Migration("20221101171534_AddedIgnoreDescriptions")]
    partial class AddedIgnoreDescriptions
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("portfolio.Models.Education", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("End")
                        .HasColumnType("datetime2");

                    b.Property<string>("Institute")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActual")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.Property<string>("TitleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Education", (string)null);
                });

            modelBuilder.Entity("portfolio.Models.Education_Description", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("EducationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EducationId");

                    b.HasIndex("ProfileId");

                    b.ToTable("Education_Description", (string)null);
                });

            modelBuilder.Entity("portfolio.Models.Experience", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("End")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActual")
                        .HasColumnType("bit");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Experience", (string)null);
                });

            modelBuilder.Entity("portfolio.Models.Experience_Description", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("ExperienceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ExperienceId");

                    b.HasIndex("ProfileId");

                    b.ToTable("Experience_Description", (string)null);
                });

            modelBuilder.Entity("portfolio.Models.Profile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AboutMe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("LocationCountry")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LocationState")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<Guid>("ProfileConfigId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProfileConfigId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Profile", (string)null);
                });

            modelBuilder.Entity("portfolio.Models.ProfileConfig", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("ShowBanner")
                        .HasColumnType("bit");

                    b.Property<bool>("ShowLocation")
                        .HasColumnType("bit");

                    b.Property<bool>("ShowPhone")
                        .HasColumnType("bit");

                    b.Property<bool>("ShowPhoto")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("ProfileConfig", (string)null);
                });

            modelBuilder.Entity("portfolio.Models.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Url")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Project", (string)null);
                });

            modelBuilder.Entity("portfolio.Models.Project_Description", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Project_Description", (string)null);
                });

            modelBuilder.Entity("portfolio.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Role", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("ae71fb27-676f-43f0-8cab-0d2209369597"),
                            RoleName = "Admin"
                        },
                        new
                        {
                            Id = new Guid("328d0ca0-4ba0-4a70-ade2-c054bc7cb0d2"),
                            RoleName = "User"
                        });
                });

            modelBuilder.Entity("portfolio.Models.Skill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Skill", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("6d7fad5f-ace2-461a-9e19-76a49d859759"),
                            Name = "C#",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("d05e500b-6623-49d7-883d-ec45f21a9951"),
                            Name = ".NET",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("7b1ee93a-fd93-45d7-b5eb-5362b5040ae9"),
                            Name = ".NET WPF",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("e7562007-7022-49bb-86e9-7b3439cfc44b"),
                            Name = "Entity Framework",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("3f713a12-ae3c-474d-9b54-d7763ca35d45"),
                            Name = "Python",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("2473e788-8a72-4a1d-a551-de3fa359afbf"),
                            Name = "Java",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("cf8ba91f-ef54-4aa7-b667-d70280d1c478"),
                            Name = "Java Spring",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("f26c9a48-088e-45a3-9318-009a56976db7"),
                            Name = "SQL",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("02b043f1-c0be-4a74-88dc-5ec271b465f3"),
                            Name = "MS SQL Server",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("458011cd-0501-41fa-bdf0-a4008f5ae2da"),
                            Name = "MySql",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("d3acb776-edb9-4369-aa35-5d87a24bdd73"),
                            Name = "HTML",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("97fcce35-a6ea-4123-9c03-44eafc0197ac"),
                            Name = "CSS",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("9d590db8-e3d0-46f5-b506-444dc7998815"),
                            Name = "Bootstrap",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("72e0093f-eb87-49eb-bb6a-a1522eb54a32"),
                            Name = "JavaScript",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("e0357e64-6e4b-42f7-9277-3763f9bcbf25"),
                            Name = "JavaScript",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("6dbda30a-7cb3-4f8e-8c0b-60294f0dbc7e"),
                            Name = "TypeScript",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("e14f279c-4619-4b1b-83c0-365240c9bc61"),
                            Name = "TypeScript",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("7e39892f-2670-4a3d-8a74-0ae549520f23"),
                            Name = "Angular",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("579cc7d3-76df-4255-a390-9ca98d1d9bfe"),
                            Name = "React",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("cb63a9a4-fc52-4df8-9d8f-2243ec039f92"),
                            Name = "Git",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("51d16dc0-c8b2-4ca2-96dd-ce5bfe1add98"),
                            Name = "Scrum",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("e28ba5f0-f130-453c-bcf8-dbd389486544"),
                            Name = "ERD / DER",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("19d5999e-84cb-4825-bc0f-082ab6c2accd"),
                            Name = "UML",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("87a5ef1b-06e6-47e9-b62a-cfb5445f14e8"),
                            Name = "JWT",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("6639970a-366c-4776-8063-e5640af80c8a"),
                            Name = "Linux",
                            Type = 2
                        });
                });

            modelBuilder.Entity("portfolio.Models.SocialMedia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("IconClassName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("SocialMedia", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("341c9765-f0fb-47c9-8da6-cddf7733d96e"),
                            IconClassName = "bi bi-facebook",
                            Name = "Facebook"
                        },
                        new
                        {
                            Id = new Guid("57aa8cf7-5efb-41ba-8a67-2154f4aa083a"),
                            IconClassName = "bi bi-whatsapp",
                            Name = "Whatsapp"
                        },
                        new
                        {
                            Id = new Guid("cd061a63-9e6f-4fcb-a558-36768cec8dbe"),
                            IconClassName = "bi bi-github",
                            Name = "Github"
                        },
                        new
                        {
                            Id = new Guid("b53ecc95-f25c-4a03-b47b-ce71bd4fee92"),
                            IconClassName = "bi bi-instagram",
                            Name = "Instagram"
                        },
                        new
                        {
                            Id = new Guid("5f5fdb95-f591-4cf9-9f55-62e08b2a60f1"),
                            IconClassName = "bi bi-linkedin",
                            Name = "LinkedIn"
                        },
                        new
                        {
                            Id = new Guid("8d9beed8-371d-458b-9dd8-788e12643b9a"),
                            IconClassName = "bi bi-twitter",
                            Name = "Twitter"
                        },
                        new
                        {
                            Id = new Guid("df68facb-b1db-4232-ac8b-b0287220afd6"),
                            IconClassName = "bi bi-youtube",
                            Name = "Youtube"
                        },
                        new
                        {
                            Id = new Guid("900913d2-1ed5-4bb8-994d-afcf6699d531"),
                            IconClassName = "bi bi-person-circle",
                            Name = "Web Personal"
                        });
                });

            modelBuilder.Entity("portfolio.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("portfolio.Models.User_Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("User_Role", (string)null);
                });

            modelBuilder.Entity("portfolio.Models.User_Skill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Percentage")
                        .HasColumnType("int");

                    b.Property<Guid>("SkillId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SkillId");

                    b.HasIndex("UserId");

                    b.ToTable("User_Skill", (string)null);
                });

            modelBuilder.Entity("portfolio.Models.User_SocialMedia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SocialMediaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SocialMediaId");

                    b.HasIndex("UserId");

                    b.ToTable("User_SocialMedia", (string)null);
                });

            modelBuilder.Entity("portfolio.Models.Education", b =>
                {
                    b.HasOne("portfolio.Models.User", "User")
                        .WithMany("Educations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("portfolio.Models.Education_Description", b =>
                {
                    b.HasOne("portfolio.Models.Education", "Education")
                        .WithMany("Descriptions")
                        .HasForeignKey("EducationId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("portfolio.Models.Profile", "Profile")
                        .WithMany("EducationDescriptions")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Education");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("portfolio.Models.Experience", b =>
                {
                    b.HasOne("portfolio.Models.User", "User")
                        .WithMany("Experiences")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("portfolio.Models.Experience_Description", b =>
                {
                    b.HasOne("portfolio.Models.Experience", "Experience")
                        .WithMany("Descriptions")
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("portfolio.Models.Profile", "Profile")
                        .WithMany("ExperienceDescriptions")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Experience");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("portfolio.Models.Profile", b =>
                {
                    b.HasOne("portfolio.Models.ProfileConfig", "Config")
                        .WithOne("Profile")
                        .HasForeignKey("portfolio.Models.Profile", "ProfileConfigId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("portfolio.Models.User", "User")
                        .WithMany("Profiles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Config");

                    b.Navigation("User");
                });

            modelBuilder.Entity("portfolio.Models.Project", b =>
                {
                    b.HasOne("portfolio.Models.User", "User")
                        .WithMany("Projects")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("portfolio.Models.Project_Description", b =>
                {
                    b.HasOne("portfolio.Models.Profile", "Profile")
                        .WithMany("ProjectDescriptions")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("portfolio.Models.Project", "Project")
                        .WithMany("Descriptions")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Profile");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("portfolio.Models.User_Role", b =>
                {
                    b.HasOne("portfolio.Models.Role", "Role")
                        .WithMany("User_Roles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("portfolio.Models.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("portfolio.Models.User_Skill", b =>
                {
                    b.HasOne("portfolio.Models.Skill", "Skill")
                        .WithMany("User_Skills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("portfolio.Models.User", "User")
                        .WithMany("Skills")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Skill");

                    b.Navigation("User");
                });

            modelBuilder.Entity("portfolio.Models.User_SocialMedia", b =>
                {
                    b.HasOne("portfolio.Models.SocialMedia", "SocialMedia")
                        .WithMany("User_SocialMedias")
                        .HasForeignKey("SocialMediaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("portfolio.Models.User", "User")
                        .WithMany("SocialMedias")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SocialMedia");

                    b.Navigation("User");
                });

            modelBuilder.Entity("portfolio.Models.Education", b =>
                {
                    b.Navigation("Descriptions");
                });

            modelBuilder.Entity("portfolio.Models.Experience", b =>
                {
                    b.Navigation("Descriptions");
                });

            modelBuilder.Entity("portfolio.Models.Profile", b =>
                {
                    b.Navigation("EducationDescriptions");

                    b.Navigation("ExperienceDescriptions");

                    b.Navigation("ProjectDescriptions");
                });

            modelBuilder.Entity("portfolio.Models.ProfileConfig", b =>
                {
                    b.Navigation("Profile");
                });

            modelBuilder.Entity("portfolio.Models.Project", b =>
                {
                    b.Navigation("Descriptions");
                });

            modelBuilder.Entity("portfolio.Models.Role", b =>
                {
                    b.Navigation("User_Roles");
                });

            modelBuilder.Entity("portfolio.Models.Skill", b =>
                {
                    b.Navigation("User_Skills");
                });

            modelBuilder.Entity("portfolio.Models.SocialMedia", b =>
                {
                    b.Navigation("User_SocialMedias");
                });

            modelBuilder.Entity("portfolio.Models.User", b =>
                {
                    b.Navigation("Educations");

                    b.Navigation("Experiences");

                    b.Navigation("Profiles");

                    b.Navigation("Projects");

                    b.Navigation("Roles");

                    b.Navigation("Skills");

                    b.Navigation("SocialMedias");
                });
#pragma warning restore 612, 618
        }
    }
}
