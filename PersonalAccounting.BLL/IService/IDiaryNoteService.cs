using PersonalAccounting.BLL.Enum;
using PersonalAccounting.Domain.Entity;
using System;
using System.Threading.Tasks;

namespace PersonalAccounting.BLL.IService
{
    public interface IDiaryNoteService
    {
        Task<string> LoadByIdAsync(int noteId);
        Task<DiaryNote> LoadByDateAsync(DateTime date, int userId);
        DiaryNote LoadByDate(DateTime date, int userId);
        Task<CreateStatus> CreateAsync(DiaryNote diaryNote);
        Task UpdateAsync(DiaryNote diaryNote);
        Task<bool> ExistAsync(DateTime date, int userId);
    }
}
