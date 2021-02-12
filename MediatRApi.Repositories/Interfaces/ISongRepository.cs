using MediatRApi.Repositories.Entities;
using System.Threading.Tasks;

namespace MediatRApi.Repositories.Interfaces
{
    public interface ISongRepository
    {
        Task SetRating(SetRating setRating);
    }
}
