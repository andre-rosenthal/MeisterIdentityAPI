using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeisterIdentity.Models
{
	/// <summary>
	/// Application Model
	/// </summary>
    public class Application : IIdentityModel
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[HiddenInput(DisplayValue = false)]
		public string Id { get; set; }
		public string Name { get; set; }
		public string Code { get; set; }
		public Application() { }
		public Application(string Id, string Name, string Code)
		{
			this.Id = Id;
			this.Name = Name;
			this.Code = Code;
		}
		public Application(Guid Id, string Name, string Code)
		{
			this.Id = Id.ToString();
			this.Name = Name;
			this.Code = Code;
		}
	}
}
