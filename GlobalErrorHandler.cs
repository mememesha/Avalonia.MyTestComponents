using System;
using System.Diagnostics;
using System.Reactive.Concurrency;
using ReactiveUI;
using Splat;

namespace VEGASTAR;

public class GlobalErrorHandler : IObserver<Exception>, IEnableLogger
{
    public void OnNext(Exception value)
    {
        if (Debugger.IsAttached) Debugger.Break();

        RxApp.MainThreadScheduler.Schedule(() =>
        {
            var errorType = value.GetType();
            var message = value.Message;
            this.Log().Fatal(value, $"{errorType}: {message}");
        });
    }

    public void OnError(Exception error)
    {
        if (Debugger.IsAttached) Debugger.Break();

        RxApp.MainThreadScheduler.Schedule(() =>
        {
            var errorType = error.GetType();
            var message = error.Message;
            this.Log().Fatal(error, $"{errorType}: {message}");
        });
    }

    public void OnCompleted()
    {
        if (Debugger.IsAttached) Debugger.Break();
        RxApp.MainThreadScheduler.Schedule(() => { });
    }
}