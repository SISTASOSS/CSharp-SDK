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

using System.Collections.Generic;

namespace o2g.Types.MaintenanceNS
{
    /// <summary>
    /// <c>OXRConfig</c> Configuration for an OmniPCX Record (OXR) system.
    /// </summary>
    public class OXRConfig
    {
        /// <summary>
        /// OXR host name.
        /// </summary>
        public string? HostName { get; init; }

        /// <summary>
        /// OXR IP address.
        /// </summary>
        public string? IpAddress { get; init; }

        /// <summary>
        /// OXR site identifier.
        /// </summary>
        public string? SiteId { get; init; }

        /// <summary>
        /// Indicates whether access is secured.
        /// </summary>
        public bool? Secured { get; init; }

        /// <summary>
        /// Indicates whether the system is connected.
        /// </summary>
        public bool? Connected { get; init; }

        /// <summary>
        /// List of device numbers that may be recorded by this recorder.
        /// </summary>
        public List<string> Devices { get; init; } = new();
    }
}
