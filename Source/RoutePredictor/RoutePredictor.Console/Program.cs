// See https://aka.ms/new-console-template for more information
using RoutePredictor.Core;

Console.WriteLine("Hello, World!");


Console.Write("Enter StartKM: ");
var startKm = float.Parse(Console.ReadLine()!);
Console.Write("Enter EndKM: ");
var endKM = float.Parse(Console.ReadLine()!);

Console.Write("Enter AbflussM3: ");
var abflussM3 = float.Parse(Console.ReadLine()!);

Console.WriteLine();
Console.WriteLine();

var predictor = new FlowPredictor();
var prediction = predictor.PredictTime(startKm, endKM, abflussM3);

Console.WriteLine($"Prediction Time: {prediction.ToString("n2")} min");



