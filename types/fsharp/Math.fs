module Math

let factorial numberToCalculateFactorial =
    let mutable accumulator = numberToCalculateFactorial

    for number = numberToCalculateFactorial - 1 downto 1 do
        accumulator <- accumulator * number
    accumulator

let rec factorialWithPatternMatching number =
    match number with
    | 0 | 1 -> 1
    | 2 -> 2
    | _ -> number * factorialWithPatternMatching (number - 1)