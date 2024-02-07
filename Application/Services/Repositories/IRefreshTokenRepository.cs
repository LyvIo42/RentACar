using Core.Security.Entities;
using Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IRefreshTokenRepository : IAsyncRepository<RefreshToken, int>, IRepository<RefreshToken, int>
{
    Task<List<RefreshToken>> GetoldRefreshTokensAsync(int userID,int refreshTokeTTl);
}
