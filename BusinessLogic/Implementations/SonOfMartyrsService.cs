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
    public class SonOfMartyrsService : ISonOfMartyrsService
    {
        private readonly IDatabaseContext _db;

        public SonOfMartyrsService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteSonOfMartyrs", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetSonOfMartyrs");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetSonOfMartyrsById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(SonOfMartyrsViewModel student)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveSonOfMartyrs",
               _db.CreateListOfSqlParams(student, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(SonOfMartyrsViewModel student)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateSonOfMartyrs",
               _db.CreateListOfSqlParams(student, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
