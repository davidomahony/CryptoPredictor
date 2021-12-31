# Historical Price Data

## Goals:
1. A consumer should be able to specify a crypto currency which they would like to retrieve historical data results.
2. The consumer will indicate the length of time in which they would like to retrieve the data from.
3. The results should be returned to the user with a specific timestamp indicating the price at that specific time (UTC).
4. The consumer will indicate the currency the value should be returned in (E.x EUR, USD)
5. A meaningful limit should be identified to prevent excess results being returned which could cause issues. (What issues?)

## Inputs

### Flow One
Information provided using a GET request.

    * The currency name (Full Name E.x Bitcoin)
    * Returned currency.
    * The start date.
    * The end date.

## Outputs

### Flow One
Successful Response (200)

    * The Request ID.
    * The timestamp of the request.
    * Returned currency.
    * A collection of result objects:
        > Date
        > Daily High
        > Daily Low
