module Tests

open NUnit.Framework
open SmallDotnetProject


[<SetUp>]
let Setup () =
    ()

[<Test>]
let Test1 () =
    Assert.AreEqual("Hello Tim", (Say.hello "Tim"))
