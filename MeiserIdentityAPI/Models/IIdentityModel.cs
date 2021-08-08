using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeisterIdentityAPI.Models
{
    /// <summary>
    /// public interface IIdentity
    /// </summary>
    public interface IIdentityModel
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; }
    }
}
