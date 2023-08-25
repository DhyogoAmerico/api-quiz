using Quiz.Domain.Entity;

namespace Quiz.Domain.Repository
{
    public interface IAnswerOptionRepository
    {
        Task<bool> GetCorrect(int id_answer);
        Task<List<AnswerOptions>> GetListCorrects(int id_question);
    }
}