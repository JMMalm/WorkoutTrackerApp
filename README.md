# WorkoutTrackerApp
A desktop app for logging and analyzing workout stats using C#, Windows Forms and SQL Server.

## Built With
* Visual Studio 2015
* SQL Server 2014
* .NET 4.5
* C# 5.0

Note that there currently isn't much in the source code that would prohibit using a different version of .NET, C#, or SQL Server.

## Local Setup
1. Download the source code.
2. Build in Visual Studio.
3. Create a `connectionStrings.config` file and place in your `..\WorkoutTrackerApp\bin\Debug` folder. (see note below)
4. Run via Visual Studio or the .exe.

* This project assumes you have a local installation of SQL Server 2008 (or greater), but with some Googling you could probably configure this to work with LocalDB.

In the app.config, you'll see that the connectionStrings tag refers to another file, `connectionStrings.config`. That line is there so wrong connection strings aren't negligently committed or constantly needing to be changed between commits (i.e. you keep this file locally). The config file only needs the following:

```
<connectionStrings>
	<add name="WorkoutTracker" providerName="System.Data.ProviderName" connectionString="Your string here" />
</connectionStrings>
```