let raiseNumberSquared myNumber = myNumber * myNumber

let sumOfSquaresOfNumbersUpToTen =
    [1..10]
    |> List.map raiseNumberSquared
    |> List.sum

[<EntryPoint>]
let main argv =
    0
