## ElasticSearch Reporter

Metrics can be reported to [ElasticSearch](https://www.elastic.co/) using the [ElasticSearch Reporter package](https://www.nuget.org/packages/App.Metrics.Extensions.Reporting.ElasticSearch/).

[Configure a Console Application](../getting-started/intro.md#configuring-a-console-application) with App Metrics, you can then add the ElasticSearch Report Provider as below:

[!code-csharp[Main](../src/samples/App.Metrics.Extensions.Reporting.Code.Snippets/ElasticSearchReporterSetup.cs)]

See the [api documentation](../api/App.Metrics.Extensions.Reporting.ElasticSearch.ElasticSearchReporterSettings.html) on the `ElasticSearchReporterSettings` available.

TODO - ADD docs on mappings and reference file