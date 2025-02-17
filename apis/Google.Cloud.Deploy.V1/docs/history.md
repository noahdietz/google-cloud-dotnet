# Version history

## Version 2.0.0, released 2022-06-08

This is the first version of this package to depend on GAX v4.

There are some breaking changes, both in GAX v4 and in the generated
code. The changes that aren't specific to any given API are [described in the Google Cloud
documentation](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax4).
We don't anticipate any changes to most customer code, but please [file a
GitHub issue](https://github.com/googleapis/google-cloud-dotnet/issues/new/choose)
if you run into problems.

The most important change in this release is the use of the Grpc.Net.Client package
for gRPC communication, instead of Grpc.Core. When using .NET Core 3.1 or .NET 5.0+
this should lead to a smaller installation footprint and greater compatibility (e.g.
with Apple M1 chips). Any significant change in a core component comes with the risk
of incompatibility, however - so again, please let us know if you encounter any
issues.


## Version 1.1.0, released 2022-04-26

### New features

- Add support for Anthos worker pool. ([commit 456b719](https://github.com/googleapis/google-cloud-dotnet/commit/456b71950b4e34b14de76a63effd2fa5e5d92ff9))

### Documentation improvements

- Cloud Deploy API Platform Logging documentation ([commit 456b719](https://github.com/googleapis/google-cloud-dotnet/commit/456b71950b4e34b14de76a63effd2fa5e5d92ff9))

## Version 1.0.0, released 2022-01-25

No API surface changes; just dependency updates and promotion to 1.0.0.

## Version 1.0.0-beta02, released 2021-12-07

- [Commit 1c771ae](https://github.com/googleapis/google-cloud-dotnet/commit/1c771ae): docs: fix docstring formatting
## Version 1.0.0-beta01, released 2021-09-23

Initial release.
