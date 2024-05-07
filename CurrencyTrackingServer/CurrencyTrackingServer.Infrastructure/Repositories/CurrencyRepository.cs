using CurrencyTrackingServer.Domain.Entities;
using CurrencyTrackingServer.Domain.Repositories;
using CurrencyTrackingServer.Infrastructure.Context;
using GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyTrackingServer.Infrastructure.Repositories;
internal sealed class CurrencyRepository : Repository<Currency, ApplicationDbContext>, ICurrencyRepository
{
    public CurrencyRepository(ApplicationDbContext context) : base(context)
    {
    }
}
