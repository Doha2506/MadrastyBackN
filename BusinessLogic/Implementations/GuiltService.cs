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
    public class GuiltService : IGuiltService
    {
        private readonly IDatabaseContext _db;

        public GuiltService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteGuilt", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetGuilts");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetGuiltById", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetByStudentId(int studentId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(studentId), studentId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetGuiltByStudentId", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(GuiltViewModel guilt)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveGuilt",
               _db.CreateListOfSqlParams(guilt, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(GuiltViewModel guilt)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateGuilt",
               _db.CreateListOfSqlParams(guilt, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
