

namespace Yoda.Services.Identity.Services.Login;

public interface ILoginService
{
    Task<Guid> Login(CustomerModel customer);
}