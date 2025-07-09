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
    /// <c>SystemServicesStatusDto</c> Top-level DTO that reports the overall status of system services.
    /// </summary>
    public class SystemServicesStatusDto
    {
        /// <summary>
        /// One entry per service. 0..* → empty list when no services.
        /// </summary>
        public List<ServiceStatus> Services { get; init; } = new();

        /// <summary>
        /// When the system runs in HA mode, this is the status of the global IP address.
        /// </summary>
        public string? GlobalIpAddress { get; init; }

        /// <summary>
        /// When the system runs in HA mode, this is the status of DRBD.
        /// </summary>
        public string? Drbd { get; init; }
    }
}
