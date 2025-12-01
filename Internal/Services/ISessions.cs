using System.Threading.Tasks;

namespace o2g.Internal.Services
{
    internal class SessionRequest
    {
        public string ApplicationName { get; set; }

        public string ApplicationAddress { get; set; }

        public SupervisedAccount SupervisedAccount { get; set; }

        public int? TimeToLive { get; set; }
    }

    internal class SupervisedAccount
    {
        public string Id { get; set; }

        public SupervisedAccountType Type { get; set; }
    }

    internal enum SupervisedAccountType
    {
        LoginName,
        PhoneNumber
    }

    internal class SessionTokenInfo
    {
        public string ExpirationDate { get; set; }
    }

    internal interface ISessions : IService
    {
        Task<SessionInfo> Open(SessionRequest sessionRequest);
        Task<bool> Close();
        Task<SessionInfo> Get();
        Task<SessionTokenInfo> SendKeepAlive();
    }
}
