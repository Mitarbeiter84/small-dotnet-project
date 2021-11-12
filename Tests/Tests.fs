namespace SmallDotnetProject

open System
open Xunit

module Tests =

    [<Fact>]
    let Test1 () =
        Assert.Equal("Hello Tim", (Say.hello "Tim"))
