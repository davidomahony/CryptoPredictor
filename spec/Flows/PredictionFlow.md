# Twitter Traction Data

## Goals:
1. A consumer should be able to specify a crypto currency which they would like to retrieve a prediction for a future price.
2. The consumer will indicate the length of time in which they would like to get a prediction for. (With a limit of up to 2 months)
3. The results should be returned to the user with a specific timestamp.
4. The user should be allowed to specify a certain ML algorithm to generate a prediction.
6. A user should be able to specify a lengh of time which allows the algorithm to train
5. A meaningful limit should be identified to prevent excess results being returned which could cause issues. (What issues?)

### Flow One
Information provided using a GET request.

    * The currency name (Full Name E.x Bitcoin)
    * The returned currency (EUR)
    * ML Algorithm
    * Train - Start Date, End Date
    * Predicted Time Frame (Single day or month)

## Outputs

### Flow One
Successful Response (200)

    * The currency name (Full Name E.x Bitcoin)
    * The returned currency (EUR)
    * ML Algorithm
    * Train - Start Date, End Date
    * Results of prediction
        > Timestamp
        > Value