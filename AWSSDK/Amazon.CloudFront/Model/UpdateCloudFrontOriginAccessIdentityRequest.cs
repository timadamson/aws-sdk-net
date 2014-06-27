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
    /// Container for the parameters to the UpdateCloudFrontOriginAccessIdentity operation.
    /// Update an origin access identity.
    /// </summary>
    public partial class UpdateCloudFrontOriginAccessIdentityRequest : AmazonWebServiceRequest
    {
        private CloudFrontOriginAccessIdentityConfig _cloudFrontOriginAccessIdentityConfig;
        private string _id;
        private string _ifMatch;


        /// <summary>
        /// Gets and sets the property CloudFrontOriginAccessIdentityConfig. The identity's configuration
        /// information.
        /// </summary>
        public CloudFrontOriginAccessIdentityConfig CloudFrontOriginAccessIdentityConfig
        {
            get { return this._cloudFrontOriginAccessIdentityConfig; }
            set { this._cloudFrontOriginAccessIdentityConfig = value; }
        }


        /// <summary>
        /// Sets the CloudFrontOriginAccessIdentityConfig property
        /// </summary>
        /// <param name="cloudFrontOriginAccessIdentityConfig">The value to set for the CloudFrontOriginAccessIdentityConfig property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateCloudFrontOriginAccessIdentityRequest WithCloudFrontOriginAccessIdentityConfig(CloudFrontOriginAccessIdentityConfig cloudFrontOriginAccessIdentityConfig)
        {
            this._cloudFrontOriginAccessIdentityConfig = cloudFrontOriginAccessIdentityConfig;
            return this;
        }

        // Check to see if CloudFrontOriginAccessIdentityConfig property is set
        internal bool IsSetCloudFrontOriginAccessIdentityConfig()
        {
            return this._cloudFrontOriginAccessIdentityConfig != null;
        }


        /// <summary>
        /// Gets and sets the property Id. The identity's id.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }


        /// <summary>
        /// Sets the Id property
        /// </summary>
        /// <param name="id">The value to set for the Id property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateCloudFrontOriginAccessIdentityRequest WithId(string id)
        {
            this._id = id;
            return this;
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }


        /// <summary>
        /// Gets and sets the property IfMatch. The value of the ETag header you received when
        /// retrieving the identity's configuration. For example: E2QWRUHAPOMQZL.
        /// </summary>
        public string IfMatch
        {
            get { return this._ifMatch; }
            set { this._ifMatch = value; }
        }


        /// <summary>
        /// Sets the IfMatch property
        /// </summary>
        /// <param name="ifMatch">The value to set for the IfMatch property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateCloudFrontOriginAccessIdentityRequest WithIfMatch(string ifMatch)
        {
            this._ifMatch = ifMatch;
            return this;
        }

        // Check to see if IfMatch property is set
        internal bool IsSetIfMatch()
        {
            return this._ifMatch != null;
        }

    }
}