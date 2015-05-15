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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WorkSpaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateWorkspaces Request Marshaller
    /// </summary>       
    public class CreateWorkspacesRequestMarshaller : IMarshaller<IRequest, CreateWorkspacesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateWorkspacesRequest)input);
        }

        public IRequest Marshall(CreateWorkspacesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkSpaces");
            string target = "WorkspacesService.CreateWorkspaces";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetWorkspaces())
                {
                    context.Writer.WritePropertyName("Workspaces");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestWorkspacesListValue in publicRequest.Workspaces)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = WorkspaceRequestMarshaller.Instance;
                        marshaller.Marshall(publicRequestWorkspacesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}