using Core.Security.Entities;
using Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IEmailAuthenticatorRepository : IAsyncRepository<EmailAuthenticator, int>, IRepository<EmailAuthenticator, int>
{
    
}
