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
    public class PhaseService : IPhaseService
    {
        private readonly IDatabaseContext _db;

        public PhaseService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeletePhase", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetPhases");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetPhaseById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(PhaseViewModel phase)
        {
            var dalResponse = await _db.ExecuteNonQuery("SavePhase",
               _db.CreateListOfSqlParams(phase, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(PhaseViewModel phase)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdatePhase",
               _db.CreateListOfSqlParams(phase, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
