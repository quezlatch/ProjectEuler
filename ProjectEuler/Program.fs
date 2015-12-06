open Fuchu

[<Tests>]
let problems = testList "first few problems" [
                testCase "1" <| fun _ ->
                    let actual = [1..999] |> Seq.where (fun x -> x % 3 =0 || x % 5 = 0) |> Seq.sum
                    Assert.Equal("", 233168, actual)
     ]

[<EntryPoint>]
let main args = defaultMainThisAssembly args

