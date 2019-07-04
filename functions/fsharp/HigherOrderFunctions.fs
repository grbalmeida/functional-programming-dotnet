module HigherOrderFunctions

let printADoubleNumber number = printfn "%i" (number * 2)

let performActionOnElements list action =
    list |> List.iter action

let numberIsEven number = number % 2 = 0
let getEvenNumbersFromAList =
    [0..10]
    |> List.filter numberIsEven

let printNames names =
    performActionOnElements names (printfn "Hello %s")

let doubleNumbersPrinting numbers =
    performActionOnElements numbers
        (fun number -> printfn "%i" (number * 2))

let sumWithFive number = number + 5
let sumWithFiveViaLambda = fun number -> number + 5

let multiplyAndPrintNumber multiplier number =
    printfn "%i" (number * multiplier)

let printListOfNumbers multiplier numbers =
    performActionOnElements numbers
        (fun number -> multiplyAndPrintNumber multiplier number)