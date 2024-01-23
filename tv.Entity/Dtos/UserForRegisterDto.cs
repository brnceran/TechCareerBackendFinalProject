﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tv.Core.Entity.Abstract;

namespace tv.Entity.Dtos
{
    public class UserForRegisterDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
    }
}
