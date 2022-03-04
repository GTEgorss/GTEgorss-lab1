namespace Fsharp

module DiscriminatedUnion =
    type intOrString =
        | I of int
        | S of string
