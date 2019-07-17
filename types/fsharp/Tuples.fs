module Tuples

let intAndBool = 2, true
let otherInAndBool = -1, false
let firstTuple = 1, 2, 3
let secondTuple = 1, true, "Gabriel"
let thirdTuple = 3, false
let fourthTuple = 1, 2, 3, false, "Test"

let sum firstNumber secondNumber =
    firstNumber + secondNumber

let sumTuple (firstNumber, secondNumber) =
    firstNumber + secondNumber

let item1, item2, item3 = firstTuple