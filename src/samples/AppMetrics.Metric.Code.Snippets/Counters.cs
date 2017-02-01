// Counter Basic

var sentEmailsCounter = new CounterOptions
{
    Name = "Sent Emails",
    MeasurementUnit = Unit.Calls
};

_metrics.Measure.Counter.Increment(sentEmailsCounter); // Increment by 1 
_metrics.Measure.Counter.Decrement(sentEmailsCounter); // Decrement by 1
_metrics.Measure.Counter.Increment(sentEmailsCounter, 10); // Increment by 10
_metrics.Measure.Counter.Decrement(sentEmailsCounter, 10); // Decrement by 10

// Counter Items

var sentEmailsCounter = new CounterOptions
{
    Name = "Sent Emails",
    MeasurementUnit = Unit.Calls
};

_metrics.Measure.Counter.Increment(sentEmailsCounter, "email-a-friend");
_metrics.Measure.Counter.Increment(sentEmailsCounter, "forgot-password");
_metrics.Measure.Counter.Increment(sentEmailsCounter, "account-verification");

// Access a Counter intance

_metrics.Provider.Counter.Instance(sentEmailsCounter).Reset();