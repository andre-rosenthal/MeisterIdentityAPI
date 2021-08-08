using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace MeisterIdentityAPI.Models
{
    public class ApplicationUser: IIdentityModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [HiddenInput(DisplayValue = false)]
        public string Id { get; set; }
        [Required]
        [StringLength(18, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
        [DataType(DataType.Password)]
        public string Password {  get; set; }
        [Required]
        [StringLength(18, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [Display(Name = "User Name")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string? RoleId { get; set; }
        public string? UserApplicationId { get; set; }
        public string? GroupId { get; set; }
        public string? TypeId { get; set; }
        public string? SapUserId { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "SAP User Password")]
        public string? SapUserPassword { get; set; }
        public string? SapConnectionId { get; set; }
        public string? Company { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public ApplicationUser()
        {
            this.Company = string.Empty;
            this.ValidFrom = (DateTime)SqlDateTime.MinValue;
            this.ValidTo = (DateTime)SqlDateTime.MaxValue;
        }
        public ApplicationUser(string RoleId, string UserApplicationId, string groupdId, string typeId, string? sapUserId, string? connectionId, DateTime validFrom, DateTime validTo, string company)
        {
            this.RoleId = RoleId;
            this.GroupId = groupdId;
            this.UserApplicationId = UserApplicationId;
            this.TypeId = typeId;
            this.SapUserId = sapUserId;
            this.SapConnectionId = connectionId;
            this.Company = company;
            if (validFrom == DateTime.MinValue)
                this.ValidFrom = (DateTime)SqlDateTime.MinValue;
            else
                this.ValidFrom = validFrom;
            if (validTo == DateTime.MaxValue)
                this.ValidTo = (DateTime)SqlDateTime.MaxValue;
            else
                this.ValidTo = validTo;
      }
        public ApplicationUser(Guid roleId, Guid UserApplicationId, Guid groupdId, Guid typeId, Guid? sapUserId, Guid? connectionId, string company): this(roleId,UserApplicationId,groupdId,typeId,sapUserId,connectionId,DateTime.MinValue,DateTime.MaxValue,company)
        {
        }
        public ApplicationUser(Guid RoleId, Guid UserApplicationId, Guid groupdId, Guid typeId, Guid? sapUserId, Guid? connectionId, DateTime validFrom, DateTime validTo,string company)
        {
            this.RoleId = RoleId.ToString();
            this.GroupId = groupdId.ToString();
            this.UserApplicationId = UserApplicationId.ToString();
            this.TypeId = typeId.ToString();
            this.SapUserId = sapUserId.ToString();
            this.SapConnectionId = connectionId.ToString();
            this.Company = company;
            this.ValidFrom = validFrom;
            this.ValidTo = validTo;
        }
    }
}
