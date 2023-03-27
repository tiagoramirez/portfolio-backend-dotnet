using Microsoft.EntityFrameworkCore;
using portfolio.Models;

namespace portfolio;

public class PortfolioContext : DbContext
{
    public DbSet<Education> Educations { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<User_Skill> User_Skills { get; set; }
    public DbSet<User_SocialMedia> User_SocialMedias { get; set; }
    public DbSet<User> Users { get; set; }

    public PortfolioContext(DbContextOptions<PortfolioContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        List<Skill> skills = new List<Skill>();
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "C#", Type = SkillType.BackEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = ".NET API", Type = SkillType.BackEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = ".NET CORE 6", Type = SkillType.BackEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = ".NET WPF", Type = SkillType.BackEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Entity Framework", Type = SkillType.BackEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Fluent API", Type = SkillType.BackEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Migrations", Type = SkillType.BackEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Middlewares", Type = SkillType.BackEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Python", Type = SkillType.BackEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Java", Type = SkillType.BackEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Java Spring", Type = SkillType.BackEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "SQL", Type = SkillType.BackEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "MS SQL Server", Type = SkillType.BackEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "MySql", Type = SkillType.BackEnd });

        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "HTML", Type = SkillType.FrontEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "CSS", Type = SkillType.FrontEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Bootstrap", Type = SkillType.FrontEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "JavaScript", Type = SkillType.FrontEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "TypeScript", Type = SkillType.FrontEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Angular", Type = SkillType.FrontEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "React", Type = SkillType.FrontEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Redux Toolkit", Type = SkillType.FrontEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "React Router", Type = SkillType.FrontEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Vite", Type = SkillType.FrontEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Vitest", Type = SkillType.FrontEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Testing library", Type = SkillType.FrontEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "TailwindCss", Type = SkillType.FrontEnd });

        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Git", Type = SkillType.DeveloperTool });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Scrum", Type = SkillType.DeveloperTool });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "ERD / DER", Type = SkillType.DeveloperTool });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "UML", Type = SkillType.DeveloperTool });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "JWT", Type = SkillType.DeveloperTool });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Linux", Type = SkillType.DeveloperTool });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "REST API", Type = SkillType.DeveloperTool });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Node", Type = SkillType.DeveloperTool });

        modelBuilder.Entity<Skill>(skill =>
        {
            skill.ToTable("Skill");
            skill.HasKey(table => table.Id);
            skill.HasMany(table => table.User_Skills).WithOne(user_skill => user_skill.Skill).HasForeignKey(user_skill => user_skill.SkillId);
            skill.Property(table => table.Id).ValueGeneratedOnAdd();
            skill.Property(table => table.Name).IsRequired().HasMaxLength(50);
            skill.Property(table => table.Type).IsRequired();
            skill.HasData(skills);
        });

        List<SocialMedia> socialMedias = new List<SocialMedia>();
        socialMedias.Add(new SocialMedia { Id = Guid.NewGuid(), Name = "Facebook", IconClassName = "bi bi-facebook" });
        socialMedias.Add(new SocialMedia { Id = Guid.NewGuid(), Name = "Whatsapp", IconClassName = "bi bi-whatsapp" });
        socialMedias.Add(new SocialMedia { Id = Guid.NewGuid(), Name = "Github", IconClassName = "bi bi-github" });
        socialMedias.Add(new SocialMedia { Id = Guid.NewGuid(), Name = "Instagram", IconClassName = "bi bi-instagram" });
        socialMedias.Add(new SocialMedia { Id = Guid.NewGuid(), Name = "LinkedIn", IconClassName = "bi bi-linkedin" });
        socialMedias.Add(new SocialMedia { Id = Guid.NewGuid(), Name = "Twitter", IconClassName = "bi bi-twitter" });
        socialMedias.Add(new SocialMedia { Id = Guid.NewGuid(), Name = "Youtube", IconClassName = "bi bi-youtube" });
        socialMedias.Add(new SocialMedia { Id = Guid.NewGuid(), Name = "Personal", IconClassName = "bi bi-person-circle" });

        modelBuilder.Entity<SocialMedia>(sm =>
        {
            sm.ToTable("SocialMedia");
            sm.HasKey(table => table.Id);
            sm.HasMany(table => table.User_SocialMedias).WithOne(user_socialMedia => user_socialMedia.SocialMedia).HasForeignKey(user_socialMedia => user_socialMedia.SocialMediaId);
            sm.Property(table => table.Id).ValueGeneratedOnAdd();
            sm.Property(table => table.Name).IsRequired().HasMaxLength(20);
            sm.Property(table => table.IconClassName).IsRequired().HasMaxLength(100);
            sm.HasData(socialMedias);
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
            Role = "USR",
            IsEnglishModeEnabled = true,
            NativeDesc = "FullStack Web Dev. con +1 año de exp. || React + Typescript + .NET 6 + SQL Server + Node || Ingeniería en Sistemas de Información - UTN (Argentina)",
            HasEnglishDesc = true,
            EnglishDesc = "FullStack Web Dev. with +1yr exp. || React + Typescript + .NET 6 + SQL Server + Node || Student in Systems Engineering - UTN (Argentina)",
            Phone = null,
            LocationCountry = "Argentina",
            LocationState = "C.A.B.A.",
            NativeAboutMe = "Fullstack Web Dev. con 1 año de experiencia en el área de TI. Mi stack principal: React + Typescript + .NET 6 API + SQL Server + Node",
            HasEnglishAboutMe = true,
            EnglishAboutMe = "Fullstack Web Dev. with 1 year of experience in the IT area. My main stack: React + Typescript + .NET 6 API + SQL Server + Node"
        });

        modelBuilder.Entity<User>(user =>
        {
            user.ToTable("User");
            user.HasKey(table => table.Id);
            user.HasMany(table => table.Skills).WithOne(user_skill => user_skill.User).HasForeignKey(user_skill => user_skill.UserId);
            user.HasMany(table => table.SocialMedias).WithOne(user_socialMedia => user_socialMedia.User).HasForeignKey(user_socialMedia => user_socialMedia.UserId);
            user.HasMany(table => table.Projects).WithOne(project => project.User).HasForeignKey(project => project.UserId);
            user.Property(table => table.Id).ValueGeneratedOnAdd();
            user.Property(table => table.Username).IsRequired().HasMaxLength(15);
            user.Property(table => table.Name).IsRequired().HasMaxLength(50);
            user.Property(table => table.Email).IsRequired().HasMaxLength(100);
            user.Property(table => table.Status).IsRequired();
            user.Property(table => table.Role).IsRequired().HasMaxLength(20);
            user.Property(table => table.IsEnglishModeEnabled).IsRequired();
            user.Property(table => table.NativeDesc).IsRequired().HasMaxLength(255);
            user.Property(table => table.HasEnglishDesc).IsRequired();
            user.Property(table => table.EnglishDesc).IsRequired(false).HasMaxLength(255);
            user.Property(table => table.Phone).IsRequired(false).HasMaxLength(16);
            user.Property(table => table.LocationCountry).IsRequired(false).HasMaxLength(50);
            user.Property(table => table.LocationState).IsRequired(false).HasMaxLength(50);
            user.Property(table => table.NativeAboutMe).IsRequired().HasMaxLength(255);
            user.Property(table => table.HasEnglishAboutMe).IsRequired();
            user.Property(table => table.EnglishAboutMe).IsRequired(false).HasMaxLength(255);
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

        modelBuilder.Entity<User_Skill>(userSkill =>
        {
            userSkill.ToTable("User_Skill");
            userSkill.HasKey(table => table.Id);
            userSkill.HasOne(table => table.User).WithMany(user => user.Skills).HasForeignKey(user_skill => user_skill.UserId);
            userSkill.HasOne(table => table.Skill).WithMany(skill => skill.User_Skills).HasForeignKey(user_skill => user_skill.SkillId);
            userSkill.Property(table => table.Id).ValueGeneratedOnAdd();
            userSkill.Property(table => table.Percentage).IsRequired();
            userSkill.HasData(userSkills);
        });

        List<User_SocialMedia> userSocialMedias = new List<User_SocialMedia>();
        userSocialMedias.Add(new User_SocialMedia
        {
            Id = Guid.NewGuid(),
            UserId = users[0].Id,
            SocialMediaId = socialMedias[2].Id,
            Url = "https://www.github.com/tiagoramirez/"
        });
        userSocialMedias.Add(new User_SocialMedia
        {
            Id = Guid.NewGuid(),
            UserId = users[0].Id,
            SocialMediaId = socialMedias[4].Id,
            Url = "https://www.linkedin.com/in/tiagoramirezmar/"
        });

        modelBuilder.Entity<User_SocialMedia>(userSocialMedia =>
        {
            userSocialMedia.ToTable("User_SocialMedia");
            userSocialMedia.HasKey(table => table.Id);
            userSocialMedia.HasOne(table => table.User).WithMany(user => user.SocialMedias).HasForeignKey(user_socialMedia => user_socialMedia.UserId);
            userSocialMedia.HasOne(table => table.SocialMedia).WithMany(socialMedia => socialMedia.User_SocialMedias).HasForeignKey(user_socialMedia => user_socialMedia.SocialMediaId);
            userSocialMedia.Property(table => table.Id).ValueGeneratedOnAdd();
            userSocialMedia.Property(table => table.Url).IsRequired().HasMaxLength(255);
            userSocialMedia.HasData(userSocialMedias);
        });

        List<Education> educations = new List<Education>();
        educations.Add(new Education
        {
            Id = Guid.NewGuid(),
            UserId = users[0].Id,
            Institute = "Universidad Tecnologica Nacional",
            TitleName = "Ingenieria en Sistemas de Informacion",
            IsActual = true,
            Type = EducationType.College,
            Start = new DateTime(2020, 4, 1),
            End = null,
            NativeDesc = "Me encuentro en 3er año con un promedio de 9/10",
            HasEnglishDesc = true,
            EnglishDesc = "Currently at 3rd year with an average of 9/10"
        });

        modelBuilder.Entity<Education>(educ =>
        {
            educ.ToTable("Education");
            educ.HasKey(table => table.Id);
            educ.HasOne(table => table.User).WithMany(user => user.Educations).HasForeignKey(education => education.UserId);
            educ.Property(table => table.Id).ValueGeneratedOnAdd();
            educ.Property(table => table.Institute).IsRequired().HasMaxLength(50);
            educ.Property(table => table.TitleName).IsRequired().HasMaxLength(50);
            educ.Property(table => table.Type).IsRequired();
            educ.Property(table => table.IsActual).IsRequired();
            educ.Property(table => table.Start).IsRequired();
            educ.Property(table => table.End).IsRequired(false);
            educ.Property(table => table.NativeDesc).IsRequired().HasMaxLength(255);
            educ.Property(table => table.HasEnglishDesc).IsRequired();
            educ.Property(table => table.EnglishDesc).IsRequired(false).HasMaxLength(255);
            educ.HasData(educations);
        });

        List<Experience> experiences = new List<Experience>();
        experiences.Add(new Experience
        {
            Id = Guid.NewGuid(),
            UserId = users[0].Id,
            Position = "Analista Programador Junior",
            Company = "Accusys",
            Type = ExperienceType.FullTime,
            IsActual = true,
            Start = new DateTime(2022, 4, 5),
            End = null,
            NativeDesc = "Manejo y optimización de querys, tablas, stored procedures y vistas en bases de datos MS SQL Server. Trabajo con tecnologías tales como WPF, ASP Clásico, VBS, HTML, Javascript, Java y IIS",
            HasEnglishDesc = true,
            EnglishDesc = "Management and optimization of queries, tables, stored procedures and views in MS SQL Server databases. I work with technologies such as WPF, Classic ASP, VBS, HTML, Javascript, Java and IIS"
        });

        modelBuilder.Entity<Experience>(exp =>
        {
            exp.ToTable("Experience");
            exp.HasKey(table => table.Id);
            exp.HasOne(table => table.User).WithMany(user => user.Experiences).HasForeignKey(experience => experience.UserId);
            exp.Property(table => table.Id).ValueGeneratedOnAdd();
            exp.Property(table => table.Position).IsRequired().HasMaxLength(100);
            exp.Property(table => table.Company).IsRequired().HasMaxLength(50);
            exp.Property(table => table.Type).IsRequired();
            exp.Property(table => table.IsActual).IsRequired();
            exp.Property(table => table.Start).IsRequired();
            exp.Property(table => table.End).IsRequired(false);
            exp.Property(table => table.NativeDesc).IsRequired().HasMaxLength(255);
            exp.Property(table => table.HasEnglishDesc).IsRequired();
            exp.Property(table => table.EnglishDesc).IsRequired(false).HasMaxLength(255);
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
            proj.Property(table => table.Id).ValueGeneratedOnAdd();
            proj.Property(table => table.Name).IsRequired().HasMaxLength(50);
            proj.Property(table => table.Url).IsRequired(false).HasMaxLength(255);
            proj.Property(table => table.NativeDesc).IsRequired().HasMaxLength(255);
            proj.Property(table => table.HasEnglishDesc).IsRequired();
            proj.Property(table => table.EnglishDesc).IsRequired(false).HasMaxLength(255);
            proj.HasData(projects);
        });
    }
}