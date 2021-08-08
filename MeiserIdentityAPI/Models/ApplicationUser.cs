using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace MeisterIdentity.Models
{
    public class ApplicationUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [HiddenInput(DisplayValue = false)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string RoleId { get; set; }
        public string UserApplicationId { get; set; }
        public string GroupId { get; set; }
        public string TypeId { get; set; }
        public string? SapUserId { get; set; }
        public string? SapConnectionId { get; set; }
        public string Company { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public string SalesGroup { get; set; }
        public string Ein { get; set; }
        public string SalesOrg { get; set; }
        public string SaleChannel { get; set; }
        public ApplicationUser()
        {
            this.Company = string.Empty;
            this.Ein = string.Empty;
            this.SaleChannel = string.Empty;
            this.SalesGroup = string.Empty;
            this.SalesOrg = string.Empty;
            this.ValidFrom = (DateTime)SqlDateTime.MinValue;
            this.ValidTo = (DateTime)SqlDateTime.MaxValue;
        }
        public ApplicationUser(string RoleId, string UserApplicationId, string groupdId, string typeId, string? sapUserId, string? connectionId, DateTime validFrom, DateTime validTo, string company, string ein, string salesGroup, string salesOrg, string salesChannel)
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
            this.Ein = ein;
            if (validTo == DateTime.MaxValue)
                this.ValidTo = (DateTime)SqlDateTime.MaxValue;
            else
                this.ValidTo = validTo;
            this.SalesOrg = salesGroup;
            this.SalesOrg = salesOrg;
            this.SaleChannel = salesChannel;
        }
        public ApplicationUser(Guid roleId, Guid UserApplicationId, Guid groupdId, Guid typeId, Guid? sapUserId, Guid? connectionId, string company, string ein,string salesGroup,string salesOrg, string salesChannel): this(roleId,UserApplicationId,groupdId,typeId,sapUserId,connectionId,DateTime.MinValue,DateTime.MaxValue,company,ein,salesGroup,salesOrg,salesChannel)
        {
        }
        public ApplicationUser(Guid RoleId, Guid UserApplicationId, Guid groupdId, Guid typeId, Guid? sapUserId, Guid? connectionId, DateTime validFrom, DateTime validTo,string company,string ein, string salesGroup,string salesOrg,string salesChannel)
        {
            this.RoleId = RoleId.ToString();
            this.GroupId = groupdId.ToString();
            this.UserApplicationId = UserApplicationId.ToString();
            this.TypeId = typeId.ToString();
            this.SapUserId = sapUserId.ToString();
            this.SapConnectionId = connectionId.ToString();
            this.Company = company;
            this.ValidFrom = validFrom;
            this.Ein = ein;
            this.ValidTo = validTo;
            this.SalesOrg = salesGroup;
            this.SalesOrg = salesOrg;
            this.SaleChannel = salesChannel;
        }
    }
}
