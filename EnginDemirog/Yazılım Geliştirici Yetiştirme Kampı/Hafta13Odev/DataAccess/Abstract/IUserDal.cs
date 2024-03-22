using System.Collections.Generic;
using Core.DataAccess;
using Core.DataAccess.Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}