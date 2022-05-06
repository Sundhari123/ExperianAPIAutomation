using System;
using System.Linq;
using NUnit.Framework;

namespace Experian.API.Automation.Tests
{
    public class Photos
    {
        Service.Backend.API.PhotosApi photos = new Service.Backend.API.PhotosApi();

        Service.Backend.API.AlbumsPhotosApi albumPhotos = new Service.Backend.API.AlbumsPhotosApi();

        [TestCaseSource(typeof(TestCaseData.PhotoTestCaseData), nameof(TestCaseData.PhotoTestCaseData.PhotoTestData))]
        public void PhotosTests(int albumId, int photoCount)
        {
            var getphotos = photos.PhotoApi();

            var albumDetails = getphotos.Where(a => a.AlbumId.Equals(albumId));

            Assert.That(albumDetails.Count().Equals(photoCount), $"Expected photo count is {photoCount} but its {albumDetails.Count()}");

            Console.WriteLine("Photo Test cases are successful");
        }

        [TestCaseSource(typeof(TestCaseData.PhotoTestCaseData),
            nameof(TestCaseData.PhotoTestCaseData.PhotoAlbumTestData))]
        public void PhotosTests(int userId, int albumId, int photoCount)
        {
            var getAlbumPhotos = albumPhotos.AlbumPhotosApi();

            var photoCountDetails = getAlbumPhotos.Where(a => a.UserId.Equals(userId) && a.AlbumId.Equals(albumId));

            var photoCounts = photoCountDetails.Select(a => a.Id).Count();

            Assert.That(photoCounts.Equals(photoCount),$"Expected Album Id with photo count is {albumId} {photoCount} but its {photoCountDetails.First().AlbumId} {photoCounts} for user {userId}");

            Console.WriteLine("PhotoAlbum Test cases are successful");
        }

    }
}
