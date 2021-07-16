# Breaking changes (Feb 2020)

Prior to February 2020, all API client libraries targeted GAX
(Google.Api.Gax and related packages) version 2.x. As part of
supporting Grpc.Core 2.x and the `IAsyncEnumerable<T>` interface
that's compatible with C# 8, a new major version of GAX was
released, with the first beta in February 2020. This contains
breaking changes, and we've taken advantage of the opportunity this
provides to make some separate breaking changes in code generation
at the same time.

This document provides a guide to these breaking changes, most of
which apply to most or all API libraries. Any breaking changes which
only affect a single API library are documented in the corresponding
version history instead.

# Platform support

GAX v3 supports .NET Standard 2.0 and .NET 4.6.1 (and higher
versions of each). (For reference, GAX v2 supported .NET Standard
1.3 or 1.5 depending on the exact package, and .NET 4.5.)

This means that if you want to use the API libraries targeting GAX
v3, you need to be using .NET Core 2.0 or .NET 4.6.1, or a higher
version of either of these.

# Client creation

Creating a client with the default endpoint, credentials, settings
etc is still supported via the static `Create` and `CreateAsync`
methods on the client class. If you need any customization, please
use the corresponding client builder class. For example:

```csharp
// Synchronous creation with defaults
var client1 = SpeechClient.Create();

// Asynchronous creation with defaults
var client2 = await SpeechClient.CreateAsync();

// Customized synchronous creation
var client3 = new SpeechClientBuilder
{
   UserAgent = "custom-user-agent"
}.Build();
```

# Endpoints

The previous GAX `ServiceEndpoint` class has been removed. Endpoints
are now specified as strings. For example:

```csharp
// Customized synchronous creation
var client3 = new SpeechClientBuilder
{
    Endpoint = "sandbox.speech.googleapis.com"
}.Build();
```

# Retry settings

## RetrySettings and BackoffSettings types

The GAX v2 `RetrySettings` class contained two `BackoffSettings`
members, one for timeouts and one for backoff between attempts. A
separate `CallTiming` class contained the expiration and the retry
settings.

In GAX v3, `RetrySettings` is only about backoff, and contains the
multiplier, filter etc directly. This is based on the retry
specification from gRPC. The expiration is directly specified in
`CallSettings`.

## Generated methods in API libraries

Previous versions exposed properties and methods for retry settings of
grouped operations, e.g. `IdempotentRetryFilter`,
`GetDefaultRetryBackoff()` and `GetDefaultTimeoutBackoff()`. These
are not generated by the new generator, and there is no equivalent.
Instead, use the settings applicable to individual RPCs.

# Resource names

## Multi-pattern resources

When a resource name is represented by multiple patterns, the
previous generator created multiple resource name types and a
"one-of" type to represent "one of those resource names". For
example, in the Logging.V2 API, we had a `LogNameOneof` class which
would be a `LogName`, `OrganizationLogName`, `FolderLogName`, or
`BillingLogName`.

The new generator generates a single `LogName` resource that can
handle each of the patterns, with a static factory method for each
one:

- `FromProjectLog`
- `FromOrganizationLog`
- `FromFolderLog`
- `FromBillingAccountLog`

## Multi-resource methods

Some RPCs accept multiple resource names. This is typically the
case when specifying the parent of a resource name which itself has
multiple patterns. Again, this was previously represented using a
"one-of" type, but the new generator creates an overload for each
resource type, as well as one accepting a string.

## Common resource names

In order to work with multiple APIs simply, some common resource
names are in GAX. These are:

- `ProjectName`
- `LocationName`
- `OrganizationName`
- `FolderName`
- `BillingAccountName`

All of these are in the `Google.Api.Gax.ResourceNames` namespace.

Some API libraries previously used some of these resource name
patterns - particularly `LocationName` - but had their own types.
For example, the Logging API library used to include its own
`OrganizationName`, `BillingName`, `ProjectName` and `FolderName`
types, all within `Google.Cloud.Logging.V2`. These were maintained
across minor releases for backward compatibility, but have been
removed in the new major version.

Code broken by this change will normally just need to import the
`Google.Api.Gax.ResourceNames` namespace.