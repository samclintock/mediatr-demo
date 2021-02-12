using MediatRApi.Repositories.Entities;
using System;
using System.Threading.Tasks;

namespace MediatRApi.Repositories.Interfaces
{
    public interface IAlbumRepository
    {
        Task<Guid> CreateAlbum(Album album);
    }
}
