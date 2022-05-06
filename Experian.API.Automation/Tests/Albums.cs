using System;
using System.Linq;
using NUnit.Framework;

namespace Experian.API.Automation.Tests
{
    public class Albums
    {
        Service.Backend.API.AlbumsApi albums = new Service.Backend.API.AlbumsApi();

        [TestCaseSource(typeof(TestCaseData.AlbumTestCaseData), nameof(TestCaseData.AlbumTestCaseData.AlbumsTestData))]
        public void AlbumTests(int userId, int albumCount)
        {
            var getAlbums = albums.GetAlbumApi();

            var userDetails = getAlbums.Where(a => a.UserId.Equals(userId));

            Assert.That(userDetails.Count().Equals(albumCount), $"Expected album count is {albumCount} but its {userDetails.Count()}");

            Console.WriteLine("Album Test cases are successful");

        }
    }
}
