﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCServicesBook.Data.Model
{
    public class User
    {
        public virtual Guid UserId { get; set; }
        public virtual string Firstname { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Username { get; set; }
        public virtual string Email { get; set; }
        public virtual byte[] Version { get; set; }
    }
}
