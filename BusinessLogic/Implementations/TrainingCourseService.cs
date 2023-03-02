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
    public class TrainingCourseService : ITrainingCourseService
    {
        private readonly IDatabaseContext _db;

        public TrainingCourseService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> GetByEmployeeId(int emolyeeId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(emolyeeId), emolyeeId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetTrainingCourseByEmployeeId", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(TrainingCourseViewModel course)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveTrainingCourse",
               _db.CreateListOfSqlParams(course, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

    }
}
