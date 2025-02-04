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

namespace o2g.Types.MessagingNS
{
    /// <summary>
    /// <c>MailBoxInfo</c> provides information on the mail box the user is connected on.
    /// </summary>
    /// <seealso cref="IMessaging.GetMailboxInfoAsync(string, string, string)"/>
    public class MailBoxInfo
    {
        /// <summary>
        /// Get the total number of messages in this voice mail box.
        /// </summary>
        /// <value>
        /// The number of messages stored in the voice mail box.
        /// </value>
        public int TotalVoiceMsg { get; set; }

        /// <summary>
        /// Get the number of new messages in this voice mail box.
        /// </summary>
        /// <value>
        /// The number of new messages stored in the voice mail box.
        /// </value>
        public int NewVoiceMsg { get; set; }
        /// <summary>
        /// Get the mail box usage.
        /// </summary>
        /// <value>
        /// Threshold indicating mailbox usage ratio. 100 mean 100% full. No more message deposit is allowed. -1 means information not available.
        /// </value>
        public int StorageUsage { get; set; }
    }
}
