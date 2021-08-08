using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace MeisterIdentityAPI.Models
{
    /// <summary>
    /// public class Application user model
    /// </summary>
    public class ApplicationRole 
    {
        public enum AssignedRole
        {
            [Display(Name = "System Administrator")]
            SysAdmin = 0,
            [Display(Name = "Application Administrator")]
            AppAdmin,
            [Display(Name = "External Client Administrator")]
            ClientAdmin,
            [Display(Name = "Portal User")]
            PortalUser,
            [Display(Name = "SAP User")]
            SapUser
        }
        public AssignedRole UserRole { get; set; }
        public string Role { get; set; }

        public ApplicationRole() { }
        public ApplicationRole(string Role)
        {
            this.Role = Role;
        }
    }
}
