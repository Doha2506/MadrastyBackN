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
    public class ChangeBranchService : IChangeBranchService
    {
        private readonly IDatabaseContext _db;

        public ChangeBranchService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int ChangeBranchId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(ChangeBranchId), ChangeBranchId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteChangeBranch", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetChangeBranch");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int ChangeBranchId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(ChangeBranchId), ChangeBranchId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetChangeBranchById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(ChangeBranchViewModel ChangeBranch)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveChangeBranch",
              _db.CreateListOfSqlParams(ChangeBranch, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(ChangeBranchViewModel ChangeBranch)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateChangeBranch",
               _db.CreateListOfSqlParams(ChangeBranch, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
