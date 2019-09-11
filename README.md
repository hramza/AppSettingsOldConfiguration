# AppSettingsOldConfiguration for .NET CORE projects

Read AppSettings section of a web.config file.

How to use it:
In Program.cs file, add:

```
  WebHost.CreateDefaultBuilder(args)
         .ConfigureAppConfiguration(cfg =>
         {
           cfg.Sources.Clear();
		   
           cfg.AddAppSettingsFromWebConfig();
         })
         .UseStartup<Startup>()
         .Build();

```