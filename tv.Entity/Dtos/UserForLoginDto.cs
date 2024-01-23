﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tv.Core.Entity.Abstract;

namespace tv.Entity.Dtos
{
    public class UserForLoginDto :IDto
    {
        public string Email{ get; set; }
        public string Password{ get; set; }
    }
}