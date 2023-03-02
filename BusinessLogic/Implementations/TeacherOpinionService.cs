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
    public class TeacherOpinionService : ITeacherOpinionService
    {
        private readonly IDatabaseContext _db;

        public TeacherOpinionService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteTeacherOpinion", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetTeacherOpinions");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetTeacherOpinionsById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(TeacherOpinionViewModel opinion)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveTeacherOpinion",
               _db.CreateListOfSqlParams(opinion, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(TeacherOpinionViewModel opinion)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateTeacherOpinion",
               _db.CreateListOfSqlParams(opinion, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
