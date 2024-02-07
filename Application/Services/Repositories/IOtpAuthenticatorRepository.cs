using Core.Security.Entities;
using Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IOtpAuthenticatorRepository : IAsyncRepository<OtpAuthenticator, int>, IRepository<OtpAuthenticator, int>
{
   
}
