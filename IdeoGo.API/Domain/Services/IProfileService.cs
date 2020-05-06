﻿using IdeoGo.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdeoGo.API.Domain.Services
{
    interface IProfileService
    {
        Task<IEnumerable<Profile>> ListAsync();
    }
}