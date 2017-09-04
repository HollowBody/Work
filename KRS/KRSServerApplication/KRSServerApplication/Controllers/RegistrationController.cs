using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KRSServerApplication.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KRSServerApplication.Controllers
{
    [Route("api/[controller]/[action]")]
    public class RegistrationController : Controller
    {
        KRSDataBaseContext db;
        public RegistrationController(KRSDataBaseContext context)
        {
            db = context;
        }
        [HttpGet]
        public IEnumerable<ProviderSelect> GetProviders()
        {
            var providers = db.Provider.Select(providerSelect => new ProviderSelect
            {
                IdProvider = providerSelect.IdProvider,
                ProviderLabel = providerSelect.ProviderLabel
            });
            return providers.ToList();
        }
    }
}
