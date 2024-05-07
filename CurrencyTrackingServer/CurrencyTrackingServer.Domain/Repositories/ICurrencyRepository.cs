using CurrencyTrackingServer.Domain.Entities;
using GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyTrackingServer.Domain.Repositories;
public interface ICurrencyRepository : IRepository<Currency>
{
}
