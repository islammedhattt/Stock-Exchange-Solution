﻿using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User:BaseEntity
    {
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? MobileNumbers { get; set; }
        ICollection<Order>? Orders { get; set; }
    }
}
