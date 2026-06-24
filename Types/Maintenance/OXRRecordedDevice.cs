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
    /// <c>OXRRecordedDevice</c> represents an OXR recorded device.
    /// </summary>
    public class OXRRecordedDevice
    {
        /// <summary>
        /// Return the device number.
        /// </summary>
        /// <value>
        /// The device number.
        /// </value>
        public string Number { get; init; }

        /// <summary>
        /// Return whether the device is recordable on demand.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the device is recordable on demand; <see langword="false"/> otherwise.
        /// </value>
        public bool Recordable { get; init; }

        /// <summary>
        /// Return the start mode capabilities of the device.
        /// </summary>
        /// <value>
        /// A list of <see cref="StartType"/> values that represents the start mode capabilities of the device.
        /// This property is not present if the device is not recordable on demand.
        /// </value>
        public List<StartType> StartCapabilities { get; init; }

        /// <summary>
        /// Return the list of recorder identifiers which manage the device.
        /// </summary>
        /// <value>
        /// A list of recorder identifiers which manage the device.
        /// </value>
        public List<string> Recorders { get; init; }
    }
}
