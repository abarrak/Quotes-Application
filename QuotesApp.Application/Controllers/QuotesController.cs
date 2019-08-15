using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using QuotesApp.Application.DTOs;
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
        private readonly IMapper _mapper;

        public QuotesController(IQuotesManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<QuoteOutputDto>> Get()
        {
            var records = _manager.List();
            return Ok(_mapper.Map<IEnumerable<QuoteOutputDto>>(records));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<QuoteOutputDto>> Get(int id)
        {
            var record = await _manager.Find(id);
            return Ok(_mapper.Map<QuoteOutputDto>(record));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]QuoteInputDto quote)
        {
            var model = _mapper.Map<Quote>(quote);
            await _manager.Add(model);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]QuoteInputDto quote)
        {
            var model = _mapper.Map<Quote>(quote);
            model.Id = id;
            await _manager.Update(model);

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
