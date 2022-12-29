using DataAccessLayer.Concrete;
using TraversalCoreProject.CQRS.Queries.DestinationQueries;
using TraversalCoreProject.CQRS.Results.DestinationResults;
using Destination = EntityLayer.Concrete.Destination;

namespace TraversalCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIdQueryHandler(Context context)
        {
            _context = context;
        }


        public GetDestinationByIdQueryResult Handle(GetDestinationByIdQuery query)
        {
            Destination values = _context.Destinations.Find(query.Id);
            return new GetDestinationByIdQueryResult()
            {
                City = values.City,
                Daynight = values.DayNight,
                Destinationid = values.DestinationId,
                Price = values.Price
            };
        }

    }
}
