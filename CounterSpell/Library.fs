namespace CounterSpell

module Say =
    let hello name =
        printfn "Hello %s" name

    let sample foo = 
        let strings = [| foo; "one"; "two"; "three" |]
        System.String.Concat(strings)