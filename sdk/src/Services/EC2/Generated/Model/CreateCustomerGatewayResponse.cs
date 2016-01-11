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

/*
 * Do not modify this file. This file is generated from the ec2-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class CreateCustomerGatewayResponse : AmazonWebServiceResponse
    {
        private CustomerGateway _customerGateway;

        /// <summary>
        /// Gets and sets the property CustomerGateway. 
        /// <para>
        /// Information about the customer gateway.
        /// </para>
        /// </summary>
        public CustomerGateway CustomerGateway
        {
            get { return this._customerGateway; }
            set { this._customerGateway = value; }
        }

        // Check to see if CustomerGateway property is set
        internal bool IsSetCustomerGateway()
        {
            return this._customerGateway != null;
        }

    }
}