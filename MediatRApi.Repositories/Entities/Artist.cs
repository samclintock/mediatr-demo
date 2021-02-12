using System.Collections.Generic;

namespace MediatRApi.Repositories.Entities
{
    public class Artist
    {
        public string Name { get; set; }

        public IEnumerable<Album> Albums { get; set; }
    }
}
