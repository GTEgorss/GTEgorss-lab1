using System;
using System.Collections.Generic;
using Fsharp;
using Microsoft.FSharp.Collections;

List<int> list = new() {1, 2, 3, 4, 5};
FSharpList<int> fSharpList = ListModule.OfSeq(list);
Console.WriteLine(Pipe.squareAndAddOdd(fSharpList));

Console.WriteLine();

DiscriminatedUnion.intOrString intOrString = DiscriminatedUnion.intOrString.NewS("JNNKASKNDA");
Console.WriteLine(intOrString);
intOrString = DiscriminatedUnion.intOrString.NewI(1);
Console.WriteLine(intOrString);

Console.WriteLine();

Console.WriteLine(ComputationExpression.addAndMultiply(2, 3));
