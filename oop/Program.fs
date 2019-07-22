open System
open Classes

[<EntryPoint>]
let main argv =
    Console.WriteLine(gabriel.FullName())
    Console.WriteLine(maria.FullName())
    Console.WriteLine(jose.FullName())

    Console.WriteLine(john.FullName())
    john.LastName <- "Wick"
    Console.WriteLine(john.FullName())

    Console.WriteLine(vanessa.FullName())

    Console.WriteLine(milena.Adulthood)
    Console.WriteLine(milena.Age)
    Console.WriteLine(august.Adulthood)
    Console.WriteLine(august.Age)

    Console.WriteLine(roberta.WhoIAm())
    Console.WriteLine(ronald.WhoIAm())

    Console.WriteLine(fullName)
    0
