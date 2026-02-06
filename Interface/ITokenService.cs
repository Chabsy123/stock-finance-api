using stock_finance_api.Models;

namespace stock_finance_api.Interface
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
