using System;
namespace StackExchange.Redis.StackExchange.Redis
{
    interface IConnectionMultiplexer
    {
        bool AllowConnect { get; set; }
        string ClientName { get; }
        void Close(bool allowCommandsToComplete = true);
        global::System.Threading.Tasks.Task CloseAsync(bool allowCommandsToComplete = true);
        string Configuration { get; }
        event EventHandler<global::StackExchange.Redis.EndPointEventArgs> ConfigurationChanged;
        event EventHandler<global::StackExchange.Redis.EndPointEventArgs> ConfigurationChangedBroadcast;
        bool Configure(global::System.IO.TextWriter log = null);
        global::System.Threading.Tasks.Task<bool> ConfigureAsync(global::System.IO.TextWriter log = null);
        event EventHandler<global::StackExchange.Redis.ConnectionFailedEventArgs> ConnectionFailed;
        event EventHandler<global::StackExchange.Redis.ConnectionFailedEventArgs> ConnectionRestored;
        void Dispose();
        event EventHandler<global::StackExchange.Redis.RedisErrorEventArgs> ErrorMessage;
        void ExportConfiguration(global::System.IO.Stream destination, global::StackExchange.Redis.ExportOptions options = ExportOptions.All);
        global::StackExchange.Redis.ServerCounters GetCounters();
        global::StackExchange.Redis.IDatabase GetDatabase(int db = 0, object asyncState = null);
        global::System.Net.EndPoint[] GetEndPoints(bool configuredOnly = false);
        global::StackExchange.Redis.IServer GetServer(global::System.Net.EndPoint endpoint, object asyncState = null);
        global::StackExchange.Redis.IServer GetServer(global::System.Net.IPAddress host, int port);
        global::StackExchange.Redis.IServer GetServer(string host, int port, object asyncState = null);
        global::StackExchange.Redis.IServer GetServer(string hostAndPort, object asyncState = null);
        string GetStatus();
        void GetStatus(global::System.IO.TextWriter log);
        string GetStormLog();
        global::StackExchange.Redis.ISubscriber GetSubscriber(object asyncState = null);
        int HashSlot(global::StackExchange.Redis.RedisKey key);
        event EventHandler<global::StackExchange.Redis.HashSlotMovedEventArgs> HashSlotMoved;
        bool IgnoreConnect { get; set; }
        bool IncludeDetailInExceptions { get; set; }
        event EventHandler<global::StackExchange.Redis.InternalErrorEventArgs> InternalError;
        bool IsConnected { get; }
        long OperationCount { get; }
        bool PreserveAsyncOrder { get; set; }
        long PublishReconfigure(global::StackExchange.Redis.CommandFlags flags = CommandFlags.None);
        global::System.Threading.Tasks.Task<long> PublishReconfigureAsync(global::StackExchange.Redis.CommandFlags flags = CommandFlags.None);
        void ResetStormLog();
        int StormLogThreshold { get; set; }
        int TimeoutMilliseconds { get; }
        string ToString();
        void Wait(global::System.Threading.Tasks.Task task);
        T Wait<T>(global::System.Threading.Tasks.Task<T> task);
        void WaitAll(params global::System.Threading.Tasks.Task[] tasks);
    }
}
