using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuotesApp.Domain.Contracts;
using QuotesApp.Domain.Entities;

namespace QuotesApp.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    [Consumes("application/json")]
    public class QuotesController : ControllerBase
    {
        private readonly IQuotesManager _manager;

        public QuotesController(IQuotesManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Quote>> Get()
        {
            return Ok(_manager.List());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Quote>> Get(int id)
        {
            return Ok(await _manager.Find(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Quote quote)
        {
            await _manager.Add(quote);
            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]Quote quote)
        {
            await _manager.Update(quote);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _manager.Delete(id);
            return NoContent();
        }
    }
}
