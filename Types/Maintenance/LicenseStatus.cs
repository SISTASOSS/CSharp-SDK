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
    /// <c>LicenseStatus</c> Represents the overall status of the license system (FLEXLM or LMS).
    /// </summary>
    public class LicenseStatus
    {
        /// <summary>
        /// License system type: "FLEXLM" (CAPEX) or "LMS" (OPEX).
        /// </summary>
        public string? Type { get; init; }

        /// <summary>
        /// Only for LMS: infrastructure used – e.g. "PROD", "QA", or "INT".
        /// </summary>
        public string? Context { get; init; }

        /// <summary>
        /// Current license server address.
        /// </summary>
        public string? CurrentServer { get; init; }

        /// <summary>
        /// Only for LMS: status of the RTR – e.g. "NORMAL", "GRACE PERIOD", "PANIC MODE".
        /// </summary>
        public string? Status { get; init; }

        /// <summary>
        /// Only for LMS: debug message associated with the status.
        /// </summary>
        public string? StatusMessage { get; init; }

        /// <summary>
        /// 0..* list of licenses.
        /// </summary>
        public List<License> Lics { get; init; } = new();
    }
}
