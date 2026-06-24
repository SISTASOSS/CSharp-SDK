using System.Collections.Generic;
using System.Threading.Tasks;
using o2g.Internal.Rest;
using o2g.Internal.Services;
using o2g.Types.RecordingNS;

namespace o2g
{
    /// <summary>
    ///  <c>IRecording</c> service allows a recorder application to record voice of OXE devices, either in IP or TDM mode.
    /// </summary>
    public interface IRecording : IService
    {
        /// <summary>
        /// Gets the list of existing recorder links on a PBX.
        /// </summary>
        /// <param name="nodeId">The OXE node number where the recorder is registered.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the list of DRLinks.</returns>
        Task<DRLinks> GetRecorderLinksAsync(int nodeId);

        /// <summary>
        /// Registers a recorder link on a PBX.
        /// </summary>
        /// <param name="nodeId">The OXE node number where to register the recorder.</param>
        /// <param name="registerServiceRequest">The request specifying the type of recorder.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the service registration information.</returns>
        Task<ServiceRegistered> RegisterRecorderLinkAsync(int nodeId, RegisterServiceRequest registerServiceRequest);

        /// <summary>
        /// Cancels the registration of a recorder link on a PBX.
        /// </summary>
        /// <param name="nodeId">The OXE node number where to unregister the link.</param>
        /// <param name="registerId">The DR link identifier to unregister.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a boolean indicating success or failure.</returns>
        Task<bool> DeleteRecorderLinkAsync(int nodeId, string registerId);

        /// <summary>
        /// Starts beep generation on a device.
        /// </summary>
        /// <param name="nodeId">The OXE PBX node.</param>
        /// <param name="registerId">The DR link identifier.</param>
        /// <param name="startBeepRequest">The request specifying the device number, tone, presence, and silence duration.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a boolean indicating success or failure.</returns>
        Task<bool> StartBeepAsync(int nodeId, string registerId, StartBeepRequest startBeepRequest);

        /// <summary>
        /// Stops beep generation on an IP device.
        /// </summary>
        /// <param name="nodeId">The OXE PBX node.</param>
        /// <param name="registerId">The IP DR link identifier.</param>
        /// <param name="deviceNumber">The device number.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a boolean indicating success or failure.</returns>
        Task<bool> StopBeepAsync(int nodeId, string registerId, string deviceNumber);

        /// <summary>
        /// Starts the monitoring of a device on a DR link.
        /// </summary>
        /// <param name="nodeId">The OXE PBX node.</param>
        /// <param name="registerId">The IP DR link identifier.</param>
        /// <param name="monitorRequest">The request specifying the device number to monitor.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the monitored device information.</returns>
        Task<DeviceMonitored> StartMonitorAsync(int nodeId, string registerId, MonitorRequest monitorRequest);

        /// <summary>
        /// Stops the monitoring of a device on a DR link.
        /// </summary>
        /// <param name="nodeId">The OXE PBX node.</param>
        /// <param name="registerId">The IP DR link identifier.</param>
        /// <param name="deviceNumber">The device number to stop monitoring.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a boolean indicating success or failure.</returns>
        Task<bool> StopMonitorAsync(int nodeId, string registerId, string deviceNumber);

        /// <summary>
        /// Starts an IP record of an IP device.
        /// </summary>
        /// <param name="nodeId">The OXE PBX node.</param>
        /// <param name="registerId">The IP DR link identifier.</param>
        /// <param name="startRecordRequest">The request specifying the device number, recorder IP address, and IP call flow ports to record.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the SRTP keys if native encryption is enabled.</returns>
        Task<RecordingSrtpKeys> StartRecordAsync(int nodeId, string registerId, StartRecordRequest startRecordRequest);

        /// <summary>
        /// Stops the IP or TDM recording of a device.
        /// </summary>
        /// <param name="nodeId">The OXE PBX node.</param>
        /// <param name="registerId">The DR link identifier.</param>
        /// <param name="deviceNumber">The recorded device number.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a boolean indicating success or failure.</returns>
        Task<bool> StopRecordAsync(int nodeId, string registerId, string deviceNumber);

        /// <summary>
        /// Starts a TDM record of a device through a PCM link.
        /// </summary>
        /// <param name="nodeId">The OXE PBX node.</param>
        /// <param name="registerId">The DR link identifier.</param>
        /// <param name="startTDMRecordRequest">The request specifying the device number and PCM resource.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a boolean indicating success or failure.</returns>
        Task<bool> StartTDMRecordAsync(int nodeId, string registerId, StartTDMRecordRequest startTDMRecordRequest);
    }
}