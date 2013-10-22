/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeSpotDatafeedSubscription operation.
    /// <para> Describes the data feed for Spot Instances. </para> <para> For conceptual information about Spot Instances, refer to the Amazon
    /// Elastic Compute Cloud Developer Guide or Amazon Elastic Compute Cloud User Guide .
    /// </para>
    /// </summary>
    public partial class DescribeSpotDatafeedSubscriptionRequest : AmazonWebServiceRequest
    {
        private bool? dryRun;
        public bool DryRun
        {
            get { return this.dryRun ?? default(bool); }
            set { this.dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this.dryRun.HasValue;
        }

    }
}
    