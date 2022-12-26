using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using TraversalCoreProject.CQRS.Queries.DestinationQueries;
using TraversalCoreProject.CQRS.Results.DestinationResults;

namespace TraversalCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationQueryHandler
    {
        private readonly Context _context;

        public GetAllDestinationQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetAllDestinationQueryResult> Handle()
        {
            List<GetAllDestinationQueryResult> values = _context.Destinations.Select(x => new GetAllDestinationQueryResult()
            {
                id = x.DestinationId,
                Capacity = x.Capacity,
                City = x.City,
                Daynight = x.DayNight,
                Price = x.Price
            }).AsNoTracking().ToList();

            return values;
        }

    }
}
