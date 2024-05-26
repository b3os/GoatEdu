using GoatEdu.Core.Interfaces.GenericInterfaces;
using GoatEdu.Core.Models;

namespace GoatEdu.Core.Interfaces.FlashcardInterfaces;

public interface IFlashcardRepository : IRepository<Flashcard>
{
    Task<List<Flashcard>> GetTwoTagFlashcard();
}