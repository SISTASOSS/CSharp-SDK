﻿/*
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
namespace o2g.Types.TelephonyNS
{
    /// <summary>
    /// <c>TrunkIdentification</c> For external call, provide information on network timeslot and trunk eqt number
    /// </summary>
    public class TrunkIdentification
    {
        /// <summary>
        /// The network time slot.
        /// </summary>
        /// <value>
        /// An <see cref="int"/> that represent the network time slot.
        /// </value>
        public int networkTimeslot { get; set; }

        /// <summary>
        /// Trunk equipment number (Could be 2 nbrs in case of conference with 2 different external trunks.
        /// </summary>
        /// <value>
        /// An <see cref="int"/> that  represent Trunk equipment number
        /// </value>
        public int trunkNeqt { get; set; }
    }
}
