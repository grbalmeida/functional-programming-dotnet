module UnitsOfMeasurement

[<Measure>] type Gram
[<Measure>] type Kilo
[<Measure>] type Ton

let firstWeight = 500<Gram>
let secondWeight = 10<Kilo>
let thirdWeight = 1<Ton>

[<Measure>] type Kilometer
[<Measure>] type Meter
[<Measure>] type Hour
[<Measure>] type Second

let carSpeed = 130<Kilometer/Hour>
let speedOfSound = 340.29<Meter/Second>

[<Measure>] type FirstVelocity = Kilometer/Hour
[<Measure>] type SecondVelocity = Meter/Second

let kilometers = 100.0<Kilometer>
let meters = 1000.0<Meter>

let conversionFactorKilometerPerMeter = 0.001<Kilometer/Meter>
let metersConverted = meters * conversionFactorKilometerPerMeter

let sumMeasure = kilometers + metersConverted