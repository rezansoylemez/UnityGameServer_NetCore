using Core.AuthSecurity.Entities;
using Core.AuthSecurity.JWT;

namespace Core.Security.JWT;

public interface ITokenHelper
{
    //AccessToken CreateToken(User user, IList<OperationClaim> operationClaims);
    AccessToken CreateToken(User user );

    RefreshToken CreateRefreshToken(User user, string ipAddress);
}