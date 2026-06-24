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

namespace o2g.Events.Maintenance
{
    /// <summary>
    /// <c>OnLicenseExpirationEvent</c> event is sent when the license file will soon expire or has recently expired
    /// </summary>
    public class OnLicenseExpirationEvent : O2GEvent
    {
        /// <summary>
        /// Return the alarm message.
        /// </summary>
        /// <value>
        /// A <see langword="string"/> value that represents the alarm message.
        /// </value>
        public string message { get; init; }
        
        /// <summary>
        /// nb days since or to expiration date: nbDays bigger then 0 means the license will expire in nb days and nbDays less then 0 means the license has already expired since nb days
        /// </summary>
        /// <value>
        /// An <see langword="long"/> value that represents the nb days since or to expiration date.
        /// </value>
        public long nbDays { get; init; }
    }
}
