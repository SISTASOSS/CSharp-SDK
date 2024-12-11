namespace o2g.Types.RecordingNS
{
    /// <summary>
    /// Request to register an IP recorder on a PBX node.
    /// </summary>
    public class RegisterServiceRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterServiceRequest"/> class.
        /// </summary>
        /// <param name="type">The type of the recorder.</param>
        /// <param name="secured">Indicates whether the recorder should work in secured mode.</param>
        public RegisterServiceRequest(IPRecorderType type, bool secured)
        {
            Type = type;
            Secured = secured;
        }

        /// <summary>
        /// Gets or sets the type of the recorder. Default is "other than NICE".
        /// </summary>
        /// <value>
        /// An <see langword="IPRecorderType"/> that represents the type of the recorder.
        /// </value>
        public IPRecorderType Type { get; set; } = IPRecorderType.OTHER;

        /// <summary>
        /// Gets or sets a value indicating whether the recorder should work in secured mode.
        /// Default is according to OXE recording configuration.
        /// </summary>
        /// <value>
        /// A <see langword="bool"/> that indicates if the recorder should work in secured mode.
        /// </value>
        public bool Secured { get; set; }
    }
}