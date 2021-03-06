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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeServices operation.
    /// Returns the current list of AWS services and a list of service categories that applies
    /// to each one. You then use service names and categories in your <a>CreateCase</a> requests.
    /// Each AWS service has its own set of categories.
    /// 
    ///  
    /// <para>
    /// The service codes and category codes correspond to the values that are displayed in
    /// the <b>Service</b> and <b>Category</b> drop-down lists on the AWS Support Center <a
    /// href="https://console.aws.amazon.com/support/home#/case/create">Create Case</a> page.
    /// The values in those fields, however, do not necessarily match the service codes and
    /// categories returned by the <code>DescribeServices</code> request. Always use the service
    /// codes and categories obtained programmatically. This practice ensures that you always
    /// have the most recent set of service and category codes.
    /// </para>
    /// </summary>
    public partial class DescribeServicesRequest : AmazonAWSSupportRequest
    {
        private string _language;
        private List<string> _serviceCodeList = new List<string>();

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The ISO 639-1 code for the language in which AWS provides support. AWS Support currently
        /// supports English ("en") and Japanese ("ja"). Language parameters must be passed explicitly
        /// for operations that take them.
        /// </para>
        /// </summary>
        public string Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceCodeList. 
        /// <para>
        /// A JSON-formatted list of service codes available for AWS services.
        /// </para>
        /// </summary>
        public List<string> ServiceCodeList
        {
            get { return this._serviceCodeList; }
            set { this._serviceCodeList = value; }
        }

        // Check to see if ServiceCodeList property is set
        internal bool IsSetServiceCodeList()
        {
            return this._serviceCodeList != null && this._serviceCodeList.Count > 0; 
        }

    }
}