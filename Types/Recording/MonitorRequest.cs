using System.Collections.Generic;

namespace o2g.Types.RecordingNS
{
    /// <summary>
    /// Request to start/stop the monitoring of a device on a DR link.
    /// </summary>
    public class MonitorRequest
    {
        /// <summary>
        /// Gets or sets the device number to monitor on the DR link for recording.
        /// </summary>
        /// <value>
        /// A <see langword="string"/> that represents the device number.
        /// </value>
        public string DeviceNumber { get; set; }
        
        /// <summary>
        /// Gets or sets the list of the device numbers to monitor on the DR link for recording. Since version 2.7.3
        /// </summary>
        /// <value>
        /// A list of <see langword="string"/> devices to monitor. Several devices may be monitored at a time: List of numbers to be monitored. All the devices must exist else the request will fail. If the parameter deviceNumbers is not null, the parameter deviceNumber is ignored
        /// </value>
        public List<string> DeviceNumbers { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorRequest"/> class.
        /// </summary>
        /// <param name="deviceNumber">The device number to monitor on the DR link for recording.</param>
        public MonitorRequest(string deviceNumber)
        {
            DeviceNumber = deviceNumber;
        }
    }
}