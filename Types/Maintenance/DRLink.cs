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
    /// <c>DRLink</c> represents a CSTA DR link.
    /// </summary>
    public class DRLink
    {
        /// <summary>
        /// Return the DR link registration identifier.
        /// </summary>
        public string Identifier { get; init; }

        /// <summary>
        /// Return the DR link initiator identifier.
        /// Since version 2.7.3.
        /// </summary>
        public string Initiator { get; init; }

        /// <summary>
        /// Return the number of recorded devices.
        /// </summary>
        public int NbRecordedDevices { get; init; }

        /// <summary>
        /// Return the list of recorded devices.
        /// </summary>
        public List<RecordedDevice> RecordedDevices { get; init; }
    }
}
