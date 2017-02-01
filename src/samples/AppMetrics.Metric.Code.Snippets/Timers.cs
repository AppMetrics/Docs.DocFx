// Timer Basic

var requestTimer = new TimerOptions
{
    Name = "Request Timer",
    MeasurementUnit = Unit.Requests,
    DurationUnit = TimeUnit.Milliseconds,
    RateUnit = TimeUnit.Milliseconds
};

_metrics.Measure.Timer.Time(requestTimer, () => PerformRequest());

// OR

using(_metrics.Measure.Timer.Time(requestTimer))
{
    PerformRequest();
}

// Timer Items

using(_metrics.Measure.Timer.Time(requestTimer, "feature-1"))
{
    PerformRequest();
}

// Access a Timer Instance

_metrics.Provider.Timer.Instance(httpStatusMeter).Reset();