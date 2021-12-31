# Active News Information

## Goals:
1. A consumer should be able to specify a crypto currency which they would like to retrieve the latest news stories
2. The consumer will indicate the length of time in which they would like to retrieve the data from.
3. The consumer can specify the various news outlets which should be checked for relavent stories.
4. The response should contain information detailing the article.

## Inputs

### Flow One
Information provided using a GET request.

    * The currency name (Full Name E.x Bitcoin)
    * The start date.
    * The end date.
    * A list of news aties to check

## Outputs

### Flow One
Successful Response (200)

    * The Request ID.
    * The timestamp of the request.
    * Inputted currency
    * A collection of result items:
        > Date
        > Article Title
        > Article description (optional)
        > Article URL
        > Article Source
