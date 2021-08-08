using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MeisterIdentityAPI.Models;

namespace MeisterIdentityAPI.Common
{
    public class CommonController<CTR> : ControllerBase
    {
        private string Endpoint { get; set; }
        private readonly IConfiguration _config;
        private readonly ILogger<CTR> logger;
        private readonly UserManager<ApplicationUser> userManager;

        public CommonController(ILogger<CTR> logger)
        {
            this.logger = logger;
        }

        public ILogger<CTR> GetLogger()
        {
            return logger;
        }
    }
}