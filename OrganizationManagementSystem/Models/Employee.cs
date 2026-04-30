using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OrganizationManagementSystem.Models
{
    public class Employee
        {
            [Key]
            public int EmployeeId { get; set; }

            [Required]
            [StringLength(200)]
            public string Name { get; set; }

            [Required]
            [EmailAddress]
            [StringLength(200)]
            public string Email { get; set; }

            [Required]
            public int DepartmentId { get; set; }

            [Required]
            public int RoleId { get; set; }

            public int? ManagerId { get; set; }

            public DateTime CreatedDate { get; set; }


            public Department Department { get; set; }
            public Role Role { get; set; }
            public Employee Manager { get; set; }

    }
}