using Sentry;

namespace TestSentryApp;

internal static class Program
{
    public static void Main()
    {
        using var _ = SentrySdk.Init(options =>
        {
            options.Dsn = "https://7c34571a56b94abe898bbd7721ac5f0c@o1162446.ingest.sentry.io/6723856";
            options.AutoSessionTracking = true;
            options.Release = "3.0.0";
            options.Debug = true;
        });

        Foo.Bar.Baz.DoSomething();
    }
}