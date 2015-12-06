open Fuchu

[<Tests>]
let problems = testList "first few problems" [
                testCase "1" <| fun _ ->
                    let multiplesOf3 = [0 .. 3 .. 999]
                    let multiplesOf5 = [0 .. 5 .. 999]
                    let actual =  Seq.append multiplesOf3 multiplesOf5 |> Seq.distinct|> Seq.sum
                    Assert.Equal("", 233168, actual)
     ]

[<EntryPoint>]
let main args = defaultMainThisAssembly args