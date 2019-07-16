module PipelineOperator

open Sum
open Multiplication

let doubleValuesFromAList() =
    let list = [0..10]
    let listWithValuesLessThan5 =
        List.filter (fun number -> number < 5) list
    List.map multiplyBy2 listWithValuesLessThan5

let doubleValuesFromListWithOperator() =
    [0..10]
    |> List.filter (fun number -> number < 5)
    |> List.map multiplyBy2

let variousOperations firstValue secondValue =
    firstValue + secondValue
    |> sumWith10
    |> sumWith2
    |> multiplyBy2

let reverseExample firstValue secondValue =
    sumWith10 <| firstValue + secondValue

let oddNumberReverseOperator value =
    let evenNumber number = number % 2 = 0
    not <| evenNumber value

let oddNumber value =
    let evenNumber number = number % 2 = 0
    evenNumber value |> not

let oddNumberWithParentheses value =
    let evenNumber number = number % 2 = 0
    not (evenNumber value)