using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OrganizationManagementSystem.Models
{
    public class Employee
        {
            public int EmployeeId { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public int DepartmentId { get; set; }
            public int RoleId { get; set; }
            public int? ManagerId { get; set; }
            public DateTime CreatedDate { get; set; }


            public Department Department { get; set; }
            public Role Role { get; set; }
            public Employee Manager { get; set; }

    }
}