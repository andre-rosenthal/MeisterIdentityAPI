using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeisterIdentity.Models
{
	/// <summary>
	/// language model
	/// </summary>
    public class Language
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[HiddenInput(DisplayValue = false)]
		public string Id { get; set; }
		public string Culture { get; set; }
		public string CultureName { get; set; }
		public Language() { }
		public Language(string Id, string Culture, string CultureName)
		{
			this.Id = Id;
			this.Culture = Culture;
			this.CultureName = CultureName;
		}
		public Language(Guid Id, string Culture, string CultureName)
		{
			this.Id = Id.ToString();
			this.Culture = Culture;
			this.CultureName = CultureName;
		}
	}
}
