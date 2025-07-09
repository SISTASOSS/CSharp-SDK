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
        /// Initializes a new instance of the <see cref="MonitorRequest"/> class.
        /// </summary>
        /// <param name="deviceNumber">The device number to monitor on the DR link for recording.</param>
        public MonitorRequest(string deviceNumber)
        {
            DeviceNumber = deviceNumber;
        }
    }
}