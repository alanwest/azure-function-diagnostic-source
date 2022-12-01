# OpenTelemetry 1.4.0 + Azure Function (in-process)

```
System.IO.FileNotFoundException: 'Could not load file or assembly 'System.Diagnostics.DiagnosticSource, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'. The system cannot find the file specified.'
   at OpenTelemetry.Sdk.CreateTracerProviderBuilder()
   at FunctionsOpenTelemetry.Startup.Configure(IFunctionsHostBuilder builder) in C:\Users\Alan\github\alanwest\azure-function-diagnostic-source\Startup.cs:line 11
   at Microsoft.Azure.Functions.Extensions.DependencyInjection.FunctionsStartup.Configure(WebJobsBuilderContext context, IWebJobsBuilder builder)
   at Microsoft.Azure.WebJobs.WebJobsBuilderExtensions.ConfigureStartup(IWebJobsStartup startup, WebJobsBuilderContext context, IWebJobsBuilder builder)
   at Microsoft.Azure.WebJobs.WebJobsBuilderExtensions.ConfigureAndLogUserConfiguredServices(IWebJobsStartup startup, WebJobsBuilderContext context, IWebJobsBuilder builder, ILoggerFactory loggerFactory)
   at Microsoft.Azure.WebJobs.WebJobsBuilderExtensions.UseWebJobsStartup(IWebJobsBuilder builder, Type startupType, WebJobsBuilderContext context, ILoggerFactory loggerFactory)
   at Microsoft.Azure.WebJobs.WebJobsBuilderExtensions.UseExternalStartup(IWebJobsBuilder builder, IWebJobsStartupTypeLocator startupTypeLocator, WebJobsBuilderContext context, ILoggerFactory loggerFactory)
   at Microsoft.Azure.WebJobs.Script.ScriptHostBuilderExtensions.<>c__DisplayClass7_0.<AddScriptHostCore>b__1(HostBuilderContext context, IWebJobsBuilder webJobsBuilder)
   at Microsoft.Extensions.Hosting.WebJobsHostBuilderExtensions.<>c__DisplayClass5_0.<ConfigureWebJobs>b__1(HostBuilderContext context, IServiceCollection services)
   at Microsoft.Extensions.Hosting.HostBuilder.CreateServiceProvider()
   at Microsoft.Extensions.Hosting.HostBuilder.Build()
   at Microsoft.Azure.WebJobs.Script.WebHost.DefaultScriptHostBuilder.BuildHost(Boolean skipHostStartup, Boolean skipHostConfigurationParsing)
   at Microsoft.Azure.WebJobs.Script.WebHost.WebJobsScriptHostService.BuildHost(Boolean skipHostStartup, Boolean skipHostJsonConfiguration)
   at Microsoft.Azure.WebJobs.Script.WebHost.WebJobsScriptHostService.<UnsynchronizedStartHostAsync>d__51.MoveNext()
```
