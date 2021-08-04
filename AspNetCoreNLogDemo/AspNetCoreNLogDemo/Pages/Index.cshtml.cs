using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreNLogDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

 

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog injected into IndexModel");
        }

        public void OnGet()
        {
            _logger.LogError("Hello, this is the index!");
        }
    }
}
