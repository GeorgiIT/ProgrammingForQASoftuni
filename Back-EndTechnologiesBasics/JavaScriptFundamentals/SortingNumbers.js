function SortingNumbers(arr){
    arr.sort((a,b) => a - b);
    const result = [];

    while(arr.length > 0){
        let firstElement = arr.shift();
        let lastElement = arr.pop();
        result.push(firstElement);
        if(lastElement !== undefined){
            result.push(lastElement);
        }
    }
    return result;
}

arr = [1, 65, 3, 52, 48, 63, 31, -3, 18, 56]

SortingNumbers(arr)