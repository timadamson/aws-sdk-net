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
using Amazon.Runtime;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Returns information about the UpdateStreamingDistributionResult response and response metadata.
    /// </summary>
    public class UpdateStreamingDistributionResponse : AmazonWebServiceResponse
    {
        private UpdateStreamingDistributionResult _updateStreamingDistributionResult;

        /// <summary>
        /// Gets and sets the UpdateStreamingDistributionResult property.
        /// Represents the output of a UpdateStreamingDistribution operation.
        /// </summary>
        public UpdateStreamingDistributionResult UpdateStreamingDistributionResult
        {
            get
            {
                if(this._updateStreamingDistributionResult == null)
                {
                    this._updateStreamingDistributionResult = new UpdateStreamingDistributionResult();
                }
                return this._updateStreamingDistributionResult;
            }
            set { this._updateStreamingDistributionResult = value; }
        }
    }
}