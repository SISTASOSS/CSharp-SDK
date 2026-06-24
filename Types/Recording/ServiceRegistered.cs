namespace o2g.Types.RecordingNS
{
    /// <summary>
    /// Contains the identifier of the recorder registration on the PBX node, to be used to unregister the service.
    /// Also specifies whether the connection is secure or not.
    /// </summary>
    public class ServiceRegistered
    {
        /// <summary>
        /// Gets or sets the registration identifier.
        /// </summary>
        /// <value>
        /// A <see langword="string"/> that represents the registration identifier.
        /// </value>
        public string RegistrationId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the connection is secure.
        /// </summary>
        /// <value>
        /// A <see langword="bool"/> that indicates if the connection is secure.
        /// </value>
        public bool? Secure { get; set; }
    }
}