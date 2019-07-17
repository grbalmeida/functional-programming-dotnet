open ControlFlow
open Math
open Tuples

[<EntryPoint>]
let main argv =
    printfn "%s" (verifyIfNumberIsEven 10)
    printfn "%s" (verifyIfNumberIsEven 5)
    printfn "%s" (verifyIfNumberIsEvenWithPatternMatching 10)
    printfn "%s" (verifyIfNumberIsEvenWithPatternMatching 5)

    printfn "%s" (verifyIfNumberIsEvenOrZero 3)
    printfn "%s" (verifyIfNumberIsEvenOrZero 0)
    printfn "%s" (verifyIfNumberIsEvenOrZero 2)

    printfn "%s" (verifyIfNumberIsEvenOrZeroWithPatternMatching 3)
    printfn "%s" (verifyIfNumberIsEvenOrZeroWithPatternMatching 0)
    printfn "%s" (verifyIfNumberIsEvenOrZeroWithPatternMatching 2)

    printfn "%i" (factorial 2)
    printfn "%i" (factorial 3)
    printfn "%i" (factorial 4)

    printfn "%i" (factorialWithPatternMatching 2)
    printfn "%i" (factorialWithPatternMatching 3)
    printfn "%i" (factorialWithPatternMatching 4)

    printfn "%i" (sum 10 20)
    0
