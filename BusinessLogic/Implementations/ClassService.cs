using BusinessLogic.Abstractions;
using BusinessLogic.Contexts;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class ClassService : IClassService
    {
        private readonly IDatabaseContext _db;

        public ClassService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int ClassId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(ClassId), ClassId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteFromClass", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetClass");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int ClassId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(ClassId), ClassId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetClassById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetClassByLevelId(int ClassLevel)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(ClassLevel), ClassLevel.ToString());

            var dalResponse = await _db.ExecuteQuery("GetClassByLevelId", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetClassCountForTeacher(int EmpId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(EmpId), EmpId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetClassCountForTeacher", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> Save(ClassViewModel Class)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveClass",
              _db.CreateListOfSqlParams(Class, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(ClassViewModel Class)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateClass",
               _db.CreateListOfSqlParams(Class, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
    