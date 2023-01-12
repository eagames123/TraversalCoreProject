using System.Threading;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using MediatR;
using TraversalCoreProject.CQRS.Queries.GuideQueries;
using TraversalCoreProject.CQRS.Results.GuideResults;

namespace TraversalCoreProject.CQRS.Handlers.GuideHandlers
{
    public class GetGuideByIdQueryHandler:IRequestHandler<GetGuideByIdQuery,GetByIdQueryResult>
    {
        private readonly Context _context;

        public GetGuideByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetByIdQueryResult> Handle(GetGuideByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.Id);
            return new GetByIdQueryResult
            {
                GuideId = values.GuideId,
                Description = values.Description,
                Name = values.Name
            };
        }
    }
}
