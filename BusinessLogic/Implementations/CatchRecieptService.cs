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
    public class CatchRecieptService : ICatchRecieptService
    {
        private readonly IDatabaseContext _db;

        public CatchRecieptService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int CatchRecieptId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(CatchRecieptId), CatchRecieptId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteCatchReciept", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetCatchReciept");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int CatchRecieptId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(CatchRecieptId), CatchRecieptId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetCatchRecieptById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(CatchRecieptViewModel CatchReciept)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveCatchReciept",
              _db.CreateListOfSqlParams(CatchReciept, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(CatchRecieptViewModel CatchReciept)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateCatchReciept",
               _db.CreateListOfSqlParams(CatchReciept, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
