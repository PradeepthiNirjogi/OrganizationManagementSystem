using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OrganizationManagementSystem.Models
{
    public class Department
        {
        [Key]
        public int DepartmentId { get; set; }

        [Required]
        [StringLength(150)]
        public string DepartmentName { get; set; }
        }
    }
