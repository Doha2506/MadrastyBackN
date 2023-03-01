using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IChangeBranchService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int ChangeBranchId);
        Task<ServiceResponse> Delete(int ChangeBranchId);
        Task<ServiceResponse> Save(ChangeBranchViewModel ChangeBranch);
        Task<ServiceResponse> Update(ChangeBranchViewModel ChangeBranch);
    }
}
