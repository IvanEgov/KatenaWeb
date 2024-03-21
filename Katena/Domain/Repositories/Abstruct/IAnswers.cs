using Katena.Domain.Entities;

namespace Katena.Domain.Repositories.Abstruct
{
    //Публичный интерфейс, позволяющий получать все ответы, получать ответ по id, сохранять новый ответ или изменять уже существующий
    //Удалять ответ по id
    public interface IAnswers
    {
        IQueryable<AnswersBase> GetAllAnswers();
        AnswersBase GetAnswerById(Guid Id);
        void AddReason(AnswersBase answer, Guid reasonId);
        void DeleteReason(AnswersBase answer, Guid id);
        void SaveAnswer(AnswersBase entity);
        void DeleteAnswerById(Guid Id);
    }
}
