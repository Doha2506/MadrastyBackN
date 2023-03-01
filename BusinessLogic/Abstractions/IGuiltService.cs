using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IGuiltService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int id);
        Task<ServiceResponse> GetByStudentId(int studentId);
        Task<ServiceResponse> Delete(int id);
        Task<ServiceResponse> Save(GuiltViewModel guilt);
        Task<ServiceResponse> Update(GuiltViewModel guilt);
    }
}
