namespace o2g.Types.RecordingNS
{
    /// <summary>
    /// In response of the monitor start request of a device, contains the user selector identifier to use for the telephony event subscription.
    /// If the device (for example number = "5000") is the main device of the oxe subscriber (or if the subscriber is mono device), the userId will be "oxe5000".
    /// If the device (for example number = "5001") is one of the secondary devices of a multi-device oxe subscriber (number = "5000"), the userId will be "oxe5000".
    /// </summary>
    public class DeviceMonitored
    {
        /// <summary>
        /// Gets or sets the user identifier for telephony event subscription.
        /// </summary>
        /// <value>
        /// A <see langword="string"/> that represents the user identifier.
        /// </value>
        public string UserId { get; init; }
    }
}