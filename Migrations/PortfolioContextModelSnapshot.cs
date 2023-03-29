﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using portfolio;

#nullable disable

namespace portfolio.Migrations
{
    [DbContext(typeof(PortfolioContext))]
    partial class PortfolioContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
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
                            Id = new Guid("d79fdf42-42d9-49e0-81ab-0330d0ddbf9c"),
                            EnglishDesc = "Currently at 3rd year with an average of 9/10",
                            HasEnglishDesc = true,
                            Institute = "Universidad Tecnologica Nacional",
                            IsActual = true,
                            NativeDesc = "Me encuentro en 3er año con un promedio de 9/10",
                            Start = new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TitleName = "Ingenieria en Sistemas de Informacion",
                            Type = 1,
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
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
                            Id = new Guid("b3bf98c1-1f5d-406c-a8ed-4083ea564af0"),
                            Company = "Accusys",
                            EnglishDesc = "Management and optimization of queries, tables, stored procedures and views in MS SQL Server databases. I work with technologies such as WPF, Classic ASP, VBS, HTML, Javascript, Java and IIS",
                            HasEnglishDesc = true,
                            IsActual = true,
                            NativeDesc = "Manejo y optimización de querys, tablas, stored procedures y vistas en bases de datos MS SQL Server. Trabajo con tecnologías tales como WPF, ASP Clásico, VBS, HTML, Javascript, Java y IIS",
                            Position = "Analista Programador Junior",
                            Start = new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = 0,
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
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
                            Id = new Guid("618bdbcf-7304-492f-a347-b989a6904099"),
                            EnglishDesc = "Personal portfolio made with REACT + Typescript + Tailwindcss + .NET 6 + SQL Server",
                            HasEnglishDesc = true,
                            Name = "Portfolio",
                            NativeDesc = "Portfolio personal realizado con REACT + Typescript + Tailwindcss + .NET 6 + SQL Server",
                            Url = "https://tiagoramirez-portfolio.netlify.app/tiagoramirez",
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
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
                            Id = new Guid("d0938a3f-2bd4-473b-bb10-270531665cd1"),
                            Name = "C#",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("3ac74277-64c2-461e-9097-1cd0d592ea75"),
                            Name = ".NET API",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("014633c5-2767-4736-85fb-1fe8bbab3931"),
                            Name = ".NET CORE 6",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("fc3ddd76-225c-496b-852a-18056bba8401"),
                            Name = ".NET WPF",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("25337d23-87e0-4b04-985c-8d0d17be8093"),
                            Name = "Entity Framework",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("d806b2b4-4727-4f6c-9a69-cd90eac1a419"),
                            Name = "Fluent API",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("1f813416-62f8-4151-a627-4e3809d06992"),
                            Name = "Migrations",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("4fc0941e-d64f-496a-8557-32db7fb4504c"),
                            Name = "Middlewares",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("dea83442-6947-4606-af62-c9feea00dc28"),
                            Name = "Python",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("f35f33ac-b759-49b9-9d53-8b63378b6b9d"),
                            Name = "Java",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("0749acb2-87e8-460c-81ee-ae37676f7b0f"),
                            Name = "Java Spring",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("9823aebc-db4b-4bc1-946e-2c93e89af71b"),
                            Name = "SQL",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("ea323063-81e0-4130-b07d-0b0a19a97c01"),
                            Name = "MS SQL Server",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("f3d75026-0855-41da-b18a-cd207341fe76"),
                            Name = "MySql",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("2f1e14cc-1f52-4b3e-b01b-6cdc1a878f21"),
                            Name = "HTML",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("b8b937df-e02e-436d-977c-243f7fcc97fc"),
                            Name = "CSS",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("487fba6c-0c35-4fa5-af18-53fb0cb922c6"),
                            Name = "Bootstrap",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("ce45c4eb-9f2b-4bf4-a260-cabf77a66197"),
                            Name = "JavaScript",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("bb05f08f-cc32-4cf3-9440-49923d2336d0"),
                            Name = "TypeScript",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("618d696e-3de2-455d-963b-77152fa2fa86"),
                            Name = "Angular",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("26e3c863-f2e1-4dc4-9718-b3dae0a7dd04"),
                            Name = "React",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("53e59760-58ab-402a-a261-1d9d2ad5e709"),
                            Name = "Redux Toolkit",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("d5cedb6c-bdc7-4769-ab44-b75e800cfdf3"),
                            Name = "React Router",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("094ba69d-edee-4fa2-bbd4-8ddc3ebbcde0"),
                            Name = "Vite",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("717c0440-c700-4b12-a431-53c5dca4d96a"),
                            Name = "Vitest",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("61d3a2d5-bd4f-4906-bead-9b61b5437e8d"),
                            Name = "Testing library",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("fa6eff2f-e2cc-42c2-8318-171800dd3540"),
                            Name = "TailwindCss",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("28d8f96e-5a00-4413-8501-7d66eeea97f3"),
                            Name = "Git",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("457012cc-1ee3-4941-8fab-dac9fcdbae1c"),
                            Name = "Scrum",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("8b525a78-81fe-4416-8408-97ecf86654f6"),
                            Name = "ERD / DER",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("c46c4d39-dc74-4fdf-bfab-48cb4aadaa46"),
                            Name = "UML",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("8d80f814-f57c-4786-b139-17616a929ba2"),
                            Name = "JWT",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("ccf97f36-a6e1-44c3-8e4c-3414071a28d9"),
                            Name = "Linux",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("3e8a0e07-bbdb-4a1a-b866-132c22db4cd7"),
                            Name = "REST API",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("755b6b22-a2d4-4533-bce5-5247ce58985e"),
                            Name = "Node",
                            Type = 2
                        });
                });

            modelBuilder.Entity("portfolio.Models.SocialMedia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("SocialMedia", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("78146e6c-8ee4-476a-bd71-268e2a10ef26"),
                            Name = "Github",
                            Url = "https://www.github.com/tiagoramirez/",
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("00eeeead-1e0c-4e90-bfe9-bf81409f8387"),
                            Name = "LinkedIn",
                            Url = "https://www.linkedin.com/in/tiagoramirezmar/",
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
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
                            Id = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1",
                            Created = new DateTime(2023, 3, 29, 1, 31, 47, 188, DateTimeKind.Local).AddTicks(3036),
                            Email = "tiagoramirez2001@gmail.com",
                            EnglishAboutMe = "Fullstack Web Dev. with 1 year of experience in the IT area. My main stack: React + Typescript + .NET 6 API + SQL Server + Node",
                            EnglishDesc = "FullStack Web Dev. with +1yr exp. || React + Typescript + .NET 6 + SQL Server + Node || Student in Systems Engineering - UTN (Argentina)",
                            HasEnglishAboutMe = true,
                            HasEnglishDesc = true,
                            IsEnglishModeEnabled = true,
                            LocationCountry = "Argentina",
                            LocationState = "C.A.B.A.",
                            Name = "Tiago Alberto Ramirez Marchisio",
                            NativeAboutMe = "Fullstack Web Dev. con 1 año de experiencia en el área de TI. Mi stack principal: React + Typescript + .NET 6 API + SQL Server + Node",
                            NativeDesc = "FullStack Web Dev. con +1 año de exp. || React + Typescript + .NET 6 + SQL Server + Node || Ingeniería en Sistemas de Información - UTN (Argentina)",
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
                            Id = new Guid("2f9f6947-c007-4267-b0f1-703aec821665"),
                            Percentage = 100,
                            SkillId = new Guid("d0938a3f-2bd4-473b-bb10-270531665cd1"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("0688b498-14d1-48d3-acbf-d193ffbc63b0"),
                            Percentage = 90,
                            SkillId = new Guid("3ac74277-64c2-461e-9097-1cd0d592ea75"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("11f285a6-9a59-4cc8-895e-f2ed25bf8c58"),
                            Percentage = 90,
                            SkillId = new Guid("014633c5-2767-4736-85fb-1fe8bbab3931"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("b01e5bda-1b0c-4c96-9616-dd7ce6008f5d"),
                            Percentage = 75,
                            SkillId = new Guid("fc3ddd76-225c-496b-852a-18056bba8401"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("c917b886-dcac-45f8-879e-6ae33b5df6b5"),
                            Percentage = 90,
                            SkillId = new Guid("25337d23-87e0-4b04-985c-8d0d17be8093"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("a2ae240d-8e4c-4699-bb9b-42e9cdc92956"),
                            Percentage = 95,
                            SkillId = new Guid("d806b2b4-4727-4f6c-9a69-cd90eac1a419"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("a547e991-f657-423a-9c65-d9dff034ef7b"),
                            Percentage = 100,
                            SkillId = new Guid("1f813416-62f8-4151-a627-4e3809d06992"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("6432879a-6583-4cc2-8c9d-8820741a17d6"),
                            Percentage = 90,
                            SkillId = new Guid("4fc0941e-d64f-496a-8557-32db7fb4504c"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("6e17776a-3b4b-4ba6-ae1f-33b7b4989e45"),
                            Percentage = 90,
                            SkillId = new Guid("f35f33ac-b759-49b9-9d53-8b63378b6b9d"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("3e6468ff-3e3e-44f8-9ea5-53d136867e3d"),
                            Percentage = 70,
                            SkillId = new Guid("0749acb2-87e8-460c-81ee-ae37676f7b0f"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("bded44ff-58bb-4144-87c3-c1d4dec0d9ec"),
                            Percentage = 100,
                            SkillId = new Guid("9823aebc-db4b-4bc1-946e-2c93e89af71b"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("bd52b781-40c6-48ef-a453-25dae8c800c5"),
                            Percentage = 100,
                            SkillId = new Guid("ea323063-81e0-4130-b07d-0b0a19a97c01"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("527255c1-91fe-4159-aade-eb57190d2368"),
                            Percentage = 70,
                            SkillId = new Guid("f3d75026-0855-41da-b18a-cd207341fe76"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("c8d5c425-7ffb-465f-9dcf-4145fd1f93d7"),
                            Percentage = 90,
                            SkillId = new Guid("2f1e14cc-1f52-4b3e-b01b-6cdc1a878f21"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("262f8834-f7ca-4fe8-b699-f069fef575f8"),
                            Percentage = 80,
                            SkillId = new Guid("b8b937df-e02e-436d-977c-243f7fcc97fc"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("c7d09100-ecd9-4e43-977f-c1f4395fd18b"),
                            Percentage = 90,
                            SkillId = new Guid("ce45c4eb-9f2b-4bf4-a260-cabf77a66197"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("1b2f1138-43cf-4a3c-86b3-72eb32fe788d"),
                            Percentage = 100,
                            SkillId = new Guid("bb05f08f-cc32-4cf3-9440-49923d2336d0"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("fcc1f7ca-c146-42d1-b44c-8b8582e148b0"),
                            Percentage = 70,
                            SkillId = new Guid("618d696e-3de2-455d-963b-77152fa2fa86"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("ae8ba168-8b3a-4e0b-b8b2-b38042bba166"),
                            Percentage = 95,
                            SkillId = new Guid("26e3c863-f2e1-4dc4-9718-b3dae0a7dd04"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("b12850c9-e5c1-40c9-80f9-43df14ab316b"),
                            Percentage = 95,
                            SkillId = new Guid("53e59760-58ab-402a-a261-1d9d2ad5e709"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("37060ad4-1b61-45d9-a313-c4eb5292cfa5"),
                            Percentage = 95,
                            SkillId = new Guid("d5cedb6c-bdc7-4769-ab44-b75e800cfdf3"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("c3f148dd-05f7-4850-9c94-f102a7c11559"),
                            Percentage = 80,
                            SkillId = new Guid("094ba69d-edee-4fa2-bbd4-8ddc3ebbcde0"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("83d87ef6-9c3d-40ee-861b-ea50fc8f2498"),
                            Percentage = 80,
                            SkillId = new Guid("717c0440-c700-4b12-a431-53c5dca4d96a"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("93671bb2-456f-4cb7-bfb3-08d4335314b7"),
                            Percentage = 80,
                            SkillId = new Guid("61d3a2d5-bd4f-4906-bead-9b61b5437e8d"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("c4217a9c-0937-4aad-857a-93abaa17dad1"),
                            Percentage = 95,
                            SkillId = new Guid("fa6eff2f-e2cc-42c2-8318-171800dd3540"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("31f4c8e6-3a95-4b5e-869c-c025c62d2551"),
                            Percentage = 90,
                            SkillId = new Guid("28d8f96e-5a00-4413-8501-7d66eeea97f3"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("6380fd1d-4eec-49f5-833c-dd07a5877bd7"),
                            Percentage = 90,
                            SkillId = new Guid("457012cc-1ee3-4941-8fab-dac9fcdbae1c"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("6fbbae4d-4935-4680-9af0-3d10831ebbc7"),
                            Percentage = 100,
                            SkillId = new Guid("8b525a78-81fe-4416-8408-97ecf86654f6"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("4b83855c-fb6b-44f4-8bdb-cd218ae0a8c2"),
                            Percentage = 100,
                            SkillId = new Guid("c46c4d39-dc74-4fdf-bfab-48cb4aadaa46"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("e023a21c-c1a7-46a0-92bf-7594cdfb1683"),
                            Percentage = 90,
                            SkillId = new Guid("8d80f814-f57c-4786-b139-17616a929ba2"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("b9c53b89-9a6d-41c4-b448-4b529f35af33"),
                            Percentage = 80,
                            SkillId = new Guid("ccf97f36-a6e1-44c3-8e4c-3414071a28d9"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("54a9b699-9a86-4f42-b2a9-0b100b135a3d"),
                            Percentage = 90,
                            SkillId = new Guid("3e8a0e07-bbdb-4a1a-b866-132c22db4cd7"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
                        },
                        new
                        {
                            Id = new Guid("a64dc248-e1c7-414b-9a44-a9a98447f8a0"),
                            Percentage = 85,
                            SkillId = new Guid("755b6b22-a2d4-4533-bce5-5247ce58985e"),
                            UserId = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1"
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

            modelBuilder.Entity("portfolio.Models.SocialMedia", b =>
                {
                    b.HasOne("portfolio.Models.User", "User")
                        .WithMany("SocialMedias")
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

            modelBuilder.Entity("portfolio.Models.Skill", b =>
                {
                    b.Navigation("User_Skills");
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
