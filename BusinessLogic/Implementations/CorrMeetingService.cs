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
    public class CorrMeetingService : ICorrMeetingService
    {
        private readonly IDatabaseContext _db;

        public CorrMeetingService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int CorrMeetingId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(CorrMeetingId), CorrMeetingId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteCorrMeeting", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetCorrMeeting");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int CorrMeetingId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(CorrMeetingId), CorrMeetingId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetCorrMeetingById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(CorrMeetingViewModel CorrMeeting)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveCorrMeeting",
              _db.CreateListOfSqlParams(CorrMeeting, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(CorrMeetingViewModel CorrMeeting)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateCorrMeeting",
               _db.CreateListOfSqlParams(CorrMeeting, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
