# Basic Implementation

The basic implementation is an ASP.NET Core 2.1 application that uses the full .NET Framework and incorporates various logging frameworks.

## Create new Application

To get started, open up Visual Studio 2017 and click on File -> New Project:

### 1. Add New Project

Go to the .NET Core section and choose **ASP.NET Core Web Application**.

![](https://github.com/calloncampbell/AspNetCore-FullFramework/raw/master/screenshots/NewProject.png)

### 2. Configure WebApi

1. When configuring your new project, change the framework from **.NET Core** to **.NET Framework** as shown in the orange box
2. Then select **ASP.NET Core 2.1** or newer if available
3. Then choose the **API** template

![](https://github.com/calloncampbell/AspNetCore-FullFramework/raw/master/screenshots/ConfigureWebApi.png)

### 3. Update NuGet Packages

Go to Manage Nuget Packages for the Solution and make sure your using the latest NuGet packages for ASP.NET Core.

![](https://github.com/calloncampbell/AspNetCore-FullFramework/raw/master/screenshots/Nuget-AspNetCore.png)

### 4. Add Microsoft.Extensions.Logging

Add the following NuGet package **Microsoft.Extensions.Logging**.

![](https://github.com/calloncampbell/AspNetCore-FullFramework/raw/master/screenshots/Nuget-Microsoft.Extensions.Logging.png)

### 5. Add ReflectInsight.Extensions.Logging

Add the following NuGet package **ReflectInsight.Extensions.Logging**.

![](https://github.com/calloncampbell/AspNetCore-FullFramework/raw/master/screenshots/Nuget-ReflectInsight.Extensions.Logging.png)

## Run application

Now run the application and you should see a new tab open in your browser showing the following results from the ValuesController:

![](https://github.com/calloncampbell/AspNetCore-FullFramework/raw/master/screenshots/RunApi.png)

### View Application Logs in Real-Time with the ReflectInsight Live Viewer

Since we configured our application to use the **Microsoft.Extensions.Logging** library in conjuntion with **ReflectInsight.Extensions.Logging** library, 
we will now see all logging information in real-time in the ReflectInsight Live Viewer. This can be configured to log to a file and you can change the
logging levels that are shown.

![](https://github.com/calloncampbell/AspNetCore-FullFramework/raw/master/screenshots/ReflectInsight-Viewer.png)

## References

For more information on the **ReflectInsight** logging library and Live Log Viewer, please go to the [**ReflectInsight**](http://reflectinsight.com) website where you can download a trial and view the documentation.