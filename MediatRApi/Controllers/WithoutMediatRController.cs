using MediatRApi.Repositories.Entities;
using MediatRApi.Repositories.Interfaces;
using MediatRApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace MediatRApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WithoutMediatRController : ControllerBase
    {
        private readonly IValidationService _validationService;
        private readonly IArtistRepository _artistRepository;
        private readonly IAlbumRepository _albumRepository;
        private readonly ISongRepository _songRepository;

        public WithoutMediatRController(
            IValidationService validationService,
            IArtistRepository artistRepository,
            IAlbumRepository albumRepository,
            ISongRepository songRepository)
        {
            _validationService = validationService;
            _artistRepository = artistRepository;
            _albumRepository = albumRepository;
            _songRepository = songRepository;
        }

        [HttpGet("get-artist/{artistId:guid}")]
        public async Task<Artist> GetArtist(Guid artistId)
        {
            _validationService.Validate<Guid>(artistId);

            return await _artistRepository.GetArtist(artistId);
        }

        [HttpPost("create-album")]
        public async Task<Guid> CreateAlbum(Album album)
        {
            _validationService.Validate<Album>(album);

            return await _albumRepository.CreateAlbum(album);
        }

        [HttpPut("set-rating")]
        public async Task SetRating(SetRating setRating)
        {
            _validationService.Validate<SetRating>(setRating);

            await _songRepository.SetRating(setRating);
        }
    }
}
