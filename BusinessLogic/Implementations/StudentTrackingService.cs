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
    public class StudentTrackingService : IStudentTrackingService
    {
        private readonly IDatabaseContext _db;

        public StudentTrackingService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteStudentTracking", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get(int classId, string date)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(classId), classId.ToString());
            pars.Add(nameof(date), date.ToString());

            var dalResponse = await _db.ExecuteQuery("GetStudentTracking");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetByClassIdAndDate(int classId, string date)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(classId), classId.ToString());
            pars.Add(nameof(date), date.ToString());

            var dalResponse = await _db.ExecuteQuery("GetStudentsTrackingByClassIdAndDate", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(StudentTrackingViewModel student)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveStudentTracking",
               _db.CreateListOfSqlParams(student, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(StudentTrackingViewModel student)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateStudentTracking",
               _db.CreateListOfSqlParams(student, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
