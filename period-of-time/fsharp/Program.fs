open PeriodOfTime
open System

let a = 10
let b = 20 + 3
let c = 5 + a + b
let result = a + b - c

let exampleUseOfExpression number =
    let result =
        if number % 2 = 0 then 2 else 0
    printfn "%i" result

[<EntryPoint>]
let main argv =
    let period =
        { InitialDate = DateTime.Parse "20/08/2016"
        ; FinalDate = DateTime.Parse "31/08/2016" }

    let dates =
        [|
            DateTime.Parse "18/08/2016"
            DateTime.Parse "22/08/2016"
            DateTime.Parse "01/09/2016"
        |]

    for date in dates do
        let dateIsInThePeriod = checkIfDataIsBetweenThePeriod period date
        printfn "%b" dateIsInThePeriod

    exampleUseOfExpression 20
    exampleUseOfExpression 15
    0
