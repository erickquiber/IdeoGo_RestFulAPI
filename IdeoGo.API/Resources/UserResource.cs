﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdeoGo.API.Resources
{
    public class UserResource
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime Datesignup { get; set; }

        //public ProfileResource Profile { get; set; }
    }
}
