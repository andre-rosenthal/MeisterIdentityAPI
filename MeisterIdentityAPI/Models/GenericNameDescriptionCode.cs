using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeisterIdentityAPI.Models
{
	/// <summary>
	/// generic name value code tuple model
	/// </summary>
    public class GenericNameDescriptionCode
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[HiddenInput(DisplayValue = false)]
		public string Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Code { get; set; }
		public GenericNameDescriptionCode(string Id, string Name, string Description, string Code)
		{
			this.Id = Id;
			this.Name = Name;
			this.Description = Description;
			this.Code = Code;
		}
		public GenericNameDescriptionCode(Guid Id, string Name, string Description, string Code)
		{
			this.Id = Id.ToString();
			this.Name = Name;
			this.Description = Description;
			this.Code = Code;
		}
	}
}
