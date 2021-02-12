using MediatR;
using MediatRApi.Handlers.Requests;
using MediatRApi.Repositories.Entities;
using MediatRApi.Repositories.Interfaces;
using MediatRApi.Services.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRApi.Handlers
{
    public class SetRatingHandler : IRequestHandler<SetRatingRequest, Unit>
    {
        private readonly IValidationService _validationService;
        private readonly ISongRepository _songRepository;

        public SetRatingHandler(
            IValidationService validationService,
            ISongRepository songRepository)
        {
            _validationService = validationService;
            _songRepository = songRepository;
        }

        public async Task<Unit> Handle(
            SetRatingRequest request,
            CancellationToken cancellationToken = default)
        {
            SetRating setRating = new SetRating
            {
                SongId = request.SongId,
                Rating = request.Rating
            };

            _validationService.Validate<SetRating>(setRating);

            await _songRepository.SetRating(setRating);

            return Unit.Value;
        }
    }
}
