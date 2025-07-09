using System.Collections.Generic;

namespace o2g.Types.RecordingNS
{
    /// <summary>
    /// CSTA DR link.
    /// </summary>
    public class DRLink
    {
        /// <summary>
        /// Gets or sets the DR link registration identifier.
        /// </summary>
        /// <value>
        /// A <see langword="string"/> that represents the identifier.
        /// </value>
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets the number of recorded devices.
        /// </summary>
        /// <value>
        /// An <see langword="int"/> that represents the number of recorded devices.
        /// </value>
        public int NbRecordedDevices { get; set; }

        /// <summary>
        /// Gets or sets the list of recorded devices.
        /// </summary>
        /// <value>
        /// A <see langword="List{RecordedDevice}"/> that represents the recorded devices.
        /// </value>
        public List<RecordedDevice> RecordedDevices { get; set; }
        
    }
}