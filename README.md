![logo](https://user-images.githubusercontent.com/8418700/140858271-924767d3-7b0c-492e-83ab-cfc931db466f.png)

> DryIoc is fast, small, full-featured IoC Container for .NET

### [Nuget](https://www.nuget.org/packages/DryIocExtended/)

[![Open Source Love](https://badges.frapsoft.com/os/mit/mit.svg?v=102)](https://opensource.org/licenses/MIT)
![Nuget](https://img.shields.io/nuget/v/DryIocExtended)
![Nuget](https://img.shields.io/nuget/dt/DryIocExtended)

```
Install-Package DryIocExtended

dotnet add package DryIocExtended
```


### UseDryIoc

This extension method helps you to add `DryIoc` to `HostBuilder` easily.

```cs
public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .UseDryIoc() // HERE
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}
```


<hr/>
Icon made by Freepik from www.flaticon.com is licensed by CC 3.0 BY
