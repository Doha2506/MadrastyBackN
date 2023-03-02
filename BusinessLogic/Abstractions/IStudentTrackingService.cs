using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IStudentTrackingService
    {
        Task<ServiceResponse> Get(int classId, string date);
        Task<ServiceResponse> GetByClassIdAndDate(int classId, string date);
        Task<ServiceResponse> Delete(int id);
        Task<ServiceResponse> Save(StudentTrackingViewModel student);
        Task<ServiceResponse> Update(StudentTrackingViewModel student);
    }
}
