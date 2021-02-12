using MediatR;
using MediatRApi.Repositories.Entities;
using System;

namespace MediatRApi.Handlers.Requests
{
    public class CreateAlbumRequest : IRequest<Guid>
    {
        public Album Album { get; set; }
    }
}
