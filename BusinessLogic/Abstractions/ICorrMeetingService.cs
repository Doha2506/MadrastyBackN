using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface ICorrMeetingService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int CorrMeetingId);
        Task<ServiceResponse> Delete(int CorrMeetingId);
        Task<ServiceResponse> Save(CorrMeetingViewModel CorrMeeting);
        Task<ServiceResponse> Update(CorrMeetingViewModel CorrMeeting);
    }
}
