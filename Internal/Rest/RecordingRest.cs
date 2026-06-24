using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using o2g.Internal.Utility;
using o2g.Types.RecordingNS;

namespace o2g.Internal.Rest
{
    /// <summary>
    /// Represents the REST service to manage recording links.
    /// </summary>
    internal class RecordingRest : AbstractRESTService, IRecording
    {
        public RecordingRest(Uri uri) : base(uri)
        {
        }

        /// <summary>
        /// Gets the list of existing recorder links on a PBX.
        /// </summary>
        /// <param name="nodeId">The OXE node number where the recorder is registered.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the list of DRLinks.</returns>
        public async Task<DRLinks> GetRecorderLinksAsync(int nodeId)
        {
            Uri uriGet = uri.Append(nodeId.ToString(), "link");

            HttpResponseMessage response = await httpClient.GetAsync(uriGet);
            return await GetResult<DRLinks>(response);
        }
        
        /// <summary>
        /// Registers a recorder link on a PBX.
        /// </summary>
        /// <param name="nodeId">The OXE node number where to register the recorder.</param>
        /// <param name="registerServiceRequest">The request specifying the type of recorder.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the service registration information.</returns>
        public async Task<ServiceRegistered> RegisterRecorderLinkAsync(int nodeId, RegisterServiceRequest registerServiceRequest)
        {
            Uri uriPost = uri.Append( nodeId.ToString(), "link");
            var json = JsonSerializer.Serialize(registerServiceRequest, serializeOptions);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(uriPost, content);
            return await GetResult<ServiceRegistered>(response);
        }

        /// <summary>
        /// Cancels the registration of a recorder link on a PBX.
        /// </summary>
        /// <param name="nodeId">The OXE node number where to unregister the link.</param>
        /// <param name="registerId">The DR link identifier to unregister.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a boolean indicating success or failure.</returns>
        public async Task<bool> DeleteRecorderLinkAsync(int nodeId, string registerId)
        {
            Uri uriDelete = uri.Append( nodeId.ToString(), "link", registerId);

            HttpResponseMessage response = await httpClient.DeleteAsync(uriDelete);
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        
        /// <summary>
        /// Starts beep generation on a device.
        /// </summary>
        /// <param name="nodeId">The OXE PBX node.</param>
        /// <param name="registerId">The DR link identifier.</param>
        /// <param name="startBeepRequest">The request specifying the device number, tone, presence, and silence duration.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a boolean indicating success or failure.</returns>
        public async Task<bool> StartBeepAsync(int nodeId, string registerId, StartBeepRequest startBeepRequest)
        {
            Uri uriPost = uri.Append(nodeId.ToString(), "link", registerId, "beep");
            var json = JsonSerializer.Serialize(startBeepRequest, serializeOptions);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(uriPost, content);
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        
        /// <summary>
        /// Stops beep generation on an IP device.
        /// </summary>
        /// <param name="nodeId">The OXE PBX node.</param>
        /// <param name="registerId">The IP DR link identifier.</param>
        /// <param name="deviceNumber">The device number.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a boolean indicating success or failure.</returns>
        public async Task<bool> StopBeepAsync(int nodeId, string registerId, string deviceNumber)
        {
            Uri uriDelete = uri.Append(nodeId.ToString(), "link", registerId, "beep", deviceNumber);

            HttpResponseMessage response = await httpClient.DeleteAsync(uriDelete);
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        
        /// <summary>
        /// Starts the monitoring of a device on a DR link.
        /// </summary>
        /// <param name="nodeId">The OXE PBX node.</param>
        /// <param name="registerId">The IP DR link identifier.</param>
        /// <param name="monitorRequest">The request specifying the device number to monitor.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the monitored device information.</returns>
        public async Task<DeviceMonitored> StartMonitorAsync(int nodeId, string registerId, MonitorRequest monitorRequest)
        {
            Uri uriPost = uri.Append(nodeId.ToString(), "link", registerId, "monitor");
            var json = JsonSerializer.Serialize(monitorRequest, serializeOptions);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(uriPost, content);
            return await GetResult<DeviceMonitored>(response);
        }
        
        /// <summary>
        /// Stops the monitoring of a device on a DR link.
        /// </summary>
        /// <param name="nodeId">The OXE PBX node.</param>
        /// <param name="registerId">The IP DR link identifier.</param>
        /// <param name="deviceNumber">The device number to stop monitoring.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a boolean indicating success or failure.</returns>
        public async Task<bool> StopMonitorAsync(int nodeId, string registerId, string deviceNumber)
        {
            Uri uriDelete = uri.Append(nodeId.ToString(), "link", registerId, "monitor", deviceNumber);

            HttpResponseMessage response = await httpClient.DeleteAsync(uriDelete);
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        
        /// <summary>
        /// Starts an IP record of an IP device.
        /// </summary>
        /// <param name="nodeId">The OXE PBX node.</param>
        /// <param name="registerId">The IP DR link identifier.</param>
        /// <param name="startRecordRequest">The request specifying the device number, recorder IP address, and IP call flow ports to record.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the SRTP keys if native encryption is enabled.</returns>
        public async Task<RecordingSrtpKeys> StartRecordAsync(int nodeId, string registerId, StartRecordRequest startRecordRequest)
        {
            Uri uriPost = uri.Append(nodeId.ToString(), "link", registerId, "record");
            var json = JsonSerializer.Serialize(startRecordRequest, serializeOptions);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(uriPost, content);
            return await GetResult<RecordingSrtpKeys>(response);
        }
        
        /// <summary>
        /// Stops the IP or TDM recording of a device.
        /// </summary>
        /// <param name="nodeId">The OXE PBX node.</param>
        /// <param name="registerId">The DR link identifier.</param>
        /// <param name="deviceNumber">The recorded device number.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a boolean indicating success or failure.</returns>
        public async Task<bool> StopRecordAsync(int nodeId, string registerId, string deviceNumber)
        {
            Uri uriDelete = uri.Append(nodeId.ToString(), "link", registerId, "record", deviceNumber);

            HttpResponseMessage response = await httpClient.DeleteAsync(uriDelete);
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        
        /// <summary>
        /// Starts a TDM record of a device through a PCM link.
        /// </summary>
        /// <param name="nodeId">The OXE PBX node.</param>
        /// <param name="registerId">The DR link identifier.</param>
        /// <param name="startTDMRecordRequest">The request specifying the device number and PCM resource.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a boolean indicating success or failure.</returns>
        public async Task<bool> StartTDMRecordAsync(int nodeId, string registerId, StartTDMRecordRequest startTDMRecordRequest)
        {
            Uri uriPost = uri.Append(nodeId.ToString(), "link", registerId, "tdmrecord");
            var json = JsonSerializer.Serialize(startTDMRecordRequest, serializeOptions);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(uriPost, content);
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
    }
}