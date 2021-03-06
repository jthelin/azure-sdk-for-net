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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.DataFactories.Models;

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// HDInsight activity properties.
    /// </summary>
    public partial class Hive : HDInsightActivityPropertiesBase
    {
        private IDictionary<string, string> _extendedProperties;
        
        /// <summary>
        /// Optional. User specified property bag used in Pig or Hive scripts.
        /// There is no restriction on the keys or values that can be used.
        /// User needs to consume and interpret the content accordingly in
        /// their customized Pig or Hive scripts.
        /// </summary>
        public IDictionary<string, string> ExtendedProperties
        {
            get { return this._extendedProperties; }
            set { this._extendedProperties = value; }
        }
        
        private string _script;
        
        /// <summary>
        /// Optional. script.
        /// </summary>
        public string Script
        {
            get { return this._script; }
            set { this._script = value; }
        }
        
        private string _scriptLinkedService;
        
        /// <summary>
        /// Optional. Script linked service.
        /// </summary>
        public string ScriptLinkedService
        {
            get { return this._scriptLinkedService; }
            set { this._scriptLinkedService = value; }
        }
        
        private string _scriptPath;
        
        /// <summary>
        /// Optional. Script path.
        /// </summary>
        public string ScriptPath
        {
            get { return this._scriptPath; }
            set { this._scriptPath = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Hive class.
        /// </summary>
        public Hive()
        {
            this.ExtendedProperties = new LazyDictionary<string, string>();
        }
    }
}
