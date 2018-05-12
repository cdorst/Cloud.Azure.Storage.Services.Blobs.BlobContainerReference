// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Cloud.Azure.Storage.Services.Blobs.Interfaces.BlobContainerReferenceGetter;
using Cloud.Azure.Storage.Services.Blobs.Interfaces.CloudBlobClientGetter;
using Microsoft.WindowsAzure.Storage.Blob;
using System;

namespace Cloud.Azure.Storage.Services.Blobs.BlobContainerReference
{
    /// <summary>Service responsible for getting a reference to an existing blob container</summary>
    public class BlobContainerReferenceGetter : IBlobContainerReferenceGetter
    {
        private readonly CloudBlobClient _blobClient;

        public BlobContainerReferenceGetter(ICloudBlobClientGetter cloudBlobClientGetter)
        {
            _blobClient = cloudBlobClientGetter?.BlobClient ?? throw new ArgumentNullException(nameof(cloudBlobClientGetter));
        }

        /// <summary>Returns CloudBlobContainer reference</summary>
        public CloudBlobContainer GetExistingContainer(string containerName) => _blobClient.GetContainerReference(containerName);
    }
}
