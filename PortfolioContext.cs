using Microsoft.EntityFrameworkCore;
using portfolio.Models;

namespace portfolio;

public class PortfolioContext : DbContext
{
    public DbSet<Education> Educations { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<User_Skill> User_Skills { get; set; }
    public DbSet<SocialMedia> Social_Medias { get; set; }
    public DbSet<User> Users { get; set; }

    public PortfolioContext(DbContextOptions<PortfolioContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        List<Skill> skills = new List<Skill>();
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "C#", Type = SkillType.BACKEND });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = ".NET API", Type = SkillType.BACKEND });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = ".NET CORE 6", Type = SkillType.BACKEND });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = ".NET WPF", Type = SkillType.BACKEND });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Entity Framework", Type = SkillType.BACKEND });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Fluent API", Type = SkillType.BACKEND });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Migrations", Type = SkillType.BACKEND });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Middlewares", Type = SkillType.BACKEND });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Python", Type = SkillType.BACKEND });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Java", Type = SkillType.BACKEND });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Java Spring", Type = SkillType.BACKEND });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "SQL", Type = SkillType.BACKEND });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "MS SQL Server", Type = SkillType.BACKEND });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "MySql", Type = SkillType.BACKEND });

        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "HTML", Type = SkillType.FRONTEND });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "CSS", Type = SkillType.FRONTEND });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Bootstrap", Type = SkillType.FRONTEND });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "JavaScript", Type = SkillType.FRONTEND });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "TypeScript", Type = SkillType.FRONTEND });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Angular", Type = SkillType.FRONTEND });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "React", Type = SkillType.FRONTEND });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Redux Toolkit", Type = SkillType.FRONTEND });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "React Router", Type = SkillType.FRONTEND });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Vite", Type = SkillType.FRONTEND });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Vitest", Type = SkillType.FRONTEND });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Testing library", Type = SkillType.FRONTEND });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "TailwindCss", Type = SkillType.FRONTEND });

        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Git", Type = SkillType.DEVELOPER_TOOL });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Scrum", Type = SkillType.DEVELOPER_TOOL });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Entity Relationship Diagram", Type = SkillType.DEVELOPER_TOOL });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "UML", Type = SkillType.DEVELOPER_TOOL });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "JWT", Type = SkillType.DEVELOPER_TOOL });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Linux", Type = SkillType.DEVELOPER_TOOL });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "REST API", Type = SkillType.DEVELOPER_TOOL });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Node", Type = SkillType.DEVELOPER_TOOL });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "POO", Type = SkillType.DEVELOPER_TOOL });

        modelBuilder.Entity<Skill>(skill =>
        {
            skill.ToTable("Skill");
            skill.HasKey(table => table.Id);
            skill.HasMany(table => table.User_Skills).WithOne(user_skill => user_skill.Skill).HasForeignKey(user_skill => user_skill.SkillId);
            skill.Property(table => table.Id);
            skill.Property(table => table.Name).IsRequired().HasMaxLength(50);
            skill.Property(table => table.Type).IsRequired();
            skill.HasData(skills);
        });

        List<User> users = new List<User>();
        users.Add(new User
        {
            Id = "p7EW1FzwW5hgFi4YTV1mmdHTAnm1",
            Name = "Tiago Alberto Ramirez Marchisio",
            Email = "tiagoramirez2001@gmail.com",
            Username = "tiagoramirez",
            Status = true,
            Created = DateTime.Now,
            IsEnglishModeEnabled = true,
            NativeDesc = "FullStack Dev. || React + Typescript + .NET 6 + SQL Server + Node.js || Ing. en Sistemas de Información - UTN 🇦🇷",
            HasEnglishDesc = true,
            EnglishDesc = "FullStack Dev. || React + Typescript + .NET 6 + SQL Server + Node.js || Student in Systems Engineering - UTN 🇦🇷",
            LocationCountry = "Argentina",
            LocationState = "C.A.B.A.",
            NativeAboutMe = "Soy Fullstack Developer con 1 año de experiencia en el área de TI.\n\nMi stack principal: React.js + Typescript + Node.js + .NET 6 API + SQL Server",
            HasEnglishAboutMe = true,
            EnglishAboutMe = "I'm Fullstack Developer with 1 year of experience in the IT area.\n\nMy main stack: React.js + Typescript + Node.js + .NET 6 API + SQL Server"
        });

        modelBuilder.Entity<User>(user =>
        {
            user.ToTable("User");
            user.HasKey(table => table.Id);
            user.HasMany(table => table.Educations).WithOne(educ => educ.User).HasForeignKey(educ => educ.UserId);
            user.HasMany(table => table.Experiences).WithOne(exp => exp.User).HasForeignKey(exp => exp.UserId);
            user.HasMany(table => table.Projects).WithOne(project => project.User).HasForeignKey(project => project.UserId);
            user.HasMany(table => table.Skills).WithOne(user_skill => user_skill.User).HasForeignKey(user_skill => user_skill.UserId);
            user.HasMany(table => table.SocialMedias).WithOne(user_socialMedia => user_socialMedia.User).HasForeignKey(user_socialMedia => user_socialMedia.UserId);
            user.Property(table => table.Id);
            user.Property(table => table.Name).IsRequired().HasMaxLength(50);
            user.Property(table => table.Email).IsRequired().HasMaxLength(100);
            user.Property(table => table.Username).IsRequired().HasMaxLength(15);
            user.Property(table => table.Status).IsRequired();
            user.Property(table => table.IsEnglishModeEnabled).IsRequired();
            user.Property(table => table.NativeDesc).IsRequired().HasMaxLength(255);
            user.Property(table => table.HasEnglishDesc).IsRequired();
            user.Property(table => table.EnglishDesc).IsRequired(false).HasMaxLength(255);
            user.Property(table => table.LocationCountry).IsRequired(false).HasMaxLength(50);
            user.Property(table => table.LocationState).IsRequired(false).HasMaxLength(50);
            user.Property(table => table.NativeAboutMe).IsRequired().HasMaxLength(500);
            user.Property(table => table.HasEnglishAboutMe).IsRequired();
            user.Property(table => table.EnglishAboutMe).IsRequired(false).HasMaxLength(500);
            user.HasData(users);
        });

        List<User_Skill> userSkills = new List<User_Skill>();
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[0].Id, Percentage = 100 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[1].Id, Percentage = 90 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[2].Id, Percentage = 90 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[3].Id, Percentage = 75 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[4].Id, Percentage = 90 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[5].Id, Percentage = 95 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[6].Id, Percentage = 100 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[7].Id, Percentage = 90 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[9].Id, Percentage = 90 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[10].Id, Percentage = 70 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[11].Id, Percentage = 100 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[12].Id, Percentage = 100 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[13].Id, Percentage = 70 });

        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[14].Id, Percentage = 90 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[15].Id, Percentage = 80 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[17].Id, Percentage = 90 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[18].Id, Percentage = 100 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[19].Id, Percentage = 70 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[20].Id, Percentage = 95 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[21].Id, Percentage = 95 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[22].Id, Percentage = 95 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[23].Id, Percentage = 80 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[24].Id, Percentage = 80 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[25].Id, Percentage = 80 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[26].Id, Percentage = 95 });

        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[27].Id, Percentage = 90 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[28].Id, Percentage = 90 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[29].Id, Percentage = 100 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[30].Id, Percentage = 100 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[31].Id, Percentage = 90 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[32].Id, Percentage = 80 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[33].Id, Percentage = 90 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[34].Id, Percentage = 85 });
        userSkills.Add(new User_Skill { Id = Guid.NewGuid(), UserId = users[0].Id, SkillId = skills[35].Id, Percentage = 100 });

        modelBuilder.Entity<User_Skill>(userSkill =>
        {
            userSkill.ToTable("User_Skill");
            userSkill.HasKey(table => table.Id);
            userSkill.HasOne(table => table.User).WithMany(user => user.Skills).HasForeignKey(user_skill => user_skill.UserId);
            userSkill.HasOne(table => table.Skill).WithMany(skill => skill.User_Skills).HasForeignKey(user_skill => user_skill.SkillId);
            userSkill.Property(table => table.Id);
            userSkill.Property(table => table.Percentage).IsRequired();
            userSkill.HasData(userSkills);
        });

        List<SocialMedia> socialMedias = new List<SocialMedia>();
        socialMedias.Add(new SocialMedia
        {
            Id = Guid.NewGuid(),
            UserId = users[0].Id,
            Name = SocialMediaName.GITHUB,
            Url = "https://www.github.com/tiagoramirez/"
        });
        socialMedias.Add(new SocialMedia
        {
            Id = Guid.NewGuid(),
            UserId = users[0].Id,
            Name = SocialMediaName.LINKEDIN,
            Url = "https://www.linkedin.com/in/tiagoramirezmar/"
        });

        modelBuilder.Entity<SocialMedia>(userSocialMedia =>
        {
            userSocialMedia.ToTable("SocialMedia");
            userSocialMedia.HasKey(table => table.Id);
            userSocialMedia.HasOne(table => table.User).WithMany(user => user.SocialMedias).HasForeignKey(user_socialMedia => user_socialMedia.UserId);
            userSocialMedia.Property(table => table.Id);
            userSocialMedia.Property(table => table.Name).IsRequired().HasMaxLength(20);
            userSocialMedia.Property(table => table.Url).IsRequired().HasMaxLength(255);
            userSocialMedia.HasData(socialMedias);
        });

        List<Education> educations = new List<Education>();
        educations.Add(new Education
        {
            Id = Guid.NewGuid(),
            UserId = users[0].Id,
            Institute = "Universidad Tecnologica Nacional",
            TitleName = "Ingenieria en Sistemas de Informacion",
            IsActual = true,
            Type = EducationType.COLLEGE,
            Start = new DateTime(2020, 4, 1),
            End = null,
            NativeDesc = "Me encuentro en 3er año con un promedio de 9/10.",
            HasEnglishDesc = true,
            EnglishDesc = "Currently at 3rd year with an average of 9/10."
        });
        educations.Add(new Education
        {
            Id = Guid.NewGuid(),
            UserId = users[0].Id,
            Institute = "Argentina Programa - INTI",
            TitleName = "Argentina Programa #YoProgramo",
            IsActual = false,
            Type = EducationType.COURSE,
            Start = new DateTime(2022, 2, 1),
            End = new DateTime(2022, 10, 1),
            NativeDesc = "Temas:\n- Introducción a Desarrollo Web y Aplicaciones\n- Desarrollo Front End Estático (HTML, CSS, BOOTSTRAP, JavaScript y TypeScript)\n- Desarrollo Front End Dinámico (Angular)\n- Desarrollo Back End (MySQL+ Java Spring)\n- Diagrama Entidad Relación\n- JWT\n- DevOps",
            HasEnglishDesc = true,
            EnglishDesc = "Topics:\n- Web Development and Applications (Introduction)\n- Static Front End Development (HTML, CSS, BOOTSTRAP, JavaScript y TypeScript)\n- Dynamic Front End Development (Angular)\n- BACKEND Development (MySQL + Java Spring)\n- Entity Relationship Diagram\n- JWT\n- DevOps"
        });
        educations.Add(new Education
        {
            Id = Guid.NewGuid(),
            UserId = users[0].Id,
            Institute = "Universidad Tecnologica Nacional FRBA",
            TitleName = "Desarrollador .NET",
            IsActual = false,
            Type = EducationType.COURSE,
            Start = new DateTime(2021, 10, 1),
            End = new DateTime(2021, 12, 1),
            NativeDesc = "Aprendimos: C#, POO, UML, .NET Framework, Entity Framework, Sql Server.\nProyecto final: https://github.com/tiagoramirez/tpFinalCursoDotNetNeorisUTN",
            HasEnglishDesc = true,
            EnglishDesc = "We learned: C#, OOP, UML, .NET Framework, Entity Framework, Sql Server.\nFinal Project: https://github.com/tiagoramirez/tpFinalCursoDotNetNeorisUTN"
        });
        educations.Add(new Education
        {
            Id = Guid.NewGuid(),
            UserId = users[0].Id,
            Institute = "Platzi",
            TitleName = ".NET API's",
            IsActual = false,
            Type = EducationType.COURSE,
            Start = new DateTime(2022, 10, 1),
            End = new DateTime(2022, 10, 1),
            NativeDesc = "REST API, Middlewares, C#, .NET 6, POO, Entity Framework, Sql Server.",
            HasEnglishDesc = true,
            EnglishDesc = "REST API, Middlewares, C#, .NET 6, POO, Entity Framework, Sql Server."
        });
        educations.Add(new Education
        {
            Id = Guid.NewGuid(),
            UserId = users[0].Id,
            Institute = "Platzi",
            TitleName = "Entity Framework",
            IsActual = false,
            Type = EducationType.COURSE,
            Start = new DateTime(2022, 10, 1),
            End = new DateTime(2022, 10, 1),
            NativeDesc = "C#, .NET 6, POO, Entity Framework, Fluent API, Sql Server.",
            HasEnglishDesc = true,
            EnglishDesc = "C#, .NET 6, POO, Entity Framework, Fluent API, Sql Server."
        });
        educations.Add(new Education
        {
            Id = Guid.NewGuid(),
            UserId = users[0].Id,
            Institute = "Instituto Nuestra Sra del Huerto - Cambridge",
            TitleName = "English",
            IsActual = false,
            Type = EducationType.TERTIARY_DEGREE,
            Start = new DateTime(2011, 03, 1),
            End = new DateTime(2021, 12, 1),
            NativeDesc = "Clases de ingles. Al final rendimos el examen First Certificate in English (Instituto Cambridge). Mi nivel fue: B2.",
            HasEnglishDesc = true,
            EnglishDesc = "English classes. At the end we took the First Certificate in English exam (Cambridge Institute). My level was: B2."
        });

        modelBuilder.Entity<Education>(educ =>
        {
            educ.ToTable("Education");
            educ.HasKey(table => table.Id);
            educ.HasOne(table => table.User).WithMany(user => user.Educations).HasForeignKey(education => education.UserId);
            educ.Property(table => table.Id);
            educ.Property(table => table.TitleName).IsRequired().HasMaxLength(50);
            educ.Property(table => table.Institute).IsRequired().HasMaxLength(50);
            educ.Property(table => table.Type).IsRequired();
            educ.Property(table => table.IsActual).IsRequired();
            educ.Property(table => table.Start).IsRequired();
            educ.Property(table => table.End).IsRequired(false);
            educ.Property(table => table.NativeDesc).IsRequired().HasMaxLength(1000);
            educ.Property(table => table.HasEnglishDesc).IsRequired();
            educ.Property(table => table.EnglishDesc).IsRequired(false).HasMaxLength(1000);
            educ.HasData(educations);
        });

        List<Experience> experiences = new List<Experience>();
        experiences.Add(new Experience
        {
            Id = Guid.NewGuid(),
            UserId = users[0].Id,
            Position = "Analista Programador Junior",
            Company = "Accusys",
            Type = ExperienceType.FULLTIME,
            IsActual = true,
            Start = new DateTime(2022, 4, 5),
            End = null,
            NativeDesc = "Mantenimiento de un sistema para el Control del Efectivo Bancario.\nManejo y optimización de querys, tablas, stored procedures y vistas en bases de datos MS SQL Server.\nTecnologías: WPF, ASP Clásico, VBS, HTML, Javascript, Java y IIS.",
            HasEnglishDesc = true,
            EnglishDesc = "Maintenance of an Bank Cash Control system.\nManagement and optimization of queries, tables, stored procedures and views in MS SQL Server databases.\nTechnologies: WPF, Classic ASP, VBS, HTML, Javascript, Java and IIS."
        });

        modelBuilder.Entity<Experience>(exp =>
        {
            exp.ToTable("Experience");
            exp.HasKey(table => table.Id);
            exp.HasOne(table => table.User).WithMany(user => user.Experiences).HasForeignKey(experience => experience.UserId);
            exp.Property(table => table.Id);
            exp.Property(table => table.Position).IsRequired().HasMaxLength(100);
            exp.Property(table => table.Company).IsRequired().HasMaxLength(50);
            exp.Property(table => table.Type).IsRequired();
            exp.Property(table => table.IsActual).IsRequired();
            exp.Property(table => table.Start).IsRequired();
            exp.Property(table => table.End).IsRequired(false);
            exp.Property(table => table.NativeDesc).IsRequired().HasMaxLength(1000);
            exp.Property(table => table.HasEnglishDesc).IsRequired();
            exp.Property(table => table.EnglishDesc).IsRequired(false).HasMaxLength(1000);
            exp.HasData(experiences);
        });

        List<Project> projects = new List<Project>();
        projects.Add(new Project
        {
            Id = Guid.NewGuid(),
            UserId = users[0].Id,
            Name = "Portfolio",
            Url = "https://tiagoramirez-portfolio.netlify.app/tiagoramirez",
            NativeDesc = "Portfolio personal realizado con REACT + Typescript + Tailwindcss + .NET 6 + SQL Server",
            HasEnglishDesc = true,
            EnglishDesc = "Personal portfolio made with REACT + Typescript + Tailwindcss + .NET 6 + SQL Server"
        });

        modelBuilder.Entity<Project>(proj =>
        {
            proj.ToTable("Project");
            proj.HasKey(table => table.Id);
            proj.HasOne(table => table.User).WithMany(user => user.Projects).HasForeignKey(project => project.UserId);
            proj.Property(table => table.Id);
            proj.Property(table => table.Name).IsRequired().HasMaxLength(50);
            proj.Property(table => table.Url).IsRequired(false).HasMaxLength(255);
            proj.Property(table => table.NativeDesc).IsRequired().HasMaxLength(1000);
            proj.Property(table => table.HasEnglishDesc).IsRequired();
            proj.Property(table => table.EnglishDesc).IsRequired(false).HasMaxLength(1000);
            proj.HasData(projects);
        });
    }
}