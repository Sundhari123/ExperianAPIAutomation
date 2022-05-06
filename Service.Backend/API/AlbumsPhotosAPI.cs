using System.Collections.Generic;
using System.Linq;
using Service.Backend.API.Models;

namespace Service.Backend.API
{
    public class AlbumsPhotosApi
    {
        public IEnumerable<AlbumPhoto> AlbumPhotosApi()
        {
            var albums = new AlbumsApi().GetAlbumApi();

            var photos = new PhotosApi().PhotoApi();

            return from l1 in albums
                join l2 in photos
                    on l1.Id equals l2.AlbumId
                select new AlbumPhoto()
                {
                    AlbumId = l2.AlbumId , UserId = l1.UserId, Id = l2.Id

                };
        }
    }
}
