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
    public class AchievementLevelService : IAchievementLevelService
    {
        private readonly IDatabaseContext _db;

        public AchievementLevelService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteAchievementService", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetAchivementLevels");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetAchivementLevelsById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(AchivementLevelViewModel achivementLevel)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveAchivementLevel",
               _db.CreateListOfSqlParams(achivementLevel, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(AchivementLevelViewModel achivementLevel)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateAchivementLevel",
               _db.CreateListOfSqlParams(achivementLevel, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
