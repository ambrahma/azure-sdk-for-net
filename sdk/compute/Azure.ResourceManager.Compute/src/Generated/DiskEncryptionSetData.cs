// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing the DiskEncryptionSet data model. </summary>
    public partial class DiskEncryptionSetData : TrackedResource
    {
        /// <summary> Initializes a new instance of DiskEncryptionSetData. </summary>
        /// <param name="location"> The location. </param>
        public DiskEncryptionSetData(AzureLocation location) : base(location)
        {
            PreviousKeys = new ChangeTrackingList<KeyForDiskEncryptionSet>();
        }

        /// <summary> Initializes a new instance of DiskEncryptionSetData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The managed identity for the disk encryption set. It should be given permission on the key vault before it can be used to encrypt disks. </param>
        /// <param name="encryptionType"> The type of key used to encrypt the data of the disk. </param>
        /// <param name="activeKey"> The key vault key which is currently used by this disk encryption set. </param>
        /// <param name="previousKeys"> A readonly collection of key vault keys previously used by this disk encryption set while a key rotation is in progress. It will be empty if there is no ongoing key rotation. </param>
        /// <param name="provisioningState"> The disk encryption set provisioning state. </param>
        /// <param name="rotationToLatestKeyVersionEnabled"> Set this flag to true to enable auto-updating of this disk encryption set to the latest key version. </param>
        /// <param name="lastKeyRotationTimestamp"> The time when the active key of this disk encryption set was updated. </param>
        internal DiskEncryptionSetData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, AzureLocation location, EncryptionSetIdentity identity, DiskEncryptionSetType? encryptionType, KeyForDiskEncryptionSet activeKey, IReadOnlyList<KeyForDiskEncryptionSet> previousKeys, string provisioningState, bool? rotationToLatestKeyVersionEnabled, DateTimeOffset? lastKeyRotationTimestamp) : base(id, name, type, tags, location)
        {
            Identity = identity;
            EncryptionType = encryptionType;
            ActiveKey = activeKey;
            PreviousKeys = previousKeys;
            ProvisioningState = provisioningState;
            RotationToLatestKeyVersionEnabled = rotationToLatestKeyVersionEnabled;
            LastKeyRotationTimestamp = lastKeyRotationTimestamp;
        }

        /// <summary> The managed identity for the disk encryption set. It should be given permission on the key vault before it can be used to encrypt disks. </summary>
        public EncryptionSetIdentity Identity { get; set; }
        /// <summary> The type of key used to encrypt the data of the disk. </summary>
        public DiskEncryptionSetType? EncryptionType { get; set; }
        /// <summary> The key vault key which is currently used by this disk encryption set. </summary>
        public KeyForDiskEncryptionSet ActiveKey { get; set; }
        /// <summary> A readonly collection of key vault keys previously used by this disk encryption set while a key rotation is in progress. It will be empty if there is no ongoing key rotation. </summary>
        public IReadOnlyList<KeyForDiskEncryptionSet> PreviousKeys { get; }
        /// <summary> The disk encryption set provisioning state. </summary>
        public string ProvisioningState { get; }
        /// <summary> Set this flag to true to enable auto-updating of this disk encryption set to the latest key version. </summary>
        public bool? RotationToLatestKeyVersionEnabled { get; set; }
        /// <summary> The time when the active key of this disk encryption set was updated. </summary>
        public DateTimeOffset? LastKeyRotationTimestamp { get; }
    }
}
