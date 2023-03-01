using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface ICorridorSupervisionService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int corridorId);
        Task<ServiceResponse> Delete(int corridorId);
        Task<ServiceResponse> Save(CorridorSupervisionViewModel corridor);
        Task<ServiceResponse> Update(CorridorSupervisionViewModel corridor);
    }
}
