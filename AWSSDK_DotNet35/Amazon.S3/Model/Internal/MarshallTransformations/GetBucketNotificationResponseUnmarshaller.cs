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
using System.Net;
using System.Collections.Generic;
using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for GetBucketNotification operation
    /// </summary>
    internal class GetBucketNotificationResponseUnmarshaller : S3ReponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {   
            GetBucketNotificationResponse response = new GetBucketNotificationResponse();
            response.TopicConfigurations = new List<TopicConfiguration>();

            while (context.Read())
            {
                if (context.IsStartElement)
                {                    
                    UnmarshallResult(context,response);                        
                    continue;
                }
            }
                        
            return response;
        }
        
        private static void UnmarshallResult(XmlUnmarshallerContext context,GetBucketNotificationResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("TopicConfiguration", targetDepth))
                    {
                        response.TopicConfigurations.Add(TopicConfigurationUnmarshaller.Instance.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("QueueConfiguration", targetDepth))
                    {
                        response.QueueConfigurations.Add(QueueConfigurationUnmarshaller.Instance.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("CloudFunctionConfiguration", targetDepth))
                    {
                        var cfc = CloudFunctionConfigurationUnmarshaller.Instance.Unmarshall(context);
                        if (cfc == null || cfc.IsSetInvocationRole())
                        {
                            response.CloudFunctionConfigurations.Add(cfc);
                        }
                        else
                        {
                            var lfc = new LambdaFunctionConfiguration
                            {
                                FunctionArn = cfc.CloudFunction,
                                Events = cfc.Events,
                                Id = cfc.Id
                            };
                            response.LambdaFunctionConfigurations.Add(lfc);
                        }
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return;
                }
            }

            return;
        }

        private static GetBucketNotificationResponseUnmarshaller _instance;

        public static GetBucketNotificationResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GetBucketNotificationResponseUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
    
