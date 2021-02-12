using MediatRApi.Repositories.Entities;
using MediatRApi.Repositories.Interfaces;
using System;
using System.Threading.Tasks;

namespace MediatRApi.Repositories
{
    public class AlbumRepository : IAlbumRepository
    {
        public async Task<Guid> CreateAlbum(Album album)
        {
            throw new NotImplementedException();
        }
    }
}
