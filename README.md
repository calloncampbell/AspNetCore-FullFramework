# Sample projects for ASP.NET with .NET Framework

## Basic Requirements
- Visual Studion 2017 (v15.8.x)
- ASP.NET Core v2.1.x
- .NET Framework v4.6.1
- Microsoft.Extensions.Logging v2.1.x
- ReflectInsight.Extensions.Logging v2.1.x

## Basic Implementation

The basic implementation just gets you started with creating a simple ASP.NET Core app that targets the full .NET Framework and uses both the Microsoft and ReflectInsight logging extensions.

## Complete Implementation

The complete implementation builds upon the basic and leverage dependency injection and configures the API based upon best practices and makes it ready for production use cases.

## Logging Output

In these samples I'm using a logging framework known as [**ReflectInsight**](http://reflectinsight.com) which is a product I'm involved with. 

By leveraging the **ReflectInsight.Extensions.Logging** library, I'm able to tap into the logging data that is produced from the **Microsoft.Extensions.Logging** framework, and I'm able to use any native ReflectInsight log message type. All this will show up in real-time in the ReflectInsight Live Log Viewer as shown below.

![](https://github.com/calloncampbell/AspNetCore-FullFramework/raw/master/screenshots/ReflectInsight-Viewer.png)

## References

[Logging in ASP.NET Core](https://docs.microsoft.com/en-ca/aspnet/core/fundamentals/logging/?view=aspnetcore-2.1#how-to-create-logs)

[ReflectInsight](http://reflectinsight.com)