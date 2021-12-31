# Active Price Data

## Goals:
1. A consumer should be able to specify a crypto currency which they would like to retrieve active price data for.
2. The results should be returned to the user with a specific timestamp indicating the price at that specific time (UTC).
3. The consumer will indicate the currency the value should be returned in (E.x EUR, USD)

## Inputs

### Flow One
Information provided using a GET request.

    * The currency name (Full Name E.x Bitcoin)
    * The returned currency (EUR)

## Outputs

### Flow One
Successful Response (200)

    * The Request ID.
    * The timestamp of the request.
    * A result item:
        > Inputted currency
        > Date
        > Active Price
        > Returned currency
