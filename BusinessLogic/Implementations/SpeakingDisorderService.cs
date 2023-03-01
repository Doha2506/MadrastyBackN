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
    public class SpeakingDisorderService : ISpeakingDisorderService
    {
        private readonly IDatabaseContext _db;

        public SpeakingDisorderService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteSpeakingDisorder", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetDpeakingDisorder");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetDpeakingDisorderById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(SpeakingDisorderViewModel student)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveSpeakingDisorder",
               _db.CreateListOfSqlParams(student, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(SpeakingDisorderViewModel student)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateSpeakingDisorder",
               _db.CreateListOfSqlParams(student, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
