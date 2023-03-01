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
    public class StatusService : IStatusService
    {
        private readonly IDatabaseContext _db;

        public StatusService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteStatus", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetStatus");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetStatusById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(StatusViewModel status)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveStatus",
               _db.CreateListOfSqlParams(status, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(StatusViewModel status)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateStatus",
               _db.CreateListOfSqlParams(status, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
