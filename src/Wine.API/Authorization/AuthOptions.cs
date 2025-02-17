using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace WineCatalog.API.Authorization
{
    public class AuthOptions
    {
        public const string ISSUER = "WineCatalogAuthServer";
        public const string AUDIENCE = "WineCatalogAuthClient";
        const string KEY = "somesecretkeyforwinecatalogsercret_12345!@";
        public static SymmetricSecurityKey GetSymmetricSecurityKey() => new(Encoding.UTF8.GetBytes(KEY));
    }
}
