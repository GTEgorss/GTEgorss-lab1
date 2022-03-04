using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.FSharp.Core;

[assembly: FSharpInterfaceDataVersion(2, 0, 0)]
[assembly: AssemblyVersion("0.0.0.0")]
namespace Fsharp
{
    [CompilationMapping(SourceConstructFlags.Module)]
    public static class DiscriminatedUnion
    {
        [Serializable]
        [StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
        [DebuggerDisplay("{__DebugDisplay(),nq}")]
        [CompilationMapping(SourceConstructFlags.SumType)]
        public abstract class intOrString : IEquatable<intOrString>, IStructuralEquatable, IComparable<intOrString>, IComparable, IStructuralComparable
        {
            public static class Tags
            {
                public const int I = 0;

                public const int S = 1;
            }

            [Serializable]
            [SpecialName]
            [DebuggerTypeProxy(typeof(I@DebugTypeProxy))]
            [DebuggerDisplay("{__DebugDisplay(),nq}")]
            public class I : intOrString
            {
                [DebuggerBrowsable(DebuggerBrowsableState.Never)]
                [CompilerGenerated]
                [DebuggerNonUserCode]
                internal readonly int item;

                [CompilationMapping(SourceConstructFlags.Field, 0, 0)]
                [CompilerGenerated]
                [DebuggerNonUserCode]
                public int Item
                {
                    [CompilerGenerated]
                    [DebuggerNonUserCode]
                    get
                    {
                        return item;
                    }
                }

                [CompilerGenerated]
                [DebuggerNonUserCode]
                internal I(int item)
                {
                    this.item = item;
                }
            }

            [Serializable]
            [SpecialName]
            [DebuggerTypeProxy(typeof(S@DebugTypeProxy))]
            [DebuggerDisplay("{__DebugDisplay(),nq}")]
            public class S : intOrString
            {
                [DebuggerBrowsable(DebuggerBrowsableState.Never)]
                [CompilerGenerated]
                [DebuggerNonUserCode]
                internal readonly string item;

                [CompilationMapping(SourceConstructFlags.Field, 1, 0)]
                [CompilerGenerated]
                [DebuggerNonUserCode]
                public string Item
                {
                    [CompilerGenerated]
                    [DebuggerNonUserCode]
                    get
                    {
                        return item;
                    }
                }

                [CompilerGenerated]
                [DebuggerNonUserCode]
                internal S(string item)
                {
                    this.item = item;
                }
            }

            [SpecialName]
            internal class I@DebugTypeProxy
            {
                [DebuggerBrowsable(DebuggerBrowsableState.Never)]
                [CompilerGenerated]
                [DebuggerNonUserCode]
                internal I _obj;

                [CompilationMapping(SourceConstructFlags.Field, 0, 0)]
                [CompilerGenerated]
                [DebuggerNonUserCode]
                public int Item
                {
                    [CompilerGenerated]
                    [DebuggerNonUserCode]
                    get
                    {
                        return _obj.item;
                    }
                }

                [CompilerGenerated]
                [DebuggerNonUserCode]
                public I@DebugTypeProxy(I obj)
                {
                    _obj = obj;
                }
            }

            [SpecialName]
            internal class S@DebugTypeProxy
            {
                [DebuggerBrowsable(DebuggerBrowsableState.Never)]
                [CompilerGenerated]
                [DebuggerNonUserCode]
                internal S _obj;

                [CompilationMapping(SourceConstructFlags.Field, 1, 0)]
                [CompilerGenerated]
                [DebuggerNonUserCode]
                public string Item
                {
                    [CompilerGenerated]
                    [DebuggerNonUserCode]
                    get
                    {
                        return _obj.item;
                    }
                }

                [CompilerGenerated]
                [DebuggerNonUserCode]
                public S@DebugTypeProxy(S obj)
                {
                    _obj = obj;
                }
            }

            [CompilerGenerated]
            [DebuggerNonUserCode]
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            public int Tag
            {
                [CompilerGenerated]
                [DebuggerNonUserCode]
                get
                {
                    return (this is S) ? 1 : 0;
                }
            }

            [CompilerGenerated]
            [DebuggerNonUserCode]
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            public bool IsI
            {
                [CompilerGenerated]
                [DebuggerNonUserCode]
                get
                {
                    return this is I;
                }
            }

            [CompilerGenerated]
            [DebuggerNonUserCode]
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            public bool IsS
            {
                [CompilerGenerated]
                [DebuggerNonUserCode]
                get
                {
                    return this is S;
                }
            }

            [CompilerGenerated]
            [DebuggerNonUserCode]
            internal intOrString()
            {
            }

            [CompilationMapping(SourceConstructFlags.UnionCase, 0)]
            public static intOrString NewI(int item)
            {
                return new I(item);
            }

            [CompilationMapping(SourceConstructFlags.UnionCase, 1)]
            public static intOrString NewS(string item)
            {
                return new S(item);
            }

            [SpecialName]
            [CompilerGenerated]
            [DebuggerNonUserCode]
            internal object __DebugDisplay()
            {
                return ExtraTopLevelOperators.PrintFormatToString(new PrintfFormat<FSharpFunc<intOrString, string>, Unit, string, string, string>("%+0.8A")).Invoke(this);
            }

            [CompilerGenerated]
            public override string ToString()
            {
                return ExtraTopLevelOperators.PrintFormatToString(new PrintfFormat<FSharpFunc<intOrString, string>, Unit, string, string, intOrString>("%+A")).Invoke(this);
            }

            [CompilerGenerated]
            public sealed override int CompareTo(intOrString obj)
            {
                if (this != null)
                {
                    if (obj != null)
                    {
                        int num = ((this is S) ? 1 : 0);
                        int num2 = ((obj is S) ? 1 : 0);
                        if (num == num2)
                        {
                            IComparer genericComparer;
                            if (this is I)
                            {
                                I i = (I)this;
                                I i2 = (I)obj;
                                genericComparer = LanguagePrimitives.GenericComparer;
                                int item = i.item;
                                int item2 = i2.item;
                                if (item < item2)
                                {
                                    return -1;
                                }
                                return (item > item2) ? 1 : 0;
                            }
                            S s = (S)this;
                            S s2 = (S)obj;
                            genericComparer = LanguagePrimitives.GenericComparer;
                            return string.CompareOrdinal(s.item, s2.item);
                        }
                        return num - num2;
                    }
                    return 1;
                }
                if (obj != null)
                {
                    return -1;
                }
                return 0;
            }

            [CompilerGenerated]
            public sealed override int CompareTo(object obj)
            {
                return CompareTo((intOrString)obj);
            }

            [CompilerGenerated]
            public sealed override int CompareTo(object obj, IComparer comp)
            {
                intOrString intOrString = (intOrString)obj;
                if (this != null)
                {
                    if ((intOrString)obj != null)
                    {
                        int num = ((this is S) ? 1 : 0);
                        intOrString intOrString2 = intOrString;
                        int num2 = ((intOrString2 is S) ? 1 : 0);
                        if (num == num2)
                        {
                            if (this is I)
                            {
                                I i = (I)this;
                                I i2 = (I)intOrString;
                                int item = i.item;
                                int item2 = i2.item;
                                if (item < item2)
                                {
                                    return -1;
                                }
                                return (item > item2) ? 1 : 0;
                            }
                            S s = (S)this;
                            S s2 = (S)intOrString;
                            return string.CompareOrdinal(s.item, s2.item);
                        }
                        return num - num2;
                    }
                    return 1;
                }
                if ((intOrString)obj != null)
                {
                    return -1;
                }
                return 0;
            }

            [CompilerGenerated]
            public sealed override int GetHashCode(IEqualityComparer comp)
            {
                if (this != null)
                {
                    int num = 0;
                    if (this is I)
                    {
                        I i = (I)this;
                        num = 0;
                        return -1640531527 + (i.item + ((num << 6) + (num >> 2)));
                    }
                    S s = (S)this;
                    num = 1;
                    string item = s.item;
                    return -1640531527 + (((item != null) ? item.GetHashCode() : 0) + ((num << 6) + (num >> 2)));
                }
                return 0;
            }

            [CompilerGenerated]
            public sealed override int GetHashCode()
            {
                return GetHashCode(LanguagePrimitives.GenericEqualityComparer);
            }

            [CompilerGenerated]
            public sealed override bool Equals(object obj, IEqualityComparer comp)
            {
                if (this != null)
                {
                    intOrString intOrString = obj as intOrString;
                    if (intOrString != null)
                    {
                        int num = ((this is S) ? 1 : 0);
                        intOrString intOrString2 = intOrString;
                        int num2 = ((intOrString2 is S) ? 1 : 0);
                        if (num == num2)
                        {
                            if (this is I)
                            {
                                I i = (I)this;
                                I i2 = (I)intOrString;
                                return i.item == i2.item;
                            }
                            S s = (S)this;
                            S s2 = (S)intOrString;
                            return string.Equals(s.item, s2.item);
                        }
                        return false;
                    }
                    return false;
                }
                return obj == null;
            }

            [CompilerGenerated]
            public sealed override bool Equals(intOrString obj)
            {
                if (this != null)
                {
                    if (obj != null)
                    {
                        int num = ((this is S) ? 1 : 0);
                        int num2 = ((obj is S) ? 1 : 0);
                        if (num == num2)
                        {
                            if (this is I)
                            {
                                I i = (I)this;
                                I i2 = (I)obj;
                                return i.item == i2.item;
                            }
                            S s = (S)this;
                            S s2 = (S)obj;
                            return string.Equals(s.item, s2.item);
                        }
                        return false;
                    }
                    return false;
                }
                return obj == null;
            }

            [CompilerGenerated]
            public sealed override bool Equals(object obj)
            {
                intOrString intOrString = obj as intOrString;
                if (intOrString != null)
                {
                    return Equals(intOrString);
                }
                return false;
            }
        }
    }
}
namespace <StartupCode$_>
{
    internal static class $_
    {
    }
}
