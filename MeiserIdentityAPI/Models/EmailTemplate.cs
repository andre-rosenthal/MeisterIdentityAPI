using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeisterIdentity.Models
{
	/// <summary>
	/// email templates model
	/// </summary>
    public class EmailTemplate
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[HiddenInput(DisplayValue = false)]
		public string Id { get; set; }
		public string LanguageId { get; set; }
		public string Subject { get; set; }
		public string Header { get; set; }
		public string Body { get; set; }
		public string Footer { get; set; }
		public EmailTemplate(string Id, string LanguageId, string Subject, string Header, string Body, string Footer)
		{
			this.Id = Id;
			this.LanguageId = LanguageId;
			this.Subject = Subject;
			this.Header = Header;
			this.Body = Body;
			this.Footer = Footer;
		}
		public EmailTemplate(Guid Id, Guid LanguageId, string Subject, string Header, string Body, string Footer)
		{
			this.Id = Id.ToString();
			this.LanguageId = LanguageId.ToString();
			this.Subject = Subject;
			this.Header = Header;
			this.Body = Body;
			this.Footer = Footer;
		}
	}
}
