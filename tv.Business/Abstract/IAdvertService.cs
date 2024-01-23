using tv.Core.Utilities.Results;
using tv.Entity.Concrete;

namespace tv.Business.Abstract
{
    public interface IAdvertService
    {
        IResult Add(Advert advert);
        IResult Update(Advert advert);
        IResult Delete(Advert advert);
        IDataResult<Advert> GetById (int id);
        IDataResult<List<Advert>> GetAll();
        IDataResult<List<Advert>> GetByCategory(int categoryId);
        IDataResult<List<Advert>> GetByOwner(int ownerId);        
    }
}
