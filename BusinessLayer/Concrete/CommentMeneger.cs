using BusinessLayer.Abstract;
using DataAcsessLayer.Abstract;
using EntityLayerr.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentMeneger : ICommentService
    {
        private ICommentDal _commenDal;

        public CommentMeneger(ICommentDal commentDal)
        {
            _commenDal = commentDal;

        }
        public void Create(Comment entity)
        {
            _commenDal.Create(entity);
        }

        public void Delete(Comment entity)
        {
            _commenDal.Delete(entity);
        }

        public Comment GetById(int id)
        {
           return _commenDal.GetById(id);
        }

        public List<Comment> GetListAll()
        {
            return _commenDal.GetListAll();
        }

        public void Update(Comment entity)
        {
            _commenDal.Update(entity);
        }
    }
}
