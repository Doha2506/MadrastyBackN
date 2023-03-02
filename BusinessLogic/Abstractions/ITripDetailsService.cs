using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface ITripDetailsService
    {
        Task<ServiceResponse> GetById(int id);
        Task<ServiceResponse> GetByTripId(int tripId);
        Task<ServiceResponse> DeleteByTripId(int tripId);
        Task<ServiceResponse> Save(TripDetailsViewModel trip);
    }
}
