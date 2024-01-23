function SortingNames(arr){
    arr.sort();
    counter = 1;
    for(let name in arr){
        console.log(`${counter}.${arr[name]}`)
        counter++;
    }
}

names = ["John", "Bob", "Christina", "Ema"];

SortingNames(names)