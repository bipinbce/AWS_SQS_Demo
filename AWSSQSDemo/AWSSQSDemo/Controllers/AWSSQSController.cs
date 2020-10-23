using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWSSQSDemo.Models;
using AWSSQSDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AWSSQSDemo.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AWSSQSController : ControllerBase
    {
        private readonly IAWSSQSService _AWSSQSService;

        public AWSSQSController(IAWSSQSService AWSSQSService)
        {
            this._AWSSQSService = AWSSQSService;
        }

        [Route("postMessage")]
        [HttpPost]
        public async Task<IActionResult> PostMessageAsync([FromBody] User user)
        {
            var result = await _AWSSQSService.PostMessageAsync(user);
            return Ok(new { isSucess = result });
        }
        [Route("getAllMessages")]
        [HttpGet]
        public async Task<IActionResult> GetAllMessagesAsync()
        {
            var result = await _AWSSQSService.GetAllMessagesAsync();
            return Ok(result);
        }
        [Route("deleteMessage")]
        [HttpDelete]
        public async Task<IActionResult> DeleteMessageAsync(DeleteMessage deleteMessage)
        {
            var result = await _AWSSQSService.DeleteMessageAsync(deleteMessage);
            return Ok(new { isSucess = result });
        }
    }
}