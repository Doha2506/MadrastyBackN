using BusinessLogic.Abstractions;
using BusinessLogic.Contexts;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class TripDetailsService :ITripDetailsService
    {
        private readonly IDatabaseContext _db;

        public TripDetailsService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> DeleteByTripId(int tripId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(tripId), tripId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteTripDetailsByTripId", pars);
            return new ServiceResponse(dalResponse);
        }
       
        public async Task<ServiceResponse> GetByTripId(int tripId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(tripId), tripId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetTripDetailsByTripId", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetTripDetailsById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(TripDetailsViewModel trip)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveTripDetails",
               _db.CreateListOfSqlParams(trip, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        
    }
}
