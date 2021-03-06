// Copyright © Microsoft Open Technologies, Inc.
// All Rights Reserved
// Licensed under the Apache License, Version 2.0 (the "License"); 
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
// http://www.apache.org/licenses/LICENSE-2.0 

// THIS CODE IS PROVIDED ON AN *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED WARRANTIES OR
// CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE, MERCHANTABLITY OR NON-INFRINGEMENT. 
// See the Apache 2 License for the specific language governing permissions and limitations under the License. 

namespace Microsoft.GFS.WCS.ChassisManager.Ipmi
{
    /// <summary>
    /// Represents the IPMI 'Get SDR' response message.
    /// </summary>
    [IpmiMessageRequest(IpmiFunctions.Storage, IpmiCommand.GetSdr)]
    internal class GetSdrPartialResponse : IpmiResponse
    {
        /// <summary>
        /// Next Record Id LS Byte.
        /// </summary> 
        private byte recordIdLsByte;

        /// <summary>
        /// Next Record Id MS Byte.
        /// </summary> 
        private byte recordIdMsByte;

        [IpmiMessageData(0)]
        public byte RecordIdLsByte
        {
            get { return this.recordIdLsByte; }
            set { this.recordIdLsByte = value; }
        }

        /// <summary>
        /// Next Record ID MS Byte
        /// </summary>       
        [IpmiMessageData(1)]
        public byte RecordIdMsByte
        {
            get { return this.recordIdMsByte; }
            set { this.recordIdMsByte = value; }
        }

        /// <summary>
        /// Record Data.
        /// </summary> 
        private byte[] recordData;
    
        /// <summary>
        /// Record Data
        /// </summary>       
        [IpmiMessageData(2)]
        public byte[] RecordData
        {
            get { return this.recordData; }
            set { this.recordData = value; }
        }
    }
}
