using GoatEdu.Core.Interfaces.ChapterInterfaces;
using GoatEdu.Core.Interfaces.FlashcardInterfaces;
using GoatEdu.Core.Interfaces.LessonInterfaces;
using GoatEdu.Core.Interfaces.NoteInterfaces;
using GoatEdu.Core.Interfaces.NotificationInterfaces;
using GoatEdu.Core.Interfaces.RoleInterfaces;
using GoatEdu.Core.Interfaces.SubjectInterfaces;
using GoatEdu.Core.Interfaces.TagInterfaces;
using GoatEdu.Core.Interfaces.UserInterfaces;

namespace GoatEdu.Core.Interfaces
{

    public interface IUnitOfWork
    {
        
        IUserRepository UserRepository { get; }
        IRoleRepository RoleRepository { get; }
        INotificationRepository NotificationRepository { get; }
        INoteRepository NoteRepository { get; }
        ISubjectRepository SubjectRepository { get; }
        IChapterRepository ChapterRepository { get; }
        ILessonRepository LessonRepository { get; }
        ITagRepository TagRepository { get; }
        IFlashcardRepository FlashcardRepository { get; }

        
        void SaveChanges();
        Task<int> SaveChangesAsync();
    }
}