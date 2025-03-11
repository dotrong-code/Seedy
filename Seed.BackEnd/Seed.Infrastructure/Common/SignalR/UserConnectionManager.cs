using System.Collections.Concurrent;

namespace Seed.Infrastructure.Common.SignalR
{
    public class UserConnectionManager
    {
        private static ConcurrentDictionary<string, string> _connections = new();

        public void AddUser(string connectionId, string userId)
        {
            _connections[connectionId] = userId;
        }

        public void RemoveUser(string connectionId)
        {
            _connections.TryRemove(connectionId, out _);
        }

        public IEnumerable<string> GetOnlineUsers()
        {
            return _connections.Values.Distinct();
        }
    }
}
