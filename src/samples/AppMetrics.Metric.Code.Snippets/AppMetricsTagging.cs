var tags = new MetricTags(new[] { "client_id", "route" }, new[] { clientId, routeTemplate });
metrics.Measure.Meter.Mark(OAuthRequestMetricsRegistry.Meters.RequestRate, tags);