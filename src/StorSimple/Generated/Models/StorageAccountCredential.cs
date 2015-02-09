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
using Microsoft.WindowsAzure.Management.StorSimple.Models;

namespace Microsoft.WindowsAzure.Management.StorSimple.Models
{
    /// <summary>
    /// Information about the storage account credentials which needs to be
    /// either added or delete or update
    /// </summary>
    public partial class StorageAccountCredential
    {
        private CloudType _cloudType;
        
        /// <summary>
        /// Required. Type of cloud
        /// </summary>
        public CloudType CloudType
        {
            get { return this._cloudType; }
            set { this._cloudType = value; }
        }
        
        private string _hostname;
        
        /// <summary>
        /// Required. Host name
        /// </summary>
        public string Hostname
        {
            get { return this._hostname; }
            set { this._hostname = value; }
        }
        
        private string _instanceId;
        
        /// <summary>
        /// Optional. The instance identifier
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }
        
        private bool _isDefault;
        
        /// <summary>
        /// Required. Is default
        /// </summary>
        public bool IsDefault
        {
            get { return this._isDefault; }
            set { this._isDefault = value; }
        }
        
        private string _location;
        
        /// <summary>
        /// Optional. Locations
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        
        private string _login;
        
        /// <summary>
        /// Required. user name
        /// </summary>
        public string Login
        {
            get { return this._login; }
            set { this._login = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. The name of the entity
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private OperationInProgress _operationInProgress;
        
        /// <summary>
        /// Optional. Is operation in progress
        /// </summary>
        public OperationInProgress OperationInProgress
        {
            get { return this._operationInProgress; }
            set { this._operationInProgress = value; }
        }
        
        private string _password;
        
        /// <summary>
        /// Required. password
        /// </summary>
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }
        
        private string _passwordEncryptionCertThumbprint;
        
        /// <summary>
        /// Optional. Certificate thumbprint for password encryption
        /// </summary>
        public string PasswordEncryptionCertThumbprint
        {
            get { return this._passwordEncryptionCertThumbprint; }
            set { this._passwordEncryptionCertThumbprint = value; }
        }
        
        private bool _useSSL;
        
        /// <summary>
        /// Required. Flag for settings useSSL
        /// </summary>
        public bool UseSSL
        {
            get { return this._useSSL; }
            set { this._useSSL = value; }
        }
        
        private int _volumeCount;
        
        /// <summary>
        /// Required. Number of Volume
        /// </summary>
        public int VolumeCount
        {
            get { return this._volumeCount; }
            set { this._volumeCount = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the StorageAccountCredential class.
        /// </summary>
        public StorageAccountCredential()
        {
        }
    }
}
