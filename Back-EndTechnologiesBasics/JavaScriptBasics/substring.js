function substring(text, startN, count){
    let newText = text.slice(startN, startN + count);
    console.log(newText);
}

substring('ASentence', 1, 8);