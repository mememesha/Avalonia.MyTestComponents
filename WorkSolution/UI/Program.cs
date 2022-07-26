﻿using System;
using Avalonia;
using Avalonia.ReactiveUI;
using Projektanker.Icons.Avalonia;
using Projektanker.Icons.Avalonia.FontAwesome;
using Serilog;
using Serilog.Enrichers;
using Splat;
using VEGASTAR.DI;

namespace VEGASTAR;

internal class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        try
        {
            BuildAvaloniaApp()
                .StartWithClassicDesktopLifetime(args);
        }
        catch (Exception e)
        {
            Log.Fatal(e, "Что-то пошло не так...");
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }

    public static AppBuilder BuildAvaloniaApp()
    {
        ConfigureLogger();

        Bootstrapper.Register(Locator.CurrentMutable, Locator.Current);

        return AppBuilder.Configure<App>()
            .UseReactiveUI()
            .UseAvaloniaNative()
            .UsePlatformDetect()
            .LogToTrace()
            .WithIcons(container => container
                .Register<FontAwesomeIconProvider>());
    }

    public static void ConfigureLogger()
    {
        Log.Logger = new LoggerConfiguration()
            .Enrich.With(new ThreadIdEnricher())
            .Enrich.WithMemoryUsage()
            .MinimumLevel.Information()
            .WriteTo.File("Logs/log-.txt",
                rollingInterval: RollingInterval.Day,
                retainedFileCountLimit: 31,
                outputTemplate:
                "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] ({ThreadId}) {Message:lj}{NewLine}{Exception} {MemoryUsage}")
            .CreateLogger();
    }
}