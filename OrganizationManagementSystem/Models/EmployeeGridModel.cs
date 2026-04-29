using System;
using System.Collections.Generic;
using System.Text;

namespace OrganizationManagementSystem.Models
{
    public class EmployeeGridModel
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string RoleName { get; set; }
        public string Department { get; set; }
        public string Manager { get; set; }
        public int? ManagerId { get; set; }
    }
}
