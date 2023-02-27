﻿using BusinessLogic.Abstractions;
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
    public class OtherStudentsSlidesService : IOtherStudentsSlidesService
    {
        private readonly IDatabaseContext _db;

        public OtherStudentsSlidesService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteOtherStudentsSlides", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetOtherStudentsSlides");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetOtherStudentsSlidesById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(OtherStudentsSlides student)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveOtherStudentsSlides",
               _db.CreateListOfSqlParams(student, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(OtherStudentsSlides student)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateOtherStudentSlides",
               _db.CreateListOfSqlParams(student, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
