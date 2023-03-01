using BusinessLogic.Abstractions;
using BusinessLogic.Contexts;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class AbsenceStudentService : IAbsenceStudentService
    {
        private readonly IDatabaseContext _db;

        public AbsenceStudentService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> Save(AbsenceStudent absenceStudent)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveAbsenceStudent",
               _db.CreateListOfSqlParams(absenceStudent, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }
    }
}
