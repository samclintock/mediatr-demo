using System;

namespace MediatRApi.Repositories.Entities
{
    public class SetRating
    {
        public Guid SongId { get; set; }

        public int Rating { get; set; }
    }
}
