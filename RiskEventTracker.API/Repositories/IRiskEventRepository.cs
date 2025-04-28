using RiskEventTracker.API.Models;
using System;
using System.Collections.Generic;

namespace RiskEventTracker.API.Repositories
{
    public interface IRiskEventRepository
    {
        IEnumerable<RiskEvent> GetAll();
        RiskEvent GetById(Guid id);
        void Add(RiskEvent riskevent);
        void Update(RiskEvent riskevent);
        void Delete(Guid id);
    }
}