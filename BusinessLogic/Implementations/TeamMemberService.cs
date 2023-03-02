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
    public class TeamMemberService : ITeamMemberService
    {
        private readonly IDatabaseContext _db;

        public TeamMemberService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteTeamMember", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetTeamMembers");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetTeamMembersById", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetByTeamId(int teamId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(teamId), teamId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetTeamMembersByTeamId", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(TeamMemberViewModel member)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveTeamMember",
               _db.CreateListOfSqlParams(member, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(TeamMemberViewModel member)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateTeamMember",
               _db.CreateListOfSqlParams(member, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
