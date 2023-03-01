using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface ICatchRecieptService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int CatchRecieptId);
        Task<ServiceResponse> Delete(int CatchRecieptId);
        Task<ServiceResponse> Save(CatchRecieptViewModel CatchReciept);
        Task<ServiceResponse> Update(CatchRecieptViewModel CatchReciept);
    }
}
