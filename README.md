# AxataPOS.LogReader

Read and view log logged by NLog or another frameworks.

The format of the logs is in this json format:

```json
{
  "time": "DateTime",
  "level": "string",
  "logger": "string",
  "message": "string",
  "exception": "string"
}
```

if you use NLog, please configure the Nlog.config like this:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<nlog xmlns="http://www.nlog-project.org/schemas/NLog.xsd"
      xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">

	<targets>
		<target xsi:type="File" name="logfile" fileName="${specialfolder:folder=LocalApplicationData}/[your-target-folder]/logfile-axata.json"
                archiveFileName="${specialfolder:folder=LocalApplicationData}/[your-target-folder]/archives/logfile-{#}.json"
                archiveAboveSize="5242880">
			<layout xsi:type="JsonLayout">
				<attribute name="time" layout="${longdate}"/>
				<attribute name="level" layout="${level}"/>
				<attribute name="logger" layout="${logger}"/>
				<attribute name="message" layout="${message}"/>
				<attribute name="exception" layout="${exception:format=ToString,Data:maxInnerExceptionLevel=10}"/>
			</layout>
		</target>
		<target name="logconsole" xsi:type="Console" />
	</targets>

	<rules>
		<logger name="*" minlevel="Info" writeTo="logconsole" />
		<logger name="*" minlevel="Error" writeTo="logfile" />
	</rules>
</nlog>
```

*Don't forget to change your specific logs specification.*