module Classes

open System

type Person (name: string, lastName:string) =
    member this.Name = name
    member this.LastName = lastName

    member this.FullName() =
        this.Name + " " + this.LastName

type PersonWithSelf (name: string, lastName: string) =
    member self.Name = name
    member self.LastName = lastName

    member this.FullName() =
        this.Name + " " + this.LastName

type PersonWithUnderscore (name: string, lastName: string) =
    member __.Name = name
    member __.LastName = lastName

    member this.FullName() =
        this.Name + " " + this.LastName

let gabriel = Person("Gabriel", "Schade")
let maria = PersonWithSelf("Maria", "Silva")
let jose = PersonWithUnderscore("Jose", "Moraes")

type PersonWithGetAndSet (name: string, lastName: string) =
    let mutable _Name = name
    let mutable _LastName = lastName

    member this.Name
        with get() = _Name
        and set value = _Name <- value
    
    member this.LastName
        with get() = _LastName
        and set value = _LastName <- value

    member this.FullName() =
        _Name + " " + _LastName

let john = PersonWithGetAndSet("John", "Kennedy")

type PersonWithAutoproperty (name: string, lastName: string) =
    member val Name = name with get, set
    member val LastName = lastName with get, set

    member this.FullName() =
        this.Name + " " + this.LastName

let vanessa = PersonWithAutoproperty("Vanessa", "Oliveira")

type PersonWithAge (age: int) =
    let mutable _Adulthood = false
    do
        _Adulthood <- age >= 18

    member val Age = age with get, set
    member val Adulthood = _Adulthood with get

let milena = PersonWithAge(10)
let august = PersonWithAge(19)

type PersonWithInheritance (name: string, lastName: string, age: int) =
    inherit PersonWithAutoproperty(name, lastName)

    let mutable _Adulthood = false

    do
        _Adulthood <- age >= 18

    member val Age = age with get, set
    member val Adulthood = _Adulthood with get

    member this.WhoIAm() =
        String.Format("My name is {0} {1} and I am {2} years old", this.Name, this.LastName, this.Age)     

let roberta = PersonWithInheritance("Roberta", "Miranda", 26)
let ronald = PersonWithInheritance("Ronald", "Reagan", 70)

type IPessoa =
    abstract member Name: string
    abstract member LastName: string
    abstract member FullName: string

type PersonWithInterface (name: string, lastName: string) =
    member val Name = name with get, set
    member val LastName = lastName with get, set

    interface IPessoa with
        member this.Name = name
        member this.LastName = lastName
        member this.FullName = sprintf "%s %s" name lastName

let gabrielWithInterface = PersonWithInterface("Gabriel", "Schade")
let fullName = (gabrielWithInterface :> IPessoa).FullName