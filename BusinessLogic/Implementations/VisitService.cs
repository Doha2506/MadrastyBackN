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
    public class VisitService : IVisitService
    {
        private readonly IDatabaseContext _db;

        public VisitService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteVisit", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetVisits");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetVisitById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(VisitViewModel visit)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveVisit",
               _db.CreateListOfSqlParams(visit, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(VisitViewModel visit)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateVisit",
               _db.CreateListOfSqlParams(visit, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
