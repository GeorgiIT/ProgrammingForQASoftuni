function PrintArrayWithNStep(arr, step){
    result = [];
    for (let index = 0; index < arr.length; index+=step) {
        result.push(arr[index])
    }
    return result;
}

arr = ['5','20','31','4','20']
PrintArrayWithNStep(arr, 2)