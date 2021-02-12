using MediatRApi.Repositories.Entities;
using MediatRApi.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MediatRApi.Repositories
{
    public class ArtistRepository : IArtistRepository
    {
        public async Task<Artist> GetArtist(Guid artistId)
        {
            Artist artist = new Artist
            {
                Name = "Oasis",
                Albums = new List<Album>
                {
                    new Album
                    {
                        Name = "(What's the Story) Morning Glory?",
                        ReleaseDate = new DateTime(1995, 10, 2),
                        Songs = new List<Song>()
                        {
                            new Song
                            {
                                Name = "Hello",
                                Rating = 3
                            },
                            new Song
                            {
                                Name = "Roll with It",
                                Rating = 4
                            },
                            new Song
                            {
                                Name = "Wonderwall",
                                Rating = 5
                            },
                            new Song
                            {
                                Name = "Don't Look Back in Anger",
                                Rating = 5
                            },
                            new Song
                            {
                                Name = "Hey Now!",
                                Rating = 4
                            },
                            new Song
                            {
                                Name = "Some Might Say",
                                Rating = 5
                            },
                            new Song
                            {
                                Name = "Cast No Shadow",
                                Rating = 4
                            },
                            new Song
                            {
                                Name = "She's Electric",
                                Rating = 4
                            },
                            new Song
                            {
                                Name = "Morning Glory",
                                Rating = 3
                            },
                            new Song
                            {
                                Name = "Champagne Supernova",
                                Rating = 4
                            }
                        }
                    }
                }
            };

            return artist;
        }
    }
}
