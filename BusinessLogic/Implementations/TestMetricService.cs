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
    public class TestMetricService : ITestMetricService
    {
        private readonly IDatabaseContext _db;

        public TestMetricService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteTest", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetTests");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetTestById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(TestMetricViewModel test)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveTest",
               _db.CreateListOfSqlParams(test, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(TestMetricViewModel test)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateTest",
               _db.CreateListOfSqlParams(test, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
