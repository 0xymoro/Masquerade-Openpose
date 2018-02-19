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
using UnityEngine;

namespace Meta
{
    /// <summary>  A data point with xyz data. </summary>
    public class PointXYZ
    {
        /// <summary>   The vertex. </summary>
        protected Vector3 _vertex;
    
        /// <summary>   Gets the vertex. </summary>
        /// <value> The vertex. </value>
        public Vector3 vertex
        {
            get { return _vertex; }
            internal set { _vertex = value; }
        }

        /// <summary>   Initializes a new instance of the PointXYZ class. </summary>
        public PointXYZ() {}

    
        /// <summary>   Initializes a new instance of the PointXYZ class. </summary>
        /// <param name="vert"> The vertex. </param>
        public PointXYZ(Vector3 vert)
        {
            vertex = vert;
        }

    
        /// <summary>   Sets data from raw bytes. </summary>
        /// <param name="data">         The data. </param>
        /// <param name="startIndex">   The start index. </param>
        /// <param name="size">         The size. </param>
        /// <returns>   true if it succeeds, false if it fails. </returns>
        public virtual bool SetDataFromRawBytes(float[] data, int startIndex, int size)
        {
            vertex.Set(data[size * startIndex + 0], data[size * startIndex], data[size * startIndex]);
            return true;
        }

    
        /// <summary>   Convert this point data into a string representation. </summary>
        /// <returns>   A string that represents this object. </returns>
        public override string ToString()
        {
            return vertex.x + " " + vertex.y + " " + vertex.z;
        }



        public static implicit operator Vector3(PointXYZ point)
        {
            return point.vertex;
        }
    }
}
