module ComposingFunctions

open Sum
open PipelineOperator

let convertBooleanToText value =
    if value
        then "Yes"
        else "No"

let verifyIfNumbersIsOdd value =
    let result = oddNumber value
    convertBooleanToText result

let compose firstFunction secondFunction parameter =
    secondFunction (firstFunction (parameter) )

let verifyIfNumberIsOddUsingCompose =
    compose oddNumber convertBooleanToText

let sumWith3AndVerifyIfNumberIsOddUsingTheCompose =
    compose sumWith3
        (compose oddNumber convertBooleanToText)

let verifyIfNumberIsOddUsingOperator =
    oddNumber >> convertBooleanToText

let sumWith3AndVerifyIfNumberIsOddUsingOperator =
    sumWith3 >> oddNumber >> convertBooleanToText