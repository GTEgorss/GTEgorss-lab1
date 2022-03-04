namespace Fsharp

module ComputationExpression = 
    type LoggerBuilder() =
        let log arg = printfn $"new value: %d{arg}"
        
        member this.Bind(x, f) =
            log x
            f x
        
        member this.Return(x) =
            x
            
    let logger = new LoggerBuilder()
    
    let addAndMultiply x y =
        logger{
            let! z = x + y
            let! z = z * y
            return z
        }
