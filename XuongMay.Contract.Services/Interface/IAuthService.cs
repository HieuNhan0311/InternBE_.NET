using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using XuongMay.ModelViews.AuthModelViews;

namespace XuongMay.Contract.Services.Interface
{
    public interface IAuthService
    {
        Task<string> LoginAsync(LoginModelView model);
        Task<IdentityResult> RegisterAsync(RegisterModelView model);
    }
}
