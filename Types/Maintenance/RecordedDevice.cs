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

namespace o2g.Types.MaintenanceNS
{
    /// <summary>
    /// <c>RecordedDevice</c> represents a recorded device identification with its recording resource.
    /// </summary>
    public class RecordedDevice
    {
        /// <summary>
        /// Return the device number.
        /// </summary>
        public string Number { get; init; }

        /// <summary>
        /// Return the device user.
        /// </summary>
        public string User { get; init; }

        /// <summary>
        /// Return the device CSTA CRID.
        /// </summary>
        public string Crid { get; init; }

        /// <summary>
        /// Return whether recording has been asked.
        /// </summary>
        public bool Recorded { get; init; }

        /// <summary>
        /// Return the recorder IP address or TDM time slot.
        /// </summary>
        public string RecordingResource { get; init; }

        /// <summary>
        /// Return whether it is an IP recording.
        /// </summary>
        public bool Ip { get; init; }

        /// <summary>
        /// Return the recorder port where the sent RTP flow is sent.
        /// </summary>
        public int SentFlowPort { get; init; }

        /// <summary>
        /// Return the recorder port where the received RTP flow is sent.
        /// </summary>
        public int ReceivedFlowPort { get; init; }

        /// <summary>
        /// Return whether the IP recording is encrypted.
        /// </summary>
        public bool Encrypted { get; init; }
    }
}
