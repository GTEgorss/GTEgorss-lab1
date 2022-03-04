using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.FSharp.Collections;
using Microsoft.FSharp.Core;

[assembly: FSharpInterfaceDataVersion(2, 0, 0)]
[assembly: AssemblyVersion("0.0.0.0")]
namespace Fsharp
{
    [CompilationMapping(SourceConstructFlags.Module)]
    public static class Pipe
    {
        [Serializable]
        internal sealed class squareAndAddOdd@13 : FSharpFunc<int, int>
        {
            internal static readonly squareAndAddOdd@13 @_instance = new squareAndAddOdd@13();

            [CompilerGenerated]
            [DebuggerNonUserCode]
            internal squareAndAddOdd@13()
            {
            }

            public override int Invoke(int x)
            {
                return x * x + 1;
            }
        }

        [Serializable]
        internal sealed class squareAndAddOdd@12-1 : FSharpFunc<int, bool>
        {
            internal static readonly squareAndAddOdd@12-1 @_instance = new squareAndAddOdd@12-1();

            [CompilerGenerated]
            [DebuggerNonUserCode]
            internal squareAndAddOdd@12-1()
            {
            }

            public override bool Invoke(int x)
            {
                return x % 2 != 0;
            }
        }

        [CompilationArgumentCounts(new int[] { 1, 1 })]
        public static int multiplication(int a, int b)
        {
            return a * b;
        }

        [CompilationArgumentCounts(new int[] { 1, 1 })]
        public static int pipemult(int a, int b)
        {
            return a * 2 * (3 * b);
        }

        public static FSharpList<int> squareAndAddOdd(FSharpList<int> values)
        {
            return ListModule.Map(squareAndAddOdd@13.@_instance, ListModule.Filter(squareAndAddOdd@12-1.@_instance, values));
        }
    }
}
namespace <StartupCode$_>
{
    internal static class $_
    {
    }
}

