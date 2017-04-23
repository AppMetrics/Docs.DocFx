# Elasticsearch Reporter

Metrics can be reported to [ElasticSearch](https://www.elastic.co/) using the [ElasticSearch Reporter package](https://www.nuget.org/packages/App.Metrics.Extensions.Reporting.ElasticSearch/).

1. First see the [getting started](../getting-started/intro.md) guide.

2. Configure the Elasticsearch reporter as follows:

[!code-csharp[Main](../src/samples/App.Metrics.Extensions.Reporting.Code.Snippets/ElasticSearchReporterSetup.cs)]

### Web Monitoring

Add an index and the document mappings to Elasticsearch, there are [**default mappings**](https://raw.githubusercontent.com/alhardy/AppMetrics.Extensions.Elasticsearch/master/visualization/App.Metrics.Sandbox-Elasticsearch-IndexAndMappingSetup.json) provided in the github repository for the [**generic Grafana web dashboards**](../web-application-monitoring/visualization-grafana.md).