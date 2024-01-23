function ReverseArrayOfNums(n, elements) {
    let newArray = elements.slice(0, n);
    newArray.reverse();
    console.log(newArray.join(" "));
}

arr = [ 66, 43, 75, 89, 47]

ReverseArrayOfNums(2, arr)