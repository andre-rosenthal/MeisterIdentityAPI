using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeisterIdentity.Models
{
	/// <summary>
	/// public class Sap Connection model
	/// </summary>
    public class SapConnection
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public string Id { get; set; }
		public string GatewayUrl { get; set; }
		public string ClientNumber { get; set; }
		public bool IsODataV4 { get; set; }
		public SapConnection(string Id, string GatewayUrl, string ClientNumber, bool IsODataV4)
		{
			this.Id = Id;
			this.GatewayUrl = GatewayUrl;
			this.ClientNumber = ClientNumber;
			this.IsODataV4 = IsODataV4;
		}
		public SapConnection(Guid Id, string GatewayUrl, string ClientNumber, bool IsODataV4)
		{
			this.Id = Id.ToString();
			this.GatewayUrl = GatewayUrl;
			this.ClientNumber = ClientNumber;
			this.IsODataV4 = IsODataV4;
		}
	}
}
