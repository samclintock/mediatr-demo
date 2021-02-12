using MediatR;
using MediatRApi.Handlers.Requests;
using MediatRApi.Repositories.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace MediatRApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WithMediatRController : Controller
    {
        private readonly IMediator _mediator;

        public WithMediatRController(
            IMediator mediator) =>
            _mediator = mediator;

        [HttpGet("get-artist/{artistId:guid}")]
        public Task<Artist> GetArtist(Guid artistId) =>
            _mediator.Send(new GetArtistRequest { ArtistId = artistId });

        [HttpPost("create-album")]
        public Task<Guid> CreateAlbum(Album album) =>
            _mediator.Send(new CreateAlbumRequest { Album = album });

        [HttpPut("set-rating")]
        public void SetRating(SetRating setRating) =>
            _mediator.Send(new SetRatingRequest
            {
                SongId = setRating.SongId, Rating = setRating.Rating
            });
    }
}