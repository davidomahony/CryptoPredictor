# Twitter Endpoint
This file details code path when requests are processed on the Twitter endpoint.

## UML Diagram
![Twitter UML Flow Diagram](./TwitterUmlFlow.png)


## Classes & Interfaces

### Twitter Controller
ILogger logger   
TwitterService service   
[GetRequest]  
TwitterDataResponse GetTwitterData(TwitterRequest)

### Twitter Service
IDataRepository TwitterDataRepository  
IResponseGenerator TwitterResponseGenerator
TwitterDataResponse GenerateTwitterDataReponse(request)

### Twitter Data Repository : IDataRepository
ITwitterRepositoryProvider repoProvider
 > The factory is used to find the right repositoy to use. So it effectively has a DataRepository within another

### ITwitterRepositoryProvider
IDataRepository GetReposirotyProvider()

### ResponseConverterFactory : IConverter
I will think of something

### IDataRepository<T>
T GetData(info);

### IConverterFactory
IConverter GetConverter();

###  IResponseGenerator<T>
T GenerateResponse();
