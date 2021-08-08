using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeisterIdentityAPI.Models
{
	/// <summary>
	/// file management model
	/// </summary>
	public class FileManagement
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[HiddenInput(DisplayValue = false)]
		public string Id { get; set; }
		public string Name { get; set; }
		public string UpdatedBy { get; set; }
		public DateTime UpdateOn { get; set; }
		public string Content { get; set; }
		public FileManagement(string Id, string Name, string UpdatedBy, DateTime UpdateOn, string Content)
		{
			this.Id = Id;
			this.Name = Name;
			this.UpdatedBy = UpdatedBy;
			this.UpdateOn = UpdateOn;
			this.Content = Content;
		}
		public FileManagement(Guid Id, string Name, string UpdatedBy, DateTime UpdateOn, string Content)
		{
			this.Id = Id.ToString();
			this.Name = Name;
			this.UpdatedBy = UpdatedBy;
			this.UpdateOn = UpdateOn;
			this.Content = Content;
		}
	}
}
