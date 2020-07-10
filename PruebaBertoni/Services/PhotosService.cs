using PruebaBertoni.Models;
using PruebaBertoni.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaBertoni.Services
{
    public interface IPhotosService : IServiceBase<Photo>
    {
        IEnumerable<Photo> GetPhotosByAlbum(int id);
    }
    public class PhotosService : IPhotosService
    {
        private readonly string ruta = "https://jsonplaceholder.typicode.com/photos";


        public Photo Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Photo> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Photo> GetPhotosByAlbum(int id)
        {
            try
            {
                Photo photo;

                dynamic json = Data.DataJson.GetData(ruta);

                var photos = new List<Photo>();

                foreach (var pht in json)
                {
                    if(pht.albumId == id)
                    {
                        photo = new Photo
                        {
                            id = pht.id,
                            title = pht.title,
                            url = pht.url,
                            thumbnailUrl = pht.thumbnailUrl,
                            albumId = pht.albumId
                        };

                        photos.Add(photo);
                    }
                }

                return photos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}