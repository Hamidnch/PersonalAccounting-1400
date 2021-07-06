using PersonalAccounting.BLL.Enum;
using PersonalAccounting.Domain.Entity;
using PersonalAccounting.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalAccounting.BLL.IService
{
    public interface IDiaryNoteService
    {
        Task<string> LoadByIdAsync(int noteId);
        Task<DiaryNote> LoadByDateAsync(DateTime date, int userId);
        Task<DiaryNote> LoadByDate(DateTime date, int userId);
        IList<ViewModelLoadAllDiaryNoteReport> GetAllDiaryNotes(DateTime? date = null,
            int? mentalConditionId = null, int? weatherConditionId = null, string note = null, int? userId = null);
        Task<CreateStatus> CreateAsync(DiaryNote diaryNote);
        Task UpdateAsync(DiaryNote diaryNote);
        Task<bool> ExistAsync(DateTime date, int userId);
    }
}
