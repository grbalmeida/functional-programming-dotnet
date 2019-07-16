﻿open Sum
open Subtraction
open Multiplication
open PipelineOperator

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

    printfn "%A" (doubleValuesFromAList())
    printfn "%A" (doubleValuesFromListWithOperator())

    printfn "%i" (variousOperations 2 3)
    printfn "%i" (variousOperations 3 7)
    printfn "%i" (variousOperations 10 20)

    printfn "%i" (reverseExample 2 3)

    printfn "%b" (oddNumberReverseOperator 10)
    printfn "%b" (oddNumberReverseOperator 5)

    printfn "%b" (oddNumber 10)
    printfn "%b" (oddNumber 5)

    printfn "%b" (oddNumberWithParentheses 10)
    printfn "%b" (oddNumberWithParentheses 5)
    0
