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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// A JSON object containing the following fields:
    /// </summary>
    public partial class DescribeGatewayInformationResult : AmazonWebServiceResponse
    {
        private string _gatewayARN;
        private string _gatewayId;
        private List<NetworkInterface> _gatewayNetworkInterfaces = new List<NetworkInterface>();
        private string _gatewayState;
        private string _gatewayTimezone;
        private string _gatewayType;
        private string _nextUpdateAvailabilityDate;

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        public string GatewayARN
        {
            get { return this._gatewayARN; }
            set { this._gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this._gatewayARN != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayId. 
        /// <para>
        /// The gateway ID.
        /// </para>
        /// </summary>
        public string GatewayId
        {
            get { return this._gatewayId; }
            set { this._gatewayId = value; }
        }

        // Check to see if GatewayId property is set
        internal bool IsSetGatewayId()
        {
            return this._gatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayNetworkInterfaces. 
        /// <para>
        /// A <a>NetworkInterface</a> array that contains descriptions of the gateway network
        /// interfaces.
        /// </para>
        /// </summary>
        public List<NetworkInterface> GatewayNetworkInterfaces
        {
            get { return this._gatewayNetworkInterfaces; }
            set { this._gatewayNetworkInterfaces = value; }
        }

        // Check to see if GatewayNetworkInterfaces property is set
        internal bool IsSetGatewayNetworkInterfaces()
        {
            return this._gatewayNetworkInterfaces != null && this._gatewayNetworkInterfaces.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GatewayState. 
        /// <para>
        /// One of the values that indicates the operating state of the gateway.
        /// </para>
        /// </summary>
        public string GatewayState
        {
            get { return this._gatewayState; }
            set { this._gatewayState = value; }
        }

        // Check to see if GatewayState property is set
        internal bool IsSetGatewayState()
        {
            return this._gatewayState != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayTimezone. 
        /// <para>
        /// One of the values that indicates the time zone configured for the gateway.
        /// </para>
        /// </summary>
        public string GatewayTimezone
        {
            get { return this._gatewayTimezone; }
            set { this._gatewayTimezone = value; }
        }

        // Check to see if GatewayTimezone property is set
        internal bool IsSetGatewayTimezone()
        {
            return this._gatewayTimezone != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayType. 
        /// <para>
        /// TBD
        /// </para>
        /// </summary>
        public string GatewayType
        {
            get { return this._gatewayType; }
            set { this._gatewayType = value; }
        }

        // Check to see if GatewayType property is set
        internal bool IsSetGatewayType()
        {
            return this._gatewayType != null;
        }

        /// <summary>
        /// Gets and sets the property NextUpdateAvailabilityDate. 
        /// <para>
        /// The date at which an update to the gateway is available. This date is in the time
        /// zone of the gateway. If the gateway is not available for an update this field is not
        /// returned in the response.
        /// </para>
        /// </summary>
        public string NextUpdateAvailabilityDate
        {
            get { return this._nextUpdateAvailabilityDate; }
            set { this._nextUpdateAvailabilityDate = value; }
        }

        // Check to see if NextUpdateAvailabilityDate property is set
        internal bool IsSetNextUpdateAvailabilityDate()
        {
            return this._nextUpdateAvailabilityDate != null;
        }

    }
}