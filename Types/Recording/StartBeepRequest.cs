namespace o2g.Types.RecordingNS
{
    /// <summary>
    /// Request to generate a beep tone on a device.
    /// </summary>
    public class StartBeepRequest
    {
        /// <summary>
        /// Gets or sets the device number.
        /// </summary>
        /// <value>
        /// A <see langword="string"/> that represents the device number.
        /// </value>
        public string DeviceNumber { get; set; }

        /// <summary>
        /// Gets or sets the tone or frequency to connect.
        /// This parameter identifies the time slot number defined in the OXE tones table, which is specific for each country.
        /// In practice, only values 21 to 30 are usable.
        /// </summary>
        /// <value>
        /// An <see langword="int"/> that represents the tone or frequency.
        /// </value>
        public int Tone { get; set; }

        /// <summary>
        /// Gets or sets the presence duration of the pulse.
        /// Value must be specified in steps of 10ms, from 10 milliseconds to 2.5 seconds.
        /// </summary>
        /// <value>
        /// An <see langword="int"/> that represents the presence duration.
        /// </value>
        public int PresenceDuration { get; set; }

        /// <summary>
        /// Gets or sets the silence duration between two pulses.
        /// Value must be specified in steps of 1s, from 1 second to 255 seconds.
        /// </summary>
        /// <value>
        /// An <see langword="int"/> that represents the silence duration.
        /// </value>
        public int SilenceDuration { get; set; }
    }
}