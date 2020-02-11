module CounterSpells

let SwitchStrings (word : string,  a : string,  b : string) =
    if(word.ToLower().Contains(a)) then
        word.Replace(a, b)
    else if(word.ToLower().Contains(b)) then
        word.Replace(b, a)
    else 
        word


let TransposeIAndE (word : string) =
    SwitchStrings (word, "ie", "ei")

let ConfuseAnceAndEnce (word : string) =
    SwitchStrings(word, "ance", "ence")

let ConfuseAntAndEnt (word : string) =
    SwitchStrings(word, "ant", "ent")

        // todo: how will I handle the case issues

