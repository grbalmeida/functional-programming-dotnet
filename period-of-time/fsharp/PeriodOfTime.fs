module PeriodOfTime
open System

type Period = { InitialDate:DateTime; FinalDate:DateTime }

let addDays period days =
    {
        InitialDate = period.InitialDate.AddDays days
        ; FinalDate = period.FinalDate.AddDays days
    }

let checkIfDataIsBetweenThePeriod
    period
    (date:DateTime) =
    
    date.CompareTo period.InitialDate >= 0 &&
    date.CompareTo period.FinalDate <= 0
