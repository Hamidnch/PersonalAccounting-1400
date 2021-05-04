using PersonalAccounting.BLL.Enum;
using PersonalAccounting.BLL.IService;
using PersonalAccounting.CommonLibrary.Helper;
using PersonalAccounting.DAL.Infrastructure;
using PersonalAccounting.Domain.Entity;
using PersonalAccounting.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalAccounting.BLL.Service
{
    public class DiaryNoteService : BaseService, IDiaryNoteService
    {
        private readonly IUnitOfWork _unitOfWork;

        private const string EntityName = nameof(DiaryNote);
        private const string EntityNameNormal = "یادداشت روزانه ";

        public DiaryNoteService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            DiaryNotes = _unitOfWork.Set<DiaryNote>();
        }

        public IDbSet<DiaryNote> DiaryNotes { get; set; }

        public async Task<string> LoadByIdAsync(int noteId)
        {
            var res = await DiaryNotes.AsNoTracking()
                .FirstOrDefaultAsync(dn => dn.Id == noteId);
            return res != null ? res.Note : "هیچ";
        }

        public async Task<DiaryNote> LoadByDateAsync(DateTime date, int userId)
        {
            //if (createdBy == null)
            //{
            //    return await DiaryNotes.AsNoTracking().FirstOrDefaultAsync(dn => dn.Date == date);
            //}

            var res = await DiaryNotes.AsNoTracking()
                .FirstOrDefaultAsync(dn => dn.Date == date && dn.UserId == userId);
            return res;
        }

        public DiaryNote LoadByDate(DateTime date, int userId)
        {
            //if (createdBy == null)
            //{
            //    DiaryNotes.AsNoTracking().FirstOrDefault(dn => dn.Date == date);
            //}

            return DiaryNotes.AsNoTracking().FirstOrDefault(dn => dn.Date == date && dn.UserId == userId);
        }

        public IList<ViewModelLoadAllDiaryNoteReport> GetAllDiaryNotes(DateTime? date = null, int? mentalConditionId = null, int? weatherConditionId = null,
            string note = null, int? userId = null)
        {
            var diaryNoteList = DiaryNotes.AsNoTracking();
            if (date != null)
            {
                diaryNoteList = diaryNoteList.Where(dn => dn.Date == date);
            }

            if (mentalConditionId != null)
            {
                diaryNoteList = diaryNoteList.Where(dn => dn.MentalConditionId == mentalConditionId);
            }

            if (weatherConditionId != null)
            {
                diaryNoteList = diaryNoteList.Where(dn => dn.WeatherConditionId == weatherConditionId);
            }

            if (userId != null)
            {
                diaryNoteList = diaryNoteList.Where(dn => dn.UserId == userId);
            }

            if (note != null)
            {
                diaryNoteList = diaryNoteList.Where(dn => dn.Note.Contains(note));
            }

            var myQuery = from diaryNote in diaryNoteList
                          select
                              new ViewModelLoadAllDiaryNoteReport()
                              {
                                  UserId = diaryNote.UserId,
                                  Username = diaryNote.User.UserName,
                                  WeatherConditionId = diaryNote.WeatherConditionId,
                                  MentalConditionId = diaryNote.WeatherConditionId,
                                  DiaryNoteDate = diaryNote.Date,
                                  MentalConditionSubject = diaryNote.MentalCondition.Title,
                                  WeatherConditionSubject = diaryNote.WeatherCondition.Title,
                                  CreatedBy = diaryNote.CreatedBy,
                                  CreationUserName = diaryNote.SelfUser.UserName,
                                  UpdateBy = diaryNote.UpdateBy,
                                  UpdateUserName = diaryNote.UpdateUser.UserName,
                                  CreatedOn = diaryNote.CreatedOn,
                                  UpdateOn = diaryNote.LastUpdate,
                                  Note = diaryNote.Note,
                                  Comment = diaryNote.Description
                              };
            return myQuery.ToList();
        }

        public async Task<CreateStatus> CreateAsync(DiaryNote diaryNote)
        {
            try
            {
                if (await ExistAsync(diaryNote.Date, diaryNote.UserId))
                {
                    InsertLog(LogLevel.Warning, EntityName,
                        "CreateAsync", GetServiceName(), EntityNameNormal + "جدید تکراری می باشد");
                    return CreateStatus.Exist;
                }

                DiaryNotes.Add(diaryNote);
                await _unitOfWork.SaveChangesAsync();
                InsertLog(LogLevel.Information, EntityName,
                    "CreateAsync", GetServiceName(), EntityNameNormal + $" جدید با موفقیت ثبت گردید.");

                return CreateStatus.Successful;
            }
            catch (Exception exception)
            {
                // log exception
                InsertLog(LogLevel.Error, EntityName,
                    "CreateAsync", exception.Message, exception.ToDetailedString());
                return CreateStatus.Failure;
            }
        }
        public async Task UpdateAsync(DiaryNote diaryNote)
        {
            //_unitOfWork.MarkAsChanged(diaryNote);
            DiaryNotes.AddOrUpdate(diaryNote);
            await _unitOfWork.SaveChangesAsync();
            InsertLog(LogLevel.Information, EntityName,
                "UpdateAsync", GetServiceName(), EntityNameNormal + $" با موفقیت ویرایش گردید.");
        }

        public async Task<bool> ExistAsync(DateTime date, int userId)
        {
            //if (createdBy == null)
            //{
            //    return await DiaryNotes.AnyAsync(dn => dn.Date == date);
            //}

            return await DiaryNotes.AnyAsync(dn => dn.Date == date && dn.UserId == userId);
        }
    }
}
