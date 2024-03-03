using Katena.Domain.Entities;
using Katena.Domain.Repositories.Abstruct;
using Microsoft.EntityFrameworkCore;

namespace Katena.Domain.Repositories.EntityFramework
{
    public class EFAnswersBase : IAnswers
    {
        private readonly AppDbContext context;

        public EFAnswersBase(AppDbContext context)
        {
            this.context = context;
        }
        public IQueryable<AnswersBase> GetAllAnswers()
        {
            return context.Answers;
        }

        public AnswersBase GetAnswerById(Guid id)
        {
            return context.Answers.FirstOrDefault(x => x.Id == id);
        }

        public void SaveAnswer(AnswersBase entity)
        {
            if (entity.Id == default)
            {
                context.Entry(entity).State = EntityState.Added;
                entity.Id = Guid.NewGuid();
            }
            else
            {
                context.Entry(entity).State = EntityState.Modified;
            }

            context.SaveChanges();
        }

        public void DeleteAnswerById(Guid id)
        {
            context.Answers.Remove(new AnswersBase { Id = id });
            context.SaveChanges();
        }
    }
}
