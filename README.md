# Cloud.Azure.Storage.Services.Blobs.BlobContainerReference

[![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/cloud-azure-storage-services-blobs-blobcontainerre.svg?label=AppVeyor&style=for-the-badge)](https://ci.appveyor.com/project/cdorst/cloud-azure-storage-services-blobs-blobcontainerre)
[![NuGet package status](https://img.shields.io/nuget/v/CDorst.Cloud.Azure.Storage.Services.Blobs.BlobContainerReference.svg?label=NuGet&style=for-the-badge)](https://www.nuget.org/packages/CDorst.Cloud.Azure.Storage.Services.Blobs.BlobContainerReference)

## Description

Service responsible for getting a reference to an existing blob container

## Environment Variables

This project depends on this environment variable:

Name | Description
---- | -----------
`LOCAL_NUGET_SOURCE_PATH` | *Required* to build the project, but not required during code execution. This is set to `c:\projects\nuget\cache` on the build server. On your development machine, set this to an empty, existing path. `dotnet restore` will inspect this folder prior to checking NuGet.

## Dependencies

Name | Status
---- | ------
[CDorst.Cloud.Azure.Storage.Services.Blobs.Interfaces.BlobContainerReferenceGetter](https://github.com/CDorst/Cloud.Azure.Storage.Services.Blobs.Interfaces.BlobContainerReferenceGetter) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/cloud-azure-storage-services-blobs-interfaces-blob.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/cloud-azure-storage-services-blobs-interfaces-blob) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Cloud.Azure.Storage.Services.Blobs.Interfaces.BlobContainerReferenceGetter.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Cloud.Azure.Storage.Services.Blobs.Interfaces.BlobContainerReferenceGetter)
[CDorst.Cloud.Azure.Storage.Services.Blobs.Interfaces.CloudBlobClientGetter](https://github.com/CDorst/Cloud.Azure.Storage.Services.Blobs.Interfaces.CloudBlobClientGetter) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/cloud-azure-storage-services-blobs-interfaces-clou.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/cloud-azure-storage-services-blobs-interfaces-clou) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Cloud.Azure.Storage.Services.Blobs.Interfaces.CloudBlobClientGetter.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Cloud.Azure.Storage.Services.Blobs.Interfaces.CloudBlobClientGetter)

## NuGet

This project is published as a NuGet package at [https://www.nuget.org/packages/CDorst.Cloud.Azure.Storage.Services.Blobs.BlobContainerReference](https://www.nuget.org/packages/CDorst.Cloud.Azure.Storage.Services.Blobs.BlobContainerReference)

## Version

1.0.0

## Metaproject

Cloud.Azure.Storage.Services.Blobs.BlobContainerReference is maintained by robots and exists because of a declarative template metaproject. View the metaproject's component directory at [https://github.com/CDorst/Project.Index](https://github.com/CDorst/Project.Index)

