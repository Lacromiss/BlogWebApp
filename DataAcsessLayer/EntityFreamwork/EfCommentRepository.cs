using DataAcsessLayer.Abstract;
using DataAcsessLayer.Respositories;
using EntityLayerr.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsessLayer.EntityFreamwork
{
    public class EfCommentRepository:GenericRepository<Comment>,ICommentDal
    {
    }
}
