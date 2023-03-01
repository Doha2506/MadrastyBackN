using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface ISpeakingDisorderDetailsFirstService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int id);
        Task<ServiceResponse> GetBySpeakingDisorderId(int speakingDisorderId);
        Task<ServiceResponse> Delete(int id);
        Task<ServiceResponse> DeleteBySpeakingDisorderId(int speakingDisorderId);
        Task<ServiceResponse> Save(SpeakingDisorderDetailsFirst model);
        Task<ServiceResponse> Update(SpeakingDisorderDetailsFirst model);
    }
}
