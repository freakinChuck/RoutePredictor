namespace RoutePredictor.Core
{
    using Microsoft.ML.Data;
    public class FlowSample
    {
        [LoadColumn(0)] public float StartKm { get; set; }
        [LoadColumn(1)] public float EndKm { get; set; }
        [LoadColumn(2)] public float AbflussM3 { get; set; }
        [LoadColumn(3)] public float TimeMin { get; set; } // Label
    } 
    public class FlowPrediction 
    { 
        [ColumnName("Score")] public float TimeMin { get; set; } 
    }

    public class DistanceOutput { public float Distance { get; set; } }
}
