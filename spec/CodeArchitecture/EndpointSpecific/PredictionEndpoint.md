# Prediction Endpoint
This file details code path when requests are processed on the prediction endpoint.

## UML Diagram
![Prediction UML Flow Diagram](./PredictionFlow.png)

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

### IPredictorFactory
PredictorBase GetPredictor();

### PredictorBase
void TrainMe();
object IPredictTheseThings();

... Same as the rest