﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Entities
{
    public class User
    {

        public int UserId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Contact { get; set; }
    }
}
