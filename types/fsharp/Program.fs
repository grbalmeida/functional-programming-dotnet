open ControlFlow

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
    0
