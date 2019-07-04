open NestedFunctions
open WriteFunctions
open NumberWritingFunctions
open HigherOrderFunctions

[<EntryPoint>]
let main argv =
    printIfNumberIsEvenOrOdd 10
    printIfNumberIsEvenOrOdd 5
    
    write "Maria"
    write "John"

    writeAge 20
    writeAge 25

    for number in getEvenNumbersFromAList do
        printfn "%i" number

    printADoubleNumber 3
    printNames ["Gabriel"; "John"; "Jose"; "Maria"]
    doubleNumbersPrinting [3; 5; 7]
    printfn "%i" (sumWithFive 10)
    printfn "%i" (sumWithFiveViaLambda 25)
    printListOfNumbers 10 [1; 2; 3]
    0
