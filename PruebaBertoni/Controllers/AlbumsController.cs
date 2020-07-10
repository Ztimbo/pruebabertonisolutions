using PruebaBertoni.Models;
using PruebaBertoni.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaBertoni.Controllers
{
    public class AlbumsController : Controller
    {
        AlbumsService albumsService = new AlbumsService();
        PhotosService photosService = new PhotosService();
        CommentsService commentsService = new CommentsService();
        Album album = new Album();

        // GET: Albums
        public ActionResult albums()
        {
            var albums = albumsService.GetAll();
            return View(albums);
        }

        public ActionResult albumdetails(int id)
        {
            var photos = photosService.GetPhotosByAlbum(id);
            return View(photos);
        }

        [HttpPost]
        [Route("Albums/comments")]
        public ActionResult comments(int id)
        {
            var comments = commentsService.GetCommentsByPhoto(id);
            return Json(comments);
        }
    }
}