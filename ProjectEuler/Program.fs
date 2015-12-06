open Fuchu

[<Tests>]
let problems = testList "first few problems" [
                testCase "1" <| fun _ ->
                    let multiplesOf3 = [0 .. 3 .. 999]
                    let multiplesOf5 = [0 .. 5 .. 999]
                    let actual =  Seq.append multiplesOf3 multiplesOf5 |> Seq.distinct|> Seq.sum
                    Assert.Equal("", 233168, actual)

                testCase "2" <| fun _ ->
                    // x,y -> y, x + y -> x + y, x + 2y -> x + 2y, 2x + 3y
                    let evenFibonacci =
                        let rec s i j = seq {
                                yield j
                                yield! s (i + 2*j) (2*i + 3*j)
                            }
                        s 1 2
                    let actual = evenFibonacci |> Seq.takeWhile (fun i -> i < 4000000) |> Seq.sum
                    Assert.Equal("", 4613732, actual)
                
     ]

[<EntryPoint>]
let main args = defaultMainThisAssembly args