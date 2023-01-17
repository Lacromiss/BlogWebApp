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
    public class ContactMeneger : IContactService
    {
        private IContactDal _contactDal;

        public ContactMeneger(IContactDal contactDal)
        {
            _contactDal = contactDal;

        }
        public void Create(Contact entity)
        {
            _contactDal.Create(entity);
        }

        public void Delete(Contact entity)
        {
            _contactDal.Delete(entity);
        }

        public Contact GetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public List<Contact> GetListAll()
        {
         return   _contactDal.GetListAll();
        }

        public void Update(Contact entity)
        {
            _contactDal.Update(entity);
        }
    }
}
