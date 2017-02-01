// Meter Basic

var cacheHitsMeter = new MeterOptions
{
    Name = "Cache Hits",
    MeasurementUnit = Unit.Calls
};

_metrics.Measure.Meter.Mark(cacheHitsMeter); 
_metrics.Measure.Meter.Mark(cacheHitsMeter, 10);

// Meter Items

var httpStatusMeter = new MeterOptions
{
    Name = "Http Status",
    MeasurementUnit = Unit.Calls
};

_metrics.Measure.Meter.Mark(httpStatusMeter, "200");
_metrics.Measure.Meter.Mark(httpStatusMeter, "500");
_metrics.Measure.Meter.Mark(httpStatusMeter, "401");

// Access a Meter Instance

_metrics.Provider.Meter.Instance(httpStatusMeter).Reset();