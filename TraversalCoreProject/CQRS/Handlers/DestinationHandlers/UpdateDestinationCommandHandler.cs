using DataAccessLayer.Concrete;
using TraversalCoreProject.CQRS.Commands.DestinationCommands;

namespace TraversalCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandler
    {
        private Context _context;

        public UpdateDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateDestinationCommand destinationCommand)
        {
            var values = _context.Destinations.Find(destinationCommand.Destinationid);
            values.City = destinationCommand.City;
            values.DayNight = destinationCommand.Daynight;
            values.Price = destinationCommand.Price;
            _context.SaveChanges();
        }

    }
}
