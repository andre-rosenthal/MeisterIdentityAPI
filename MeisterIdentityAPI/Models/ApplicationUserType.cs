using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using MeisterIdentityAPI.Common;
namespace MeisterIdentityAPI.Models
{
	/// <summary>
	/// Aplication User Type model
	/// </summary>
    public class ApplicationUserType
	{
		public enum PortalUserTypes
		{
			[Display(Name = "Internal")]
			Internal = 0,
			[Display(Name = "External")]
			External,
			[Display(Name = "SAP UserName")]
			SapNamed,
			[Display(Name = "SAP Service Account")]
			SapTechnical,
			[Display(Name = "Test")]
			Test
		}
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[HiddenInput(DisplayValue = false)]
		public string Id { get; set; }
		public string UserRole { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public ApplicationUserType()
        {
			this.Name = string.Empty;
			this.UserRole = string.Empty;
			this.Description = string.Empty;
        }
		public ApplicationUserType(string Id, string userRole, string Name, string Description)
		{
			this.Id = Id;
			this.UserRole = userRole;
			this.Name = Name;
			this.Description = Description;
		}
		public ApplicationUserType(Guid Id, PortalUserTypes userRole,string Name, string Description)
		{
			this.Id = Id.ToString();
			this.UserRole = Utilities.GetEnumDescription<PortalUserTypes>(userRole);
			this.Name = Name;
			this.Description = Description;
		}
	}
}
