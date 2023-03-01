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
    public class MessageEmailService : IMessageEmailService
    {
        private readonly IDatabaseContext _db;

        public MessageEmailService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetMessageEmailById", pars);
            return new ServiceResponse(dalResponse);
        }

    }
}
