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
    public class VisitTypeService : IVisitTypeService
    {
        private readonly IDatabaseContext _db;

        public VisitTypeService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteVisitType", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetVisitsType");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetVisitsTypeById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(VisitTypeViewModel visitType)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveVisitType",
               _db.CreateListOfSqlParams(visitType, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(VisitTypeViewModel visitType)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateVisitType",
               _db.CreateListOfSqlParams(visitType, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
