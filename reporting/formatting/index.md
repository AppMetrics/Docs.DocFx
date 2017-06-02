# Metrics formatting for reporting

You'll find a formatting package in each of the TSDB specific reporting extensions as well as some custom formatting packages included in App Metrics such as [App.Metrics.Formatters.Ascii](https://www.nuget.org/packages/App.Metrics.Formatters.Ascii/) & [App.Metrics.Formatters.Json](https://www.nuget.org/packages/App.Metrics.Formatters.Json/). These allow us to serialize metrics in the desired format and work with the more generic reporters provided by App Metrics such as the Text File, Console and HTTP Reporters.

## Implementing custom metric formatting

To implement custom metric formatting, you can create an implementation of `IMetricPayloadBuilder<TPayload>` and then use it on any of the reporters. For example:

[!code-csharp[Main](../../src/samples/App.Metrics.Formatting.Samples/CustomFormatter.cs?highlight=9)]