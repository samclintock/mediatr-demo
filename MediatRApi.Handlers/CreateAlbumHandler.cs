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
    public class CreateAlbumHandler : IRequestHandler<CreateAlbumRequest, Guid>
    {
        private readonly IValidationService _validationService;
        private readonly IAlbumRepository _albumRepository;

        public CreateAlbumHandler(
            IValidationService validationService,
            IAlbumRepository albumRepository)
        {
            _validationService = validationService;
            _albumRepository = albumRepository;
        }

        public async Task<Guid> Handle(CreateAlbumRequest request,
            CancellationToken cancellationToken = default)
        {
            _validationService.Validate<Album>(request.Album);

            return await _albumRepository.CreateAlbum(request.Album);
        }
    }
}
