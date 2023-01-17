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
    public class CategoryMeneger : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryMeneger(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Create(Category entity)
        {
            _categoryDal.Create(entity);
        }

        public void Delete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public Category GetById(int id)
        {
          return  _categoryDal.GetById(id);
        }

        public List<Category> GetListAll()
        {
            return _categoryDal.GetListAll();
        }

        public void Update(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
