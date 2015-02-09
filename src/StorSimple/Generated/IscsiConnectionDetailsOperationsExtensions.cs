// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.StorSimple;
using Microsoft.WindowsAzure.Management.StorSimple.Models;

namespace Microsoft.WindowsAzure.Management.StorSimple
{
    /// <summary>
    /// This is an RESTFul API to manage you StorSimple Objects
    /// </summary>
    public static partial class IscsiConnectionDetailsOperationsExtensions
    {
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IIscsiConnectionDetailsOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client can use.
        /// </param>
        /// <returns>
        /// The response model for the list of iscsi connection details.
        /// </returns>
        public static IscsiConnectionResponse Get(this IIscsiConnectionDetailsOperations operations, string deviceId, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IIscsiConnectionDetailsOperations)s).GetAsync(deviceId, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IIscsiConnectionDetailsOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client can use.
        /// </param>
        /// <returns>
        /// The response model for the list of iscsi connection details.
        /// </returns>
        public static Task<IscsiConnectionResponse> GetAsync(this IIscsiConnectionDetailsOperations operations, string deviceId, CustomRequestHeaders customRequestHeaders)
        {
            return operations.GetAsync(deviceId, customRequestHeaders, CancellationToken.None);
        }
    }
}
