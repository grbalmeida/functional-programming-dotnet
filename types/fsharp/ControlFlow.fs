module ControlFlow

let verifyIfNumberIsEven number =
    if number % 2 = 0
        then "Even"
        else "Odd"

let verifyIfNumberIsEvenWithPatternMatching number =
    match number % 2 = 0 with
    | true -> "Even"
    | false -> "Odd"

let verifyIfNumberIsEvenOrZero number =
    if number % 2 = 0
        then
            if number = 0
                then "Zero"
                else "Even"        
        else "Odd"

let verifyIfNumberIsEvenOrZeroWithPatternMatching number =
    match number with
    | 0 -> "Zero"
    | number when number % 2 = 0 -> "Even"
    | _ -> "Odd"