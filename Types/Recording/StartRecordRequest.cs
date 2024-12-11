namespace o2g.Types.RecordingNS
{
    /// <summary>
    /// Request to start an IP record of a device.
    /// </summary>
    public class StartRecordRequest
    {
        /// <summary>
        /// Gets or sets the device number to record.
        /// Must correspond to an O2G monitored user.
        /// </summary>
        /// <value>
        /// A <see langword="string"/> that represents the device number.
        /// </value>
        public string DeviceNumber { get; set; }

        /// <summary>
        /// Gets or sets the IP V4 address of the recorder.(aaa.bbb.ccc.ddd)
        /// </summary>
        /// <value>
        /// A <see langword="string"/> that represents the IP V4 address of the recorder.
        /// </value>
        public string IpRecorderAddr { get; set; }

        /// <summary>
        /// Gets or sets the recorder port where to send the sent RTP flow.
        /// From the local recorded device to the remote.
        /// </summary>
        /// <value>
        /// An <see langword="int"/> that represents the sent flow port.
        /// </value>
        public int SentFlowPort { get; set; }

        /// <summary>
        /// Gets or sets the recorder port where to send the received RTP flow.
        /// From the remote to the local recorded device.
        /// </summary>
        /// <value>
        /// An <see langword="int"/> that represents the received flow port.
        /// </value>
        public int ReceivedFlowPort { get; set; }
    }
}