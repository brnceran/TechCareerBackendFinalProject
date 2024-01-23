using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tv.Core.DataAccess.Concrete.EF;
using tv.DataAccess.Abstract;
using tv.DataAccess.Concrete.EF.Context;
using tv.Entity.Concrete;

namespace tv.DataAccess.Concrete.EF
{
    public class EfCategoryDal : EfBaseEntityRepository<Category, TakasContext>, ICategoryDal
    {
    }
}
