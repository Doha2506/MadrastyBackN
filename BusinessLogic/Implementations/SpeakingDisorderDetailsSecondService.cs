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
    public class SpeakingDisorderDetailsSecondService : ISpeakingDisorderDetailsSecondService
    {
        private readonly IDatabaseContext _db;

        public SpeakingDisorderDetailsSecondService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteSpeakingDisorderDetailsSecond", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> DeleteBySpeakingDisorderId(int speakingDisorderId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(speakingDisorderId), speakingDisorderId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteSpeakingDisorderDetailsSecondBySpeakingDisorderId", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetSpeakingDisorderDetailsSecond");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetSpeakingDisorderDetailsSecondById", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetBySpeakingDisorderId(int speakingDisorderId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(speakingDisorderId), speakingDisorderId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetSpeakingDisorderDetailsSecondBySpeakingDisorderId", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(SpeakingDisorderDetailsSecond model)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveSpeakingDisorderDetailsSecond",
               _db.CreateListOfSqlParams(model, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(SpeakingDisorderDetailsSecond model)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateSpeakingDisorderDetailsSecond",
               _db.CreateListOfSqlParams(model, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
