using RiskEventTracker.API.Models;
using RiskEventTracker.API.Data;
using Microsoft.EntityFrameworkCore;

namespace RiskEventTracker.API.Repositories
{
    public class RiskEventRepository : IRiskEventRepository
    {
        private readonly AppDbContext _context;

        public RiskEventRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<RiskEvent> GetAll()
        {
            return _context.RiskEvents.AsNoTracking().ToList();
        }

        public RiskEvent GetById(Guid id)
        {
            return _context.RiskEvents.Find(id);
        }

        public void Add(RiskEvent riskEvent)
        {
            _context.RiskEvents.Add(riskEvent);
            _context.SaveChanges();
        }

        public void Update(RiskEvent updatedRiskEvent)
        {
            var existing = _context.RiskEvents.Find(updatedRiskEvent.Id);
            if (existing != null)
            {
                existing.Title = updatedRiskEvent.Title;
                existing.Description = updatedRiskEvent.Description;
                existing.Type = updatedRiskEvent.Type;
                existing.Severity = updatedRiskEvent.Severity;
                _context.SaveChanges();
            }
        }

        public void Delete(Guid id)
        {
            var riskEvent = _context.RiskEvents.Find(id);
            if (riskEvent != null)
            {
                _context.RiskEvents.Remove(riskEvent);
                _context.SaveChanges();
            }
        }
    }
}