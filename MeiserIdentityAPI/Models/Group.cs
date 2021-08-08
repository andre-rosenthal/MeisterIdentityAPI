using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeisterIdentity.Models
{
	/// <summary>
	/// group model
	/// </summary>
    public class Group
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public string Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public Group() { }
		public Group(string Id, string Name, string Description)
		{
			this.Id = Id;
			this.Name = Name;
			this.Description = Description;
		}
		public Group(Guid Id, string Name, string Description)
		{
			this.Id = Id.ToString();
			this.Name = Name;
			this.Description = Description;
		}
	}
}
