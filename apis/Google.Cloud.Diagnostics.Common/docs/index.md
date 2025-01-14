{{title}}

`Google.Cloud.Diagnostics.Common` is a .NET Core instrumentation library for Google Logging,
Error Reporting and Tracing. It allows for simple integration of Google observability components into .NET Standard 2.0+ applications
with minimal custom code.

[`Google.Cloud.Diagnostics.AspNetCore`](https://cloud.google.com/dotnet/docs/reference/Google.Cloud.Diagnostics.AspNetCore/latest) and
[`Google.Cloud.Diagnostics.AspNetCore3`](https://cloud.google.com/dotnet/docs/reference/Google.Cloud.Diagnostics.AspNetCore3/latest)
are the recommended instrumentation libraries if you are writing ASP.NET Core 2.1 or ASP.NET Core 3.1+ applications respectively.

{{version}}

{{installation}}

{{auth}}

See [API Permissions for `entries.write`](https://cloud.google.com/logging/docs/access-control#api-permissions)
for the permissions needed for Logging and Error Reporting.

See [API Permissions for PatchTraces](https://cloud.google.com/trace/docs/iam#api_permissions)
for the permissions needed for Tracing.

> **Note**  
> The `Google.Cloud.Diagnostics.Common` package attempts to collect the filename and line number when
> error entries are collected. However, to be able to collect this information PDBs must be included with
> the deployed code.

> **Note**  
> Some environments limit or disable CPU usage for background activities, while some others allow you to
> configure CPU allocation for request processing only.
> When running on environments with limited CPU for background activities, take care not to use the
> timed buffer options for any of Logging, Tracing or Error Reporting. Take into account that the timed buffer
> is used for the Logging and Tracing components by default so you will need to explicitly configure the buffers by using
> the `Google.Cloud.Diagnostics.Common.LoggerOptions` and `Google.Cloud.Diagnostics.Common.TraceOptions` classes. The Error Reporting
> component does not buffer entries by default.
> Below you'll find examples of how to configure the buffers.
> Here you can read more about [CPU allocation in Google Cloud Run](https://cloud.google.com/run/docs/tips/general#background-activity).

> **Note**
> Using `Google.Cloud.Diagnostics.Common` for non ASP.NET Core applications relies heavily on
> .NET's Dependency Injection mechanism.
> You can read more about .NET dependency injection in non ASP.NET Core applications in the
> [Microsoft documentation](https://docs.microsoft.com/en-us/dotnet/core/extensions/dependency-injection-usage).

## Getting started

The easiest way to configure Google Cloud Diagnostics is using the `AddGoogleDiagnostics` extension
methods on `IServiceCollection`.
This configures the Logging, Tracing and Error Reporting components.

If your application is running on Google App Engine, Google Kubernetes Engine, Google Cloud Run or 
Google Compute Engine, you don't need to provide a value for `ProjectId`, `Service` and `Version`
since they can be automatically obtained by the `AddGoogleDiagnostics` methods as far as they make sense for the
environment. (Not every environment has the concept of a "service" or "version".)
The values used will be the ones associated with the running application.

If your application is running outside of GCP, including when it runs locally, then you'll need to provide the 
`ProjectId` of the Google Cloud Project in which to store the diagnostic information as well as the `Service` and `Version`
with which to identify your application.

{{sample:Diagnostics.Configure}}

Don't forget to start the host.

{{sample:Diagnostics.Start}}

You can still initialize the separate components using the extension methods described below.
This can be useful if you only need to use some of the observability components.

Optional parameters on `AddGoogleDiagnostics` are also available to specify options for each of the components
(logging, tracing and error reporting).

### Buffers and buffer configuration

The Diagnostics instrumentation library supports different buffering strategies that may be configured individually for each of the
Logging, Tracing and Error Reporting components, i.e. you don't need to use the same buffering strategy for each of the components
and even if you do, each buffer may be configured differently for each of the components. For instance, a timed buffer may be configured
for Logging with a 5 second period at the same time as a timed buffer with a 7 second period is configured for Tracing.

These strategies are:

- Timed buffers: Written entries are stored in a buffer that is flushed periodically to the backend service.
  This is the buffering strategy used by default by the Tracing and Logging components. Since the service calls
  are performed in the background, this buffering strategy won't affect your application's performance, in particular
  it won't affect external requests or user interactions. Depending on the amount of entries your application is generating, you may
  want to fine tune the timed buffer period, which defaults to 5 seconds, to flush more or less frequently by taking into account
  application memory comsumption and how soon you need entries to appear on the backend.
  As stated earlier in this documentation, it is important to note that some environments do limit CPU usage for background
  operations, and in such cases, using timed buffers may result in delayed backend entry recording, lost entries or even thread starvation
  scenarios.
- Sized buffers: Written entries are stored in a buffer that is flushed to the backend service when it reaches a given size.
  Service calls are not performed in the background, so the sized buffer may affect performance of certain external requests or
  user interactions, in particular those who make the buffer reach the flushing size. In general you'll need to fine tune the
  buffer size so that flushing occurs as little as possible while keeping memory comsumption at appropriate levels. Adjustments will
  depend on the amount of entries your application is generating.
- No buffer: Entries are sent to the backend service as soon as they are generated by your application. This is the buffering strategy
  used by default by the Error Reporting component. A service call will be made whenever an entry is generated by your application which
  may affect performance greatly, depending on the amount of entries your code is generating.

Below you can see sample code that forces all three components to use no buffering.

{{sample:Diagnostics.ConfigureBuffers}}

## Error reporting

The error reporting component allows you to create error reports from exceptions thrown in your application.

## Configuration

The first step is to configure the error reporting component for dependency injection.

{{sample:ErrorReporting.Configure}}

And then start the host. This will probably be done in your `Main` method.

{{sample:ErrorReporting.Start}}

## Logging exceptions

Now you can log exceptions whenever they are thrown. Meaningful error reports will be created and sent to
Google Cloud Error Reporting.

{{sample:ErrorReporting.LogException}}

## Logging

The logging component allows you to store the logs generated by your application in Google Cloud Logger.
The `GoogleLogger` implements `Microsoft.Extensions.Logging.ILogger` and so it integrates seamlessly with .NET's
logging infrastructure.

## Configuration

For configuring the logging component you use the `AddGoogle` extension method on a `Microsoft.Extensions.Logging.ILoggingBuilder`.

You can onfigure logging when configuring your host builder.

{{sample:Logging.ConfigureLogging}}

As an alternative, you can configure logging when you are configuring services for your application. This approach is useful
if you are configuring services in a `Startup` class or similar.

{{sample:Logging.ConfigureServices}}

And then start the host. This will probably be done in your `Main`.

{{sample:Logging.Start}}

## Log

For logging, youuse the configured Google Cloud Logger as you would any other `Microsoft.Extensions.Logging.ILogger`.

{{sample:Logging.Logging}}

## Troubleshooting Logging

Sometimes it is necessary to diagnose log operations. It might be that logging is failing or that you simply cannot find
where the logs are being stored in Google Cloud Logging. What follows are a couple of code samples that can be useful to
find out what might be wrong with logging operations.

### Propagating Exceptions

By default the Google Logger won't propagate any exceptions thrown during logging. This is to protect the application from
crashing if logging is not possible. But logging is an important aspect of most applications so at times we need to know if
it's failing and why. The following example shows how to configure Google Logger so that it propagates exceptions thrown during
logging.

{{sample:Logging.PropagatesExceptions}}

### Finding out the URL where logs are written

Depending on where your code is running and the options you provided for creating a Google Logger, it might be hard to find
your logs in the Google Cloud Logging Console. We have provided a way for you to obtain the URL where your logs can be found.

As the following code sample shows, you only need to pass a `System.IO.TextWriter` (typically `Console.Out` or `Console.Error`)
as part of the options when configuring logging. When the `GoogleLoggerProvider` is initialized, the URL where its logs can be
found will be written to the given text writer.

{{sample:Logging.WritesLogsURL}}

Please note that since this is a Google Logger diagnostics feature, we don't respect settings for exception handling, i.e. we propagate
any exception thrown while writing the URL to the given text writer so you know what might be happening. This feature should only be
activated as a one off, if you are having trouble finding your logs in the GCP Console, and not as a permanent feature in
production code. To deactivate this feature simply stop passing a `System.IO.TextWriter` as part of the options when configuring 
Google Logger.

## Tracing

The tracing component allows you to trace your application and send traces to Google Cloud Trace.

## Configuration

The first step is to configure the tracing component for dependency injection.

{{sample:Trace.Configure}}

And then start the host. This will probably be done in your `Main` method.

{{sample:Trace.Start}}

## Starting a trace

How to start a trace will depend on how you want to trace, and what type of application you want to trace.

- You want to trace all activity of your application in one trace (within potentially different spans). This
is best suited for scheduled services or user facing applications (like desktop applications) where you want
to have one trace per usage session.
- Your application is a service reacting to requests/events (for instance it's a subscriber on a publisher/subscriber
architectured system). You want a trace per request/event; the trace may have even be initialized by the emitter of
said request/event.

### One trace per usage session

If you want to have one trace per usage session, then right after starting the host, probably on your `Main` method
you would create the trace.

{{sample:Trace.SingleContext}}

Note that when you create the tracing context, you don't need to specify trace ID or span ID (although you may),
`Google.Cloud.Diagnostics.Common` will create a trace ID for you. Each span you create will be created with it's own
span ID.

Note that you should specify `true` for the `shouldTrace`parameter to make sure tha tracing happens regardless
of tracing rates/qps, etc.

### One trace per request/event

If your application reacts to requests/events, then on the method that receives each of those (your listener method)
you need to extract the trace context information from the request and ser it on the tracer.

{{sample:Trace.IncomingContext}}

Note that we can't go into detail here as to how extract trace context information from a request/event, as that's
dependent on the emitter of said request/event.

If the emitter of requests/events is not attaching trace context information, then you can start your own
trace for each request/event. On your listener method, you would have code similar to the one in the
[One trace per usage sesion](### One trace per usage session). But consider in this case not forcing the trace,
instead specify `null` for the `shouldTrace` parameter. The tracer will decide whether to trace each request based
on tracing rates/qps, etc.

## Starting a span

For any traces to be sent to Google Cloud Trace, a span needs to be started.

{{sample:Trace.Trace}}

Or alternatively, using the `RunInSpan` methods.

{{sample:Trace.RunInSpan}}

## Troubleshooting Tracing

Failures in tracing are most easily diagnosed by removing buffering and propagating exceptions immediately.

{{sample:Trace.Troubleshooting}}

These options may be specified wherever you are configuring tracing.

## Trace Outgoing HTTP Requests

If your application itself performs HTTP requests to other services you may want to propagate trace context information.
The [recommended way of creating `HttpClient`](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/http-requests?view=aspnetcore-3.1)
in .NET Standard 2.0+ and upwards is to use the `System.Net.Http.IHttpClientFactory` defined in the
`Microsoft.Extensions.Http` package.
The following example demonstrates how to register and use an `HttpClient` using Google Trace so that it propagates trace
context information for outgoing requests.

### Configuration

{{sample:Trace.ConfigureHttpClient}}

### Usage

{{sample:Trace.TraceOutgoingClientFactory}}

### Custom trace context for outgoing HTTP requests

If you configure the trace component for outgoing requests, it will, by default, set on them
[Google's own trace header](https://cloud.google.com/trace/docs/setup#force-trace).
If you want to propagate trace context information in a format other than Google's trace header, you can use dependency
injection to register an action `System.Action<System.Net.Http.HttpRequestMessage, Google.Cloud.Diagnostics.Common.ITraceContext>`
that will be used to set trace context information on outgoing HTTP requests. A few things to notice:

- The format in which you propagate trace context information to external requests doesn't have to be the same as
the format in which trace context information is received by your application.

- The trace context information propagated to outgoing requests will be the information available at the time the 
request is made, which may or may not be the same as the information you received. For instance, your code may have
created several trace spans before making the outgoing request, in which case the span ID that will be propagated
is the one of the innermost span that remains open at the moment of sending the outgoing request.

Here's an example of how your configuration may look like. You then use `System.Net.Http.IHttpClientFactory` as shown
in [Usage](### Usage).

Note that the following is for demonstration purposes only. We assume that trace context information contains a trace ID only
that is propagated in a `custom_trace_id` header. This is of no use in the real world.

{{sample:Trace.CustomConfigureHttpClient}}

