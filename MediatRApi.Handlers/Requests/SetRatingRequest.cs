using MediatR;
using System;

namespace MediatRApi.Handlers.Requests
{
    public class SetRatingRequest : IRequest<Unit>
    {
        public Guid SongId { get; set; }

        public int Rating { get; set; }
    }
}
