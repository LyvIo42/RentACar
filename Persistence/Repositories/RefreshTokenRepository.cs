using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Core.Security.Entities;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Persistence.Repositories;

public class RefreshTokenRepository : EfRepositoryBase<RefreshToken, int, BaseDbContext>, IRefreshTokenRepository
{
    public RefreshTokenRepository(BaseDbContext context) : base(context)
    {
    }

    public async Task<List<RefreshToken>> GetoldRefreshTokensAsync(int userID, int refreshTokeTTl)
    {
        List<RefreshToken> tokens = await Query()
        .AsNoTracking()
            .Where(
            r =>
            r.UserId == userID
            && r.Revoked == null
            && r.Expires >= DateTime.UtcNow
            && r.CreatedDate.AddDays(refreshTokeTTl) <= DateTime.UtcNow
            )
            .ToListAsync();
        return tokens;
    }
}



