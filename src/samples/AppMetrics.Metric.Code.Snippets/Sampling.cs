 services
    .AddMetrics()    
    // Uniform Reservoir Sampling
    .AddDefaultReservoir(() => new Lazy<IReservoir>(() => new DefaultAlgorithmRReservoir(sampleSize: 1028)))
    // Or, Exponentially Decaying Reservoir Sampling
    .AddDefaultReservoir(() => new Lazy<IReservoir>(() => new DefaultForwardDecayingReservoir(sampleSize: 1028, alpha: 0.015)))
    // Or, Sliding Window Reservoir Sampling
    .AddDefaultReservoir(() => new Lazy<IReservoir>(() => new DefaultSlidingWindowReservoir(sampleSize: 1028)))
    .AddHealthChecks();

  public static readonly HistogramOptions PostRequestSizeHistogram = new HistogramOptions
                                                                    {
                                                                        Context = ContextName,
                                                                        Name = "POST Size",
                                                                        MeasurementUnit = Unit.Bytes,
                                                                        Reservoir = new Lazy<IReservoir>(() => new DefaultSlidingWindowReservoir(sampleSize: 1028))                                                                        
                                                                    };