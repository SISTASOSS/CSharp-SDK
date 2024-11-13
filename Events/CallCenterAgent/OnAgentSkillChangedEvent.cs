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

using o2g.Types.CallCenterAgentNS;

namespace o2g.Events.CallCenterAgent
{
    /// <summary>
    /// This event is raised when an agent changes the activation of one or several skills.
    /// </summary>
    public class OnAgentSkillChangedEvent : O2GEvent
    {
        /// <summary>
        /// Return the agent login name.
        /// </summary>
        /// <value>
        /// A <see langword="string"/> value that represents the agent login name.
        /// </value>
        public string LoginName { get; init; }

        /// <summary>
        /// Return the agent skills.
        /// </summary>
        /// <value>
        /// A <see cref="OperatorState"/> object that represents the agent state.
        /// </value>
        public AgentSkillSet Skills { get; init; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="OnAgentSkillChangedEvent"/> class.
        /// </summary>
        /// <param name="eventName">The event name.</param>
        /// <param name="loginName">The login name of the agent.</param>
        /// <param name="skills">The skill set of the agent.</param>
        protected OnAgentSkillChangedEvent(string eventName, string loginName, AgentSkillSet skills)
        {
            EventName = eventName;
            LoginName = loginName;
            Skills = skills;
        }

        /// <summary>
        /// Returns the agent's login name.
        /// </summary>
        public string GetLoginName()
        {
            return LoginName;
        }

        /// <summary>
        /// Returns the agent's skill set.
        /// </summary>
        public AgentSkillSet GetSkills()
        {
            return Skills;
        }
    }
}
