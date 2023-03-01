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
    public class CorridorsService : ICorridorsService
    {
        private readonly IDatabaseContext _db;

        public CorridorsService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteCorridorsDef", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetCorridorsDef");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetCorridorsDefById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(CorridorsViewModel corridors)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveCorridorsDef",
              _db.CreateListOfSqlParams(corridors, new List<string>() { "id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(CorridorsViewModel corridors)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateCorridorsDef",
               _db.CreateListOfSqlParams(corridors, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
