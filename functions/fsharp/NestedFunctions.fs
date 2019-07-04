module NestedFunctions

let printIfNumberIsEvenOrOdd number =
    let verifyIfNumberIsEven = number % 2 = 0
    let printEvenNumber() = printfn "The number %i is even" number
    let printOddNumber() = printfn "The number %i is odd" number
    
    if verifyIfNumberIsEven then
        printEvenNumber()
    else
        printOddNumber()