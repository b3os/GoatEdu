using System.Data.Entity;
using GoatEdu.Core.Interfaces.FlashcardInterfaces;
using GoatEdu.Core.Models;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class FlashcardRepository : BaseRepository<Flashcard>, IFlashcardRepository
{
    private readonly GoatEduContext _context;
    
    public FlashcardRepository(GoatEduContext context) : base(context)
    {
        _context = context;
    }

    public async Task<List<Flashcard>> GetTwoTagFlashcard()
    {
        return await _entities.Where(x => x.Tags.Count(tag => tag.IsDeleted == false) <= 2).ToListAsync();
    }
}