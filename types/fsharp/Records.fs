module Records

type IntAndBool = {
    integerValue: int;
    booleanValue: bool
}

let intAndBool = { integerValue = 2; booleanValue = true }

let { integerValue = integer ; booleanValue = bool } = intAndBool