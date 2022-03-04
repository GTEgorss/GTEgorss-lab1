using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using <StartupCode$_>;
using Fsharp;
using Microsoft.FSharp.Core;

[assembly: FSharpInterfaceDataVersion(2, 0, 0)]
[assembly: AssemblyVersion("0.0.0.0")]
namespace Fsharp
{
    [CompilationMapping(SourceConstructFlags.Module)]
    public static class ComputationExpression
    {
        [Serializable]
        [CompilationMapping(SourceConstructFlags.ObjectType)]
        public class LoggerBuilder
        {
            public b Bind<b>(int x, FSharpFunc<int, b> f)
            {
                log(x);
                return f.Invoke(x);
            }

            public a Return<a>(a x)
            {
                return x;
            }

            [CompilerGenerated]
            internal void log(int arg)
            {
                object[] array = new object[1];
                array[0] = arg;
                PrintfFormat<Unit, TextWriter, Unit, Unit> format = new PrintfFormat<Unit, TextWriter, Unit, Unit, int>("new value: %d%P()", array, null);
                PrintfModule.PrintFormatLineToTextWriter(Console.Out, format);
            }
        }

        [CompilationMapping(SourceConstructFlags.Value)]
        public static LoggerBuilder logger
        {
            get
            {
                return $_.logger@14;
            }
        }

        [CompilerGenerated]
        internal static int f@7(int y, int z)
        {
            int num = z * y;
            logger.log(num);
            return num;
        }

        [CompilationArgumentCounts(new int[] { 1, 1 })]
        public static int addAndMultiply(int x, int y)
        {
            int num = x + y;
            logger.log(num);
            return f@7(y, num);
        }
    }
}
namespace <StartupCode$_>
{
    internal static class $_
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal static readonly ComputationExpression.LoggerBuilder logger@14;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        [DebuggerNonUserCode]
        internal static int init@;

        static $_()
        {
            logger@14 = new ComputationExpression.LoggerBuilder();
        }
    }
}

