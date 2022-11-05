using Microsoft.EntityFrameworkCore;
using portfolio.Helpers;
using portfolio.Models;

namespace portfolio;

public class PortfolioContext : DbContext
{
    public DbSet<Education_Description> EducationDescriptions { get; set; }
    public DbSet<Education> Educations { get; set; }
    public DbSet<Experience_Description> ExperienceDescriptions { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Profile> Profiles { get; set; }
    public DbSet<ProfileConfig> ProfileConfigs { get; set; }
    public DbSet<Project_Description> ProjectDescriptions { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<User_Role> User_Roles { get; set; }
    public DbSet<User_Skill> User_Skills { get; set; }
    public DbSet<User_SocialMedia> User_SocialMedias { get; set; }
    public DbSet<User> Users { get; set; }

    public PortfolioContext(DbContextOptions<PortfolioContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        List<Role> roles = new List<Role>();
        roles.Add(new Role { Id = Guid.NewGuid(), RoleName = "Admin" });
        roles.Add(new Role { Id = Guid.NewGuid(), RoleName = "User" });

        modelBuilder.Entity<Role>(role =>
        {
            role.ToTable("Role");
            role.HasKey(table => table.Id);
            role.HasMany(table => table.User_Roles).WithOne(user_role => user_role.Role).HasForeignKey(user_role => user_role.RoleId);
            role.Property(table => table.Id).ValueGeneratedOnAdd();
            role.Property(table => table.RoleName).IsRequired().HasMaxLength(50);
            role.HasData(roles);
        });

        List<Skill> skills = new List<Skill>();
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "C#", Type = SkillType.BackEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = ".NET", Type = SkillType.BackEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = ".NET WPF", Type = SkillType.BackEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Entity Framework", Type = SkillType.BackEnd });
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
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "JavaScript", Type = SkillType.BackEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "TypeScript", Type = SkillType.FrontEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "TypeScript", Type = SkillType.BackEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Angular", Type = SkillType.FrontEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "React", Type = SkillType.FrontEnd });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Git", Type = SkillType.DeveloperTool });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Scrum", Type = SkillType.DeveloperTool });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "ERD / DER", Type = SkillType.DeveloperTool });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "UML", Type = SkillType.DeveloperTool });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "JWT", Type = SkillType.DeveloperTool });
        skills.Add(new Skill { Id = Guid.NewGuid(), Name = "Linux", Type = SkillType.DeveloperTool });

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
        socialMedias.Add(new SocialMedia { Id = Guid.NewGuid(), Name = "Web Personal", IconClassName = "bi bi-person-circle" });

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
            Id = Guid.NewGuid(),
            Name = "Tiago Alberto Ramirez Marchisio",
            Email = "tiagoramirez2001@gmail.com",
            Username = "tiagoramirez",
            Password = Encrypt.GetSHA512("Tiago@1234"),
            Status = true,
            Created = DateTime.Now,
        });

        modelBuilder.Entity<User>(user =>
        {
            user.ToTable("User");
            user.HasKey(table => table.Id);
            user.HasMany(table => table.Roles).WithOne(user_role => user_role.User).HasForeignKey(user_role => user_role.UserId);
            user.HasMany(table => table.Skills).WithOne(user_skill => user_skill.User).HasForeignKey(user_skill => user_skill.UserId);
            user.HasMany(table => table.SocialMedias).WithOne(user_socialMedia => user_socialMedia.User).HasForeignKey(user_socialMedia => user_socialMedia.UserId);
            user.HasMany(table => table.Projects).WithOne(project => project.User).HasForeignKey(project => project.UserId);
            user.HasMany(table => table.Profiles).WithOne(profile => profile.User).HasForeignKey(profile => profile.UserId);
            user.Property(table => table.Id).ValueGeneratedOnAdd();
            user.Property(table => table.Username).IsRequired().HasMaxLength(15);
            user.Property(table => table.Password).IsRequired().HasMaxLength(255);
            user.Property(table => table.Name).IsRequired().HasMaxLength(50);
            user.Property(table => table.Email).IsRequired().HasMaxLength(100);
            user.Property(table => table.Status).IsRequired();
            user.HasData(users);
        });

        List<Profile> profiles = new List<Profile>();
        profiles.Add(new Profile
        {
            Id = Guid.NewGuid(),
            UserId = users[0].Id,
            ProfileConfigId = profiles[0].Id,
            Description = "FullStack Developer || .NET + ANGULAR + SQL SERVER || Estudiante Ingeniería en Sistemas de Información en UTN",
            Phone = null,
            LocationState = "Capital Federal",
            LocationCountry = "Argentina",
            AboutMe = "Soy estudiante y programador. No se que mas poner salu2"
        });

        modelBuilder.Entity<Profile>(prof =>
        {
            prof.ToTable("Profile");
            prof.HasKey(table => table.Id);
            // prof.HasMany(table => table.Descriptions).WithOne(description => description.Profile).HasForeignKey(description => description.ProfileId);
            prof.HasOne(table => table.User).WithMany(user => user.Profiles).HasForeignKey(profile => profile.UserId);
            prof.HasOne(table => table.Config).WithOne(profileConfig => profileConfig.Profile).HasForeignKey<ProfileConfig>(profileConfig => profileConfig.ProfileId);
            prof.HasMany(table => table.ExperienceDescriptions).WithOne(experienceDescription => experienceDescription.Profile).HasForeignKey(experienceDescription => experienceDescription.ProfileId);
            prof.HasMany(table => table.EducationDescriptions).WithOne(educationDescription => educationDescription.Profile).HasForeignKey(educationDescription => educationDescription.ProfileId);
            prof.HasMany(table => table.ProjectDescriptions).WithOne(projectDescription => projectDescription.Profile).HasForeignKey(projectDescription => projectDescription.ProfileId);
            prof.Property(table => table.Id).ValueGeneratedOnAdd();
            prof.Property(table => table.Description).IsRequired().HasMaxLength(255);
            prof.Property(table => table.Phone).HasMaxLength(16).IsRequired(false);
            prof.Property(table => table.LocationState).IsRequired(false).HasMaxLength(50);
            prof.Property(table => table.LocationCountry).IsRequired(false).HasMaxLength(50);
            prof.Property(table => table.AboutMe).IsRequired();
            prof.HasData(profiles);
        });

        List<ProfileConfig> profileConfigs = new List<ProfileConfig>();
        profileConfigs.Add(new ProfileConfig
        {
            Id = Guid.NewGuid(),
            ProfileId = profiles[0].Id,
            ShowPhoto = true,
            ShowBanner = true,
            ShowLocation = true,
            ShowPhone = true,
        });

        modelBuilder.Entity<ProfileConfig>(config =>
        {
            config.ToTable("ProfileConfig");
            config.HasKey(table => table.Id);
            config.HasOne(table => table.Profile).WithOne(profile => profile.Config).HasForeignKey<Profile>(profile => profile.ProfileConfigId);
            config.Property(table => table.Id).ValueGeneratedOnAdd();
            config.Property(table => table.ShowBanner).IsRequired();
            config.Property(table => table.ShowLocation).IsRequired();
            config.Property(table => table.ShowPhone).IsRequired();
            config.Property(table => table.ShowPhoto).IsRequired();
            config.HasData(profileConfigs);
        });

        List<User_Role> userRoles = new List<User_Role>();
        userRoles.Add(new User_Role
        {
            Id = Guid.NewGuid(),
            UserId = users[0].Id,
            RoleId = roles[1].Id
        });

        modelBuilder.Entity<User_Role>(userRole =>
        {
            userRole.ToTable("User_Role");
            userRole.HasKey(table => table.Id);
            userRole.HasOne(table => table.User).WithMany(user => user.Roles).HasForeignKey(user_role => user_role.UserId);
            userRole.HasOne(table => table.Role).WithMany(role => role.User_Roles).HasForeignKey(user_role => user_role.RoleId);
            userRole.Property(table => table.Id).ValueGeneratedOnAdd();
            userRole.HasData(userRoles);
        });

        List<User_Skill> userSkills = new List<User_Skill>();
        userSkills.Add(new User_Skill
        {
            Id = Guid.NewGuid(),
            UserId = users[0].Id,
            SkillId = skills[0].Id,
            Percentage = 90
        });

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
            End = null
        });

        modelBuilder.Entity<Education>(educ =>
        {
            educ.ToTable("Education");
            educ.HasKey(table => table.Id);
            educ.HasMany(table => table.Descriptions).WithOne(description => description.Education).HasForeignKey(description => description.EducationId);
            educ.HasOne(table => table.User).WithMany(user => user.Educations).HasForeignKey(education => education.UserId);
            educ.Property(table => table.Id).ValueGeneratedOnAdd();
            educ.Property(table => table.Institute).IsRequired().HasMaxLength(50);
            educ.Property(table => table.TitleName).IsRequired().HasMaxLength(50);
            educ.Property(table => table.Type).IsRequired();
            educ.Property(table => table.IsActual).IsRequired();
            educ.Property(table => table.Start).IsRequired();
            educ.Property(table => table.End).IsRequired(false);
            educ.HasData(educations);
        });

        List<Education_Description> educationDescriptions = new List<Education_Description>();
        educationDescriptions.Add(new Education_Description
        {
            Id = Guid.NewGuid(),
            EducationId = educations[0].Id,
            ProfileId = profiles[0].Id,
            Description = "No se que poner aca"
        });

        modelBuilder.Entity<Education_Description>(desc =>
        {
            desc.ToTable("Education_Description");
            desc.HasKey(table => table.Id);
            desc.HasOne(table => table.Profile).WithMany(profile => profile.EducationDescriptions).HasForeignKey(description => description.ProfileId);
            desc.HasOne(table => table.Education).WithMany(education => education.Descriptions).HasForeignKey(description => description.EducationId).OnDelete(DeleteBehavior.NoAction);
            desc.Property(table => table.Id).ValueGeneratedOnAdd();
            desc.Property(table => table.Description).IsRequired().HasMaxLength(255);
            desc.HasData(educationDescriptions);
        });
        // TODO
        // ------------------------------------------------------------------------------------------------------------------
        modelBuilder.Entity<Experience_Description>(desc =>
        {
            desc.ToTable("Experience_Description");
            desc.HasKey(table => table.Id);
            desc.HasOne(table => table.Profile).WithMany(profile => profile.ExperienceDescriptions).HasForeignKey(description => description.ProfileId);
            desc.HasOne(table => table.Experience).WithMany(experience => experience.Descriptions).HasForeignKey(description => description.ExperienceId).OnDelete(DeleteBehavior.NoAction);
            desc.Property(table => table.Id).ValueGeneratedOnAdd();
            desc.Property(table => table.Description).IsRequired().HasMaxLength(255);
        });

        modelBuilder.Entity<Experience>(exp =>
        {
            exp.ToTable("Experience");
            exp.HasKey(table => table.Id);
            exp.HasMany(table => table.Descriptions).WithOne(description => description.Experience).HasForeignKey(description => description.ExperienceId);
            exp.HasOne(table => table.User).WithMany(user => user.Experiences).HasForeignKey(experience => experience.UserId);
            exp.Property(table => table.Id).ValueGeneratedOnAdd();
            exp.Property(table => table.Position).IsRequired().HasMaxLength(100);
            exp.Property(table => table.Company).IsRequired().HasMaxLength(50);
            exp.Property(table => table.Type).IsRequired();
            exp.Property(table => table.IsActual).IsRequired();
            exp.Property(table => table.Start).IsRequired();
            exp.Property(table => table.End).IsRequired(false);
        });

        modelBuilder.Entity<Project_Description>(desc =>
        {
            desc.ToTable("Project_Description");
            desc.HasKey(table => table.Id);
            desc.HasOne(table => table.Profile).WithMany(profile => profile.ProjectDescriptions).HasForeignKey(description => description.ProfileId);
            desc.HasOne(table => table.Project).WithMany(project => project.Descriptions).HasForeignKey(description => description.ProjectId).OnDelete(DeleteBehavior.NoAction);
            desc.Property(table => table.Id).ValueGeneratedOnAdd();
            desc.Property(table => table.Description).IsRequired().HasMaxLength(255);
        });

        modelBuilder.Entity<Project>(proj =>
        {
            proj.ToTable("Project");
            proj.HasKey(table => table.Id);
            proj.HasMany(table => table.Descriptions).WithOne(description => description.Project).HasForeignKey(description => description.ProjectId);
            proj.HasOne(table => table.User).WithMany(user => user.Projects).HasForeignKey(project => project.UserId);
            proj.Property(table => table.Id).ValueGeneratedOnAdd();
            proj.Property(table => table.Name).IsRequired().HasMaxLength(50);
            proj.Property(table => table.Url).IsRequired(false).HasMaxLength(255);
        });
    }
}