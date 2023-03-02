using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface ITeamMemberService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int id);
        Task<ServiceResponse> GetByTeamId(int teamId);
        Task<ServiceResponse> Delete(int id);
        Task<ServiceResponse> Save(TeamMemberViewModel guide);
        Task<ServiceResponse> Update(TeamMemberViewModel guide);
    }
}
