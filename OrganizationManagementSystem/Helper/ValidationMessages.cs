using System;
using System.Collections.Generic;
using System.Text;

namespace OrganizationManagementSystem.Helpers
{
    public static class ValidationMessages
    {
        public const string NameRequired = "⚠️Name is Invalid or already taken";
        //public const string NameInvalid = "Name Cannot Be Blank";

        public const string EmailRequired = "⚠️Email is required or already taken";
        public const string EmailInvalid = "⚠️Invalid email address (example: user@org.com)";

        public const string RoleRequired = "⚠️Please select a role";
        public const string DepartmentRequired = "⚠️Please select a department";
        public const string ManagerRequired = "⚠️Manager is required";
    }
}