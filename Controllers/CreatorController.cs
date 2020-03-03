using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MediatR_latihan.Entity;

namespace MediatR_latihan.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreatorController : ControllerBase
    {
        private readonly ILogger<CreatorController> _logger;

        public CreatorController(ILogger<CreatorController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Add(Creator creator)
        {
            return Ok(new { success = true });
        }
    }
}
