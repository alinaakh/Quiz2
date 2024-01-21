namespace CS220.Quiz1

open System
open Microsoft.VisualStudio.TestTools.UnitTesting

[<TestClass>]
type TestClass () =

  [<TestMethod; TestCategory "1">]
  member _.``Test1`` () =
    let result = Math.collatz 9
    Assert.AreEqual (19, result)

  [<TestMethod; TestCategory "2">]
  member _.``Test2`` () =
    let result = Math.collatz 27
    Assert.AreEqual (111, result)

  [<TestMethod; TestCategory "3">]
  member _.``Test3`` () =
    let result = Math.collatz 871
    Assert.AreEqual (178, result)

  [<TestMethod; TestCategory "4">]
  member _.``Test4`` () =
    let result = Math.collatz 6171
    Assert.AreEqual (261, result)

  [<TestMethod; TestCategory "5">]
  member _.``Test5`` () =
    let result = Math.collatz 670617279
    Assert.AreEqual (986, result)
