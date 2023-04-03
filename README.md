# System.Diagnostics.DiagnosticSource 7.0.0 w/ Azure Functions (in-process)

When running an Azure Function that depends on System.Diagnostics.DiagnosticSource 7.0.0
you may see the following error:

```text
Azure Functions Core Tools
Core Tools Version:       4.0.3971 Commit hash: d0775d487c93ebd49e9c1166d5c3c01f3c76eaaf  (64-bit)
Function Runtime Version: 4.0.1.16815

[2022-12-01T22:30:58.048Z] Found C:\Users\Alan\github\alanwest\azure-function-diagnostic-source\MyFunctions.csproj. Using for user secrets file configuration.

Functions:

        Function1: [GET,POST] http://localhost:7071/api/Function1

For detailed output, run func with --verbose flag.
[2022-12-01T22:31:07.289Z] Host lock lease acquired by instance ID '0000000000000000000000001EC35807'.
[2022-12-01T22:31:12.954Z] Executing 'Function1' (Reason='This function was programmatically called via the host APIs.', Id=adcd6693-6dcc-47a4-b1a7-a3411b41f115)
[2022-12-01T22:31:13.116Z] Executed 'Function1' (Failed, Id=adcd6693-6dcc-47a4-b1a7-a3411b41f115, Duration=196ms)
[2022-12-01T22:31:13.120Z] System.Private.CoreLib: Exception while executing function: Function1. MyFunctions: Could not load file or assembly 'System.Diagnostics.DiagnosticSource, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'. The system cannot find the file specified.
```

The following is added to MyFunctions.csproj to get around this error.

```xml
<ItemGroup>
  <FunctionsPreservedDependencies Include="System.Diagnostics.DiagnosticSource.dll" />
</ItemGroup>
```
