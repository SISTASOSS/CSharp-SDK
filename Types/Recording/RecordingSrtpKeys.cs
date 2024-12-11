namespace o2g.Types.RecordingNS
{
    /// <summary>
    /// Contains the Secured RTP key and salt in response to the start IP record on a secured IP link.
    /// </summary>
    public class RecordingSrtpKeys
    {
        /// <summary>
        /// Gets or sets the key.
        /// </summary>
        /// <value>
        /// A <see langword="string"/> that represents the key.
        /// </value>
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the salt.
        /// </summary>
        /// <value>
        /// A <see langword="string"/> that represents the salt.
        /// </value>
        public string Salt { get; set; }
    }
}