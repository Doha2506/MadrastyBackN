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
    public class RestToRedoService : IRestToRedoService
    {
        private readonly IDatabaseContext _db;

        public RestToRedoService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteRestToRedo", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetRestToRedo");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetRestToRedoById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(RestToRedoViewModel student)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveRestToRedo",
               _db.CreateListOfSqlParams(student, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(RestToRedoViewModel student)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateRestToRedo",
               _db.CreateListOfSqlParams(student, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
