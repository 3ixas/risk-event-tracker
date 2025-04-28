using Microsoft.AspNetCore.Mvc;
using RiskEventTracker.API.Models;
using RiskEventTracker.API.Repositories;

namespace RiskEventTracker.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RiskEventsController : ControllerBase
    {
        private readonly IRiskEventRepository _repository;

        public RiskEventsController(IRiskEventRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<RiskEvent>> GetAll()
        {
            var events = _repository.GetAll();
            return Ok(events);
        }

        [HttpGet("{id}")]
        public ActionResult<RiskEvent> GetById(Guid id)
        {
            var riskEvent = _repository.GetById(id);
            if (riskEvent == null)
            {
                return NotFound();
            }
            return Ok(riskEvent);
        }

        [HttpPost]
        public ActionResult<RiskEvent> Create(RiskEvent riskEvent)
        {
            _repository.Add(riskEvent);
            return CreatedAtAction(nameof(GetById), new { id = riskEvent.Id }, riskEvent);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, RiskEvent updatedRiskEvent)
        {
            var existingRiskEvent = _repository.GetById(id);
            if (existingRiskEvent == null)
            {
                return NotFound();
            }

            updatedRiskEvent.Id = id;
            _repository.Update(updatedRiskEvent);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var existingRiskEvent = _repository.GetById(id);
            if (existingRiskEvent == null)
            {
                return NotFound();
            }

            _repository.Delete(id);
            return NoContent();
        }
    }
}