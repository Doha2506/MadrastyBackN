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
    public class FinancialFundService : IFinancialFundService
    {
        private readonly IDatabaseContext _db;

        public FinancialFundService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteFinancialFund", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetFinancialFund");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetFinancialFundById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(FinancialFundViewModel delay)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveFinancialFund",
               _db.CreateListOfSqlParams(delay, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(FinancialFundViewModel delay)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateFinancialFund",
               _db.CreateListOfSqlParams(delay, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
