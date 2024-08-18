using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using XuongMay.Contract.Repositories.Interface;
using XuongMay.Contract.Repositories.IUOW;
using XuongMay.Contract.Services.Interface;
using XuongMay.Repositories.UOW;
using XuongMay.Services.Service;

namespace XuongMay.Services
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRepositories();
            services.AddServices(); // Đăng ký dịch vụ ở đây
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>(); // Đăng ký dịch vụ ở đây
        }
    }
}
