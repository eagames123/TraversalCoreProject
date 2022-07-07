using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CommentManager:ICommentService
    {
        private ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void Tadd(Comment t)
        {
            _commentDal.Insert(t);
        }

        public void Delete(Comment t)
        {
            _commentDal.Delete(t);
        }

        public void Update(Comment t)
        {
            _commentDal.Update(t);
        }

        public List<Comment> TGetList()
        {
            return _commentDal.GetList();
        }

        public Comment TGetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
