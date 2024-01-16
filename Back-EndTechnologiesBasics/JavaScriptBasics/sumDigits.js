function SumDigits(input){
    textInput = input.toString();
    let sum = 0;
    for (let i = 0; i < textInput.length; i++) {
        let digit = Number(textInput[i]);
        sum += digit;
    }
    console.log(sum); 
}
SumDigits(245678);