using PruebaBertoni.Models;
using PruebaBertoni.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaBertoni.Services
{
    public interface IAlbumService : IServiceBase<Album>
    {

    }

    public class AlbumsService : IAlbumService
    {
        private readonly string ruta = "https://jsonplaceholder.typicode.com/albums";

        public Album Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Album> GetAll()
        {
            try
            {
                Album album;

                dynamic json = Data.DataJson.GetData(ruta);

                var albums = new List<Album>();

                foreach (var alb in json)
                {
                    album = new Album
                    {
                        id = alb.id,
                        title = alb.title,
                        userId = alb.userId
                    };

                    albums.Add(album);
                }

                return albums;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}