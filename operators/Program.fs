open Sum
open Subtraction
open Multiplication

[<EntryPoint>]
let main argv =
    printfn "%i" (sumWith3 10)
    printfn "%i" (sumWith3Operator 5)
    printfn "%i" (sumWith 5 10)
    printfn "%i" (sumWith10 20)
    printfn "%i" (sumWith2 30)

    printfn "%i" (subtract3 10)
    printfn "%i" (subtract5 10)

    printfn "%i" (multiplyBy10 2)
    printfn "%i" (multiplyBy4 8)
    0
