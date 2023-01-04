using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.CQRS.Queries.GuideQueries;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    public class DestinationMediaTRController : Controller
    {
        private readonly IMediator _mediator;

        public DestinationMediaTRController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllGuideQuery());
            return View(values);
        }
    }
}
