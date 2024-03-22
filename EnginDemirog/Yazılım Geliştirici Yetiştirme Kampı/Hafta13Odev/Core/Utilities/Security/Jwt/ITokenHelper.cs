using System.Collections.Generic;
using Core.DataAccess.Entities.Concrete;

namespace Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> oparationClaims);
    }
}