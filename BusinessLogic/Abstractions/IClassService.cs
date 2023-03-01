using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IClassService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int ClassId);
        Task<ServiceResponse> GetClassWithLevelId(int ClassLevel);
        Task<ServiceResponse> GetClassCountForTeacher(int EmpId);
        Task<ServiceResponse> Delete(int ClassId);
        Task<ServiceResponse> Save(ClassViewModel Class);
        Task<ServiceResponse> Update(ClassViewModel Class);

    }
}
