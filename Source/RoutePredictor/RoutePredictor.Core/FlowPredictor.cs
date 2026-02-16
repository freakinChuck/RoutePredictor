using Microsoft.ML;
using RoutePredictor_Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RoutePredictor.Core
{
    public  class FlowPredictor
    {
        public FlowPredictor() 
        {
            
        }

        public float PredictTime(float startKm, float endKm, float abflussM3)
        {
            var inputData = new SpeedRegressionModel.ModelInput()
            {
                StartKm = startKm,
                EndKm = endKm,
                AbflussM3 = abflussM3,
            };

            var prediction = SpeedRegressionModel.Predict(inputData);

            return prediction.Score;
        }

        public void TrainModel(string newDataPath)
        {
            var ml = new MLContext(seed: 0);

            var data = ml.Data.LoadFromTextFile<FlowSample>(newDataPath, hasHeader: true, separatorChar: ',');
            SpeedRegressionModel.RetrainModel(ml, data);
        }
    }
}
