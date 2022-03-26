﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? Birthdate { get; set; }
    }
}