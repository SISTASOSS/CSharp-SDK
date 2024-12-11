using System.Collections.Generic;

namespace o2g.Types.RecordingNS
{
    /// <summary>
    /// List of existing DRLinks for a PBX.
    /// </summary>
    public class DRLinks
    {
        /// <summary>
        /// Gets or sets the list of DRLinks.
        /// In case of IP recording, list of DRLinks.
        /// </summary>
        /// <value>
        /// A <see langword="List{DRLink}"/> that represents the list of DRLinks.
        /// </value>
        public List<DRLink> DrLinks { get; set; }
    }
}