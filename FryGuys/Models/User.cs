﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FryGuys.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Birthday { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public bool GetEmail { get; set; }
        public string Password { get; set; }
    }
}