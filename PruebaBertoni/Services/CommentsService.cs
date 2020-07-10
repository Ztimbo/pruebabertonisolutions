using PruebaBertoni.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PruebaBertoni.Models;

namespace PruebaBertoni.Services
{
    public interface ICommentsService : IServiceBase<Comment>
    {
        IEnumerable<Comment> GetCommentsByPhoto(int id);
    }
    public class CommentsService : ICommentsService
    {
        private readonly string ruta = "https://jsonplaceholder.typicode.com/photos";

        public Comment Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetCommentsByPhoto(int id)
        {
            try
            {
                Comment comment;

                dynamic json = Data.DataJson.GetData(ruta);

                var comments = new List<Comment>();

                foreach (var cmt in json)
                {
                    if (cmt.postId == id)
                    {
                        comment = new Comment
                        {
                            postId = cmt.postId,
                            id = cmt.id,
                            name = cmt.name,
                            email = cmt.email,
                            body = cmt.body
                        };

                        comments.Add(comment);
                    }
                }

                return comments;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}