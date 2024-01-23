function EvenAndOddSub(numbers){
    evenSum = 0
    oddSum = 0
    for(let i = 0; i <= numbers.length - 1; i++){
        if(numbers[i] % 2 == 0){
            evenSum += Number(numbers[i]);
        }
        else{
            oddSum += Number(numbers[i]);
        }
    }
    console.log(evenSum - oddSum);
}
nums = [1,2,3,4,5,6]
EvenAndOddSub(nums)