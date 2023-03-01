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
    public class BasicDataService : IBasicDataService
    {
        private readonly IDatabaseContext _db;

        public BasicDataService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteBasicData", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetBasicData");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetBasicDataById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(BasicDataViewModel data)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveBasicData",
               _db.CreateListOfSqlParams(data, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(BasicDataViewModel data)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateBasicData",
               _db.CreateListOfSqlParams(data, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
