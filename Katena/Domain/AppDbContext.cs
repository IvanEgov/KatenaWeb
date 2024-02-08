using Katena.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static Katena.Domain.Entities.QuestionBase;

namespace Katena.Domain
{
	//Представление личного кабинета админа и теста в бд
	public class AppDbContext : IdentityDbContext<IdentityUser>
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
		public DbSet<QuestionPackBase> Packs { get; set; }
		public DbSet<QuestionBase> Questions { get; set; }
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

			modelBuilder.Entity<QuestionPackBase>().HasData(new QuestionPackBase
			{
				Id = new Guid("6a419d80-c1c8-47a2-a2b1-984ebf353970"),
				PackName = "admin",
				Description = "New pack",
				Instructions = "Do this",
				QuestionsIds = new List<Guid>([
					new Guid("4e3c39e9-773b-4d3a-b1c2-9e049943a2c6"),
					new Guid("d3da6694-881f-4cc9-a0c0-6cfae3bc92b6"),
					new Guid("503eafd8-fb5b-41d6-9fae-714a70e6a79b"),
					new Guid("cb8c72de-9a98-427d-b0d8-2a0bdb01d85f"),
					new Guid("e845b1e7-611f-4519-bcdb-0e2ab5a7b5c6"),
					new Guid("3cd9cec1-ef3b-4664-90d8-ba897609fc5f"),
					new Guid("a13769d1-6d53-42e8-b5b9-0bc7f66c3e70"),
					new Guid("f1b161a3-3be4-489c-88c6-da32fafa41d4"),
					new Guid("981b9904-6be5-497c-bf5c-31fe8fe32d7f"),
					new Guid("73ed060a-0904-419f-a27c-f293bde0c359"),
					new Guid("0ab1053c-2879-4181-a54d-cb7668f0737c")
				]),
				Resaults = new Dictionary<string, Dictionary<string, Dictionary<string, string>>> ()
				{
					{"Женщина",
					new Dictionary<string, Dictionary<string, string>>()
					{
						{"Producer", new Dictionary<string, string>()
						{
							{ "Заботливая", "Decription"
							},
							{"Познающая", "Decription"
							},
							{"Хранительница", "Decription"
							},
						} },
						{"Administrator", new Dictionary<string, string>(){
							{"Заботливая", "Decription"
							},
							{"Познающая", "Decription"
							},
							{"Хранительница", "Decription"
							}
						} },
						{"Entrepreneur", new Dictionary<string, string>()
						{
							{"Заботливая", "Decription"
							},
							{"Познающая", "Decription"
							},
							{"Хранительница", "Decription"
							}
						} },
						{"Integrator", new Dictionary<string, string> () 
						{
							{"Заботливая ", "Decription"
							},
							{"Познающая","Decription"
							},
							{"Хранительница","Decription"
							}
						} }
					}
					},
					{"Мужчина",
					new Dictionary<string, Dictionary<string, string>>()
					{
						{"Producer", new Dictionary<string, string>()
						{
							{ "Наставник", "Decription"
							},
							{"Ищущий", "Decription"
							},
							{"Охотник", "Decription"
							},
						} },
						{"Administrator", new Dictionary<string, string>(){
							{"Наставник", "Decription"
							},
							{"Ищущий", "Decription"
							},
							{"Охотник", "Decription"
							}
						} },
						{"Entrepreneur", new Dictionary<string, string>()
						{
							{"Наставник", "Decription"
							},
							{"Ищущий", "Decription"
							},
							{"Охотник", "Decription"
							}
						} },
						{"Integrator", new Dictionary<string, string> ()
						{
							{"Наставник ", "Decription"
							},
							{"Ищущий","Decription"
							},
							{"Охотник","Decription"
							}
						} }
					}}
				}
			});

			modelBuilder.Entity<QuestionBase>().HasData(
			[   
				new QuestionBase 
				{ 
					Quest = "Question 1",
					Answers = new Dictionary<string, Dictionary<string, Answer>>(){ 
				{ "action 1", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } } 
				}},
				{ "action 2", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 3", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 4", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},},
					Id = new Guid("e593b817-fe15-4e58-8d72-e93a6e6d471c")
				},
				new QuestionBase
				{
					Quest = "Question 2",
					Answers = new Dictionary<string, Dictionary<string, Answer>>(){
				{ "action 1", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 2", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 3", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 4", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},},
					Id = new Guid("fa4b4ec9-5459-49c9-95a1-e17b8e8fd842")
				},
				new QuestionBase
				{
					Quest = "Question 3",
					Answers = new Dictionary<string, Dictionary<string, Answer>>(){
				{ "action 1", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 2", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 3", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 4", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},},
					Id = new Guid("0c19d3a0-a690-40a4-a5e4-e28cc03baf9d")
				},
				new QuestionBase
				{
					Quest = "Question 4",
					Answers = new Dictionary<string, Dictionary<string, Answer>>(){
				{ "action 1", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 2", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 3", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 4", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},},
					Id = new Guid("ea5819a5-3282-43e9-ae17-eb375dd463d9")
				},
				new QuestionBase
				{
					Quest = "Question 5",
					Answers = new Dictionary<string, Dictionary<string, Answer>>(){
				{ "action 1", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 2", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 3", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 4", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},},
					Id = new Guid("1f99211c-7081-4f71-81d9-366d97a589b7")
				},
				new QuestionBase
				{
					Quest = "Question 6",
					Answers = new Dictionary<string, Dictionary<string, Answer>>(){
				{ "action 1", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 2", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 3", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 4", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},},
					Id = new Guid("bcc19739-bb72-4938-aa98-ce5f497dbb1e")
				},
				new QuestionBase
				{
					Quest = "Question 7",
					Answers = new Dictionary<string, Dictionary<string, Answer>>(){
				{ "action 1", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 2", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 3", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 4", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},},
					Id = new Guid("57980f25-8079-40b4-bdd9-a51f5fe049ff")
				},
				new QuestionBase
				{
					Quest = "Question 8",
					Answers = new Dictionary<string, Dictionary<string, Answer>>(){
				{ "action 1", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 2", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 3", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 4", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},},
					Id = new Guid("02c39937-8d5e-41c3-99c6-09d6e3621744")
				},
				new QuestionBase
				{
					Quest = "Question 9",
					Answers = new Dictionary<string, Dictionary<string, Answer>>(){
				{ "action 1", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 2", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 3", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 4", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},},
					Id = new Guid("31254e36-8970-4361-be58-260594c173c8")
				},
				new QuestionBase
				{
					Quest = "Question 10",
					Answers = new Dictionary<string, Dictionary<string, Answer>>(){
				{ "action 1", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 2", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 3", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 4", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},},
					Id = new Guid("8f95d02c-e4b0-4313-801b-d0d2044bd30c")
				},
				new QuestionBase
				{
					Quest = "Question 11",
					Answers = new Dictionary<string, Dictionary<string, Answer>>(){
				{ "action 1", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 2", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 3", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},
				{ "action 4", new Dictionary<string, Answer>(){
				{"reason 1", new Answer{weight = 0, type = 0 } },
				{"reason 2", new Answer{weight = 0, type = 0 } },
				{"reason 3", new Answer{weight = 0, type = 0 } }
				}},},
					Id = new Guid("025fcc95-a7b6-4632-aa73-595576ea630c")
				},
			]);
		}
	}
}
