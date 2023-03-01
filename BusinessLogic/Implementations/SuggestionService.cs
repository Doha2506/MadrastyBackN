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
    public class SuggestionService : ISuggestionService
    {
        private readonly IDatabaseContext _db;

        public SuggestionService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteSuggestion", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetSuggestions");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetSuggestionsById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(SuggestionsViewModel suggestion)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveSuggestion",
               _db.CreateListOfSqlParams(suggestion, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(SuggestionsViewModel suggestion)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateSuggestion",
               _db.CreateListOfSqlParams(suggestion, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
