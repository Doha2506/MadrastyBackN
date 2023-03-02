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
    public class TeamService : ITeamService
    {
        private readonly IDatabaseContext _db;

        public TeamService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteTeam", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetTeams");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetTeamById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(TeamViewModel team)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveTeam",
               _db.CreateListOfSqlParams(team, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(TeamViewModel team)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateTeam",
               _db.CreateListOfSqlParams(team, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
