using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tv.Core.DataAccess.Concrete.EF;
using tv.Core.Entity.Concrete;
using tv.DataAccess.Abstract;
using tv.DataAccess.Concrete.EF.Context;

namespace tv.DataAccess.Concrete.EF
{
    public class EfUserDal : EfBaseEntityRepository<User, TakasContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var ctx = new TakasContext())
            {
                var result = ctx.UserOperationClaims
                    .Where(uoc => uoc.UserId == user.Id)
                    .Join(
                            ctx.OperationClaims,
                            userOperationClaim => userOperationClaim.OperationClaimId,
                            operationClaim => operationClaim.Id,
                            (userOperationClaim, operationClaim) => new OperationClaim
                            {
                                Id = operationClaim.Id,
                                Name = operationClaim.Name
                            });
                return result.ToList();
            }
        }
    }
}
