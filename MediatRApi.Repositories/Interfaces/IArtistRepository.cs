using MediatRApi.Repositories.Entities;
using System;
using System.Threading.Tasks;

namespace MediatRApi.Repositories.Interfaces
{
    public interface IArtistRepository
    {
        Task<Artist> GetArtist(Guid artistId);
    }
}
