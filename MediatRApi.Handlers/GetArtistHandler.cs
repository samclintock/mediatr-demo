using MediatR;
using MediatRApi.Handlers.Requests;
using MediatRApi.Repositories.Entities;
using MediatRApi.Repositories.Interfaces;
using MediatRApi.Services.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRApi.Handlers
{
    public class GetArtistHandler : IRequestHandler<GetArtistRequest, Artist>
    {
        private readonly IValidationService _validationService;
        private readonly IArtistRepository _artistRepository;

        public GetArtistHandler(
            IValidationService validationService,
            IArtistRepository artistRepository)
        {
            _validationService = validationService;
            _artistRepository = artistRepository;
        }

        public async Task<Artist> Handle(
            GetArtistRequest request,
            CancellationToken cancellationToken = default)
        {
            _validationService.Validate<Guid>(request.ArtistId);

            return await _artistRepository.GetArtist(request.ArtistId);
        }
    }
}
