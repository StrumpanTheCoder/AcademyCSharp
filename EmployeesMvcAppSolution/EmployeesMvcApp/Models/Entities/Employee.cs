﻿using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeesMvcApp.Models.Entities
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int? CompanyId { get; set; }

        public virtual Company Company { get; set; }
    }
}
