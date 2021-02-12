using System;
using System.Collections.Generic;

namespace MediatRApi.Repositories.Entities
{
    public class Album
    {
        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public IEnumerable<Song> Songs { get; set; }
    }
}
