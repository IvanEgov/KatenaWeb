using Katena.Domain.Entities;

namespace Katena.Domain.Repositories.Abstruct
{
    public interface IAnswers
    {
        IQueryable<AnswersBase> GetAllAnswers();
        AnswersBase GetAnswerById(Guid Id);
        void SaveAnswer(AnswersBase entity);
        void DeleteAnswerById(Guid Id);
    }
}
