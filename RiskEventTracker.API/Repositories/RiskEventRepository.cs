using RiskEventTracker.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RiskEventTracker.API.Repositories
{
    public class RiskEventRepository : IRiskEventRepository
    {
        private readonly List<RiskEvent> _riskEvents = new List<RiskEvent>();

        public IEnumerable<RiskEvent> GetAll()
        {
            return _riskEvents;
        }

        public RiskEvent GetById(Guid id)
        {
            return _riskEvents.FirstOrDefault(re => re.Id == id);
        }

        public void Add(RiskEvent riskEvent)
        {
            _riskEvents.Add(riskEvent);
        }

        public void Update(RiskEvent updatedRiskEvent)
        {
            var existing = GetById(updatedRiskEvent.Id);
            if (existing != null)
            {
                existing.Title = updatedRiskEvent.Title;
                existing.Description = updatedRiskEvent.Description;
                existing.Type = updatedRiskEvent.Type;
                existing.Severity = updatedRiskEvent.Severity;
            }
        }

        public void Delete(Guid id)
        {
            var riskEvent = GetById(id);
            if (riskEvent != null)
            {
                _riskEvents.Remove(riskEvent);
            }
        }
    }
}