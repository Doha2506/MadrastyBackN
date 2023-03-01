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
    public class CorridorSupervisionService : ICorridorSupervisionService
    {
        private readonly IDatabaseContext _db;

        public CorridorSupervisionService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int Id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Id), Id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteCorridorSupervision", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetActivities");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int Id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Id), Id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetCorridorSupervisionById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(CorridorSupervisionViewModel CorridorSupervision)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveCorridorSupervision",
              _db.CreateListOfSqlParams(CorridorSupervision, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(CorridorSupervisionViewModel CorridorSupervision)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateCorridorSupervision",
               _db.CreateListOfSqlParams(CorridorSupervision, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
