using MediatRApi.Repositories.Entities;
using MediatRApi.Repositories.Interfaces;
using System;
using System.Threading.Tasks;

namespace MediatRApi.Repositories
{
    public class SongRepository : ISongRepository
    {
        public async Task SetRating(SetRating setRating)
        {
            throw new NotImplementedException();
        }
    }
}
