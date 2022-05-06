using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using Service.Backend.API.Models;

namespace Service.Backend.API
{
    public class PhotosApi : Base
    {
        private readonly string url = "http://jsonplaceholder.typicode.com/photos";

        public IList<Photo> PhotoApi()
        {
            var request = WebRequest.Create(url);

            request.Method = "GET";

            var data = GetResponse(request, HttpStatusCode.OK);

            return JsonConvert.DeserializeObject<IList<Models.Photo>>(data);
        }
    }
}
