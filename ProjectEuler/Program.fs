open Fuchu

[<Tests>]
let problems = testList "first few problems" [
                testCase "1" <| fun _ ->
                    let multiplesOf3 = [0 .. 3 .. 999]
                    let multiplesOf5 = [0 .. 5 .. 999]
                    let actual =  Seq.append multiplesOf3 multiplesOf5 |> Seq.distinct|> Seq.sum
                    Assert.Equal("", 233168, actual)

                testCase "2" <| fun _ ->
                    let fibonacci =
                        let rec s i j = seq {
                                yield j
                                yield! s j (i + j)
                            }
                        s 1 1
                    let actual = fibonacci |> Seq.take 6 |> Seq.toList
                    Assert.Equal("",[1; 2; 3; 5; 8; 13], actual)
                
     ]

[<EntryPoint>]
let main args = defaultMainThisAssembly args