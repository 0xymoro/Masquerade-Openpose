﻿// Copyright © 2017, Meta Company.  All rights reserved.
// 
// Redistribution and use of this software (the "Software") in binary form, without modification, is 
// permitted provided that the following conditions are met:
// 
// 1.      Redistributions of the unmodified Software in binary form must reproduce the above 
//         copyright notice, this list of conditions and the following disclaimer in the 
//         documentation and/or other materials provided with the distribution.
// 2.      The name of Meta Company (“Meta”) may not be used to endorse or promote products derived 
//         from this Software without specific prior written permission from Meta.
// 3.      LIMITATION TO META PLATFORM: Use of the Software is limited to use on or in connection 
//         with Meta-branded devices or Meta-branded software development kits.  For example, a bona 
//         fide recipient of the Software may incorporate an unmodified binary version of the 
//         Software into an application limited to use on or in connection with a Meta-branded 
//         device, while he or she may not incorporate an unmodified binary version of the Software 
//         into an application designed or offered for use on a non-Meta-branded device.
// 
// For the sake of clarity, the Software may not be redistributed under any circumstances in source 
// code form, or in the form of modified binary code – and nothing in this License shall be construed 
// to permit such redistribution.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDER "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, 
// INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A 
// PARTICULAR PURPOSE ARE DISCLAIMED.  IN NO EVENT SHALL META COMPANY BE LIABLE FOR ANY DIRECT, 
// INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, 
// PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA OR PROFITS; OR BUSINESS 
// INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT 
// LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS 
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Meta.Reconstruction
{
    /// <summary>
    /// Environment profile that has information to localize the environment resources.
    /// </summary>
    public class EnvironmentProfile : IEnvironmentProfile
    {
        [JsonProperty(PropertyName = "id")]
        private int _id;
        [JsonProperty(PropertyName = "name")]
        private string _name;
        [JsonProperty(PropertyName = "meshes")]
        private List<string> _meshes;
        [JsonProperty(PropertyName = "map_name")]
        private string _mapName;
        [JsonProperty(PropertyName = "last_time_used")]
        private long _lastTimeUsed;

        /// <summary>
        /// Gets the environment profile id.
        /// </summary>
        [JsonIgnore]
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Gets or sets the environment profile name.
        /// </summary>
        [JsonIgnore]
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name");
                }
                _name = value;
            }
        }

        /// <summary>
        /// Gets or sets the environment profile meshes.
        /// </summary>
        [JsonIgnore]
        public List<string> Meshes
        {
            get { return _meshes; }
            set { _meshes = value == null ? new List<string>() : value; }
        }

        /// <summary>
        /// Gets or sets the environment profile map name.
        /// </summary>
        [JsonIgnore]
        public string MapName
        {
            get { return _mapName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("MapName");
                }
                _mapName = value;
            }
        }

        /// <summary>
        /// Gets or sets the environment profile last time used timestamp.
        /// </summary>
        [JsonIgnore]
        public long LastTimeUsed
        {
            get { return _lastTimeUsed; }
            set { _lastTimeUsed = value; }
        }

        /// <summary>
        /// Whether the environment profile is default or not.
        /// </summary>
        [JsonIgnore]
        public bool IsDefault
        {
            get { return _name == EnvironmentConstants.DefaultEnvironmentName; }
        }

        /// <summary>
        /// Creates an instance of <see cref="EnvironmentProfile"/> class.
        /// </summary>
        /// <param name="id">The environment profile id</param>
        /// <param name="name">The environment profile name</param>
        public EnvironmentProfile(int id, string name)
        {
            _id = id;
            Name = name;
            Meshes = null;
            UpdateLastTimeUsed();
        }
        
        /// <summary>
        /// Sets the current time as the last time this environment was used.
        /// </summary>
        public void UpdateLastTimeUsed()
        {
            LastTimeUsed = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
        }
    }
}
