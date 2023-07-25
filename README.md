# Tue_DotNetConfig
THAT Conference 2023 .NET Configurations in Depth

## Order matters for config
IConfigurationSource
* JSON, EnvFiles, CmdLine
IConfigurationProvider
* Process these sources in a specific order
IConfigurationBuilder
* builds one object
IConfiguration
* This is what you use in code

## Types of IOptions
Singleton/HotReloading/NamedOptionSupport

IOptions
*Y/N/N
IOptionsSnapshot
*N/Y/Y
IOptionsMonitor
*Y/Y/Y

There is the ability to validate Configuration values using annotations.
*ValidateAnnotations
*ValidataeOnStart

There is also the ability to call "PostConfigure" to actually edit the config.
