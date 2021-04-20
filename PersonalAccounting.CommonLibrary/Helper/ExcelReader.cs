//using System.Linq;
//using Emkan.Domain.ViewModel;
//using LinqToExcel;
//namespace Emkan.CommonLibrary.Utility
//{
//    public static class ExcelReader
//    {
//        public static IQueryable<ShareholderViewModel> ReadFromExcel(string fileName, string sheetName)
//        {
//            IQueryable<ShareholderViewModel> query;
//            using (var book = new ExcelQueryFactory(fileName))
//            {
//                //var columnNames = book.GetColumnNames(sheetName);
//                query =
//                    from row in book.Worksheet(sheetName)
//                    let record = new ShareholderViewModel
//                    {
//                        RegisterNumber = row[1].Cast<int>(),
//                        FullName = row[2].Cast<string>(),
//                        FatherName = row[3].Cast<string>(),
//                        NationalCode = row[4].Cast<string>(),
//                        Mobile = row[5].Cast<string>(),
//                        Organization = row[6].Cast<string>(),
//                        Address = row[7].Cast<string>(),
//                        StockAmount = row[8].Cast<long>()
//                    }
//                    //where item.Supplier == "Walmart"
//                    select record;
//            }
//            return query;
//        }
//    }
//}
