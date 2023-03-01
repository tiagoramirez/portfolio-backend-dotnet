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
    [Migration("20230301172140_ImprovedDefaultData")]
    partial class ImprovedDefaultData
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

                    b.Property<string>("EnglishDesc")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("HasEnglishDesc")
                        .HasColumnType("bit");

                    b.Property<string>("Institute")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActual")
                        .HasColumnType("bit");

                    b.Property<string>("NativeDesc")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.Property<string>("TitleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Education", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("ecbe3d82-f053-433a-b0d8-87449c5d7323"),
                            EnglishDesc = "Currently at 3rd year with an average of 9/10",
                            HasEnglishDesc = true,
                            Institute = "Universidad Tecnologica Nacional",
                            IsActual = true,
                            NativeDesc = "Me encuentro en 3er año con un promedio de 9/10",
                            Start = new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TitleName = "Ingenieria en Sistemas de Informacion",
                            Type = 1,
                            UserId = "00000000000000000000000000000"
                        });
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

                    b.Property<string>("EnglishDesc")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("HasEnglishDesc")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActual")
                        .HasColumnType("bit");

                    b.Property<string>("NativeDesc")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Experience", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("95c5f5ae-2587-4148-a89d-9c4215435e94"),
                            Company = "Accusys",
                            EnglishDesc = "Management and optimization of queries, tables, stored procedures and views in MS SQL Server databases. I work with technologies such as WPF, Classic ASP, VBS, HTML, Javascript, Java and IIS",
                            HasEnglishDesc = true,
                            IsActual = true,
                            NativeDesc = "Manejo y optimización de querys, tablas, stored procedures y vistas en bases de datos MS SQL Server. Trabajo con tecnologías tales como WPF, ASP Clásico, VBS, HTML, Javascript, Java y IIS",
                            Position = "Analista Programador Junior",
                            Start = new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = 0,
                            UserId = "00000000000000000000000000000"
                        });
                });

            modelBuilder.Entity("portfolio.Models.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EnglishDesc")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("HasEnglishDesc")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NativeDesc")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Url")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Project", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("437db8da-4adb-4aaf-baf1-0551b4e80cd7"),
                            EnglishDesc = "Personal portfolio made with REACT + Typescript + Tailwindcss + .NET 6 + SQL Server",
                            HasEnglishDesc = true,
                            Name = "Portfolio",
                            NativeDesc = "Portfolio personal realizado con REACT + Typescript + Tailwindcss + .NET 6 + SQL Server",
                            Url = "https://www.github.com/tiagoramirez",
                            UserId = "00000000000000000000000000000"
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
                            Id = new Guid("27277b58-070f-4e2b-baac-f28a6200715a"),
                            Name = "C#",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("dab52178-a8b8-4f41-b20c-2d24f156f240"),
                            Name = ".NET API",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("7270c665-91f0-45c0-8f8c-9ca814477610"),
                            Name = ".NET CORE 6",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("56c600f5-c5bf-4988-813a-5f5b5b6a5449"),
                            Name = ".NET WPF",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("de5facb6-323b-413a-b119-2114bc688b27"),
                            Name = "Entity Framework",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("c92798fc-3185-43cf-9127-dad825c12e9c"),
                            Name = "Fluent API",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("32d7cb4c-9e77-4ade-884c-92a9a91db87a"),
                            Name = "Migrations",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("51823903-9296-43b7-9ee8-dab85c4e29ea"),
                            Name = "Middlewares",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("ef61fdbf-94fc-4463-8852-5a804d60bee7"),
                            Name = "Python",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("901da623-2221-472b-bc6e-16845a7fce17"),
                            Name = "Java",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("91cc9b4c-7ee7-4676-a660-15abf3be770e"),
                            Name = "Java Spring",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("a56f990a-c0d0-486f-8d0f-d086a278e252"),
                            Name = "SQL",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("a3e95dae-2c4d-4cff-b937-89b0588f11a6"),
                            Name = "MS SQL Server",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("19982c0b-5e59-4514-8686-eec11f22943e"),
                            Name = "MySql",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("11404bda-ba5e-4092-8153-8688431fcc39"),
                            Name = "HTML",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("a26fcf30-ce3f-4c7e-9f93-f0dc2f03f84f"),
                            Name = "CSS",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("a32286dc-0a4a-415c-af52-b6906faae8e2"),
                            Name = "Bootstrap",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("05a89055-2308-458d-a829-df535a77cbf2"),
                            Name = "JavaScript",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("d1d70f2c-6933-47e6-9e70-cc10f8bce8b2"),
                            Name = "TypeScript",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("1c20bb16-393d-448e-98e7-25395dedcace"),
                            Name = "Angular",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("54fc6e67-fb4a-4add-91be-443ac8ee3745"),
                            Name = "React",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("1c5def7e-ddfe-4261-9a5d-487817e3d057"),
                            Name = "Redux Toolkit",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("e93827d3-2526-4d3c-989e-84bff8071644"),
                            Name = "React Router",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("3ae6184d-e53a-459d-adc7-7f2de62c5e1b"),
                            Name = "Vite",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("63394645-d9a3-460f-9f47-915107bdabc1"),
                            Name = "Vitest",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("508435bb-bb2a-4091-9990-bd55297ebb74"),
                            Name = "Testing library",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("e104fa1a-4866-4058-8557-2e7b550c65ed"),
                            Name = "TailwindCss",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("df1d3199-2e55-4a4f-8105-65087a83d2a0"),
                            Name = "Git",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("380c80ce-9025-4e21-bea4-24ba0d6f8525"),
                            Name = "Scrum",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("e91d1250-4b8c-4580-893b-85e7a5818d9f"),
                            Name = "ERD / DER",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("d386659f-746f-4e57-a52a-3a282e2cb407"),
                            Name = "UML",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("57999f5c-7934-4d16-b56c-27f2b80ae9fe"),
                            Name = "JWT",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("d8d67b0e-7bb7-4744-a5a9-71d3e4bd330d"),
                            Name = "Linux",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("9bde1fbe-91f5-4b3d-b230-12dad7feb3f3"),
                            Name = "REST API",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("259585db-73ae-4a8b-ba7b-c7be407c3474"),
                            Name = "Node",
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
                            Id = new Guid("18f95ffc-b012-4e33-af96-de92a6ac728d"),
                            IconClassName = "bi bi-facebook",
                            Name = "Facebook"
                        },
                        new
                        {
                            Id = new Guid("e14fea03-8971-4fad-b7ce-31e81151757d"),
                            IconClassName = "bi bi-whatsapp",
                            Name = "Whatsapp"
                        },
                        new
                        {
                            Id = new Guid("fcd440d9-da36-4a93-a840-6ee8d22b88c2"),
                            IconClassName = "bi bi-github",
                            Name = "Github"
                        },
                        new
                        {
                            Id = new Guid("44989082-ea07-49db-9892-afe921dc7fbe"),
                            IconClassName = "bi bi-instagram",
                            Name = "Instagram"
                        },
                        new
                        {
                            Id = new Guid("78e464d4-ad11-4db5-936d-e92180abf3dd"),
                            IconClassName = "bi bi-linkedin",
                            Name = "LinkedIn"
                        },
                        new
                        {
                            Id = new Guid("528978ba-3cbe-4d9f-9b3d-23200ca10eaa"),
                            IconClassName = "bi bi-twitter",
                            Name = "Twitter"
                        },
                        new
                        {
                            Id = new Guid("e6bce127-a511-4f33-948c-6d00f4a9927e"),
                            IconClassName = "bi bi-youtube",
                            Name = "Youtube"
                        },
                        new
                        {
                            Id = new Guid("92792965-3020-45b7-b5b6-56fcba6575fe"),
                            IconClassName = "bi bi-person-circle",
                            Name = "Web Personal"
                        });
                });

            modelBuilder.Entity("portfolio.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EnglishAboutMe")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("EnglishDesc")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("HasEnglishAboutMe")
                        .HasColumnType("bit");

                    b.Property<bool>("HasEnglishDesc")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEnglishModeEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("LocationCountry")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LocationState")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NativeAboutMe")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("NativeDesc")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Phone")
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("User", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "00000000000000000000000000000",
                            Created = new DateTime(2023, 3, 1, 14, 21, 39, 274, DateTimeKind.Local).AddTicks(1910),
                            Email = "tiagoramirez2001@gmail.com",
                            EnglishAboutMe = "Fullstack Web Dev. with 1 year of experience in the IT area. My main stack: React + Typescript + .NET 6 API + SQL Server + Node",
                            EnglishDesc = "FullStack Web Dev. with +1yr exp. || React + Typescript + .NET 6 + SQL Server + Node || Student in Systems Engineering - UTN (Argentina)",
                            HasEnglishAboutMe = true,
                            HasEnglishDesc = true,
                            IsEnglishModeEnabled = true,
                            LocationCountry = "Argentina",
                            LocationState = "Chaco",
                            Name = "Tiago Alberto Ramirez Marchisio",
                            NativeAboutMe = "Fullstack Web Dev. con 1 año de experiencia en el área de TI. Mi stack principal: React + Typescript + .NET 6 API + SQL Server + Node",
                            NativeDesc = "FullStack Web Dev. con +1 año de exp. || React + Typescript + .NET 6 + SQL Server + Node || Ingeniería en Sistemas de Información - UTN (Argentina)",
                            Role = "USR",
                            Status = true,
                            Username = "tiagoramirez"
                        });
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

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("SkillId");

                    b.HasIndex("UserId");

                    b.ToTable("User_Skill", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("b26ff75e-0556-4d30-b198-8d472ac10fed"),
                            Percentage = 90,
                            SkillId = new Guid("27277b58-070f-4e2b-baac-f28a6200715a"),
                            UserId = "00000000000000000000000000000"
                        });
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

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("SocialMediaId");

                    b.HasIndex("UserId");

                    b.ToTable("User_SocialMedia", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("cc53d1cb-53cb-4b32-bb37-ca512223e639"),
                            SocialMediaId = new Guid("78e464d4-ad11-4db5-936d-e92180abf3dd"),
                            Url = "https://www.linkedin.com/in/tiagoramirezmar/",
                            UserId = "00000000000000000000000000000"
                        });
                });

            modelBuilder.Entity("portfolio.Models.Education", b =>
                {
                    b.HasOne("portfolio.Models.User", "User")
                        .WithMany("Educations")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("portfolio.Models.Experience", b =>
                {
                    b.HasOne("portfolio.Models.User", "User")
                        .WithMany("Experiences")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("portfolio.Models.Project", b =>
                {
                    b.HasOne("portfolio.Models.User", "User")
                        .WithMany("Projects")
                        .HasForeignKey("UserId");

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
                        .HasForeignKey("UserId");

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
                        .HasForeignKey("UserId");

                    b.Navigation("SocialMedia");

                    b.Navigation("User");
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

                    b.Navigation("Projects");

                    b.Navigation("Skills");

                    b.Navigation("SocialMedias");
                });
#pragma warning restore 612, 618
        }
    }
}
