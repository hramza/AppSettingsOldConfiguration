using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AppSettingsLoader.Dump.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IEnumerable<string> Index()
        {
            return _configuration.AsEnumerable().Select(p => p.Key + " " + p.Value);
        }
    }
}