using o2g.Internal.Services;
using o2g.Internal.Utility;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace o2g.Internal.Rest
{
    internal class SessionsRest : AbstractRESTService, ISessions
    {
        public SessionsRest(Uri uri) : base(uri)
        {

        }

        async Task<bool> ISessions.Close()
        {
            HttpResponseMessage response = await httpClient.DeleteAsync(uri);
            return await IsSucceeded(response);
        }

        async Task<SessionInfo> ISessions.Get()
        {
            HttpResponseMessage response = await httpClient.GetAsync(uri);
            return await GetResult<SessionInfo>(response);
        }

        async Task<SessionInfo> ISessions.Open(SessionRequest sessionRequest)
        {
            string jsonCode = JsonSerializer.Serialize(sessionRequest, serializeOptions);
            var content = new StringContent(jsonCode, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync(uri, content);
            return await GetResult<SessionInfo>(response);
        }

        async Task<SessionTokenInfo> ISessions.SendKeepAlive()
        {
            HttpResponseMessage response = await httpClient.PostAsync(uri.Append("keepalive"), null);
            return await GetResult<SessionTokenInfo>(response);
        }
    }
}
