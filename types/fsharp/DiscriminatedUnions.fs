module DiscriminatedUnions

type IntOrBool =
    | Integer of int
    | Bool of bool

type Person = {
    Name: string;
    Age: int
}

type DiscriminatedComplex =
    | IntOrBool of IntOrBool
    | Person of Person
    | Tuple of int * string

type Result =
    | Success
    | Error of string list

type UserResponse =
    | Yes
    | Not

type Color =
    | Red
    | Green
    | Blue

let successResult = Success
let errorResult = Error["Invalid"]

type CustomerIdentifier = int
type Name = string
type LastName = string

type Customer = {
    Id: CustomerIdentifier;
    Name: Name;
    LastName: LastName
}

let createCustomer id name lastName = {
    Id = id;
    Name = name;
    LastName = lastName
}

let createOtherCustomer id (name:Name) (lastName:LastName) = {
    Id = id;
    Name = name;
    LastName = lastName;
}

let id = 1
let name = "Gabriel"
let lastName = "Schade"

let firstCustomer = createCustomer id name lastName
let secondCustomer = createOtherCustomer id name lastName