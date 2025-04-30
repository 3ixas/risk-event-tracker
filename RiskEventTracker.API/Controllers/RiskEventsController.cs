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

        /// <summary>
        /// Get all risk events.
        /// </summary>
        [HttpGet]
        public ActionResult<IEnumerable<RiskEvent>> GetAll()
        {
            var events = _repository.GetAll();
            return Ok(events);
        }

        /// <summary>
        /// Get a risk event by its ID.
        /// </summary>
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

        /// <summary>
        /// Create a new risk event.
        /// </summary>
        [HttpPost]
        public ActionResult<RiskEvent> Create(RiskEvent riskEvent)
        {
            _repository.Add(riskEvent);
            return CreatedAtAction(nameof(GetById), new { id = riskEvent.Id }, riskEvent);
        }

        /// <summary>
        /// Update an existing risk event.
        /// </summary>
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

        /// <summary>
        /// Delete a risk event by ID.
        /// </summary>
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