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
    public class GuideService : IGuideService
    {
        private readonly IDatabaseContext _db;

        public GuideService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteGuide", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetGuides");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetGuideById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(GuideViewModel guide)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveGuide",
               _db.CreateListOfSqlParams(guide, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(GuideViewModel guide)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpodateGuide",
               _db.CreateListOfSqlParams(guide, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
