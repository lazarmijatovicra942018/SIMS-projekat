﻿using klinika.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klinika.Model
{
    internal class User
    {
        public string jmbg { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public string name { get; set; }

        public string phoneNumber { get; set; }

        public UserType userType { get; set; }

        public bool isBaned { get; set; }

    }
}
