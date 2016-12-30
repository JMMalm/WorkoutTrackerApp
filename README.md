# WorkoutTrackerApp
A desktop app for logging and analyzing workout stats using C#, Windows Forms and SQL Server.

## Built With
* Visual Studio 2015
* SQL Server 2014
* .NET 4.5
* C# 5.0

Note that there currently isn't much in the source code that would prohibit using a slightly older (or newer) version of .NET, C#, or SQL Server.

## Local Setup
1. Download the source code.
2. Build in Visual Studio.
3. Create a `connectionStrings.config` file and place in your `..\WorkoutTrackerApp\bin\Debug` folder. (see note below)
4. Run via Visual Studio or the .exe.

In the app.config, you'll see that the connectionStrings tag refers to another file, `connectionStrings.config`. That line is there so I don't negligently commit the wrong connection string or constantly have to change it between commits. The config file only needs the following:

```
<connectionStrings>
	<add name="WorkoutTracker" providerName="System.Data.ProviderName" connectionString="Your string here" />
</connectionStrings>
```

## Other Info
This project is being developed in my free time for my own enjoyment and to enhance my skills. To that end, I'm not seeking contributors but if you have questions or comments feel free to send me an email.