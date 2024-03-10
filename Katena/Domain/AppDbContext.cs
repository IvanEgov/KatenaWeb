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
		public DbSet<ResaultsBase> Resaults { get; set; }
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
				RoleId = "e8ec6f61-f6d0-4b1d-bbe4-5910f862b2bd",
				UserId = "ef37a3c2-7c96-4405-a971-7abcc91ac333"
            });

			modelBuilder.Entity<TextField>().HasData(new TextField
			{
				Id = new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
				CodeWord = "PageIndex",
				Title = "Главная",
				TitleImagePath = ""
			});
			modelBuilder.Entity<TextField>().HasData(new TextField
			{
				Id = new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
				CodeWord = "PageTests",
				Title = "Тесты",
                TitleImagePath = ""
            });
			modelBuilder.Entity<TextField>().HasData(new TextField
			{
				Id = new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
				CodeWord = "PageAbilities",
				Title = "Возможности",
                TitleImagePath = ""
            });
			modelBuilder.Entity<TextField>().HasData(new TextField
			{
				Id = new Guid("8eae0a63-8f52-4160-a14e-b405e431a13b"),
				CodeWord = "PageContacts",
				Title = "Контакты",
                TitleImagePath = ""
            });

			modelBuilder.Entity<AnswersBase>().HasData(
				[
					new AnswersBase 
					{
						Id = new Guid("cb83a258-54e1-4b2a-a58f-24fe95a357bc"),
						Action = "Начну звонить соседям и выяснять у всех ли отключили",
						Reason = "Может, кто-то знает причину отключения",
						Type = "Hunter",
						Weight = 0
					},
					new AnswersBase 
					{
						Id = new Guid("03b5d02c-aa7f-47b9-8b80-4bd984ce7906"),
						Action = "Начну искать телефоны снабжающих организаций и выяснять причину отключения",
						Reason = "Надо вывалить на кого-то все зло, которое у меня накопилось",
						Type = "Mentor",
						Weight = 0
					},
					new AnswersBase 
					{
						Id = new Guid("9102a12d-2845-4224-939e-913ab96524ab"),
						Action = "Плевать, не велика проблема",
						Reason = "Сейчас важнее не опаздать, а остальное -  мелочи",
						Type = "Finder",
						Weight = 0
					},
					new AnswersBase 
					{
						Id = new Guid("e82f0359-d505-49f3-9292-f3877a9a844f"),
						Action = "Это знак свыше, можно никуда сегодня не ходить, пойду спать дальше",
						Reason = "Вот, наконец-то, повод отлежаться дома",
						Type = "GoodMan",
						Weight = 0
					},
                    new AnswersBase
                    {
                        Id = new Guid("5ed2804d-bc6a-4296-b9a0-cf720271a18a"),
                        Action = "Накричу на него, заставлю извиняться",
                        Reason = "Если бы подобных людей в моей жизни было бы меньше, я бы чувствовал себя лучше",
                        Type = "Hunter",
                        Weight = 0
                    },
					new AnswersBase
                    {
                        Id = new Guid("4c748f11-614c-4da8-97f2-eec8dc8ef989"),
                        Action = "Поеду домой переодеваться, а потом вернусь на вечеринку",
                        Reason = "Я всегда выгляжу идеально и должен быть примером для других",
                        Type = "Hunter",
                        Weight = 0
                    },
					new AnswersBase
                    {
                        Id = new Guid("01786293-47e4-407e-9c24-66591aa9e099"),
                        Action = "Постараюсь, не привлекая внимания окружающих, удалить пятно подручными средствами," +
						" а если это не получится, продолжу веселиться вместе с пятном",
                        Reason = "Не думаю, что на подобной вечеринке мой канфуз будет сильно бросаться в глаза",
                        Type = "Mentor",
                        Weight = 0
                    },
					new AnswersBase
                    {
                        Id = new Guid("6afb4539-1a1c-44d5-ab1e-c8b29fbc2ddc"),
                        Action = "Настроение испорчено, уеду с вечеринки",
                        Reason = "Никто не должен видеть меня в таком виде",
                        Type = "Finder",
                        Weight = 0
                    }
                ]);

			modelBuilder.Entity<QuestionBase>().HasData(
				[
					new QuestionBase 
					{
						Id = new Guid("0dc6e45e-ba94-4f54-a59e-53caa1eea73c"),
						AnswerId = new List<Guid> { new Guid("cb83a258-54e1-4b2a-a58f-24fe95a357bc"), new Guid("03b5d02c-aa7f-47b9-8b80-4bd984ce7906"),
							new Guid("9102a12d-2845-4224-939e-913ab96524ab"), new Guid("e82f0359-d505-49f3-9292-f3877a9a844f") },
						Name = "Вы проснулись утром и поняли, что проспали сигнал будильника. Вы стремглав бежите в ванную и обнаруживаете," +
						" что в кране нет воды. Ни холодной, ни горячей. Ваши первые действия?"
                    },

					new QuestionBase 
					{
						Id = new Guid("2b8ad992-d4aa-4c3f-a65e-aaf036260807"),
						AnswerId = new List<Guid> { new Guid("5ed2804d-bc6a-4296-b9a0-cf720271a18a"), new Guid("4c748f11-614c-4da8-97f2-eec8dc8ef989"),
							new Guid("01786293-47e4-407e-9c24-66591aa9e099"), new Guid("6afb4539-1a1c-44d5-ab1e-c8b29fbc2ddc") },
						Name = "На корпоративе, к которому вы давно готовились, сосед случайно проливает на вас красное вино. Ваша первая реакция?"
                    },

					new QuestionBase 
					{
						Id = new Guid("2c517d36-d4db-4b02-b1c6-20b9c5eab29a"),
						AnswerId = new List<Guid> { new Guid("c407f32a-9fbf-486e-b744-c69f4961e58e"), new Guid("0429066e-201f-4b2a-97fe-d15448bc4876"),
							new Guid("6b39f0ec-0314-41c3-84f1-3b892bef6545"), new Guid("1b08ffbf-6ae8-46b2-a058-10f742cbb3d4") },
						Name = "Question from Jack Fresko?"
					}
				]);

			modelBuilder.Entity<QuestionPackBase>().HasData(
				[
					new QuestionPackBase
					{
						Id = new Guid("0ed29a4b-ea2d-426d-add2-22753c7bf8cb"),
						Name = "Personality test",
						Description = "A good test to get to know yourself",
						Instructions = "Think",
						QuestionsIds = new List<Guid> { new Guid("0dc6e45e-ba94-4f54-a59e-53caa1eea73c"),
							new Guid("2b8ad992-d4aa-4c3f-a65e-aaf036260807"),  new Guid("2c517d36-d4db-4b02-b1c6-20b9c5eab29a")},
						ResaultsId = new List<Guid> { new Guid("959f07c9-5bd1-402c-9d29-c0cd3b5f954d"),
							new Guid("cbed2409-359d-4425-9505-7434d6f75d79"), new Guid("6662ee7c-34c8-4811-b3f3-ada6618dc47b")}

					}
				]);
			
			modelBuilder.Entity<ResaultsBase>().HasData(
				[
					new ResaultsBase
					{
						Id = new Guid("959f07c9-5bd1-402c-9d29-c0cd3b5f954d"),
						Gender = "Male",
						Style = "Producer",
						Type = "Mentor",
						Resault = "Megamen"
					},
					new ResaultsBase
					{
						Id = new Guid("cbed2409-359d-4425-9505-7434d6f75d79"),
						Gender = "Female",
						Style = "Producer",
						Type = "Mentor",
						Resault = "Megawomen"
					},
					new ResaultsBase
					{
						Id = new Guid("6662ee7c-34c8-4811-b3f3-ada6618dc47b"),
						Gender = "Female",
						Style = "Entrepreneur",
						Type = "Guardian",
						Resault = "Strongwomen"
					}
				]);
		}
	}
}
