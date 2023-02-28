﻿using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IEvaluationItemService
    {
        Task<ServiceResponse> Save(EvaluationItems item);

    }
}
