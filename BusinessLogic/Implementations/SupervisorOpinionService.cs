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
    public class SupervisorOpinionService : ISupervisorOpinionService
    {
        private readonly IDatabaseContext _db;

        public SupervisorOpinionService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteSupervisorOpinion", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetSupervisorOpinions");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetSupervisorOpinionById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(SupervisorOpinionViewModel opinion)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveSupervisorOpinion",
               _db.CreateListOfSqlParams(opinion, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(SupervisorOpinionViewModel opinion)
        {   
            var dalResponse = await _db.ExecuteNonQuery("UpdateSupervisorOpinion",
               _db.CreateListOfSqlParams(opinion, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
