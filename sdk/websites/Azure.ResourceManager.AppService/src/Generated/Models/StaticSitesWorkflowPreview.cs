// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Preview for the Static Site Workflow to be generated. </summary>
    public partial class StaticSitesWorkflowPreview : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of StaticSitesWorkflowPreview. </summary>
        public StaticSitesWorkflowPreview()
        {
        }

        /// <summary> Initializes a new instance of StaticSitesWorkflowPreview. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="path"> The path for the workflow file to be generated. </param>
        /// <param name="contents"> The contents for the workflow file to be generated. </param>
        internal StaticSitesWorkflowPreview(ResourceIdentifier id, string name, ResourceType type, string kind, string path, string contents) : base(id, name, type, kind)
        {
            Path = path;
            Contents = contents;
        }

        /// <summary> The path for the workflow file to be generated. </summary>
        public string Path { get; }
        /// <summary> The contents for the workflow file to be generated. </summary>
        public string Contents { get; }
    }
}
