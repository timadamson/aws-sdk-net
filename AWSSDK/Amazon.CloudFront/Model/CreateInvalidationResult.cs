/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// The returned result of the corresponding request.
    /// </summary>
    public partial class CreateInvalidationResult
    {
        private Invalidation _invalidation;
        private string _location;


        /// <summary>
        /// Gets and sets the property Invalidation. The invalidation's information.
        /// </summary>
        public Invalidation Invalidation
        {
            get { return this._invalidation; }
            set { this._invalidation = value; }
        }


        /// <summary>
        /// Sets the Invalidation property
        /// </summary>
        /// <param name="invalidation">The value to set for the Invalidation property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInvalidationResult WithInvalidation(Invalidation invalidation)
        {
            this._invalidation = invalidation;
            return this;
        }

        // Check to see if Invalidation property is set
        internal bool IsSetInvalidation()
        {
            return this._invalidation != null;
        }


        /// <summary>
        /// Gets and sets the property Location. The fully qualified URI of the distribution and
        /// invalidation batch request, including the Invalidation ID.
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }


        /// <summary>
        /// Sets the Location property
        /// </summary>
        /// <param name="location">The value to set for the Location property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInvalidationResult WithLocation(string location)
        {
            this._location = location;
            return this;
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

    }
}