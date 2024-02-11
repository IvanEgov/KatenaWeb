using Katena.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static Katena.Domain.Entities.QuestionBase;

namespace Katena.Domain
{
	//Представление личного кабинета админа, заполнения страниц и теста в бд
	public class AppDbContext : IdentityDbContext<IdentityUser>
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
		public DbSet<TextField> TextFields { get; set; }
		public DbSet<QuestionPackBase> Packs { get; set; }
		public DbSet<QuestionBase> Questions { get; set; }
		public DbSet<AnswersBase> Answers { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
			{
				Id = "e8ec6f61-f6d0-4b1d-bbe4-5910f862b2bd",
				Name = "admin",
				NormalizedName = "ADMIN"
			});

			modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
			{
				Id = "ef37a3c2-7c96-4405-a971-7abcc91ac333",
				UserName = "admin",
				NormalizedUserName = "ADMIN",
				Email = "my@email.com",
				NormalizedEmail = "MY@EMAIL.COM",
				EmailConfirmed = true,
				PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
				SecurityStamp = string.Empty
			});

			modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
			{
				RoleId = "358f7a09-da5c-4c70-a4ee-265de54b9382",
				UserId = "09cd0a02-4235-4ba8-84ca-4267ed4b5484"
			});

			modelBuilder.Entity<TextField>().HasData(new TextField
			{
				Id = new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
				CodeWord = "PageIndex",
				Title = "Главная"
			});
			modelBuilder.Entity<TextField>().HasData(new TextField
			{
				Id = new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
				CodeWord = "PageTests",
				Title = "Тесты"
			});
			modelBuilder.Entity<TextField>().HasData(new TextField
			{
				Id = new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
				CodeWord = "PageAbilities",
				Title = "Возможности"
			});
			modelBuilder.Entity<TextField>().HasData(new TextField
			{
				Id = new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
				CodeWord = "PageContacts",
				Title = "Контакты"
			});

		}
	}
}
