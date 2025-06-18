using o2g.Internal.Events;
using o2g.Internal.Services;
using o2g.Internal.Types;
using o2g.Internal.Utility;
using o2g.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using o2g.Types;

namespace o2g.Internal.Rest
{
    internal class SubscriptionsRest : AbstractRESTService, ISubscriptions
    {
        public SubscriptionsRest(Uri uri) : base(uri)
        {

        }

        async Task<SubscriptionResult> ISubscriptions.Create(Subscription request)
        {
            var json = JsonSerializer.Serialize(request, serializeOptions);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(uri, content);
            
            SubscriptionResult subscriptionResult = JsonSerializer.Deserialize<SubscriptionResult>(await response.Content.ReadAsStringAsync(),serializeOptions);
            if (null != subscriptionResult?.Status) // REFUSED, "LICENSE_REQUIRED: Max number licenses exceeded..." is received with http response code 400 and not 2xx
            {
                SetLastError(null);
                return subscriptionResult;
            }
            return await GetResult<SubscriptionResult>(response);
        }
        
        async Task<bool> ISubscriptions.Update(Subscription request)
        {
            var json = JsonSerializer.Serialize(request.Filter, serializeOptions);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PutAsync(uri, content);
            return await IsSucceeded(response);
        }

        async Task<bool> ISubscriptions.Delete(string subscriptionId)
        {
            Uri uriDelete = uri.Append(subscriptionId);

            HttpResponseMessage response = await httpClient.DeleteAsync(uriDelete);
            return await IsSucceeded(response);
        }

    }
}
