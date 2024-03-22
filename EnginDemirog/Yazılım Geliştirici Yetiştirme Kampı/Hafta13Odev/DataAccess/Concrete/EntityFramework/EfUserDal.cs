using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.Entities.Concrete;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, CarDbContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using var context = new CarDbContext();
            IQueryable<OperationClaim> result = from operationClaim in context.OperationClaims
                join userOperationClaim in context.UserOperationClaims
                    on operationClaim.Id equals userOperationClaim.OperationClaimId
                where userOperationClaim.UserId == user.Id
                select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
            return result.ToList();
        }
    }
}