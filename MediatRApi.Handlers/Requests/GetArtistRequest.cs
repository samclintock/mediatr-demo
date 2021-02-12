using MediatR;
using MediatRApi.Repositories.Entities;
using System;

namespace MediatRApi.Handlers.Requests
{
    public class GetArtistRequest : IRequest<Artist>
    {
        public Guid ArtistId { get; set; }
    }
}
