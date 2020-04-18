﻿using MVCTrial.Helper;
using System;

namespace MVCTrial_Core.Entities
{
    public class Client
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Contact Contact { get; set; }
        public bool IsActive { get; set; }
        public Type type { get; set; }
    }
}
