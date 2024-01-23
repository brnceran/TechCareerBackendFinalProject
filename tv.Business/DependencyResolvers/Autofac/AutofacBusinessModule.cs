using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tv.Business.Abstract;
using tv.Business.Concrete;
using tv.Core.Utilities.Security.Jwt;
using tv.DataAccess.Abstract;
using tv.DataAccess.Concrete.EF;

namespace tv.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Advert
            builder.RegisterType<AdvertManager>().As<IAdvertService>();
            builder.RegisterType<EfAdvertDal>().As<IAdvertDal>();
            //Category
            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();
            //User
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();
            //Auth
            builder.RegisterType<AuthManager>().As<IAuthService>();
            //TokenHelper
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

        }
    }
}
