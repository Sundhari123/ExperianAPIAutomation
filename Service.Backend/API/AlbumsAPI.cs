using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using Service.Backend.Models;

namespace Service.Backend.API
{
    public class AlbumsApi :Base
    {
        private readonly string url = "http://jsonplaceholder.typicode.com/albums";

        public IList<Album> GetAlbumApi()
        {
            var request = WebRequest.Create(url);

            request.Method = "GET";

            var data = GetResponse(request, HttpStatusCode.OK);

            return JsonConvert.DeserializeObject<IList<Album>>(data);
        }

        //to check post method

        //public AlbumId PostAlbumApi()
        //{
        //    var request = WebRequest.Create(url);

        //    request.Method = "Post";

        //    var postData = new Album()
        //    {
        //        Id = 101,
        //        Title = "enim repellat iste enim repellat iste",
        //        UserId = 10
        //    };

        //    byte[] byteArray = Encoding.UTF8.GetBytes(postData.ToString());

        //    request.ContentType = "application/x-www-form-urlencoded";

        //    request.ContentLength = byteArray.Length;

        //    Stream dataStream = request.GetRequestStream();

        //    dataStream.Write(byteArray, 0, byteArray.Length);

        //    var data = GetResponse(request, HttpStatusCode.Created);

        //    return JsonConvert.DeserializeObject<AlbumId>(data);
        //}

    }
}
