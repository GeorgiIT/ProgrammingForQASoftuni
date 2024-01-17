function DigitsChecker(num){
    let sum = 0;
    areAllTheSame = true;
    let numbers = num.toString().split("");
    
    for (let index = 0; index < numbers.length; index++) {
        numbers.forEach(el =>{
            if(parseInt(el) != parseInt(numbers[index])){
                areAllTheSame = false
            };
        });
        sum += parseInt(numbers[index]);
    };

    console.log(areAllTheSame);
    console.log(sum);
}

DigitsChecker(22222);