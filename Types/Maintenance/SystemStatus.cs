/*
* Copyright 2021 ALE International
*
* Permission is hereby granted, free of charge, to any person obtaining a copy of this 
* software and associated documentation files (the "Software"), to deal in the Software 
* without restriction, including without limitation the rights to use, copy, modify, merge, 
* publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons 
* to whom the Software is furnished to do so, subject to the following conditions:
* 
* The above copyright notice and this permission notice shall be included in all copies or 
* substantial portions of the Software.
* 
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING 
* BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND 
* NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, 
* DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Collections.Generic;

namespace o2g.Types.MaintenanceNS
{
    /// <summary>
    /// <c>SystemStatus</c> class provide a full status of the O2G server and its connections.
    /// </summary>
    /// <seealso cref="IMaintenance.GetSystemStatusAsync"/>
    public class SystemStatus
    {
        /// <summary>
        /// Return this O2G server logical address.
        /// </summary>
        /// <value>
        /// A <see cref="ServerAddress"/> that represents the O2G server logical address.
        /// </value>
        public ServerAddress LogicalAddress { get; init; }

        /// <summary>
        /// Return the start date of the O2G server.
        /// </summary>
        /// <value>
        /// A <see langword="DateTime"/> object that represents the O2G server start date.
        /// </value>
        public DateTime StartDate { get; init; }

        /// <summary>
        /// Return whether this O2G is deployed in high availability mode.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the O2G is in HA mode; <see langword="false"/> otherwise.
        /// </value>
        public bool HaMode { get; init; }

        /// <summary>
        /// Return the FQDN of the currently active O2G server when it is configured in HA mode.
        /// </summary>
        /// <value>
        /// The FQDN of the current active O2G server in case of HA configuration.
        /// </value>
        public string Primary { get; init; }

        /// <summary>
        /// Return the version of the current active O2G server when it is configured in HA mode.
        /// </summary>
        /// <value>
        /// The version of the active O2G server.
        /// </value>
        public string PrimaryVersion { get; init; }

        /// <summary>
        /// Return the primary server services status.
        /// </summary>
        /// <value>
        /// A <see cref="SystemServicesStatus"/> object that represents primary server services status.
        /// </value>
        public SystemServicesStatus PrimaryServicesStatus { get; init; }

        /// <summary>
        /// Return the FQDN of the backup system when it is configured in HA mode.
        /// </summary>
        /// <value>
        /// The FQDN of the backup O2G server in case of HA configuration.
        /// </value>
        public string Secondary { get; init; }

        /// <summary>
        /// Return the version of the backup O2G server when it is configured in HA mode.
        /// </summary>
        /// <value>
        /// The version of the backup O2G server.
        /// </value>
        public string SecondaryVersion { get; init; }

        /// <summary>
        /// Return the secondary server services status.
        /// </summary>
        /// <value>
        /// A <see cref="SystemServicesStatus"/> object that represents secondary server services status.
        /// </value>
        public SystemServicesStatus SecondaryServicesStatus { get; init; }

        /// <summary>
        /// Return information about the PBXs connected to this O2G server.
        /// </summary>
        /// <value>
        /// A list of <see cref="PbxStatus"/> that represents the connected Pbx and their connection status.
        /// </value>
        public List<PbxStatus> Pbxs { get; init; }

        /// <summary>
        /// Return OXR recording service status.
        /// </summary>
        /// <value>
        /// An <see cref="OXRRecordingStatus"/> object that represents OXR recording information.
        /// Since version 2.7.3.
        /// </value>
        public OXRRecordingStatus RecordingStatus { get; init; }

        /// <summary>
        /// Return the license status.
        /// </summary>
        /// <value>
        /// A list of <see cref="License"/> object that represents the status of the O2G server licenses.
        /// </value>
        public List<License> Licenses { get; init; }

        /// <summary>
        /// Return the O2G server configuration type.
        /// </summary>
        /// <value>
        /// The <see cref="ConfigurationType"/> that corresponds to the O2G server configuration.
        /// </value>
        public ConfigurationType ConfigurationType { get; init; }

        /// <summary>
        /// Return the O2G server identifier.
        /// </summary>
        /// <value>
        /// The O2G server identifier.
        /// </value>
        public string ApplicationId { get; init; }

        /// <summary>
        /// Return the OXE subscriber load filter type.
        /// </summary>
        /// <value>
        /// A <see cref="SubscriberFilter"/> object that represents the OXE subscriber load filter type.
        /// </value>
        public SubscriberFilter SubscriberFilter { get; init; }

        /// <summary>
        /// Return system resource information.
        /// </summary>
        /// <value>
        /// A <see cref="ServerAddress"/> that represents system resource information.
        /// Since version 2.7.5.
        /// </value>
        public ServerAddress SystemResources { get; init; }
    }
}
