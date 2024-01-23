function ArayRotation(arr, index){
    for(let i = 0; i < index; i++){
        const firstElement = arr.shift();
        arr.push(firstElement);
    }
    console.log(arr.join(" "));
    
}

arr = [1,2,3,4,5]
ArayRotation(arr, 2)