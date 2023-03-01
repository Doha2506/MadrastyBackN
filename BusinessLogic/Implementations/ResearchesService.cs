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
    public class ResearchesService : IResearchesService
    {
        private readonly IDatabaseContext _db;

        public ResearchesService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteResearch", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetResearches");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetResearchById", pars);
            return new ServiceResponse(dalResponse);
        }
        
        public async Task<ServiceResponse> Save(ResearchesViewModel research)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveResearch",
               _db.CreateListOfSqlParams(research, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(ResearchesViewModel research)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateResearch",
               _db.CreateListOfSqlParams(research, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
