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
    public class AccusedStudentInGuiltService : IAccusedStudentInGuiltService
    {
        private readonly IDatabaseContext _db;

        public AccusedStudentInGuiltService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteAccusedStudentInGuilt", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetAccusedStudentsInGuilt");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetAccusedStudentInGuiltById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(AccusedStudentInGuilt student)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveAccusedStudentInGuilt",
                _db.CreateListOfSqlParams(student, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(AccusedStudentInGuilt student)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateAccusedStudentInGuilt",
                _db.CreateListOfSqlParams(student, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
