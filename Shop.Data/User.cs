﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class User:BaseEntity
    {
		public string Username { get; set; }
		public bool IsActive { get; set; }
	}
}
