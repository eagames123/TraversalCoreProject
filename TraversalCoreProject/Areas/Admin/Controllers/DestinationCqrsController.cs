using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.CQRS.Handlers.DestinationHandlers;
using TraversalCoreProject.CQRS.Queries.DestinationQueries;
using TraversalCoreProject.CQRS.Results.DestinationResults;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationCqrsController : Controller
    {
        private readonly GetAllDestinationQueryHandler _handler;

        private readonly GetDestinationByIdQueryHandler _getDestinationByIdQueryHandler;

        public DestinationCqrsController(GetAllDestinationQueryHandler handler, GetDestinationByIdQueryHandler getDestinationByIdQueryHandler)
        {
            _handler = handler;
            _getDestinationByIdQueryHandler = getDestinationByIdQueryHandler;
        }

        public IActionResult Index()
        {
            List<GetAllDestinationQueryResult> values = _handler.Handle();
            return View(values);
        }

        public IActionResult GetDestination(int id)
        {
            var values = _getDestinationByIdQueryHandler.Handle(new GetDestinationByIdQuery(id));
            return View(values);
        }

    }
}
