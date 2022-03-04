namespace Fsharp

module Pipe =
    let multiplication a b = a * b

    let pipemult a b =
        (2 |> multiplication a, multiplication <|| (3, b))
        ||> multiplication

    let squareAndAddOdd values =
        values
        |> List.filter (fun x -> x % 2 <> 0)
        |> List.map (fun x -> x * x + 1)
