function repeatStr(text, n){
    let result = "";
    for (let i = 0; i < n; i++) {
        result += text;
    }
    console.log(result)
}

repeatStr("abc", 3)