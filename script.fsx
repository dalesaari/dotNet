let vowels = set ['a';'e';'i';'o';'u']

let convertToPigLatin (str: string) =
    let firstChar = str.[0]
    if vowels.Contains firstChar then
        str
    else
        str.[1..] + string firstChar + "ay"