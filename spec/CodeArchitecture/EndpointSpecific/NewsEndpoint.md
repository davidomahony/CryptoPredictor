# News Endpoint

## Classes & Interfaces

### News Controller
ILogger logger   
NewsService service   
[GetRequest]  
NewsResponse GetHistoricalCurrencyData(NewsRequest)

### News Service
IDataRepository newsRepository  
IResponseGenerator newsResponseGenerator
NewsResponse GenerateNewsReponse(request)

### News Response Generator : IResponseGenerator<NewsResonse>
IResponseConverterFactory factory

### NewsRepository : IDataRepository<NewsData>
NewsData GetData(information);

### ResponseConverterFactory : IConverter
I will think of something

### IDataRepository<T>
T GetData(info);

### IConverterFactory
IConverter GetConverter();