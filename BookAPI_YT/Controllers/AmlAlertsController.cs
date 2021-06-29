using BookAPI_YT.Models;
using BookAPI_YT.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI_YT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmlAlertsController : ControllerBase
    {
        private readonly IAmlAlertsRepository _amlAlertsRepository;
        public AmlAlertsController(IAmlAlertsRepository amlAlertsRepository)
        {
            _amlAlertsRepository = amlAlertsRepository;
        }

        [HttpGet("{Client}")]
        public async Task<ActionResult<AmlAlerts>> GetAlerts(int client)
        {

            return await _amlAlertsRepository.GetAlerts(client);
        }
    }
}
