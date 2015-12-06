open Fuchu

[<Tests>]
let problems = testList "first few problems" [
                testCase "1" <| fun _ ->
                    let takeFirst1000 = Seq.takeWhile (fun x -> x < 1000)
                    let multiplesOf3 = Seq.initInfinite ( fun i -> i * 3) |> takeFirst1000
                    let multiplesOf5 = Seq.initInfinite ( fun i -> i * 5) |> takeFirst1000
                    let actual =  Seq.append multiplesOf3 multiplesOf5 |> Seq.distinct|> Seq.sum
                    Assert.Equal("", 233168, actual)
     ]

[<EntryPoint>]
let main args = defaultMainThisAssembly args