# Price Endpoint
This file details code path when requests are processed on the price endpoint.

## UML Diagram
![Price UML Flow Diagram](./PriceUmlFlow.png)

### Price Controller
ILogger logger   
PriceService service   
[GetRequest]  
PriceHistoricalDataResponse GetHistoricalCurrencyData(PriceHistoricalDataRequest)

### Price Service
IDataRepository CoinMarketDataRepository  
IResponseGenerator PriceHistoricalDataResponseGenerator
PriceHistoricalDataResponse GeneratePriceHistoricalDataReponse(request)

### Price Historical Data Response Generator : IResponseGenerator<PriceResponse>
IResponseConverterFactory factory 

### Coin Market Data Repository : IDataRepository<T>
CoinMarketData GetData(information);

### ResponseConverterFactory : IConverter
I will think of something

### IDataRepository<T>
T GetData(info);

### IConverterFactory
IConverter GetConverter();

###  IResponseGenerator<T>
T GenerateResponse();