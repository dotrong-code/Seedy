using Microsoft.AspNetCore.SignalR;
using System.Collections.Concurrent;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Seed.Infrastructure.Common.SignalR
{
    public class UserHub : Hub
    {
        private static ConcurrentDictionary<string, string> OnlineUsers = new();

        public override async Task OnConnectedAsync()
        {
            var userId = GetUserIdFromToken(); // Extract from JWT
            if (userId != null)
            {
                OnlineUsers[Context.ConnectionId] = userId;
                await Clients.All.SendAsync("UpdateUserList", OnlineUsers.Values);
            }

            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            OnlineUsers.TryRemove(Context.ConnectionId, out _);
            await Clients.All.SendAsync("UpdateUserList", OnlineUsers.Values);
            await base.OnDisconnectedAsync(exception);
        }

        private string GetUserIdFromToken()
        {
            var httpContext = Context.GetHttpContext();
            var token = httpContext?.Request.Query["access_token"].ToString();

            if (string.IsNullOrEmpty(token))
                return null;

            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadToken(token) as JwtSecurityToken;

            var userIdClaim = jwtToken?.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);

            return userIdClaim?.Value;
        }
    }
}
