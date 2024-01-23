function solve(wordString, templateString){
    const words = wordString.split(", ");

    for(const separateWord of words){
        templateString = templateString.replace("*".repeat(separateWord.length), separateWord)
    }
    console.log(templateString)
}

solve('great', 'softuni is ***** place for learning new programming languages')