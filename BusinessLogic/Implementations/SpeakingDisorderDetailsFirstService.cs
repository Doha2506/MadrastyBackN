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
    public class SpeakingDisorderDetailsFirstService : ISpeakingDisorderDetailsFirstService
    {
        private readonly IDatabaseContext _db;

        public SpeakingDisorderDetailsFirstService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteSpeakingDisorderDetailsFirst", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> DeleteBySpeakingDisorderId(int speakingDisorderId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(speakingDisorderId), speakingDisorderId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteSpeakingDisorderDetailsFirstBySpeakingDisorderId", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetSpeakingDisorderDetailsFirst");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetSpeakingDisorderDetailsFirstById", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetBySpeakingDisorderId(int speakingDisorderId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(speakingDisorderId), speakingDisorderId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetSpeakingDisorderDetailsFirstBySpeakingDisorderId", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(SpeakingDisorderDetailsFirst model)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveSpeakingDisorderDetailsFirst",
               _db.CreateListOfSqlParams(model, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(SpeakingDisorderDetailsFirst model)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateSpeakingDisorderDetailsFirst",
               _db.CreateListOfSqlParams(model, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
