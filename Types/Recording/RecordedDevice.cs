namespace o2g.Types.RecordingNS
{
    /// <summary>
    /// Represents a recorded device identification with its recording resource.
    /// </summary>
    public class RecordedDevice
    {
        /// <summary>
        /// Gets or sets the device number.
        /// </summary>
        /// <value>
        /// A <see langword="string"/> that represents the device number.
        /// </value>
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the recording has been asked.
        /// </summary>
        /// <value>
        /// A <see langword="bool"/> that indicates if the recording has been asked.
        /// </value>
        public bool Recorded { get; set; }

        /// <summary>
        /// Gets or sets the recorder IP address or TDM time slot.
        /// </summary>
        /// <value>
        /// A <see langword="string"/> that represents the recording resource.
        /// </value>
        public string RecordingResource { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether it is an IP recording.
        /// </summary>
        /// <value>
        /// A <see langword="bool"/> that indicates if it is an IP recording.
        /// </value>
        public bool Ip { get; set; }

        /// <summary>
        /// Gets or sets the recorder port where the sent RTP flow is sent (from the local recorded device to the remote).
        /// </summary>
        /// <value>
        /// An <see langword="int"/> that represents the sent flow port.
        /// </value>
        public int SentFlowPort { get; set; }

        /// <summary>
        /// Gets or sets the recorder port where the received RTP flow is sent (from the remote to the local recorded device).
        /// </summary>
        /// <value>
        /// An <see langword="int"/> that represents the received flow port.
        /// </value>
        public int ReceivedFlowPort { get; set; }
    }
}