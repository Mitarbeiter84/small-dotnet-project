namespace SmallDotnetProject

open NUnit.Framework
open SmallDotnetProject

[<TestFixture>]
module Tests =



    [<SetUp>]
    let Setup () =
        ()

    [<Test>]
    let Test1 () =
        Assert.AreEqual("Hello Tim", (Say.hello "Tim"))
