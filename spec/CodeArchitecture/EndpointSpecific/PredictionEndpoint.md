# Prediction Endpoint



## Classes & Interfaces

### Prediction Controller
ILogger logger   
PredictionService service   
[GetRequest]  
PredictionDataResponse GetPredictionData(PredictionDataRequest)

### Prediction Service
IPredictorFactory predictorFactory  
IResponseGenerator PredictionResponseGenerator
PredictionDataResponse GeneratePredictionDataReponse(request)

### PredictorFactory : IPredictorFactory
Hmmm

### IPredictorFactory
PredictorBase GetPredictor();

### PredictorBase
void TrainMe();
object IPredictTheseThings();

... Same as the rest