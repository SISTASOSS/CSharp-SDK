namespace o2g.Types.RecordingNS
{
    /// <summary>
    /// Request to start a TDM record of a device.
    /// </summary>
    public class StartTDMRecordRequest
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
        /// Gets or sets the PCM crystal number.
        /// </summary>
        /// <value>
        /// An <see langword="int"/> that represents the PCM crystal number.
        /// </value>
        public int Crystal { get; set; }

        /// <summary>
        /// Gets or sets the PCM board number.
        /// </summary>
        /// <value>
        /// An <see langword="int"/> that represents the PCM board number.
        /// </value>
        public int Board { get; set; }

        /// <summary>
        /// Gets or sets the PCM timeslot number.
        /// </summary>
        /// <value>
        /// An <see langword="int"/> that represents the PCM timeslot number.
        /// </value>
        public int Timeslot { get; set; }
    }
}