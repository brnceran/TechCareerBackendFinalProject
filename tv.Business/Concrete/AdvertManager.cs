using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tv.Business.Abstract;
using tv.Business.Constants;
using tv.Core.Utilities.Results;
using tv.DataAccess.Abstract;
using tv.Entity.Concrete;

namespace tv.Business.Concrete
{
    public class AdvertManager : IAdvertService
    {
        private IAdvertDal _advertDal;
        public AdvertManager(IAdvertDal advertDal)
        {
            _advertDal = advertDal;
        }

        public IResult Add(Advert advert)
        {
            _advertDal.Add(advert);
            return new SuccessResult(Messages.AddSuccessful);
        }

        public IResult Delete(Advert advert)
        {
            _advertDal.Delete(advert);
            return new SuccessResult(Messages.DeleteSuccessful);
        }

        public IDataResult<List<Advert>> GetAll()
        {
            return new SuccessDataResult<List<Advert>>(_advertDal.GetList());
        }

        public IDataResult<List<Advert>> GetByCategory(int categoryId)
        {
            return new SuccessDataResult<List<Advert>>(_advertDal.GetList(ss=>ss.CategoryId==categoryId));
        }

        public IDataResult<Advert> GetById(int id)
        {
            return new SuccessDataResult<Advert>(_advertDal.Get(ss => ss.Id == id));
        }

        public IDataResult<List<Advert>> GetByOwner(int ownerId)
        {
            return new SuccessDataResult<List<Advert>>(_advertDal.GetList(ss => ss.OwnerId== ownerId));
        }

        public IResult Update(Advert advert)
        {
            _advertDal.Update(advert);
            return new SuccessResult(Messages.UpdateSuccessful);
        }
    }
}
